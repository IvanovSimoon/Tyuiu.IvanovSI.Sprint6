
namespace Tyuiu.IvanovSI.Sprint6.Task5.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_ISI = new System.Windows.Forms.Panel();
            this.panelData_ISI = new System.Windows.Forms.Panel();
            this.panelFunction_ISI = new System.Windows.Forms.Panel();
            this.groupBoxTask_ISI = new System.Windows.Forms.GroupBox();
            this.labelTask_ISI = new System.Windows.Forms.Label();
            this.buttonDone_ISI = new System.Windows.Forms.Button();
            this.buttonOpen_ISI = new System.Windows.Forms.Button();
            this.buttonHelp_ISI = new System.Windows.Forms.Button();
            this.groupBoxRes_ISI = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_ISI = new System.Windows.Forms.DataGridView();
            this.chartDiag_ISI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask_ISI.SuspendLayout();
            this.panelData_ISI.SuspendLayout();
            this.panelFunction_ISI.SuspendLayout();
            this.groupBoxTask_ISI.SuspendLayout();
            this.groupBoxRes_ISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_ISI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_ISI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_ISI
            // 
            this.panelTask_ISI.Controls.Add(this.buttonHelp_ISI);
            this.panelTask_ISI.Controls.Add(this.buttonOpen_ISI);
            this.panelTask_ISI.Controls.Add(this.buttonDone_ISI);
            this.panelTask_ISI.Controls.Add(this.groupBoxTask_ISI);
            this.panelTask_ISI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ISI.Location = new System.Drawing.Point(0, 0);
            this.panelTask_ISI.Name = "panelTask_ISI";
            this.panelTask_ISI.Size = new System.Drawing.Size(800, 83);
            this.panelTask_ISI.TabIndex = 0;
            // 
            // panelData_ISI
            // 
            this.panelData_ISI.Controls.Add(this.groupBoxRes_ISI);
            this.panelData_ISI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelData_ISI.Location = new System.Drawing.Point(0, 83);
            this.panelData_ISI.Name = "panelData_ISI";
            this.panelData_ISI.Size = new System.Drawing.Size(200, 428);
            this.panelData_ISI.TabIndex = 1;
            // 
            // panelFunction_ISI
            // 
            this.panelFunction_ISI.Controls.Add(this.chartDiag_ISI);
            this.panelFunction_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_ISI.Location = new System.Drawing.Point(200, 83);
            this.panelFunction_ISI.Name = "panelFunction_ISI";
            this.panelFunction_ISI.Size = new System.Drawing.Size(600, 428);
            this.panelFunction_ISI.TabIndex = 2;
            // 
            // groupBoxTask_ISI
            // 
            this.groupBoxTask_ISI.Controls.Add(this.labelTask_ISI);
            this.groupBoxTask_ISI.Location = new System.Drawing.Point(12, 6);
            this.groupBoxTask_ISI.Name = "groupBoxTask_ISI";
            this.groupBoxTask_ISI.Size = new System.Drawing.Size(456, 71);
            this.groupBoxTask_ISI.TabIndex = 0;
            this.groupBoxTask_ISI.TabStop = false;
            this.groupBoxTask_ISI.Text = "Условие";
            // 
            // labelTask_ISI
            // 
            this.labelTask_ISI.AutoSize = true;
            this.labelTask_ISI.Location = new System.Drawing.Point(7, 20);
            this.labelTask_ISI.Name = "labelTask_ISI";
            this.labelTask_ISI.Size = new System.Drawing.Size(383, 39);
            this.labelTask_ISI.TabIndex = 0;
            this.labelTask_ISI.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView. \r\nВывести" +
    " все отрицательные числа. \r\nПостроить диаграмму по этим значениям.";
            // 
            // buttonDone_ISI
            // 
            this.buttonDone_ISI.Location = new System.Drawing.Point(475, 12);
            this.buttonDone_ISI.Name = "buttonDone_ISI";
            this.buttonDone_ISI.Size = new System.Drawing.Size(99, 65);
            this.buttonDone_ISI.TabIndex = 1;
            this.buttonDone_ISI.Text = "Выполнить";
            this.buttonDone_ISI.UseVisualStyleBackColor = true;
            this.buttonDone_ISI.Click += new System.EventHandler(this.buttonDone_ISI_Click);
            // 
            // buttonOpen_ISI
            // 
            this.buttonOpen_ISI.Location = new System.Drawing.Point(580, 12);
            this.buttonOpen_ISI.Name = "buttonOpen_ISI";
            this.buttonOpen_ISI.Size = new System.Drawing.Size(99, 65);
            this.buttonOpen_ISI.TabIndex = 1;
            this.buttonOpen_ISI.Text = "Открыть файл";
            this.buttonOpen_ISI.UseVisualStyleBackColor = true;
            this.buttonOpen_ISI.Click += new System.EventHandler(this.buttonOpen_ISI_Click);
            // 
            // buttonHelp_ISI
            // 
            this.buttonHelp_ISI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ISI.Location = new System.Drawing.Point(685, 12);
            this.buttonHelp_ISI.Name = "buttonHelp_ISI";
            this.buttonHelp_ISI.Size = new System.Drawing.Size(99, 65);
            this.buttonHelp_ISI.TabIndex = 1;
            this.buttonHelp_ISI.Text = "Справка";
            this.buttonHelp_ISI.UseVisualStyleBackColor = true;
            this.buttonHelp_ISI.Click += new System.EventHandler(this.buttonHelp_ISI_Click);
            // 
            // groupBoxRes_ISI
            // 
            this.groupBoxRes_ISI.Controls.Add(this.dataGridViewRes_ISI);
            this.groupBoxRes_ISI.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRes_ISI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_ISI.Name = "groupBoxRes_ISI";
            this.groupBoxRes_ISI.Size = new System.Drawing.Size(191, 428);
            this.groupBoxRes_ISI.TabIndex = 0;
            this.groupBoxRes_ISI.TabStop = false;
            this.groupBoxRes_ISI.Text = "Вывод данных";
            // 
            // dataGridViewRes_ISI
            // 
            this.dataGridViewRes_ISI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_ISI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRes_ISI.Name = "dataGridViewRes_ISI";
            this.dataGridViewRes_ISI.Size = new System.Drawing.Size(185, 409);
            this.dataGridViewRes_ISI.TabIndex = 0;
            // 
            // chartDiag_ISI
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiag_ISI.ChartAreas.Add(chartArea4);
            this.chartDiag_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartDiag_ISI.Legends.Add(legend4);
            this.chartDiag_ISI.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_ISI.Name = "chartDiag_ISI";
            this.chartDiag_ISI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiag_ISI.Series.Add(series4);
            this.chartDiag_ISI.Size = new System.Drawing.Size(600, 428);
            this.chartDiag_ISI.TabIndex = 0;
            this.chartDiag_ISI.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.panelFunction_ISI);
            this.Controls.Add(this.panelData_ISI);
            this.Controls.Add(this.panelTask_ISI);
            this.MinimumSize = new System.Drawing.Size(816, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 2 | Иванов С. И.";
            this.panelTask_ISI.ResumeLayout(false);
            this.panelData_ISI.ResumeLayout(false);
            this.panelFunction_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.PerformLayout();
            this.groupBoxRes_ISI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_ISI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_ISI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_ISI;
        private System.Windows.Forms.Button buttonHelp_ISI;
        private System.Windows.Forms.Button buttonOpen_ISI;
        private System.Windows.Forms.Button buttonDone_ISI;
        private System.Windows.Forms.GroupBox groupBoxTask_ISI;
        private System.Windows.Forms.Label labelTask_ISI;
        private System.Windows.Forms.Panel panelData_ISI;
        private System.Windows.Forms.GroupBox groupBoxRes_ISI;
        private System.Windows.Forms.DataGridView dataGridViewRes_ISI;
        private System.Windows.Forms.Panel panelFunction_ISI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_ISI;
    }
}

