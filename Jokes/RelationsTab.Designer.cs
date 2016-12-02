namespace Jokes
{
    partial class RelationsTab
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
            this.relationsListBox = new System.Windows.Forms.ListBox();
            this.relationTextBox = new System.Windows.Forms.TextBox();
            this.addRelationBtn = new System.Windows.Forms.Button();
            this.word1TextBox = new System.Windows.Forms.TextBox();
            this.word2TextBox = new System.Windows.Forms.TextBox();
            this.AddTupleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tupples = new System.Windows.Forms.Label();
            this.tuplesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // relationsListBox
            // 
            this.relationsListBox.FormattingEnabled = true;
            this.relationsListBox.ItemHeight = 16;
            this.relationsListBox.Location = new System.Drawing.Point(450, 97);
            this.relationsListBox.Name = "relationsListBox";
            this.relationsListBox.Size = new System.Drawing.Size(141, 212);
            this.relationsListBox.TabIndex = 0;
            // 
            // relationTextBox
            // 
            this.relationTextBox.Location = new System.Drawing.Point(450, 316);
            this.relationTextBox.Name = "relationTextBox";
            this.relationTextBox.Size = new System.Drawing.Size(141, 22);
            this.relationTextBox.TabIndex = 2;
            // 
            // addRelationBtn
            // 
            this.addRelationBtn.Location = new System.Drawing.Point(450, 354);
            this.addRelationBtn.Name = "addRelationBtn";
            this.addRelationBtn.Size = new System.Drawing.Size(141, 27);
            this.addRelationBtn.TabIndex = 3;
            this.addRelationBtn.Text = "Add";
            this.addRelationBtn.UseVisualStyleBackColor = true;
            this.addRelationBtn.Click += new System.EventHandler(this.addRelationBtn_Click);
            // 
            // word1TextBox
            // 
            this.word1TextBox.Location = new System.Drawing.Point(238, 315);
            this.word1TextBox.Name = "word1TextBox";
            this.word1TextBox.Size = new System.Drawing.Size(141, 22);
            this.word1TextBox.TabIndex = 2;
            // 
            // word2TextBox
            // 
            this.word2TextBox.Location = new System.Drawing.Point(91, 315);
            this.word2TextBox.Name = "word2TextBox";
            this.word2TextBox.Size = new System.Drawing.Size(141, 22);
            this.word2TextBox.TabIndex = 2;
            // 
            // AddTupleBtn
            // 
            this.AddTupleBtn.Location = new System.Drawing.Point(156, 354);
            this.AddTupleBtn.Name = "AddTupleBtn";
            this.AddTupleBtn.Size = new System.Drawing.Size(141, 27);
            this.AddTupleBtn.TabIndex = 3;
            this.AddTupleBtn.Text = "Add";
            this.AddTupleBtn.UseVisualStyleBackColor = true;
            this.AddTupleBtn.Click += new System.EventHandler(this.AddTupleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(444, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Relations";
            // 
            // Tupples
            // 
            this.Tupples.AutoSize = true;
            this.Tupples.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Tupples.Location = new System.Drawing.Point(89, 52);
            this.Tupples.Name = "Tupples";
            this.Tupples.Size = new System.Drawing.Size(85, 32);
            this.Tupples.TabIndex = 4;
            this.Tupples.Text = "Tuples";
            // 
            // tuplesListBox
            // 
            this.tuplesListBox.FormattingEnabled = true;
            this.tuplesListBox.ItemHeight = 16;
            this.tuplesListBox.Location = new System.Drawing.Point(91, 97);
            this.tuplesListBox.Name = "tuplesListBox";
            this.tuplesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.tuplesListBox.Size = new System.Drawing.Size(288, 212);
            this.tuplesListBox.TabIndex = 5;
            // 
            // RelationsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tuplesListBox);
            this.Controls.Add(this.Tupples);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTupleBtn);
            this.Controls.Add(this.addRelationBtn);
            this.Controls.Add(this.word2TextBox);
            this.Controls.Add(this.word1TextBox);
            this.Controls.Add(this.relationTextBox);
            this.Controls.Add(this.relationsListBox);
            this.Name = "RelationsTab";
            this.Size = new System.Drawing.Size(632, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox relationsListBox;
        private System.Windows.Forms.TextBox relationTextBox;
        private System.Windows.Forms.Button addRelationBtn;
        private System.Windows.Forms.TextBox word1TextBox;
        private System.Windows.Forms.TextBox word2TextBox;
        private System.Windows.Forms.Button AddTupleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tupples;
        private System.Windows.Forms.ListBox tuplesListBox;
    }
}
