namespace Mesty_Code
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new TextBox();
            panel1 = new Panel();
            materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GrayText;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(217, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 27);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 452);
            panel1.TabIndex = 1;
            // 
            // materialScrollBar1
            // 
            materialScrollBar1.Depth = 0;
            materialScrollBar1.Location = new Point(921, 12);
            materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialScrollBar1.Name = "materialScrollBar1";
            materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            materialScrollBar1.ScrollbarSize = 12;
            materialScrollBar1.Size = new Size(12, 503);
            materialScrollBar1.TabIndex = 2;
            materialScrollBar1.Text = "materialScrollBar1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(945, 527);
            Controls.Add(materialScrollBar1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Development store";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
    }
}