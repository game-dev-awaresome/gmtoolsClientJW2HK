namespace M_GD
{
    partial class FrmGDLoginInfo
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
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.LblLink = new System.Windows.Forms.Label();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tbcResult = new System.Windows.Forms.TabControl();
            this.tpgCharacter = new System.Windows.Forms.TabPage();
            this.GrdCharacter = new System.Windows.Forms.DataGridView();
            this.tpgLoginInfo = new System.Windows.Forms.TabPage();
            this.GrdLoginInfo = new System.Windows.Forms.DataGridView();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.cmbLoginInfo = new System.Windows.Forms.ComboBox();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.backgroundWorkerFormLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLogin = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReLogin = new System.ComponentModel.BackgroundWorker();
            this.GrpSearch.SuspendLayout();
            this.tbcResult.SuspendLayout();
            this.tpgCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).BeginInit();
            this.tpgLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdLoginInfo)).BeginInit();
            this.pnlLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.DtpEnd);
            this.GrpSearch.Controls.Add(this.LblLink);
            this.GrpSearch.Controls.Add(this.DtpBegin);
            this.GrpSearch.Controls.Add(this.LblDate);
            this.GrpSearch.Controls.Add(this.lblHint);
            this.GrpSearch.Controls.Add(this.btnClose);
            this.GrpSearch.Controls.Add(this.btnSearch);
            this.GrpSearch.Controls.Add(this.txtNick);
            this.GrpSearch.Controls.Add(this.lblNick);
            this.GrpSearch.Controls.Add(this.txtAccount);
            this.GrpSearch.Controls.Add(this.lblAccount);
            this.GrpSearch.Controls.Add(this.cmbServer);
            this.GrpSearch.Controls.Add(this.lblServer);
            this.GrpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpSearch.Location = new System.Drawing.Point(0, 0);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(881, 133);
            this.GrpSearch.TabIndex = 4;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "搜索条件";
            // 
            // DtpEnd
            // 
            this.DtpEnd.CustomFormat = "yyyy-MM-dd";
            this.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEnd.Location = new System.Drawing.Point(310, 87);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(188, 21);
            this.DtpEnd.TabIndex = 118;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(319, 72);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(65, 12);
            this.LblLink.TabIndex = 117;
            this.LblLink.Text = "结束时间：";
            // 
            // DtpBegin
            // 
            this.DtpBegin.CustomFormat = "yyyy-MM-dd";
            this.DtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpBegin.Location = new System.Drawing.Point(310, 41);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(188, 21);
            this.DtpBegin.TabIndex = 116;
            this.DtpBegin.Leave += new System.EventHandler(this.DtpBegin_Leave);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(319, 25);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(65, 12);
            this.LblDate.TabIndex = 115;
            this.LblDate.Text = "开始时间：";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(300, 118);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(569, 12);
            this.lblHint.TabIndex = 109;
            this.lblHint.Text = "提示：查詢到的用戶登陸資訊有兩個小時的延遲，即距當前時間兩個小時之內的登陸資訊無法查詢登陸資訊";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(612, 59);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(612, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(107, 92);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(187, 21);
            this.txtNick.TabIndex = 29;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(36, 95);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(65, 12);
            this.lblNick.TabIndex = 28;
            this.lblNick.Text = "玩家昵稱：";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(107, 58);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(187, 21);
            this.txtAccount.TabIndex = 27;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(36, 61);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(65, 12);
            this.lblAccount.TabIndex = 26;
            this.lblAccount.Text = "玩家帳號：";
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(107, 25);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(187, 20);
            this.cmbServer.TabIndex = 25;
            this.cmbServer.SelectedIndexChanged += new System.EventHandler(this.cmbServer_SelectedIndexChanged);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(24, 28);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(77, 12);
            this.lblServer.TabIndex = 24;
            this.lblServer.Text = "遊戲伺服器：";
            // 
            // tbcResult
            // 
            this.tbcResult.Controls.Add(this.tpgCharacter);
            this.tbcResult.Controls.Add(this.tpgLoginInfo);
            this.tbcResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcResult.Location = new System.Drawing.Point(0, 133);
            this.tbcResult.Name = "tbcResult";
            this.tbcResult.SelectedIndex = 0;
            this.tbcResult.Size = new System.Drawing.Size(881, 353);
            this.tbcResult.TabIndex = 5;
            this.tbcResult.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcResult_Selected);
            // 
            // tpgCharacter
            // 
            this.tpgCharacter.Controls.Add(this.GrdCharacter);
            this.tpgCharacter.Location = new System.Drawing.Point(4, 21);
            this.tpgCharacter.Name = "tpgCharacter";
            this.tpgCharacter.Size = new System.Drawing.Size(873, 328);
            this.tpgCharacter.TabIndex = 7;
            this.tpgCharacter.Text = "玩家角色信息";
            this.tpgCharacter.UseVisualStyleBackColor = true;
            // 
            // GrdCharacter
            // 
            this.GrdCharacter.AllowUserToAddRows = false;
            this.GrdCharacter.AllowUserToDeleteRows = false;
            this.GrdCharacter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCharacter.Location = new System.Drawing.Point(0, 0);
            this.GrdCharacter.Name = "GrdCharacter";
            this.GrdCharacter.ReadOnly = true;
            this.GrdCharacter.RowTemplate.Height = 23;
            this.GrdCharacter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCharacter.Size = new System.Drawing.Size(873, 328);
            this.GrdCharacter.TabIndex = 10;
            this.GrdCharacter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellDoubleClick);
            this.GrdCharacter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellClick);
            // 
            // tpgLoginInfo
            // 
            this.tpgLoginInfo.Controls.Add(this.GrdLoginInfo);
            this.tpgLoginInfo.Controls.Add(this.pnlLoginInfo);
            this.tpgLoginInfo.Location = new System.Drawing.Point(4, 21);
            this.tpgLoginInfo.Name = "tpgLoginInfo";
            this.tpgLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLoginInfo.Size = new System.Drawing.Size(873, 328);
            this.tpgLoginInfo.TabIndex = 0;
            this.tpgLoginInfo.Text = "登陸信息";
            this.tpgLoginInfo.UseVisualStyleBackColor = true;
            // 
            // GrdLoginInfo
            // 
            this.GrdLoginInfo.AllowUserToAddRows = false;
            this.GrdLoginInfo.AllowUserToDeleteRows = false;
            this.GrdLoginInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdLoginInfo.Location = new System.Drawing.Point(3, 40);
            this.GrdLoginInfo.Name = "GrdLoginInfo";
            this.GrdLoginInfo.ReadOnly = true;
            this.GrdLoginInfo.RowTemplate.Height = 23;
            this.GrdLoginInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdLoginInfo.Size = new System.Drawing.Size(867, 285);
            this.GrdLoginInfo.TabIndex = 12;
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.Controls.Add(this.cmbLoginInfo);
            this.pnlLoginInfo.Controls.Add(this.lblLoginInfo);
            this.pnlLoginInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(867, 37);
            this.pnlLoginInfo.TabIndex = 11;
            // 
            // cmbLoginInfo
            // 
            this.cmbLoginInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoginInfo.FormattingEnabled = true;
            this.cmbLoginInfo.Location = new System.Drawing.Point(124, 8);
            this.cmbLoginInfo.Name = "cmbLoginInfo";
            this.cmbLoginInfo.Size = new System.Drawing.Size(100, 20);
            this.cmbLoginInfo.TabIndex = 1;
            this.cmbLoginInfo.SelectedIndexChanged += new System.EventHandler(this.cmbLoginInfo_SelectedIndexChanged);
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Location = new System.Drawing.Point(20, 13);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(101, 12);
            this.lblLoginInfo.TabIndex = 0;
            this.lblLoginInfo.Text = "请选择查看页数：";
            // 
            // backgroundWorkerFormLoad
            // 
            this.backgroundWorkerFormLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFormLoad_DoWork);
            this.backgroundWorkerFormLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFormLoad_RunWorkerCompleted);
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // backgroundWorkerLogin
            // 
            this.backgroundWorkerLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLogin_DoWork);
            this.backgroundWorkerLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLogin_RunWorkerCompleted);
            // 
            // backgroundWorkerReLogin
            // 
            this.backgroundWorkerReLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReLogin_DoWork);
            this.backgroundWorkerReLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReLogin_RunWorkerCompleted);
            // 
            // FrmGDLoginInfo
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(881, 486);
            this.Controls.Add(this.tbcResult);
            this.Controls.Add(this.GrpSearch);
            this.Name = "FrmGDLoginInfo";
            this.Text = "用戶登陸資訊";
            this.Load += new System.EventHandler(this.FrmGDLoginInfo_Load);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.tbcResult.ResumeLayout(false);
            this.tpgCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).EndInit();
            this.tpgLoginInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdLoginInfo)).EndInit();
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TabControl tbcResult;
        private System.Windows.Forms.TabPage tpgCharacter;
        private System.Windows.Forms.DataGridView GrdCharacter;
        private System.Windows.Forms.TabPage tpgLoginInfo;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private System.Windows.Forms.ComboBox cmbLoginInfo;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFormLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReLogin;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.Label LblLink;
        private System.Windows.Forms.DateTimePicker DtpBegin;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.DataGridView GrdLoginInfo;
    }
}