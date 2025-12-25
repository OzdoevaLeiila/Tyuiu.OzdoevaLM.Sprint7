using System;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.OzdoevaLM.Sprint7.Lib;

namespace Tyuiu.OzdoevaLM.Sprint7.V13
{
    public partial class FormFile_OLM : Form
    {
        private CountryManager _countryManager;

        public FormFile_OLM()
        {
            InitializeComponent();
            _countryManager = new CountryManager(); // Инициализация менеджера
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Привязка BindingList к DataGridView
            dataGridViewFileCountries_OLM.DataSource = _countryManager.Countries;
        }

        private void buttonLoadFile2_OLM_Click(object sender, EventArgs e)
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
                    // Загрузка данных из CSV
                    var countries = CSVHelper.LoadFromCsv(openFileDialog.FileName);

                    // Очистка текущих данных
                    _countryManager.Countries.Clear();

                    // Добавление загруженных стран
                    foreach (var country in countries)
                    {
                        _countryManager.Countries.Add(country);
                    }

                    // Привязка данных снова
                    dataGridViewFileCountries_OLM.DataSource = null; // Сбрасываем привязку
                    dataGridViewFileCountries_OLM.DataSource = _countryManager.Countries;
                    groupBoxFileWork_OLM.Enabled = true;
                    groupBoxFile_OLM.Enabled = true;
                    buttonSaveToCsv_OLM.Enabled = true;

                    MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void buttonAddCountry_OLM_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем заполнение полей
                if (string.IsNullOrWhiteSpace(textBoxCountryName_OLM.Text) ||
                string.IsNullOrWhiteSpace(textBoxCapital_OLM.Text) ||
                string.IsNullOrWhiteSpace(textBoxArea_OLM.Text) ||
                string.IsNullOrWhiteSpace(textBoxPopulation_OLM.Text) ||
                string.IsNullOrWhiteSpace(textBoxNationality_OLM.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверяем корректность числовых значений
                if (!double.TryParse(textBoxArea_OLM.Text, out double area))
                {
                    MessageBox.Show("Площадь должна быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(textBoxPopulation_OLM.Text, out long population))
                {
                    MessageBox.Show("Население должно быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создаем новую страну
                var newCountry = new Country
                {
                    Name = textBoxCountryName_OLM.Text,
                    Capital = textBoxCapital_OLM.Text,
                    Area = area,
                    Population = population,
                    PredominantNationality = textBoxNationality_OLM.Text,
                    IsDeveloped = checkBoxIsDeveloped_OLM.Checked
                };

                // Добавляем страну в список
                _countryManager.Countries.Add(newCountry);

                MessageBox.Show("Страна успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении страны: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEditCountry_OLM_Click(object sender, EventArgs e)
        {
            try
            {
                // Ищем страну по названию
                var countryToEdit = _countryManager.Countries.FirstOrDefault(c => c.Name == textBoxCountryName_OLM.Text);

                if (countryToEdit == null)
                {
                    MessageBox.Show("Страна не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Обновляем данные страны
                countryToEdit.Capital = textBoxCapital_OLM.Text;
                countryToEdit.Area = double.Parse(textBoxArea_OLM.Text);
                countryToEdit.Population = long.Parse(textBoxPopulation_OLM.Text);
                countryToEdit.PredominantNationality = textBoxNationality_OLM.Text;
                countryToEdit.IsDeveloped = checkBoxIsDeveloped_OLM.Checked;

                // Обновляем DataGridView
                _countryManager.Countries.ResetBindings();

                MessageBox.Show("Страна успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании страны: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveCountry_OLM_Click(object sender, EventArgs e)
        {
            try
            {
                // Удаляем страну по названию
                var success = _countryManager.RemoveCountry(textBoxCountryName_OLM.Text);

                if (success)
                {
                    MessageBox.Show("Страна успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Страна не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении страны: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonUpdateTable_OLM_Click(object sender, EventArgs e)
        {

            dataGridViewFileCountries_OLM.Refresh();
        }

        private void buttonSaveToCsv_OLM_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                    Title = "Сохранить данные в CSV"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Сохраняем данные из BindingList с помощью метода из библиотеки
                        CSVHelper.SaveToCsv(_countryManager.Countries.ToList(), saveFileDialog.FileName);

                        MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonCloseFormFile_OLM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonInfoFile_OLM_Click(object sender, EventArgs e)
        {
            FormFileEDIT_OLM formfileeditinf = new FormFileEDIT_OLM();
            formfileeditinf.ShowDialog();
        }

        private void buttonClearFields_OLM_Click(object sender, EventArgs e)
        {
            {
                textBoxCountryName_OLM.Text = string.Empty; // Очистка названия страны
                textBoxCapital_OLM.Text = string.Empty; // Очистка столицы
                textBoxArea_OLM.Text = string.Empty; // Очистка площади
                textBoxPopulation_OLM.Text = string.Empty; // Очистка населения
                textBoxNationality_OLM.Text = string.Empty; // Очистка национальности
                checkBoxIsDeveloped_OLM.Checked = false; // Сброс чекбокса
            }
        }

        private void FormFile_OLM_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFileCountries_OLM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelraz_OLM_Click(object sender, EventArgs e)
        {

        }
    }
}

