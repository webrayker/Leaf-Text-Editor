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
using System.Speech;
using System.Speech.Synthesis;

namespace Leaf_Text_Editor_v2
{
    public partial class Form1 : Form
    {
        private const string pathToThemes = "files/themes"; //path to program themes
        static string open_path = ""; //starting path
        static string[] reservlist = { }; //dictionary reserv list
        Hashtable emotions; //set of emojes
        SpeechSynthesizer speech; //speech synthesis engine
        
        public Form1()
        {
            InitializeComponent();
            CreateEmotions(); //create a сonnection between a symbolic representation of emoji and emoji picture
            speech = new SpeechSynthesizer(); //speech synthesis engine
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|All Files (*.*)|*.*";
            richTextBox1.AcceptsTab = true; //tabulation allowed  
            reservlist = File.ReadAllText("files/dictionaries/rus-eng-reserved-list.dicr").Split('\n'); //reading dictionary of reserved worlds
            richTextBox2.Text = File.ReadAllText(@"files/dictionaries/rus-eng-reserved-list.dicr"); //diplay dictionary  
            autocompleteMenu1.Items = reservlist; //add worlds from dictionary to autocomplete menu 
            getThemesNames(); //getting names of exhisting themes
            toolStripComboBox1.SelectedIndex = 2; //selecting theme index in combo box
        }

        //getting names of exhisting themes in themes folder
        private void getThemesNames()
        {
            if (Directory.Exists(pathToThemes))
            {
               string[] files = Directory.GetFiles(pathToThemes);
               if (files.Length > 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        IniParser parser = new IniParser(files[i]);
                        string themeName = parser.GetSetting("Theme", "name");
                        toolStripComboBox1.Items.Add(themeName);
                    }
                }
            }
        }

        //open file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string text = File.ReadAllText(filename);
            richTextBox1.Text = text;
            open_path = filename;
            MessageBox.Show("File Opened!", "Success!");
        }

        //save file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (open_path != "")
            {
                File.WriteAllText(open_path, richTextBox1.Text);
            }
            else if (open_path == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, richTextBox1.Text);
                open_path = filename;
            }
            MessageBox.Show("File Saved!", "Success!");
        }

        //sava file as
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("File Saved!", "Success!");
            open_path = filename;
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

        //changing colors according to the selected theme
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "files/themes/" + toolStripComboBox1.Text + ".ini";
            IniParser parser = new IniParser(path); //opens .ini file at the given path

            richTextBox1.BackColor = ColorTranslator.FromHtml(parser.GetSetting("Colors", "part1BackColor")); //parser.GetSetting() returns the value for the given section, key pair
            richTextBox1.ForeColor = ColorTranslator.FromHtml(parser.GetSetting("Colors", "part1ForeColor")); 
            Color color1 = ColorTranslator.FromHtml(parser.GetSetting("Colors", "part2BackColor"));
            menuStrip1.BackColor = color1;
            panel1.BackColor = color1;
            Color color2 = ColorTranslator.FromHtml(parser.GetSetting("Colors", "part2ForeColor"));
            menuStrip1.ForeColor = color2;
            label1.ForeColor = color2;
            label2.ForeColor = color2;
            panel2.BackColor = color1;
        }

        //open dictionary editor
        private void openDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        //close dictionary editor
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            File.WriteAllText(@"files/dictionaries/rus-eng-reserved-list.dicr", richTextBox2.Text);
        }

        //add new word to dictionary
        private void button1_Click(object sender, EventArgs e)
        {
            string newsnippet = textBox1.Text;
            textBox1.Text = "";
            richTextBox2.Text = richTextBox2.Text + "\n" + newsnippet;
            File.WriteAllText(@"files/dictionaries/rus-eng-reserved-list.dicr", richTextBox2.Text);
            reservlist = File.ReadAllText("files/dictionaries/rus-eng-reserved-list.dicr").Split('\n');
            autocompleteMenu1.Items = reservlist;
        }

        //load installed voices to choose
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var voice in speech.GetInstalledVoices())
            {
                toolStripComboBox2.Items.Add(voice.VoiceInfo.Name);
            }
            toolStripComboBox2.SelectedIndex = 0;

        }

        //dub the text
        private void dubTheTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speech.SelectVoice(toolStripComboBox2.Text);
            speech.SpeakAsync(richTextBox1.Text);
        }

        //pause dubbing
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
            {
                speech.Pause();
            }
        }

        //resume dubbing
        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Paused)
            {
                speech.Resume();
            }

        }

    }

   
}
