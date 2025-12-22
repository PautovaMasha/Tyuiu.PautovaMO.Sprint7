using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.PautovaMO.Sprint7.Project.V11.Lib;

namespace Tyuiu.PautovaMO.Sprint7.Project.V11
{
    public partial class FormStatistics : Form
    {
        private List<Employee> currentEmployees_PMO;

        public FormStatistics((int count, decimal avg, decimal min, decimal max, decimal total) stats,
                             List<Employee> employees)
        {
            InitializeComponent();

            currentEmployees_PMO = employees ?? new List<Employee>();

            // Заполняем статистику
            textBoxCountRes_PMO.Text = stats.count.ToString();
            textBoxAvgSalaryRes_PMO.Text = $"{stats.avg:N2} руб.";
            textBoxMinSalaryRes_PMO.Text = $"{stats.min:N2} руб.";
            textBoxMaxSalaryRes_PMO.Text = $"{stats.max:N2} руб.";
            textBoxtotalSalaryRes_PMO.Text = $"{stats.total:N2} руб.";

            // Строим график
            if (currentEmployees_PMO.Count > 0)
            {
                BuildChart_PMO(currentEmployees_PMO);
            }
        }

        private void BuildChart_PMO(List<Employee> employees)
        {
            chartEmployees_PMO.Series.Clear();

            Series series = new Series();
            series.ChartType = SeriesChartType.Bar;

            var dict = new Dictionary<string, int>();
            foreach (var emp in employees)
            {
                if (!dict.ContainsKey(emp.Position))
                    dict[emp.Position] = 0;
                dict[emp.Position]++;
            }

            foreach (var item in dict)
            {
                series.Points.AddXY(item.Value, item.Key);
            }

            chartEmployees_PMO.Series.Add(series);
        }

        private void buttonOk_PMO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chartEmployees_PMO_Click(object sender, EventArgs e)
        {
            
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {

        }
    }
}
