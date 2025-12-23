namespace Tyuiu.PautovaMO.Sprint7.Project.V11
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartEmployees_PMO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxCount_PMO = new TextBox();
            buttonOk_PMO = new Button();
            textBoxCountRes_PMO = new TextBox();
            textBoxAvgSalary_PMO = new TextBox();
            textBoxAvgSalaryRes_PMO = new TextBox();
            textBoxMinSalary_PMO = new TextBox();
            textBoxMinSalaryRes_PMO = new TextBox();
            textBoxMaxSalary_PMO = new TextBox();
            textBoxMaxSalaryRes_PMO = new TextBox();
            textBoxtotalSalary_PMO = new TextBox();
            textBoxtotalSalaryRes_PMO = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chartEmployees_PMO).BeginInit();
            SuspendLayout();
            // 
            // chartEmployees_PMO
            // 
            chartArea1.Name = "chartEmployees_PMO";
            chartEmployees_PMO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartEmployees_PMO.Legends.Add(legend1);
            chartEmployees_PMO.Location = new Point(326, 12);
            chartEmployees_PMO.Name = "chartEmployees_PMO";
            series1.ChartArea = "chartEmployees_PMO";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartEmployees_PMO.Series.Add(series1);
            chartEmployees_PMO.Size = new Size(416, 317);
            chartEmployees_PMO.TabIndex = 0;
            chartEmployees_PMO.Text = "Статистика";
            chartEmployees_PMO.Click += chartEmployees_PMO_Click;
            // 
            // textBoxCount_PMO
            // 
            textBoxCount_PMO.Location = new Point(22, 65);
            textBoxCount_PMO.Multiline = true;
            textBoxCount_PMO.Name = "textBoxCount_PMO";
            textBoxCount_PMO.ReadOnly = true;
            textBoxCount_PMO.Size = new Size(155, 23);
            textBoxCount_PMO.TabIndex = 1;
            textBoxCount_PMO.Text = "Количество работников :";
            // 
            // buttonOk_PMO
            // 
            buttonOk_PMO.BackColor = SystemColors.GradientActiveCaption;
            buttonOk_PMO.Location = new Point(209, 289);
            buttonOk_PMO.Name = "buttonOk_PMO";
            buttonOk_PMO.Size = new Size(97, 40);
            buttonOk_PMO.TabIndex = 2;
            buttonOk_PMO.Text = "Ok";
            buttonOk_PMO.UseVisualStyleBackColor = false;
            buttonOk_PMO.Click += buttonOk_PMO_Click;
            // 
            // textBoxCountRes_PMO
            // 
            textBoxCountRes_PMO.Location = new Point(183, 65);
            textBoxCountRes_PMO.Multiline = true;
            textBoxCountRes_PMO.Name = "textBoxCountRes_PMO";
            textBoxCountRes_PMO.ReadOnly = true;
            textBoxCountRes_PMO.Size = new Size(123, 23);
            textBoxCountRes_PMO.TabIndex = 1;
            textBoxCountRes_PMO.TextChanged += textBoxCountRes_PMO_TextChanged;
            // 
            // textBoxAvgSalary_PMO
            // 
            textBoxAvgSalary_PMO.Location = new Point(22, 94);
            textBoxAvgSalary_PMO.Multiline = true;
            textBoxAvgSalary_PMO.Name = "textBoxAvgSalary_PMO";
            textBoxAvgSalary_PMO.ReadOnly = true;
            textBoxAvgSalary_PMO.Size = new Size(155, 23);
            textBoxAvgSalary_PMO.TabIndex = 1;
            textBoxAvgSalary_PMO.Text = "Средняя зарплата :";
            // 
            // textBoxAvgSalaryRes_PMO
            // 
            textBoxAvgSalaryRes_PMO.Location = new Point(183, 94);
            textBoxAvgSalaryRes_PMO.Multiline = true;
            textBoxAvgSalaryRes_PMO.Name = "textBoxAvgSalaryRes_PMO";
            textBoxAvgSalaryRes_PMO.ReadOnly = true;
            textBoxAvgSalaryRes_PMO.Size = new Size(123, 23);
            textBoxAvgSalaryRes_PMO.TabIndex = 1;
            // 
            // textBoxMinSalary_PMO
            // 
            textBoxMinSalary_PMO.Location = new Point(22, 123);
            textBoxMinSalary_PMO.Multiline = true;
            textBoxMinSalary_PMO.Name = "textBoxMinSalary_PMO";
            textBoxMinSalary_PMO.ReadOnly = true;
            textBoxMinSalary_PMO.Size = new Size(155, 23);
            textBoxMinSalary_PMO.TabIndex = 1;
            textBoxMinSalary_PMO.Text = "Минимальная зарплата :";
            // 
            // textBoxMinSalaryRes_PMO
            // 
            textBoxMinSalaryRes_PMO.Location = new Point(183, 123);
            textBoxMinSalaryRes_PMO.Multiline = true;
            textBoxMinSalaryRes_PMO.Name = "textBoxMinSalaryRes_PMO";
            textBoxMinSalaryRes_PMO.ReadOnly = true;
            textBoxMinSalaryRes_PMO.Size = new Size(123, 23);
            textBoxMinSalaryRes_PMO.TabIndex = 1;
            // 
            // textBoxMaxSalary_PMO
            // 
            textBoxMaxSalary_PMO.Location = new Point(22, 152);
            textBoxMaxSalary_PMO.Multiline = true;
            textBoxMaxSalary_PMO.Name = "textBoxMaxSalary_PMO";
            textBoxMaxSalary_PMO.ReadOnly = true;
            textBoxMaxSalary_PMO.Size = new Size(155, 23);
            textBoxMaxSalary_PMO.TabIndex = 1;
            textBoxMaxSalary_PMO.Text = "Максимальная зарплата : ";
            // 
            // textBoxMaxSalaryRes_PMO
            // 
            textBoxMaxSalaryRes_PMO.Location = new Point(183, 152);
            textBoxMaxSalaryRes_PMO.Multiline = true;
            textBoxMaxSalaryRes_PMO.Name = "textBoxMaxSalaryRes_PMO";
            textBoxMaxSalaryRes_PMO.ReadOnly = true;
            textBoxMaxSalaryRes_PMO.Size = new Size(123, 23);
            textBoxMaxSalaryRes_PMO.TabIndex = 1;
            // 
            // textBoxtotalSalary_PMO
            // 
            textBoxtotalSalary_PMO.Location = new Point(22, 181);
            textBoxtotalSalary_PMO.Multiline = true;
            textBoxtotalSalary_PMO.Name = "textBoxtotalSalary_PMO";
            textBoxtotalSalary_PMO.ReadOnly = true;
            textBoxtotalSalary_PMO.Size = new Size(155, 23);
            textBoxtotalSalary_PMO.TabIndex = 1;
            textBoxtotalSalary_PMO.Text = "Общая сумма зарплат : ";
            // 
            // textBoxtotalSalaryRes_PMO
            // 
            textBoxtotalSalaryRes_PMO.Location = new Point(183, 181);
            textBoxtotalSalaryRes_PMO.Multiline = true;
            textBoxtotalSalaryRes_PMO.Name = "textBoxtotalSalaryRes_PMO";
            textBoxtotalSalaryRes_PMO.ReadOnly = true;
            textBoxtotalSalaryRes_PMO.Size = new Size(123, 23);
            textBoxtotalSalaryRes_PMO.TabIndex = 1;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 341);
            Controls.Add(buttonOk_PMO);
            Controls.Add(textBoxtotalSalaryRes_PMO);
            Controls.Add(textBoxMaxSalaryRes_PMO);
            Controls.Add(textBoxMinSalaryRes_PMO);
            Controls.Add(textBoxAvgSalaryRes_PMO);
            Controls.Add(textBoxtotalSalary_PMO);
            Controls.Add(textBoxMaxSalary_PMO);
            Controls.Add(textBoxMinSalary_PMO);
            Controls.Add(textBoxCountRes_PMO);
            Controls.Add(textBoxAvgSalary_PMO);
            Controls.Add(textBoxCount_PMO);
            Controls.Add(chartEmployees_PMO);
            MaximizeBox = false;
            MaximumSize = new Size(770, 380);
            MinimizeBox = false;
            MinimumSize = new Size(770, 380);
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)chartEmployees_PMO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployees_PMO;
        private TextBox textBoxCount_PMO;
        private Button buttonOk_PMO;
        private TextBox textBoxCountRes_PMO;
        private TextBox textBoxAvgSalary_PMO;
        private TextBox textBoxAvgSalaryRes_PMO;
        private TextBox textBoxMinSalary_PMO;
        private TextBox textBoxMinSalaryRes_PMO;
        private TextBox textBoxMaxSalary_PMO;
        private TextBox textBoxMaxSalaryRes_PMO;
        private TextBox textBoxtotalSalary_PMO;
        private TextBox textBoxtotalSalaryRes_PMO;
    }
}