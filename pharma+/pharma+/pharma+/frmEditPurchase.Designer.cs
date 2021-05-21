
namespace pharma_
{
    partial class frmEditPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPurchase));
            this.pnlFrame = new Guna.UI.WinForms.GunaPanel();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.txtGrandTotal = new Guna.UI.WinForms.GunaTextBox();
            this.lblGrandTotal = new Guna.UI.WinForms.GunaLabel();
            this.cmbStatus = new Guna.UI.WinForms.GunaComboBox();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.cmbPaymentMethod = new Guna.UI.WinForms.GunaComboBox();
            this.lblPyamentMethod = new Guna.UI.WinForms.GunaLabel();
            this.cmbMedicine = new Guna.UI.WinForms.GunaComboBox();
            this.dtpPurchase = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblPurchaseDate = new Guna.UI.WinForms.GunaLabel();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.lblQuantity = new Guna.UI.WinForms.GunaLabel();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.lblDesc = new Guna.UI.WinForms.GunaLabel();
            this.txtPurchaseCode = new Guna.UI.WinForms.GunaTextBox();
            this.lblPurchaseCode = new Guna.UI.WinForms.GunaLabel();
            this.cmbSupplier = new Guna.UI.WinForms.GunaComboBox();
            this.lblSupplier = new Guna.UI.WinForms.GunaLabel();
            this.cmbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.lblCategory = new Guna.UI.WinForms.GunaLabel();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblMedicineName = new Guna.UI.WinForms.GunaLabel();
            this.lblEditPurchase = new Guna.UI.WinForms.GunaLabel();
            this.pnlFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.Controls.Add(this.btnUpdate);
            this.pnlFrame.Controls.Add(this.txtGrandTotal);
            this.pnlFrame.Controls.Add(this.lblGrandTotal);
            this.pnlFrame.Controls.Add(this.cmbStatus);
            this.pnlFrame.Controls.Add(this.lblStatus);
            this.pnlFrame.Controls.Add(this.cmbPaymentMethod);
            this.pnlFrame.Controls.Add(this.lblPyamentMethod);
            this.pnlFrame.Controls.Add(this.cmbMedicine);
            this.pnlFrame.Controls.Add(this.dtpPurchase);
            this.pnlFrame.Controls.Add(this.lblPurchaseDate);
            this.pnlFrame.Controls.Add(this.txtQuantity);
            this.pnlFrame.Controls.Add(this.lblQuantity);
            this.pnlFrame.Controls.Add(this.txtDesc);
            this.pnlFrame.Controls.Add(this.lblDesc);
            this.pnlFrame.Controls.Add(this.txtPurchaseCode);
            this.pnlFrame.Controls.Add(this.lblPurchaseCode);
            this.pnlFrame.Controls.Add(this.cmbSupplier);
            this.pnlFrame.Controls.Add(this.lblSupplier);
            this.pnlFrame.Controls.Add(this.cmbCategory);
            this.pnlFrame.Controls.Add(this.lblCategory);
            this.pnlFrame.Controls.Add(this.HSeparator1);
            this.pnlFrame.Controls.Add(this.lblMedicineName);
            this.pnlFrame.Controls.Add(this.lblEditPurchase);
            this.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(554, 681);
            this.pnlFrame.TabIndex = 4;
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
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtGrandTotal.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtGrandTotal.BorderColor = System.Drawing.Color.Silver;
            this.txtGrandTotal.BorderSize = 1;
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtGrandTotal.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtGrandTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGrandTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtGrandTotal.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtGrandTotal.Location = new System.Drawing.Point(284, 569);
            this.txtGrandTotal.MaxLength = 9;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PasswordChar = '\0';
            this.txtGrandTotal.Radius = 6;
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.Size = new System.Drawing.Size(240, 32);
            this.txtGrandTotal.TabIndex = 3;
            this.txtGrandTotal.TextOffsetX = 6;
            this.txtGrandTotal.Enter += new System.EventHandler(this.txtGrandTotal_Enter);
            this.txtGrandTotal.Leave += new System.EventHandler(this.txtGrandTotal_Leave);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblGrandTotal.Location = new System.Drawing.Point(280, 535);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(127, 21);
            this.lblGrandTotal.TabIndex = 88;
            this.lblGrandTotal.Text = "Загальна сумма";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStatus.BorderColor = System.Drawing.Color.Silver;
            this.cmbStatus.BorderSize = 1;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "- Статус -",
            "В очікувані",
            "Сплачено"});
            this.cmbStatus.Location = new System.Drawing.Point(30, 571);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbStatus.Radius = 6;
            this.cmbStatus.Size = new System.Drawing.Size(240, 30);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.Enter += new System.EventHandler(this.cmbStatus_Enter);
            this.cmbStatus.Leave += new System.EventHandler(this.cmbStatus_Leave);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(26, 537);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 21);
            this.lblStatus.TabIndex = 86;
            this.lblStatus.Text = "Статус";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPaymentMethod.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPaymentMethod.BorderColor = System.Drawing.Color.Silver;
            this.cmbPaymentMethod.BorderSize = 1;
            this.cmbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPaymentMethod.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "- Оберіть спосіб оплати -",
            "Готівка",
            "Чек"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(30, 492);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbPaymentMethod.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPaymentMethod.Radius = 6;
            this.cmbPaymentMethod.Size = new System.Drawing.Size(240, 30);
            this.cmbPaymentMethod.TabIndex = 1;
            this.cmbPaymentMethod.Enter += new System.EventHandler(this.cmbPaymentMethod_Enter);
            this.cmbPaymentMethod.Leave += new System.EventHandler(this.cmbPaymentMethod_Leave);
            // 
            // lblPyamentMethod
            // 
            this.lblPyamentMethod.AutoSize = true;
            this.lblPyamentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPyamentMethod.ForeColor = System.Drawing.Color.DimGray;
            this.lblPyamentMethod.Location = new System.Drawing.Point(26, 458);
            this.lblPyamentMethod.Name = "lblPyamentMethod";
            this.lblPyamentMethod.Size = new System.Drawing.Size(117, 21);
            this.lblPyamentMethod.TabIndex = 84;
            this.lblPyamentMethod.Text = "Спосіб оплати";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.BackColor = System.Drawing.Color.Transparent;
            this.cmbMedicine.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMedicine.BorderColor = System.Drawing.Color.Silver;
            this.cmbMedicine.BorderSize = 1;
            this.cmbMedicine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicine.Enabled = false;
            this.cmbMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMedicine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbMedicine.ForeColor = System.Drawing.Color.DimGray;
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Items.AddRange(new object[] {
            "- Назва медикаменту -"});
            this.cmbMedicine.Location = new System.Drawing.Point(30, 120);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbMedicine.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbMedicine.Radius = 6;
            this.cmbMedicine.Size = new System.Drawing.Size(494, 30);
            this.cmbMedicine.TabIndex = 0;
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.BackColor = System.Drawing.Color.Transparent;
            this.dtpPurchase.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpPurchase.BorderColor = System.Drawing.Color.Silver;
            this.dtpPurchase.BorderSize = 1;
            this.dtpPurchase.CustomFormat = null;
            this.dtpPurchase.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPurchase.Enabled = false;
            this.dtpPurchase.FocusedColor = System.Drawing.Color.Transparent;
            this.dtpPurchase.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpPurchase.ForeColor = System.Drawing.Color.DimGray;
            this.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchase.Location = new System.Drawing.Point(284, 490);
            this.dtpPurchase.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPurchase.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpPurchase.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.dtpPurchase.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtpPurchase.OnPressedColor = System.Drawing.Color.Black;
            this.dtpPurchase.Radius = 6;
            this.dtpPurchase.Size = new System.Drawing.Size(240, 32);
            this.dtpPurchase.TabIndex = 8;
            this.dtpPurchase.Text = "2/9/2021";
            this.dtpPurchase.Value = new System.DateTime(2021, 2, 9, 21, 28, 19, 83);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPurchaseDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblPurchaseDate.Location = new System.Drawing.Point(280, 456);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(107, 21);
            this.lblPurchaseDate.TabIndex = 80;
            this.lblPurchaseDate.Text = "Дата закупки";
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
            this.txtQuantity.Location = new System.Drawing.Point(284, 280);
            this.txtQuantity.MaxLength = 9;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.Radius = 6;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(240, 32);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "Введіть кількість";
            this.txtQuantity.TextOffsetX = 6;
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(282, 246);
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
            this.txtDesc.Location = new System.Drawing.Point(30, 363);
            this.txtDesc.MaxLength = 256;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.Radius = 6;
            this.txtDesc.SelectedText = "";
            this.txtDesc.Size = new System.Drawing.Size(494, 80);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.TextOffsetX = 6;
            this.txtDesc.Enter += new System.EventHandler(this.txtDesc_Enter);
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(26, 329);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(49, 21);
            this.lblDesc.TabIndex = 78;
            this.lblDesc.Text = "Опис";
            // 
            // txtPurchaseCode
            // 
            this.txtPurchaseCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchaseCode.BackColor = System.Drawing.Color.Transparent;
            this.txtPurchaseCode.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchaseCode.BorderColor = System.Drawing.Color.Silver;
            this.txtPurchaseCode.BorderSize = 1;
            this.txtPurchaseCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchaseCode.Enabled = false;
            this.txtPurchaseCode.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchaseCode.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtPurchaseCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPurchaseCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPurchaseCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtPurchaseCode.Location = new System.Drawing.Point(30, 280);
            this.txtPurchaseCode.MaxLength = 16;
            this.txtPurchaseCode.Name = "txtPurchaseCode";
            this.txtPurchaseCode.PasswordChar = '\0';
            this.txtPurchaseCode.Radius = 6;
            this.txtPurchaseCode.SelectedText = "";
            this.txtPurchaseCode.Size = new System.Drawing.Size(240, 32);
            this.txtPurchaseCode.TabIndex = 3;
            this.txtPurchaseCode.Text = "Введіть код";
            this.txtPurchaseCode.TextOffsetX = 6;
            // 
            // lblPurchaseCode
            // 
            this.lblPurchaseCode.AutoSize = true;
            this.lblPurchaseCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPurchaseCode.ForeColor = System.Drawing.Color.DimGray;
            this.lblPurchaseCode.Location = new System.Drawing.Point(26, 246);
            this.lblPurchaseCode.Name = "lblPurchaseCode";
            this.lblPurchaseCode.Size = new System.Drawing.Size(94, 21);
            this.lblPurchaseCode.TabIndex = 77;
            this.lblPurchaseCode.Text = "Код купівлі";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSupplier.BorderColor = System.Drawing.Color.Silver;
            this.cmbSupplier.BorderSize = 1;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Enabled = false;
            this.cmbSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "- Постачальник -"});
            this.cmbSupplier.Location = new System.Drawing.Point(284, 199);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbSupplier.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSupplier.Radius = 6;
            this.cmbSupplier.Size = new System.Drawing.Size(240, 30);
            this.cmbSupplier.TabIndex = 2;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.lblSupplier.Location = new System.Drawing.Point(280, 165);
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
            this.cmbCategory.Enabled = false;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "- Категорія -"});
            this.cmbCategory.Location = new System.Drawing.Point(30, 199);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCategory.Radius = 6;
            this.cmbCategory.Size = new System.Drawing.Size(240, 30);
            this.cmbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(26, 165);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 21);
            this.lblCategory.TabIndex = 75;
            this.lblCategory.Text = "Категорія";
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
            // lblEditPurchase
            // 
            this.lblEditPurchase.AutoSize = true;
            this.lblEditPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPurchase.ForeColor = System.Drawing.Color.DimGray;
            this.lblEditPurchase.Location = new System.Drawing.Point(22, 16);
            this.lblEditPurchase.Name = "lblEditPurchase";
            this.lblEditPurchase.Size = new System.Drawing.Size(261, 32);
            this.lblEditPurchase.TabIndex = 72;
            this.lblEditPurchase.Text = "Редагувати закупівлю";
            // 
            // frmEditPurchase
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
            this.Name = "frmEditPurchase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%title%";
            this.Activated += new System.EventHandler(this.frmEditPurchase_Activated);
            this.pnlFrame.ResumeLayout(false);
            this.pnlFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlFrame;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaTextBox txtGrandTotal;
        private Guna.UI.WinForms.GunaLabel lblGrandTotal;
        private Guna.UI.WinForms.GunaComboBox cmbStatus;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaComboBox cmbPaymentMethod;
        private Guna.UI.WinForms.GunaLabel lblPyamentMethod;
        private Guna.UI.WinForms.GunaComboBox cmbMedicine;
        private Guna.UI.WinForms.GunaDateTimePicker dtpPurchase;
        private Guna.UI.WinForms.GunaLabel lblPurchaseDate;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaLabel lblQuantity;
        private Guna.UI.WinForms.GunaTextBox txtDesc;
        private Guna.UI.WinForms.GunaLabel lblDesc;
        private Guna.UI.WinForms.GunaTextBox txtPurchaseCode;
        private Guna.UI.WinForms.GunaLabel lblPurchaseCode;
        private Guna.UI.WinForms.GunaComboBox cmbSupplier;
        private Guna.UI.WinForms.GunaLabel lblSupplier;
        private Guna.UI.WinForms.GunaComboBox cmbCategory;
        private Guna.UI.WinForms.GunaLabel lblCategory;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblMedicineName;
        private Guna.UI.WinForms.GunaLabel lblEditPurchase;
    }
}