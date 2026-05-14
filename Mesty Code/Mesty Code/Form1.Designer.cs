namespace Mesty_Code
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panelfile = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            Terminal = new FontAwesome.Sharp.IconButton();
            Developmentstore = new FontAwesome.Sharp.IconButton();
            setings = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            treeView1 = new TreeView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(panelfile);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(Terminal);
            panel1.Controls.Add(Developmentstore);
            panel1.Controls.Add(setings);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 32);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelfile
            // 
            panelfile.Location = new Point(377, 0);
            panelfile.Name = "panelfile";
            panelfile.Size = new Size(652, 32);
            panelfile.TabIndex = 0;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.DimGray;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.DimGray;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Play;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(1035, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(45, 37);
            iconButton2.TabIndex = 3;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // Terminal
            // 
            Terminal.BackColor = Color.DimGray;
            Terminal.ForeColor = SystemColors.Control;
            Terminal.IconChar = FontAwesome.Sharp.IconChar.None;
            Terminal.IconColor = Color.Black;
            Terminal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Terminal.Location = new Point(233, 0);
            Terminal.Name = "Terminal";
            Terminal.Size = new Size(145, 32);
            Terminal.TabIndex = 2;
            Terminal.Text = "Terminal";
            Terminal.UseVisualStyleBackColor = false;
            // 
            // Developmentstore
            // 
            Developmentstore.BackColor = Color.DimGray;
            Developmentstore.ForeColor = SystemColors.Control;
            Developmentstore.IconChar = FontAwesome.Sharp.IconChar.None;
            Developmentstore.IconColor = Color.Black;
            Developmentstore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Developmentstore.Location = new Point(91, 0);
            Developmentstore.Name = "Developmentstore";
            Developmentstore.Size = new Size(145, 32);
            Developmentstore.TabIndex = 1;
            Developmentstore.Text = "Development store";
            Developmentstore.UseVisualStyleBackColor = false;
            Developmentstore.Click += Developmentstore_Click;
            // 
            // setings
            // 
            setings.BackColor = Color.DimGray;
            setings.ForeColor = SystemColors.Control;
            setings.IconChar = FontAwesome.Sharp.IconChar.None;
            setings.IconColor = Color.Black;
            setings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            setings.Location = new Point(0, 0);
            setings.Name = "setings";
            setings.Size = new Size(94, 32);
            setings.TabIndex = 0;
            setings.Text = "Setings";
            setings.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 697);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(treeView1);
            panel3.Location = new Point(3, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 630);
            panel3.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DimGray;
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(161, 49);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Folder";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // fastColoredTextBox1
            // 
            fastColoredTextBox1.AccessibleDescription = "Textbox control";
            fastColoredTextBox1.AccessibleName = "Fast Colored Text Box";
            fastColoredTextBox1.AccessibleRole = AccessibleRole.Text;
            fastColoredTextBox1.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            fastColoredTextBox1.AutoScrollMinSize = new Size(31, 18);
            fastColoredTextBox1.BackBrush = null;
            fastColoredTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            fastColoredTextBox1.CharCnWidth = 16;
            fastColoredTextBox1.CharHeight = 18;
            fastColoredTextBox1.CharWidth = 10;
            fastColoredTextBox1.DefaultMarkerSize = 8;
            fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fastColoredTextBox1.Dock = DockStyle.Fill;
            fastColoredTextBox1.FindForm = null;
            fastColoredTextBox1.FoldingHighlightColor = Color.Gainsboro;
            fastColoredTextBox1.FoldingHighlightEnabled = false;
            fastColoredTextBox1.Font = new Font("Courier New", 9.75F);
            fastColoredTextBox1.ForeColor = SystemColors.Control;
            fastColoredTextBox1.GoToForm = null;
            fastColoredTextBox1.Hotkeys = resources.GetString("fastColoredTextBox1.Hotkeys");
            fastColoredTextBox1.IndentBackColor = Color.FromArgb(64, 64, 64);
            fastColoredTextBox1.IsReplaceMode = false;
            fastColoredTextBox1.LineNumberColor = Color.White;
            fastColoredTextBox1.Location = new Point(161, 32);
            fastColoredTextBox1.Name = "fastColoredTextBox1";
            fastColoredTextBox1.Paddings = new Padding(0);
            fastColoredTextBox1.ReplaceForm = null;
            fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fastColoredTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
            fastColoredTextBox1.Size = new Size(1006, 697);
            fastColoredTextBox1.TabIndex = 2;
            fastColoredTextBox1.ToolTipDelay = 100;
            fastColoredTextBox1.UseCJK = FastColoredTextBoxNS.CJKMode.Hanzi;
            fastColoredTextBox1.Zoom = 100;
            fastColoredTextBox1.Load += fastColoredTextBox1_Load;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.DimGray;
            treeView1.Location = new Point(4, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(151, 624);
            treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1167, 729);
            Controls.Add(fastColoredTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Mesty Code";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fastColoredTextBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton setings;
        private FontAwesome.Sharp.IconButton Developmentstore;
        private FontAwesome.Sharp.IconButton Terminal;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel3;
        private Panel panelfile;
        private TreeView treeView1;
    }
}
