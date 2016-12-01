namespace Jokes
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
            this.wordsListView = new System.Windows.Forms.ListView();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 16;
            this.groupsListBox.Location = new System.Drawing.Point(494, 79);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(119, 228);
            this.groupsListBox.TabIndex = 0;
            // 
            // wordsListView
            // 
            this.wordsListView.Location = new System.Drawing.Point(347, 79);
            this.wordsListView.Name = "wordsListView";
            this.wordsListView.Size = new System.Drawing.Size(113, 228);
            this.wordsListView.TabIndex = 1;
            this.wordsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addWordBtn
            // 
            this.addWordBtn.Location = new System.Drawing.Point(43, 275);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(122, 32);
            this.addWordBtn.TabIndex = 2;
            this.addWordBtn.Text = "Add";
            this.addWordBtn.UseVisualStyleBackColor = true;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(43, 150);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(122, 32);
            this.addGroupBtn.TabIndex = 2;
            this.addGroupBtn.Text = "Add";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(38, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add a new group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(38, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add word to selected group";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(181, 160);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(138, 22);
            this.groupTextBox.TabIndex = 5;
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(181, 285);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(138, 22);
            this.wordTextBox.TabIndex = 5;
            // 
            // GroupsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addGroupBtn);
            this.Controls.Add(this.addWordBtn);
            this.Controls.Add(this.wordsListView);
            this.Controls.Add(this.groupsListBox);
            this.Name = "GroupsTab";
            this.Size = new System.Drawing.Size(640, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.ListView wordsListView;
        private System.Windows.Forms.Button addWordBtn;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox wordTextBox;
    }
}
