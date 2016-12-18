namespace Jokes
{
    partial class StatisticsTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.avgLetters = new System.Windows.Forms.RadioButton();
            this.avgWords = new System.Windows.Forms.RadioButton();
            this.avgJokes = new System.Windows.Forms.RadioButton();
            this.maxLetters = new System.Windows.Forms.RadioButton();
            this.maxWordsFile = new System.Windows.Forms.RadioButton();
            this.maxWords = new System.Windows.Forms.RadioButton();
            this.minLetters = new System.Windows.Forms.RadioButton();
            this.minWords = new System.Windows.Forms.RadioButton();
            this.mostCommon = new System.Windows.Forms.RadioButton();
            this.minJokes = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // avgLetters
            // 
            this.avgLetters.AutoSize = true;
            this.avgLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLetters.Location = new System.Drawing.Point(435, 93);
            this.avgLetters.Name = "avgLetters";
            this.avgLetters.Size = new System.Drawing.Size(228, 29);
            this.avgLetters.TabIndex = 0;
            this.avgLetters.Text = "Average letters in word";
            this.avgLetters.CheckedChanged += new System.EventHandler(this.avgLetters_CheckedChanged);
            // 
            // avgWords
            // 
            this.avgWords.AutoSize = true;
            this.avgWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWords.Location = new System.Drawing.Point(435, 142);
            this.avgWords.Name = "avgWords";
            this.avgWords.Size = new System.Drawing.Size(219, 29);
            this.avgWords.TabIndex = 0;
            this.avgWords.Text = "Average words in joke";
            this.avgWords.CheckedChanged += new System.EventHandler(this.avgWords_CheckedChanged);
            // 
            // avgJokes
            // 
            this.avgJokes.AutoSize = true;
            this.avgJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgJokes.Location = new System.Drawing.Point(435, 188);
            this.avgJokes.Name = "avgJokes";
            this.avgJokes.Size = new System.Drawing.Size(202, 29);
            this.avgJokes.TabIndex = 0;
            this.avgJokes.Text = "Average jokes in file";
            this.avgJokes.CheckedChanged += new System.EventHandler(this.avgJokes_CheckedChanged);
            // 
            // maxLetters
            // 
            this.maxLetters.AutoSize = true;
            this.maxLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLetters.Location = new System.Drawing.Point(24, 93);
            this.maxLetters.Name = "maxLetters";
            this.maxLetters.Size = new System.Drawing.Size(195, 29);
            this.maxLetters.TabIndex = 0;
            this.maxLetters.Text = "Max letters in word";
            this.maxLetters.CheckedChanged += new System.EventHandler(this.maxLetters_CheckedChanged);
            // 
            // maxWordsFile
            // 
            this.maxWordsFile.AutoSize = true;
            this.maxWordsFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWordsFile.Location = new System.Drawing.Point(24, 188);
            this.maxWordsFile.Name = "maxWordsFile";
            this.maxWordsFile.Size = new System.Drawing.Size(181, 29);
            this.maxWordsFile.TabIndex = 0;
            this.maxWordsFile.Text = "Max words in file";
            this.maxWordsFile.CheckedChanged += new System.EventHandler(this.maxWordsFile_CheckedChanged);
            // 
            // maxWords
            // 
            this.maxWords.AutoSize = true;
            this.maxWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWords.Location = new System.Drawing.Point(24, 140);
            this.maxWords.Name = "maxWords";
            this.maxWords.Size = new System.Drawing.Size(186, 29);
            this.maxWords.TabIndex = 0;
            this.maxWords.Text = "Max words in joke";
            this.maxWords.CheckedChanged += new System.EventHandler(this.maxWords_CheckedChanged);
            // 
            // minLetters
            // 
            this.minLetters.AutoSize = true;
            this.minLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLetters.Location = new System.Drawing.Point(229, 93);
            this.minLetters.Name = "minLetters";
            this.minLetters.Size = new System.Drawing.Size(192, 29);
            this.minLetters.TabIndex = 0;
            this.minLetters.Text = "Min letters in word";
            this.minLetters.CheckedChanged += new System.EventHandler(this.minLetters_CheckedChanged);
            // 
            // minWords
            // 
            this.minWords.AutoSize = true;
            this.minWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minWords.Location = new System.Drawing.Point(229, 142);
            this.minWords.Name = "minWords";
            this.minWords.Size = new System.Drawing.Size(188, 29);
            this.minWords.TabIndex = 0;
            this.minWords.Text = "Min  words in joke";
            this.minWords.CheckedChanged += new System.EventHandler(this.minWords_CheckedChanged);
            // 
            // mostCommon
            // 
            this.mostCommon.AutoSize = true;
            this.mostCommon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostCommon.Location = new System.Drawing.Point(24, 188);
            this.mostCommon.Name = "mostCommon";
            this.mostCommon.Size = new System.Drawing.Size(202, 29);
            this.mostCommon.TabIndex = 0;
            this.mostCommon.Text = "Most common word";
            this.mostCommon.CheckedChanged += new System.EventHandler(this.mostCommon_CheckedChanged);
            // 
            // minJokes
            // 
            this.minJokes.AutoSize = true;
            this.minJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minJokes.Location = new System.Drawing.Point(229, 188);
            this.minJokes.Name = "minJokes";
            this.minJokes.Size = new System.Drawing.Size(166, 29);
            this.minJokes.TabIndex = 0;
            this.minJokes.Text = "Min jokes in file";
            this.minJokes.CheckedChanged += new System.EventHandler(this.minJokes_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(229, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(367, 75);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(25, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numeric Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(225, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject";
            // 
            // StatisticsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minJokes);
            this.Controls.Add(this.minWords);
            this.Controls.Add(this.maxWords);
            this.Controls.Add(this.minLetters);
            this.Controls.Add(this.maxLetters);
            this.Controls.Add(this.avgJokes);
            this.Controls.Add(this.avgWords);
            this.Controls.Add(this.mostCommon);
            this.Controls.Add(this.avgLetters);
            this.Name = "StatisticsTab";
            this.Size = new System.Drawing.Size(687, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.RadioButton avgLetters;
        private System.Windows.Forms.RadioButton avgWords;
        private System.Windows.Forms.RadioButton avgJokes;
        private System.Windows.Forms.RadioButton maxLetters;
        private System.Windows.Forms.RadioButton maxWords;
        private System.Windows.Forms.RadioButton maxWordsFile;
        private System.Windows.Forms.RadioButton minLetters;
        private System.Windows.Forms.RadioButton minWords;
        private System.Windows.Forms.RadioButton minJokes;
        private System.Windows.Forms.RadioButton mostCommon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        // private System.Windows.Forms.RadioButton radioButton1;



    }
}
