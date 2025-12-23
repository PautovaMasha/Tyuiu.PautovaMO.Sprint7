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

        private List<Employee> employees;
        private DataService ds = new DataService(); 

        public FormStatistics(List<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;

            
            var stats = ds.GetStatistics(employees);

            // Выводим статистику
            textBoxCountRes_PMO.Text = stats.count.ToString();
            textBoxAvgSalaryRes_PMO.Text = $"{stats.avgSalary:N2} руб.";
            textBoxMinSalaryRes_PMO.Text = $"{stats.minSalary:N2} руб.";
            textBoxMaxSalaryRes_PMO.Text = $"{stats.maxSalary:N2} руб.";
            textBoxtotalSalaryRes_PMO.Text = $"{stats.totalSalary:N2} руб.";

            // Строим диаграмму
            BuildChart();
        }

        private void BuildChart()
        {
            if (employees == null || employees.Count == 0) return;

            chartEmployees_PMO.Series.Clear();
            chartEmployees_PMO.Titles.Clear();

            
            chartEmployees_PMO.Titles.Add($"Распределение по должностям\nВсего сотрудников: {employees.Count}");
            chartEmployees_PMO.Titles[0].Font = new Font("Arial", 11, FontStyle.Bold);

            // Создаем кольцевую диаграмму
            Series series = new Series("Должности");
            series.ChartType = SeriesChartType.Doughnut; 

            // Настройки отображения
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT{P1}"; // Процент с одним знаком после запятой
            series.Font = new Font("Arial", 9, FontStyle.Bold);
            series.BorderWidth = 2;
            series.BorderColor = Color.White;

            // Толщина кольца (30% радиуса)
            series["DoughnutRadius"] = "30";

            // Группируем данные
            var groups = employees
                .GroupBy(e => e.Position)
                .Select(g => new
                {
                    Position = g.Key,
                    Count = g.Count(),
                    Percentage = (double)g.Count() / employees.Count * 100
                })
                .OrderByDescending(g => g.Count)
                .ToList();

            // Цветовая палитра
            Color[] palette =
            {
        Color.FromArgb(65, 105, 225),   // RoyalBlue
        Color.FromArgb(220, 20, 60),    // Crimson
        Color.FromArgb(34, 139, 34),    // ForestGreen
        Color.FromArgb(255, 140, 0),    // DarkOrange
        Color.FromArgb(138, 43, 226),   // BlueViolet
        Color.FromArgb(255, 215, 0),    // Gold
        Color.FromArgb(50, 205, 50),    // LimeGreen
        Color.FromArgb(199, 21, 133)    // MediumVioletRed
    };

            // Добавляем данные
            for (int i = 0; i < groups.Count; i++)
            {
                var group = groups[i];

                DataPoint point = new DataPoint();
                point.SetValueXY(group.Position, group.Count);
                point.Color = palette[i % palette.Length];
                point.LegendText = $"{group.Position} ({group.Count})";
                point.Label = $"{group.Percentage:F1}%";
                point.ToolTip = $"{group.Position}\n{group.Count} сотрудников\n{group.Percentage:F1}%";

                series.Points.Add(point);
            }

            chartEmployees_PMO.Series.Add(series);

            
        }


        private void FormStatistics_Load(object sender, EventArgs e)
        {
            this.Text = $"Статистика сотрудников";
        }
    


        private void FormChart_Load(object sender, EventArgs e)
        {
 
        }
    


        private void buttonOk_PMO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chartEmployees_PMO_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
