using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovSI.Sprint6.Task7.V4.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        
        static string openFilePath;

        DataService ds = new DataService();

        
        private void buttonOpenFile_ISI_Click(object sender, EventArgs e)
        {
            openFileDialog_ISI.ShowDialog();
            openFilePath = openFileDialog_ISI.FileName;

            int[,] matrix = ds.GetMatrix(openFilePath);

            dataGridViewIn_ISI.RowCount = matrix.GetLength(0);
            dataGridViewIn_ISI.ColumnCount = matrix.GetLength(1);
            dataGridViewOut_ISI.RowCount = matrix.GetLength(0);
            dataGridViewOut_ISI.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridViewIn_ISI.Columns[i].Width = 25;
                dataGridViewOut_ISI.Columns[i].Width = 25;
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    dataGridViewIn_ISI.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonDone_ISI.Enabled = true;
        }

        private void buttonDone_ISI_Click(object sender, EventArgs e)
        {
            string path = @"C:\DataSprint6\InPutFileTask7V4.csv";
            int[,] matrix = ds.GetMatrix(path);

            for (int r = 0; r < dataGridViewOut_ISI.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewOut_ISI.ColumnCount; c++)
                {
                    if ((r == 1) && (matrix[r,c] != 0) &&(matrix[r, c] % 4 == 0))
                        dataGridViewOut_ISI.Rows[r].Cells[c].Value = 4;
                    else
                        dataGridViewOut_ISI.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonSave_ISI.Enabled = true;
        }

        private void buttonSave_ISI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ISI.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_ISI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ISI.ShowDialog();

            string path = saveFileDialogMatrix_ISI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
                File.Delete(path);

            int rows = dataGridViewOut_ISI.RowCount;
            int columns = dataGridViewOut_ISI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str += dataGridViewOut_ISI.Rows[i].Cells[j].Value + ";";
                    else
                        str += dataGridViewOut_ISI.Rows[i].Cells[j].Value;

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
