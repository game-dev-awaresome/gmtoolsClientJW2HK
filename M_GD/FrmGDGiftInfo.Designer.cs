namespace M_GD
{
    partial class FrmGDGiftInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.chbRecvOrSend = new System.Windows.Forms.CheckBox();
            this.DptStartTime = new System.Windows.Forms.DateTimePicker();
            this.DptEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
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
            this.tpgGiftBase = new System.Windows.Forms.TabPage();
            this.GrdGiftBase = new System.Windows.Forms.DataGridView();
            this.pnlGiftBase = new System.Windows.Forms.Panel();
            this.cmbGiftBase = new System.Windows.Forms.ComboBox();
            this.lblGiftBase = new System.Windows.Forms.Label();
            this.tpgGiftInfo = new System.Windows.Forms.TabPage();
            this.pnlGiftInfo = new System.Windows.Forms.Panel();
            this.cmbGiftInfo = new System.Windows.Forms.ComboBox();
            this.lblGiftInfo = new System.Windows.Forms.Label();
            this.GrdGiftInfo = new System.Windows.Forms.DataGridView();
            this.tpgRecvGift = new System.Windows.Forms.TabPage();
            this.GrdRecvGift = new System.Windows.Forms.DataGridView();
            this.pnlRecvGift = new System.Windows.Forms.Panel();
            this.cmbRecvGift = new System.Windows.Forms.ComboBox();
            this.lblRecvGift = new System.Windows.Forms.Label();
            this.backgroundWorkerFormLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerGiftInfo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReGiftInfo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerGiftBase = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReGiftBase = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerRecvGift = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReRecvGift = new System.ComponentModel.BackgroundWorker();
            this.GrpSearch.SuspendLayout();
            this.tbcResult.SuspendLayout();
            this.tpgCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).BeginInit();
            this.tpgGiftBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGiftBase)).BeginInit();
            this.pnlGiftBase.SuspendLayout();
            this.tpgGiftInfo.SuspendLayout();
            this.pnlGiftInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGiftInfo)).BeginInit();
            this.tpgRecvGift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecvGift)).BeginInit();
            this.pnlRecvGift.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.lblHint);
            this.GrpSearch.Controls.Add(this.chbRecvOrSend);
            this.GrpSearch.Controls.Add(this.DptStartTime);
            this.GrpSearch.Controls.Add(this.DptEndTime);
            this.GrpSearch.Controls.Add(this.lblStartTime);
            this.GrpSearch.Controls.Add(this.lblEndTime);
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
            this.GrpSearch.Size = new System.Drawing.Size(1065, 133);
            this.GrpSearch.TabIndex = 4;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "搜索條件";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(541, 101);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(485, 12);
            this.lblHint.TabIndex = 91;
            this.lblHint.Text = "提示:查詢到的禮物資訊有兩個小時的延遲,即距當前時間兩個小時之內的禮物資訊無法查詢";
            // 
            // chbRecvOrSend
            // 
            this.chbRecvOrSend.AutoSize = true;
            this.chbRecvOrSend.Location = new System.Drawing.Point(355, 28);
            this.chbRecvOrSend.Name = "chbRecvOrSend";
            this.chbRecvOrSend.Size = new System.Drawing.Size(120, 16);
            this.chbRecvOrSend.TabIndex = 90;
            this.chbRecvOrSend.Text = "按接受人進行查詢";
            this.chbRecvOrSend.UseVisualStyleBackColor = true;
            this.chbRecvOrSend.CheckedChanged += new System.EventHandler(this.chbRecvOrSend_CheckedChanged);
            // 
            // DptStartTime
            // 
            this.DptStartTime.CustomFormat = "yyyy-MM-dd";
            this.DptStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DptStartTime.Location = new System.Drawing.Point(418, 58);
            this.DptStartTime.Name = "DptStartTime";
            this.DptStartTime.Size = new System.Drawing.Size(100, 21);
            this.DptStartTime.TabIndex = 89;
            // 
            // DptEndTime
            // 
            this.DptEndTime.CustomFormat = "yyyy-MM-dd";
            this.DptEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DptEndTime.Location = new System.Drawing.Point(418, 90);
            this.DptEndTime.Name = "DptEndTime";
            this.DptEndTime.Size = new System.Drawing.Size(100, 21);
            this.DptEndTime.TabIndex = 88;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStartTime.Location = new System.Drawing.Point(353, 62);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 15);
            this.lblStartTime.TabIndex = 86;
            this.lblStartTime.Text = "開始時間:";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEndTime.Location = new System.Drawing.Point(353, 94);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(58, 15);
            this.lblEndTime.TabIndex = 87;
            this.lblEndTime.Text = "結束時間:";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(603, 59);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 25);
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
            this.lblNick.Location = new System.Drawing.Point(24, 95);
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
            this.lblAccount.Location = new System.Drawing.Point(24, 62);
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
            this.tbcResult.Controls.Add(this.tpgGiftBase);
            this.tbcResult.Controls.Add(this.tpgGiftInfo);
            this.tbcResult.Controls.Add(this.tpgRecvGift);
            this.tbcResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcResult.Location = new System.Drawing.Point(0, 133);
            this.tbcResult.Name = "tbcResult";
            this.tbcResult.SelectedIndex = 0;
            this.tbcResult.Size = new System.Drawing.Size(1065, 358);
            this.tbcResult.TabIndex = 5;
            this.tbcResult.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcResult_Selected);
            // 
            // tpgCharacter
            // 
            this.tpgCharacter.Controls.Add(this.GrdCharacter);
            this.tpgCharacter.Location = new System.Drawing.Point(4, 21);
            this.tpgCharacter.Name = "tpgCharacter";
            this.tpgCharacter.Size = new System.Drawing.Size(1057, 333);
            this.tpgCharacter.TabIndex = 7;
            this.tpgCharacter.Text = "玩家角色信息";
            this.tpgCharacter.UseVisualStyleBackColor = true;
            // 
            // GrdCharacter
            // 
            this.GrdCharacter.AllowUserToAddRows = false;
            this.GrdCharacter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdCharacter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdCharacter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdCharacter.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCharacter.Location = new System.Drawing.Point(0, 0);
            this.GrdCharacter.Name = "GrdCharacter";
            this.GrdCharacter.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdCharacter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdCharacter.RowTemplate.Height = 23;
            this.GrdCharacter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCharacter.Size = new System.Drawing.Size(1057, 333);
            this.GrdCharacter.TabIndex = 10;
            this.GrdCharacter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellDoubleClick);
            this.GrdCharacter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellClick);
            // 
            // tpgGiftBase
            // 
            this.tpgGiftBase.Controls.Add(this.GrdGiftBase);
            this.tpgGiftBase.Controls.Add(this.pnlGiftBase);
            this.tpgGiftBase.Location = new System.Drawing.Point(4, 21);
            this.tpgGiftBase.Name = "tpgGiftBase";
            this.tpgGiftBase.Size = new System.Drawing.Size(1057, 333);
            this.tpgGiftBase.TabIndex = 8;
            this.tpgGiftBase.Text = "禮物基本資訊";
            this.tpgGiftBase.UseVisualStyleBackColor = true;
            // 
            // GrdGiftBase
            // 
            this.GrdGiftBase.AllowUserToAddRows = false;
            this.GrdGiftBase.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdGiftBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GrdGiftBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdGiftBase.DefaultCellStyle = dataGridViewCellStyle5;
            this.GrdGiftBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdGiftBase.Location = new System.Drawing.Point(0, 37);
            this.GrdGiftBase.Name = "GrdGiftBase";
            this.GrdGiftBase.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdGiftBase.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GrdGiftBase.RowTemplate.Height = 23;
            this.GrdGiftBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdGiftBase.Size = new System.Drawing.Size(1057, 296);
            this.GrdGiftBase.TabIndex = 13;
            this.GrdGiftBase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdGiftBase_CellDoubleClick);
            this.GrdGiftBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdGiftBase_CellClick);
            // 
            // pnlGiftBase
            // 
            this.pnlGiftBase.Controls.Add(this.cmbGiftBase);
            this.pnlGiftBase.Controls.Add(this.lblGiftBase);
            this.pnlGiftBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGiftBase.Location = new System.Drawing.Point(0, 0);
            this.pnlGiftBase.Name = "pnlGiftBase";
            this.pnlGiftBase.Size = new System.Drawing.Size(1057, 37);
            this.pnlGiftBase.TabIndex = 12;
            // 
            // cmbGiftBase
            // 
            this.cmbGiftBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiftBase.FormattingEnabled = true;
            this.cmbGiftBase.Location = new System.Drawing.Point(124, 8);
            this.cmbGiftBase.Name = "cmbGiftBase";
            this.cmbGiftBase.Size = new System.Drawing.Size(100, 20);
            this.cmbGiftBase.TabIndex = 1;
            this.cmbGiftBase.SelectedIndexChanged += new System.EventHandler(this.cmbGiftBase_SelectedIndexChanged);
            // 
            // lblGiftBase
            // 
            this.lblGiftBase.AutoSize = true;
            this.lblGiftBase.Location = new System.Drawing.Point(20, 13);
            this.lblGiftBase.Name = "lblGiftBase";
            this.lblGiftBase.Size = new System.Drawing.Size(101, 12);
            this.lblGiftBase.TabIndex = 0;
            this.lblGiftBase.Text = "请选择查看页数：";
            // 
            // tpgGiftInfo
            // 
            this.tpgGiftInfo.Controls.Add(this.pnlGiftInfo);
            this.tpgGiftInfo.Controls.Add(this.GrdGiftInfo);
            this.tpgGiftInfo.Location = new System.Drawing.Point(4, 21);
            this.tpgGiftInfo.Name = "tpgGiftInfo";
            this.tpgGiftInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpgGiftInfo.Size = new System.Drawing.Size(1057, 333);
            this.tpgGiftInfo.TabIndex = 0;
            this.tpgGiftInfo.Text = "發送禮物詳細資訊";
            this.tpgGiftInfo.UseVisualStyleBackColor = true;
            // 
            // pnlGiftInfo
            // 
            this.pnlGiftInfo.Controls.Add(this.cmbGiftInfo);
            this.pnlGiftInfo.Controls.Add(this.lblGiftInfo);
            this.pnlGiftInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGiftInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlGiftInfo.Name = "pnlGiftInfo";
            this.pnlGiftInfo.Size = new System.Drawing.Size(1051, 37);
            this.pnlGiftInfo.TabIndex = 11;
            // 
            // cmbGiftInfo
            // 
            this.cmbGiftInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiftInfo.FormattingEnabled = true;
            this.cmbGiftInfo.Location = new System.Drawing.Point(124, 8);
            this.cmbGiftInfo.Name = "cmbGiftInfo";
            this.cmbGiftInfo.Size = new System.Drawing.Size(100, 20);
            this.cmbGiftInfo.TabIndex = 1;
            this.cmbGiftInfo.SelectedIndexChanged += new System.EventHandler(this.cmbGiftInfo_SelectedIndexChanged);
            // 
            // lblGiftInfo
            // 
            this.lblGiftInfo.AutoSize = true;
            this.lblGiftInfo.Location = new System.Drawing.Point(20, 13);
            this.lblGiftInfo.Name = "lblGiftInfo";
            this.lblGiftInfo.Size = new System.Drawing.Size(101, 12);
            this.lblGiftInfo.TabIndex = 0;
            this.lblGiftInfo.Text = "请选择查看页数：";
            // 
            // GrdGiftInfo
            // 
            this.GrdGiftInfo.AllowUserToAddRows = false;
            this.GrdGiftInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdGiftInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdGiftInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdGiftInfo.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdGiftInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdGiftInfo.Location = new System.Drawing.Point(3, 3);
            this.GrdGiftInfo.Name = "GrdGiftInfo";
            this.GrdGiftInfo.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdGiftInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdGiftInfo.RowTemplate.Height = 23;
            this.GrdGiftInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdGiftInfo.Size = new System.Drawing.Size(1051, 327);
            this.GrdGiftInfo.TabIndex = 9;
            this.GrdGiftInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdGiftInfo_CellDoubleClick);
            this.GrdGiftInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdGiftInfo_CellClick);
            // 
            // tpgRecvGift
            // 
            this.tpgRecvGift.Controls.Add(this.GrdRecvGift);
            this.tpgRecvGift.Controls.Add(this.pnlRecvGift);
            this.tpgRecvGift.Location = new System.Drawing.Point(4, 21);
            this.tpgRecvGift.Name = "tpgRecvGift";
            this.tpgRecvGift.Size = new System.Drawing.Size(1057, 333);
            this.tpgRecvGift.TabIndex = 9;
            this.tpgRecvGift.Text = "接受禮物詳細資訊";
            this.tpgRecvGift.UseVisualStyleBackColor = true;
            // 
            // GrdRecvGift
            // 
            this.GrdRecvGift.AllowUserToAddRows = false;
            this.GrdRecvGift.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRecvGift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GrdRecvGift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdRecvGift.DefaultCellStyle = dataGridViewCellStyle11;
            this.GrdRecvGift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdRecvGift.Location = new System.Drawing.Point(0, 37);
            this.GrdRecvGift.Name = "GrdRecvGift";
            this.GrdRecvGift.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdRecvGift.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GrdRecvGift.RowTemplate.Height = 23;
            this.GrdRecvGift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdRecvGift.Size = new System.Drawing.Size(1057, 296);
            this.GrdRecvGift.TabIndex = 13;
            // 
            // pnlRecvGift
            // 
            this.pnlRecvGift.Controls.Add(this.cmbRecvGift);
            this.pnlRecvGift.Controls.Add(this.lblRecvGift);
            this.pnlRecvGift.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecvGift.Location = new System.Drawing.Point(0, 0);
            this.pnlRecvGift.Name = "pnlRecvGift";
            this.pnlRecvGift.Size = new System.Drawing.Size(1057, 37);
            this.pnlRecvGift.TabIndex = 12;
            // 
            // cmbRecvGift
            // 
            this.cmbRecvGift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecvGift.FormattingEnabled = true;
            this.cmbRecvGift.Location = new System.Drawing.Point(124, 8);
            this.cmbRecvGift.Name = "cmbRecvGift";
            this.cmbRecvGift.Size = new System.Drawing.Size(100, 20);
            this.cmbRecvGift.TabIndex = 1;
            this.cmbRecvGift.SelectedIndexChanged += new System.EventHandler(this.cmbRecvGift_SelectedIndexChanged);
            // 
            // lblRecvGift
            // 
            this.lblRecvGift.AutoSize = true;
            this.lblRecvGift.Location = new System.Drawing.Point(20, 13);
            this.lblRecvGift.Name = "lblRecvGift";
            this.lblRecvGift.Size = new System.Drawing.Size(101, 12);
            this.lblRecvGift.TabIndex = 0;
            this.lblRecvGift.Text = "请选择查看页数：";
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
            // backgroundWorkerGiftInfo
            // 
            this.backgroundWorkerGiftInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGiftInfo_DoWork);
            this.backgroundWorkerGiftInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGiftInfo_RunWorkerCompleted);
            // 
            // backgroundWorkerReGiftInfo
            // 
            this.backgroundWorkerReGiftInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReGiftInfo_DoWork);
            this.backgroundWorkerReGiftInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReGiftInfo_RunWorkerCompleted);
            // 
            // backgroundWorkerGiftBase
            // 
            this.backgroundWorkerGiftBase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGiftBase_DoWork);
            this.backgroundWorkerGiftBase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGiftBase_RunWorkerCompleted);
            // 
            // backgroundWorkerReGiftBase
            // 
            this.backgroundWorkerReGiftBase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReGiftBase_DoWork);
            this.backgroundWorkerReGiftBase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReGiftBase_RunWorkerCompleted);
            // 
            // backgroundWorkerRecvGift
            // 
            this.backgroundWorkerRecvGift.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRecvGift_DoWork);
            this.backgroundWorkerRecvGift.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerRecvGift_RunWorkerCompleted);
            // 
            // backgroundWorkerReRecvGift
            // 
            this.backgroundWorkerReRecvGift.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReRecvGift_DoWork);
            this.backgroundWorkerReRecvGift.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReRecvGift_RunWorkerCompleted);
            // 
            // FrmGDGiftInfo
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1065, 491);
            this.Controls.Add(this.tbcResult);
            this.Controls.Add(this.GrpSearch);
            this.Name = "FrmGDGiftInfo";
            this.Text = "礼物信息";
            this.Load += new System.EventHandler(this.FrmGDGiftInfo_Load);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.tbcResult.ResumeLayout(false);
            this.tpgCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).EndInit();
            this.tpgGiftBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdGiftBase)).EndInit();
            this.pnlGiftBase.ResumeLayout(false);
            this.pnlGiftBase.PerformLayout();
            this.tpgGiftInfo.ResumeLayout(false);
            this.pnlGiftInfo.ResumeLayout(false);
            this.pnlGiftInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGiftInfo)).EndInit();
            this.tpgRecvGift.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdRecvGift)).EndInit();
            this.pnlRecvGift.ResumeLayout(false);
            this.pnlRecvGift.PerformLayout();
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
        private System.Windows.Forms.TabPage tpgGiftInfo;
        private System.Windows.Forms.DataGridView GrdGiftInfo;
        private System.Windows.Forms.DateTimePicker DptStartTime;
        private System.Windows.Forms.DateTimePicker DptEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFormLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGiftInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReGiftInfo;
        private System.Windows.Forms.CheckBox chbRecvOrSend;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TabPage tpgGiftBase;
        private System.Windows.Forms.Panel pnlGiftBase;
        private System.Windows.Forms.ComboBox cmbGiftBase;
        private System.Windows.Forms.Label lblGiftBase;
        private System.Windows.Forms.DataGridView GrdGiftBase;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGiftBase;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReGiftBase;
        private System.Windows.Forms.Panel pnlGiftInfo;
        private System.Windows.Forms.ComboBox cmbGiftInfo;
        private System.Windows.Forms.Label lblGiftInfo;
        private System.Windows.Forms.TabPage tpgRecvGift;
        private System.Windows.Forms.Panel pnlRecvGift;
        private System.Windows.Forms.ComboBox cmbRecvGift;
        private System.Windows.Forms.Label lblRecvGift;
        private System.Windows.Forms.DataGridView GrdRecvGift;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRecvGift;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReRecvGift;
    }
}