namespace M_GD
{
    partial class FrmGDSystemMail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblLink = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.chbRecvOrSend = new System.Windows.Forms.CheckBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblServer = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.backgroundWorkerFormLoad = new System.ComponentModel.BackgroundWorker();
            this.TbcResult = new System.Windows.Forms.TabControl();
            this.TpgCharacter = new System.Windows.Forms.TabPage();
            this.GrdCharacter = new System.Windows.Forms.DataGridView();
            this.tpgSystemMail = new System.Windows.Forms.TabPage();
            this.GrdSystemMail = new System.Windows.Forms.DataGridView();
            this.pnlSystemMail = new System.Windows.Forms.Panel();
            this.cmbSystemMail = new System.Windows.Forms.ComboBox();
            this.lblGiftBase = new System.Windows.Forms.Label();
            this.backgroundWorkerSystemMail = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerReSystemMail = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.GrpSearch.SuspendLayout();
            this.TbcResult.SuspendLayout();
            this.TpgCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).BeginInit();
            this.tpgSystemMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSystemMail)).BeginInit();
            this.pnlSystemMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(177, 103);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(65, 12);
            this.LblLink.TabIndex = 23;
            this.LblLink.Text = "结束时间：";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(5, 103);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(65, 12);
            this.LblDate.TabIndex = 21;
            this.LblDate.Text = "开始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(351, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "提示：要查询邮件记录请双击其所在的单元行";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(469, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "壽敕";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(8, 32);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(155, 20);
            this.cmbServer.TabIndex = 8;
            // 
            // GrpSearch
            // 
            this.GrpSearch.Controls.Add(this.DtpBegin);
            this.GrpSearch.Controls.Add(this.DtpEnd);
            this.GrpSearch.Controls.Add(this.chbRecvOrSend);
            this.GrpSearch.Controls.Add(this.txtNick);
            this.GrpSearch.Controls.Add(this.label3);
            this.GrpSearch.Controls.Add(this.txtAccount);
            this.GrpSearch.Controls.Add(this.label1);
            this.GrpSearch.Controls.Add(this.LblLink);
            this.GrpSearch.Controls.Add(this.LblDate);
            this.GrpSearch.Controls.Add(this.label2);
            this.GrpSearch.Controls.Add(this.button1);
            this.GrpSearch.Controls.Add(this.cmbServer);
            this.GrpSearch.Controls.Add(this.LblServer);
            this.GrpSearch.Controls.Add(this.BtnSearch);
            this.GrpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpSearch.Location = new System.Drawing.Point(0, 0);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Size = new System.Drawing.Size(606, 148);
            this.GrpSearch.TabIndex = 8;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "搜索条件";
            // 
            // DtpBegin
            // 
            this.DtpBegin.CustomFormat = "yyyy-MM-dd";
            this.DtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpBegin.Location = new System.Drawing.Point(8, 119);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(155, 21);
            this.DtpBegin.TabIndex = 93;
            // 
            // DtpEnd
            // 
            this.DtpEnd.CustomFormat = "yyyy-MM-dd";
            this.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEnd.Location = new System.Drawing.Point(179, 121);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(145, 21);
            this.DtpEnd.TabIndex = 92;
            // 
            // chbRecvOrSend
            // 
            this.chbRecvOrSend.AutoSize = true;
            this.chbRecvOrSend.Location = new System.Drawing.Point(343, 29);
            this.chbRecvOrSend.Name = "chbRecvOrSend";
            this.chbRecvOrSend.Size = new System.Drawing.Size(120, 16);
            this.chbRecvOrSend.TabIndex = 91;
            this.chbRecvOrSend.Text = "按发送人进行查询";
            this.chbRecvOrSend.UseVisualStyleBackColor = true;
            this.chbRecvOrSend.CheckedChanged += new System.EventHandler(this.chbRecvOrSend_CheckedChanged);
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(179, 79);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(145, 21);
            this.txtNick.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "发送人昵称：";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(181, 32);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(143, 21);
            this.txtAccount.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "发送人帐号：";
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Location = new System.Drawing.Point(6, 17);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(77, 12);
            this.LblServer.TabIndex = 7;
            this.LblServer.Text = "游戏服务器：";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(469, 29);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(67, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "刲坰";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // backgroundWorkerFormLoad
            // 
            this.backgroundWorkerFormLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFormLoad_DoWork);
            this.backgroundWorkerFormLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFormLoad_RunWorkerCompleted);
            // 
            // TbcResult
            // 
            this.TbcResult.Controls.Add(this.TpgCharacter);
            this.TbcResult.Controls.Add(this.tpgSystemMail);
            this.TbcResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcResult.Location = new System.Drawing.Point(0, 148);
            this.TbcResult.Name = "TbcResult";
            this.TbcResult.SelectedIndex = 0;
            this.TbcResult.Size = new System.Drawing.Size(606, 313);
            this.TbcResult.TabIndex = 24;
            this.TbcResult.Selected += new System.Windows.Forms.TabControlEventHandler(this.TbcResult_Selected);
            // 
            // TpgCharacter
            // 
            this.TpgCharacter.Controls.Add(this.GrdCharacter);
            this.TpgCharacter.Location = new System.Drawing.Point(4, 21);
            this.TpgCharacter.Name = "TpgCharacter";
            this.TpgCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.TpgCharacter.Size = new System.Drawing.Size(598, 288);
            this.TpgCharacter.TabIndex = 0;
            this.TpgCharacter.Text = "角色信息";
            this.TpgCharacter.UseVisualStyleBackColor = true;
            // 
            // GrdCharacter
            // 
            this.GrdCharacter.AllowUserToAddRows = false;
            this.GrdCharacter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdCharacter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.GrdCharacter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdCharacter.DefaultCellStyle = dataGridViewCellStyle17;
            this.GrdCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCharacter.Location = new System.Drawing.Point(3, 3);
            this.GrdCharacter.Name = "GrdCharacter";
            this.GrdCharacter.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdCharacter.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.GrdCharacter.RowTemplate.Height = 23;
            this.GrdCharacter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCharacter.Size = new System.Drawing.Size(592, 282);
            this.GrdCharacter.TabIndex = 11;
            this.GrdCharacter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellDoubleClick);
            this.GrdCharacter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCharacter_CellClick);
            // 
            // tpgSystemMail
            // 
            this.tpgSystemMail.Controls.Add(this.GrdSystemMail);
            this.tpgSystemMail.Controls.Add(this.pnlSystemMail);
            this.tpgSystemMail.Location = new System.Drawing.Point(4, 21);
            this.tpgSystemMail.Name = "tpgSystemMail";
            this.tpgSystemMail.Size = new System.Drawing.Size(598, 288);
            this.tpgSystemMail.TabIndex = 1;
            this.tpgSystemMail.Text = "系统邮件";
            this.tpgSystemMail.UseVisualStyleBackColor = true;
            // 
            // GrdSystemMail
            // 
            this.GrdSystemMail.AllowUserToAddRows = false;
            this.GrdSystemMail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdSystemMail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GrdSystemMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdSystemMail.DefaultCellStyle = dataGridViewCellStyle14;
            this.GrdSystemMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSystemMail.Location = new System.Drawing.Point(0, 37);
            this.GrdSystemMail.Name = "GrdSystemMail";
            this.GrdSystemMail.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdSystemMail.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GrdSystemMail.RowTemplate.Height = 23;
            this.GrdSystemMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdSystemMail.Size = new System.Drawing.Size(598, 251);
            this.GrdSystemMail.TabIndex = 16;
            // 
            // pnlSystemMail
            // 
            this.pnlSystemMail.Controls.Add(this.cmbSystemMail);
            this.pnlSystemMail.Controls.Add(this.lblGiftBase);
            this.pnlSystemMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSystemMail.Location = new System.Drawing.Point(0, 0);
            this.pnlSystemMail.Name = "pnlSystemMail";
            this.pnlSystemMail.Size = new System.Drawing.Size(598, 37);
            this.pnlSystemMail.TabIndex = 14;
            // 
            // cmbSystemMail
            // 
            this.cmbSystemMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSystemMail.FormattingEnabled = true;
            this.cmbSystemMail.Location = new System.Drawing.Point(124, 8);
            this.cmbSystemMail.Name = "cmbSystemMail";
            this.cmbSystemMail.Size = new System.Drawing.Size(100, 20);
            this.cmbSystemMail.TabIndex = 1;
            this.cmbSystemMail.SelectedIndexChanged += new System.EventHandler(this.cmbSystemMail_SelectedIndexChanged);
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
            // backgroundWorkerSystemMail
            // 
            this.backgroundWorkerSystemMail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSystemMail_DoWork);
            this.backgroundWorkerSystemMail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSystemMail_RunWorkerCompleted);
            // 
            // backgroundWorkerReSystemMail
            // 
            this.backgroundWorkerReSystemMail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerReSystemMail_DoWork);
            this.backgroundWorkerReSystemMail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerReSystemMail_RunWorkerCompleted);
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // FrmGDSystemMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 461);
            this.Controls.Add(this.TbcResult);
            this.Controls.Add(this.GrpSearch);
            this.Name = "FrmGDSystemMail";
            this.Text = "系统邮件查询";
            this.Load += new System.EventHandler(this.FrmGDSystemMail_Load);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.TbcResult.ResumeLayout(false);
            this.TpgCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdCharacter)).EndInit();
            this.tpgSystemMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSystemMail)).EndInit();
            this.pnlSystemMail.ResumeLayout(false);
            this.pnlSystemMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblLink;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblServer;
        private System.Windows.Forms.Button BtnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFormLoad;
        private System.Windows.Forms.TabControl TbcResult;
        private System.Windows.Forms.TabPage TpgCharacter;
        private System.Windows.Forms.DataGridView GrdCharacter;
        private System.Windows.Forms.TabPage tpgSystemMail;
        private System.Windows.Forms.DataGridView GrdSystemMail;
        private System.Windows.Forms.Panel pnlSystemMail;
        private System.Windows.Forms.ComboBox cmbSystemMail;
        private System.Windows.Forms.Label lblGiftBase;
        private System.Windows.Forms.CheckBox chbRecvOrSend;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSystemMail;
        private System.ComponentModel.BackgroundWorker backgroundWorkerReSystemMail;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.DateTimePicker DtpBegin;
        private System.Windows.Forms.DateTimePicker DtpEnd;
    }
}