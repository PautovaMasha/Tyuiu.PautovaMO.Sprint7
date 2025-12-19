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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            splitter1 = new Splitter();
            dataGridView1 = new DataGridView();
            buttonDelete_PMO = new Button();
            buttonSaveFile_PMO = new Button();
            buttonOpenFile_PMO = new Button();
            buttonSearch_PMO = new Button();
            buttonAdd_PMO = new Button();
            buttonStatic_PMO = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(buttonStatic_PMO);
            panel1.Controls.Add(buttonAdd_PMO);
            panel1.Controls.Add(buttonSearch_PMO);
            panel1.Controls.Add(buttonOpenFile_PMO);
            panel1.Controls.Add(buttonSaveFile_PMO);
            panel1.Controls.Add(buttonDelete_PMO);
            panel1.Controls.Add(splitter1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 418);
            panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(252, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 418);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(659, 418);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonDelete_PMO
            // 
            buttonDelete_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonDelete_PMO.Image = (Image)resources.GetObject("buttonDelete_PMO.Image");
            buttonDelete_PMO.Location = new Point(96, 189);
            buttonDelete_PMO.Name = "buttonDelete_PMO";
            buttonDelete_PMO.Size = new Size(60, 44);
            buttonDelete_PMO.TabIndex = 2;
            buttonDelete_PMO.UseVisualStyleBackColor = false;
            // 
            // buttonSaveFile_PMO
            // 
            buttonSaveFile_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonSaveFile_PMO.Image = (Image)resources.GetObject("buttonSaveFile_PMO.Image");
            buttonSaveFile_PMO.Location = new Point(135, 117);
            buttonSaveFile_PMO.Name = "buttonSaveFile_PMO";
            buttonSaveFile_PMO.Size = new Size(60, 49);
            buttonSaveFile_PMO.TabIndex = 3;
            buttonSaveFile_PMO.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile_PMO
            // 
            buttonOpenFile_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonOpenFile_PMO.Image = (Image)resources.GetObject("buttonOpenFile_PMO.Image");
            buttonOpenFile_PMO.Location = new Point(54, 117);
            buttonOpenFile_PMO.Name = "buttonOpenFile_PMO";
            buttonOpenFile_PMO.Size = new Size(62, 49);
            buttonOpenFile_PMO.TabIndex = 4;
            buttonOpenFile_PMO.UseVisualStyleBackColor = false;
            // 
            // buttonSearch_PMO
            // 
            buttonSearch_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonSearch_PMO.Image = (Image)resources.GetObject("buttonSearch_PMO.Image");
            buttonSearch_PMO.Location = new Point(198, 20);
            buttonSearch_PMO.Name = "buttonSearch_PMO";
            buttonSearch_PMO.Size = new Size(38, 35);
            buttonSearch_PMO.TabIndex = 5;
            buttonSearch_PMO.UseVisualStyleBackColor = false;
            // 
            // buttonAdd_PMO
            // 
            buttonAdd_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonAdd_PMO.Image = (Image)resources.GetObject("buttonAdd_PMO.Image");
            buttonAdd_PMO.Location = new Point(177, 189);
            buttonAdd_PMO.Name = "buttonAdd_PMO";
            buttonAdd_PMO.Size = new Size(59, 44);
            buttonAdd_PMO.TabIndex = 6;
            buttonAdd_PMO.UseVisualStyleBackColor = false;
            // 
            // buttonStatic_PMO
            // 
            buttonStatic_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonStatic_PMO.Image = (Image)resources.GetObject("buttonStatic_PMO.Image");
            buttonStatic_PMO.Location = new Point(12, 189);
            buttonStatic_PMO.Name = "buttonStatic_PMO";
            buttonStatic_PMO.Size = new Size(62, 44);
            buttonStatic_PMO.TabIndex = 7;
            buttonStatic_PMO.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 418);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Отдел кадров";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Splitter splitter1;
        private DataGridView dataGridView1;
        private Button buttonStatic_PMO;
        private Button buttonAdd_PMO;
        private Button buttonSearch_PMO;
        private Button buttonOpenFile_PMO;
        private Button buttonSaveFile_PMO;
        private Button buttonDelete_PMO;
    }
}
