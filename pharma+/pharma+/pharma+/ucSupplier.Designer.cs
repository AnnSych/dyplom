
namespace pharma_
{
    partial class ucSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSupplier));
            this.btnNewSupplier = new Guna.UI.WinForms.GunaButton();
            this.pctBoxSearch = new Guna.UI.WinForms.GunaPictureBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.lblSuppliers = new Guna.UI.WinForms.GunaLabel();
            this.pnlSuppliersList = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblDesc = new Guna.UI.WinForms.GunaLabel();
            this.lblAddress = new Guna.UI.WinForms.GunaLabel();
            this.lblPhone = new Guna.UI.WinForms.GunaLabel();
            this.lblEmail = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.dataGridSuppliers = new Guna.UI.WinForms.GunaDataGridView();
            this.supplier_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_supplier = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_supplier = new System.Windows.Forms.DataGridViewImageColumn();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblNo = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).BeginInit();
            this.pnlSuppliersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Animated = true;
            this.btnNewSupplier.AnimationHoverSpeed = 0.07F;
            this.btnNewSupplier.AnimationSpeed = 0.03F;
            this.btnNewSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSupplier.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewSupplier.BorderColor = System.Drawing.Color.Silver;
            this.btnNewSupplier.BorderSize = 1;
            this.btnNewSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.btnNewSupplier.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewSupplier.Image = null;
            this.btnNewSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewSupplier.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNewSupplier.Location = new System.Drawing.Point(28, 70);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNewSupplier.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNewSupplier.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNewSupplier.OnHoverImage = null;
            this.btnNewSupplier.OnPressedColor = System.Drawing.Color.Black;
            this.btnNewSupplier.Radius = 6;
            this.btnNewSupplier.Size = new System.Drawing.Size(186, 39);
            this.btnNewSupplier.TabIndex = 52;
            this.btnNewSupplier.Text = "Новий постачальник";
            this.btnNewSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
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
            this.pctBoxSearch.TabIndex = 51;
            this.pctBoxSearch.TabStop = false;
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
            this.txtSearch.TabIndex = 50;
            this.txtSearch.Text = "Пошук";
            this.txtSearch.TextOffsetX = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblSuppliers.ForeColor = System.Drawing.Color.DimGray;
            this.lblSuppliers.Location = new System.Drawing.Point(18, 14);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(245, 45);
            this.lblSuppliers.TabIndex = 48;
            this.lblSuppliers.Text = "Постачальники";
            // 
            // pnlSuppliersList
            // 
            this.pnlSuppliersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSuppliersList.BackColor = System.Drawing.Color.Transparent;
            this.pnlSuppliersList.BaseColor = System.Drawing.Color.White;
            this.pnlSuppliersList.Controls.Add(this.lblDesc);
            this.pnlSuppliersList.Controls.Add(this.lblAddress);
            this.pnlSuppliersList.Controls.Add(this.lblPhone);
            this.pnlSuppliersList.Controls.Add(this.lblEmail);
            this.pnlSuppliersList.Controls.Add(this.lblName);
            this.pnlSuppliersList.Controls.Add(this.dataGridSuppliers);
            this.pnlSuppliersList.Controls.Add(this.HSeparator1);
            this.pnlSuppliersList.Controls.Add(this.lblNo);
            this.pnlSuppliersList.Location = new System.Drawing.Point(26, 124);
            this.pnlSuppliersList.Name = "pnlSuppliersList";
            this.pnlSuppliersList.ShadowColor = System.Drawing.Color.Black;
            this.pnlSuppliersList.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.pnlSuppliersList.Size = new System.Drawing.Size(1134, 460);
            this.pnlSuppliersList.TabIndex = 53;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(876, 18);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(49, 21);
            this.lblDesc.TabIndex = 51;
            this.lblDesc.Text = "Опис";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddress.Location = new System.Drawing.Point(698, 18);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 21);
            this.lblAddress.TabIndex = 50;
            this.lblAddress.Text = "Адреса";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.DimGray;
            this.lblPhone.Location = new System.Drawing.Point(508, 18);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 21);
            this.lblPhone.TabIndex = 49;
            this.lblPhone.Text = "Телефон";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(296, 18);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(148, 21);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Електронна пошта";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(116, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 21);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Назва";
            // 
            // dataGridSuppliers
            // 
            this.dataGridSuppliers.AllowUserToAddRows = false;
            this.dataGridSuppliers.AllowUserToDeleteRows = false;
            this.dataGridSuppliers.AllowUserToResizeColumns = false;
            this.dataGridSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSuppliers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSuppliers.ColumnHeadersHeight = 30;
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSuppliers.ColumnHeadersVisible = false;
            this.dataGridSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplier_no,
            this.supplier_name,
            this.supplier_email,
            this.supplier_phone,
            this.supplier_address,
            this.supplier_desc,
            this.view_supplier,
            this.delete_supplier});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSuppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSuppliers.EnableHeadersVisualStyles = false;
            this.dataGridSuppliers.GridColor = System.Drawing.Color.White;
            this.dataGridSuppliers.Location = new System.Drawing.Point(28, 64);
            this.dataGridSuppliers.MultiSelect = false;
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.ReadOnly = true;
            this.dataGridSuppliers.RowHeadersVisible = false;
            this.dataGridSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSuppliers.RowTemplate.Height = 50;
            this.dataGridSuppliers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuppliers.ShowCellErrors = false;
            this.dataGridSuppliers.ShowCellToolTips = false;
            this.dataGridSuppliers.ShowEditingIcon = false;
            this.dataGridSuppliers.ShowRowErrors = false;
            this.dataGridSuppliers.Size = new System.Drawing.Size(1067, 378);
            this.dataGridSuppliers.TabIndex = 45;
            this.dataGridSuppliers.TabStop = false;
            this.dataGridSuppliers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridSuppliers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridSuppliers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridSuppliers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridSuppliers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridSuppliers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridSuppliers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridSuppliers.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridSuppliers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.dataGridSuppliers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridSuppliers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridSuppliers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridSuppliers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSuppliers.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridSuppliers.ThemeStyle.ReadOnly = true;
            this.dataGridSuppliers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridSuppliers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSuppliers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridSuppliers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridSuppliers.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridSuppliers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridSuppliers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSuppliers_CellClick);
            // 
            // supplier_no
            // 
            this.supplier_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplier_no.FillWeight = 253.8071F;
            this.supplier_no.HeaderText = "№";
            this.supplier_no.Name = "supplier_no";
            this.supplier_no.ReadOnly = true;
            this.supplier_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supplier_no.Width = 90;
            // 
            // supplier_name
            // 
            this.supplier_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplier_name.FillWeight = 14.70838F;
            this.supplier_name.HeaderText = "Назва";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            this.supplier_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supplier_name.Width = 180;
            // 
            // supplier_email
            // 
            this.supplier_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplier_email.HeaderText = "Пошта";
            this.supplier_email.Name = "supplier_email";
            this.supplier_email.ReadOnly = true;
            this.supplier_email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supplier_email.Width = 210;
            // 
            // supplier_phone
            // 
            this.supplier_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplier_phone.HeaderText = "Телефон";
            this.supplier_phone.Name = "supplier_phone";
            this.supplier_phone.ReadOnly = true;
            this.supplier_phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supplier_phone.Width = 190;
            // 
            // supplier_address
            // 
            this.supplier_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplier_address.HeaderText = "Адреса";
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.ReadOnly = true;
            this.supplier_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supplier_address.Width = 180;
            // 
            // supplier_desc
            // 
            this.supplier_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplier_desc.HeaderText = "Опис";
            this.supplier_desc.Name = "supplier_desc";
            this.supplier_desc.ReadOnly = true;
            this.supplier_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // view_supplier
            // 
            this.view_supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.view_supplier.HeaderText = "Оглянути";
            this.view_supplier.Image = ((System.Drawing.Image)(resources.GetObject("view_supplier.Image")));
            this.view_supplier.Name = "view_supplier";
            this.view_supplier.ReadOnly = true;
            this.view_supplier.Width = 20;
            // 
            // delete_supplier
            // 
            this.delete_supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete_supplier.HeaderText = "Видалити";
            this.delete_supplier.Image = global::pharma_.Properties.Resources.trash_small;
            this.delete_supplier.Name = "delete_supplier";
            this.delete_supplier.ReadOnly = true;
            this.delete_supplier.Width = 60;
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
            // ucSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlSuppliersList);
            this.Controls.Add(this.btnNewSupplier);
            this.Controls.Add(this.pctBoxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSuppliers);
            this.Name = "ucSupplier";
            this.Size = new System.Drawing.Size(1184, 598);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).EndInit();
            this.pnlSuppliersList.ResumeLayout(false);
            this.pnlSuppliersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnNewSupplier;
        private Guna.UI.WinForms.GunaPictureBox pctBoxSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaLabel lblSuppliers;
        private Guna.UI.WinForms.GunaShadowPanel pnlSuppliersList;
        private Guna.UI.WinForms.GunaLabel lblAddress;
        private Guna.UI.WinForms.GunaLabel lblPhone;
        private Guna.UI.WinForms.GunaLabel lblEmail;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaDataGridView dataGridSuppliers;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblNo;
        private Guna.UI.WinForms.GunaLabel lblDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_desc;
        private System.Windows.Forms.DataGridViewImageColumn view_supplier;
        private System.Windows.Forms.DataGridViewImageColumn delete_supplier;
    }
}
