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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LoadControl = new System.Windows.Forms.TabPage();
            this.loadTab1 = new Jokes.LoadTab();
            this.Search = new System.Windows.Forms.TabPage();
            this.searchTab1 = new Jokes.SearchTab();
            this.Groups = new System.Windows.Forms.TabPage();
            this.groupTab1 = new Jokes.GroupsTab();
            this.Relations = new System.Windows.Forms.TabPage();
            this.relationTab1 = new Jokes.RelationsTab();
            this.Files = new System.Windows.Forms.TabPage();
            this.filesTab1 = new Jokes.FilesTab();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.statisticsTab1 = new StatisticsTab();
            this.tabControl1.SuspendLayout();
            this.LoadControl.SuspendLayout();
            this.Search.SuspendLayout();
            this.Groups.SuspendLayout();
            this.Relations.SuspendLayout();
            this.Files.SuspendLayout();
            this.Statistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LoadControl);
            this.tabControl1.Controls.Add(this.Search);
            this.tabControl1.Controls.Add(this.Groups);
            this.tabControl1.Controls.Add(this.Relations);
            this.tabControl1.Controls.Add(this.Files);
            this.tabControl1.Controls.Add(this.Statistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // LoadControl
            // 
            this.LoadControl.Controls.Add(this.loadTab1);
            this.LoadControl.Location = new System.Drawing.Point(4, 22);
            this.LoadControl.Margin = new System.Windows.Forms.Padding(2);
            this.LoadControl.Name = "LoadControl";
            this.LoadControl.Padding = new System.Windows.Forms.Padding(2);
            this.LoadControl.Size = new System.Drawing.Size(744,402);
            this.LoadControl.TabIndex = 0;
            this.LoadControl.Text = "Load";
            this.LoadControl.UseVisualStyleBackColor = true;
            // 
            // loadTab1
            // 
            this.loadTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTab1.Location = new System.Drawing.Point(2, 2);
            this.loadTab1.Margin = new System.Windows.Forms.Padding(0);
            this.loadTab1.Name = "loadTab1";
            this.loadTab1.Size = new System.Drawing.Size(740,398);
            this.loadTab1.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.searchTab1);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding( 2);
            this.Search.Size = new System.Drawing.Size(744,402);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // searchTab1
            // 
            this.searchTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTab1.Location = new System.Drawing.Point(2, 2);            
            this.searchTab1.Name = "searchTab1";
            this.searchTab1.Size = new System.Drawing.Size(740,398);
            this.searchTab1.TabIndex = 0;
            // 
            // Groups
            // 
            this.Groups.Controls.Add(this.groupTab1);
            this.Groups.Location = new System.Drawing.Point(4, 22);
            this.Groups.Margin = new System.Windows.Forms.Padding(2);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(744,402);
            this.Groups.TabIndex = 2;
            this.Groups.Text = "Groups";
            this.Groups.UseVisualStyleBackColor = true;
            // 
            // groupTab1
            // 
            this.groupTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTab1.Groups = ((System.Collections.Generic.Dictionary<int, string>)(resources.GetObject("groupTab1.Groups")));
            this.groupTab1.Location = new System.Drawing.Point(0, 0);
            this.groupTab1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupTab1.Name = "groupTab1";
            this.groupTab1.Size = new System.Drawing.Size(744, 402);
            this.groupTab1.TabIndex = 0;
            // 
            // Relations
            // 
            this.Relations.Controls.Add(this.relationTab1);
            this.Relations.Location = new System.Drawing.Point(4, 22);
            this.Relations.Margin = new System.Windows.Forms.Padding(2);
            this.Relations.Name = "Relations";
            this.Relations.Size = new System.Drawing.Size(744,402);
            this.Relations.TabIndex = 3;
            this.Relations.Text = "Relations";
            this.Relations.UseVisualStyleBackColor = true;
            // 
            // relationTab1
            // 
            this.relationTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relationTab1.Location = new System.Drawing.Point(0, 0);
            this.relationTab1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.relationTab1.Name = "relationTab1";
            this.relationTab1.Relations = ((System.Collections.Generic.Dictionary<int, string>)(resources.GetObject("relationTab1.Relations")));
            this.relationTab1.Size = new System.Drawing.Size(744,402);
            this.relationTab1.TabIndex = 0;
            // 
            // Files
            // 
            this.Files.Controls.Add(this.filesTab1);
            this.Files.Location = new System.Drawing.Point(4, 22);
            this.Files.Margin = new System.Windows.Forms.Padding( 2);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(744, 402);
            this.Files.TabIndex = 4;
            this.Files.Text = "Files";
            this.Files.UseVisualStyleBackColor = true;
            // 
            // filesTab1
            // 
            this.filesTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTab1.Location = new System.Drawing.Point(0, 0);
            this.filesTab1.Name = "filesTab1";
            this.filesTab1.Size = new System.Drawing.Size(744, 402);
            this.filesTab1.TabIndex = 0;
            // 
            // Statistics
            // 
            this.Statistics.Controls.Add(this.statisticsTab1);
            this.Statistics.Location = new System.Drawing.Point(4, 22);
            this.Statistics.Name = "statisticsTab1";
            this.Statistics.Size = new System.Drawing.Size(744, 402);
            this.Statistics.TabIndex = 5;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // statisticsTab1
            // 
            this.statisticsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsTab1.Location = new System.Drawing.Point(0, 0);
            this.statisticsTab1.Margin = new System.Windows.Forms.Padding(2, 2, 2,2);
            this.statisticsTab1.Name = "statisticsTab1";
            this.statisticsTab1.Size = new System.Drawing.Size(744, 402);
            this.statisticsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 428);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.LoadControl.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Groups.ResumeLayout(false);
            this.Relations.ResumeLayout(false);
            this.Files.ResumeLayout(false);
            this.Statistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LoadControl;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.TabPage Relations;
        private System.Windows.Forms.TabPage Files;
        private LoadTab loadTab1;
        private GroupsTab groupTab1;
        private RelationsTab relationTab1;
        private FilesTab filesTab1;
        private SearchTab searchTab1;
        private StatisticsTab statisticsTab1;

        private System.Windows.Forms.TabPage Statistics;
    }
}