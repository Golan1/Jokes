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
            this.avgLetters = new System.Windows.Forms.Label();
            this.avgWords = new System.Windows.Forms.Label();
            this.avgJokes = new System.Windows.Forms.Label();
            this.maxLetters = new System.Windows.Forms.Label();
            this.maxWords = new System.Windows.Forms.Label();
            this.maxJokes = new System.Windows.Forms.Label();
            this.minLetters = new System.Windows.Forms.Label();
            this.minWords = new System.Windows.Forms.Label();
            this.minJokes = new System.Windows.Forms.Label();
            this.mostCommon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // avgLetters
            // 
            this.avgLetters.AutoSize = true;
            this.avgLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLetters.Location = new System.Drawing.Point(24, 31);
            this.avgLetters.Name = "avgLetters";
            this.avgLetters.Size = new System.Drawing.Size(211, 25);
            this.avgLetters.TabIndex = 0;
            this.avgLetters.Text = "Average letters in word:";
            // 
            // avgWords
            // 
            this.avgWords.AutoSize = true;
            this.avgWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWords.Location = new System.Drawing.Point(24, 65);
            this.avgWords.Name = "avgWords";
            this.avgWords.Size = new System.Drawing.Size(202, 25);
            this.avgWords.TabIndex = 0;
            this.avgWords.Text = "Average words in joke:";
            // 
            // avgJokes
            // 
            this.avgJokes.AutoSize = true;
            this.avgJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgJokes.Location = new System.Drawing.Point(24, 103);
            this.avgJokes.Name = "avgJokes";
            this.avgJokes.Size = new System.Drawing.Size(185, 25);
            this.avgJokes.TabIndex = 0;
            this.avgJokes.Text = "Average jokes in file:";
            // 
            // maxLetters
            // 
            this.maxLetters.AutoSize = true;
            this.maxLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLetters.Location = new System.Drawing.Point(24, 156);
            this.maxLetters.Name = "maxLetters";
            this.maxLetters.Size = new System.Drawing.Size(178, 25);
            this.maxLetters.TabIndex = 0;
            this.maxLetters.Text = "Max letters in word:";
            // 
            // maxWords
            // 
            this.maxWords.AutoSize = true;
            this.maxWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWords.Location = new System.Drawing.Point(24, 194);
            this.maxWords.Name = "maxWords";
            this.maxWords.Size = new System.Drawing.Size(169, 25);
            this.maxWords.TabIndex = 0;
            this.maxWords.Text = "Max words in joke:";
            // 
            // maxJokes
            // 
            this.maxJokes.AutoSize = true;
            this.maxJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxJokes.Location = new System.Drawing.Point(24, 230);
            this.maxJokes.Name = "maxJokes";
            this.maxJokes.Size = new System.Drawing.Size(152, 25);
            this.maxJokes.TabIndex = 0;
            this.maxJokes.Text = "Max jokes in file:";
            // 
            // minLetters
            // 
            this.minLetters.AutoSize = true;
            this.minLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLetters.Location = new System.Drawing.Point(24, 279);
            this.minLetters.Name = "minLetters";
            this.minLetters.Size = new System.Drawing.Size(175, 25);
            this.minLetters.TabIndex = 0;
            this.minLetters.Text = "Min letters in word:";
            // 
            // minWords
            // 
            this.minWords.AutoSize = true;
            this.minWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minWords.Location = new System.Drawing.Point(24, 317);
            this.minWords.Name = "minWords";
            this.minWords.Size = new System.Drawing.Size(171, 25);
            this.minWords.TabIndex = 0;
            this.minWords.Text = "Min  words in joke:";
            // 
            // minJokes
            // 
            this.minJokes.AutoSize = true;
            this.minJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minJokes.Location = new System.Drawing.Point(24, 353);
            this.minJokes.Name = "minJokes";
            this.minJokes.Size = new System.Drawing.Size(149, 25);
            this.minJokes.TabIndex = 0;
            this.minJokes.Text = "Min jokes in file:";
            // 
            // mostCommon
            // 
            this.mostCommon.AutoSize = true;
            this.mostCommon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostCommon.Location = new System.Drawing.Point(305, 31);
            this.mostCommon.Name = "mostCommon";
            this.mostCommon.Size = new System.Drawing.Size(185, 25);
            this.mostCommon.TabIndex = 0;
            this.mostCommon.Text = "Most common word:";
            // 
            // StatisticsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minJokes);
            this.Controls.Add(this.maxJokes);
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

        private System.Windows.Forms.Label avgLetters;
        private System.Windows.Forms.Label avgWords;
        private System.Windows.Forms.Label avgJokes;
        private System.Windows.Forms.Label maxLetters;
        private System.Windows.Forms.Label maxWords;
        private System.Windows.Forms.Label maxJokes;
        private System.Windows.Forms.Label minLetters;
        private System.Windows.Forms.Label minWords;
        private System.Windows.Forms.Label minJokes;
        private System.Windows.Forms.Label mostCommon;
    }
}
