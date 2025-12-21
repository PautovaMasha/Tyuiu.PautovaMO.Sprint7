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

        private void buttonAdd_PMO_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_PMO_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_PMO_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonSaveFile_PMO_Click(object sender, EventArgs e)
        {

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

            
            FormStatistics formStats = new FormStatistics(stats);
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
    }
}
