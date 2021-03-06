﻿namespace ANSIS_V3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UserAccountTile = new MetroFramework.Controls.MetroTile();
            this.StudentInfoTile = new MetroFramework.Controls.MetroTile();
            this.TeacherInformationTile = new MetroFramework.Controls.MetroTile();
            this.SectionTile = new MetroFramework.Controls.MetroTile();
            this.BooksTile = new MetroFramework.Controls.MetroTile();
            this.ReportsTile = new MetroFramework.Controls.MetroTile();
            this.InventoryTile = new MetroFramework.Controls.MetroTile();
            this.MonitoringTile = new MetroFramework.Controls.MetroTile();
            this.TransactionTile = new MetroFramework.Controls.MetroTile();
            this.InquiryTile = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cmbTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbColor = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserAccountTile
            // 
            this.UserAccountTile.ActiveControl = null;
            this.UserAccountTile.BackColor = System.Drawing.Color.White;
            this.UserAccountTile.Location = new System.Drawing.Point(69, 164);
            this.UserAccountTile.Name = "UserAccountTile";
            this.UserAccountTile.Size = new System.Drawing.Size(225, 190);
            this.UserAccountTile.TabIndex = 0;
            this.UserAccountTile.Text = "User Accounts";
            this.UserAccountTile.TileImage = ((System.Drawing.Image)(resources.GetObject("UserAccountTile.TileImage")));
            this.UserAccountTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserAccountTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UserAccountTile.UseSelectable = true;
            this.UserAccountTile.UseTileImage = true;
            this.UserAccountTile.Click += new System.EventHandler(this.UserAccountTile_Click);
            // 
            // StudentInfoTile
            // 
            this.StudentInfoTile.ActiveControl = null;
            this.StudentInfoTile.Location = new System.Drawing.Point(318, 164);
            this.StudentInfoTile.Name = "StudentInfoTile";
            this.StudentInfoTile.Size = new System.Drawing.Size(225, 190);
            this.StudentInfoTile.TabIndex = 1;
            this.StudentInfoTile.Text = "Student Information";
            this.StudentInfoTile.TileImage = ((System.Drawing.Image)(resources.GetObject("StudentInfoTile.TileImage")));
            this.StudentInfoTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StudentInfoTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.StudentInfoTile.UseSelectable = true;
            this.StudentInfoTile.UseTileImage = true;
            this.StudentInfoTile.Click += new System.EventHandler(this.StudentProfileTile_Click);
            // 
            // TeacherInformationTile
            // 
            this.TeacherInformationTile.ActiveControl = null;
            this.TeacherInformationTile.Location = new System.Drawing.Point(564, 164);
            this.TeacherInformationTile.Name = "TeacherInformationTile";
            this.TeacherInformationTile.Size = new System.Drawing.Size(225, 190);
            this.TeacherInformationTile.TabIndex = 2;
            this.TeacherInformationTile.Text = "Teacher Information";
            this.TeacherInformationTile.TileImage = ((System.Drawing.Image)(resources.GetObject("TeacherInformationTile.TileImage")));
            this.TeacherInformationTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TeacherInformationTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TeacherInformationTile.UseSelectable = true;
            this.TeacherInformationTile.UseTileImage = true;
            this.TeacherInformationTile.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // SectionTile
            // 
            this.SectionTile.ActiveControl = null;
            this.SectionTile.Location = new System.Drawing.Point(815, 164);
            this.SectionTile.Name = "SectionTile";
            this.SectionTile.Size = new System.Drawing.Size(225, 190);
            this.SectionTile.TabIndex = 3;
            this.SectionTile.Text = "Section";
            this.SectionTile.TileImage = ((System.Drawing.Image)(resources.GetObject("SectionTile.TileImage")));
            this.SectionTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SectionTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SectionTile.UseSelectable = true;
            this.SectionTile.UseTileImage = true;
            this.SectionTile.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // BooksTile
            // 
            this.BooksTile.ActiveControl = null;
            this.BooksTile.Location = new System.Drawing.Point(1059, 164);
            this.BooksTile.Name = "BooksTile";
            this.BooksTile.Size = new System.Drawing.Size(225, 190);
            this.BooksTile.TabIndex = 4;
            this.BooksTile.Text = "Books";
            this.BooksTile.TileImage = ((System.Drawing.Image)(resources.GetObject("BooksTile.TileImage")));
            this.BooksTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BooksTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BooksTile.UseSelectable = true;
            this.BooksTile.UseTileImage = true;
            this.BooksTile.Click += new System.EventHandler(this.BooksTile_Click);
            // 
            // ReportsTile
            // 
            this.ReportsTile.ActiveControl = null;
            this.ReportsTile.Location = new System.Drawing.Point(1059, 373);
            this.ReportsTile.Name = "ReportsTile";
            this.ReportsTile.Size = new System.Drawing.Size(225, 190);
            this.ReportsTile.TabIndex = 8;
            this.ReportsTile.Text = "Reports";
            this.ReportsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("ReportsTile.TileImage")));
            this.ReportsTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ReportsTile.UseSelectable = true;
            this.ReportsTile.UseTileImage = true;
            this.ReportsTile.Click += new System.EventHandler(this.ReportsTile_Click);
            // 
            // InventoryTile
            // 
            this.InventoryTile.ActiveControl = null;
            this.InventoryTile.Location = new System.Drawing.Point(815, 373);
            this.InventoryTile.Name = "InventoryTile";
            this.InventoryTile.Size = new System.Drawing.Size(225, 190);
            this.InventoryTile.TabIndex = 7;
            this.InventoryTile.Text = "Inventory";
            this.InventoryTile.TileImage = ((System.Drawing.Image)(resources.GetObject("InventoryTile.TileImage")));
            this.InventoryTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InventoryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.InventoryTile.UseSelectable = true;
            this.InventoryTile.UseTileImage = true;
            this.InventoryTile.Click += new System.EventHandler(this.InventoryTile_Click);
            // 
            // MonitoringTile
            // 
            this.MonitoringTile.ActiveControl = null;
            this.MonitoringTile.Location = new System.Drawing.Point(564, 373);
            this.MonitoringTile.Name = "MonitoringTile";
            this.MonitoringTile.Size = new System.Drawing.Size(225, 190);
            this.MonitoringTile.TabIndex = 6;
            this.MonitoringTile.Text = "Monitoring";
            this.MonitoringTile.TileImage = ((System.Drawing.Image)(resources.GetObject("MonitoringTile.TileImage")));
            this.MonitoringTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MonitoringTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MonitoringTile.UseSelectable = true;
            this.MonitoringTile.UseTileImage = true;
            this.MonitoringTile.Click += new System.EventHandler(this.MonitoringTile_Click);
            // 
            // TransactionTile
            // 
            this.TransactionTile.ActiveControl = null;
            this.TransactionTile.Location = new System.Drawing.Point(318, 373);
            this.TransactionTile.Name = "TransactionTile";
            this.TransactionTile.Size = new System.Drawing.Size(225, 190);
            this.TransactionTile.TabIndex = 5;
            this.TransactionTile.Text = "Transaction";
            this.TransactionTile.TileImage = ((System.Drawing.Image)(resources.GetObject("TransactionTile.TileImage")));
            this.TransactionTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TransactionTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TransactionTile.UseSelectable = true;
            this.TransactionTile.UseTileImage = true;
            this.TransactionTile.Click += new System.EventHandler(this.TransactionTile_Click);
            // 
            // InquiryTile
            // 
            this.InquiryTile.ActiveControl = null;
            this.InquiryTile.Location = new System.Drawing.Point(69, 373);
            this.InquiryTile.Name = "InquiryTile";
            this.InquiryTile.Size = new System.Drawing.Size(225, 190);
            this.InquiryTile.TabIndex = 10;
            this.InquiryTile.Text = "Inquiry";
            this.InquiryTile.TileImage = ((System.Drawing.Image)(resources.GetObject("InquiryTile.TileImage")));
            this.InquiryTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InquiryTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.InquiryTile.UseSelectable = true;
            this.InquiryTile.UseTileImage = true;
            this.InquiryTile.Click += new System.EventHandler(this.InquiryTile_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // cmbTheme
            // 
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.ItemHeight = 23;
            this.cmbTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.cmbTheme.Location = new System.Drawing.Point(127, 105);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(121, 29);
            this.cmbTheme.TabIndex = 11;
            this.cmbTheme.UseSelectable = true;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(71, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Theme :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(288, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Color :";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.ItemHeight = 23;
            this.cbColor.Items.AddRange(new object[] {
            "Default",
            "Black ",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange\t",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.cbColor.Location = new System.Drawing.Point(343, 105);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 29);
            this.cbColor.TabIndex = 13;
            this.cbColor.UseSelectable = true;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.InquiryTile);
            this.Controls.Add(this.ReportsTile);
            this.Controls.Add(this.InventoryTile);
            this.Controls.Add(this.MonitoringTile);
            this.Controls.Add(this.TransactionTile);
            this.Controls.Add(this.BooksTile);
            this.Controls.Add(this.SectionTile);
            this.Controls.Add(this.TeacherInformationTile);
            this.Controls.Add(this.StudentInfoTile);
            this.Controls.Add(this.UserAccountTile);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Student Information System of Abellana National High School";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private MetroFramework.Controls.MetroTile UserAccountTile;
		private MetroFramework.Controls.MetroTile StudentInfoTile;
		private MetroFramework.Controls.MetroTile TeacherInformationTile;
		private MetroFramework.Controls.MetroTile SectionTile;
        private MetroFramework.Controls.MetroTile BooksTile;
		private MetroFramework.Controls.MetroTile ReportsTile;
		private MetroFramework.Controls.MetroTile InventoryTile;
		private MetroFramework.Controls.MetroTile MonitoringTile;
		private MetroFramework.Controls.MetroTile TransactionTile;
        private MetroFramework.Controls.MetroTile InquiryTile;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox cmbTheme;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbColor;
	}
}