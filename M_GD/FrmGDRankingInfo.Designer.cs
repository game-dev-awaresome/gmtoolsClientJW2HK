namespace M_GD
{
    partial class FrmGDRankingInfo
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
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tbcResult = new System.Windows.Forms.TabControl();
            this.tpgComplexRank = new System.Windows.Forms.TabPage();
            this.GrdComplexRank = new System.Windows.Forms.DataGridView();
            this.pnlComplexRank = new System.Windows.Forms.Panel();
            this.cmbComplexRank = new System.Windows.Forms.ComboBox();
            this.lblComplexRank = new System.Windows.Forms.Label();
            this.tpgStraightRanking = new System.Windows.Forms.TabPage();
            this.GrdStraightRanking = new System.Windows.Forms.DataGridView();
            this.pnlStraightRanking = new System.Windows.Forms.Panel();
            this.cmbStraightRanking = new System.Windows.Forms.ComboBox();
            this.lblStraightRanking = new System.Windows.Forms.Label();
            this.backgroundWorkerFormLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerComplexRank = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerStraightRanking = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReStraightRanking = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReComplexRank = new System.ComponentModel.BackgroundWorker();
            this.GrpSearch.SuspendLayout();
            this.tbcResult.SuspendLayout();
            this.tpgComplexRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdComplexRank)).BeginInit();
            this.pnlComplexRank.SuspendLayout();
            this.tpgStraightRanking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdStraightRanking)).BeginInit();
            this.pnlStraightRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.btnClose);
            this.GrpSearch.Controls.Add(this.btnSearch);
            this.GrpSearch.Controls.Add(this.cmbServer);
            this.GrpSearch.Controls.Add(this.lblServer);
            this.GrpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpSearch.Location = new System.Drawing.Point(0, 0);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(726, 99);
            this.GrpSearch.TabIndex = 4;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "搜索条件";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(322, 57);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(322, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(107, 25);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(187, 20);
            this.cmbServer.TabIndex = 25;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(24, 28);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(65, 12);
            this.lblServer.TabIndex = 24;
            this.lblServer.Text = "蚔牁督昢ㄩ";
            // 
            // tbcResult
            // 
            this.tbcResult.Controls.Add(this.tpgComplexRank);
            this.tbcResult.Controls.Add(this.tpgStraightRanking);
            this.tbcResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcResult.Location = new System.Drawing.Point(0, 99);
            this.tbcResult.Name = "tbcResult";
            this.tbcResult.SelectedIndex = 0;
            this.tbcResult.Size = new System.Drawing.Size(726, 392);
            this.tbcResult.TabIndex = 31;
            this.tbcResult.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcResult_Selected);
            // 
            // tpgComplexRank
            // 
            this.tpgComplexRank.Controls.Add(this.GrdComplexRank);
            this.tpgComplexRank.Controls.Add(this.pnlComplexRank);
            this.tpgComplexRank.Location = new System.Drawing.Point(4, 21);
            this.tpgComplexRank.Name = "tpgComplexRank";
            this.tpgComplexRank.Size = new System.Drawing.Size(718, 367);
            this.tpgComplexRank.TabIndex = 8;
            this.tpgComplexRank.Text = "综合排名";
            this.tpgComplexRank.UseVisualStyleBackColor = true;
            // 
            // GrdComplexRank
            // 
            this.GrdComplexRank.AllowUserToAddRows = false;
            this.GrdComplexRank.AllowUserToDeleteRows = false;
            this.GrdComplexRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdComplexRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdComplexRank.Location = new System.Drawing.Point(0, 37);
            this.GrdComplexRank.Name = "GrdComplexRank";
            this.GrdComplexRank.ReadOnly = true;
            this.GrdComplexRank.RowTemplate.Height = 23;
            this.GrdComplexRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdComplexRank.Size = new System.Drawing.Size(718, 330);
            this.GrdComplexRank.TabIndex = 23;
            // 
            // pnlComplexRank
            // 
            this.pnlComplexRank.Controls.Add(this.cmbComplexRank);
            this.pnlComplexRank.Controls.Add(this.lblComplexRank);
            this.pnlComplexRank.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComplexRank.Location = new System.Drawing.Point(0, 0);
            this.pnlComplexRank.Name = "pnlComplexRank";
            this.pnlComplexRank.Size = new System.Drawing.Size(718, 37);
            this.pnlComplexRank.TabIndex = 21;
            // 
            // cmbComplexRank
            // 
            this.cmbComplexRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComplexRank.FormattingEnabled = true;
            this.cmbComplexRank.Location = new System.Drawing.Point(124, 8);
            this.cmbComplexRank.Name = "cmbComplexRank";
            this.cmbComplexRank.Size = new System.Drawing.Size(100, 20);
            this.cmbComplexRank.TabIndex = 1;
            this.cmbComplexRank.SelectedIndexChanged += new System.EventHandler(this.cmbComplexRank_SelectedIndexChanged);
            // 
            // lblComplexRank
            // 
            this.lblComplexRank.AutoSize = true;
            this.lblComplexRank.Location = new System.Drawing.Point(20, 13);
            this.lblComplexRank.Name = "lblComplexRank";
            this.lblComplexRank.Size = new System.Drawing.Size(101, 12);
            this.lblComplexRank.TabIndex = 0;
            this.lblComplexRank.Text = "请选择查看页数：";
            // 
            // tpgStraightRanking
            // 
            this.tpgStraightRanking.Controls.Add(this.GrdStraightRanking);
            this.tpgStraightRanking.Controls.Add(this.pnlStraightRanking);
            this.tpgStraightRanking.Location = new System.Drawing.Point(4, 21);
            this.tpgStraightRanking.Name = "tpgStraightRanking";
            this.tpgStraightRanking.Size = new System.Drawing.Size(718, 367);
            this.tpgStraightRanking.TabIndex = 9;
            this.tpgStraightRanking.Text = "获胜排名";
            this.tpgStraightRanking.UseVisualStyleBackColor = true;
            // 
            // GrdStraightRanking
            // 
            this.GrdStraightRanking.AllowUserToAddRows = false;
            this.GrdStraightRanking.AllowUserToDeleteRows = false;
            this.GrdStraightRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdStraightRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdStraightRanking.Location = new System.Drawing.Point(0, 37);
            this.GrdStraightRanking.Name = "GrdStraightRanking";
            this.GrdStraightRanking.ReadOnly = true;
            this.GrdStraightRanking.RowTemplate.Height = 23;
            this.GrdStraightRanking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdStraightRanking.Size = new System.Drawing.Size(718, 330);
            this.GrdStraightRanking.TabIndex = 25;
            // 
            // pnlStraightRanking
            // 
            this.pnlStraightRanking.Controls.Add(this.cmbStraightRanking);
            this.pnlStraightRanking.Controls.Add(this.lblStraightRanking);
            this.pnlStraightRanking.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStraightRanking.Location = new System.Drawing.Point(0, 0);
            this.pnlStraightRanking.Name = "pnlStraightRanking";
            this.pnlStraightRanking.Size = new System.Drawing.Size(718, 37);
            this.pnlStraightRanking.TabIndex = 24;
            // 
            // cmbStraightRanking
            // 
            this.cmbStraightRanking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStraightRanking.FormattingEnabled = true;
            this.cmbStraightRanking.Location = new System.Drawing.Point(124, 8);
            this.cmbStraightRanking.Name = "cmbStraightRanking";
            this.cmbStraightRanking.Size = new System.Drawing.Size(100, 20);
            this.cmbStraightRanking.TabIndex = 1;
            this.cmbStraightRanking.SelectedIndexChanged += new System.EventHandler(this.cmbStraightRanking_SelectedIndexChanged);
            // 
            // lblStraightRanking
            // 
            this.lblStraightRanking.AutoSize = true;
            this.lblStraightRanking.Location = new System.Drawing.Point(20, 13);
            this.lblStraightRanking.Name = "lblStraightRanking";
            this.lblStraightRanking.Size = new System.Drawing.Size(101, 12);
            this.lblStraightRanking.TabIndex = 0;
            this.lblStraightRanking.Text = "恁寁脤艘珜杅ㄩ";
            // 
            // backgroundWorkerFormLoad
            // 
            this.backgroundWorkerFormLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFormLoad_DoWork_1);
            this.backgroundWorkerFormLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFormLoad_RunWorkerCompleted_1);
            // 
            // backgroundWorkerComplexRank
            // 
            this.backgroundWorkerComplexRank.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerComplexRank_DoWork);
            this.backgroundWorkerComplexRank.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerComplexRank_RunWorkerCompleted);
            // 
            // backgroundWorkerStraightRanking
            // 
            this.backgroundWorkerStraightRanking.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerStraightRanking_DoWork);
            this.backgroundWorkerStraightRanking.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerStraightRanking_RunWorkerCompleted);
            // 
            // backgroundWorkerReStraightRanking
            // 
            this.backgroundWorkerReStraightRanking.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReStraightRanking_DoWork);
            this.backgroundWorkerReStraightRanking.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReStraightRanking_RunWorkerCompleted);
            // 
            // backgroundWorkerReComplexRank
            // 
            this.backgroundWorkerReComplexRank.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReComplexRank_DoWork);
            this.backgroundWorkerReComplexRank.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReComplexRank_RunWorkerCompleted);
            // 
            // FrmGDRankingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 491);
            this.Controls.Add(this.tbcResult);
            this.Controls.Add(this.GrpSearch);
            this.Name = "FrmGDRankingInfo";
            this.Text = "用户排名查询";
            this.Load += new System.EventHandler(this.FrmGDRankingInfo_Load);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.tbcResult.ResumeLayout(false);
            this.tpgComplexRank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdComplexRank)).EndInit();
            this.pnlComplexRank.ResumeLayout(false);
            this.pnlComplexRank.PerformLayout();
            this.tpgStraightRanking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdStraightRanking)).EndInit();
            this.pnlStraightRanking.ResumeLayout(false);
            this.pnlStraightRanking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TabControl tbcResult;
        private System.Windows.Forms.TabPage tpgComplexRank;
        private System.Windows.Forms.TabPage tpgStraightRanking;
        private System.Windows.Forms.DataGridView GrdComplexRank;
        private System.Windows.Forms.Panel pnlComplexRank;
        private System.Windows.Forms.ComboBox cmbComplexRank;
        private System.Windows.Forms.Label lblComplexRank;
        private System.Windows.Forms.DataGridView GrdStraightRanking;
        private System.Windows.Forms.Panel pnlStraightRanking;
        private System.Windows.Forms.ComboBox cmbStraightRanking;
        private System.Windows.Forms.Label lblStraightRanking;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFormLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerComplexRank;
        private System.ComponentModel.BackgroundWorker backgroundWorkerStraightRanking;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReStraightRanking;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReComplexRank;
    }
}