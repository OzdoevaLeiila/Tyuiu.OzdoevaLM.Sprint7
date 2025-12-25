namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    partial class FormInfProgram_OLM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfProgram_OLM));
            pictureBoxOzd_OLM = new PictureBox();
            labelOzd_OLM = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOzd_OLM).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxOzd_OLM
            // 
            pictureBoxOzd_OLM.BackColor = Color.White;
            pictureBoxOzd_OLM.Dock = DockStyle.Left;
            pictureBoxOzd_OLM.Image = (Image)resources.GetObject("pictureBoxOzd_OLM.Image");
            pictureBoxOzd_OLM.InitialImage = null;
            pictureBoxOzd_OLM.Location = new Point(0, 0);
            pictureBoxOzd_OLM.Margin = new Padding(4);
            pictureBoxOzd_OLM.Name = "pictureBoxOzd_OLM";
            pictureBoxOzd_OLM.Size = new Size(329, 365);
            pictureBoxOzd_OLM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOzd_OLM.TabIndex = 0;
            pictureBoxOzd_OLM.TabStop = false;
            // 
            // labelOzd_OLM
            // 
            labelOzd_OLM.AutoSize = true;
            labelOzd_OLM.Location = new Point(363, 38);
            labelOzd_OLM.Margin = new Padding(4, 0, 4, 0);
            labelOzd_OLM.Name = "labelOzd_OLM";
            labelOzd_OLM.Size = new Size(329, 294);
            labelOzd_OLM.TabIndex = 1;
            labelOzd_OLM.Text = resources.GetString("labelOzd_OLM.Text");
            // 
            // FormInfProgram_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(813, 365);
            Controls.Add(labelOzd_OLM);
            Controls.Add(pictureBoxOzd_OLM);
            Margin = new Padding(4);
            MaximumSize = new Size(831, 471);
            MinimumSize = new Size(831, 401);
            Name = "FormInfProgram_OLM";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о разработке";
            Load += FormInfProgram_OLM_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxOzd_OLM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxOzd_OLM;
        private Label labelOzd_OLM;
    }
}