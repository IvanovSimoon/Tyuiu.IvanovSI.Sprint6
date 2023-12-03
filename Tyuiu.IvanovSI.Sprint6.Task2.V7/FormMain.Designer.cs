
namespace Tyuiu.IvanovSI.Sprint6.Task2.V7
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
            this.groupBoxTask_ISI = new System.Windows.Forms.GroupBox();
            this.groupBoxDataStep_ISI = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxRes_ISI = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_ISI = new System.Windows.Forms.DataGridView();
            this.textBoxStartData_ISI = new System.Windows.Forms.TextBox();
            this.textBoxEndData_ISI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStartName_ISI = new System.Windows.Forms.TextBox();
            this.textBoxEndName_ISI = new System.Windows.Forms.TextBox();
            this.chartFunction_ISI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTaskText_ISI = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_ISI = new System.Windows.Forms.PictureBox();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_ISI.SuspendLayout();
            this.groupBoxDataStep_ISI.SuspendLayout();
            this.groupBoxRes_ISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_ISI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ISI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ISI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ISI
            // 
            this.groupBoxTask_ISI.Controls.Add(this.pictureBoxFormula_ISI);
            this.groupBoxTask_ISI.Controls.Add(this.textBoxTaskText_ISI);
            this.groupBoxTask_ISI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ISI.Name = "groupBoxTask_ISI";
            this.groupBoxTask_ISI.Size = new System.Drawing.Size(524, 287);
            this.groupBoxTask_ISI.TabIndex = 0;
            this.groupBoxTask_ISI.TabStop = false;
            this.groupBoxTask_ISI.Text = "Условие";
            // 
            // groupBoxDataStep_ISI
            // 
            this.groupBoxDataStep_ISI.Controls.Add(this.textBoxEndName_ISI);
            this.groupBoxDataStep_ISI.Controls.Add(this.textBoxEndData_ISI);
            this.groupBoxDataStep_ISI.Controls.Add(this.textBoxStartName_ISI);
            this.groupBoxDataStep_ISI.Controls.Add(this.textBoxStartData_ISI);
            this.groupBoxDataStep_ISI.Controls.Add(this.groupBox1);
            this.groupBoxDataStep_ISI.Location = new System.Drawing.Point(12, 305);
            this.groupBoxDataStep_ISI.Name = "groupBoxDataStep_ISI";
            this.groupBoxDataStep_ISI.Size = new System.Drawing.Size(304, 74);
            this.groupBoxDataStep_ISI.TabIndex = 0;
            this.groupBoxDataStep_ISI.TabStop = false;
            this.groupBoxDataStep_ISI.Text = "Ввод данных";
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(322, 315);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(85, 63);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone.Location = new System.Drawing.Point(413, 315);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(123, 63);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // groupBoxRes_ISI
            // 
            this.groupBoxRes_ISI.Controls.Add(this.chartFunction_ISI);
            this.groupBoxRes_ISI.Controls.Add(this.dataGridViewRes_ISI);
            this.groupBoxRes_ISI.Location = new System.Drawing.Point(542, 12);
            this.groupBoxRes_ISI.Name = "groupBoxRes_ISI";
            this.groupBoxRes_ISI.Size = new System.Drawing.Size(619, 366);
            this.groupBoxRes_ISI.TabIndex = 0;
            this.groupBoxRes_ISI.TabStop = false;
            this.groupBoxRes_ISI.Text = "Вывод данных";
            // 
            // dataGridViewRes_ISI
            // 
            this.dataGridViewRes_ISI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_ISI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewRes_ISI.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewRes_ISI.Name = "dataGridViewRes_ISI";
            this.dataGridViewRes_ISI.RowHeadersVisible = false;
            this.dataGridViewRes_ISI.Size = new System.Drawing.Size(133, 341);
            this.dataGridViewRes_ISI.TabIndex = 0;
            // 
            // textBoxStartData_ISI
            // 
            this.textBoxStartData_ISI.Location = new System.Drawing.Point(4, 40);
            this.textBoxStartData_ISI.Name = "textBoxStartData_ISI";
            this.textBoxStartData_ISI.Size = new System.Drawing.Size(144, 20);
            this.textBoxStartData_ISI.TabIndex = 0;
            // 
            // textBoxEndData_ISI
            // 
            this.textBoxEndData_ISI.Location = new System.Drawing.Point(154, 40);
            this.textBoxEndData_ISI.Name = "textBoxEndData_ISI";
            this.textBoxEndData_ISI.Size = new System.Drawing.Size(144, 20);
            this.textBoxEndData_ISI.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, -306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // textBoxStartName_ISI
            // 
            this.textBoxStartName_ISI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStartName_ISI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartName_ISI.Location = new System.Drawing.Point(6, 24);
            this.textBoxStartName_ISI.Name = "textBoxStartName_ISI";
            this.textBoxStartName_ISI.Size = new System.Drawing.Size(144, 13);
            this.textBoxStartName_ISI.TabIndex = 0;
            this.textBoxStartName_ISI.Text = "Старт шага:";
            // 
            // textBoxEndName_ISI
            // 
            this.textBoxEndName_ISI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEndName_ISI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndName_ISI.Location = new System.Drawing.Point(156, 24);
            this.textBoxEndName_ISI.Name = "textBoxEndName_ISI";
            this.textBoxEndName_ISI.Size = new System.Drawing.Size(144, 13);
            this.textBoxEndName_ISI.TabIndex = 0;
            this.textBoxEndName_ISI.Text = "Конец шага:";
            // 
            // chartFunction_ISI
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_ISI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_ISI.Legends.Add(legend3);
            this.chartFunction_ISI.Location = new System.Drawing.Point(145, 19);
            this.chartFunction_ISI.Name = "chartFunction_ISI";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_ISI.Series.Add(series3);
            this.chartFunction_ISI.Size = new System.Drawing.Size(468, 341);
            this.chartFunction_ISI.TabIndex = 1;
            this.chartFunction_ISI.Text = "chart1";
            // 
            // textBoxTaskText_ISI
            // 
            this.textBoxTaskText_ISI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTaskText_ISI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskText_ISI.Location = new System.Drawing.Point(6, 19);
            this.textBoxTaskText_ISI.Multiline = true;
            this.textBoxTaskText_ISI.Name = "textBoxTaskText_ISI";
            this.textBoxTaskText_ISI.Size = new System.Drawing.Size(512, 37);
            this.textBoxTaskText_ISI.TabIndex = 0;
            this.textBoxTaskText_ISI.Text = "Протабулировать функцию, изображонную на картинке, на заданном диапазоне\r\nРезульт" +
    "ат вывести в DataGridView и построить график функции.\r\n";
            // 
            // pictureBoxFormula_ISI
            // 
            this.pictureBoxFormula_ISI.Image = global::Tyuiu.IvanovSI.Sprint6.Task2.V7.Properties.Resources._213123123;
            this.pictureBoxFormula_ISI.Location = new System.Drawing.Point(0, 62);
            this.pictureBoxFormula_ISI.Name = "pictureBoxFormula_ISI";
            this.pictureBoxFormula_ISI.Size = new System.Drawing.Size(250, 41);
            this.pictureBoxFormula_ISI.TabIndex = 1;
            this.pictureBoxFormula_ISI.TabStop = false;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 390);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxDataStep_ISI);
            this.Controls.Add(this.groupBoxRes_ISI);
            this.Controls.Add(this.groupBoxTask_ISI);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 7 | Иванов С. И.";
            this.groupBoxTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.PerformLayout();
            this.groupBoxDataStep_ISI.ResumeLayout(false);
            this.groupBoxDataStep_ISI.PerformLayout();
            this.groupBoxRes_ISI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_ISI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ISI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ISI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ISI;
        private System.Windows.Forms.GroupBox groupBoxDataStep_ISI;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxRes_ISI;
        private System.Windows.Forms.DataGridView dataGridViewRes_ISI;
        private System.Windows.Forms.TextBox textBoxEndName_ISI;
        private System.Windows.Forms.TextBox textBoxEndData_ISI;
        private System.Windows.Forms.TextBox textBoxStartName_ISI;
        private System.Windows.Forms.TextBox textBoxStartData_ISI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ISI;
        private System.Windows.Forms.PictureBox pictureBoxFormula_ISI;
        private System.Windows.Forms.TextBox textBoxTaskText_ISI;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

