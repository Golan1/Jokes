namespace Jokes
{
    partial class Joke
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
            this.wordLable = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.jokeTextBox = new System.Windows.Forms.RichTextBox();
            this.fullFileBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordLable
            // 
            this.wordLable.AutoSize = true;
            this.wordLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wordLable.Location = new System.Drawing.Point(36, 30);
            this.wordLable.Name = "wordLable";
            this.wordLable.Size = new System.Drawing.Size(92, 32);
            this.wordLable.TabIndex = 0;
            this.wordLable.Text = "Word 1";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(58, 90);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(67, 17);
            this.title.TabIndex = 1;
            this.title.Text = "The Joke";
            // 
            // jokeTextBox
            // 
            this.jokeTextBox.Location = new System.Drawing.Point(69, 134);
            this.jokeTextBox.Name = "jokeTextBox";
            this.jokeTextBox.Size = new System.Drawing.Size(487, 161);
            this.jokeTextBox.TabIndex = 2;
            this.jokeTextBox.Text = "";
            // 
            // fullFileBtn
            // 
            this.fullFileBtn.Location = new System.Drawing.Point(433, 396);
            this.fullFileBtn.Name = "fullFileBtn";
            this.fullFileBtn.Size = new System.Drawing.Size(112, 46);
            this.fullFileBtn.TabIndex = 3;
            this.fullFileBtn.Text = "Watch full file";
            this.fullFileBtn.UseVisualStyleBackColor = true;
            this.fullFileBtn.Click += new System.EventHandler(this.fullFileBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(433, 322);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(112, 38);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(69, 322);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(112, 38);
            this.prevBtn.TabIndex = 4;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            // 
            // Joke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 461);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.fullFileBtn);
            this.Controls.Add(this.jokeTextBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.wordLable);
            this.Name = "Joke";
            this.Text = "Joke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLable;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RichTextBox jokeTextBox;
        private System.Windows.Forms.Button fullFileBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
    }
}