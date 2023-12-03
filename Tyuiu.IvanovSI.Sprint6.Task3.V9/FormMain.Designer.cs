
namespace Tyuiu.IvanovSI.Sprint6.Task3.V9
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
            this.groupBoxTask_ISI = new System.Windows.Forms.GroupBox();
            this.groupBoxResData_ISI = new System.Windows.Forms.GroupBox();
            this.buttonHelp_ISI = new System.Windows.Forms.Button();
            this.buttonDone_ISI = new System.Windows.Forms.Button();
            this.dataGridViewTask_ISI = new System.Windows.Forms.DataGridView();
            this.textBoxResName_ISI = new System.Windows.Forms.TextBox();
            this.dataGridViewRes_ISI = new System.Windows.Forms.DataGridView();
            this.textBoxTask_ISI = new System.Windows.Forms.TextBox();
            this.groupBoxTask_ISI.SuspendLayout();
            this.groupBoxResData_ISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_ISI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_ISI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ISI
            // 
            this.groupBoxTask_ISI.Controls.Add(this.textBoxTask_ISI);
            this.groupBoxTask_ISI.Controls.Add(this.buttonHelp_ISI);
            this.groupBoxTask_ISI.Controls.Add(this.buttonDone_ISI);
            this.groupBoxTask_ISI.Controls.Add(this.dataGridViewTask_ISI);
            this.groupBoxTask_ISI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ISI.Name = "groupBoxTask_ISI";
            this.groupBoxTask_ISI.Size = new System.Drawing.Size(512, 271);
            this.groupBoxTask_ISI.TabIndex = 0;
            this.groupBoxTask_ISI.TabStop = false;
            this.groupBoxTask_ISI.Text = "Условие";
            // 
            // groupBoxResData_ISI
            // 
            this.groupBoxResData_ISI.Controls.Add(this.textBoxResName_ISI);
            this.groupBoxResData_ISI.Controls.Add(this.dataGridViewRes_ISI);
            this.groupBoxResData_ISI.Location = new System.Drawing.Point(531, 12);
            this.groupBoxResData_ISI.Name = "groupBoxResData_ISI";
            this.groupBoxResData_ISI.Size = new System.Drawing.Size(320, 271);
            this.groupBoxResData_ISI.TabIndex = 0;
            this.groupBoxResData_ISI.TabStop = false;
            this.groupBoxResData_ISI.Text = "Вывод данных";
            // 
            // buttonHelp_ISI
            // 
            this.buttonHelp_ISI.Location = new System.Drawing.Point(94, 234);
            this.buttonHelp_ISI.Name = "buttonHelp_ISI";
            this.buttonHelp_ISI.Size = new System.Drawing.Size(31, 31);
            this.buttonHelp_ISI.TabIndex = 1;
            this.buttonHelp_ISI.Text = "?";
            this.buttonHelp_ISI.UseVisualStyleBackColor = true;
            this.buttonHelp_ISI.Click += new System.EventHandler(this.buttonHelp_ISI_Click);
            // 
            // buttonDone_ISI
            // 
            this.buttonDone_ISI.Location = new System.Drawing.Point(6, 234);
            this.buttonDone_ISI.Name = "buttonDone_ISI";
            this.buttonDone_ISI.Size = new System.Drawing.Size(82, 31);
            this.buttonDone_ISI.TabIndex = 1;
            this.buttonDone_ISI.Text = "Выполнить";
            this.buttonDone_ISI.UseVisualStyleBackColor = true;
            this.buttonDone_ISI.Click += new System.EventHandler(this.buttonDone_ISI_Click);
            // 
            // dataGridViewTask_ISI
            // 
            this.dataGridViewTask_ISI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask_ISI.ColumnHeadersVisible = false;
            this.dataGridViewTask_ISI.Location = new System.Drawing.Point(266, 19);
            this.dataGridViewTask_ISI.Name = "dataGridViewTask_ISI";
            this.dataGridViewTask_ISI.ReadOnly = true;
            this.dataGridViewTask_ISI.RowHeadersVisible = false;
            this.dataGridViewTask_ISI.Size = new System.Drawing.Size(240, 246);
            this.dataGridViewTask_ISI.TabIndex = 0;
            // 
            // textBoxResName_ISI
            // 
            this.textBoxResName_ISI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResName_ISI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResName_ISI.Location = new System.Drawing.Point(8, 20);
            this.textBoxResName_ISI.Name = "textBoxResName_ISI";
            this.textBoxResName_ISI.Size = new System.Drawing.Size(60, 13);
            this.textBoxResName_ISI.TabIndex = 0;
            this.textBoxResName_ISI.Text = "Результат:";
            // 
            // dataGridViewRes_ISI
            // 
            this.dataGridViewRes_ISI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_ISI.ColumnHeadersVisible = false;
            this.dataGridViewRes_ISI.Location = new System.Drawing.Point(74, 19);
            this.dataGridViewRes_ISI.Name = "dataGridViewRes_ISI";
            this.dataGridViewRes_ISI.ReadOnly = true;
            this.dataGridViewRes_ISI.RowHeadersVisible = false;
            this.dataGridViewRes_ISI.Size = new System.Drawing.Size(240, 246);
            this.dataGridViewRes_ISI.TabIndex = 0;
            // 
            // textBoxTask_ISI
            // 
            this.textBoxTask_ISI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ISI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ISI.Location = new System.Drawing.Point(6, 20);
            this.textBoxTask_ISI.Multiline = true;
            this.textBoxTask_ISI.Name = "textBoxTask_ISI";
            this.textBoxTask_ISI.Size = new System.Drawing.Size(186, 147);
            this.textBoxTask_ISI.TabIndex = 0;
            this.textBoxTask_ISI.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце." +
    "\r\n\r\n-14  25  26  18  17\r\n  28  10   6  -2   4\r\n  30  25  -3  11 -10\r\n  11  32  -" +
    "5 -20  25\r\n   2 -18  11   8 -20";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 291);
            this.Controls.Add(this.groupBoxResData_ISI);
            this.Controls.Add(this.groupBoxTask_ISI);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Иванов С. И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.PerformLayout();
            this.groupBoxResData_ISI.ResumeLayout(false);
            this.groupBoxResData_ISI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_ISI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_ISI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ISI;
        private System.Windows.Forms.TextBox textBoxTask_ISI;
        private System.Windows.Forms.Button buttonHelp_ISI;
        private System.Windows.Forms.Button buttonDone_ISI;
        private System.Windows.Forms.DataGridView dataGridViewTask_ISI;
        private System.Windows.Forms.GroupBox groupBoxResData_ISI;
        private System.Windows.Forms.TextBox textBoxResName_ISI;
        private System.Windows.Forms.DataGridView dataGridViewRes_ISI;
    }
}

