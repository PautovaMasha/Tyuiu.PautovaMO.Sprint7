namespace Tyuiu.PautovaMO.Sprint7.Project.V11
{
    partial class FormAbout_PMO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_PMO));
            buttonOk_PMO = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOk_PMO
            // 
            buttonOk_PMO.BackColor = Color.FromArgb(192, 255, 255);
            buttonOk_PMO.Location = new Point(333, 159);
            buttonOk_PMO.Name = "buttonOk_PMO";
            buttonOk_PMO.Size = new Size(56, 27);
            buttonOk_PMO.TabIndex = 0;
            buttonOk_PMO.Text = "Ok";
            buttonOk_PMO.UseVisualStyleBackColor = false;
            buttonOk_PMO.Click += buttonOk_PMO_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 186);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(243, 159);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout_PMO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 186);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOk_PMO);
            MaximizeBox = false;
            MaximumSize = new Size(417, 225);
            MinimizeBox = false;
            MinimumSize = new Size(417, 225);
            Name = "FormAbout_PMO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk_PMO;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}