namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    partial class FormFileChartInf_OLM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileChartInf_OLM));
            pictureBoxWorkFile_OLM = new PictureBox();
            textBoxFileChart_OLM = new TextBox();
            groupBoxInfoWfile_OLM = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_OLM).BeginInit();
            groupBoxInfoWfile_OLM.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxWorkFile_OLM
            // 
            pictureBoxWorkFile_OLM.Dock = DockStyle.Top;
            pictureBoxWorkFile_OLM.Image = (Image)resources.GetObject("pictureBoxWorkFile_OLM.Image");
            pictureBoxWorkFile_OLM.Location = new Point(0, 0);
            pictureBoxWorkFile_OLM.Margin = new Padding(4, 5, 4, 5);
            pictureBoxWorkFile_OLM.Name = "pictureBoxWorkFile_OLM";
            pictureBoxWorkFile_OLM.Size = new Size(703, 512);
            pictureBoxWorkFile_OLM.TabIndex = 1;
            pictureBoxWorkFile_OLM.TabStop = false;
            // 
            // textBoxFileChart_OLM
            // 
            textBoxFileChart_OLM.Enabled = false;
            textBoxFileChart_OLM.Location = new Point(15, 31);
            textBoxFileChart_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxFileChart_OLM.Multiline = true;
            textBoxFileChart_OLM.Name = "textBoxFileChart_OLM";
            textBoxFileChart_OLM.ReadOnly = true;
            textBoxFileChart_OLM.Size = new Size(680, 138);
            textBoxFileChart_OLM.TabIndex = 0;
            textBoxFileChart_OLM.Text = "Для построения графиков необходимо загрузить файл с данными в формате CSV.\r\n\r\nПосле загрузки станут доступны:\r\n• Гистограмма населения \r\n• Гистограмма площади ";
            // 
            // groupBoxInfoWfile_OLM
            // 
            groupBoxInfoWfile_OLM.BackColor = Color.White;
            groupBoxInfoWfile_OLM.Controls.Add(textBoxFileChart_OLM);
            groupBoxInfoWfile_OLM.Dock = DockStyle.Bottom;
            groupBoxInfoWfile_OLM.Location = new Point(0, 521);
            groupBoxInfoWfile_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBoxInfoWfile_OLM.MinimumSize = new Size(703, 253);
            groupBoxInfoWfile_OLM.Name = "groupBoxInfoWfile_OLM";
            groupBoxInfoWfile_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBoxInfoWfile_OLM.Size = new Size(703, 253);
            groupBoxInfoWfile_OLM.TabIndex = 0;
            groupBoxInfoWfile_OLM.TabStop = false;
            groupBoxInfoWfile_OLM.Text = "Описание";
            // 
            // FormFileChartInf_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 774);
            Controls.Add(pictureBoxWorkFile_OLM);
            Controls.Add(groupBoxInfoWfile_OLM);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1023, 821);
            MinimumSize = new Size(702, 821);
            Name = "FormFileChartInf_OLM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство по работе с анализом данных";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWorkFile_OLM).EndInit();
            groupBoxInfoWfile_OLM.ResumeLayout(false);
            groupBoxInfoWfile_OLM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxWorkFile_OLM;
        private GroupBox groupBox2;
        private TextBox textBoxFileChart_OLM;
        private GroupBox groupBoxInfoWfile_OLM;
    }
}