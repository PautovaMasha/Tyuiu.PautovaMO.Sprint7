using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PautovaMO.Sprint7.Project.V11
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        public FormStatistics((int count, decimal avg, decimal min, decimal max, decimal total) stats)
        {
            InitializeComponent();

            // Просто присваиваем значения
            textBoxCountRes_PMO.Text = stats.count.ToString();
            textBoxAvgSalaryRes_PMO.Text = $"{stats.avg:N2} руб.";
            textBoxMinSalaryRes_PMO.Text = $"{stats.min:N2} руб.";
            textBoxMaxSalaryRes_PMO.Text = $"{stats.max:N2} руб.";
            textBoxtotalSalaryRes_PMO.Text = $"{stats.total:N2} руб.";
        }
        private void buttonOk_PMO_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
