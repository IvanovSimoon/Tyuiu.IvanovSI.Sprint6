using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovSI.Sprint6.Task3.V9.Lib;
namespace Tyuiu.IvanovSI.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {-14, 25, 26, 18, 17},
                                         {28, 10, 6, -2, 4},
                                         {30, 25, -3, 11, -10},
                                         {11, 32, -5, -20, 25},
                                         {2, -18, 11, 8, -20} };
        private void buttonDone_ISI_Click(object sender, EventArgs e)
        {
            int[,] mas = ds.Calculate(mtrx);

            int rows = mas.GetLength(0);
            int cols = mas.GetLength(1);

            dataGridViewRes_ISI.ColumnCount = cols;
            dataGridViewRes_ISI.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewRes_ISI.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewRes_ISI.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);

            dataGridViewTask_ISI.ColumnCount = cols;
            dataGridViewTask_ISI.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewTask_ISI.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTask_ISI.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РПСб-23-1 Иванов С. И.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
