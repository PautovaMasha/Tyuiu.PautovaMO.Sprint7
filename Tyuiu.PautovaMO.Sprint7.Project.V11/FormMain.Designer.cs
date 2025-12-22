
namespace Tyuiu.PautovaMO.Sprint7.Project.V11
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel_PMO = new Panel();
            groupBoxInfo_PMO = new GroupBox();
            buttonAbout_PMO = new Button();
            buttonGuide_PMO = new Button();
            groupBoxTabl_PMO = new GroupBox();
            buttonStatic_PMO = new Button();
            buttonDelete_PMO = new Button();
            groupBoxAdd_PMO = new GroupBox();
            textBoxStazhInput_PMO = new TextBox();
            textBoxStazh_PMO = new TextBox();
            textBoxSalaryInput_PMO = new TextBox();
            textBoxSalary_PMO = new TextBox();
            textBoxPostInput_PMO = new TextBox();
            textBoxPost_PMO = new TextBox();
            textBoxNameInput_PMO = new TextBox();
            textBoxName_PMO = new TextBox();
            textBoxFamiliaInput_PMO = new TextBox();
            textBoxFamilia_PMO = new TextBox();
            buttonAdd_PMO = new Button();
            groupBoxFile_PMO = new GroupBox();
            buttonOpenFile_PMO = new Button();
            buttonSaveFile_PMO = new Button();
            groupBoxSearch_PMO = new GroupBox();
            textBoxSearch_PMO = new TextBox();
            buttonResetSearch_PMO = new Button();
            buttonSearch_PMO = new Button();
            splitter_PMO = new Splitter();
            dataGridViewEmployees_PMO = new DataGridView();
            openFileDialog_PMO = new OpenFileDialog();
            saveFileDialog_PMO = new SaveFileDialog();
            toolTip_PMO = new ToolTip(components);
            comboBoxFilter_PMO = new ComboBox();
            groupBoxFilter_PMO = new GroupBox();
            buttonDoneFilter_PMO = new Button();
            panel_PMO.SuspendLayout();
            groupBoxInfo_PMO.SuspendLayout();
            groupBoxTabl_PMO.SuspendLayout();
            groupBoxAdd_PMO.SuspendLayout();
            groupBoxFile_PMO.SuspendLayout();
            groupBoxSearch_PMO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees_PMO).BeginInit();
            groupBoxFilter_PMO.SuspendLayout();
            SuspendLayout();
            // 
            // panel_PMO
            // 
            panel_PMO.Controls.Add(groupBoxFilter_PMO);
            panel_PMO.Controls.Add(groupBoxInfo_PMO);
            panel_PMO.Controls.Add(groupBoxTabl_PMO);
            panel_PMO.Controls.Add(groupBoxAdd_PMO);
            panel_PMO.Controls.Add(groupBoxFile_PMO);
            panel_PMO.Controls.Add(groupBoxSearch_PMO);
            panel_PMO.Controls.Add(splitter_PMO);
            panel_PMO.Dock = DockStyle.Left;
            panel_PMO.Location = new Point(0, 0);
            panel_PMO.Name = "panel_PMO";
            panel_PMO.Size = new Size(331, 514);
            panel_PMO.TabIndex = 0;
            // 
            // groupBoxInfo_PMO
            // 
            groupBoxInfo_PMO.Controls.Add(buttonAbout_PMO);
            groupBoxInfo_PMO.Controls.Add(buttonGuide_PMO);
            groupBoxInfo_PMO.Location = new Point(0, 376);
            groupBoxInfo_PMO.Name = "groupBoxInfo_PMO";
            groupBoxInfo_PMO.Size = new Size(328, 84);
            groupBoxInfo_PMO.TabIndex = 2;
            groupBoxInfo_PMO.TabStop = false;
            groupBoxInfo_PMO.Text = "Информация";
            groupBoxInfo_PMO.Enter += groupBoxInfo_PMO_Enter;
            // 
            // buttonAbout_PMO
            // 
            buttonAbout_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonAbout_PMO.Image = (Image)resources.GetObject("buttonAbout_PMO.Image");
            buttonAbout_PMO.Location = new Point(175, 23);
            buttonAbout_PMO.Name = "buttonAbout_PMO";
            buttonAbout_PMO.Size = new Size(60, 53);
            buttonAbout_PMO.TabIndex = 1;
            buttonAbout_PMO.UseVisualStyleBackColor = false;
            buttonAbout_PMO.Click += buttonAbout_PMO_Click;
            // 
            // buttonGuide_PMO
            // 
            buttonGuide_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonGuide_PMO.Image = (Image)resources.GetObject("buttonGuide_PMO.Image");
            buttonGuide_PMO.Location = new Point(86, 23);
            buttonGuide_PMO.Name = "buttonGuide_PMO";
            buttonGuide_PMO.Size = new Size(62, 53);
            buttonGuide_PMO.TabIndex = 0;
            buttonGuide_PMO.UseVisualStyleBackColor = false;
            buttonGuide_PMO.Click += buttonGuide_PMO_Click;
            // 
            // groupBoxTabl_PMO
            // 
            groupBoxTabl_PMO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTabl_PMO.Controls.Add(buttonStatic_PMO);
            groupBoxTabl_PMO.Controls.Add(buttonDelete_PMO);
            groupBoxTabl_PMO.Location = new Point(3, 295);
            groupBoxTabl_PMO.Name = "groupBoxTabl_PMO";
            groupBoxTabl_PMO.Size = new Size(325, 141);
            groupBoxTabl_PMO.TabIndex = 11;
            groupBoxTabl_PMO.TabStop = false;
            groupBoxTabl_PMO.Text = "Работа с таблицей";
            // 
            // buttonStatic_PMO
            // 
            buttonStatic_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonStatic_PMO.Image = (Image)resources.GetObject("buttonStatic_PMO.Image");
            buttonStatic_PMO.Location = new Point(83, 22);
            buttonStatic_PMO.Name = "buttonStatic_PMO";
            buttonStatic_PMO.Size = new Size(62, 53);
            buttonStatic_PMO.TabIndex = 7;
            buttonStatic_PMO.UseVisualStyleBackColor = false;
            buttonStatic_PMO.Click += buttonStatic_PMO_Click;
            // 
            // buttonDelete_PMO
            // 
            buttonDelete_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonDelete_PMO.Image = (Image)resources.GetObject("buttonDelete_PMO.Image");
            buttonDelete_PMO.Location = new Point(172, 22);
            buttonDelete_PMO.Name = "buttonDelete_PMO";
            buttonDelete_PMO.Size = new Size(60, 53);
            buttonDelete_PMO.TabIndex = 2;
            buttonDelete_PMO.UseVisualStyleBackColor = false;
            buttonDelete_PMO.Click += buttonDelete_PMO_Click;
            // 
            // groupBoxAdd_PMO
            // 
            groupBoxAdd_PMO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxAdd_PMO.Controls.Add(textBoxStazhInput_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxStazh_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxSalaryInput_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxSalary_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxPostInput_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxPost_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxNameInput_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxName_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxFamiliaInput_PMO);
            groupBoxAdd_PMO.Controls.Add(textBoxFamilia_PMO);
            groupBoxAdd_PMO.Controls.Add(buttonAdd_PMO);
            groupBoxAdd_PMO.Location = new Point(3, 125);
            groupBoxAdd_PMO.Name = "groupBoxAdd_PMO";
            groupBoxAdd_PMO.Size = new Size(325, 247);
            groupBoxAdd_PMO.TabIndex = 2;
            groupBoxAdd_PMO.TabStop = false;
            groupBoxAdd_PMO.Text = "Добавление сотрудника";
            groupBoxAdd_PMO.Enter += groupBox1_Enter;
            // 
            // textBoxStazhInput_PMO
            // 
            textBoxStazhInput_PMO.Location = new Point(135, 141);
            textBoxStazhInput_PMO.Name = "textBoxStazhInput_PMO";
            textBoxStazhInput_PMO.Size = new Size(100, 23);
            textBoxStazhInput_PMO.TabIndex = 10;
            textBoxStazhInput_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxStazh_PMO
            // 
            textBoxStazh_PMO.Location = new Point(6, 141);
            textBoxStazh_PMO.Name = "textBoxStazh_PMO";
            textBoxStazh_PMO.ReadOnly = true;
            textBoxStazh_PMO.Size = new Size(123, 23);
            textBoxStazh_PMO.TabIndex = 10;
            textBoxStazh_PMO.Text = "Введите стаж";
            textBoxStazh_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxSalaryInput_PMO
            // 
            textBoxSalaryInput_PMO.Location = new Point(135, 112);
            textBoxSalaryInput_PMO.Name = "textBoxSalaryInput_PMO";
            textBoxSalaryInput_PMO.Size = new Size(100, 23);
            textBoxSalaryInput_PMO.TabIndex = 10;
            textBoxSalaryInput_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxSalary_PMO
            // 
            textBoxSalary_PMO.Location = new Point(6, 109);
            textBoxSalary_PMO.Name = "textBoxSalary_PMO";
            textBoxSalary_PMO.ReadOnly = true;
            textBoxSalary_PMO.Size = new Size(123, 23);
            textBoxSalary_PMO.TabIndex = 10;
            textBoxSalary_PMO.Text = "Введите зарплату";
            textBoxSalary_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxPostInput_PMO
            // 
            textBoxPostInput_PMO.Location = new Point(135, 80);
            textBoxPostInput_PMO.Name = "textBoxPostInput_PMO";
            textBoxPostInput_PMO.Size = new Size(100, 23);
            textBoxPostInput_PMO.TabIndex = 10;
            textBoxPostInput_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxPost_PMO
            // 
            textBoxPost_PMO.Location = new Point(6, 80);
            textBoxPost_PMO.Name = "textBoxPost_PMO";
            textBoxPost_PMO.ReadOnly = true;
            textBoxPost_PMO.Size = new Size(123, 23);
            textBoxPost_PMO.TabIndex = 10;
            textBoxPost_PMO.Text = "Введите должность";
            textBoxPost_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxNameInput_PMO
            // 
            textBoxNameInput_PMO.Location = new Point(135, 51);
            textBoxNameInput_PMO.Name = "textBoxNameInput_PMO";
            textBoxNameInput_PMO.Size = new Size(100, 23);
            textBoxNameInput_PMO.TabIndex = 10;
            textBoxNameInput_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxName_PMO
            // 
            textBoxName_PMO.Location = new Point(6, 51);
            textBoxName_PMO.Name = "textBoxName_PMO";
            textBoxName_PMO.ReadOnly = true;
            textBoxName_PMO.Size = new Size(123, 23);
            textBoxName_PMO.TabIndex = 10;
            textBoxName_PMO.Text = "Введите имя";
            textBoxName_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxFamiliaInput_PMO
            // 
            textBoxFamiliaInput_PMO.Location = new Point(135, 22);
            textBoxFamiliaInput_PMO.Name = "textBoxFamiliaInput_PMO";
            textBoxFamiliaInput_PMO.Size = new Size(100, 23);
            textBoxFamiliaInput_PMO.TabIndex = 10;
            textBoxFamiliaInput_PMO.TextChanged += textBox2_TextChanged;
            // 
            // textBoxFamilia_PMO
            // 
            textBoxFamilia_PMO.Location = new Point(6, 22);
            textBoxFamilia_PMO.Name = "textBoxFamilia_PMO";
            textBoxFamilia_PMO.ReadOnly = true;
            textBoxFamilia_PMO.Size = new Size(123, 23);
            textBoxFamilia_PMO.TabIndex = 10;
            textBoxFamilia_PMO.Text = "Введите фамилию";
            textBoxFamilia_PMO.TextChanged += textBox2_TextChanged;
            // 
            // buttonAdd_PMO
            // 
            buttonAdd_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonAdd_PMO.Image = (Image)resources.GetObject("buttonAdd_PMO.Image");
            buttonAdd_PMO.Location = new Point(251, 120);
            buttonAdd_PMO.Name = "buttonAdd_PMO";
            buttonAdd_PMO.Size = new Size(59, 44);
            buttonAdd_PMO.TabIndex = 6;
            buttonAdd_PMO.UseVisualStyleBackColor = false;
            buttonAdd_PMO.Click += buttonAdd_PMO_Click;
            // 
            // groupBoxFile_PMO
            // 
            groupBoxFile_PMO.Controls.Add(buttonOpenFile_PMO);
            groupBoxFile_PMO.Controls.Add(buttonSaveFile_PMO);
            groupBoxFile_PMO.Location = new Point(3, 48);
            groupBoxFile_PMO.Name = "groupBoxFile_PMO";
            groupBoxFile_PMO.Size = new Size(325, 82);
            groupBoxFile_PMO.TabIndex = 9;
            groupBoxFile_PMO.TabStop = false;
            groupBoxFile_PMO.Text = "Работа с файлом";
            // 
            // buttonOpenFile_PMO
            // 
            buttonOpenFile_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonOpenFile_PMO.Image = (Image)resources.GetObject("buttonOpenFile_PMO.Image");
            buttonOpenFile_PMO.Location = new Point(83, 22);
            buttonOpenFile_PMO.Name = "buttonOpenFile_PMO";
            buttonOpenFile_PMO.Size = new Size(62, 49);
            buttonOpenFile_PMO.TabIndex = 4;
            buttonOpenFile_PMO.UseVisualStyleBackColor = false;
            buttonOpenFile_PMO.Click += buttonOpenFile_PMO_Click;
            // 
            // buttonSaveFile_PMO
            // 
            buttonSaveFile_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonSaveFile_PMO.Image = (Image)resources.GetObject("buttonSaveFile_PMO.Image");
            buttonSaveFile_PMO.Location = new Point(172, 22);
            buttonSaveFile_PMO.Name = "buttonSaveFile_PMO";
            buttonSaveFile_PMO.Size = new Size(60, 49);
            buttonSaveFile_PMO.TabIndex = 3;
            buttonSaveFile_PMO.UseVisualStyleBackColor = false;
            buttonSaveFile_PMO.Click += buttonSaveFile_PMO_Click;
            // 
            // groupBoxSearch_PMO
            // 
            groupBoxSearch_PMO.Controls.Add(textBoxSearch_PMO);
            groupBoxSearch_PMO.Controls.Add(buttonResetSearch_PMO);
            groupBoxSearch_PMO.Controls.Add(buttonSearch_PMO);
            groupBoxSearch_PMO.Location = new Point(3, 0);
            groupBoxSearch_PMO.Name = "groupBoxSearch_PMO";
            groupBoxSearch_PMO.Size = new Size(325, 53);
            groupBoxSearch_PMO.TabIndex = 8;
            groupBoxSearch_PMO.TabStop = false;
            groupBoxSearch_PMO.Text = "Поиск сотрудника";
            // 
            // textBoxSearch_PMO
            // 
            textBoxSearch_PMO.Location = new Point(6, 19);
            textBoxSearch_PMO.Name = "textBoxSearch_PMO";
            textBoxSearch_PMO.Size = new Size(226, 23);
            textBoxSearch_PMO.TabIndex = 9;
            // 
            // buttonResetSearch_PMO
            // 
            buttonResetSearch_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonResetSearch_PMO.Image = (Image)resources.GetObject("buttonResetSearch_PMO.Image");
            buttonResetSearch_PMO.Location = new Point(282, 12);
            buttonResetSearch_PMO.Name = "buttonResetSearch_PMO";
            buttonResetSearch_PMO.Size = new Size(38, 35);
            buttonResetSearch_PMO.TabIndex = 5;
            buttonResetSearch_PMO.UseVisualStyleBackColor = false;
            buttonResetSearch_PMO.Click += buttonResetSearch_PMO_Click;
            // 
            // buttonSearch_PMO
            // 
            buttonSearch_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonSearch_PMO.Image = (Image)resources.GetObject("buttonSearch_PMO.Image");
            buttonSearch_PMO.Location = new Point(238, 12);
            buttonSearch_PMO.Name = "buttonSearch_PMO";
            buttonSearch_PMO.Size = new Size(38, 35);
            buttonSearch_PMO.TabIndex = 5;
            buttonSearch_PMO.UseVisualStyleBackColor = false;
            buttonSearch_PMO.Click += buttonSearch_PMO_Click;
            // 
            // splitter_PMO
            // 
            splitter_PMO.Dock = DockStyle.Right;
            splitter_PMO.Location = new Point(328, 0);
            splitter_PMO.Name = "splitter_PMO";
            splitter_PMO.Size = new Size(3, 514);
            splitter_PMO.TabIndex = 1;
            splitter_PMO.TabStop = false;
            // 
            // dataGridViewEmployees_PMO
            // 
            dataGridViewEmployees_PMO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees_PMO.Dock = DockStyle.Fill;
            dataGridViewEmployees_PMO.Location = new Point(331, 0);
            dataGridViewEmployees_PMO.Name = "dataGridViewEmployees_PMO";
            dataGridViewEmployees_PMO.Size = new Size(541, 514);
            dataGridViewEmployees_PMO.TabIndex = 1;
            dataGridViewEmployees_PMO.CellContentClick += dataGridView1_CellContentClick;
            // 
            // openFileDialog_PMO
            // 
            openFileDialog_PMO.FileName = "openFileDialog1";
            // 
            // comboBoxFilter_PMO
            // 
            comboBoxFilter_PMO.FormattingEnabled = true;
            comboBoxFilter_PMO.Items.AddRange(new object[] { "по зарплате ", "по стажу", "по должности" });
            comboBoxFilter_PMO.Location = new Point(9, 21);
            comboBoxFilter_PMO.Name = "comboBoxFilter_PMO";
            comboBoxFilter_PMO.Size = new Size(136, 23);
            comboBoxFilter_PMO.TabIndex = 12;
            // 
            // groupBoxFilter_PMO
            // 
            groupBoxFilter_PMO.Controls.Add(buttonDoneFilter_PMO);
            groupBoxFilter_PMO.Controls.Add(comboBoxFilter_PMO);
            groupBoxFilter_PMO.Location = new Point(3, 458);
            groupBoxFilter_PMO.Name = "groupBoxFilter_PMO";
            groupBoxFilter_PMO.Size = new Size(325, 56);
            groupBoxFilter_PMO.TabIndex = 13;
            groupBoxFilter_PMO.TabStop = false;
            groupBoxFilter_PMO.Text = "Фильтр таблицы";
            // 
            // buttonDoneFilter_PMO
            // 
            buttonDoneFilter_PMO.Location = new Point(160, 21);
            buttonDoneFilter_PMO.Name = "buttonDoneFilter_PMO";
            buttonDoneFilter_PMO.Size = new Size(72, 23);
            buttonDoneFilter_PMO.TabIndex = 13;
            buttonDoneFilter_PMO.UseVisualStyleBackColor = true;
            buttonDoneFilter_PMO.Click += buttonDoneFilter_PMO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 514);
            Controls.Add(dataGridViewEmployees_PMO);
            Controls.Add(panel_PMO);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отдел кадров";
            Load += FormMain_Load;
            panel_PMO.ResumeLayout(false);
            groupBoxInfo_PMO.ResumeLayout(false);
            groupBoxTabl_PMO.ResumeLayout(false);
            groupBoxAdd_PMO.ResumeLayout(false);
            groupBoxAdd_PMO.PerformLayout();
            groupBoxFile_PMO.ResumeLayout(false);
            groupBoxSearch_PMO.ResumeLayout(false);
            groupBoxSearch_PMO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees_PMO).EndInit();
            groupBoxFilter_PMO.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel_PMO;
        private Splitter splitter_PMO;
        private DataGridView dataGridViewEmployees_PMO;
        private Button buttonStatic_PMO;
        private Button buttonAdd_PMO;
        private Button buttonSearch_PMO;
        private Button buttonOpenFile_PMO;
        private Button buttonSaveFile_PMO;
        private Button buttonDelete_PMO;
        private GroupBox groupBoxSearch_PMO;
        private GroupBox groupBoxFile_PMO;
        private GroupBox groupBoxAdd_PMO;
        private TextBox textBoxFamilia_PMO;
        private TextBox textBoxPost_PMO;
        private TextBox textBoxName_PMO;
        private TextBox textBoxStazh_PMO;
        private TextBox textBoxSalary_PMO;
        private TextBox textBoxFamiliaInput_PMO;
        private TextBox textBoxSalaryInput_PMO;
        private TextBox textBoxPostInput_PMO;
        private TextBox textBoxNameInput_PMO;
        private TextBox textBoxStazhInput_PMO;
        private GroupBox groupBoxTabl_PMO;
        private GroupBox groupBoxInfo_PMO;
        private Button buttonAbout_PMO;
        private Button buttonGuide_PMO;
        private OpenFileDialog openFileDialog_PMO;
        private SaveFileDialog saveFileDialog_PMO;
        private ToolTip toolTip_PMO;
        private Button buttonResetSearch_PMO;
        private TextBox textBoxSearch_PMO;
        private GroupBox groupBoxFilter_PMO;
        private ComboBox comboBoxFilter_PMO;
        private Button buttonDoneFilter_PMO;
    }
}
