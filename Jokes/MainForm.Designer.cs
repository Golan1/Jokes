namespace Jokes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Load = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.TabPage();
            this.Groups = new System.Windows.Forms.TabPage();
            this.Relations = new System.Windows.Forms.TabPage();
            this.Files = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Load);
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Controls.Add(this.Groups);
            this.tabControl1.Controls.Add(this.Relations);
            this.tabControl1.Controls.Add(this.Files);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(4, 25);
            this.Load.Name = "Load";
            this.Load.Padding = new System.Windows.Forms.Padding(3);
            this.Load.Size = new System.Drawing.Size(600, 473);
            this.Load.TabIndex = 0;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(4, 25);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(600, 473);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Groups
            // 
            this.Groups.Location = new System.Drawing.Point(4, 25);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(600, 473);
            this.Groups.TabIndex = 2;
            this.Groups.Text = "Groups";
            this.Groups.UseVisualStyleBackColor = true;
            // 
            // Relations
            // 
            this.Relations.Location = new System.Drawing.Point(4, 25);
            this.Relations.Name = "Relations";
            this.Relations.Size = new System.Drawing.Size(600, 473);
            this.Relations.TabIndex = 3;
            this.Relations.Text = "Relations";
            this.Relations.UseVisualStyleBackColor = true;
            // 
            // Files
            // 
            this.Files.Location = new System.Drawing.Point(4, 25);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(600, 473);
            this.Files.TabIndex = 4;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Load;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.TabPage Relations;
        private System.Windows.Forms.TabPage Files;
    }
}