
namespace Leaf_Text_Editor_v2
{
    partial class TextEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDictionary = new System.Windows.Forms.RichTextBox();
            this.textBoxDictionary = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseVoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.dubTheTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelCount = new System.Windows.Forms.Panel();
            this.symbols = new System.Windows.Forms.Label();
            this.lines = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDictionary = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.chooseVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.panelCount.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelDictionary.SuspendLayout();
            this.SuspendLayout();
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // richTextBoxMain
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.richTextBoxMain, this.autocompleteMenu1);
            this.richTextBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxMain.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.Size = new System.Drawing.Size(984, 437);
            this.richTextBoxMain.TabIndex = 0;
            this.richTextBoxMain.Text = "";
            this.richTextBoxMain.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // richTextBoxDictionary
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.richTextBoxDictionary, null);
            this.richTextBoxDictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDictionary.Font = new System.Drawing.Font("e-Ukraine Head", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDictionary.Location = new System.Drawing.Point(15, 16);
            this.richTextBoxDictionary.Name = "richTextBoxDictionary";
            this.richTextBoxDictionary.Size = new System.Drawing.Size(469, 229);
            this.richTextBoxDictionary.TabIndex = 0;
            this.richTextBoxDictionary.Text = "";
            // 
            // textBoxDictionary
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.textBoxDictionary, null);
            this.textBoxDictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDictionary.Location = new System.Drawing.Point(15, 262);
            this.textBoxDictionary.Name = "textBoxDictionary";
            this.textBoxDictionary.Size = new System.Drawing.Size(292, 21);
            this.textBoxDictionary.TabIndex = 3;
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStripMain.Font = new System.Drawing.Font("e-Ukraine Head", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.vocabularyToolStripMenuItem,
            this.speakToolStripMenuItem1});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(984, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSettingsToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // fontSettingsToolStripMenuItem
            // 
            this.fontSettingsToolStripMenuItem.Name = "fontSettingsToolStripMenuItem";
            this.fontSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontSettingsToolStripMenuItem.Text = "Font Settings";
            this.fontSettingsToolStripMenuItem.Click += new System.EventHandler(this.fontSettingsToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Font = new System.Drawing.Font("e-Ukraine Head", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripComboBox1.MergeIndex = 0;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 22);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDictionaryToolStripMenuItem});
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.vocabularyToolStripMenuItem.Text = "Dictionary";
            // 
            // openDictionaryToolStripMenuItem
            // 
            this.openDictionaryToolStripMenuItem.Name = "openDictionaryToolStripMenuItem";
            this.openDictionaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDictionaryToolStripMenuItem.Text = "Open dictionary";
            this.openDictionaryToolStripMenuItem.Click += new System.EventHandler(this.openDictionaryToolStripMenuItem_Click);
            // 
            // speakToolStripMenuItem1
            // 
            this.speakToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseVoiceToolStripMenuItem1,
            this.dubTheTextToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem});
            this.speakToolStripMenuItem1.Name = "speakToolStripMenuItem1";
            this.speakToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.speakToolStripMenuItem1.Text = "Speak";
            // 
            // chooseVoiceToolStripMenuItem1
            // 
            this.chooseVoiceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.chooseVoiceToolStripMenuItem1.Name = "chooseVoiceToolStripMenuItem1";
            this.chooseVoiceToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.chooseVoiceToolStripMenuItem1.Text = "Choose voice";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Font = new System.Drawing.Font("e-Ukraine Head", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(180, 22);
            this.toolStripComboBox2.Text = "Choose Speaker";
            // 
            // dubTheTextToolStripMenuItem
            // 
            this.dubTheTextToolStripMenuItem.Name = "dubTheTextToolStripMenuItem";
            this.dubTheTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dubTheTextToolStripMenuItem.Text = "Dub the text";
            this.dubTheTextToolStripMenuItem.Click += new System.EventHandler(this.dubTheTextToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelCount
            // 
            this.panelCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCount.Controls.Add(this.symbols);
            this.panelCount.Controls.Add(this.lines);
            this.panelCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCount.Location = new System.Drawing.Point(0, 431);
            this.panelCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(984, 30);
            this.panelCount.TabIndex = 2;
            // 
            // symbols
            // 
            this.symbols.AutoSize = true;
            this.symbols.Font = new System.Drawing.Font("e-Ukraine Head", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbols.Location = new System.Drawing.Point(168, 9);
            this.symbols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(68, 13);
            this.symbols.TabIndex = 1;
            this.symbols.Text = "Symbols:  ";
            // 
            // lines
            // 
            this.lines.AutoSize = true;
            this.lines.Font = new System.Drawing.Font("e-Ukraine Head", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lines.Location = new System.Drawing.Point(16, 9);
            this.lines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(49, 13);
            this.lines.TabIndex = 0;
            this.lines.Text = "Lines:  ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.selectAllToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 92);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.selectAllToolStripMenuItem1.Text = "Select all";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // panelDictionary
            // 
            this.panelDictionary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDictionary.Controls.Add(this.textBoxDictionary);
            this.panelDictionary.Controls.Add(this.buttonClose);
            this.panelDictionary.Controls.Add(this.buttonAdd);
            this.panelDictionary.Controls.Add(this.richTextBoxDictionary);
            this.panelDictionary.Location = new System.Drawing.Point(242, 80);
            this.panelDictionary.Name = "panelDictionary";
            this.panelDictionary.Size = new System.Drawing.Size(500, 300);
            this.panelDictionary.TabIndex = 3;
            this.panelDictionary.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(409, 262);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 21);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(321, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 21);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseVoiceToolStripMenuItem
            // 
            this.chooseVoiceToolStripMenuItem.Name = "chooseVoiceToolStripMenuItem";
            this.chooseVoiceToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panelDictionary);
            this.Controls.Add(this.panelCount);
            this.Controls.Add(this.richTextBoxMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("e-Ukraine Head", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaf Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelCount.ResumeLayout(false);
            this.panelCount.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelDictionary.ResumeLayout(false);
            this.panelDictionary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSettingsToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.Panel panelCount;
        private System.Windows.Forms.Label lines;
        private System.Windows.Forms.Label symbols;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDictionaryToolStripMenuItem;
        private System.Windows.Forms.Panel panelDictionary;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RichTextBox richTextBoxDictionary;
        private System.Windows.Forms.TextBox textBoxDictionary;
        private System.Windows.Forms.ToolStripMenuItem chooseVoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chooseVoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem dubTheTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
    }
}

