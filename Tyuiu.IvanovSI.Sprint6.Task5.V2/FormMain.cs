using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovSI.Sprint6.Task5.V2.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\seemoon\source\repos\Tyuiu.IvanovSI.Sprint6\Tyuiu.IvanovSI.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";
        private void buttonDone_ISI_Click(object sender, EventArgs e)
        {
            dataGridViewRes_ISI.ColumnCount = 2;
            dataGridViewRes_ISI.Columns[0].Width = 20;
            dataGridViewRes_ISI.Columns[1].Width = 50;

            this.chartDiag_ISI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_ISI.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_ISI.Series[0].Points.Clear();

            double [] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes_ISI.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_ISI.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_ISI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РПСб-23-1 Иванов С. И.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
