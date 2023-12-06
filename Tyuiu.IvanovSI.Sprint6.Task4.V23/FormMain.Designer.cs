
namespace Tyuiu.IvanovSI.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartFunction_ISI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_ISI = new System.Windows.Forms.Button();
            this.buttonSave_ISI = new System.Windows.Forms.Button();
            this.buttonHelp_ISI = new System.Windows.Forms.Button();
            this.groupBoxOut_ISI = new System.Windows.Forms.GroupBox();
            this.textBoxRes_ISI = new System.Windows.Forms.TextBox();
            this.panelTask_ISI = new System.Windows.Forms.Panel();
            this.groupBoxTask_ISI = new System.Windows.Forms.GroupBox();
            this.groupBoxData_ISI = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStart_ISI = new System.Windows.Forms.TextBox();
            this.textBoxEnd_ISI = new System.Windows.Forms.TextBox();
            this.labelVarA_ISI = new System.Windows.Forms.Label();
            this.labelVarB_ISI = new System.Windows.Forms.Label();
            this.panelRes_ISI = new System.Windows.Forms.Panel();
            this.panelFunction_ISI = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ISI)).BeginInit();
            this.groupBoxOut_ISI.SuspendLayout();
            this.panelTask_ISI.SuspendLayout();
            this.groupBoxTask_ISI.SuspendLayout();
            this.groupBoxData_ISI.SuspendLayout();
            this.panelRes_ISI.SuspendLayout();
            this.panelFunction_ISI.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_ISI
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_ISI.ChartAreas.Add(chartArea3);
            this.chartFunction_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartFunction_ISI.Legends.Add(legend3);
            this.chartFunction_ISI.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_ISI.Name = "chartFunction_ISI";
            this.chartFunction_ISI.Padding = new System.Windows.Forms.Padding(5);
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_ISI.Series.Add(series3);
            this.chartFunction_ISI.Size = new System.Drawing.Size(793, 478);
            this.chartFunction_ISI.TabIndex = 0;
            this.chartFunction_ISI.Text = "chart";
            title3.Name = "TitleFunction_ISI";
            title3.Text = "График функции ";
            this.chartFunction_ISI.Titles.Add(title3);
            // 
            // buttonDone_ISI
            // 
            this.buttonDone_ISI.Location = new System.Drawing.Point(744, 12);
            this.buttonDone_ISI.Name = "buttonDone_ISI";
            this.buttonDone_ISI.Size = new System.Drawing.Size(91, 65);
            this.buttonDone_ISI.TabIndex = 2;
            this.buttonDone_ISI.Text = "Выполнить";
            this.buttonDone_ISI.UseVisualStyleBackColor = true;
            this.buttonDone_ISI.Click += new System.EventHandler(this.buttonDone_ISI_Click);
            // 
            // buttonSave_ISI
            // 
            this.buttonSave_ISI.Location = new System.Drawing.Point(841, 12);
            this.buttonSave_ISI.Name = "buttonSave_ISI";
            this.buttonSave_ISI.Size = new System.Drawing.Size(91, 65);
            this.buttonSave_ISI.TabIndex = 2;
            this.buttonSave_ISI.Text = "Сохранить";
            this.buttonSave_ISI.UseVisualStyleBackColor = true;
            this.buttonSave_ISI.Click += new System.EventHandler(this.buttonSave_ISI_Click);
            // 
            // buttonHelp_ISI
            // 
            this.buttonHelp_ISI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ISI.Location = new System.Drawing.Point(938, 12);
            this.buttonHelp_ISI.Name = "buttonHelp_ISI";
            this.buttonHelp_ISI.Size = new System.Drawing.Size(91, 65);
            this.buttonHelp_ISI.TabIndex = 2;
            this.buttonHelp_ISI.Text = "Справка";
            this.buttonHelp_ISI.UseVisualStyleBackColor = true;
            this.buttonHelp_ISI.Click += new System.EventHandler(this.buttonHelp_ISI_Click);
            // 
            // groupBoxOut_ISI
            // 
            this.groupBoxOut_ISI.Controls.Add(this.textBoxRes_ISI);
            this.groupBoxOut_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_ISI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOut_ISI.Name = "groupBoxOut_ISI";
            this.groupBoxOut_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxOut_ISI.Size = new System.Drawing.Size(242, 468);
            this.groupBoxOut_ISI.TabIndex = 1;
            this.groupBoxOut_ISI.TabStop = false;
            this.groupBoxOut_ISI.Text = "Вывод:";
            // 
            // textBoxRes_ISI
            // 
            this.textBoxRes_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_ISI.Location = new System.Drawing.Point(5, 18);
            this.textBoxRes_ISI.Multiline = true;
            this.textBoxRes_ISI.Name = "textBoxRes_ISI";
            this.textBoxRes_ISI.ReadOnly = true;
            this.textBoxRes_ISI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_ISI.Size = new System.Drawing.Size(232, 445);
            this.textBoxRes_ISI.TabIndex = 0;
            // 
            // panelTask_ISI
            // 
            this.panelTask_ISI.Controls.Add(this.groupBoxData_ISI);
            this.panelTask_ISI.Controls.Add(this.groupBoxTask_ISI);
            this.panelTask_ISI.Controls.Add(this.buttonDone_ISI);
            this.panelTask_ISI.Controls.Add(this.buttonHelp_ISI);
            this.panelTask_ISI.Controls.Add(this.buttonSave_ISI);
            this.panelTask_ISI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ISI.Location = new System.Drawing.Point(0, 0);
            this.panelTask_ISI.Name = "panelTask_ISI";
            this.panelTask_ISI.Size = new System.Drawing.Size(1045, 88);
            this.panelTask_ISI.TabIndex = 3;
            // 
            // groupBoxTask_ISI
            // 
            this.groupBoxTask_ISI.Controls.Add(this.label1);
            this.groupBoxTask_ISI.Location = new System.Drawing.Point(5, 8);
            this.groupBoxTask_ISI.Name = "groupBoxTask_ISI";
            this.groupBoxTask_ISI.Size = new System.Drawing.Size(432, 69);
            this.groupBoxTask_ISI.TabIndex = 3;
            this.groupBoxTask_ISI.TabStop = false;
            this.groupBoxTask_ISI.Text = "Условие";
            // 
            // groupBoxData_ISI
            // 
            this.groupBoxData_ISI.Controls.Add(this.labelVarB_ISI);
            this.groupBoxData_ISI.Controls.Add(this.labelVarA_ISI);
            this.groupBoxData_ISI.Controls.Add(this.textBoxEnd_ISI);
            this.groupBoxData_ISI.Controls.Add(this.textBoxStart_ISI);
            this.groupBoxData_ISI.Location = new System.Drawing.Point(443, 8);
            this.groupBoxData_ISI.Name = "groupBoxData_ISI";
            this.groupBoxData_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxData_ISI.Size = new System.Drawing.Size(295, 69);
            this.groupBoxData_ISI.TabIndex = 3;
            this.groupBoxData_ISI.TabStop = false;
            this.groupBoxData_ISI.Text = "Ввод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Протабулировать функцию на заданном диавазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox. Построить график функции и сохранить в файл\r\nOutPutFileTask4V23.txt по на" +
    "жатию кнопки.";
            // 
            // textBoxStart_ISI
            // 
            this.textBoxStart_ISI.Location = new System.Drawing.Point(7, 33);
            this.textBoxStart_ISI.Name = "textBoxStart_ISI";
            this.textBoxStart_ISI.Size = new System.Drawing.Size(145, 20);
            this.textBoxStart_ISI.TabIndex = 0;
            // 
            // textBoxEnd_ISI
            // 
            this.textBoxEnd_ISI.Location = new System.Drawing.Point(158, 33);
            this.textBoxEnd_ISI.Name = "textBoxEnd_ISI";
            this.textBoxEnd_ISI.Size = new System.Drawing.Size(131, 20);
            this.textBoxEnd_ISI.TabIndex = 0;
            // 
            // labelVarA_ISI
            // 
            this.labelVarA_ISI.AutoSize = true;
            this.labelVarA_ISI.Location = new System.Drawing.Point(8, 18);
            this.labelVarA_ISI.Name = "labelVarA_ISI";
            this.labelVarA_ISI.Size = new System.Drawing.Size(67, 13);
            this.labelVarA_ISI.TabIndex = 0;
            this.labelVarA_ISI.Text = "Старт шага:\r\n";
            // 
            // labelVarB_ISI
            // 
            this.labelVarB_ISI.AutoSize = true;
            this.labelVarB_ISI.Location = new System.Drawing.Point(157, 18);
            this.labelVarB_ISI.Name = "labelVarB_ISI";
            this.labelVarB_ISI.Size = new System.Drawing.Size(69, 13);
            this.labelVarB_ISI.TabIndex = 0;
            this.labelVarB_ISI.Text = "Конец шага:\r\n";
            // 
            // panelRes_ISI
            // 
            this.panelRes_ISI.Controls.Add(this.groupBoxOut_ISI);
            this.panelRes_ISI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRes_ISI.Location = new System.Drawing.Point(0, 88);
            this.panelRes_ISI.Name = "panelRes_ISI";
            this.panelRes_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.panelRes_ISI.Size = new System.Drawing.Size(252, 478);
            this.panelRes_ISI.TabIndex = 1;
            // 
            // panelFunction_ISI
            // 
            this.panelFunction_ISI.Controls.Add(this.chartFunction_ISI);
            this.panelFunction_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_ISI.Location = new System.Drawing.Point(252, 88);
            this.panelFunction_ISI.Name = "panelFunction_ISI";
            this.panelFunction_ISI.Size = new System.Drawing.Size(793, 478);
            this.panelFunction_ISI.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 566);
            this.Controls.Add(this.panelFunction_ISI);
            this.Controls.Add(this.panelRes_ISI);
            this.Controls.Add(this.panelTask_ISI);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 | Иванов С. И.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ISI)).EndInit();
            this.groupBoxOut_ISI.ResumeLayout(false);
            this.groupBoxOut_ISI.PerformLayout();
            this.panelTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.PerformLayout();
            this.groupBoxData_ISI.ResumeLayout(false);
            this.groupBoxData_ISI.PerformLayout();
            this.panelRes_ISI.ResumeLayout(false);
            this.panelFunction_ISI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ISI;
        private System.Windows.Forms.Button buttonDone_ISI;
        private System.Windows.Forms.Button buttonSave_ISI;
        private System.Windows.Forms.Button buttonHelp_ISI;
        private System.Windows.Forms.GroupBox groupBoxOut_ISI;
        private System.Windows.Forms.TextBox textBoxRes_ISI;
        private System.Windows.Forms.Panel panelTask_ISI;
        private System.Windows.Forms.GroupBox groupBoxData_ISI;
        private System.Windows.Forms.Label labelVarB_ISI;
        private System.Windows.Forms.Label labelVarA_ISI;
        private System.Windows.Forms.TextBox textBoxEnd_ISI;
        private System.Windows.Forms.TextBox textBoxStart_ISI;
        private System.Windows.Forms.GroupBox groupBoxTask_ISI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRes_ISI;
        private System.Windows.Forms.Panel panelFunction_ISI;
    }
}

