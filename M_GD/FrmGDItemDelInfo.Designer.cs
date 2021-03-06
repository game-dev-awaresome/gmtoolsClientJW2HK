namespace M_GD
{
    partial class FrmGDItemDelInfo
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.LblLink = new System.Windows.Forms.Label();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.LblAccount = new System.Windows.Forms.Label();
            this.CmbServer = new System.Windows.Forms.ComboBox();
            this.LblServer = new System.Windows.Forms.Label();
            this.GrpResult = new System.Windows.Forms.GroupBox();
            this.tbcResult = new System.Windows.Forms.TabControl();
            this.tpgCharacter = new System.Windows.Forms.TabPage();
            this.GrdCharacter = new System.Windows.Forms.DataGridView();
            this.TpgNonLoanToRentBody = new System.Windows.Forms.TabPage();
            this.GrdNonLoanToRentBody = new System.Windows.Forms.DataGridView();
            this.PnlNonLoanToRentBody = new System.Windows.Forms.Panel();
            this.LblPage = new System.Windows.Forms.Label();
            this.CmbNonLoanToRentBody = new System.Windows.Forms.ComboBox();
            this.TpgShopPurchaseBody = new System.Windows.Forms.TabPage();
            this.GrdShopPurchaseBody = new System.Windows.Forms.DataGridView();
            this.pnlShopPurchaseBody = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbShopPurchaseBody = new System.Windows.Forms.ComboBox();
            this.TpgSynthesisDrawings = new System.Windows.Forms.TabPage();
            this.GrdSynthesisDrawings = new System.Windows.Forms.DataGridView();
            this.pnlSynthesisDrawings = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbSynthesisDrawings = new System.Windows.Forms.ComboBox();
            this.TpgAdjutant = new System.Windows.Forms.TabPage();
            this.GrdAdjutant = new System.Windows.Forms.DataGridView();
            this.pnlAdjutant = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbAdjutant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerFormLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerNonLoanToRentBodyQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerShopPurchaseBodyQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSynthesisDrawingsQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerFightConsumerQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerAdjutantQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReNonLoanToRentBodyQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReShopPurchaseBodyQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReSynthesisDrawingsQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReFightConsumerQuery = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReAdjutantQuery = new System.ComponentModel.BackgroundWorker();
            this.GrpSearch.SuspendLayout();
            this.GrpResult.SuspendLayout();
            this.tbcResult.SuspendLayout();
            this.tpgCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).BeginInit();
            this.TpgNonLoanToRentBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdNonLoanToRentBody)).BeginInit();
            this.PnlNonLoanToRentBody.SuspendLayout();
            this.TpgShopPurchaseBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdShopPurchaseBody)).BeginInit();
            this.pnlShopPurchaseBody.SuspendLayout();
            this.TpgSynthesisDrawings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSynthesisDrawings)).BeginInit();
            this.pnlSynthesisDrawings.SuspendLayout();
            this.TpgAdjutant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjutant)).BeginInit();
            this.pnlAdjutant.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.Location = new System.Drawing.Point(434, 60);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(72, 23);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = true;
            this.BtnSearch.Location = new System.Drawing.Point(434, 31);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(72, 23);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TxtAccount
            // 
            this.TxtAccount.Location = new System.Drawing.Point(10, 78);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(188, 21);
            this.TxtAccount.TabIndex = 4;
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.label6);
            this.GrpSearch.Controls.Add(this.label5);
            this.GrpSearch.Controls.Add(this.DtpEnd);
            this.GrpSearch.Controls.Add(this.LblLink);
            this.GrpSearch.Controls.Add(this.DtpBegin);
            this.GrpSearch.Controls.Add(this.LblDate);
            this.GrpSearch.Controls.Add(this.txtNick);
            this.GrpSearch.Controls.Add(this.lblNick);
            this.GrpSearch.Controls.Add(this.lblHint);
            this.GrpSearch.Controls.Add(this.BtnClose);
            this.GrpSearch.Controls.Add(this.BtnSearch);
            this.GrpSearch.Controls.Add(this.TxtAccount);
            this.GrpSearch.Controls.Add(this.LblAccount);
            this.GrpSearch.Controls.Add(this.CmbServer);
            this.GrpSearch.Controls.Add(this.LblServer);
            this.GrpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpSearch.Location = new System.Drawing.Point(0, 0);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(866, 164);
            this.GrpSearch.TabIndex = 10;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "搜索條件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 103;
            this.label6.Text = "遊戲伺服器：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(237, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "“數量或使用期限”欄位在“租賃機體”和“副官”中是“天”數，在“合成圖紙”和“非租賃機體”中是“個”數";
            // 
            // DtpEnd
            // 
            this.DtpEnd.CustomFormat = "yyyy-MM-dd";
            this.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEnd.Location = new System.Drawing.Point(224, 79);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(188, 21);
            this.DtpEnd.TabIndex = 101;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(233, 64);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(65, 12);
            this.LblLink.TabIndex = 100;
            this.LblLink.Text = "結束時間：";
            // 
            // DtpBegin
            // 
            this.DtpBegin.CustomFormat = "yyyy-MM-dd";
            this.DtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpBegin.Location = new System.Drawing.Point(224, 33);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(188, 21);
            this.DtpBegin.TabIndex = 99;
            this.DtpBegin.ValueChanged += new System.EventHandler(this.DtpBegin_ValueChanged);
            this.DtpBegin.Leave += new System.EventHandler(this.DtpBegin_Leave);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(233, 17);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(65, 12);
            this.LblDate.TabIndex = 98;
            this.LblDate.Text = "開始時間：";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(10, 127);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(187, 21);
            this.txtNick.TabIndex = 94;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(12, 112);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(65, 12);
            this.lblNick.TabIndex = 93;
            this.lblNick.Text = "玩家昵稱：";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.Red;
            this.lblHint.Location = new System.Drawing.Point(204, 112);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(545, 12);
            this.lblHint.TabIndex = 92;
            this.lblHint.Text = "提示：查詢到的道具刪除資訊有兩個小時的延時，即距當前時間兩個小時之內的道具刪除資訊無法查詢";
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Location = new System.Drawing.Point(8, 64);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(65, 12);
            this.LblAccount.TabIndex = 3;
            this.LblAccount.Text = "玩家帳號：";
            // 
            // CmbServer
            // 
            this.CmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbServer.FormattingEnabled = true;
            this.CmbServer.Location = new System.Drawing.Point(10, 31);
            this.CmbServer.Name = "CmbServer";
            this.CmbServer.Size = new System.Drawing.Size(188, 20);
            this.CmbServer.TabIndex = 2;
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Location = new System.Drawing.Point(8, 16);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(0, 12);
            this.LblServer.TabIndex = 1;
            // 
            // GrpResult
            // 
            this.GrpResult.Controls.Add(this.tbcResult);
            this.GrpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpResult.Location = new System.Drawing.Point(0, 164);
            this.GrpResult.Name = "GrpResult";
            this.GrpResult.Size = new System.Drawing.Size(866, 325);
            this.GrpResult.TabIndex = 17;
            this.GrpResult.TabStop = false;
            this.GrpResult.Text = "道具刪除資料";
            // 
            // tbcResult
            // 
            this.tbcResult.Controls.Add(this.tpgCharacter);
            this.tbcResult.Controls.Add(this.TpgNonLoanToRentBody);
            this.tbcResult.Controls.Add(this.TpgShopPurchaseBody);
            this.tbcResult.Controls.Add(this.TpgSynthesisDrawings);
            this.tbcResult.Controls.Add(this.TpgAdjutant);
            this.tbcResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcResult.Location = new System.Drawing.Point(3, 17);
            this.tbcResult.Name = "tbcResult";
            this.tbcResult.SelectedIndex = 0;
            this.tbcResult.Size = new System.Drawing.Size(860, 305);
            this.tbcResult.TabIndex = 4;
            this.tbcResult.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcResult_Selected);
            // 
            // tpgCharacter
            // 
            this.tpgCharacter.Controls.Add(this.GrdCharacter);
            this.tpgCharacter.Location = new System.Drawing.Point(4, 21);
            this.tpgCharacter.Name = "tpgCharacter";
            this.tpgCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCharacter.Size = new System.Drawing.Size(852, 280);
            this.tpgCharacter.TabIndex = 0;
            this.tpgCharacter.Text = "角色信息";
            this.tpgCharacter.UseVisualStyleBackColor = true;
            // 
            // GrdCharacter
            // 
            this.GrdCharacter.AllowUserToAddRows = false;
            this.GrdCharacter.AllowUserToDeleteRows = false;
            this.GrdCharacter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCharacter.Location = new System.Drawing.Point(3, 3);
            this.GrdCharacter.Name = "GrdCharacter";
            this.GrdCharacter.ReadOnly = true;
            this.GrdCharacter.RowTemplate.Height = 23;
            this.GrdCharacter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCharacter.Size = new System.Drawing.Size(846, 274);
            this.GrdCharacter.TabIndex = 9;
            this.GrdCharacter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellDoubleClick);
            this.GrdCharacter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellClick);
            // 
            // TpgNonLoanToRentBody
            // 
            this.TpgNonLoanToRentBody.Controls.Add(this.GrdNonLoanToRentBody);
            this.TpgNonLoanToRentBody.Controls.Add(this.PnlNonLoanToRentBody);
            this.TpgNonLoanToRentBody.Location = new System.Drawing.Point(4, 21);
            this.TpgNonLoanToRentBody.Name = "TpgNonLoanToRentBody";
            this.TpgNonLoanToRentBody.Padding = new System.Windows.Forms.Padding(3);
            this.TpgNonLoanToRentBody.Size = new System.Drawing.Size(852, 280);
            this.TpgNonLoanToRentBody.TabIndex = 1;
            this.TpgNonLoanToRentBody.Text = "非租賃機體";
            this.TpgNonLoanToRentBody.UseVisualStyleBackColor = true;
            // 
            // GrdNonLoanToRentBody
            // 
            this.GrdNonLoanToRentBody.AllowUserToAddRows = false;
            this.GrdNonLoanToRentBody.AllowUserToDeleteRows = false;
            this.GrdNonLoanToRentBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdNonLoanToRentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdNonLoanToRentBody.Location = new System.Drawing.Point(3, 34);
            this.GrdNonLoanToRentBody.Name = "GrdNonLoanToRentBody";
            this.GrdNonLoanToRentBody.ReadOnly = true;
            this.GrdNonLoanToRentBody.RowTemplate.Height = 23;
            this.GrdNonLoanToRentBody.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdNonLoanToRentBody.Size = new System.Drawing.Size(846, 243);
            this.GrdNonLoanToRentBody.TabIndex = 13;
            // 
            // PnlNonLoanToRentBody
            // 
            this.PnlNonLoanToRentBody.Controls.Add(this.LblPage);
            this.PnlNonLoanToRentBody.Controls.Add(this.CmbNonLoanToRentBody);
            this.PnlNonLoanToRentBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNonLoanToRentBody.Location = new System.Drawing.Point(3, 3);
            this.PnlNonLoanToRentBody.Name = "PnlNonLoanToRentBody";
            this.PnlNonLoanToRentBody.Size = new System.Drawing.Size(846, 31);
            this.PnlNonLoanToRentBody.TabIndex = 11;
            this.PnlNonLoanToRentBody.TabStop = true;
            // 
            // LblPage
            // 
            this.LblPage.AutoSize = true;
            this.LblPage.Location = new System.Drawing.Point(5, 11);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(101, 12);
            this.LblPage.TabIndex = 1;
            this.LblPage.Text = "请选择查看页数：";
            // 
            // CmbNonLoanToRentBody
            // 
            this.CmbNonLoanToRentBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNonLoanToRentBody.FormattingEnabled = true;
            this.CmbNonLoanToRentBody.Location = new System.Drawing.Point(112, 7);
            this.CmbNonLoanToRentBody.Name = "CmbNonLoanToRentBody";
            this.CmbNonLoanToRentBody.Size = new System.Drawing.Size(121, 20);
            this.CmbNonLoanToRentBody.TabIndex = 0;
            this.CmbNonLoanToRentBody.SelectedIndexChanged += new System.EventHandler(this.CmbPage_SelectedIndexChanged);
            // 
            // TpgShopPurchaseBody
            // 
            this.TpgShopPurchaseBody.Controls.Add(this.GrdShopPurchaseBody);
            this.TpgShopPurchaseBody.Controls.Add(this.pnlShopPurchaseBody);
            this.TpgShopPurchaseBody.Location = new System.Drawing.Point(4, 21);
            this.TpgShopPurchaseBody.Name = "TpgShopPurchaseBody";
            this.TpgShopPurchaseBody.Size = new System.Drawing.Size(852, 280);
            this.TpgShopPurchaseBody.TabIndex = 2;
            this.TpgShopPurchaseBody.Text = "商店購買機體";
            this.TpgShopPurchaseBody.UseVisualStyleBackColor = true;
            // 
            // GrdShopPurchaseBody
            // 
            this.GrdShopPurchaseBody.AllowUserToAddRows = false;
            this.GrdShopPurchaseBody.AllowUserToDeleteRows = false;
            this.GrdShopPurchaseBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdShopPurchaseBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdShopPurchaseBody.Location = new System.Drawing.Point(0, 31);
            this.GrdShopPurchaseBody.Name = "GrdShopPurchaseBody";
            this.GrdShopPurchaseBody.ReadOnly = true;
            this.GrdShopPurchaseBody.RowTemplate.Height = 23;
            this.GrdShopPurchaseBody.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdShopPurchaseBody.Size = new System.Drawing.Size(852, 249);
            this.GrdShopPurchaseBody.TabIndex = 16;
            // 
            // pnlShopPurchaseBody
            // 
            this.pnlShopPurchaseBody.Controls.Add(this.label1);
            this.pnlShopPurchaseBody.Controls.Add(this.CmbShopPurchaseBody);
            this.pnlShopPurchaseBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShopPurchaseBody.Location = new System.Drawing.Point(0, 0);
            this.pnlShopPurchaseBody.Name = "pnlShopPurchaseBody";
            this.pnlShopPurchaseBody.Size = new System.Drawing.Size(852, 31);
            this.pnlShopPurchaseBody.TabIndex = 14;
            this.pnlShopPurchaseBody.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择查看页数：";
            // 
            // CmbShopPurchaseBody
            // 
            this.CmbShopPurchaseBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbShopPurchaseBody.FormattingEnabled = true;
            this.CmbShopPurchaseBody.Location = new System.Drawing.Point(112, 7);
            this.CmbShopPurchaseBody.Name = "CmbShopPurchaseBody";
            this.CmbShopPurchaseBody.Size = new System.Drawing.Size(121, 20);
            this.CmbShopPurchaseBody.TabIndex = 0;
            this.CmbShopPurchaseBody.SelectedIndexChanged += new System.EventHandler(this.CmbShopPurchaseBody_SelectedIndexChanged);
            // 
            // TpgSynthesisDrawings
            // 
            this.TpgSynthesisDrawings.Controls.Add(this.GrdSynthesisDrawings);
            this.TpgSynthesisDrawings.Controls.Add(this.pnlSynthesisDrawings);
            this.TpgSynthesisDrawings.Location = new System.Drawing.Point(4, 21);
            this.TpgSynthesisDrawings.Name = "TpgSynthesisDrawings";
            this.TpgSynthesisDrawings.Size = new System.Drawing.Size(852, 280);
            this.TpgSynthesisDrawings.TabIndex = 3;
            this.TpgSynthesisDrawings.Text = "合成圖紙";
            this.TpgSynthesisDrawings.UseVisualStyleBackColor = true;
            // 
            // GrdSynthesisDrawings
            // 
            this.GrdSynthesisDrawings.AllowUserToAddRows = false;
            this.GrdSynthesisDrawings.AllowUserToDeleteRows = false;
            this.GrdSynthesisDrawings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSynthesisDrawings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSynthesisDrawings.Location = new System.Drawing.Point(0, 31);
            this.GrdSynthesisDrawings.Name = "GrdSynthesisDrawings";
            this.GrdSynthesisDrawings.ReadOnly = true;
            this.GrdSynthesisDrawings.RowTemplate.Height = 23;
            this.GrdSynthesisDrawings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdSynthesisDrawings.Size = new System.Drawing.Size(852, 249);
            this.GrdSynthesisDrawings.TabIndex = 16;
            // 
            // pnlSynthesisDrawings
            // 
            this.pnlSynthesisDrawings.Controls.Add(this.label3);
            this.pnlSynthesisDrawings.Controls.Add(this.CmbSynthesisDrawings);
            this.pnlSynthesisDrawings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSynthesisDrawings.Location = new System.Drawing.Point(0, 0);
            this.pnlSynthesisDrawings.Name = "pnlSynthesisDrawings";
            this.pnlSynthesisDrawings.Size = new System.Drawing.Size(852, 31);
            this.pnlSynthesisDrawings.TabIndex = 14;
            this.pnlSynthesisDrawings.TabStop = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "请选择查看页数：";
            // 
            // CmbSynthesisDrawings
            // 
            this.CmbSynthesisDrawings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSynthesisDrawings.FormattingEnabled = true;
            this.CmbSynthesisDrawings.Location = new System.Drawing.Point(112, 7);
            this.CmbSynthesisDrawings.Name = "CmbSynthesisDrawings";
            this.CmbSynthesisDrawings.Size = new System.Drawing.Size(121, 20);
            this.CmbSynthesisDrawings.TabIndex = 0;
            this.CmbSynthesisDrawings.SelectedIndexChanged += new System.EventHandler(this.CmbSynthesisDrawings_SelectedIndexChanged);
            // 
            // TpgAdjutant
            // 
            this.TpgAdjutant.Controls.Add(this.GrdAdjutant);
            this.TpgAdjutant.Controls.Add(this.pnlAdjutant);
            this.TpgAdjutant.Location = new System.Drawing.Point(4, 21);
            this.TpgAdjutant.Name = "TpgAdjutant";
            this.TpgAdjutant.Size = new System.Drawing.Size(852, 280);
            this.TpgAdjutant.TabIndex = 4;
            this.TpgAdjutant.Text = "副官";
            this.TpgAdjutant.UseVisualStyleBackColor = true;
            // 
            // GrdAdjutant
            // 
            this.GrdAdjutant.AllowUserToAddRows = false;
            this.GrdAdjutant.AllowUserToDeleteRows = false;
            this.GrdAdjutant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAdjutant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAdjutant.Location = new System.Drawing.Point(0, 31);
            this.GrdAdjutant.Name = "GrdAdjutant";
            this.GrdAdjutant.ReadOnly = true;
            this.GrdAdjutant.RowTemplate.Height = 23;
            this.GrdAdjutant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdAdjutant.Size = new System.Drawing.Size(852, 249);
            this.GrdAdjutant.TabIndex = 16;
            // 
            // pnlAdjutant
            // 
            this.pnlAdjutant.Controls.Add(this.label4);
            this.pnlAdjutant.Controls.Add(this.CmbAdjutant);
            this.pnlAdjutant.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdjutant.Location = new System.Drawing.Point(0, 0);
            this.pnlAdjutant.Name = "pnlAdjutant";
            this.pnlAdjutant.Size = new System.Drawing.Size(852, 31);
            this.pnlAdjutant.TabIndex = 14;
            this.pnlAdjutant.TabStop = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "请选择查看页数：";
            // 
            // CmbAdjutant
            // 
            this.CmbAdjutant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAdjutant.FormattingEnabled = true;
            this.CmbAdjutant.Location = new System.Drawing.Point(112, 7);
            this.CmbAdjutant.Name = "CmbAdjutant";
            this.CmbAdjutant.Size = new System.Drawing.Size(121, 20);
            this.CmbAdjutant.TabIndex = 0;
            this.CmbAdjutant.SelectedIndexChanged += new System.EventHandler(this.CmbAdjutant_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "恁寁脤艘珜杅ㄩ";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(112, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 0;
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
            // backgroundWorkerNonLoanToRentBodyQuery
            // 
            this.backgroundWorkerNonLoanToRentBodyQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerNonLoanToRentBodyQuery_DoWork);
            this.backgroundWorkerNonLoanToRentBodyQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerNonLoanToRentBodyQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerShopPurchaseBodyQuery
            // 
            this.backgroundWorkerShopPurchaseBodyQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerShopPurchaseBodyQuery_DoWork);
            this.backgroundWorkerShopPurchaseBodyQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerShopPurchaseBodyQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerSynthesisDrawingsQuery
            // 
            this.backgroundWorkerSynthesisDrawingsQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSynthesisDrawingsQuery_DoWork);
            this.backgroundWorkerSynthesisDrawingsQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSynthesisDrawingsQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerFightConsumerQuery
            // 
            this.backgroundWorkerFightConsumerQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFightConsumerQuery_DoWork);
            this.backgroundWorkerFightConsumerQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFightConsumerQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerAdjutantQuery
            // 
            this.backgroundWorkerAdjutantQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAdjutantQuery_DoWork);
            this.backgroundWorkerAdjutantQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAdjutantQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerReNonLoanToRentBodyQuery
            // 
            this.backgroundWorkerReNonLoanToRentBodyQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReNonLoanToRentBodyQuery_DoWork);
            this.backgroundWorkerReNonLoanToRentBodyQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReNonLoanToRentBodyQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerReShopPurchaseBodyQuery
            // 
            this.backgroundWorkerReShopPurchaseBodyQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReShopPurchaseBodyQuery_DoWork);
            this.backgroundWorkerReShopPurchaseBodyQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReShopPurchaseBodyQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerReSynthesisDrawingsQuery
            // 
            this.backgroundWorkerReSynthesisDrawingsQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReSynthesisDrawingsQuery_DoWork);
            this.backgroundWorkerReSynthesisDrawingsQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReSynthesisDrawingsQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerReFightConsumerQuery
            // 
            this.backgroundWorkerReFightConsumerQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReFightConsumerQuery_DoWork);
            this.backgroundWorkerReFightConsumerQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReFightConsumerQuery_RunWorkerCompleted);
            // 
            // backgroundWorkerReAdjutantQuery
            // 
            this.backgroundWorkerReAdjutantQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReAdjutantQuery_DoWork);
            this.backgroundWorkerReAdjutantQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReAdjutantQuery_RunWorkerCompleted);
            // 
            // FrmGDItemDelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 489);
            this.Controls.Add(this.GrpResult);
            this.Controls.Add(this.GrpSearch);
            this.Name = "FrmGDItemDelInfo";
            this.Text = "道具刪除查詢";
            this.Load += new System.EventHandler(this.FrmGDItemDelInfo_Load);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.GrpResult.ResumeLayout(false);
            this.tbcResult.ResumeLayout(false);
            this.tpgCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).EndInit();
            this.TpgNonLoanToRentBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdNonLoanToRentBody)).EndInit();
            this.PnlNonLoanToRentBody.ResumeLayout(false);
            this.PnlNonLoanToRentBody.PerformLayout();
            this.TpgShopPurchaseBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdShopPurchaseBody)).EndInit();
            this.pnlShopPurchaseBody.ResumeLayout(false);
            this.pnlShopPurchaseBody.PerformLayout();
            this.TpgSynthesisDrawings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSynthesisDrawings)).EndInit();
            this.pnlSynthesisDrawings.ResumeLayout(false);
            this.pnlSynthesisDrawings.PerformLayout();
            this.TpgAdjutant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdAdjutant)).EndInit();
            this.pnlAdjutant.ResumeLayout(false);
            this.pnlAdjutant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.Label LblAccount;
        private System.Windows.Forms.ComboBox CmbServer;
        private System.Windows.Forms.Label LblServer;
        private System.Windows.Forms.GroupBox GrpResult;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFormLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.Label LblLink;
        private System.Windows.Forms.DateTimePicker DtpBegin;
        private System.Windows.Forms.Label LblDate;
        private System.ComponentModel.BackgroundWorker backgroundWorkerNonLoanToRentBodyQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerShopPurchaseBodyQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSynthesisDrawingsQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFightConsumerQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAdjutantQuery;
        private System.Windows.Forms.TabControl tbcResult;
        private System.Windows.Forms.TabPage tpgCharacter;
        private System.Windows.Forms.DataGridView GrdCharacter;
        private System.Windows.Forms.TabPage TpgNonLoanToRentBody;
        private System.Windows.Forms.DataGridView GrdNonLoanToRentBody;
        private System.Windows.Forms.Panel PnlNonLoanToRentBody;
        private System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.ComboBox CmbNonLoanToRentBody;
        private System.Windows.Forms.TabPage TpgShopPurchaseBody;
        private System.Windows.Forms.DataGridView GrdShopPurchaseBody;
        private System.Windows.Forms.Panel pnlShopPurchaseBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbShopPurchaseBody;
        private System.Windows.Forms.TabPage TpgSynthesisDrawings;
        private System.Windows.Forms.DataGridView GrdSynthesisDrawings;
        private System.Windows.Forms.Panel pnlSynthesisDrawings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSynthesisDrawings;
        private System.Windows.Forms.TabPage TpgAdjutant;
        private System.Windows.Forms.DataGridView GrdAdjutant;
        private System.Windows.Forms.Panel pnlAdjutant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbAdjutant;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReNonLoanToRentBodyQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReShopPurchaseBodyQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReSynthesisDrawingsQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReFightConsumerQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReAdjutantQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}