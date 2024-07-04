namespace InsertionSearch_2
{
    partial class MainForm
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
            buttonParametrsForm = new Button();
            textBoxGetIndex = new TextBox();
            textBoxGetValue = new TextBox();
            textBoxGetValueToSearch = new TextBox();
            buttonFormInfo = new Button();
            pictureBoxVisualizer = new PictureBox();
            buttonInsert = new Button();
            buttonInseartForward = new Button();
            buttonInseartBack = new Button();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            buttonSearch = new Button();
            buttonSearchBack = new Button();
            buttonSearchForward = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisualizer).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonParametrsForm
            // 
            buttonParametrsForm.Location = new Point(33, 287);
            buttonParametrsForm.Name = "buttonParametrsForm";
            buttonParametrsForm.Size = new Size(112, 80);
            buttonParametrsForm.TabIndex = 0;
            buttonParametrsForm.Text = "Форма данных";
            buttonParametrsForm.UseVisualStyleBackColor = true;
            buttonParametrsForm.Click += buttonParametrsForm_Click;
            // 
            // textBoxGetIndex
            // 
            textBoxGetIndex.Location = new Point(186, 314);
            textBoxGetIndex.Name = "textBoxGetIndex";
            textBoxGetIndex.Size = new Size(125, 27);
            textBoxGetIndex.TabIndex = 1;
            textBoxGetIndex.TextChanged += textBoxGetIndex_TextChanged;
            // 
            // textBoxGetValue
            // 
            textBoxGetValue.Location = new Point(186, 347);
            textBoxGetValue.Name = "textBoxGetValue";
            textBoxGetValue.Size = new Size(125, 27);
            textBoxGetValue.TabIndex = 2;
            // 
            // textBoxGetValueToSearch
            // 
            textBoxGetValueToSearch.Location = new Point(457, 314);
            textBoxGetValueToSearch.Name = "textBoxGetValueToSearch";
            textBoxGetValueToSearch.Size = new Size(186, 27);
            textBoxGetValueToSearch.TabIndex = 3;
            // 
            // buttonFormInfo
            // 
            buttonFormInfo.Location = new Point(679, 287);
            buttonFormInfo.Name = "buttonFormInfo";
            buttonFormInfo.Size = new Size(109, 80);
            buttonFormInfo.TabIndex = 4;
            buttonFormInfo.Text = "Форма информации";
            buttonFormInfo.UseVisualStyleBackColor = true;
            buttonFormInfo.Click += buttonFormInfo_Click;
            // 
            // pictureBoxVisualizer
            // 
            pictureBoxVisualizer.Location = new Point(103, 59);
            pictureBoxVisualizer.Name = "pictureBoxVisualizer";
            pictureBoxVisualizer.Size = new Size(582, 144);
            pictureBoxVisualizer.TabIndex = 5;
            pictureBoxVisualizer.TabStop = false;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(186, 268);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(125, 40);
            buttonInsert.TabIndex = 6;
            buttonInsert.Text = "Вставка";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonInseartForward
            // 
            buttonInseartForward.Location = new Point(317, 314);
            buttonInseartForward.Name = "buttonInseartForward";
            buttonInseartForward.Size = new Size(90, 27);
            buttonInseartForward.TabIndex = 8;
            buttonInseartForward.Text = "Вперед";
            buttonInseartForward.UseVisualStyleBackColor = true;
            buttonInseartForward.Click += buttonInseartForward_Click;
            // 
            // buttonInseartBack
            // 
            buttonInseartBack.Location = new Point(317, 347);
            buttonInseartBack.Name = "buttonInseartBack";
            buttonInseartBack.Size = new Size(90, 27);
            buttonInseartBack.TabIndex = 9;
            buttonInseartBack.Text = "Назад";
            buttonInseartBack.UseVisualStyleBackColor = true;
            buttonInseartBack.Click += buttonInseartBack_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(227, 26);
            saveToolStripMenuItem.Text = "Сохранение";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(227, 26);
            loadToolStripMenuItem.Text = "Загрузка";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(457, 268);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(125, 40);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonSearchBack
            // 
            buttonSearchBack.Location = new Point(553, 347);
            buttonSearchBack.Name = "buttonSearchBack";
            buttonSearchBack.Size = new Size(90, 27);
            buttonSearchBack.TabIndex = 13;
            buttonSearchBack.Text = "Назад";
            buttonSearchBack.UseVisualStyleBackColor = true;
            buttonSearchBack.Click += buttonSearchBack_Click;
            // 
            // buttonSearchForward
            // 
            buttonSearchForward.Location = new Point(457, 344);
            buttonSearchForward.Name = "buttonSearchForward";
            buttonSearchForward.Size = new Size(90, 27);
            buttonSearchForward.TabIndex = 12;
            buttonSearchForward.Text = "Вперед";
            buttonSearchForward.UseVisualStyleBackColor = true;
            buttonSearchForward.Click += buttonSearchForward_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSearchBack);
            Controls.Add(buttonSearchForward);
            Controls.Add(buttonSearch);
            Controls.Add(buttonInseartBack);
            Controls.Add(buttonInseartForward);
            Controls.Add(buttonInsert);
            Controls.Add(pictureBoxVisualizer);
            Controls.Add(buttonFormInfo);
            Controls.Add(textBoxGetValueToSearch);
            Controls.Add(textBoxGetValue);
            Controls.Add(textBoxGetIndex);
            Controls.Add(buttonParametrsForm);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisualizer).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonParametrsForm;
        private TextBox textBoxGetIndex;
        private TextBox textBoxGetValue;
        private TextBox textBoxGetValueToSearch;
        private Button buttonFormInfo;
        private PictureBox pictureBoxVisualizer;
        private Button buttonInsert;
        private Button buttonInseartForward;
        private Button buttonInseartBack;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button buttonSearch;
        private Button buttonSearchBack;
        private Button buttonSearchForward;
    }
}