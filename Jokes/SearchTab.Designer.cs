namespace Jokes
{
    partial class SearchTab
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
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.sEARCHRESULTDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.jOKEID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILETITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lINEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEARCH_TEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHRESULTDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AllowUserToOrderColumns = true;
            this.dgvSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResults.AutoGenerateColumns = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jOKEID1DataGridViewTextBoxColumn,
            this.fIRSTINDEXDataGridViewTextBoxColumn,
            this.fILETITLEDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.lINEINDEXDataGridViewTextBoxColumn,
            this.SEARCH_TEXT});
            this.dgvSearchResults.DataSource = this.sEARCHRESULTDataTableBindingSource;
            this.dgvSearchResults.Location = new System.Drawing.Point(0, 54);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.Size = new System.Drawing.Size(644, 361);
            this.dgvSearchResults.TabIndex = 0;
            this.dgvSearchResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResults_CellContentDoubleClick);
            // 
            // sEARCHRESULTDataTableBindingSource
            // 
            this.sEARCHRESULTDataTableBindingSource.DataSource = typeof(DAL.JokesDS.SEARCH_RESULTDataTable);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(77, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(417, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(513, 6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(111, 42);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // jOKEID1DataGridViewTextBoxColumn
            // 
            this.jOKEID1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jOKEID1DataGridViewTextBoxColumn.DataPropertyName = "JOKE_ID";
            this.jOKEID1DataGridViewTextBoxColumn.HeaderText = "JOKE_ID";
            this.jOKEID1DataGridViewTextBoxColumn.Name = "jOKEID1DataGridViewTextBoxColumn";
            this.jOKEID1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIRSTINDEXDataGridViewTextBoxColumn
            // 
            this.fIRSTINDEXDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fIRSTINDEXDataGridViewTextBoxColumn.DataPropertyName = "FIRST_INDEX";
            this.fIRSTINDEXDataGridViewTextBoxColumn.HeaderText = "FIRST_INDEX";
            this.fIRSTINDEXDataGridViewTextBoxColumn.Name = "fIRSTINDEXDataGridViewTextBoxColumn";
            this.fIRSTINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fILETITLEDataGridViewTextBoxColumn
            // 
            this.fILETITLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fILETITLEDataGridViewTextBoxColumn.DataPropertyName = "FILE_TITLE";
            this.fILETITLEDataGridViewTextBoxColumn.HeaderText = "FILE_TITLE";
            this.fILETITLEDataGridViewTextBoxColumn.Name = "fILETITLEDataGridViewTextBoxColumn";
            this.fILETITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "JOKE_INDEX";
            this.dataGridViewTextBoxColumn1.HeaderText = "JOKE_INDEX";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lINEINDEXDataGridViewTextBoxColumn
            // 
            this.lINEINDEXDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lINEINDEXDataGridViewTextBoxColumn.DataPropertyName = "LINE_INDEX";
            this.lINEINDEXDataGridViewTextBoxColumn.HeaderText = "LINE_INDEX";
            this.lINEINDEXDataGridViewTextBoxColumn.Name = "lINEINDEXDataGridViewTextBoxColumn";
            this.lINEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SEARCH_TEXT
            // 
            this.SEARCH_TEXT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SEARCH_TEXT.DataPropertyName = "SEARCH_TEXT";
            this.SEARCH_TEXT.HeaderText = "SEARCH_TEXT";
            this.SEARCH_TEXT.Name = "SEARCH_TEXT";
            this.SEARCH_TEXT.ReadOnly = true;
            // 
            // SearchTab
            // 
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchResults);
            this.Name = "SearchTab";
            this.Size = new System.Drawing.Size(645, 415);
            this.Load += new System.EventHandler(this.SearchTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHRESULTDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.BindingSource sEARCHRESULTDataTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOKEID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fILETITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lINEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEARCH_TEXT;
    }
}
