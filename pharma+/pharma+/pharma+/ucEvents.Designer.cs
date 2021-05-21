
namespace pharma_
{
    partial class ucEvents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEvents));
            this.lblEventsList = new Guna.UI.WinForms.GunaLabel();
            this.pnlEventsList = new Guna.UI.WinForms.GunaShadowPanel();
            this.cmbEvent = new Guna.UI.WinForms.GunaComboBox();
            this.lblDateTime = new Guna.UI.WinForms.GunaLabel();
            this.lblDesc = new Guna.UI.WinForms.GunaLabel();
            this.lblInitiator = new Guna.UI.WinForms.GunaLabel();
            this.dataGridEvents = new Guna.UI.WinForms.GunaDataGridView();
            this.event_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_initiator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_event = new System.Windows.Forms.DataGridViewImageColumn();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblNo = new Guna.UI.WinForms.GunaLabel();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.pctBoxSearch = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlEventsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventsList
            // 
            this.lblEventsList.AutoSize = true;
            this.lblEventsList.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblEventsList.ForeColor = System.Drawing.Color.DimGray;
            this.lblEventsList.Location = new System.Drawing.Point(18, 14);
            this.lblEventsList.Name = "lblEventsList";
            this.lblEventsList.Size = new System.Drawing.Size(218, 45);
            this.lblEventsList.TabIndex = 10;
            this.lblEventsList.Text = "Список подій";
            // 
            // pnlEventsList
            // 
            this.pnlEventsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEventsList.BackColor = System.Drawing.Color.Transparent;
            this.pnlEventsList.BaseColor = System.Drawing.Color.White;
            this.pnlEventsList.Controls.Add(this.cmbEvent);
            this.pnlEventsList.Controls.Add(this.lblDateTime);
            this.pnlEventsList.Controls.Add(this.lblDesc);
            this.pnlEventsList.Controls.Add(this.lblInitiator);
            this.pnlEventsList.Controls.Add(this.dataGridEvents);
            this.pnlEventsList.Controls.Add(this.HSeparator1);
            this.pnlEventsList.Controls.Add(this.lblNo);
            this.pnlEventsList.Location = new System.Drawing.Point(26, 76);
            this.pnlEventsList.Name = "pnlEventsList";
            this.pnlEventsList.ShadowColor = System.Drawing.Color.Black;
            this.pnlEventsList.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.pnlEventsList.Size = new System.Drawing.Size(1134, 508);
            this.pnlEventsList.TabIndex = 11;
            // 
            // cmbEvent
            // 
            this.cmbEvent.BackColor = System.Drawing.Color.Transparent;
            this.cmbEvent.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEvent.BorderColor = System.Drawing.Color.Silver;
            this.cmbEvent.BorderSize = 1;
            this.cmbEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvent.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEvent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbEvent.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Items.AddRange(new object[] {
            "Подія",
            "Реєстрація",
            "Авторизація",
            "Вихід",
            "Оновлення",
            "Створення",
            "Видалення"});
            this.cmbEvent.Location = new System.Drawing.Point(295, 13);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbEvent.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEvent.Radius = 6;
            this.cmbEvent.Size = new System.Drawing.Size(170, 30);
            this.cmbEvent.TabIndex = 77;
            this.cmbEvent.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateTime.Location = new System.Drawing.Point(850, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(93, 21);
            this.lblDateTime.TabIndex = 50;
            this.lblDateTime.Text = "Дата та час";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(538, 18);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(49, 21);
            this.lblDesc.TabIndex = 49;
            this.lblDesc.Text = "Опис";
            // 
            // lblInitiator
            // 
            this.lblInitiator.AutoSize = true;
            this.lblInitiator.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblInitiator.ForeColor = System.Drawing.Color.DimGray;
            this.lblInitiator.Location = new System.Drawing.Point(118, 18);
            this.lblInitiator.Name = "lblInitiator";
            this.lblInitiator.Size = new System.Drawing.Size(77, 21);
            this.lblInitiator.TabIndex = 47;
            this.lblInitiator.Text = "Ініціатор";
            // 
            // dataGridEvents
            // 
            this.dataGridEvents.AllowUserToAddRows = false;
            this.dataGridEvents.AllowUserToDeleteRows = false;
            this.dataGridEvents.AllowUserToResizeColumns = false;
            this.dataGridEvents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridEvents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEvents.ColumnHeadersHeight = 30;
            this.dataGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEvents.ColumnHeadersVisible = false;
            this.dataGridEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.event_no,
            this.event_initiator,
            this.event_name,
            this.event_desc,
            this.event_date_time,
            this.view_event});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEvents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEvents.EnableHeadersVisualStyles = false;
            this.dataGridEvents.GridColor = System.Drawing.Color.White;
            this.dataGridEvents.Location = new System.Drawing.Point(28, 64);
            this.dataGridEvents.MultiSelect = false;
            this.dataGridEvents.Name = "dataGridEvents";
            this.dataGridEvents.ReadOnly = true;
            this.dataGridEvents.RowHeadersVisible = false;
            this.dataGridEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridEvents.RowTemplate.Height = 50;
            this.dataGridEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEvents.ShowCellErrors = false;
            this.dataGridEvents.ShowCellToolTips = false;
            this.dataGridEvents.ShowEditingIcon = false;
            this.dataGridEvents.ShowRowErrors = false;
            this.dataGridEvents.Size = new System.Drawing.Size(1067, 426);
            this.dataGridEvents.TabIndex = 45;
            this.dataGridEvents.TabStop = false;
            this.dataGridEvents.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridEvents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridEvents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridEvents.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.dataGridEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridEvents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEvents.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridEvents.ThemeStyle.ReadOnly = true;
            this.dataGridEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridEvents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridEvents.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEvents_CellClick);
            // 
            // event_no
            // 
            this.event_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.event_no.FillWeight = 253.8071F;
            this.event_no.HeaderText = "№";
            this.event_no.Name = "event_no";
            this.event_no.ReadOnly = true;
            this.event_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.event_no.Width = 90;
            // 
            // event_initiator
            // 
            this.event_initiator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.event_initiator.FillWeight = 14.70838F;
            this.event_initiator.HeaderText = "Ініціатор";
            this.event_initiator.Name = "event_initiator";
            this.event_initiator.ReadOnly = true;
            this.event_initiator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.event_initiator.Width = 180;
            // 
            // event_name
            // 
            this.event_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.event_name.HeaderText = "Подія";
            this.event_name.Name = "event_name";
            this.event_name.ReadOnly = true;
            this.event_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.event_name.Width = 240;
            // 
            // event_desc
            // 
            this.event_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.event_desc.HeaderText = "Опис";
            this.event_desc.Name = "event_desc";
            this.event_desc.ReadOnly = true;
            this.event_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.event_desc.Width = 310;
            // 
            // event_date_time
            // 
            this.event_date_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.event_date_time.HeaderText = "Дата та час";
            this.event_date_time.Name = "event_date_time";
            this.event_date_time.ReadOnly = true;
            this.event_date_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // view_event
            // 
            this.view_event.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.view_event.FillWeight = 50F;
            this.view_event.HeaderText = "Оглянути";
            this.view_event.Image = ((System.Drawing.Image)(resources.GetObject("view_event.Image")));
            this.view_event.Name = "view_event";
            this.view_event.ReadOnly = true;
            // 
            // HSeparator1
            // 
            this.HSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.HSeparator1.Location = new System.Drawing.Point(28, 48);
            this.HSeparator1.Name = "HSeparator1";
            this.HSeparator1.Size = new System.Drawing.Size(1067, 10);
            this.HSeparator1.TabIndex = 44;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblNo.Location = new System.Drawing.Point(42, 18);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(29, 21);
            this.lblNo.TabIndex = 43;
            this.lblNo.Text = "№";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Animated = true;
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.BorderColor = System.Drawing.Color.Silver;
            this.btnRefresh.BorderSize = 1;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Image = global::pharma_.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRefresh.Location = new System.Drawing.Point(1117, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = global::pharma_.Properties.Resources.refresh_hover;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Radius = 6;
            this.btnRefresh.Size = new System.Drawing.Size(39, 39);
            this.btnRefresh.TabIndex = 40;
            this.Tips.SetToolTip(this.btnRefresh, "Оновити");
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(897, 18);
            this.txtSearch.MaxLength = 256;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 6;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(214, 39);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.Text = "Пошук";
            this.txtSearch.TextOffsetX = 28;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pctBoxSearch
            // 
            this.pctBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pctBoxSearch.BaseColor = System.Drawing.Color.Transparent;
            this.pctBoxSearch.Image = global::pharma_.Properties.Resources.search;
            this.pctBoxSearch.Location = new System.Drawing.Point(904, 28);
            this.pctBoxSearch.Name = "pctBoxSearch";
            this.pctBoxSearch.Size = new System.Drawing.Size(20, 20);
            this.pctBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxSearch.TabIndex = 42;
            this.pctBoxSearch.TabStop = false;
            // 
            // ucEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pctBoxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlEventsList);
            this.Controls.Add(this.lblEventsList);
            this.Name = "ucEvents";
            this.Size = new System.Drawing.Size(1184, 598);
            this.pnlEventsList.ResumeLayout(false);
            this.pnlEventsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblEventsList;
        private Guna.UI.WinForms.GunaShadowPanel pnlEventsList;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblNo;
        private Guna.UI.WinForms.GunaDataGridView dataGridEvents;
        private Guna.UI.WinForms.GunaLabel lblInitiator;
        private Guna.UI.WinForms.GunaLabel lblDesc;
        private Guna.UI.WinForms.GunaLabel lblDateTime;
        private System.Windows.Forms.ToolTip Tips;
        private Guna.UI.WinForms.GunaPictureBox pctBoxSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_initiator;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_date_time;
        private System.Windows.Forms.DataGridViewImageColumn view_event;
        private Guna.UI.WinForms.GunaComboBox cmbEvent;
    }
}
