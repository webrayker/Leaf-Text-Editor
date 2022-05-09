﻿using System;
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
            label2.Text = "Symbols: " + text.Length.ToString();
            label1.Text = "Lines: " + lines.Length.ToString();
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
            emotions.Add(":-)", Leaf_Text_Editor_v2.Properties.Resources.regular_smile);
            emotions.Add(":)", Leaf_Text_Editor_v2.Properties.Resources.regular_smile);
            emotions.Add(":-(", Leaf_Text_Editor_v2.Properties.Resources.sad_smile);
            emotions.Add(":(", Leaf_Text_Editor_v2.Properties.Resources.sad_smile);
            emotions.Add(":-P", Leaf_Text_Editor_v2.Properties.Resources.tongue_smile);
            emotions.Add(":P", Leaf_Text_Editor_v2.Properties.Resources.tongue_smile);
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

    }
}
