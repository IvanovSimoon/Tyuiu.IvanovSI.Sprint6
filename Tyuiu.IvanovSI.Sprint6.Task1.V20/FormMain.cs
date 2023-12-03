using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovSI.Sprint6.Task1.V20.Lib;
namespace Tyuiu.IvanovSI.Sprint6.Task1.V20
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

                string strline;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);

                textBoxRes_ISI.Text = "";
                textBoxRes_ISI.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxRes_ISI.AppendText("|    X     |    F(x)    |" + Environment.NewLine);  
                textBoxRes_ISI.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     |  {1, 6:f2}    | ", startstep, valueArray[i]);
                    textBoxRes_ISI.AppendText(strline + Environment.NewLine);
                    startstep++;
                }

                textBoxRes_ISI.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РПСб-23-1 Иванов С. И.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
