namespace TextReader
{
    partial class Text
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aNSIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uNICODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unicodeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInUnicodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInANSIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unicodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInANSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInUnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cleaneToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.formatToolStripMenuItem1,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem1
            // 
            this.formatToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNSIToolStripMenuItem1,
            this.uNICODEToolStripMenuItem});
            this.formatToolStripMenuItem1.Name = "formatToolStripMenuItem1";
            this.formatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.formatToolStripMenuItem1.Text = "Format";
            // 
            // aNSIToolStripMenuItem1
            // 
            this.aNSIToolStripMenuItem1.Name = "aNSIToolStripMenuItem1";
            this.aNSIToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.aNSIToolStripMenuItem1.Text = "ANSI";
            this.aNSIToolStripMenuItem1.Click += new System.EventHandler(this.aNSIToolStripMenuItem1_Click);
            // 
            // uNICODEToolStripMenuItem
            // 
            this.uNICODEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unicodeToolStripMenuItem2,
            this.uTF8ToolStripMenuItem1});
            this.uNICODEToolStripMenuItem.Name = "uNICODEToolStripMenuItem";
            this.uNICODEToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.uNICODEToolStripMenuItem.Text = "UNICODE";
            // 
            // unicodeToolStripMenuItem2
            // 
            this.unicodeToolStripMenuItem2.Name = "unicodeToolStripMenuItem2";
            this.unicodeToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.unicodeToolStripMenuItem2.Text = "Unicode";
            this.unicodeToolStripMenuItem2.Click += new System.EventHandler(this.unicodeToolStripMenuItem2_Click);
            // 
            // uTF8ToolStripMenuItem1
            // 
            this.uTF8ToolStripMenuItem1.Name = "uTF8ToolStripMenuItem1";
            this.uTF8ToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.uTF8ToolStripMenuItem1.Text = "UTF8";
            this.uTF8ToolStripMenuItem1.Click += new System.EventHandler(this.uTF8ToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInUnicodeToolStripMenuItem1,
            this.saveInANSIToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveInUnicodeToolStripMenuItem1
            // 
            this.saveInUnicodeToolStripMenuItem1.Name = "saveInUnicodeToolStripMenuItem1";
            this.saveInUnicodeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveInUnicodeToolStripMenuItem1.Text = "Save in Unicode";
            this.saveInUnicodeToolStripMenuItem1.Click += new System.EventHandler(this.saveInUnicodeToolStripMenuItem1_Click);
            // 
            // saveInANSIToolStripMenuItem1
            // 
            this.saveInANSIToolStripMenuItem1.Name = "saveInANSIToolStripMenuItem1";
            this.saveInANSIToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveInANSIToolStripMenuItem1.Text = "Save in ANSI";
            this.saveInANSIToolStripMenuItem1.Click += new System.EventHandler(this.saveInANSIToolStripMenuItem1_Click);
            // 
            // cleaneToolStripMenuItem
            // 
            this.cleaneToolStripMenuItem.Name = "cleaneToolStripMenuItem";
            this.cleaneToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cleaneToolStripMenuItem.Text = "Cleane";
            this.cleaneToolStripMenuItem.Click += new System.EventHandler(this.cleaneToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // unicodeToolStripMenuItem1
            // 
            this.unicodeToolStripMenuItem1.Name = "unicodeToolStripMenuItem1";
            this.unicodeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // uTF8ToolStripMenuItem
            // 
            this.uTF8ToolStripMenuItem.Name = "uTF8ToolStripMenuItem";
            this.uTF8ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveInUnicodeToolStripMenuItem
            // 
            this.saveInUnicodeToolStripMenuItem.Name = "saveInUnicodeToolStripMenuItem";
            this.saveInUnicodeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Text";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aNSIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unicodeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNICODEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unicodeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uTF8ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveInANSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInUnicodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInUnicodeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveInANSIToolStripMenuItem1;
    }
}

