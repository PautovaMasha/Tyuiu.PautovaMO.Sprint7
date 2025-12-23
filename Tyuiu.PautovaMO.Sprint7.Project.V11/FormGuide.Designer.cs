namespace Tyuiu.PautovaMO.Sprint7.Project.V11
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            textBox1 = new TextBox();
            buttonOk_PMO = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(358, 381);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonOk_PMO
            // 
            buttonOk_PMO.BackColor = SystemColors.GradientInactiveCaption;
            buttonOk_PMO.Location = new Point(294, 399);
            buttonOk_PMO.Name = "buttonOk_PMO";
            buttonOk_PMO.Size = new Size(75, 23);
            buttonOk_PMO.TabIndex = 1;
            buttonOk_PMO.Text = "Ok";
            buttonOk_PMO.UseVisualStyleBackColor = false;
            buttonOk_PMO.Click += buttonOk_PMO_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 429);
            Controls.Add(buttonOk_PMO);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOk_PMO;
    }
}