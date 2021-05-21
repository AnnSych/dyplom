
namespace pharma_
{
    partial class ucMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewMedicine = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lblMedicines = new Guna.UI.WinForms.GunaLabel();
            this.pnlMedicineList = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblQuantity = new Guna.UI.WinForms.GunaLabel();
            this.lblRack = new Guna.UI.WinForms.GunaLabel();
            this.lblBatchNo = new Guna.UI.WinForms.GunaLabel();
            this.lblSupplier = new Guna.UI.WinForms.GunaLabel();
            this.lblCategory = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.dataGridMedicines = new Guna.UI.WinForms.GunaDataGridView();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblNo = new Guna.UI.WinForms.GunaLabel();
            this.pctBoxSearch = new Guna.UI.WinForms.GunaPictureBox();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.medicine_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_batch_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_rack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_medicine = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_medicine = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlMedicineList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewMedicine
            // 
            this.btnNewMedicine.Animated = true;
            this.btnNewMedicine.AnimationHoverSpeed = 0.07F;
            this.btnNewMedicine.AnimationSpeed = 0.03F;
            this.btnNewMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnNewMedicine.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewMedicine.BorderColor = System.Drawing.Color.Silver;
            this.btnNewMedicine.BorderSize = 1;
            this.btnNewMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnNewMedicine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMedicine.ForeColor = System.Drawing.Color.DimGray;
            this.btnNewMedicine.Image = null;
            this.btnNewMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewMedicine.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNewMedicine.Location = new System.Drawing.Point(28, 70);
            this.btnNewMedicine.Name = "btnNewMedicine";
            this.btnNewMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNewMedicine.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnNewMedicine.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNewMedicine.OnHoverImage = null;
            this.btnNewMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnNewMedicine.Radius = 6;
            this.btnNewMedicine.Size = new System.Drawing.Size(186, 39);
            this.btnNewMedicine.TabIndex = 62;
            this.btnNewMedicine.Text = "Новий медикамент";
            this.btnNewMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewMedicine.Click += new System.EventHandler(this.btnNewMedicine_Click);
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
            this.txtSearch.TabIndex = 60;
            this.txtSearch.Text = "Пошук";
            this.txtSearch.TextOffsetX = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblMedicines
            // 
            this.lblMedicines.AutoSize = true;
            this.lblMedicines.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblMedicines.ForeColor = System.Drawing.Color.DimGray;
            this.lblMedicines.Location = new System.Drawing.Point(18, 14);
            this.lblMedicines.Name = "lblMedicines";
            this.lblMedicines.Size = new System.Drawing.Size(224, 45);
            this.lblMedicines.TabIndex = 58;
            this.lblMedicines.Text = "Медикаменти";
            // 
            // pnlMedicineList
            // 
            this.pnlMedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMedicineList.BackColor = System.Drawing.Color.Transparent;
            this.pnlMedicineList.BaseColor = System.Drawing.Color.White;
            this.pnlMedicineList.Controls.Add(this.lblQuantity);
            this.pnlMedicineList.Controls.Add(this.lblRack);
            this.pnlMedicineList.Controls.Add(this.lblBatchNo);
            this.pnlMedicineList.Controls.Add(this.lblSupplier);
            this.pnlMedicineList.Controls.Add(this.lblCategory);
            this.pnlMedicineList.Controls.Add(this.lblName);
            this.pnlMedicineList.Controls.Add(this.dataGridMedicines);
            this.pnlMedicineList.Controls.Add(this.HSeparator1);
            this.pnlMedicineList.Controls.Add(this.lblNo);
            this.pnlMedicineList.Location = new System.Drawing.Point(26, 124);
            this.pnlMedicineList.Name = "pnlMedicineList";
            this.pnlMedicineList.ShadowColor = System.Drawing.Color.Black;
            this.pnlMedicineList.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal;
            this.pnlMedicineList.Size = new System.Drawing.Size(1134, 460);
            this.pnlMedicineList.TabIndex = 63;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(958, 18);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 21);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "К-сть";
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRack.ForeColor = System.Drawing.Color.DimGray;
            this.lblRack.Location = new System.Drawing.Point(836, 18);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(66, 21);
            this.lblRack.TabIndex = 51;
            this.lblRack.Text = "Стелаж";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBatchNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblBatchNo.Location = new System.Drawing.Point(656, 18);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(109, 21);
            this.lblBatchNo.TabIndex = 50;
            this.lblBatchNo.Text = "Номер партії";
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
            // dataGridMedicines
            // 
            this.dataGridMedicines.AllowUserToAddRows = false;
            this.dataGridMedicines.AllowUserToDeleteRows = false;
            this.dataGridMedicines.AllowUserToResizeColumns = false;
            this.dataGridMedicines.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGridMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMedicines.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMedicines.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridMedicines.ColumnHeadersHeight = 30;
            this.dataGridMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridMedicines.ColumnHeadersVisible = false;
            this.dataGridMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicine_no,
            this.medicine_name,
            this.medicine_category,
            this.medicine_supplier,
            this.medicine_batch_no,
            this.medicine_rack,
            this.medicine_quantity,
            this.edit_medicine,
            this.delete_medicine});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMedicines.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridMedicines.EnableHeadersVisualStyles = false;
            this.dataGridMedicines.GridColor = System.Drawing.Color.White;
            this.dataGridMedicines.Location = new System.Drawing.Point(28, 64);
            this.dataGridMedicines.MultiSelect = false;
            this.dataGridMedicines.Name = "dataGridMedicines";
            this.dataGridMedicines.ReadOnly = true;
            this.dataGridMedicines.RowHeadersVisible = false;
            this.dataGridMedicines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridMedicines.RowTemplate.Height = 50;
            this.dataGridMedicines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMedicines.ShowCellErrors = false;
            this.dataGridMedicines.ShowCellToolTips = false;
            this.dataGridMedicines.ShowEditingIcon = false;
            this.dataGridMedicines.ShowRowErrors = false;
            this.dataGridMedicines.Size = new System.Drawing.Size(1067, 378);
            this.dataGridMedicines.TabIndex = 45;
            this.dataGridMedicines.TabStop = false;
            this.dataGridMedicines.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridMedicines.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridMedicines.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridMedicines.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridMedicines.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridMedicines.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridMedicines.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridMedicines.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridMedicines.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.dataGridMedicines.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridMedicines.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMedicines.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridMedicines.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridMedicines.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridMedicines.ThemeStyle.ReadOnly = true;
            this.dataGridMedicines.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridMedicines.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMedicines.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridMedicines.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridMedicines.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridMedicines.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridMedicines.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridMedicines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicines_CellClick);
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
            this.pctBoxSearch.TabIndex = 61;
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
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // medicine_no
            // 
            this.medicine_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.medicine_no.FillWeight = 253.8071F;
            this.medicine_no.HeaderText = "№";
            this.medicine_no.Name = "medicine_no";
            this.medicine_no.ReadOnly = true;
            this.medicine_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.medicine_no.Width = 90;
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
            // medicine_category
            // 
            this.medicine_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.medicine_category.HeaderText = "Категорія";
            this.medicine_category.Name = "medicine_category";
            this.medicine_category.ReadOnly = true;
            this.medicine_category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.medicine_category.Width = 180;
            // 
            // medicine_supplier
            // 
            this.medicine_supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.medicine_supplier.HeaderText = "Постачальник";
            this.medicine_supplier.Name = "medicine_supplier";
            this.medicine_supplier.ReadOnly = true;
            this.medicine_supplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.medicine_supplier.Width = 180;
            // 
            // medicine_batch_no
            // 
            this.medicine_batch_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.medicine_batch_no.HeaderText = "Номер партії";
            this.medicine_batch_no.Name = "medicine_batch_no";
            this.medicine_batch_no.ReadOnly = true;
            this.medicine_batch_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.medicine_batch_no.Width = 180;
            // 
            // medicine_rack
            // 
            this.medicine_rack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.medicine_rack.HeaderText = "Стелаж";
            this.medicine_rack.Name = "medicine_rack";
            this.medicine_rack.ReadOnly = true;
            this.medicine_rack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.medicine_rack.Width = 120;
            // 
            // medicine_quantity
            // 
            this.medicine_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicine_quantity.HeaderText = "Кількість";
            this.medicine_quantity.Name = "medicine_quantity";
            this.medicine_quantity.ReadOnly = true;
            this.medicine_quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // edit_medicine
            // 
            this.edit_medicine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit_medicine.HeaderText = "Редагувати";
            this.edit_medicine.Image = global::pharma_.Properties.Resources.edit_small;
            this.edit_medicine.Name = "edit_medicine";
            this.edit_medicine.ReadOnly = true;
            this.edit_medicine.Width = 20;
            // 
            // delete_medicine
            // 
            this.delete_medicine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete_medicine.HeaderText = "Видалити";
            this.delete_medicine.Image = global::pharma_.Properties.Resources.trash_small;
            this.delete_medicine.Name = "delete_medicine";
            this.delete_medicine.ReadOnly = true;
            this.delete_medicine.Width = 60;
            // 
            // ucMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlMedicineList);
            this.Controls.Add(this.btnNewMedicine);
            this.Controls.Add(this.pctBoxSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblMedicines);
            this.Name = "ucMedicine";
            this.Size = new System.Drawing.Size(1184, 598);
            this.pnlMedicineList.ResumeLayout(false);
            this.pnlMedicineList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnNewMedicine;
        private Guna.UI.WinForms.GunaPictureBox pctBoxSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaLabel lblMedicines;
        private Guna.UI.WinForms.GunaShadowPanel pnlMedicineList;
        private Guna.UI.WinForms.GunaLabel lblRack;
        private Guna.UI.WinForms.GunaLabel lblBatchNo;
        private Guna.UI.WinForms.GunaLabel lblSupplier;
        private Guna.UI.WinForms.GunaLabel lblCategory;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaDataGridView dataGridMedicines;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblNo;
        private Guna.UI.WinForms.GunaLabel lblQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_batch_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_rack;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_quantity;
        private System.Windows.Forms.DataGridViewImageColumn edit_medicine;
        private System.Windows.Forms.DataGridViewImageColumn delete_medicine;
    }
}
