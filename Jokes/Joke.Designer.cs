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
            this.lblSearchedText = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.jokeTextBox = new System.Windows.Forms.RichTextBox();
            this.fullFileBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearchedText
            // 
            this.lblSearchedText.AutoSize = true;
            this.lblSearchedText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSearchedText.Location = new System.Drawing.Point(27, 24);
            this.lblSearchedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchedText.Name = "lblSearchedText";
            this.lblSearchedText.Size = new System.Drawing.Size(73, 25);
            this.lblSearchedText.TabIndex = 0;
            this.lblSearchedText.Text = "Word 1";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(44, 73);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(52, 13);
            this.title.TabIndex = 1;
            this.title.Text = "The Joke";
            // 
            // jokeTextBox
            // 
            this.jokeTextBox.Location = new System.Drawing.Point(52, 109);
            this.jokeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jokeTextBox.Name = "jokeTextBox";
            this.jokeTextBox.ReadOnly = true;
            this.jokeTextBox.Size = new System.Drawing.Size(366, 132);
            this.jokeTextBox.TabIndex = 2;
            this.jokeTextBox.Text = "";
            // 
            // fullFileBtn
            // 
            this.fullFileBtn.Location = new System.Drawing.Point(325, 322);
            this.fullFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullFileBtn.Name = "fullFileBtn";
            this.fullFileBtn.Size = new System.Drawing.Size(84, 37);
            this.fullFileBtn.TabIndex = 3;
            this.fullFileBtn.Text = "Watch full file";
            this.fullFileBtn.UseVisualStyleBackColor = true;
            this.fullFileBtn.Click += new System.EventHandler(this.fullFileBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(325, 262);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(84, 31);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(52, 262);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(84, 31);
            this.prevBtn.TabIndex = 4;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // Joke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 375);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.fullFileBtn);
            this.Controls.Add(this.jokeTextBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lblSearchedText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Joke";
            this.Text = "Joke";
            this.Load += new System.EventHandler(this.Joke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchedText;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RichTextBox jokeTextBox;
        private System.Windows.Forms.Button fullFileBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
    }
}