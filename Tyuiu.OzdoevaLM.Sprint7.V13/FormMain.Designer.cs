
namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    partial class FormMain_OLM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_OLM));
            menuStrip_MAIN_OLM = new MenuStrip();
            работаСДаннымиToolStripMenuItem = new ToolStripMenuItem();
            загпрузитьФайлToolStripMenuItem_OLM = new ToolStripMenuItem();
            РаботаСфайломToolStripMenuItem_OLM = new ToolStripMenuItem();
            выходToolStripMenuItem_OLM = new ToolStripMenuItem();
            анализДанныхToolStripMenuItem_OLM = new ToolStripMenuItem();
            руководствоToolStripMenuItem_OLM = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem_OLM = new ToolStripMenuItem();
            panel1 = new Panel();
            groupBox_Info_Data_OLM = new GroupBox();
            button_info_EditFail_OLM = new Button();
            button_info_DIagram_OLM = new Button();
            button_info_WorkInProgr_OLM = new Button();
            groupBox_filter_sq_OLM = new GroupBox();
            buttonFilterByArea_OLM = new Button();
            textBoxMinArea_OLM = new TextBox();
            groupBox_SR_POPUL_OLM = new GroupBox();
            textBoxResultSr_OLM = new TextBox();
            buttonCalculateAveragePopulation_OLM = new Button();
            groupBox_Filter_popul_OLM = new GroupBox();
            buttonSortByPopulationDesc_OLM = new Button();
            buttonSortByPopulationAsc_OLM = new Button();
            groupBoxMain_OLM = new GroupBox();
            button_search_OLM = new Button();
            textBoxSearch_OLM = new TextBox();
            labelFilt_sq_OLM = new Label();
            textBox2 = new TextBox();
            panel2 = new Panel();
            dataGridViewCountries_OLM = new DataGridView();
            splitter1 = new Splitter();
            buttonFilt_sq_OLM = new Button();
            toolTip_mainform_OLM = new ToolTip(components);
            menuStrip_MAIN_OLM.SuspendLayout();
            panel1.SuspendLayout();
            groupBox_Info_Data_OLM.SuspendLayout();
            groupBox_filter_sq_OLM.SuspendLayout();
            groupBox_SR_POPUL_OLM.SuspendLayout();
            groupBox_Filter_popul_OLM.SuspendLayout();
            groupBoxMain_OLM.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries_OLM).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_MAIN_OLM
            // 
            menuStrip_MAIN_OLM.BackColor = Color.RoyalBlue;
            menuStrip_MAIN_OLM.ImageScalingSize = new Size(20, 20);
            menuStrip_MAIN_OLM.Items.AddRange(new ToolStripItem[] { работаСДаннымиToolStripMenuItem, анализДанныхToolStripMenuItem_OLM, руководствоToolStripMenuItem_OLM });
            menuStrip_MAIN_OLM.Location = new Point(0, 0);
            menuStrip_MAIN_OLM.Name = "menuStrip_MAIN_OLM";
            menuStrip_MAIN_OLM.Padding = new Padding(8, 3, 0, 3);
            menuStrip_MAIN_OLM.Size = new Size(1005, 31);
            menuStrip_MAIN_OLM.TabIndex = 0;
            menuStrip_MAIN_OLM.Text = "menuStrip1";
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загпрузитьФайлToolStripMenuItem_OLM, РаботаСфайломToolStripMenuItem_OLM, выходToolStripMenuItem_OLM });
            работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            работаСДаннымиToolStripMenuItem.Size = new Size(106, 25);
            работаСДаннымиToolStripMenuItem.Text = "Программа";
            // 
            // загпрузитьФайлToolStripMenuItem_OLM
            // 
            загпрузитьФайлToolStripMenuItem_OLM.Name = "загпрузитьФайлToolStripMenuItem_OLM";
            загпрузитьФайлToolStripMenuItem_OLM.Size = new Size(215, 26);
            загпрузитьФайлToolStripMenuItem_OLM.Text = "Загрузить файл";
            загпрузитьФайлToolStripMenuItem_OLM.Click += загпрузитьФайлToolStripMenuItem_OLM_Click;
            // 
            // РаботаСфайломToolStripMenuItem_OLM
            // 
            РаботаСфайломToolStripMenuItem_OLM.Name = "РаботаСфайломToolStripMenuItem_OLM";
            РаботаСфайломToolStripMenuItem_OLM.Size = new Size(215, 26);
            РаботаСфайломToolStripMenuItem_OLM.Text = "Работа с файлом";
            РаботаСфайломToolStripMenuItem_OLM.Click += РаботаСфайломToolStripMenuItem_OLM_Click;
            // 
            // выходToolStripMenuItem_OLM
            // 
            выходToolStripMenuItem_OLM.Name = "выходToolStripMenuItem_OLM";
            выходToolStripMenuItem_OLM.Size = new Size(215, 26);
            выходToolStripMenuItem_OLM.Text = "Выход";
            выходToolStripMenuItem_OLM.Click += выходToolStripMenuItem_OLM_Click;
            // 
            // анализДанныхToolStripMenuItem_OLM
            // 
            анализДанныхToolStripMenuItem_OLM.Name = "анализДанныхToolStripMenuItem_OLM";
            анализДанныхToolStripMenuItem_OLM.Size = new Size(132, 25);
            анализДанныхToolStripMenuItem_OLM.Text = "Анализ данных";
            анализДанныхToolStripMenuItem_OLM.Click += анализДанныхToolStripMenuItem_OLM_Click;
            // 
            // руководствоToolStripMenuItem_OLM
            // 
            руководствоToolStripMenuItem_OLM.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem_OLM });
            руководствоToolStripMenuItem_OLM.Name = "руководствоToolStripMenuItem_OLM";
            руководствоToolStripMenuItem_OLM.Size = new Size(106, 25);
            руководствоToolStripMenuItem_OLM.Text = "Разработка";
            // 
            // оПрограммеToolStripMenuItem_OLM
            // 
            оПрограммеToolStripMenuItem_OLM.Name = "оПрограммеToolStripMenuItem_OLM";
            оПрограммеToolStripMenuItem_OLM.Size = new Size(224, 26);
            оПрограммеToolStripMenuItem_OLM.Text = "О программе";
            оПрограммеToolStripMenuItem_OLM.Click += оПрограммеToolStripMenuItem_OLM_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox_Info_Data_OLM);
            panel1.Controls.Add(groupBox_filter_sq_OLM);
            panel1.Controls.Add(groupBox_SR_POPUL_OLM);
            panel1.Controls.Add(groupBox_Filter_popul_OLM);
            panel1.Controls.Add(groupBoxMain_OLM);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 31);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 697);
            panel1.TabIndex = 1;
            // 
            // groupBox_Info_Data_OLM
            // 
            groupBox_Info_Data_OLM.Controls.Add(button_info_EditFail_OLM);
            groupBox_Info_Data_OLM.Controls.Add(button_info_DIagram_OLM);
            groupBox_Info_Data_OLM.Controls.Add(button_info_WorkInProgr_OLM);
            groupBox_Info_Data_OLM.Dock = DockStyle.Bottom;
            groupBox_Info_Data_OLM.Location = new Point(0, 569);
            groupBox_Info_Data_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBox_Info_Data_OLM.Name = "groupBox_Info_Data_OLM";
            groupBox_Info_Data_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBox_Info_Data_OLM.Size = new Size(374, 128);
            groupBox_Info_Data_OLM.TabIndex = 5;
            groupBox_Info_Data_OLM.TabStop = false;
            groupBox_Info_Data_OLM.Text = "Руководтсво пользователя";
            // 
            // button_info_EditFail_OLM
            // 
            button_info_EditFail_OLM.Cursor = Cursors.Help;
            button_info_EditFail_OLM.Image = (Image)resources.GetObject("button_info_EditFail_OLM.Image");
            button_info_EditFail_OLM.Location = new Point(252, 31);
            button_info_EditFail_OLM.Margin = new Padding(4, 5, 4, 5);
            button_info_EditFail_OLM.Name = "button_info_EditFail_OLM";
            button_info_EditFail_OLM.Size = new Size(93, 81);
            button_info_EditFail_OLM.TabIndex = 6;
            toolTip_mainform_OLM.SetToolTip(button_info_EditFail_OLM, "Как работать с файлом");
            button_info_EditFail_OLM.UseVisualStyleBackColor = true;
            button_info_EditFail_OLM.Click += button_info_EditFail_OLM_Click;
            // 
            // button_info_DIagram_OLM
            // 
            button_info_DIagram_OLM.Cursor = Cursors.Help;
            button_info_DIagram_OLM.Image = (Image)resources.GetObject("button_info_DIagram_OLM.Image");
            button_info_DIagram_OLM.Location = new Point(144, 29);
            button_info_DIagram_OLM.Margin = new Padding(4, 5, 4, 5);
            button_info_DIagram_OLM.Name = "button_info_DIagram_OLM";
            button_info_DIagram_OLM.Size = new Size(93, 81);
            button_info_DIagram_OLM.TabIndex = 5;
            toolTip_mainform_OLM.SetToolTip(button_info_DIagram_OLM, "Анализ данных");
            button_info_DIagram_OLM.UseVisualStyleBackColor = true;
            button_info_DIagram_OLM.Click += button_info_DIagram_OLM_Click;
            // 
            // button_info_WorkInProgr_OLM
            // 
            button_info_WorkInProgr_OLM.Cursor = Cursors.Help;
            button_info_WorkInProgr_OLM.Image = (Image)resources.GetObject("button_info_WorkInProgr_OLM.Image");
            button_info_WorkInProgr_OLM.Location = new Point(35, 29);
            button_info_WorkInProgr_OLM.Margin = new Padding(4, 5, 4, 5);
            button_info_WorkInProgr_OLM.Name = "button_info_WorkInProgr_OLM";
            button_info_WorkInProgr_OLM.Size = new Size(93, 81);
            button_info_WorkInProgr_OLM.TabIndex = 4;
            toolTip_mainform_OLM.SetToolTip(button_info_WorkInProgr_OLM, "Работа с данными");
            button_info_WorkInProgr_OLM.UseVisualStyleBackColor = true;
            button_info_WorkInProgr_OLM.Click += button_info_WorkInProgr_OLM_Click;
            // 
            // groupBox_filter_sq_OLM
            // 
            groupBox_filter_sq_OLM.Controls.Add(buttonFilterByArea_OLM);
            groupBox_filter_sq_OLM.Controls.Add(textBoxMinArea_OLM);
            groupBox_filter_sq_OLM.Location = new Point(15, 110);
            groupBox_filter_sq_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBox_filter_sq_OLM.Name = "groupBox_filter_sq_OLM";
            groupBox_filter_sq_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBox_filter_sq_OLM.Size = new Size(351, 144);
            groupBox_filter_sq_OLM.TabIndex = 4;
            groupBox_filter_sq_OLM.TabStop = false;
            groupBox_filter_sq_OLM.Text = "Фильтрация по площади";
            // 
            // buttonFilterByArea_OLM
            // 
            buttonFilterByArea_OLM.BackColor = Color.Transparent;
            buttonFilterByArea_OLM.Cursor = Cursors.Hand;
            buttonFilterByArea_OLM.Enabled = false;
            buttonFilterByArea_OLM.Image = (Image)resources.GetObject("buttonFilterByArea_OLM.Image");
            buttonFilterByArea_OLM.Location = new Point(257, 39);
            buttonFilterByArea_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonFilterByArea_OLM.Name = "buttonFilterByArea_OLM";
            buttonFilterByArea_OLM.Size = new Size(72, 68);
            buttonFilterByArea_OLM.TabIndex = 2;
            toolTip_mainform_OLM.SetToolTip(buttonFilterByArea_OLM, "Выполнить фильтрацию");
            buttonFilterByArea_OLM.UseVisualStyleBackColor = false;
            buttonFilterByArea_OLM.Click += buttonFilterByArea_OLM_Click;
            // 
            // textBoxMinArea_OLM
            // 
            textBoxMinArea_OLM.Anchor = AnchorStyles.None;
            textBoxMinArea_OLM.Enabled = false;
            textBoxMinArea_OLM.Location = new Point(31, 60);
            textBoxMinArea_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxMinArea_OLM.Name = "textBoxMinArea_OLM";
            textBoxMinArea_OLM.Size = new Size(189, 29);
            textBoxMinArea_OLM.TabIndex = 2;
            toolTip_mainform_OLM.SetToolTip(textBoxMinArea_OLM, "Введите минимальную площадь");
            // 
            // groupBox_SR_POPUL_OLM
            // 
            groupBox_SR_POPUL_OLM.Controls.Add(textBoxResultSr_OLM);
            groupBox_SR_POPUL_OLM.Controls.Add(buttonCalculateAveragePopulation_OLM);
            groupBox_SR_POPUL_OLM.Location = new Point(15, 263);
            groupBox_SR_POPUL_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBox_SR_POPUL_OLM.Name = "groupBox_SR_POPUL_OLM";
            groupBox_SR_POPUL_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBox_SR_POPUL_OLM.Size = new Size(351, 140);
            groupBox_SR_POPUL_OLM.TabIndex = 3;
            groupBox_SR_POPUL_OLM.TabStop = false;
            groupBox_SR_POPUL_OLM.Text = "Вычесление среднего населения";
            // 
            // textBoxResultSr_OLM
            // 
            textBoxResultSr_OLM.Enabled = false;
            textBoxResultSr_OLM.Location = new Point(31, 66);
            textBoxResultSr_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxResultSr_OLM.Name = "textBoxResultSr_OLM";
            textBoxResultSr_OLM.ReadOnly = true;
            textBoxResultSr_OLM.Size = new Size(189, 29);
            textBoxResultSr_OLM.TabIndex = 7;
            // 
            // buttonCalculateAveragePopulation_OLM
            // 
            buttonCalculateAveragePopulation_OLM.Cursor = Cursors.Hand;
            buttonCalculateAveragePopulation_OLM.Enabled = false;
            buttonCalculateAveragePopulation_OLM.Image = (Image)resources.GetObject("buttonCalculateAveragePopulation_OLM.Image");
            buttonCalculateAveragePopulation_OLM.Location = new Point(257, 47);
            buttonCalculateAveragePopulation_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonCalculateAveragePopulation_OLM.Name = "buttonCalculateAveragePopulation_OLM";
            buttonCalculateAveragePopulation_OLM.Size = new Size(69, 66);
            buttonCalculateAveragePopulation_OLM.TabIndex = 4;
            toolTip_mainform_OLM.SetToolTip(buttonCalculateAveragePopulation_OLM, "Выполнить вычесление");
            buttonCalculateAveragePopulation_OLM.UseVisualStyleBackColor = true;
            buttonCalculateAveragePopulation_OLM.Click += buttonCalculateAveragePopulation_OLM_Click;
            // 
            // groupBox_Filter_popul_OLM
            // 
            groupBox_Filter_popul_OLM.Controls.Add(buttonSortByPopulationDesc_OLM);
            groupBox_Filter_popul_OLM.Controls.Add(buttonSortByPopulationAsc_OLM);
            groupBox_Filter_popul_OLM.Location = new Point(15, 412);
            groupBox_Filter_popul_OLM.Margin = new Padding(4, 5, 4, 5);
            groupBox_Filter_popul_OLM.Name = "groupBox_Filter_popul_OLM";
            groupBox_Filter_popul_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBox_Filter_popul_OLM.Size = new Size(351, 152);
            groupBox_Filter_popul_OLM.TabIndex = 2;
            groupBox_Filter_popul_OLM.TabStop = false;
            groupBox_Filter_popul_OLM.Text = "Фильтрация по населению";
            // 
            // buttonSortByPopulationDesc_OLM
            // 
            buttonSortByPopulationDesc_OLM.Cursor = Cursors.Hand;
            buttonSortByPopulationDesc_OLM.Enabled = false;
            buttonSortByPopulationDesc_OLM.Image = (Image)resources.GetObject("buttonSortByPopulationDesc_OLM.Image");
            buttonSortByPopulationDesc_OLM.Location = new Point(64, 49);
            buttonSortByPopulationDesc_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonSortByPopulationDesc_OLM.Name = "buttonSortByPopulationDesc_OLM";
            buttonSortByPopulationDesc_OLM.Size = new Size(93, 81);
            buttonSortByPopulationDesc_OLM.TabIndex = 3;
            toolTip_mainform_OLM.SetToolTip(buttonSortByPopulationDesc_OLM, "Выполнить фильтрацию по убыванию");
            buttonSortByPopulationDesc_OLM.UseVisualStyleBackColor = true;
            buttonSortByPopulationDesc_OLM.Click += buttonSortByPopulationDesc_OLM_Click;
            // 
            // buttonSortByPopulationAsc_OLM
            // 
            buttonSortByPopulationAsc_OLM.Cursor = Cursors.Hand;
            buttonSortByPopulationAsc_OLM.Enabled = false;
            buttonSortByPopulationAsc_OLM.Image = (Image)resources.GetObject("buttonSortByPopulationAsc_OLM.Image");
            buttonSortByPopulationAsc_OLM.Location = new Point(183, 49);
            buttonSortByPopulationAsc_OLM.Margin = new Padding(4, 5, 4, 5);
            buttonSortByPopulationAsc_OLM.Name = "buttonSortByPopulationAsc_OLM";
            buttonSortByPopulationAsc_OLM.Size = new Size(93, 81);
            buttonSortByPopulationAsc_OLM.TabIndex = 2;
            toolTip_mainform_OLM.SetToolTip(buttonSortByPopulationAsc_OLM, "Вычислить фильтрацию по возрастанию ");
            buttonSortByPopulationAsc_OLM.UseVisualStyleBackColor = true;
            buttonSortByPopulationAsc_OLM.Click += buttonSortByPopulationAsc_OLM_Click;
            // 
            // groupBoxMain_OLM
            // 
            groupBoxMain_OLM.Controls.Add(button_search_OLM);
            groupBoxMain_OLM.Controls.Add(textBoxSearch_OLM);
            groupBoxMain_OLM.Location = new Point(18, 0);
            groupBoxMain_OLM.Margin = new Padding(6, 7, 6, 7);
            groupBoxMain_OLM.Name = "groupBoxMain_OLM";
            groupBoxMain_OLM.Padding = new Padding(4, 5, 4, 5);
            groupBoxMain_OLM.Size = new Size(350, 100);
            groupBoxMain_OLM.TabIndex = 0;
            groupBoxMain_OLM.TabStop = false;
            groupBoxMain_OLM.Text = "Поиск";
            // 
            // button_search_OLM
            // 
            button_search_OLM.Cursor = Cursors.Hand;
            button_search_OLM.Enabled = false;
            button_search_OLM.Image = (Image)resources.GetObject("button_search_OLM.Image");
            button_search_OLM.Location = new Point(255, 23);
            button_search_OLM.Margin = new Padding(4, 5, 4, 5);
            button_search_OLM.Name = "button_search_OLM";
            button_search_OLM.Size = new Size(72, 68);
            button_search_OLM.TabIndex = 1;
            toolTip_mainform_OLM.SetToolTip(button_search_OLM, "Выполнить поиск");
            button_search_OLM.UseVisualStyleBackColor = true;
            button_search_OLM.Click += button_search_OLM_Click;
            // 
            // textBoxSearch_OLM
            // 
            textBoxSearch_OLM.Enabled = false;
            textBoxSearch_OLM.Location = new Point(28, 44);
            textBoxSearch_OLM.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch_OLM.Name = "textBoxSearch_OLM";
            textBoxSearch_OLM.Size = new Size(189, 29);
            textBoxSearch_OLM.TabIndex = 0;
            toolTip_mainform_OLM.SetToolTip(textBoxSearch_OLM, "Введите страну");
            // 
            // labelFilt_sq_OLM
            // 
            labelFilt_sq_OLM.AutoSize = true;
            labelFilt_sq_OLM.Location = new Point(8, 48);
            labelFilt_sq_OLM.Name = "labelFilt_sq_OLM";
            labelFilt_sq_OLM.Size = new Size(91, 15);
            labelFilt_sq_OLM.TabIndex = 6;
            labelFilt_sq_OLM.Text = "Мин. площадь:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 29);
            textBox2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridViewCountries_OLM);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(374, 31);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 697);
            panel2.TabIndex = 2;
            // 
            // dataGridViewCountries_OLM
            // 
            dataGridViewCountries_OLM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCountries_OLM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCountries_OLM.BackgroundColor = Color.PaleTurquoise;
            dataGridViewCountries_OLM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountries_OLM.Location = new Point(0, 0);
            dataGridViewCountries_OLM.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCountries_OLM.Name = "dataGridViewCountries_OLM";
            dataGridViewCountries_OLM.ReadOnly = true;
            dataGridViewCountries_OLM.RowHeadersVisible = false;
            dataGridViewCountries_OLM.RowHeadersWidth = 51;
            dataGridViewCountries_OLM.Size = new Size(631, 697);
            dataGridViewCountries_OLM.TabIndex = 0;
            dataGridViewCountries_OLM.CellContentClick += dataGridViewCountries_OLM_CellContentClick;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(374, 31);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 697);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // buttonFilt_sq_OLM
            // 
            buttonFilt_sq_OLM.Location = new Point(198, 32);
            buttonFilt_sq_OLM.Name = "buttonFilt_sq_OLM";
            buttonFilt_sq_OLM.Size = new Size(54, 47);
            buttonFilt_sq_OLM.TabIndex = 5;
            buttonFilt_sq_OLM.Text = "button1";
            buttonFilt_sq_OLM.UseVisualStyleBackColor = true;
            // 
            // toolTip_mainform_OLM
            // 
            toolTip_mainform_OLM.IsBalloon = true;
            toolTip_mainform_OLM.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain_OLM
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 728);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip_MAIN_OLM);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1023, 611);
            Name = "FormMain_OLM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " 🌍 GeoAtlas Pro | База данных стран мира";
            menuStrip_MAIN_OLM.ResumeLayout(false);
            menuStrip_MAIN_OLM.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox_Info_Data_OLM.ResumeLayout(false);
            groupBox_filter_sq_OLM.ResumeLayout(false);
            groupBox_filter_sq_OLM.PerformLayout();
            groupBox_SR_POPUL_OLM.ResumeLayout(false);
            groupBox_SR_POPUL_OLM.PerformLayout();
            groupBox_Filter_popul_OLM.ResumeLayout(false);
            groupBoxMain_OLM.ResumeLayout(false);
            groupBoxMain_OLM.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries_OLM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridViewCountries_OLM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip_MAIN_OLM;
        private ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem анализДанныхToolStripMenuItem_OLM;
        private ToolStripMenuItem руководствоToolStripMenuItem_OLM;
        private ToolStripMenuItem оПрограммеToolStripMenuItem_OLM;
        private Panel panel2;
        private Splitter splitter1;
        private ToolStripMenuItem загпрузитьФайлToolStripMenuItem_OLM;
        private ToolStripMenuItem РаботаСфайломToolStripMenuItem_OLM;
        private GroupBox groupBoxMain_OLM;
        private Button button_search_OLM;
        private TextBox textBoxSearch_OLM;
        private DataGridView dataGridViewCountries_OLM;
        private GroupBox groupBox_Filter_OLM;
        private Label labelSort_OLM;
        private Label label1;
        private TextBox textBox2;
        private Label label_sr_popul_OLM;
        private Label labelFilt_sq_OLM;
        private GroupBox groupBox_Filter_popul_OLM;
        private Button buttonSortByPopulationDesc_OLM;
        private Button buttonSortByPopulationAsc_OLM;
        private GroupBox groupBox_SR_POPUL_OLM;
        private TextBox textBoxResultSr_OLM;
        private Button button_sr_populat_OLM;
        private Button buttonFilt_sq_OLM;
        private GroupBox groupBox_filter_sq_OLM;
        private Button buttonFilterByArea_OLM;
        private TextBox textBoxMinArea_OLM;
        private GroupBox groupBox_Info_Data_OLM;
        private Button button_info_WorkInProgr_OLM;
        private Button button_info_EditFail_OLM;
        private Button button_info_DIagram_OLM;
        private ToolTip toolTip_mainform_OLM;
        private ToolStripMenuItem выходToolStripMenuItem_OLM;
        private Button buttonCalculateAveragePopulation_OLM;
    }
}
