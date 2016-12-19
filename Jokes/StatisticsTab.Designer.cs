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
            this.components = new System.ComponentModel.Container();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCommon = new System.Windows.Forms.DataGridView();
            this.cOMMONNESSWORDDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshCommon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMONNESSWORDDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // avgLetters
            // 
            this.avgLetters.AutoSize = true;
            this.avgLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLetters.Location = new System.Drawing.Point(334, 76);
            this.avgLetters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgLetters.Name = "avgLetters";
            this.avgLetters.Size = new System.Drawing.Size(181, 24);
            this.avgLetters.TabIndex = 0;
            this.avgLetters.Text = "Average letters in word";
            this.avgLetters.CheckedChanged += new System.EventHandler(this.avgLetters_CheckedChanged);
            // 
            // avgWords
            // 
            this.avgWords.AutoSize = true;
            this.avgWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWords.Location = new System.Drawing.Point(334, 115);
            this.avgWords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgWords.Name = "avgWords";
            this.avgWords.Size = new System.Drawing.Size(174, 24);
            this.avgWords.TabIndex = 0;
            this.avgWords.Text = "Average words in joke";
            this.avgWords.CheckedChanged += new System.EventHandler(this.avgWords_CheckedChanged);
            // 
            // avgJokes
            // 
            this.avgJokes.AutoSize = true;
            this.avgJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgJokes.Location = new System.Drawing.Point(334, 153);
            this.avgJokes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avgJokes.Name = "avgJokes";
            this.avgJokes.Size = new System.Drawing.Size(167, 24);
            this.avgJokes.TabIndex = 0;
            this.avgJokes.Text = "Average words in file";
            this.avgJokes.CheckedChanged += new System.EventHandler(this.avgJokes_CheckedChanged);
            // 
            // maxLetters
            // 
            this.maxLetters.AutoSize = true;
            this.maxLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLetters.Location = new System.Drawing.Point(18, 76);
            this.maxLetters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxLetters.Name = "maxLetters";
            this.maxLetters.Size = new System.Drawing.Size(154, 24);
            this.maxLetters.TabIndex = 0;
            this.maxLetters.Text = "Max letters in word";
            this.maxLetters.CheckedChanged += new System.EventHandler(this.maxLetters_CheckedChanged);
            // 
            // maxWordsFile
            // 
            this.maxWordsFile.AutoSize = true;
            this.maxWordsFile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWordsFile.Location = new System.Drawing.Point(24, 188);
            this.maxWordsFile.Name = "maxWordsFile";
            this.maxWordsFile.Size = new System.Drawing.Size(181, 29);
            this.maxWordsFile.TabIndex = 0;
            this.maxWordsFile.Text = "Max words in file";
            this.maxWordsFile.CheckedChanged += new System.EventHandler(this.maxWordsFile_CheckedChanged);
            // 
            // maxWords
            // 
            this.maxWords.AutoSize = true;
            this.maxWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWords.Location = new System.Drawing.Point(18, 114);
            this.maxWords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxWords.Name = "maxWords";
            this.maxWords.Size = new System.Drawing.Size(147, 24);
            this.maxWords.TabIndex = 0;
            this.maxWords.Text = "Max words in joke";
            this.maxWords.CheckedChanged += new System.EventHandler(this.maxWords_CheckedChanged);
            // 
            // minLetters
            // 
            this.minLetters.AutoSize = true;
            this.minLetters.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLetters.Location = new System.Drawing.Point(180, 76);
            this.minLetters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minLetters.Name = "minLetters";
            this.minLetters.Size = new System.Drawing.Size(151, 24);
            this.minLetters.TabIndex = 0;
            this.minLetters.Text = "Min letters in word";
            this.minLetters.CheckedChanged += new System.EventHandler(this.minLetters_CheckedChanged);
            // 
            // minWords
            // 
            this.minWords.AutoSize = true;
            this.minWords.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minWords.Location = new System.Drawing.Point(180, 115);
            this.minWords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minWords.Name = "minWords";
            this.minWords.Size = new System.Drawing.Size(148, 24);
            this.minWords.TabIndex = 0;
            this.minWords.Text = "Min  words in joke";
            this.minWords.CheckedChanged += new System.EventHandler(this.minWords_CheckedChanged);
            // 
            // mostCommon
            // 
            this.mostCommon.AutoSize = true;
            this.mostCommon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostCommon.Location = new System.Drawing.Point(18, 153);
            this.mostCommon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mostCommon.Name = "mostCommon";
            this.mostCommon.Size = new System.Drawing.Size(161, 24);
            this.mostCommon.TabIndex = 0;
            this.mostCommon.Text = "Most common word";
            this.mostCommon.CheckedChanged += new System.EventHandler(this.mostCommon_CheckedChanged);
            // 
            // minJokes
            // 
            this.minJokes.AutoSize = true;
            this.minJokes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minJokes.Location = new System.Drawing.Point(180, 153);
            this.minJokes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minJokes.Name = "minJokes";
            this.minJokes.Size = new System.Drawing.Size(131, 24);
            this.minJokes.TabIndex = 0;
            this.minJokes.Text = "Min jokes in file";
            this.minJokes.CheckedChanged += new System.EventHandler(this.minJokes_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 260);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(172, 260);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 62);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(19, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numeric Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(169, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject";
            // 
            // dgvCommon
            // 
            this.dgvCommon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommon.AutoGenerateColumns = false;
            this.dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wORDDataGridViewTextBoxColumn,
            this.cOUNTDataGridViewTextBoxColumn});
            this.dgvCommon.DataSource = this.cOMMONNESSWORDDataTableBindingSource;
            this.dgvCommon.Location = new System.Drawing.Point(3, 336);
            this.dgvCommon.Name = "dgvCommon";
            this.dgvCommon.Size = new System.Drawing.Size(734, 150);
            this.dgvCommon.TabIndex = 5;
            // 
            // cOMMONNESSWORDDataTableBindingSource
            // 
            this.cOMMONNESSWORDDataTableBindingSource.DataSource = typeof(DAL.JokesDS.COMMONNESS_WORDDataTable);
            // 
            // wORDDataGridViewTextBoxColumn
            // 
            this.wORDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wORDDataGridViewTextBoxColumn.DataPropertyName = "WORD";
            this.wORDDataGridViewTextBoxColumn.HeaderText = "WORD";
            this.wORDDataGridViewTextBoxColumn.Name = "wORDDataGridViewTextBoxColumn";
            // 
            // cOUNTDataGridViewTextBoxColumn
            // 
            this.cOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cOUNTDataGridViewTextBoxColumn.DataPropertyName = "COUNT";
            this.cOUNTDataGridViewTextBoxColumn.HeaderText = "COUNT";
            this.cOUNTDataGridViewTextBoxColumn.Name = "cOUNTDataGridViewTextBoxColumn";
            // 
            // btnRefreshCommon
            // 
            this.btnRefreshCommon.Location = new System.Drawing.Point(552, 299);
            this.btnRefreshCommon.Name = "btnRefreshCommon";
            this.btnRefreshCommon.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCommon.TabIndex = 6;
            this.btnRefreshCommon.Text = "Refresh";
            this.btnRefreshCommon.UseVisualStyleBackColor = true;
            this.btnRefreshCommon.Click += new System.EventHandler(this.btnRefreshCommon_Click);
            // 
            // StatisticsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefreshCommon);
            this.Controls.Add(this.dgvCommon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minJokes);
            this.Controls.Add(this.minWords);
            this.Controls.Add(this.maxWords);
            this.Controls.Add(this.minLetters);
            this.Controls.Add(this.maxLetters);
            this.Controls.Add(this.avgJokes);
            this.Controls.Add(this.avgWords);
            this.Controls.Add(this.mostCommon);
            this.Controls.Add(this.avgLetters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatisticsTab";
            this.Size = new System.Drawing.Size(740, 486);
            this.Load += new System.EventHandler(this.StatisticsTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMONNESSWORDDataTableBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCommon;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cOMMONNESSWORDDataTableBindingSource;
        private System.Windows.Forms.Button btnRefreshCommon;
        // private System.Windows.Forms.RadioButton radioButton1;



    }
}
