namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    partial class FormFile_OLM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFile_OLM));
            panelUPFile_OLM = new Panel();
            ButtonInfoFile_OLM = new Button();
            buttonCloseFormFile_OLM = new Button();
            buttonSaveToCsv_OLM = new Button();
            buttonLoadFile2_OLM = new Button();
            dataGridViewFileCountries_OLM = new DataGridView();
            panelLeft_OLM = new Panel();
            groupBoxFileWork_OLM = new GroupBox();
            buttonRemoveCountry_OLM = new Button();
            buttonEditCountry_OLM = new Button();
            buttonAddCountry_OLM = new Button();
            groupBoxFile_OLM = new GroupBox();
            checkBoxIsDeveloped_OLM = new CheckBox();
            buttonClearFields_OLM = new Button();
            textBoxNationality_OLM = new TextBox();
            textBoxPopulation_OLM = new TextBox();
            textBoxArea_OLM = new TextBox();
            textBoxCapital_OLM = new TextBox();
            textBoxCountryName_OLM = new TextBox();
            labelraz_OLM = new Label();
            label_PR_Popul_OLM = new Label();
            labelPopulation_OLM = new Label();
            labelArea_OLM = new Label();
            labelCountry_OLM = new Label();
            label_name_cou_OLM = new Label();
            toolTip_Form_file_OLM = new ToolTip(components);
            openFileDialog_File_OLM = new OpenFileDialog();
            saveFileDialog_File_OLM = new SaveFileDialog();
            panel1 = new Panel();
            splitter1 = new Splitter();
            panelUPFile_OLM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFileCountries_OLM).BeginInit();
            panelLeft_OLM.SuspendLayout();
            groupBoxFileWork_OLM.SuspendLayout();
            groupBoxFile_OLM.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelUPFile_OLM
            // 
            panelUPFile_OLM.BackColor = Color.FromArgb(192, 255, 255);
            panelUPFile_OLM.Controls.Add(ButtonInfoFile_OLM);
            panelUPFile_OLM.Controls.Add(buttonCloseFormFile_OLM);
            panelUPFile_OLM.Controls.Add(buttonSaveToCsv_OLM);
            panelUPFile_OLM.Controls.Add(buttonLoadFile2_OLM);
            panelUPFile_OLM.Dock = DockStyle.Top;
            panelUPFile_OLM.Location = new Point(0, 0);
            panelUPFile_OLM.Margin = new Padding(4, 5, 4, 5);
            panelUPFile_OLM.Name = "panelUPFile_OLM";
            panelUPFile_OLM.Size = new Size(1047, 131);
            panelUPFile_OLM.TabIndex = 1;
            // 
            // ButtonInfoFile_OLM
            // 
            ButtonInfoFile_OLM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonInfoFile_OLM.Cursor = Cursors.Help;
            ButtonInfoFile_OLM.Image = (Image)resources.GetObject("ButtonInfoFile_OLM.Image");
            ButtonInfoFile_OLM.Location = new Point(928, 31);
            ButtonInfoFile_OLM.Margin = new Padding(4, 5, 4, 5);
            ButtonInfoFile_OLM.Name = "ButtonInfoFile_OLM";
            ButtonInfoFile_OLM.Size = new Size(82, 73);
            ButtonInfoFile_OLM.TabIndex = 6;
            toolTip_Form_file_OLM.SetToolTip(ButtonInfoFile_OLM, "Руководтсво по работе на форме");
            ButtonInfoFile_OLM.UseVisualStyleBackColor = true;
            ButtonInfoFile_OLM.Click += ButtonInfoFile_OLM_Click;
            // 
            // buttonCloseFormFile_OLM
            // 
            buttonCloseFormFile_OLM.Cursor = Cursors.Hand;
            buttonCloseFormFile_OLM.Image = (Image)resources.GetObject("buttonCloseFormFile_OLM.Image");
            buttonCloseFormFile_OLM.Location = new Point(609, 31);
            buttonCloseFormFile_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonCloseFormFile_OLM.Name = "buttonCloseFormFile_OLM";
            buttonCloseFormFile_OLM.Size = new Size(82, 73);
            buttonCloseFormFile_OLM.TabIndex = 5;
            toolTip_Form_file_OLM.SetToolTip(buttonCloseFormFile_OLM, "Закрыть форму");
            buttonCloseFormFile_OLM.UseVisualStyleBackColor = true;
            buttonCloseFormFile_OLM.Click += buttonCloseFormFile_OLM_Click;
            // 
            // buttonSaveToCsv_OLM
            // 
            buttonSaveToCsv_OLM.Cursor = Cursors.Hand;
            buttonSaveToCsv_OLM.Enabled = false;
            buttonSaveToCsv_OLM.Image = (Image)resources.GetObject("buttonSaveToCsv_OLM.Image");
            buttonSaveToCsv_OLM.Location = new Point(508, 31);
            buttonSaveToCsv_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonSaveToCsv_OLM.Name = "buttonSaveToCsv_OLM";
            buttonSaveToCsv_OLM.Size = new Size(78, 73);
            buttonSaveToCsv_OLM.TabIndex = 1;
            toolTip_Form_file_OLM.SetToolTip(buttonSaveToCsv_OLM, "Сохранить файл");
            buttonSaveToCsv_OLM.UseVisualStyleBackColor = true;
            buttonSaveToCsv_OLM.Click += buttonSaveToCsv_OLM_Click;
            // 
            // buttonLoadFile2_OLM
            // 
            buttonLoadFile2_OLM.Cursor = Cursors.Hand;
            buttonLoadFile2_OLM.Image = (Image)resources.GetObject("buttonLoadFile2_OLM.Image");
            buttonLoadFile2_OLM.Location = new Point(409, 31);
            buttonLoadFile2_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonLoadFile2_OLM.Name = "buttonLoadFile2_OLM";
            buttonLoadFile2_OLM.Size = new Size(78, 73);
            buttonLoadFile2_OLM.TabIndex = 0;
            toolTip_Form_file_OLM.SetToolTip(buttonLoadFile2_OLM, "Загрузить файл");
            buttonLoadFile2_OLM.UseVisualStyleBackColor = true;
            buttonLoadFile2_OLM.Click += buttonLoadFile2_OLM_Click;
            // 
            // dataGridViewFileCountries_OLM
            // 
            dataGridViewFileCountries_OLM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFileCountries_OLM.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridViewFileCountries_OLM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFileCountries_OLM.Dock = DockStyle.Fill;
            dataGridViewFileCountries_OLM.Location = new Point(0, 0);
            dataGridViewFileCountries_OLM.Margin = new Padding(4, 5, 4, 5);
            dataGridViewFileCountries_OLM.Name = "dataGridViewFileCountries_OLM";
            dataGridViewFileCountries_OLM.RowHeadersVisible = false;
            dataGridViewFileCountries_OLM.RowHeadersWidth = 51;
            dataGridViewFileCountries_OLM.Size = new Size(661, 585);
            dataGridViewFileCountries_OLM.TabIndex = 0;
            dataGridViewFileCountries_OLM.CellContentClick += dataGridViewFileCountries_OLM_CellContentClick;
            // 
            // panelLeft_OLM
            // 
            panelLeft_OLM.BackColor = Color.White;
            panelLeft_OLM.Controls.Add(groupBoxFileWork_OLM);
            panelLeft_OLM.Controls.Add(groupBoxFile_OLM);
            panelLeft_OLM.Dock = DockStyle.Left;
            panelLeft_OLM.Location = new Point(0, 131);
            panelLeft_OLM.Margin = new Padding(4, 5, 4, 5);
            panelLeft_OLM.Name = "panelLeft_OLM";
            panelLeft_OLM.Size = new Size(386, 585);
            panelLeft_OLM.TabIndex = 3;
            // 
            // groupBoxFileWork_OLM
            // 
            groupBoxFileWork_OLM.BackColor = Color.White;
            groupBoxFileWork_OLM.Controls.Add(buttonRemoveCountry_OLM);
            groupBoxFileWork_OLM.Controls.Add(buttonEditCountry_OLM);
            groupBoxFileWork_OLM.Controls.Add(buttonAddCountry_OLM);
            groupBoxFileWork_OLM.Dock = DockStyle.Bottom;
            groupBoxFileWork_OLM.Enabled = false;
            groupBoxFileWork_OLM.Location = new Point(0, 440);
            groupBoxFileWork_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBoxFileWork_OLM.Name = "groupBoxFileWork_OLM";
            groupBoxFileWork_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBoxFileWork_OLM.Size = new Size(386, 145);
            groupBoxFileWork_OLM.TabIndex = 1;
            groupBoxFileWork_OLM.TabStop = false;
            groupBoxFileWork_OLM.Text = "Функционал";
            // 
            // buttonRemoveCountry_OLM
            // 
            buttonRemoveCountry_OLM.Cursor = Cursors.Hand;
            buttonRemoveCountry_OLM.Image = (Image)resources.GetObject("buttonRemoveCountry_OLM.Image");
            buttonRemoveCountry_OLM.Location = new Point(252, 44);
            buttonRemoveCountry_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonRemoveCountry_OLM.Name = "buttonRemoveCountry_OLM";
            buttonRemoveCountry_OLM.Size = new Size(82, 79);
            buttonRemoveCountry_OLM.TabIndex = 4;
            toolTip_Form_file_OLM.SetToolTip(buttonRemoveCountry_OLM, "Удалить страну");
            buttonRemoveCountry_OLM.UseVisualStyleBackColor = true;
            buttonRemoveCountry_OLM.Click += buttonRemoveCountry_OLM_Click;
            // 
            // buttonEditCountry_OLM
            // 
            buttonEditCountry_OLM.Cursor = Cursors.Hand;
            buttonEditCountry_OLM.Image = (Image)resources.GetObject("buttonEditCountry_OLM.Image");
            buttonEditCountry_OLM.Location = new Point(148, 44);
            buttonEditCountry_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonEditCountry_OLM.Name = "buttonEditCountry_OLM";
            buttonEditCountry_OLM.Size = new Size(82, 79);
            buttonEditCountry_OLM.TabIndex = 3;
            toolTip_Form_file_OLM.SetToolTip(buttonEditCountry_OLM, "Редактировать страну");
            buttonEditCountry_OLM.UseVisualStyleBackColor = true;
            buttonEditCountry_OLM.Click += buttonEditCountry_OLM_Click;
            // 
            // buttonAddCountry_OLM
            // 
            buttonAddCountry_OLM.Cursor = Cursors.Hand;
            buttonAddCountry_OLM.Image = (Image)resources.GetObject("buttonAddCountry_OLM.Image");
            buttonAddCountry_OLM.Location = new Point(36, 44);
            buttonAddCountry_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonAddCountry_OLM.Name = "buttonAddCountry_OLM";
            buttonAddCountry_OLM.Size = new Size(82, 79);
            buttonAddCountry_OLM.TabIndex = 2;
            toolTip_Form_file_OLM.SetToolTip(buttonAddCountry_OLM, "Добавить страну");
            buttonAddCountry_OLM.UseVisualStyleBackColor = true;
            buttonAddCountry_OLM.Click += buttonAddCountry_OLM_Click;
            // 
            // groupBoxFile_OLM
            // 
            groupBoxFile_OLM.BackColor = Color.White;
            groupBoxFile_OLM.Controls.Add(checkBoxIsDeveloped_OLM);
            groupBoxFile_OLM.Controls.Add(buttonClearFields_OLM);
            groupBoxFile_OLM.Controls.Add(textBoxNationality_OLM);
            groupBoxFile_OLM.Controls.Add(textBoxPopulation_OLM);
            groupBoxFile_OLM.Controls.Add(textBoxArea_OLM);
            groupBoxFile_OLM.Controls.Add(textBoxCapital_OLM);
            groupBoxFile_OLM.Controls.Add(textBoxCountryName_OLM);
            groupBoxFile_OLM.Controls.Add(labelraz_OLM);
            groupBoxFile_OLM.Controls.Add(label_PR_Popul_OLM);
            groupBoxFile_OLM.Controls.Add(labelPopulation_OLM);
            groupBoxFile_OLM.Controls.Add(labelArea_OLM);
            groupBoxFile_OLM.Controls.Add(labelCountry_OLM);
            groupBoxFile_OLM.Controls.Add(label_name_cou_OLM);
            groupBoxFile_OLM.Enabled = false;
            groupBoxFile_OLM.Location = new Point(15, 8);
            groupBoxFile_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBoxFile_OLM.Name = "groupBoxFile_OLM";
            groupBoxFile_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBoxFile_OLM.Size = new Size(350, 434);
            groupBoxFile_OLM.TabIndex = 0;
            groupBoxFile_OLM.TabStop = false;
            groupBoxFile_OLM.Text = "Данные о стране";
            // 
            // checkBoxIsDeveloped_OLM
            // 
            checkBoxIsDeveloped_OLM.AutoSize = true;
            checkBoxIsDeveloped_OLM.Location = new Point(253, 304);
            checkBoxIsDeveloped_OLM.Margin = new Padding(4, 5, 4, 5);
            checkBoxIsDeveloped_OLM.Name = "checkBoxIsDeveloped_OLM";
            checkBoxIsDeveloped_OLM.Size = new Size(18, 17);
            checkBoxIsDeveloped_OLM.TabIndex = 14;
            checkBoxIsDeveloped_OLM.UseVisualStyleBackColor = true;
            // 
            // buttonClearFields_OLM
            // 
            buttonClearFields_OLM.Cursor = Cursors.Hand;
            buttonClearFields_OLM.Image = (Image)resources.GetObject("buttonClearFields_OLM.Image");
            buttonClearFields_OLM.Location = new Point(132, 341);
            buttonClearFields_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonClearFields_OLM.Name = "buttonClearFields_OLM";
            buttonClearFields_OLM.Size = new Size(82, 73);
            buttonClearFields_OLM.TabIndex = 2;
            toolTip_Form_file_OLM.SetToolTip(buttonClearFields_OLM, "Очистка полей");
            buttonClearFields_OLM.UseVisualStyleBackColor = true;
            buttonClearFields_OLM.Click += buttonClearFields_OLM_Click;
            // 
            // textBoxNationality_OLM
            // 
            textBoxNationality_OLM.Location = new Point(202, 257);
            textBoxNationality_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxNationality_OLM.Name = "textBoxNationality_OLM";
            textBoxNationality_OLM.Size = new Size(127, 29);
            textBoxNationality_OLM.TabIndex = 13;
            // 
            // textBoxPopulation_OLM
            // 
            textBoxPopulation_OLM.Location = new Point(202, 202);
            textBoxPopulation_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxPopulation_OLM.Name = "textBoxPopulation_OLM";
            textBoxPopulation_OLM.Size = new Size(127, 29);
            textBoxPopulation_OLM.TabIndex = 12;
            // 
            // textBoxArea_OLM
            // 
            textBoxArea_OLM.Location = new Point(202, 154);
            textBoxArea_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxArea_OLM.Name = "textBoxArea_OLM";
            textBoxArea_OLM.Size = new Size(127, 29);
            textBoxArea_OLM.TabIndex = 11;
            // 
            // textBoxCapital_OLM
            // 
            textBoxCapital_OLM.Location = new Point(202, 100);
            textBoxCapital_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxCapital_OLM.Name = "textBoxCapital_OLM";
            textBoxCapital_OLM.Size = new Size(127, 29);
            textBoxCapital_OLM.TabIndex = 10;
            // 
            // textBoxCountryName_OLM
            // 
            textBoxCountryName_OLM.Location = new Point(202, 45);
            textBoxCountryName_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxCountryName_OLM.Name = "textBoxCountryName_OLM";
            textBoxCountryName_OLM.Size = new Size(127, 29);
            textBoxCountryName_OLM.TabIndex = 9;
            // 
            // labelraz_OLM
            // 
            labelraz_OLM.AutoSize = true;
            labelraz_OLM.Location = new Point(21, 302);
            labelraz_OLM.Margin = new Padding(4, 0, 4, 0);
            labelraz_OLM.Name = "labelraz_OLM";
            labelraz_OLM.Size = new Size(139, 21);
            labelraz_OLM.TabIndex = 8;
            labelraz_OLM.Text = "Развита ли страна";
            labelraz_OLM.Click += labelraz_OLM_Click;
            // 
            // label_PR_Popul_OLM
            // 
            label_PR_Popul_OLM.AutoSize = true;
            label_PR_Popul_OLM.Location = new Point(21, 247);
            label_PR_Popul_OLM.Margin = new Padding(4, 0, 4, 0);
            label_PR_Popul_OLM.Name = "label_PR_Popul_OLM";
            label_PR_Popul_OLM.Size = new Size(135, 42);
            label_PR_Popul_OLM.TabIndex = 4;
            label_PR_Popul_OLM.Text = "Преобладающая \r\nнациональность";
            // 
            // labelPopulation_OLM
            // 
            labelPopulation_OLM.AutoSize = true;
            labelPopulation_OLM.Location = new Point(21, 213);
            labelPopulation_OLM.Margin = new Padding(4, 0, 4, 0);
            labelPopulation_OLM.Name = "labelPopulation_OLM";
            labelPopulation_OLM.Size = new Size(86, 21);
            labelPopulation_OLM.TabIndex = 3;
            labelPopulation_OLM.Text = "Население";
            // 
            // labelArea_OLM
            // 
            labelArea_OLM.AutoSize = true;
            labelArea_OLM.Location = new Point(21, 165);
            labelArea_OLM.Margin = new Padding(4, 0, 4, 0);
            labelArea_OLM.Name = "labelArea_OLM";
            labelArea_OLM.Size = new Size(118, 21);
            labelArea_OLM.TabIndex = 2;
            labelArea_OLM.Text = "Площадь (км2)";
            // 
            // labelCountry_OLM
            // 
            labelCountry_OLM.AutoSize = true;
            labelCountry_OLM.Location = new Point(21, 110);
            labelCountry_OLM.Margin = new Padding(4, 0, 4, 0);
            labelCountry_OLM.Name = "labelCountry_OLM";
            labelCountry_OLM.Size = new Size(71, 21);
            labelCountry_OLM.TabIndex = 1;
            labelCountry_OLM.Text = "Столица";
            // 
            // label_name_cou_OLM
            // 
            label_name_cou_OLM.AutoSize = true;
            label_name_cou_OLM.Location = new Point(21, 56);
            label_name_cou_OLM.Margin = new Padding(4, 0, 4, 0);
            label_name_cou_OLM.Name = "label_name_cou_OLM";
            label_name_cou_OLM.Size = new Size(133, 21);
            label_name_cou_OLM.TabIndex = 0;
            label_name_cou_OLM.Text = "Название страны";
            // 
            // toolTip_Form_file_OLM
            // 
            toolTip_Form_file_OLM.IsBalloon = true;
            toolTip_Form_file_OLM.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFileDialog_File_OLM
            // 
            openFileDialog_File_OLM.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(dataGridViewFileCountries_OLM);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(386, 131);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 585);
            panel1.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(386, 131);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 585);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // FormFile_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 716);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Controls.Add(panelLeft_OLM);
            Controls.Add(panelUPFile_OLM);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1062, 751);
            Name = "FormFile_OLM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с файлом";
            Load += FormFile_OLM_Load;
            panelUPFile_OLM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFileCountries_OLM).EndInit();
            panelLeft_OLM.ResumeLayout(false);
            groupBoxFileWork_OLM.ResumeLayout(false);
            groupBoxFile_OLM.ResumeLayout(false);
            groupBoxFile_OLM.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelUPFile_OLM;
        private Button buttonSaveToCsv_OLM;
        private Button buttonLoadFile2_OLM;
        private Panel panelLeft_OLM;
        private GroupBox groupBoxFile_OLM;
        private Label label_name_cou_OLM;
        private Button buttonAddCountry_OLM;
        private Label label_PR_Popul_OLM;
        private Label labelPopulation_OLM;
        private Label labelArea_OLM;
        private Label labelCountry_OLM;
        private DataGridView dataGridViewFileCountries_OLM;
        private TextBox textBoxCapital_OLM;
        private TextBox textBoxCountryName_OLM;
        private Label labelraz_OLM;
        private GroupBox groupBoxFileWork_OLM;
        private Button buttonRemoveCountry_OLM;
        private TextBox textBoxNationality_OLM;
        private TextBox textBoxPopulation_OLM;
        private TextBox textBoxArea_OLM;
        private ToolTip toolTip_Form_file_OLM;
        private Button buttonClearFields_OLM;
        private OpenFileDialog openFileDialog_File_OLM;
        private SaveFileDialog saveFileDialog_File_OLM;
        private Button buttonCloseFormFile_OLM;
        private Button ButtonInfoFile_OLM;
        private Button buttonEditCountry_OLM;
        private CheckBox checkBoxIsDeveloped_OLM;
        private Panel panel1;
        private Splitter splitter1;
    }
}