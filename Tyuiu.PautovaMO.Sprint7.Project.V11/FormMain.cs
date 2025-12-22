using System.Collections.Generic;
using Tyuiu.PautovaMO.Sprint7.Project.V11.Lib;
namespace Tyuiu.PautovaMO.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_PMO.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_PMO.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        private List<Employee> currentEmployees_PMO = new List<Employee>();
        static int rows;
        static int columns;
        static string openFilePath_PMO;
        DataService ds = new DataService();
        private void buttonOpenFile_PMO_Click(object sender, EventArgs e)
        {
            if (openFileDialog_PMO.ShowDialog() == DialogResult.OK)
            {
                openFilePath_PMO = openFileDialog_PMO.FileName;

                try
                {

                    currentEmployees_PMO = ds.LoadFromCSV(openFilePath_PMO);

                    // Настраиваем DataGridView для отображения данных
                    dataGridViewEmployees_PMO.ColumnCount = 5;
                    dataGridViewEmployees_PMO.RowCount = currentEmployees_PMO.Count;

                    dataGridViewEmployees_PMO.Columns[0].HeaderText = "Фамилия";
                    dataGridViewEmployees_PMO.Columns[1].HeaderText = "Имя";
                    dataGridViewEmployees_PMO.Columns[2].HeaderText = "Должность";
                    dataGridViewEmployees_PMO.Columns[3].HeaderText = "Зарплата";
                    dataGridViewEmployees_PMO.Columns[4].HeaderText = "Стаж (лет)";


                    for (int i = 0; i < 5; i++)
                    {
                        dataGridViewEmployees_PMO.Columns[i].Width = 75;
                    }

                    // Заполняем DataGridView данными
                    for (int r = 0; r < currentEmployees_PMO.Count; r++)
                    {
                        dataGridViewEmployees_PMO.Rows[r].Cells[0].Value = currentEmployees_PMO[r].LastName;
                        dataGridViewEmployees_PMO.Rows[r].Cells[1].Value = currentEmployees_PMO[r].FirstName;
                        dataGridViewEmployees_PMO.Rows[r].Cells[2].Value = currentEmployees_PMO[r].Position;
                        dataGridViewEmployees_PMO.Rows[r].Cells[3].Value = currentEmployees_PMO[r].Salary.ToString("N2");
                        dataGridViewEmployees_PMO.Rows[r].Cells[4].Value = currentEmployees_PMO[r].Experience.ToString();
                    }


                    buttonSaveFile_PMO.Enabled = true;
                    buttonSearch_PMO.Enabled = true;

                    //buttonFilter_PMO.Enabled = true;
                    buttonAdd_PMO.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonSearch_PMO_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_PMO.Text.Trim();

            // ВСЕГДА начинаем с очистки таблицы
            dataGridViewEmployees_PMO.Rows.Clear();

            List<Employee> employeesToShow;

            if (string.IsNullOrEmpty(searchText)) //?????
            {
                // Показываем всех
                employeesToShow = currentEmployees_PMO;
                this.Text = "Отдел кадров - Все сотрудники";
            }
            else
            {
                // Показываем найденных
                employeesToShow = ds.SearchAll(currentEmployees_PMO, searchText);
                this.Text = $"Отдел кадров - Найдено: {employeesToShow.Count}";

                if (employeesToShow.Count == 0)
                    MessageBox.Show("Ничего не найдено");
            }

            // Заполняем dataGridViewEmployees_PMO
            foreach (Employee emp in employeesToShow)
            {
                dataGridViewEmployees_PMO.Rows.Add(
                    emp.LastName,
                    emp.FirstName,
                    emp.Position,
                    emp.Salary.ToString("N2"),
                    emp.Experience
                );
            }
        }



        private void buttonResetSearch_PMO_Click(object sender, EventArgs e)
        {
            // Очищаем поле поиска
            textBoxSearch_PMO.Clear();

            // Очищаем таблицу и показываем ВСЕХ
            dataGridViewEmployees_PMO.Rows.Clear();

            foreach (Employee emp in currentEmployees_PMO)
            {
                dataGridViewEmployees_PMO.Rows.Add(
                    emp.LastName,
                    emp.FirstName,
                    emp.Position,
                    emp.Salary.ToString("N2"),
                    emp.Experience.ToString()
                );
            }
        }

        private void buttonDelete_PMO_Click(object sender, EventArgs e)
        {

            if (dataGridViewEmployees_PMO.SelectedRows.Count == 0)
            {
                return;
            }

            // Получаем выбранную строку
            DataGridViewRow selectedRow = dataGridViewEmployees_PMO.SelectedRows[0];
            int rowIndex = selectedRow.Index;

            // Получаем данные из таблицы
            string lastName = selectedRow.Cells[0].Value?.ToString() ?? "";
            string firstName = selectedRow.Cells[1].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(lastName))
            {
                return;
            }

            try
            {
                // Находим сотрудника в списке
                Employee employeeToDelete = currentEmployees_PMO.FirstOrDefault(emp => emp.LastName == lastName && emp.FirstName == firstName);

                if (employeeToDelete != null)
                {

                    bool isDeleted = ds.RemoveEmployee(employeeToDelete);

                    if (isDeleted)
                    {
                        // Удаляем из текущего списка
                        currentEmployees_PMO.Remove(employeeToDelete);

                        // Удаляем строку из таблицы
                        dataGridViewEmployees_PMO.Rows.RemoveAt(rowIndex);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        private void buttonAdd_PMO_Click(object sender, EventArgs e)
        {
            // Проверяем заполнение
            if (textBoxFamiliaInput_PMO.Text == "" || textBoxNameInput_PMO.Text == "")
            {
                MessageBox.Show("Заполните фамилию и имя");
                return;
            }

            try
            {
                // Создаем сотрудника
                Employee emp = new Employee
                {
                    LastName = textBoxFamiliaInput_PMO.Text,
                    FirstName = textBoxNameInput_PMO.Text,
                    Position = textBoxPostInput_PMO.Text,
                    Salary = decimal.Parse(textBoxSalaryInput_PMO.Text),
                    Experience = int.Parse(textBoxStazhInput_PMO.Text)
                };

                // Добавляем
                DataService ds = new DataService();
                ds.AddEmployee(emp);

                // Добавляем в таблицу
                dataGridViewEmployees_PMO.Rows.Add(
                    emp.LastName,
                    emp.FirstName,
                    emp.Position,
                    emp.Salary.ToString("N2"),
                    emp.Experience
                );

                // Очищаем поля
                textBoxFamiliaInput_PMO.Clear();
                textBoxNameInput_PMO.Clear();
                textBoxPostInput_PMO.Clear();
                textBoxSalaryInput_PMO.Clear();
                textBoxStazhInput_PMO.Clear();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных");
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файлы (*.csv)|*.csv";
            saveDialog.FileName = "сотрудники_обновленные.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ds.SaveToCSV(saveDialog.FileName, currentEmployees_PMO);
                MessageBox.Show("Сотрудник добавлен и данные сохранены!");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }









        private void buttonSaveFile_PMO_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файлы (*.csv)|*.csv";
            saveDialog.FileName = "сотрудники_обновленные.csv";
            saveDialog.Title = "Сохранить данные сотрудников";

            // 2. Предлагаем сохранить на рабочий стол по умолчанию
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // 3. Показываем диалог
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 4. Передаем ВЫБРАННЫЙ пользователем путь
                    ds.SaveToCSV(saveDialog.FileName, currentEmployees_PMO);

                    MessageBox.Show($"Файл сохранен:\n{saveDialog.FileName}",
                        "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonStatic_PMO_Click(object sender, EventArgs e)
        {
            if (currentEmployees_PMO.Count == 0)
            {
                MessageBox.Show("Нет данных для расчета статистики", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var stats = ds.GetStatistics(currentEmployees_PMO);


            FormStatistics formStats = new FormStatistics(stats, currentEmployees_PMO);
            formStats.ShowDialog();
        }

        private void buttonAbout_PMO_Click(object sender, EventArgs e)
        {
            FormAbout_PMO aboutForm = new FormAbout_PMO();

            aboutForm.ShowDialog();
        }

        private void buttonGuide_PMO_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxInfo_PMO_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDoneFilter_PMO_Click(object sender, EventArgs e)
        {

        }
    }
}
