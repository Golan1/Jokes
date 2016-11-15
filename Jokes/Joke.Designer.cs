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
            this.words = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.jokeText = new System.Windows.Forms.RichTextBox();
            this.fullFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // words
            // 
            this.words.AutoSize = true;
            this.words.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.words.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.words.Location = new System.Drawing.Point(36, 30);
            this.words.Name = "words";
            this.words.Size = new System.Drawing.Size(92, 32);
            this.words.TabIndex = 0;
            this.words.Text = "Word 1";
           
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
            // jokeText
            // 
            this.jokeText.Location = new System.Drawing.Point(69, 134);
            this.jokeText.Name = "jokeText";
            this.jokeText.Size = new System.Drawing.Size(487, 161);
            this.jokeText.TabIndex = 2;
            this.jokeText.Text = "";
            // 
            // fullFileBtn
            // 
            this.fullFileBtn.Location = new System.Drawing.Point(443, 353);
            this.fullFileBtn.Name = "fullFileBtn";
            this.fullFileBtn.Size = new System.Drawing.Size(112, 46);
            this.fullFileBtn.TabIndex = 3;
            this.fullFileBtn.Text = "Watch full file";
            this.fullFileBtn.UseVisualStyleBackColor = true;
            // 
            // Joke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 461);
            this.Controls.Add(this.fullFileBtn);
            this.Controls.Add(this.jokeText);
            this.Controls.Add(this.title);
            this.Controls.Add(this.words);
            this.Name = "Joke";
            this.Text = "Joke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label words;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RichTextBox jokeText;
        private System.Windows.Forms.Button fullFileBtn;
    }
}