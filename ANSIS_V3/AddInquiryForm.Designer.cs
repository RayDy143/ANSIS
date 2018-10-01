namespace ANSIS_V3
{
    partial class AddInquiryForm
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
            this.mcmbInquiryType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.mtxtcapacity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.mtxtInqDescrip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.mtxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.mdgvAddSection = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvAddSection)).BeginInit();
            this.SuspendLayout();
            // 
            // mcmbInquiryType
            // 
            this.mcmbInquiryType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mcmbInquiryType.FormattingEnabled = true;
            this.mcmbInquiryType.ItemHeight = 19;
            this.mcmbInquiryType.Items.AddRange(new object[] {
            "Reminders",
            "Announcement & Events"});
            this.mcmbInquiryType.Location = new System.Drawing.Point(133, 78);
            this.mcmbInquiryType.Name = "mcmbInquiryType";
            this.mcmbInquiryType.Size = new System.Drawing.Size(244, 25);
            this.mcmbInquiryType.TabIndex = 47;
            this.mcmbInquiryType.UseSelectable = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel27.Location = new System.Drawing.Point(40, 78);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(87, 19);
            this.metroLabel27.TabIndex = 46;
            this.metroLabel27.Text = "Inquiry Type :";
            // 
            // mtxtcapacity
            // 
            // 
            // 
            // 
            this.mtxtcapacity.CustomButton.Image = null;
            this.mtxtcapacity.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.mtxtcapacity.CustomButton.Name = "";
            this.mtxtcapacity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtcapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtcapacity.CustomButton.TabIndex = 1;
            this.mtxtcapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtcapacity.CustomButton.UseSelectable = true;
            this.mtxtcapacity.CustomButton.Visible = false;
            this.mtxtcapacity.Lines = new string[0];
            this.mtxtcapacity.Location = new System.Drawing.Point(133, 220);
            this.mtxtcapacity.MaxLength = 32767;
            this.mtxtcapacity.Name = "mtxtcapacity";
            this.mtxtcapacity.PasswordChar = '\0';
            this.mtxtcapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtcapacity.SelectedText = "";
            this.mtxtcapacity.SelectionLength = 0;
            this.mtxtcapacity.SelectionStart = 0;
            this.mtxtcapacity.ShortcutsEnabled = true;
            this.mtxtcapacity.Size = new System.Drawing.Size(244, 23);
            this.mtxtcapacity.TabIndex = 45;
            this.mtxtcapacity.UseSelectable = true;
            this.mtxtcapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtcapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(18, 220);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(81, 19);
            this.metroLabel25.TabIndex = 44;
            this.metroLabel25.Text = "Created By :";
            // 
            // mtxtInqDescrip
            // 
            // 
            // 
            // 
            this.mtxtInqDescrip.CustomButton.Image = null;
            this.mtxtInqDescrip.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.mtxtInqDescrip.CustomButton.Name = "";
            this.mtxtInqDescrip.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.mtxtInqDescrip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtInqDescrip.CustomButton.TabIndex = 1;
            this.mtxtInqDescrip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtInqDescrip.CustomButton.UseSelectable = true;
            this.mtxtInqDescrip.CustomButton.Visible = false;
            this.mtxtInqDescrip.Lines = new string[0];
            this.mtxtInqDescrip.Location = new System.Drawing.Point(133, 109);
            this.mtxtInqDescrip.MaxLength = 32767;
            this.mtxtInqDescrip.Multiline = true;
            this.mtxtInqDescrip.Name = "mtxtInqDescrip";
            this.mtxtInqDescrip.PasswordChar = '\0';
            this.mtxtInqDescrip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtInqDescrip.SelectedText = "";
            this.mtxtInqDescrip.SelectionLength = 0;
            this.mtxtInqDescrip.SelectionStart = 0;
            this.mtxtInqDescrip.ShortcutsEnabled = true;
            this.mtxtInqDescrip.Size = new System.Drawing.Size(244, 105);
            this.mtxtInqDescrip.TabIndex = 43;
            this.mtxtInqDescrip.UseSelectable = true;
            this.mtxtInqDescrip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtInqDescrip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(2, 123);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(125, 19);
            this.metroLabel20.TabIndex = 42;
            this.metroLabel20.Text = "Inquiry Description :";
            // 
            // mtxtSearch
            // 
            // 
            // 
            // 
            this.mtxtSearch.CustomButton.Image = null;
            this.mtxtSearch.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.mtxtSearch.CustomButton.Name = "";
            this.mtxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtSearch.CustomButton.TabIndex = 1;
            this.mtxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtSearch.CustomButton.UseSelectable = true;
            this.mtxtSearch.CustomButton.Visible = false;
            this.mtxtSearch.Lines = new string[0];
            this.mtxtSearch.Location = new System.Drawing.Point(738, 49);
            this.mtxtSearch.MaxLength = 32767;
            this.mtxtSearch.Name = "mtxtSearch";
            this.mtxtSearch.PasswordChar = '\0';
            this.mtxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSearch.SelectedText = "";
            this.mtxtSearch.SelectionLength = 0;
            this.mtxtSearch.SelectionStart = 0;
            this.mtxtSearch.ShortcutsEnabled = true;
            this.mtxtSearch.Size = new System.Drawing.Size(157, 23);
            this.mtxtSearch.TabIndex = 50;
            this.mtxtSearch.UseSelectable = true;
            this.mtxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(679, 52);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(55, 19);
            this.metroLabel26.TabIndex = 49;
            this.metroLabel26.Text = "Search :";
            // 
            // mdgvAddSection
            // 
            this.mdgvAddSection.AllowUserToResizeRows = false;
            this.mdgvAddSection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvAddSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvAddSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvAddSection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvAddSection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvAddSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvAddSection.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvAddSection.EnableHeadersVisualStyles = false;
            this.mdgvAddSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvAddSection.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvAddSection.Location = new System.Drawing.Point(389, 78);
            this.mdgvAddSection.Name = "mdgvAddSection";
            this.mdgvAddSection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvAddSection.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvAddSection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvAddSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvAddSection.Size = new System.Drawing.Size(506, 177);
            this.mdgvAddSection.TabIndex = 48;
            // 
            // AddInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 275);
            this.Controls.Add(this.mtxtSearch);
            this.Controls.Add(this.metroLabel26);
            this.Controls.Add(this.mdgvAddSection);
            this.Controls.Add(this.mcmbInquiryType);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.mtxtcapacity);
            this.Controls.Add(this.metroLabel25);
            this.Controls.Add(this.mtxtInqDescrip);
            this.Controls.Add(this.metroLabel20);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInquiryForm";
            this.Text = "Inquiry Form";
            this.Load += new System.EventHandler(this.AddInquiryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvAddSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcmbInquiryType;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroTextBox mtxtcapacity;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroTextBox mtxtInqDescrip;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox mtxtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroGrid mdgvAddSection;
    }
}