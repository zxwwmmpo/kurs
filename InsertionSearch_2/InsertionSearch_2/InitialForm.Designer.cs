namespace InsertionSearch_2
{
    partial class InitialForm
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
            textBoxAddArray = new TextBox();
            buttonAddArray = new Button();
            numericUpDownAddSize = new NumericUpDown();
            buttonAddSize = new Button();
            richTextBoxOutPut = new RichTextBox();
            buttonBack = new Button();
            buttonAddRandomArray = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddSize).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddArray
            // 
            textBoxAddArray.Location = new Point(33, 123);
            textBoxAddArray.Name = "textBoxAddArray";
            textBoxAddArray.Size = new Size(142, 27);
            textBoxAddArray.TabIndex = 0;
            // 
            // buttonAddArray
            // 
            buttonAddArray.Location = new Point(33, 156);
            buttonAddArray.Name = "buttonAddArray";
            buttonAddArray.Size = new Size(142, 29);
            buttonAddArray.TabIndex = 1;
            buttonAddArray.Text = "добавить массив";
            buttonAddArray.UseVisualStyleBackColor = true;
            buttonAddArray.Click += buttonAddArray_Click;
            // 
            // numericUpDownAddSize
            // 
            numericUpDownAddSize.Location = new Point(202, 123);
            numericUpDownAddSize.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownAddSize.Name = "numericUpDownAddSize";
            numericUpDownAddSize.Size = new Size(122, 27);
            numericUpDownAddSize.TabIndex = 2;
            // 
            // buttonAddSize
            // 
            buttonAddSize.Location = new Point(202, 157);
            buttonAddSize.Name = "buttonAddSize";
            buttonAddSize.Size = new Size(122, 29);
            buttonAddSize.TabIndex = 3;
            buttonAddSize.Text = "задать размер";
            buttonAddSize.UseVisualStyleBackColor = true;
            buttonAddSize.Click += buttonAddSize_Click;
            // 
            // richTextBoxOutPut
            // 
            richTextBoxOutPut.Location = new Point(33, 267);
            richTextBoxOutPut.Name = "richTextBoxOutPut";
            richTextBoxOutPut.Size = new Size(208, 69);
            richTextBoxOutPut.TabIndex = 7;
            richTextBoxOutPut.Text = "";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(627, 267);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(117, 82);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Передать на форму";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAddRandomArray
            // 
            buttonAddRandomArray.Location = new Point(271, 267);
            buttonAddRandomArray.Name = "buttonAddRandomArray";
            buttonAddRandomArray.Size = new Size(94, 69);
            buttonAddRandomArray.TabIndex = 9;
            buttonAddRandomArray.Text = "добавить случайные значения";
            buttonAddRandomArray.UseVisualStyleBackColor = true;
            buttonAddRandomArray.Click += buttonAddRandomArray_Click;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddRandomArray);
            Controls.Add(buttonBack);
            Controls.Add(richTextBoxOutPut);
            Controls.Add(buttonAddSize);
            Controls.Add(numericUpDownAddSize);
            Controls.Add(buttonAddArray);
            Controls.Add(textBoxAddArray);
            Name = "InitialForm";
            Text = "InitialForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAddSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAddArray;
        private Button buttonAddArray;
        private NumericUpDown numericUpDownAddSize;
        private Button buttonAddSize;
        private RichTextBox richTextBoxOutPut;
        private Button buttonBack;
        private Button buttonAddRandomArray;
    }
}