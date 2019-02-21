using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextReader
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Danylo Lyga");
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cleaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void aNSIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.ReadFormatAnsi();
            richTextBox1.Text = read.text;    
            
        }
        class Read
        {
            public string text { get; set; }
            public  void ReadFormatUnicode()
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(openFile.FileName, Encoding.Unicode))
                        {
                            text = sr.ReadToEnd();
                            sr.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            public void ReadFormatAnsi()
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(openFile.FileName, Encoding.Default))
                        {
                            text = sr.ReadToEnd();
                            sr.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void uTF8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.ReadFormatUnicode();
            Encoding unicode = Encoding.Unicode;
            byte[] unicodeBytes = unicode.GetBytes(read.text);
            String str2 = Encoding.UTF8.GetString(unicodeBytes);
            richTextBox1.Text = str2;
        }

        private void unicodeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.ReadFormatUnicode();
            Encoding unicode = Encoding.Unicode;
            byte[] unicodeBytes = unicode.GetBytes(read.text);
            String str1 = Encoding.Unicode.GetString(unicodeBytes);
            richTextBox1.Text = str1;
        }
        private void saveInUnicodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.txt";
            saveFile.Filter = "Text files|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, true, Encoding.Unicode))
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
        }
        private void saveInANSIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.txt";
            saveFile.Filter = "Text files|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
        }
    }
}
