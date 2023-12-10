
namespace Tyuiu.IvanovSI.Sprint6.Task7.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelHelp_ISI = new System.Windows.Forms.Label();
            this.pictureBoxAva_ISI = new System.Windows.Forms.PictureBox();
            this.buttonOk_ISI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_ISI)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHelp_ISI
            // 
            this.labelHelp_ISI.AutoSize = true;
            this.labelHelp_ISI.Location = new System.Drawing.Point(241, 12);
            this.labelHelp_ISI.Name = "labelHelp_ISI";
            this.labelHelp_ISI.Size = new System.Drawing.Size(284, 117);
            this.labelHelp_ISI.TabIndex = 3;
            this.labelHelp_ISI.Text = resources.GetString("labelHelp_ISI.Text");
            // 
            // pictureBoxAva_ISI
            // 
            this.pictureBoxAva_ISI.Image = global::Tyuiu.IvanovSI.Sprint6.Task7.V4.Properties.Resources._2a09gHNnzys;
            this.pictureBoxAva_ISI.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAva_ISI.Name = "pictureBoxAva_ISI";
            this.pictureBoxAva_ISI.Size = new System.Drawing.Size(223, 212);
            this.pictureBoxAva_ISI.TabIndex = 1;
            this.pictureBoxAva_ISI.TabStop = false;
            // 
            // buttonOk_ISI
            // 
            this.buttonOk_ISI.Location = new System.Drawing.Point(445, 200);
            this.buttonOk_ISI.Name = "buttonOk_ISI";
            this.buttonOk_ISI.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_ISI.TabIndex = 4;
            this.buttonOk_ISI.Text = "Ok";
            this.buttonOk_ISI.UseVisualStyleBackColor = true;
            this.buttonOk_ISI.Click += new System.EventHandler(this.buttonOk_ISI_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 227);
            this.Controls.Add(this.buttonOk_ISI);
            this.Controls.Add(this.labelHelp_ISI);
            this.Controls.Add(this.pictureBoxAva_ISI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_ISI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAva_ISI;
        private System.Windows.Forms.Label labelHelp_ISI;
        private System.Windows.Forms.Button buttonOk_ISI;
    }
}