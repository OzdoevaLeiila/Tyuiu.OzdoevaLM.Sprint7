namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    partial class FormChart_OLM
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart_OLM));
            panelUpChartt_OLM = new Panel();
            buttonCloseFormChart_OLM = new Button();
            btnLoadFileChart_OLM = new Button();
            button_info_DIagram_OLM = new Button();
            btnAreaChart_OLM = new Button();
            btnPopulationChart_OLM = new Button();
            toolTipChek_OLM = new ToolTip(components);
            openFileDialog_chek_OLM = new OpenFileDialog();
            panel2 = new Panel();
            dataGridView_chart_OLM = new DataGridView();
            splitter1 = new Splitter();
            panelUpChartt_OLM.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_chart_OLM).BeginInit();
            SuspendLayout();
            // 
            // panelUpChartt_OLM
            // 
            panelUpChartt_OLM.BackColor = Color.FromArgb(192, 255, 255);
            panelUpChartt_OLM.Controls.Add(buttonCloseFormChart_OLM);
            panelUpChartt_OLM.Controls.Add(btnLoadFileChart_OLM);
            panelUpChartt_OLM.Controls.Add(button_info_DIagram_OLM);
            panelUpChartt_OLM.Controls.Add(btnAreaChart_OLM);
            panelUpChartt_OLM.Controls.Add(btnPopulationChart_OLM);
            panelUpChartt_OLM.Dock = DockStyle.Top;
            panelUpChartt_OLM.Location = new Point(0, 0);
            panelUpChartt_OLM.Margin = new Padding(4, 5, 4, 5);
            panelUpChartt_OLM.Name = "panelUpChartt_OLM";
            panelUpChartt_OLM.Size = new Size(1446, 186);
            panelUpChartt_OLM.TabIndex = 0;
            panelUpChartt_OLM.Paint += panelUpChartt_OLM_Paint;
            // 
            // buttonCloseFormChart_OLM
            // 
            buttonCloseFormChart_OLM.Cursor = Cursors.Hand;
            buttonCloseFormChart_OLM.Image = (Image)resources.GetObject("buttonCloseFormChart_OLM.Image");
            buttonCloseFormChart_OLM.Location = new Point(809, 68);
            buttonCloseFormChart_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonCloseFormChart_OLM.Name = "buttonCloseFormChart_OLM";
            buttonCloseFormChart_OLM.Size = new Size(89, 79);
            buttonCloseFormChart_OLM.TabIndex = 8;
            toolTipChek_OLM.SetToolTip(buttonCloseFormChart_OLM, "Закрыть форму");
            buttonCloseFormChart_OLM.UseVisualStyleBackColor = true;
            buttonCloseFormChart_OLM.Click += buttonCloseFormChart_OLM_Click;
            // 
            // btnLoadFileChart_OLM
            // 
            btnLoadFileChart_OLM.Cursor = Cursors.Hand;
            btnLoadFileChart_OLM.Image = (Image)resources.GetObject("btnLoadFileChart_OLM.Image");
            btnLoadFileChart_OLM.Location = new Point(32, 44);
            btnLoadFileChart_OLM.Margin = new Padding(4, 5, 4, 5);
            btnLoadFileChart_OLM.Name = "btnLoadFileChart_OLM";
            btnLoadFileChart_OLM.Size = new Size(93, 81);
            btnLoadFileChart_OLM.TabIndex = 7;
            toolTipChek_OLM.SetToolTip(btnLoadFileChart_OLM, "Загрузить файл");
            btnLoadFileChart_OLM.UseVisualStyleBackColor = true;
            btnLoadFileChart_OLM.Click += btnLoadFileChart_OLM_Click_1;
            // 
            // button_info_DIagram_OLM
            // 
            button_info_DIagram_OLM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_info_DIagram_OLM.Cursor = Cursors.Help;
            button_info_DIagram_OLM.Image = (Image)resources.GetObject("button_info_DIagram_OLM.Image");
            button_info_DIagram_OLM.Location = new Point(1342, 44);
            button_info_DIagram_OLM.Margin = new Padding(4, 5, 4, 5);
            button_info_DIagram_OLM.Name = "button_info_DIagram_OLM";
            button_info_DIagram_OLM.Size = new Size(89, 79);
            button_info_DIagram_OLM.TabIndex = 6;
            toolTipChek_OLM.SetToolTip(button_info_DIagram_OLM, "Руководство по работе на форме");
            button_info_DIagram_OLM.UseVisualStyleBackColor = true;
            button_info_DIagram_OLM.Click += button_info_DIagram_OLM_Click;
            // 
            // btnAreaChart_OLM
            // 
            btnAreaChart_OLM.Cursor = Cursors.Hand;
            btnAreaChart_OLM.Image = (Image)resources.GetObject("btnAreaChart_OLM.Image");
            btnAreaChart_OLM.Location = new Point(712, 68);
            btnAreaChart_OLM.Margin = new Padding(4, 5, 4, 5);
            btnAreaChart_OLM.Name = "btnAreaChart_OLM";
            btnAreaChart_OLM.Size = new Size(89, 79);
            btnAreaChart_OLM.TabIndex = 1;
            toolTipChek_OLM.SetToolTip(btnAreaChart_OLM, "Гистограмма по площади");
            btnAreaChart_OLM.UseVisualStyleBackColor = true;
            btnAreaChart_OLM.Click += btnAreaChart_OLM_Click_1;
            // 
            // btnPopulationChart_OLM
            // 
            btnPopulationChart_OLM.Cursor = Cursors.Hand;
            btnPopulationChart_OLM.Image = (Image)resources.GetObject("btnPopulationChart_OLM.Image");
            btnPopulationChart_OLM.Location = new Point(616, 68);
            btnPopulationChart_OLM.Margin = new Padding(4, 5, 4, 5);
            btnPopulationChart_OLM.Name = "btnPopulationChart_OLM";
            btnPopulationChart_OLM.Size = new Size(89, 79);
            btnPopulationChart_OLM.TabIndex = 0;
            toolTipChek_OLM.SetToolTip(btnPopulationChart_OLM, "Гистограмма по населению");
            btnPopulationChart_OLM.UseVisualStyleBackColor = true;
            btnPopulationChart_OLM.Click += btnPopulationChart_OLM_Click_1;
            // 
            // toolTipChek_OLM
            // 
            toolTipChek_OLM.IsBalloon = true;
            toolTipChek_OLM.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFileDialog_chek_OLM
            // 
            openFileDialog_chek_OLM.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dataGridView_chart_OLM);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 186);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 588);
            panel2.TabIndex = 1;
            // 
            // dataGridView_chart_OLM
            // 
            dataGridView_chart_OLM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_chart_OLM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_chart_OLM.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView_chart_OLM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_chart_OLM.Location = new Point(0, 0);
            dataGridView_chart_OLM.Margin = new Padding(4, 5, 4, 5);
            dataGridView_chart_OLM.Name = "dataGridView_chart_OLM";
            dataGridView_chart_OLM.ReadOnly = true;
            dataGridView_chart_OLM.RowHeadersVisible = false;
            dataGridView_chart_OLM.RowHeadersWidth = 51;
            dataGridView_chart_OLM.Size = new Size(752, 588);
            dataGridView_chart_OLM.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(752, 186);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(13, 588);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormChart_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1446, 774);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panelUpChartt_OLM);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1538, 821);
            MinimumSize = new Size(1281, 821);
            Name = "FormChart_OLM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анализ данных";
            Load += FormChart_OLM_Load;
            panelUpChartt_OLM.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_chart_OLM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUpChartt_OLM;
        private ToolTip toolTipChek_OLM;
        private OpenFileDialog openFileDialog_chek_OLM;
        private Panel panel2;
        private Splitter splitter1;
        private Button btnPopulationChart_OLM;
        private DataGridView dataGridView_chart_OLM;
        private Button btnAreaChart_OLM;
        private Button button_info_DIagram_OLM;
        private Button btnLoadFileChart_OLM;
        private Button buttonCloseFormChart_OLM;
    }
}