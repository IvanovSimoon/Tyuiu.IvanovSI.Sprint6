using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IvanovSI.Sprint6.Task6.V10.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void button2_Click(object sender, EventArgs e)
        {
            string str = "w";
            textBoxOut_ISI.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_ISI_Click(object sender, EventArgs e)
        {
            FormAbout fromAbout = new FormAbout();
            fromAbout.ShowDialog();
        }

        private void buttonOpenFile_ISI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ISI.ShowDialog();
            openFilePath = openFileDialogTask_ISI.FileName;
            textBoxIn_ISI.Text = File.ReadAllText(openFilePath);
            groupBoxOut_ISI.Text = groupBoxOut_ISI.Text + " " + openFileDialogTask_ISI.FileName;
            buttonDone_ISI.Enabled = true;
        }
    }
}
