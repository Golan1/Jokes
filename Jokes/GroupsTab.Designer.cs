﻿namespace Jokes
{
    partial class GroupsTab
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
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(33, 41);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(208, 186);
            this.groupsListBox.TabIndex = 0;
            // 
            // addWordBtn
            // 
            this.addWordBtn.Location = new System.Drawing.Point(324, 301);
            this.addWordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(92, 26);
            this.addWordBtn.TabIndex = 2;
            this.addWordBtn.Text = "Add";
            this.addWordBtn.UseVisualStyleBackColor = true;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(33, 301);
            this.addGroupBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(92, 26);
            this.addGroupBtn.TabIndex = 2;
            this.addGroupBtn.Text = "Add";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(29, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add a new group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(320, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add word to selected group";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(137, 309);
            this.groupTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(104, 20);
            this.groupTextBox.TabIndex = 5;
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(428, 308);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(104, 20);
            this.wordTextBox.TabIndex = 5;
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.Location = new System.Drawing.Point(324, 41);
            this.wordsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.wordsListBox.Size = new System.Drawing.Size(208, 186);
            this.wordsListBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(320, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(29, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Groups";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(33, 354);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Group";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GroupsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wordsListBox);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addGroupBtn);
            this.Controls.Add(this.addWordBtn);
            this.Controls.Add(this.groupsListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GroupsTab";
            this.Size = new System.Drawing.Size(565, 401);
            this.Load += new System.EventHandler(this.GroupsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.Button addWordBtn;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
    }
}
