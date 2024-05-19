namespace InsertionSearchArray
{
    partial class Initial
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
            textBoxInputNumber = new TextBox();
            buttonAddNumber = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBoxAddIndex = new TextBox();
            textBoxAddValue = new TextBox();
            buttonInsert = new Button();
            richTextBoxOutPut = new RichTextBox();
            buttonAddData = new Button();
            SuspendLayout();
            // 
            // textBoxInputNumber
            // 
            textBoxInputNumber.Location = new Point(26, 29);
            textBoxInputNumber.Name = "textBoxInputNumber";
            textBoxInputNumber.Size = new Size(135, 27);
            textBoxInputNumber.TabIndex = 0;
            textBoxInputNumber.TextChanged += textBoxInputNumber_TextChanged;
            // 
            // buttonAddNumber
            // 
            buttonAddNumber.Location = new Point(26, 62);
            buttonAddNumber.Name = "buttonAddNumber";
            buttonAddNumber.Size = new Size(135, 54);
            buttonAddNumber.TabIndex = 1;
            buttonAddNumber.Text = "Добавить рандом";
            buttonAddNumber.UseVisualStyleBackColor = true;
            buttonAddNumber.Click += buttonAddNumber_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(35, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(35, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(35, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(320, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(35, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(361, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(35, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(402, 153);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(35, 27);
            textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(443, 153);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(35, 27);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(484, 153);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(35, 27);
            textBox8.TabIndex = 6;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(566, 153);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(35, 27);
            textBox10.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(525, 153);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(35, 27);
            textBox9.TabIndex = 10;
            // 
            // textBoxAddIndex
            // 
            textBoxAddIndex.Location = new Point(26, 214);
            textBoxAddIndex.Name = "textBoxAddIndex";
            textBoxAddIndex.Size = new Size(135, 27);
            textBoxAddIndex.TabIndex = 12;
            // 
            // textBoxAddValue
            // 
            textBoxAddValue.Location = new Point(26, 247);
            textBoxAddValue.Name = "textBoxAddValue";
            textBoxAddValue.Size = new Size(135, 27);
            textBoxAddValue.TabIndex = 13;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(26, 294);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(135, 29);
            buttonInsert.TabIndex = 14;
            buttonInsert.Text = "Добавить число";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOutPut
            // 
            richTextBoxOutPut.Location = new Point(26, 329);
            richTextBoxOutPut.Name = "richTextBoxOutPut";
            richTextBoxOutPut.Size = new Size(135, 64);
            richTextBoxOutPut.TabIndex = 15;
            richTextBoxOutPut.Text = "";
            // 
            // buttonAddData
            // 
            buttonAddData.Location = new Point(630, 320);
            buttonAddData.Name = "buttonAddData";
            buttonAddData.Size = new Size(149, 73);
            buttonAddData.TabIndex = 16;
            buttonAddData.Text = "Передать на форму ";
            buttonAddData.UseVisualStyleBackColor = true;
            buttonAddData.Click += buttonAddData_Click;
            // 
            // Initial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddData);
            Controls.Add(richTextBoxOutPut);
            Controls.Add(buttonInsert);
            Controls.Add(textBoxAddValue);
            Controls.Add(textBoxAddIndex);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonAddNumber);
            Controls.Add(textBoxInputNumber);
            Name = "Initial";
            Text = "Initial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputNumber;
        private Button buttonAddNumber;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBoxAddIndex;
        private TextBox textBoxAddValue;
        private Button buttonInsert;
        private RichTextBox richTextBoxOutPut;
        private Button buttonAddData;
    }
}