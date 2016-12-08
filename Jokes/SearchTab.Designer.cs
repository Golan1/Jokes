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
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.jKFILEDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.sEARCHRESULTDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOKEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILETITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOKEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lINENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKFILEDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHRESULTDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToOrderColumns = true;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jOKEIDDataGridViewTextBoxColumn,
            this.fIRSTINDEXDataGridViewTextBoxColumn,
            this.fILETITLEDataGridViewTextBoxColumn,
            this.jOKEINDEXDataGridViewTextBoxColumn,
            this.lINENUMBERDataGridViewTextBoxColumn});
            this.dgvFiles.DataSource = this.sEARCHRESULTDataTableBindingSource;
            this.dgvFiles.Location = new System.Drawing.Point(0, 118);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.Size = new System.Drawing.Size(750, 297);
            this.dgvFiles.TabIndex = 0;
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            // 
            // jKFILEDataTableBindingSource
            // 
            this.jKFILEDataTableBindingSource.DataSource = typeof(DAL.JokesDS.JK_FILEDataTable);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
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
            this.txtSearch.Size = new System.Drawing.Size(523, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(619, 6);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(111, 42);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // sEARCHRESULTDataTableBindingSource
            // 
            this.sEARCHRESULTDataTableBindingSource.DataSource = typeof(DAL.JokesDS.SEARCH_RESULTDataTable);
            // 
            // jOKEIDDataGridViewTextBoxColumn
            // 
            this.jOKEIDDataGridViewTextBoxColumn.DataPropertyName = "JOKE_ID";
            this.jOKEIDDataGridViewTextBoxColumn.HeaderText = "JOKE_ID";
            this.jOKEIDDataGridViewTextBoxColumn.Name = "jOKEIDDataGridViewTextBoxColumn";
            this.jOKEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIRSTINDEXDataGridViewTextBoxColumn
            // 
            this.fIRSTINDEXDataGridViewTextBoxColumn.DataPropertyName = "FIRST_INDEX";
            this.fIRSTINDEXDataGridViewTextBoxColumn.HeaderText = "FIRST_INDEX";
            this.fIRSTINDEXDataGridViewTextBoxColumn.Name = "fIRSTINDEXDataGridViewTextBoxColumn";
            this.fIRSTINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fILETITLEDataGridViewTextBoxColumn
            // 
            this.fILETITLEDataGridViewTextBoxColumn.DataPropertyName = "FILE_TITLE";
            this.fILETITLEDataGridViewTextBoxColumn.HeaderText = "FILE_TITLE";
            this.fILETITLEDataGridViewTextBoxColumn.Name = "fILETITLEDataGridViewTextBoxColumn";
            this.fILETITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOKEINDEXDataGridViewTextBoxColumn
            // 
            this.jOKEINDEXDataGridViewTextBoxColumn.DataPropertyName = "JOKE_INDEX";
            this.jOKEINDEXDataGridViewTextBoxColumn.HeaderText = "JOKE_INDEX";
            this.jOKEINDEXDataGridViewTextBoxColumn.Name = "jOKEINDEXDataGridViewTextBoxColumn";
            this.jOKEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lINENUMBERDataGridViewTextBoxColumn
            // 
            this.lINENUMBERDataGridViewTextBoxColumn.DataPropertyName = "LINE_NUMBER";
            this.lINENUMBERDataGridViewTextBoxColumn.HeaderText = "LINE_NUMBER";
            this.lINENUMBERDataGridViewTextBoxColumn.Name = "lINENUMBERDataGridViewTextBoxColumn";
            this.lINENUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SearchTab
            // 
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFiles);
            this.Name = "SearchTab";
            this.Size = new System.Drawing.Size(751, 415);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jKFILEDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEARCHRESULTDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.BindingSource jKFILEDataTableBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOKEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fILETITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOKEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lINENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sEARCHRESULTDataTableBindingSource;
    }
}
