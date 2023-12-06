using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovSI.Sprint6.Task4.V23.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_ISI_Click(object sender, EventArgs e)
        {
            try
            {
                
                int startstep = Convert.ToInt32(textBoxStart_ISI.Text);
                int stopstep = Convert.ToInt32(textBoxEnd_ISI.Text);

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);

                this.chartFunction_ISI.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_ISI.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes_ISI.Text = "";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_ISI.Series[0].Points.AddXY(startstep, valueArray[i]);
                    textBoxRes_ISI.AppendText(valueArray[i] + Environment.NewLine);
                    startstep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РПСб-23-1 Иванов С. И.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_ISI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
                File.WriteAllText(path, textBoxRes_ISI.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранён успешно!\n Открыть его в блакноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
