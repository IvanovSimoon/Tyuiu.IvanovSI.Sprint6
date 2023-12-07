
namespace Tyuiu.IvanovSI.Sprint6.Task6.V10
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelFunc_ISI = new System.Windows.Forms.Panel();
            this.buttonHelp_ISI = new System.Windows.Forms.Button();
            this.buttonDone_ISI = new System.Windows.Forms.Button();
            this.buttonOpenFile_ISI = new System.Windows.Forms.Button();
            this.panelTask_ISI = new System.Windows.Forms.Panel();
            this.groupBoxTask_ISI = new System.Windows.Forms.GroupBox();
            this.labelTask_ISI = new System.Windows.Forms.Label();
            this.panelIn_ISI = new System.Windows.Forms.Panel();
            this.groupBoxIn_ISI = new System.Windows.Forms.GroupBox();
            this.textBoxIn_ISI = new System.Windows.Forms.TextBox();
            this.panelOut_ISI = new System.Windows.Forms.Panel();
            this.groupBoxOut_ISI = new System.Windows.Forms.GroupBox();
            this.textBoxOut_ISI = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_ISI = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_ISI = new System.Windows.Forms.ToolTip(this.components);
            this.panelFunc_ISI.SuspendLayout();
            this.panelTask_ISI.SuspendLayout();
            this.groupBoxTask_ISI.SuspendLayout();
            this.panelIn_ISI.SuspendLayout();
            this.groupBoxIn_ISI.SuspendLayout();
            this.panelOut_ISI.SuspendLayout();
            this.groupBoxOut_ISI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFunc_ISI
            // 
            this.panelFunc_ISI.Controls.Add(this.buttonHelp_ISI);
            this.panelFunc_ISI.Controls.Add(this.buttonDone_ISI);
            this.panelFunc_ISI.Controls.Add(this.buttonOpenFile_ISI);
            this.panelFunc_ISI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunc_ISI.Location = new System.Drawing.Point(0, 0);
            this.panelFunc_ISI.Name = "panelFunc_ISI";
            this.panelFunc_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.panelFunc_ISI.Size = new System.Drawing.Size(1003, 78);
            this.panelFunc_ISI.TabIndex = 0;
            // 
            // buttonHelp_ISI
            // 
            this.buttonHelp_ISI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ISI.Location = new System.Drawing.Point(896, 8);
            this.buttonHelp_ISI.Name = "buttonHelp_ISI";
            this.buttonHelp_ISI.Size = new System.Drawing.Size(94, 62);
            this.buttonHelp_ISI.TabIndex = 0;
            this.buttonHelp_ISI.Text = "Справка";
            this.toolTip_ISI.SetToolTip(this.buttonHelp_ISI, "Сведение о программе");
            this.buttonHelp_ISI.UseVisualStyleBackColor = true;
            this.buttonHelp_ISI.Click += new System.EventHandler(this.buttonHelp_ISI_Click);
            // 
            // buttonDone_ISI
            // 
            this.buttonDone_ISI.Location = new System.Drawing.Point(104, 8);
            this.buttonDone_ISI.Name = "buttonDone_ISI";
            this.buttonDone_ISI.Size = new System.Drawing.Size(94, 62);
            this.buttonDone_ISI.TabIndex = 0;
            this.buttonDone_ISI.Text = "Выполнить";
            this.toolTip_ISI.SetToolTip(this.buttonDone_ISI, "Производит поиск в файле слова в которых встречается w\r\nи выводит их в результати" +
        "рующую строку");
            this.buttonDone_ISI.UseVisualStyleBackColor = true;
            this.buttonDone_ISI.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOpenFile_ISI
            // 
            this.buttonOpenFile_ISI.Location = new System.Drawing.Point(4, 8);
            this.buttonOpenFile_ISI.Name = "buttonOpenFile_ISI";
            this.buttonOpenFile_ISI.Size = new System.Drawing.Size(94, 62);
            this.buttonOpenFile_ISI.TabIndex = 0;
            this.buttonOpenFile_ISI.Text = "Открыть файл";
            this.toolTip_ISI.SetToolTip(this.buttonOpenFile_ISI, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_ISI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ISI.Click += new System.EventHandler(this.buttonOpenFile_ISI_Click);
            // 
            // panelTask_ISI
            // 
            this.panelTask_ISI.Controls.Add(this.groupBoxTask_ISI);
            this.panelTask_ISI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ISI.Location = new System.Drawing.Point(0, 78);
            this.panelTask_ISI.Name = "panelTask_ISI";
            this.panelTask_ISI.Size = new System.Drawing.Size(1003, 89);
            this.panelTask_ISI.TabIndex = 1;
            // 
            // groupBoxTask_ISI
            // 
            this.groupBoxTask_ISI.Controls.Add(this.labelTask_ISI);
            this.groupBoxTask_ISI.Location = new System.Drawing.Point(3, 5);
            this.groupBoxTask_ISI.Name = "groupBoxTask_ISI";
            this.groupBoxTask_ISI.Size = new System.Drawing.Size(997, 77);
            this.groupBoxTask_ISI.TabIndex = 0;
            this.groupBoxTask_ISI.TabStop = false;
            this.groupBoxTask_ISI.Text = "Условие";
            // 
            // labelTask_ISI
            // 
            this.labelTask_ISI.AutoSize = true;
            this.labelTask_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTask_ISI.Location = new System.Drawing.Point(3, 16);
            this.labelTask_ISI.Name = "labelTask_ISI";
            this.labelTask_ISI.Size = new System.Drawing.Size(683, 26);
            this.labelTask_ISI.TabIndex = 0;
            this.labelTask_ISI.Text = resources.GetString("labelTask_ISI.Text");
            // 
            // panelIn_ISI
            // 
            this.panelIn_ISI.Controls.Add(this.groupBoxIn_ISI);
            this.panelIn_ISI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIn_ISI.Location = new System.Drawing.Point(0, 167);
            this.panelIn_ISI.Name = "panelIn_ISI";
            this.panelIn_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.panelIn_ISI.Size = new System.Drawing.Size(495, 423);
            this.panelIn_ISI.TabIndex = 2;
            // 
            // groupBoxIn_ISI
            // 
            this.groupBoxIn_ISI.Controls.Add(this.textBoxIn_ISI);
            this.groupBoxIn_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_ISI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxIn_ISI.Name = "groupBoxIn_ISI";
            this.groupBoxIn_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxIn_ISI.Size = new System.Drawing.Size(485, 413);
            this.groupBoxIn_ISI.TabIndex = 0;
            this.groupBoxIn_ISI.TabStop = false;
            this.groupBoxIn_ISI.Text = "Ввод";
            // 
            // textBoxIn_ISI
            // 
            this.textBoxIn_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_ISI.Location = new System.Drawing.Point(5, 18);
            this.textBoxIn_ISI.Multiline = true;
            this.textBoxIn_ISI.Name = "textBoxIn_ISI";
            this.textBoxIn_ISI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_ISI.Size = new System.Drawing.Size(475, 390);
            this.textBoxIn_ISI.TabIndex = 0;
            // 
            // panelOut_ISI
            // 
            this.panelOut_ISI.Controls.Add(this.groupBoxOut_ISI);
            this.panelOut_ISI.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOut_ISI.Location = new System.Drawing.Point(494, 167);
            this.panelOut_ISI.Name = "panelOut_ISI";
            this.panelOut_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.panelOut_ISI.Size = new System.Drawing.Size(509, 423);
            this.panelOut_ISI.TabIndex = 2;
            // 
            // groupBoxOut_ISI
            // 
            this.groupBoxOut_ISI.Controls.Add(this.textBoxOut_ISI);
            this.groupBoxOut_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_ISI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOut_ISI.Name = "groupBoxOut_ISI";
            this.groupBoxOut_ISI.Size = new System.Drawing.Size(499, 413);
            this.groupBoxOut_ISI.TabIndex = 0;
            this.groupBoxOut_ISI.TabStop = false;
            this.groupBoxOut_ISI.Text = "Вывод";
            // 
            // textBoxOut_ISI
            // 
            this.textBoxOut_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_ISI.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut_ISI.Multiline = true;
            this.textBoxOut_ISI.Name = "textBoxOut_ISI";
            this.textBoxOut_ISI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_ISI.Size = new System.Drawing.Size(493, 394);
            this.textBoxOut_ISI.TabIndex = 1;
            // 
            // openFileDialogTask_ISI
            // 
            this.openFileDialogTask_ISI.FileName = "openFileDialogTask";
            // 
            // toolTip_ISI
            // 
            this.toolTip_ISI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_ISI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 590);
            this.Controls.Add(this.panelOut_ISI);
            this.Controls.Add(this.panelIn_ISI);
            this.Controls.Add(this.panelTask_ISI);
            this.Controls.Add(this.panelFunc_ISI);
            this.MinimumSize = new System.Drawing.Size(1019, 629);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 10 | Иванов С. И.";
            this.panelFunc_ISI.ResumeLayout(false);
            this.panelTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.PerformLayout();
            this.panelIn_ISI.ResumeLayout(false);
            this.groupBoxIn_ISI.ResumeLayout(false);
            this.groupBoxIn_ISI.PerformLayout();
            this.panelOut_ISI.ResumeLayout(false);
            this.groupBoxOut_ISI.ResumeLayout(false);
            this.groupBoxOut_ISI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFunc_ISI;
        private System.Windows.Forms.Panel panelTask_ISI;
        private System.Windows.Forms.GroupBox groupBoxTask_ISI;
        private System.Windows.Forms.Label labelTask_ISI;
        private System.Windows.Forms.Panel panelIn_ISI;
        private System.Windows.Forms.GroupBox groupBoxIn_ISI;
        private System.Windows.Forms.TextBox textBoxIn_ISI;
        private System.Windows.Forms.Panel panelOut_ISI;
        private System.Windows.Forms.GroupBox groupBoxOut_ISI;
        private System.Windows.Forms.TextBox textBoxOut_ISI;
        private System.Windows.Forms.Button buttonHelp_ISI;
        private System.Windows.Forms.ToolTip toolTip_ISI;
        private System.Windows.Forms.Button buttonDone_ISI;
        private System.Windows.Forms.Button buttonOpenFile_ISI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ISI;
    }
}

