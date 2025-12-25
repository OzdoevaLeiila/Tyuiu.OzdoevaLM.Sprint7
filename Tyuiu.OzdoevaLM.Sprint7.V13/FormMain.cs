using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.OzdoevaLM.Sprint7.Lib;

namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    public partial class FormMain_OLM : Form
    {
        private CountryManager _manager; // Менеджер данных


        public FormMain_OLM()
        {
            InitializeComponent();
            _manager = new CountryManager(); // Инициализация менеджера
        }

        private void РаботаСфайломToolStripMenuItem_OLM_Click(object sender, EventArgs e)
        {
            // Создаем объект формы FormFile
            FormFile_OLM formFile = new FormFile_OLM();

            // Показываем форму как отдельное окно
            formFile.ShowDialog();


        }

        private void анализДанныхToolStripMenuItem_OLM_Click(object sender, EventArgs e)
        {
            FormChart_OLM formChart = new FormChart_OLM();

            // Показываем форму как отдельное окно
            formChart.ShowDialog();
        }

        private void загпрузитьФайлToolStripMenuItem_OLM_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Выберите файл с данными"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загрузка данных через метод из CSVHelper
                    var countries = CSVHelper.LoadFromCsv(openFileDialog.FileName);

                    // Очистка текущих данных в менеджере
                    _manager.Countries.Clear();

                    // Добавление загруженных данных в менеджер
                    foreach (var country in countries)
                    {
                        _manager.Countries.Add(country);
                    }

                    // Привязываем данные к DataGridView
                    dataGridViewCountries_OLM.DataSource = null;
                    dataGridViewCountries_OLM.DataSource = _manager.Countries;

                    // Делаем кнопки доступными
                    button_search_OLM.Enabled = true;
                    buttonFilterByArea_OLM.Enabled = true;
                    buttonCalculateAveragePopulation_OLM.Enabled = true;
                    buttonSortByPopulationDesc_OLM.Enabled = true;
                    buttonSortByPopulationAsc_OLM.Enabled = true;
                    textBoxSearch_OLM.Enabled = true;
                    textBoxMinArea_OLM.Enabled = true;
                    textBoxResultSr_OLM.Enabled = true;



                    MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        

        private void button_search_OLM_Click(object sender, EventArgs e)
        {

            // Получаем текст для поиска
            var searchName = textBoxSearch_OLM.Text.Trim();

            // Выполняем поиск стран
            var results = _manager.SearchByName(searchName);

            if (results.Any()) // Если найдены совпадения
            {
                // Привязываем результат к DataGridView напрямую
                dataGridViewCountries_OLM.DataSource = results;
            }
            else
            {
                // Если ничего не найдено, выводим сообщение
                MessageBox.Show("Страна не найдена!", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonFilterByArea_OLM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxMinArea_OLM.Text, out double minArea))
            {
                var filteredCountries = _manager.FilterByMinArea(minArea);

                dataGridViewCountries_OLM.DataSource = null;
                dataGridViewCountries_OLM.DataSource = filteredCountries;
            }
            else
            {
                MessageBox.Show("Введите корректное значение минимальной площади!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCalculateAveragePopulation_OLM_Click(object sender, EventArgs e)
        {
            {
                // Получаем среднее значение населения
                var averagePopulation = _manager.CalculateAveragePopulation();

                // Проверяем, есть ли данные
                if (averagePopulation > 0)
                {
                    // Выводим результат в текстбокс 
                    textBoxResultSr_OLM.Text = averagePopulation.ToString("N0"); // Форматируем число с разделителями; 
                }
                else
                {
                    // Если данных нет, показываем сообщение об ошибке
                    MessageBox.Show("Нет данных для расчёта среднего значения населения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void buttonSortByPopulationDesc_OLM_Click(object sender, EventArgs e)
        {
            // Сортировка по убыванию населения (descending = true)
            var sortedCountries = _manager.SortByPopulation(descending: true);

            // Привязка данных к таблице
            dataGridViewCountries_OLM.DataSource = null;
            dataGridViewCountries_OLM.DataSource = sortedCountries;
        }

        private void buttonSortByPopulationAsc_OLM_Click(object sender, EventArgs e)
        {
            // Сортировка по возрастанию населения (descending = false)
            var sortedCountries = _manager.SortByPopulation(descending: false);

            // Привязка данных к таблице
            dataGridViewCountries_OLM.DataSource = null;
            dataGridViewCountries_OLM.DataSource = sortedCountries;
        }

        

        private void button_info_WorkInProgr_OLM_Click(object sender, EventArgs e)
        {
            FormInfMain_OLM forminfMain = new FormInfMain_OLM();

            // Показываем форму как отдельное окно
            forminfMain.ShowDialog();
        }

        private void button_info_EditFail_OLM_Click(object sender, EventArgs e)
        {
            FormFileEDIT_OLM formfileeditinf = new FormFileEDIT_OLM();
            formfileeditinf.ShowDialog();
        }

        private void выходToolStripMenuItem_OLM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_OLM_Click(object sender, EventArgs e)
        {

            FormInfProgram_OLM forminfOprogram = new FormInfProgram_OLM();
            forminfOprogram.ShowDialog();
        }

        private void button_info_DIagram_OLM_Click(object sender, EventArgs e)
        {
            FormFileChartInf_OLM formfileinf = new FormFileChartInf_OLM();
            formfileinf.ShowDialog();
        }

        
    }
}



    

