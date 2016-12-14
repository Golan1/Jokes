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
            this.SuspendLayout();
            // 
            // avgLetters
            // 
            this.avgLetters.AutoSize = true;
            this.avgLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLetters.Location = new System.Drawing.Point(24, 31);
            this.avgLetters.Name = "avgLetters";
            this.avgLetters.Size = new System.Drawing.Size(232, 29);
            this.avgLetters.TabIndex = 0;
            this.avgLetters.Text = "Average letters in word:";
            this.avgLetters.CheckedChanged += new System.EventHandler(this.avgLetters_CheckedChanged);
            // 
            // avgWords
            // 
            this.avgWords.AutoSize = true;
            this.avgWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWords.Location = new System.Drawing.Point(24, 65);
            this.avgWords.Name = "avgWords";
            this.avgWords.Size = new System.Drawing.Size(223, 29);
            this.avgWords.TabIndex = 0;
            this.avgWords.Text = "Average words in joke:";
            this.avgWords.CheckedChanged += new System.EventHandler(this.avgWords_CheckedChanged);
            // 
            // avgJokes
            // 
            this.avgJokes.AutoSize = true;
            this.avgJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgJokes.Location = new System.Drawing.Point(24, 103);
            this.avgJokes.Name = "avgJokes";
            this.avgJokes.Size = new System.Drawing.Size(214, 29);
            this.avgJokes.TabIndex = 0;
            this.avgJokes.Text = "Average words in file:";
            this.avgJokes.CheckedChanged += new System.EventHandler(this.avgJokes_CheckedChanged);
            // 
            // maxLetters
            // 
            this.maxLetters.AutoSize = true;
            this.maxLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLetters.Location = new System.Drawing.Point(24, 156);
            this.maxLetters.Name = "maxLetters";
            this.maxLetters.Size = new System.Drawing.Size(199, 29);
            this.maxLetters.TabIndex = 0;
            this.maxLetters.Text = "Max letters in word:";
            this.maxLetters.CheckedChanged += new System.EventHandler(this.maxLetters_CheckedChanged);
            // 
            // maxWordsFile
            // 
            this.maxWordsFile.AutoSize = true;
            this.maxWordsFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWordsFile.Location = new System.Drawing.Point(24, 230);
            this.maxWordsFile.Name = "maxWordsFile";
            this.maxWordsFile.Size = new System.Drawing.Size(181, 29);
            this.maxWordsFile.TabIndex = 0;
            this.maxWordsFile.Text = "Max words in file:";
            this.maxWordsFile.CheckedChanged += new System.EventHandler(this.maxWordsFile_CheckedChanged);
            // 
            // maxWords
            // 
            this.maxWords.AutoSize = true;
            this.maxWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWords.Location = new System.Drawing.Point(24, 194);
            this.maxWords.Name = "maxWords";
            this.maxWords.Size = new System.Drawing.Size(190, 29);
            this.maxWords.TabIndex = 0;
            this.maxWords.Text = "Max words in joke:";
            this.maxWords.CheckedChanged += new System.EventHandler(this.maxWords_CheckedChanged);
            // 
            // minLetters
            // 
            this.minLetters.AutoSize = true;
            this.minLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLetters.Location = new System.Drawing.Point(24, 279);
            this.minLetters.Name = "minLetters";
            this.minLetters.Size = new System.Drawing.Size(196, 29);
            this.minLetters.TabIndex = 0;
            this.minLetters.Text = "Min letters in word:";
            this.minLetters.CheckedChanged += new System.EventHandler(this.minLetters_CheckedChanged);
            // 
            // minWords
            // 
            this.minWords.AutoSize = true;
            this.minWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minWords.Location = new System.Drawing.Point(24, 317);
            this.minWords.Name = "minWords";
            this.minWords.Size = new System.Drawing.Size(192, 29);
            this.minWords.TabIndex = 0;
            this.minWords.Text = "Min  words in joke:";
            this.minWords.CheckedChanged += new System.EventHandler(this.minWords_CheckedChanged);
            // 
            // mostCommon
            // 
            this.mostCommon.AutoSize = true;
            this.mostCommon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostCommon.Location = new System.Drawing.Point(305, 31);
            this.mostCommon.Name = "mostCommon";
            this.mostCommon.Size = new System.Drawing.Size(206, 29);
            this.mostCommon.TabIndex = 0;
            this.mostCommon.Text = "Most common word:";
            this.mostCommon.CheckedChanged += new System.EventHandler(this.mostCommon_CheckedChanged);
            // 
            // minJokes
            // 
            this.minJokes.AutoSize = true;
            this.minJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minJokes.Location = new System.Drawing.Point(24, 353);
            this.minJokes.Name = "minJokes";
            this.minJokes.Size = new System.Drawing.Size(181, 29);
            this.minJokes.TabIndex = 0;
            this.minJokes.Text = "Min Words in file:";
            this.minJokes.CheckedChanged += new System.EventHandler(this.minJokes_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 22);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(490, 267);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 116);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // StatisticsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minJokes);
            this.Controls.Add(this.maxWordsFile);
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
        // private System.Windows.Forms.RadioButton radioButton1;
    }
}
