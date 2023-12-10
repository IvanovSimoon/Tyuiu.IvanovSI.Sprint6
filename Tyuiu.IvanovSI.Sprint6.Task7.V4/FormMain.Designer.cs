
namespace Tyuiu.IvanovSI.Sprint6.Task7.V4
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
            this.panelButtons_ISI = new System.Windows.Forms.Panel();
            this.panelTask_ISI = new System.Windows.Forms.Panel();
            this.groupBoxTask_ISI = new System.Windows.Forms.GroupBox();
            this.labelTask_ISI = new System.Windows.Forms.Label();
            this.openFileDialog_ISI = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_ISI = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainerData_ISI = new System.Windows.Forms.SplitContainer();
            this.groupBoxIn_ISI = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_ISI = new System.Windows.Forms.DataGridView();
            this.groupBoxOut_ISI = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_ISI = new System.Windows.Forms.DataGridView();
            this.saveFileDialogMatrix_ISI = new System.Windows.Forms.SaveFileDialog();
            this.buttonHelp_ISI = new System.Windows.Forms.Button();
            this.buttonSave_ISI = new System.Windows.Forms.Button();
            this.buttonDone_ISI = new System.Windows.Forms.Button();
            this.buttonOpenFile_ISI = new System.Windows.Forms.Button();
            this.panelButtons_ISI.SuspendLayout();
            this.panelTask_ISI.SuspendLayout();
            this.groupBoxTask_ISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData_ISI)).BeginInit();
            this.splitContainerData_ISI.Panel1.SuspendLayout();
            this.splitContainerData_ISI.Panel2.SuspendLayout();
            this.splitContainerData_ISI.SuspendLayout();
            this.groupBoxIn_ISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ISI)).BeginInit();
            this.groupBoxOut_ISI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_ISI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_ISI
            // 
            this.panelButtons_ISI.Controls.Add(this.buttonHelp_ISI);
            this.panelButtons_ISI.Controls.Add(this.buttonSave_ISI);
            this.panelButtons_ISI.Controls.Add(this.buttonDone_ISI);
            this.panelButtons_ISI.Controls.Add(this.buttonOpenFile_ISI);
            this.panelButtons_ISI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_ISI.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_ISI.Name = "panelButtons_ISI";
            this.panelButtons_ISI.Size = new System.Drawing.Size(800, 84);
            this.panelButtons_ISI.TabIndex = 0;
            // 
            // panelTask_ISI
            // 
            this.panelTask_ISI.Controls.Add(this.groupBoxTask_ISI);
            this.panelTask_ISI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ISI.Location = new System.Drawing.Point(0, 84);
            this.panelTask_ISI.Name = "panelTask_ISI";
            this.panelTask_ISI.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_ISI.Size = new System.Drawing.Size(800, 86);
            this.panelTask_ISI.TabIndex = 0;
            // 
            // groupBoxTask_ISI
            // 
            this.groupBoxTask_ISI.Controls.Add(this.labelTask_ISI);
            this.groupBoxTask_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_ISI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_ISI.Name = "groupBoxTask_ISI";
            this.groupBoxTask_ISI.Size = new System.Drawing.Size(790, 76);
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
            this.labelTask_ISI.Size = new System.Drawing.Size(766, 39);
            this.labelTask_ISI.TabIndex = 0;
            this.labelTask_ISI.Text = resources.GetString("labelTask_ISI.Text");
            // 
            // openFileDialog_ISI
            // 
            this.openFileDialog_ISI.FileName = "openFileDialog1";
            // 
            // splitContainerData_ISI
            // 
            this.splitContainerData_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerData_ISI.Location = new System.Drawing.Point(0, 170);
            this.splitContainerData_ISI.Name = "splitContainerData_ISI";
            // 
            // splitContainerData_ISI.Panel1
            // 
            this.splitContainerData_ISI.Panel1.Controls.Add(this.groupBoxIn_ISI);
            this.splitContainerData_ISI.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainerData_ISI.Panel2
            // 
            this.splitContainerData_ISI.Panel2.Controls.Add(this.groupBoxOut_ISI);
            this.splitContainerData_ISI.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerData_ISI.Size = new System.Drawing.Size(800, 280);
            this.splitContainerData_ISI.SplitterDistance = 388;
            this.splitContainerData_ISI.TabIndex = 2;
            // 
            // groupBoxIn_ISI
            // 
            this.groupBoxIn_ISI.Controls.Add(this.dataGridViewIn_ISI);
            this.groupBoxIn_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_ISI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxIn_ISI.Name = "groupBoxIn_ISI";
            this.groupBoxIn_ISI.Size = new System.Drawing.Size(378, 270);
            this.groupBoxIn_ISI.TabIndex = 0;
            this.groupBoxIn_ISI.TabStop = false;
            this.groupBoxIn_ISI.Text = "Ввод";
            // 
            // dataGridViewIn_ISI
            // 
            this.dataGridViewIn_ISI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_ISI.ColumnHeadersVisible = false;
            this.dataGridViewIn_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_ISI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_ISI.Name = "dataGridViewIn_ISI";
            this.dataGridViewIn_ISI.RowHeadersVisible = false;
            this.dataGridViewIn_ISI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewIn_ISI.Size = new System.Drawing.Size(372, 251);
            this.dataGridViewIn_ISI.TabIndex = 0;
            // 
            // groupBoxOut_ISI
            // 
            this.groupBoxOut_ISI.Controls.Add(this.dataGridViewOut_ISI);
            this.groupBoxOut_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_ISI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOut_ISI.Name = "groupBoxOut_ISI";
            this.groupBoxOut_ISI.Size = new System.Drawing.Size(398, 270);
            this.groupBoxOut_ISI.TabIndex = 0;
            this.groupBoxOut_ISI.TabStop = false;
            this.groupBoxOut_ISI.Text = "Вывод";
            // 
            // dataGridViewOut_ISI
            // 
            this.dataGridViewOut_ISI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_ISI.ColumnHeadersVisible = false;
            this.dataGridViewOut_ISI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_ISI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_ISI.Name = "dataGridViewOut_ISI";
            this.dataGridViewOut_ISI.RowHeadersVisible = false;
            this.dataGridViewOut_ISI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOut_ISI.Size = new System.Drawing.Size(392, 251);
            this.dataGridViewOut_ISI.TabIndex = 0;
            // 
            // buttonHelp_ISI
            // 
            this.buttonHelp_ISI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ISI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ISI.Image = global::Tyuiu.IvanovSI.Sprint6.Task7.V4.Properties.Resources.help;
            this.buttonHelp_ISI.Location = new System.Drawing.Point(688, 3);
            this.buttonHelp_ISI.Name = "buttonHelp_ISI";
            this.buttonHelp_ISI.Size = new System.Drawing.Size(107, 75);
            this.buttonHelp_ISI.TabIndex = 0;
            this.toolTip_ISI.SetToolTip(this.buttonHelp_ISI, "Сведения о программе");
            this.buttonHelp_ISI.UseVisualStyleBackColor = true;
            this.buttonHelp_ISI.Click += new System.EventHandler(this.buttonHelp_ISI_Click);
            // 
            // buttonSave_ISI
            // 
            this.buttonSave_ISI.Enabled = false;
            this.buttonSave_ISI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_ISI.Image = global::Tyuiu.IvanovSI.Sprint6.Task7.V4.Properties.Resources.page_save;
            this.buttonSave_ISI.Location = new System.Drawing.Point(229, 3);
            this.buttonSave_ISI.Name = "buttonSave_ISI";
            this.buttonSave_ISI.Size = new System.Drawing.Size(107, 75);
            this.buttonSave_ISI.TabIndex = 0;
            this.buttonSave_ISI.UseVisualStyleBackColor = true;
            this.buttonSave_ISI.Click += new System.EventHandler(this.buttonSave_ISI_Click);
            // 
            // buttonDone_ISI
            // 
            this.buttonDone_ISI.Enabled = false;
            this.buttonDone_ISI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_ISI.Image = global::Tyuiu.IvanovSI.Sprint6.Task7.V4.Properties.Resources.page_white_go;
            this.buttonDone_ISI.Location = new System.Drawing.Point(117, 4);
            this.buttonDone_ISI.Name = "buttonDone_ISI";
            this.buttonDone_ISI.Size = new System.Drawing.Size(107, 75);
            this.buttonDone_ISI.TabIndex = 0;
            this.toolTip_ISI.SetToolTip(this.buttonDone_ISI, "Выполнить обработку данных");
            this.buttonDone_ISI.UseVisualStyleBackColor = true;
            this.buttonDone_ISI.Click += new System.EventHandler(this.buttonDone_ISI_Click);
            // 
            // buttonOpenFile_ISI
            // 
            this.buttonOpenFile_ISI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_ISI.Image = global::Tyuiu.IvanovSI.Sprint6.Task7.V4.Properties.Resources.folder_page;
            this.buttonOpenFile_ISI.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_ISI.Name = "buttonOpenFile_ISI";
            this.buttonOpenFile_ISI.Size = new System.Drawing.Size(107, 75);
            this.buttonOpenFile_ISI.TabIndex = 0;
            this.toolTip_ISI.SetToolTip(this.buttonOpenFile_ISI, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_ISI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ISI.Click += new System.EventHandler(this.buttonOpenFile_ISI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerData_ISI);
            this.Controls.Add(this.panelTask_ISI);
            this.Controls.Add(this.panelButtons_ISI);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 4 | Иванов С. И.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButtons_ISI.ResumeLayout(false);
            this.panelTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.ResumeLayout(false);
            this.groupBoxTask_ISI.PerformLayout();
            this.splitContainerData_ISI.Panel1.ResumeLayout(false);
            this.splitContainerData_ISI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData_ISI)).EndInit();
            this.splitContainerData_ISI.ResumeLayout(false);
            this.groupBoxIn_ISI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ISI)).EndInit();
            this.groupBoxOut_ISI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_ISI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_ISI;
        private System.Windows.Forms.Button buttonHelp_ISI;
        private System.Windows.Forms.Button buttonSave_ISI;
        private System.Windows.Forms.Button buttonDone_ISI;
        private System.Windows.Forms.Button buttonOpenFile_ISI;
        private System.Windows.Forms.Panel panelTask_ISI;
        private System.Windows.Forms.GroupBox groupBoxTask_ISI;
        private System.Windows.Forms.Label labelTask_ISI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ISI;
        private System.Windows.Forms.ToolTip toolTip_ISI;
        private System.Windows.Forms.SplitContainer splitContainerData_ISI;
        private System.Windows.Forms.GroupBox groupBoxIn_ISI;
        private System.Windows.Forms.GroupBox groupBoxOut_ISI;
        private System.Windows.Forms.DataGridView dataGridViewIn_ISI;
        private System.Windows.Forms.DataGridView dataGridViewOut_ISI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_ISI;
    }
}

