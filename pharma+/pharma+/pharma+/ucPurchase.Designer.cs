
namespace pharma_
{
    partial class ucPurchase
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
            this.btnNewPurchase = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lblPurchase = new Guna.UI.WinForms.GunaLabel();
            this.pnlPurchaseList = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblQuantity = new Guna.UI.WinForms.GunaLabel();
            this.lblPurchaseCode = new Guna.UI.WinForms.GunaLabel();
            this.lblSupplier = new Guna.UI.WinForms.GunaLabel();
            this.lblCategory = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.dataGridPurchases = new Guna.UI.WinForms.GunaDataGridView();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblNo = new Guna.UI.WinForms.GunaLabel();
            this.pctBoxSearch = new Guna.UI.WinForms.GunaPictureBox();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.purchase_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_purchase = new System.Windows.Forms.DataGridViewImageColumn();
            this.export_purchase_data = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_purchase = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlPurchaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPurchase
            // 
            this.btnNewPurchase.Animated = true;
            this.btnNewPurchase.AnimationHoverSpeed = 0.07F;
            this.btnNewPurchase.AnimationSpeed = 0.03F;
            this.btnNewPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPurchase.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewPurchase.BorderColor = System.Drawing.Color.Silver;
            this.btnNewPurchase.BorderSize = 1;
            this.btnNewPurchase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewPurchase.FocusedColor = System.Drawing.Color.Empty;
            this.btnNewPurchase.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPurchase.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewPurchase.Image = null;
            this.btnNewPurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewPurchase.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNewPurchase.Location = new System.Drawing.Point(28, 70);
            this.btnNewPurchase.Name = "btnNewPurchase";
            this.btnNewPurchase.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNewPurchase.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNewPurchase.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNewPurchase.OnHoverImage = null;
            this.btnNewPurchase.OnPressedColor = System.Drawing.Color.Black;
            this.btnNewPurchase.Radius = 6;
            this.btnNewPurchase.Size = new System.Drawing.Size(186, 39);
            this.btnNewPurchase.TabIndex = 57;
            this.btnNewPurchase.Text = "Нова закупівля";
            this.btnNewPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewPurchase.Click += new System.EventHandler(this.btnNewPurchase_Click);
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
            this.txtSearch.TabIndex = 55;
            this.txtSearch.Text = "Пошук";
            this.txtSearch.TextOffsetX = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblPurchase.ForeColor = System.Drawing.Color.DimGray;
            this.lblPurchase.Location = new System.Drawing.Point(18, 14);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(160, 45);
            this.lblPurchase.TabIndex = 53;
            this.lblPurchase.Text = "Закупівля";
            // 
            // pnlPurchaseList
            // 
            this.pnlPurchaseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPurchaseList.BackColor = System.Drawing.Color.Transparent;
            this.pnlPurchaseList.BaseColor = System.Drawing.Color.White;
            this.pnlPurchaseList.Controls.Add(this.lblQuantity);
            this.pnlPurchaseList.Controls.Add(this.lblPurchaseCode);
            this.pnlPurchaseList.Controls.Add(this.lblSupplier);
            this.pnlPurchaseList.Controls.Add(this.lblCategory);
            this.pnlPurchaseList.Controls.Add(this.lblName);
            this.pnlPurchaseList.Controls.Add(this.dataGridPurchases);
            this.pnlPurchaseList.Controls.Add(this.HSeparator1);
            this.pnlPurchaseList.Controls.Add(this.lblNo);
            this.pnlPurchaseList.Location = new System.Drawing.Point(26, 124);
            this.pnlPurchaseList.Name = "pnlPurchaseList";
            this.pnlPurchaseList.ShadowColor = System.Drawing.Color.Black;
            this.pnlPurchaseList.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.pnlPurchaseList.Size = new System.Drawing.Size(1134, 460);
            this.pnlPurchaseList.TabIndex = 64;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(836, 18);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 21);
            this.lblQuantity.TabIndex = 51;
            this.lblQuantity.Text = "Кількість";
            // 
            // lblPurchaseCode
            // 
            this.lblPurchaseCode.AutoSize = true;
            this.lblPurchaseCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPurchaseCode.ForeColor = System.Drawing.Color.DimGray;
            this.lblPurchaseCode.Location = new System.Drawing.Point(656, 18);
            this.lblPurchaseCode.Name = "lblPurchaseCode";
            this.lblPurchaseCode.Size = new System.Drawing.Size(39, 21);
            this.lblPurchaseCode.TabIndex = 50;
            this.lblPurchaseCode.Text = "Код";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblSupplier.Location = new System.Drawing.Point(476, 18);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(116, 21);
            this.lblSupplier.TabIndex = 49;
            this.lblSupplier.Text = "Постачальник";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(296, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 21);
            this.lblCategory.TabIndex = 48;
            this.lblCategory.Text = "Категорія";
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
            // dataGridPurchases
            // 
            this.dataGridPurchases.AllowUserToAddRows = false;
            this.dataGridPurchases.AllowUserToDeleteRows = false;
            this.dataGridPurchases.AllowUserToResizeColumns = false;
            this.dataGridPurchases.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPurchases.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPurchases.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPurchases.ColumnHeadersHeight = 30;
            this.dataGridPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPurchases.ColumnHeadersVisible = false;
            this.dataGridPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchase_no,
            this.medicine_name,
            this.purchase_category,
            this.purchase_supplier,
            this.purchase_code,
            this.purchase_quantity,
            this.edit_purchase,
            this.export_purchase_data,
            this.delete_purchase});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPurchases.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPurchases.EnableHeadersVisualStyles = false;
            this.dataGridPurchases.GridColor = System.Drawing.Color.White;
            this.dataGridPurchases.Location = new System.Drawing.Point(28, 64);
            this.dataGridPurchases.MultiSelect = false;
            this.dataGridPurchases.Name = "dataGridPurchases";
            this.dataGridPurchases.ReadOnly = true;
            this.dataGridPurchases.RowHeadersVisible = false;
            this.dataGridPurchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridPurchases.RowTemplate.Height = 50;
            this.dataGridPurchases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPurchases.ShowCellErrors = false;
            this.dataGridPurchases.ShowCellToolTips = false;
            this.dataGridPurchases.ShowEditingIcon = false;
            this.dataGridPurchases.ShowRowErrors = false;
            this.dataGridPurchases.Size = new System.Drawing.Size(1067, 378);
            this.dataGridPurchases.TabIndex = 45;
            this.dataGridPurchases.TabStop = false;
            this.dataGridPurchases.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridPurchases.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridPurchases.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridPurchases.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridPurchases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridPurchases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridPurchases.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridPurchases.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridPurchases.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.dataGridPurchases.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPurchases.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridPurchases.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridPurchases.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPurchases.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridPurchases.ThemeStyle.ReadOnly = true;
            this.dataGridPurchases.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridPurchases.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPurchases.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridPurchases.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridPurchases.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridPurchases.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridPurchases.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridPurchases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPurchases_CellClick);
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
            this.pctBoxSearch.TabIndex = 56;
            this.pctBoxSearch.TabStop = false;
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
            this.btnRefresh.TabIndex = 54;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // purchase_no
            // 
            this.purchase_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchase_no.FillWeight = 253.8071F;
            this.purchase_no.HeaderText = "№";
            this.purchase_no.Name = "purchase_no";
            this.purchase_no.ReadOnly = true;
            this.purchase_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.purchase_no.Width = 90;
            // 
            // medicine_name
            // 
            this.medicine_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.medicine_name.FillWeight = 14.70838F;
            this.medicine_name.HeaderText = "Назва";
            this.medicine_name.Name = "medicine_name";
            this.medicine_name.ReadOnly = true;
            this.medicine_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.medicine_name.Width = 180;
            // 
            // purchase_category
            // 
            this.purchase_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchase_category.HeaderText = "Категорія";
            this.purchase_category.Name = "purchase_category";
            this.purchase_category.ReadOnly = true;
            this.purchase_category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.purchase_category.Width = 180;
            // 
            // purchase_supplier
            // 
            this.purchase_supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchase_supplier.HeaderText = "Постачальник";
            this.purchase_supplier.Name = "purchase_supplier";
            this.purchase_supplier.ReadOnly = true;
            this.purchase_supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.purchase_supplier.Width = 180;
            // 
            // purchase_code
            // 
            this.purchase_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchase_code.HeaderText = "Код";
            this.purchase_code.Name = "purchase_code";
            this.purchase_code.ReadOnly = true;
            this.purchase_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.purchase_code.Width = 180;
            // 
            // purchase_quantity
            // 
            this.purchase_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchase_quantity.HeaderText = "Кількість";
            this.purchase_quantity.Name = "purchase_quantity";
            this.purchase_quantity.ReadOnly = true;
            this.purchase_quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // edit_purchase
            // 
            this.edit_purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit_purchase.HeaderText = "Редагувати";
            this.edit_purchase.Image = global::pharma_.Properties.Resources.edit_small;
            this.edit_purchase.Name = "edit_purchase";
            this.edit_purchase.ReadOnly = true;
            this.edit_purchase.Width = 60;
            // 
            // export_purchase_data
            // 
            this.export_purchase_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.export_purchase_data.HeaderText = "Експорт";
            this.export_purchase_data.Image = global::pharma_.Properties.Resources.export_pdf_small;
            this.export_purchase_data.Name = "export_purchase_data";
            this.export_purchase_data.ReadOnly = true;
            this.export_purchase_data.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.export_purchase_data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.export_purchase_data.Width = 20;
            // 
            // delete_purchase
            // 
            this.delete_purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete_purchase.HeaderText = "Видалити";
            this.delete_purchase.Image = global::pharma_.Properties.Resources.trash_small;
            this.delete_purchase.Name = "delete_purchase";
            this.delete_purchase.ReadOnly = true;
            this.delete_purchase.Width = 60;
            // 
            // ucPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlPurchaseList);
            this.Controls.Add(this.btnNewPurchase);
            this.Controls.Add(this.pctBoxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblPurchase);
            this.Name = "ucPurchase";
            this.Size = new System.Drawing.Size(1184, 598);
            this.pnlPurchaseList.ResumeLayout(false);
            this.pnlPurchaseList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnNewPurchase;
        private Guna.UI.WinForms.GunaPictureBox pctBoxSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaLabel lblPurchase;
        private Guna.UI.WinForms.GunaShadowPanel pnlPurchaseList;
        private Guna.UI.WinForms.GunaLabel lblQuantity;
        private Guna.UI.WinForms.GunaLabel lblPurchaseCode;
        private Guna.UI.WinForms.GunaLabel lblSupplier;
        private Guna.UI.WinForms.GunaLabel lblCategory;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaDataGridView dataGridPurchases;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_quantity;
        private System.Windows.Forms.DataGridViewImageColumn edit_purchase;
        private System.Windows.Forms.DataGridViewImageColumn export_purchase_data;
        private System.Windows.Forms.DataGridViewImageColumn delete_purchase;
    }
}
