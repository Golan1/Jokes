namespace Jokes
{
    partial class FileForm
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.rbJoke = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.numJoke = new System.Windows.Forms.NumericUpDown();
            this.numLine = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numJokeIndex = new System.Windows.Forms.NumericUpDown();
            this.numLineIndex = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.wORDINJOKEDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOKEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDEXINJOKEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lINEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNDEXINLINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJokeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORDINJOKEDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 61);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(407, 276);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToAddRows = false;
            this.dgvWords.AllowUserToDeleteRows = false;
            this.dgvWords.AllowUserToOrderColumns = true;
            this.dgvWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWords.AutoGenerateColumns = false;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tEXTDataGridViewTextBoxColumn,
            this.jOKEINDEXDataGridViewTextBoxColumn,
            this.iNDEXINJOKEDataGridViewTextBoxColumn,
            this.lINEINDEXDataGridViewTextBoxColumn,
            this.iNDEXINLINEDataGridViewTextBoxColumn});
            this.dgvWords.DataSource = this.wORDINJOKEDataTableBindingSource;
            this.dgvWords.Location = new System.Drawing.Point(450, 61);
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.ReadOnly = true;
            this.dgvWords.Size = new System.Drawing.Size(548, 276);
            this.dgvWords.TabIndex = 1;
            // 
            // rbJoke
            // 
            this.rbJoke.AutoSize = true;
            this.rbJoke.Location = new System.Drawing.Point(450, 12);
            this.rbJoke.Name = "rbJoke";
            this.rbJoke.Size = new System.Drawing.Size(91, 17);
            this.rbJoke.TabIndex = 2;
            this.rbJoke.TabStop = true;
            this.rbJoke.Text = "Joke Number:";
            this.rbJoke.UseVisualStyleBackColor = true;
            this.rbJoke.CheckedChanged += new System.EventHandler(this.rbJoke_CheckedChanged);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(450, 38);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(88, 17);
            this.rbLine.TabIndex = 3;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line Number:";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
            // 
            // numJoke
            // 
            this.numJoke.Location = new System.Drawing.Point(548, 12);
            this.numJoke.Name = "numJoke";
            this.numJoke.Size = new System.Drawing.Size(36, 20);
            this.numJoke.TabIndex = 4;
            this.numJoke.ValueChanged += new System.EventHandler(this.numJoke_ValueChanged);
            // 
            // numLine
            // 
            this.numLine.Location = new System.Drawing.Point(548, 38);
            this.numLine.Name = "numLine";
            this.numLine.Size = new System.Drawing.Size(36, 20);
            this.numLine.TabIndex = 5;
            this.numLine.ValueChanged += new System.EventHandler(this.numLine_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Index In Joke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Index In Line:";
            // 
            // numJokeIndex
            // 
            this.numJokeIndex.Location = new System.Drawing.Point(704, 12);
            this.numJokeIndex.Name = "numJokeIndex";
            this.numJokeIndex.Size = new System.Drawing.Size(36, 20);
            this.numJokeIndex.TabIndex = 8;
            this.numJokeIndex.ValueChanged += new System.EventHandler(this.numJokeIndex_ValueChanged);
            // 
            // numLineIndex
            // 
            this.numLineIndex.Location = new System.Drawing.Point(704, 38);
            this.numLineIndex.Name = "numLineIndex";
            this.numLineIndex.Size = new System.Drawing.Size(36, 20);
            this.numLineIndex.TabIndex = 9;
            this.numLineIndex.ValueChanged += new System.EventHandler(this.numLineIndex_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(764, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 44);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // wORDINJOKEDataTableBindingSource
            // 
            this.wORDINJOKEDataTableBindingSource.DataSource = typeof(DAL.JokesDS.WORD_IN_JOKEDataTable);
            // 
            // tEXTDataGridViewTextBoxColumn
            // 
            this.tEXTDataGridViewTextBoxColumn.DataPropertyName = "TEXT";
            this.tEXTDataGridViewTextBoxColumn.HeaderText = "TEXT";
            this.tEXTDataGridViewTextBoxColumn.Name = "tEXTDataGridViewTextBoxColumn";
            this.tEXTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOKEINDEXDataGridViewTextBoxColumn
            // 
            this.jOKEINDEXDataGridViewTextBoxColumn.DataPropertyName = "JOKE_INDEX";
            this.jOKEINDEXDataGridViewTextBoxColumn.HeaderText = "JOKE_INDEX";
            this.jOKEINDEXDataGridViewTextBoxColumn.Name = "jOKEINDEXDataGridViewTextBoxColumn";
            this.jOKEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNDEXINJOKEDataGridViewTextBoxColumn
            // 
            this.iNDEXINJOKEDataGridViewTextBoxColumn.DataPropertyName = "INDEX_IN_JOKE";
            this.iNDEXINJOKEDataGridViewTextBoxColumn.HeaderText = "INDEX_IN_JOKE";
            this.iNDEXINJOKEDataGridViewTextBoxColumn.Name = "iNDEXINJOKEDataGridViewTextBoxColumn";
            this.iNDEXINJOKEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lINEINDEXDataGridViewTextBoxColumn
            // 
            this.lINEINDEXDataGridViewTextBoxColumn.DataPropertyName = "LINE_INDEX";
            this.lINEINDEXDataGridViewTextBoxColumn.HeaderText = "LINE_INDEX";
            this.lINEINDEXDataGridViewTextBoxColumn.Name = "lINEINDEXDataGridViewTextBoxColumn";
            this.lINEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNDEXINLINEDataGridViewTextBoxColumn
            // 
            this.iNDEXINLINEDataGridViewTextBoxColumn.DataPropertyName = "INDEX_IN_LINE";
            this.iNDEXINLINEDataGridViewTextBoxColumn.HeaderText = "INDEX_IN_LINE";
            this.iNDEXINLINEDataGridViewTextBoxColumn.Name = "iNDEXINLINEDataGridViewTextBoxColumn";
            this.iNDEXINLINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTitle.Location = new System.Drawing.Point(20, 16);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(48, 25);
            this.txtTitle.TabIndex = 11;
            this.txtTitle.Text = "Title";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 369);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numLineIndex);
            this.Controls.Add(this.numJokeIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numLine);
            this.Controls.Add(this.numJoke);
            this.Controls.Add(this.rbLine);
            this.Controls.Add(this.rbJoke);
            this.Controls.Add(this.dgvWords);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.Load += new System.EventHandler(this.FileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJokeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORDINJOKEDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.RadioButton rbJoke;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.NumericUpDown numJoke;
        private System.Windows.Forms.NumericUpDown numLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numJokeIndex;
        private System.Windows.Forms.NumericUpDown numLineIndex;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOKEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDEXINJOKEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lINEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNDEXINLINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wORDINJOKEDataTableBindingSource;
        private System.Windows.Forms.Label txtTitle;
    }
}