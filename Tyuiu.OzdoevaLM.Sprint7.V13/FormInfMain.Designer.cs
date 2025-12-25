namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    partial class FormInfMain_OLM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfMain_OLM));
            groupBoxInfoMain_OLM = new GroupBox();
            textBoxInfoMain_OLM = new TextBox();
            pictureBoxInfMain_OLM = new PictureBox();
            groupBoxInfoMain_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfMain_OLM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfoMain_OLM
            // 
            groupBoxInfoMain_OLM.Controls.Add(textBoxInfoMain_OLM);
            groupBoxInfoMain_OLM.Dock = DockStyle.Bottom;
            groupBoxInfoMain_OLM.Location = new Point(0, 220);
            groupBoxInfoMain_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBoxInfoMain_OLM.Name = "groupBoxInfoMain_OLM";
            groupBoxInfoMain_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBoxInfoMain_OLM.Size = new Size(682, 333);
            groupBoxInfoMain_OLM.TabIndex = 0;
            groupBoxInfoMain_OLM.TabStop = false;
            groupBoxInfoMain_OLM.Text = "Описание";
            // 
            // textBoxInfoMain_OLM
            // 
            textBoxInfoMain_OLM.Enabled = false;
            textBoxInfoMain_OLM.Location = new Point(15, 31);
            textBoxInfoMain_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxInfoMain_OLM.Multiline = true;
            textBoxInfoMain_OLM.Name = "textBoxInfoMain_OLM";
            textBoxInfoMain_OLM.ReadOnly = true;
            textBoxInfoMain_OLM.Size = new Size(622, 315);
            textBoxInfoMain_OLM.TabIndex = 0;
            textBoxInfoMain_OLM.Text = resources.GetString("textBoxInfoMain_OLM.Text");
            // 
            // pictureBoxInfMain_OLM
            // 
            pictureBoxInfMain_OLM.Dock = DockStyle.Fill;
            pictureBoxInfMain_OLM.Image = (Image)resources.GetObject("pictureBoxInfMain_OLM.Image");
            pictureBoxInfMain_OLM.Location = new Point(0, 0);
            pictureBoxInfMain_OLM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxInfMain_OLM.Name = "pictureBoxInfMain_OLM";
            pictureBoxInfMain_OLM.Size = new Size(682, 220);
            pictureBoxInfMain_OLM.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxInfMain_OLM.TabIndex = 1;
            pictureBoxInfMain_OLM.TabStop = false;
            pictureBoxInfMain_OLM.Click += pictureBoxInfMain_OLM_Click;
            // 
            // FormInfMain_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 553);
            Controls.Add(pictureBoxInfMain_OLM);
            Controls.Add(groupBoxInfoMain_OLM);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(700, 600);
            MinimumSize = new Size(700, 600);
            Name = "FormInfMain_OLM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "👨‍🏫 Как работать на главном окне";
            groupBoxInfoMain_OLM.ResumeLayout(false);
            groupBoxInfoMain_OLM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfMain_OLM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInfoMain_OLM;
        private PictureBox pictureBoxInfMain_OLM;
        private TextBox textBoxInfoMain_OLM;
    }
}