namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    partial class FormFileEDIT_OLM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileEDIT_OLM));
            pictureBoxWorkFile_OLM = new PictureBox();
            labelWorkFile_OLM = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_OLM).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxWorkFile_OLM
            // 
            pictureBoxWorkFile_OLM.Dock = DockStyle.Left;
            pictureBoxWorkFile_OLM.Image = (Image)resources.GetObject("pictureBoxWorkFile_OLM.Image");
            pictureBoxWorkFile_OLM.Location = new Point(0, 0);
            pictureBoxWorkFile_OLM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxWorkFile_OLM.Name = "pictureBoxWorkFile_OLM";
            pictureBoxWorkFile_OLM.Size = new Size(311, 448);
            pictureBoxWorkFile_OLM.TabIndex = 0;
            pictureBoxWorkFile_OLM.TabStop = false;
            // 
            // labelWorkFile_OLM
            // 
            labelWorkFile_OLM.AutoSize = true;
            labelWorkFile_OLM.Location = new Point(324, 64);
            labelWorkFile_OLM.Margin = new Padding(4, 0, 4, 0);
            labelWorkFile_OLM.Name = "labelWorkFile_OLM";
            labelWorkFile_OLM.Size = new Size(355, 273);
            labelWorkFile_OLM.TabIndex = 1;
            labelWorkFile_OLM.Text = resources.GetString("labelWorkFile_OLM.Text");
            // 
            // FormFileEDIT_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 448);
            Controls.Add(labelWorkFile_OLM);
            Controls.Add(pictureBoxWorkFile_OLM);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormFileEDIT_OLM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство по работе c файлом";
            Load += FormFileEDIT_OLM_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_OLM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxWorkFile_OLM;
        private Label labelWorkFile_OLM;
    }
}