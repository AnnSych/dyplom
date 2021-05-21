
namespace pharma_
{
    partial class frmEditMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditMedicine));
            this.pnlFrame = new Guna.UI.WinForms.GunaPanel();
            this.cmbRack = new Guna.UI.WinForms.GunaComboBox();
            this.lblRack = new Guna.UI.WinForms.GunaLabel();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.dtpEnd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpStart = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblEndDate = new Guna.UI.WinForms.GunaLabel();
            this.lblStartDate = new Guna.UI.WinForms.GunaLabel();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.lblQuantity = new Guna.UI.WinForms.GunaLabel();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.lblDesc = new Guna.UI.WinForms.GunaLabel();
            this.txtBatchNo = new Guna.UI.WinForms.GunaTextBox();
            this.lblBatchNo = new Guna.UI.WinForms.GunaLabel();
            this.cmbSupplier = new Guna.UI.WinForms.GunaComboBox();
            this.lblSupplier = new Guna.UI.WinForms.GunaLabel();
            this.cmbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.lblCategory = new Guna.UI.WinForms.GunaLabel();
            this.txtMedicineName = new Guna.UI.WinForms.GunaTextBox();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblMedicineName = new Guna.UI.WinForms.GunaLabel();
            this.lblEditMedicine = new Guna.UI.WinForms.GunaLabel();
            this.pnlFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Controls.Add(this.cmbRack);
            this.pnlFrame.Controls.Add(this.lblRack);
            this.pnlFrame.Controls.Add(this.btnUpdate);
            this.pnlFrame.Controls.Add(this.dtpEnd);
            this.pnlFrame.Controls.Add(this.dtpStart);
            this.pnlFrame.Controls.Add(this.lblEndDate);
            this.pnlFrame.Controls.Add(this.lblStartDate);
            this.pnlFrame.Controls.Add(this.txtQuantity);
            this.pnlFrame.Controls.Add(this.lblQuantity);
            this.pnlFrame.Controls.Add(this.txtDesc);
            this.pnlFrame.Controls.Add(this.lblDesc);
            this.pnlFrame.Controls.Add(this.txtBatchNo);
            this.pnlFrame.Controls.Add(this.lblBatchNo);
            this.pnlFrame.Controls.Add(this.cmbSupplier);
            this.pnlFrame.Controls.Add(this.lblSupplier);
            this.pnlFrame.Controls.Add(this.cmbCategory);
            this.pnlFrame.Controls.Add(this.lblCategory);
            this.pnlFrame.Controls.Add(this.txtMedicineName);
            this.pnlFrame.Controls.Add(this.HSeparator1);
            this.pnlFrame.Controls.Add(this.lblMedicineName);
            this.pnlFrame.Controls.Add(this.lblEditMedicine);
            this.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(554, 681);
            this.pnlFrame.TabIndex = 0;
            // 
            // cmbRack
            // 
            this.cmbRack.BackColor = System.Drawing.Color.Transparent;
            this.cmbRack.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRack.BorderColor = System.Drawing.Color.Silver;
            this.cmbRack.BorderSize = 1;
            this.cmbRack.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRack.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbRack.ForeColor = System.Drawing.Color.DimGray;
            this.cmbRack.FormattingEnabled = true;
            this.cmbRack.Items.AddRange(new object[] {
            "- Стелаж -"});
            this.cmbRack.Location = new System.Drawing.Point(30, 280);
            this.cmbRack.Name = "cmbRack";
            this.cmbRack.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbRack.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRack.Radius = 6;
            this.cmbRack.Size = new System.Drawing.Size(494, 30);
            this.cmbRack.TabIndex = 84;
            this.cmbRack.SelectedIndexChanged += new System.EventHandler(this.cmbRack_SelectedIndexChanged);
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRack.ForeColor = System.Drawing.Color.DimGray;
            this.lblRack.Location = new System.Drawing.Point(26, 246);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(66, 21);
            this.lblRack.TabIndex = 85;
            this.lblRack.Text = "Стелаж";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(382, 622);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 6;
            this.btnUpdate.Size = new System.Drawing.Size(142, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.BackColor = System.Drawing.Color.Transparent;
            this.dtpEnd.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpEnd.BorderColor = System.Drawing.Color.Silver;
            this.dtpEnd.BorderSize = 1;
            this.dtpEnd.CustomFormat = null;
            this.dtpEnd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEnd.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpEnd.ForeColor = System.Drawing.Color.DimGray;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(284, 569);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpEnd.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.dtpEnd.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpEnd.OnPressedColor = System.Drawing.Color.Black;
            this.dtpEnd.Radius = 6;
            this.dtpEnd.Size = new System.Drawing.Size(240, 32);
            this.dtpEnd.TabIndex = 6;
            this.dtpEnd.Text = "2/9/2021";
            this.dtpEnd.Value = new System.DateTime(2021, 2, 9, 21, 19, 26, 153);
            // 
            // dtpStart
            // 
            this.dtpStart.BackColor = System.Drawing.Color.Transparent;
            this.dtpStart.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpStart.BorderColor = System.Drawing.Color.Silver;
            this.dtpStart.BorderSize = 1;
            this.dtpStart.CustomFormat = null;
            this.dtpStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStart.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpStart.ForeColor = System.Drawing.Color.DimGray;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(30, 569);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpStart.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.dtpStart.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpStart.OnPressedColor = System.Drawing.Color.Black;
            this.dtpStart.Radius = 6;
            this.dtpStart.Size = new System.Drawing.Size(240, 32);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.Text = "2/9/2021";
            this.dtpStart.Value = new System.DateTime(2021, 2, 9, 21, 28, 19, 83);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblEndDate.Location = new System.Drawing.Point(280, 535);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(118, 21);
            this.lblEndDate.TabIndex = 81;
            this.lblEndDate.Text = "Придатний до";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblStartDate.Location = new System.Drawing.Point(26, 535);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 21);
            this.lblStartDate.TabIndex = 80;
            this.lblStartDate.Text = "Вироблено";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantity.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.txtQuantity.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtQuantity.Location = new System.Drawing.Point(284, 359);
            this.txtQuantity.MaxLength = 9;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.Radius = 6;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(240, 32);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Text = "Введіть кількість";
            this.txtQuantity.TextOffsetX = 6;
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(282, 325);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(110, 21);
            this.lblQuantity.TabIndex = 79;
            this.lblQuantity.Text = "Кількість (шт)";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtDesc.BorderColor = System.Drawing.Color.Silver;
            this.txtDesc.BorderSize = 1;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtDesc.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtDesc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDesc.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesc.Location = new System.Drawing.Point(30, 440);
            this.txtDesc.MaxLength = 256;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.Radius = 6;
            this.txtDesc.SelectedText = "";
            this.txtDesc.Size = new System.Drawing.Size(494, 80);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.TextOffsetX = 6;
            this.txtDesc.Enter += new System.EventHandler(this.txtDesc_Enter);
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(26, 406);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(49, 21);
            this.lblDesc.TabIndex = 78;
            this.lblDesc.Text = "Опис";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchNo.BackColor = System.Drawing.Color.Transparent;
            this.txtBatchNo.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBatchNo.BorderColor = System.Drawing.Color.Silver;
            this.txtBatchNo.BorderSize = 1;
            this.txtBatchNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBatchNo.Enabled = false;
            this.txtBatchNo.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBatchNo.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtBatchNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBatchNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBatchNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtBatchNo.Location = new System.Drawing.Point(30, 359);
            this.txtBatchNo.MaxLength = 16;
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.PasswordChar = '\0';
            this.txtBatchNo.Radius = 6;
            this.txtBatchNo.SelectedText = "";
            this.txtBatchNo.Size = new System.Drawing.Size(240, 32);
            this.txtBatchNo.TabIndex = 2;
            this.txtBatchNo.Text = "Введіть номер";
            this.txtBatchNo.TextOffsetX = 6;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBatchNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblBatchNo.Location = new System.Drawing.Point(26, 325);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(109, 21);
            this.lblBatchNo.TabIndex = 77;
            this.lblBatchNo.Text = "Номер партії";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSupplier.BorderColor = System.Drawing.Color.Silver;
            this.cmbSupplier.BorderSize = 1;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "- Постачальник -"});
            this.cmbSupplier.Location = new System.Drawing.Point(284, 201);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbSupplier.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSupplier.Radius = 6;
            this.cmbSupplier.Size = new System.Drawing.Size(240, 30);
            this.cmbSupplier.TabIndex = 1;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblSupplier.Location = new System.Drawing.Point(280, 167);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(116, 21);
            this.lblSupplier.TabIndex = 76;
            this.lblSupplier.Text = "Постачальник";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.BorderColor = System.Drawing.Color.Silver;
            this.cmbCategory.BorderSize = 1;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "- Категорія -"});
            this.cmbCategory.Location = new System.Drawing.Point(30, 201);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCategory.Radius = 6;
            this.cmbCategory.Size = new System.Drawing.Size(240, 30);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(26, 167);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 21);
            this.lblCategory.TabIndex = 75;
            this.lblCategory.Text = "Категорія";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicineName.BackColor = System.Drawing.Color.Transparent;
            this.txtMedicineName.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedicineName.BorderColor = System.Drawing.Color.Silver;
            this.txtMedicineName.BorderSize = 1;
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.Enabled = false;
            this.txtMedicineName.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedicineName.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtMedicineName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMedicineName.ForeColor = System.Drawing.Color.DimGray;
            this.txtMedicineName.Location = new System.Drawing.Point(30, 120);
            this.txtMedicineName.MaxLength = 128;
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.PasswordChar = '\0';
            this.txtMedicineName.Radius = 6;
            this.txtMedicineName.SelectedText = "";
            this.txtMedicineName.Size = new System.Drawing.Size(494, 32);
            this.txtMedicineName.TabIndex = 63;
            this.txtMedicineName.Text = "Введіть назву";
            this.txtMedicineName.TextOffsetX = 6;
            // 
            // HSeparator1
            // 
            this.HSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.HSeparator1.Location = new System.Drawing.Point(30, 60);
            this.HSeparator1.Name = "HSeparator1";
            this.HSeparator1.Size = new System.Drawing.Size(494, 10);
            this.HSeparator1.TabIndex = 74;
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMedicineName.ForeColor = System.Drawing.Color.DimGray;
            this.lblMedicineName.Location = new System.Drawing.Point(26, 86);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(159, 21);
            this.lblMedicineName.TabIndex = 73;
            this.lblMedicineName.Text = "Назва медикаменту";
            // 
            // lblEditMedicine
            // 
            this.lblEditMedicine.AutoSize = true;
            this.lblEditMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMedicine.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditMedicine.Location = new System.Drawing.Point(22, 16);
            this.lblEditMedicine.Name = "lblEditMedicine";
            this.lblEditMedicine.Size = new System.Drawing.Size(286, 32);
            this.lblEditMedicine.TabIndex = 72;
            this.lblEditMedicine.Text = "Редагувати медикамент";
            // 
            // frmEditMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 681);
            this.Controls.Add(this.pnlFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditMedicine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%title%";
            this.Activated += new System.EventHandler(this.frmEditMedicine_Activated);
            this.pnlFrame.ResumeLayout(false);
            this.pnlFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlFrame;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaDateTimePicker dtpEnd;
        private Guna.UI.WinForms.GunaDateTimePicker dtpStart;
        private Guna.UI.WinForms.GunaLabel lblEndDate;
        private Guna.UI.WinForms.GunaLabel lblStartDate;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaLabel lblQuantity;
        private Guna.UI.WinForms.GunaTextBox txtDesc;
        private Guna.UI.WinForms.GunaLabel lblDesc;
        private Guna.UI.WinForms.GunaTextBox txtBatchNo;
        private Guna.UI.WinForms.GunaLabel lblBatchNo;
        private Guna.UI.WinForms.GunaComboBox cmbSupplier;
        private Guna.UI.WinForms.GunaLabel lblSupplier;
        private Guna.UI.WinForms.GunaComboBox cmbCategory;
        private Guna.UI.WinForms.GunaLabel lblCategory;
        private Guna.UI.WinForms.GunaTextBox txtMedicineName;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblMedicineName;
        private Guna.UI.WinForms.GunaLabel lblEditMedicine;
        private Guna.UI.WinForms.GunaComboBox cmbRack;
        private Guna.UI.WinForms.GunaLabel lblRack;
    }
}