using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace Leaf_Text_Editor_v2
{
    public partial class Form1 : Form
    {
        static string open_path = "";
        Hashtable emotions; // set of emojes

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
            richTextBox1.AcceptsTab = true; //tabulation allowed
            CreateEmotions();
            toolStripComboBox1.SelectedIndex = 0;
        }

        //open file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename2 = openFileDialog1.FileName;
            string text = File.ReadAllText(filename2);
            richTextBox1.Text = text;
            open_path = filename2;
        }

        //save file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (open_path != "")
                {
                    File.WriteAllText(open_path, richTextBox1.Text);
                }
                else
                {
                    MessageBox.Show(
                        "Error!",
                        "File not saved",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "File not saved",
                    "Error!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        //sava file as
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
        }

        //copy text
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        //paste text
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                }
                richTextBox1.Paste();
            }
        }

        //cut text
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        //select all text
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        //set font
        private void fontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        //set background
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        //display of symbols and lines count
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] lines = richTextBox1.Text.Split('\n');
            label2.Text = "Symbols:  " + text.Length.ToString();
            label1.Text = "Lines:  " + lines.Length.ToString();
            AddEmotions(); //setting emojes in text area
        }

        //rightclick context menu strip (copy, paste, cut, select)
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        //creating a сonnection between a symbolic representation of emoji and emoji picture
        void CreateEmotions()
        {
            emotions = new Hashtable(6);
            emotions.Add(":-)", Leaf_Text_Editor_v2.Properties.Resources.happy);
            emotions.Add(":-(", Leaf_Text_Editor_v2.Properties.Resources.crying);
            emotions.Add(";-)", Leaf_Text_Editor_v2.Properties.Resources.wink);
            emotions.Add(">((", Leaf_Text_Editor_v2.Properties.Resources.angry);
            emotions.Add(":O", Leaf_Text_Editor_v2.Properties.Resources.shocked);
            emotions.Add("<3", Leaf_Text_Editor_v2.Properties.Resources.heart);
        }

        //replacing symbols of emoji by pictures of emoji
        void AddEmotions()
        {
            foreach (string emote in emotions.Keys)
            {
                while (richTextBox1.Text.Contains(emote))
                {
                    int ind = richTextBox1.Text.IndexOf(emote);
                    richTextBox1.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    richTextBox1.Paste();
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                }
            }
        }

        //set of themes
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Light") //Light Theme
            {
                richTextBox1.BackColor = ColorTranslator.FromHtml("#FFFFFF"); //white
                Color black = ColorTranslator.FromHtml("#000000");
                richTextBox1.ForeColor = black;
                menuStrip1.ForeColor = black;
                label1.ForeColor = black;
                label2.ForeColor = black;
                Color green = ColorTranslator.FromHtml("#ABEBC6");
                menuStrip1.BackColor = green;
                panel1.BackColor = green;
            }
            else if (toolStripComboBox1.Text == "Dark") //Dark Theme
            {
                richTextBox1.BackColor = ColorTranslator.FromHtml("#1E1E1E"); //black
                richTextBox1.ForeColor = ColorTranslator.FromHtml("#F4F6F7"); //white
                Color black = ColorTranslator.FromHtml("#2D2D30");
                menuStrip1.BackColor = black;
                panel1.BackColor = black;
                Color grey = ColorTranslator.FromHtml("#B3B6B7");
                menuStrip1.ForeColor = grey;
                label1.ForeColor = grey;
                label2.ForeColor = grey;

            }
            else if (toolStripComboBox1.Text == "UA") //UA Theme
            {
                richTextBox1.BackColor = ColorTranslator.FromHtml("#005BBB"); //blue
                richTextBox1.ForeColor = ColorTranslator.FromHtml("#FFFFFF"); //white
                Color yellow = ColorTranslator.FromHtml("#FFD500");
                menuStrip1.BackColor = yellow;
                panel1.BackColor = yellow;
                Color black = ColorTranslator.FromHtml("#000000");
                menuStrip1.ForeColor = black;
                label1.ForeColor = black;
                label2.ForeColor = black;
            }
        }

    }
}
