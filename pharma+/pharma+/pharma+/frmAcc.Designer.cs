
namespace pharma_
{
    partial class frmAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcc));
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.txtPasswordConfirmation = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.lblSecurity = new Guna.UI.WinForms.GunaLabel();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.lblContactInfo = new Guna.UI.WinForms.GunaLabel();
            this.txtBirthDate = new Guna.UI.WinForms.GunaTextBox();
            this.txtFullName = new Guna.UI.WinForms.GunaTextBox();
            this.lblPersonalInfo = new Guna.UI.WinForms.GunaLabel();
            this.lblRegisterDate = new Guna.UI.WinForms.GunaLabel();
            this.pnlPictureFrame = new Guna.UI.WinForms.GunaPanel();
            this.btnThemeChange = new Guna.UI.WinForms.GunaButton();
            this.btnDeletePicture = new Guna.UI.WinForms.GunaButton();
            this.btnNewPicture = new Guna.UI.WinForms.GunaButton();
            this.pctBoxUserPicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblDesc = new Guna.UI.WinForms.GunaLabel();
            this.lblUserName = new Guna.UI.WinForms.GunaLabel();
            this.lblAccount = new Guna.UI.WinForms.GunaLabel();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.pctBoxDividerRight = new Guna.UI.WinForms.GunaPictureBox();
            this.pctBoxPasswordConfirm = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlPictureFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDividerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPasswordConfirm)).BeginInit();
            this.SuspendLayout();
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
            this.btnUpdate.Location = new System.Drawing.Point(486, 534);
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
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordConfirmation.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordConfirmation.BorderColor = System.Drawing.Color.Silver;
            this.txtPasswordConfirmation.BorderSize = 1;
            this.txtPasswordConfirmation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordConfirmation.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordConfirmation.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtPasswordConfirmation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordConfirmation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPasswordConfirmation.ForeColor = System.Drawing.Color.DimGray;
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(308, 475);
            this.txtPasswordConfirmation.MaxLength = 256;
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '\0';
            this.txtPasswordConfirmation.Radius = 6;
            this.txtPasswordConfirmation.SelectedText = "";
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(320, 39);
            this.txtPasswordConfirmation.TabIndex = 5;
            this.txtPasswordConfirmation.Text = "Підтвердити пароль";
            this.txtPasswordConfirmation.TextOffsetX = 6;
            this.txtPasswordConfirmation.TextChanged += new System.EventHandler(this.txtPasswordConfirmation_TextChanged);
            this.txtPasswordConfirmation.Enter += new System.EventHandler(this.txtPasswordConfirmation_Enter);
            this.txtPasswordConfirmation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordConfirmation_KeyPress);
            this.txtPasswordConfirmation.Leave += new System.EventHandler(this.txtPasswordConfirmation_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(308, 420);
            this.txtPassword.MaxLength = 256;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 6;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(320, 39);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Пароль";
            this.txtPassword.TextOffsetX = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSecurity.ForeColor = System.Drawing.Color.DimGray;
            this.lblSecurity.Location = new System.Drawing.Point(305, 385);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(68, 20);
            this.lblSecurity.TabIndex = 35;
            this.lblSecurity.Text = "Безпека:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.Location = new System.Drawing.Point(308, 323);
            this.txtPhone.MaxLength = 256;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 6;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(320, 39);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "Телефон";
            this.txtPhone.TextOffsetX = 6;
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(308, 268);
            this.txtEmail.MaxLength = 256;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 6;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(320, 39);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Електронна пошта";
            this.txtEmail.TextOffsetX = 6;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblContactInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblContactInfo.Location = new System.Drawing.Point(305, 233);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(168, 20);
            this.lblContactInfo.TabIndex = 32;
            this.lblContactInfo.Text = "Контактна інформація:";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.txtBirthDate.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBirthDate.BorderColor = System.Drawing.Color.Silver;
            this.txtBirthDate.BorderSize = 1;
            this.txtBirthDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthDate.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBirthDate.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtBirthDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBirthDate.ForeColor = System.Drawing.Color.DimGray;
            this.txtBirthDate.Location = new System.Drawing.Point(308, 171);
            this.txtBirthDate.MaxLength = 256;
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.PasswordChar = '\0';
            this.txtBirthDate.Radius = 6;
            this.txtBirthDate.SelectedText = "";
            this.txtBirthDate.Size = new System.Drawing.Size(320, 39);
            this.txtBirthDate.TabIndex = 1;
            this.txtBirthDate.Text = "День народження";
            this.txtBirthDate.TextOffsetX = 6;
            this.txtBirthDate.Enter += new System.EventHandler(this.txtBirthDate_Enter);
            this.txtBirthDate.Leave += new System.EventHandler(this.txtBirthDate_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.BorderColor = System.Drawing.Color.Silver;
            this.txtFullName.BorderSize = 1;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtFullName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFullName.Location = new System.Drawing.Point(308, 116);
            this.txtFullName.MaxLength = 256;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.Radius = 6;
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(320, 39);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Text = "Ф.І.О";
            this.txtFullName.TextOffsetX = 6;
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPersonalInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPersonalInfo.Location = new System.Drawing.Point(305, 81);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(191, 20);
            this.lblPersonalInfo.TabIndex = 29;
            this.lblPersonalInfo.Text = "Персональна інформація:";
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRegisterDate.ForeColor = System.Drawing.Color.Gray;
            this.lblRegisterDate.Location = new System.Drawing.Point(33, 447);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(105, 19);
            this.lblRegisterDate.TabIndex = 28;
            this.lblRegisterDate.Text = "Дата реєстрації";
            // 
            // pnlPictureFrame
            // 
            this.pnlPictureFrame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPictureFrame.Controls.Add(this.btnThemeChange);
            this.pnlPictureFrame.Controls.Add(this.btnDeletePicture);
            this.pnlPictureFrame.Controls.Add(this.btnNewPicture);
            this.pnlPictureFrame.Controls.Add(this.pctBoxUserPicture);
            this.pnlPictureFrame.Location = new System.Drawing.Point(19, 86);
            this.pnlPictureFrame.Name = "pnlPictureFrame";
            this.pnlPictureFrame.Size = new System.Drawing.Size(260, 348);
            this.pnlPictureFrame.TabIndex = 27;
            // 
            // btnThemeChange
            // 
            this.btnThemeChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemeChange.AnimationHoverSpeed = 0.07F;
            this.btnThemeChange.AnimationSpeed = 0.03F;
            this.btnThemeChange.BackColor = System.Drawing.Color.Transparent;
            this.btnThemeChange.BaseColor = System.Drawing.Color.White;
            this.btnThemeChange.BorderColor = System.Drawing.Color.LightGray;
            this.btnThemeChange.BorderSize = 1;
            this.btnThemeChange.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemeChange.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemeChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemeChange.ForeColor = System.Drawing.Color.White;
            this.btnThemeChange.Image = global::pharma_.Properties.Resources.day;
            this.btnThemeChange.ImageOffsetX = 8;
            this.btnThemeChange.ImageSize = new System.Drawing.Size(18, 18);
            this.btnThemeChange.Location = new System.Drawing.Point(14, 16);
            this.btnThemeChange.Name = "btnThemeChange";
            this.btnThemeChange.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnThemeChange.OnHoverBorderColor = System.Drawing.Color.LightGray;
            this.btnThemeChange.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemeChange.OnHoverImage = null;
            this.btnThemeChange.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnThemeChange.Radius = 8;
            this.btnThemeChange.Size = new System.Drawing.Size(42, 20);
            this.btnThemeChange.TabIndex = 40;
            this.btnThemeChange.Click += new System.EventHandler(this.btnThemeChange_Click);
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.Animated = true;
            this.btnDeletePicture.AnimationHoverSpeed = 0.07F;
            this.btnDeletePicture.AnimationSpeed = 0.03F;
            this.btnDeletePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePicture.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePicture.BorderColor = System.Drawing.Color.Black;
            this.btnDeletePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePicture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeletePicture.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeletePicture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeletePicture.ForeColor = System.Drawing.Color.White;
            this.btnDeletePicture.Image = global::pharma_.Properties.Resources.erase;
            this.btnDeletePicture.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeletePicture.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeletePicture.Location = new System.Drawing.Point(220, 10);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnDeletePicture.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeletePicture.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeletePicture.OnHoverImage = null;
            this.btnDeletePicture.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeletePicture.Radius = 10;
            this.btnDeletePicture.Size = new System.Drawing.Size(30, 30);
            this.btnDeletePicture.TabIndex = 40;
            this.Tips.SetToolTip(this.btnDeletePicture, "Видалити зображення");
            this.btnDeletePicture.Click += new System.EventHandler(this.btnDeletePicture_Click);
            // 
            // btnNewPicture
            // 
            this.btnNewPicture.Animated = true;
            this.btnNewPicture.AnimationHoverSpeed = 0.07F;
            this.btnNewPicture.AnimationSpeed = 0.03F;
            this.btnNewPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPicture.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewPicture.BorderColor = System.Drawing.Color.Silver;
            this.btnNewPicture.BorderSize = 1;
            this.btnNewPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPicture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewPicture.FocusedColor = System.Drawing.Color.Empty;
            this.btnNewPicture.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNewPicture.ForeColor = System.Drawing.Color.Gray;
            this.btnNewPicture.Image = global::pharma_.Properties.Resources.photo;
            this.btnNewPicture.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNewPicture.ImageOffsetX = 6;
            this.btnNewPicture.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNewPicture.Location = new System.Drawing.Point(18, 286);
            this.btnNewPicture.Name = "btnNewPicture";
            this.btnNewPicture.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewPicture.OnHoverBorderColor = System.Drawing.Color.Silver;
            this.btnNewPicture.OnHoverForeColor = System.Drawing.Color.Gray;
            this.btnNewPicture.OnHoverImage = null;
            this.btnNewPicture.OnPressedColor = System.Drawing.Color.Black;
            this.btnNewPicture.Radius = 6;
            this.btnNewPicture.Size = new System.Drawing.Size(224, 42);
            this.btnNewPicture.TabIndex = 6;
            this.btnNewPicture.Text = "Нове зображення";
            this.btnNewPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewPicture.Click += new System.EventHandler(this.btnNewPicture_Click);
            // 
            // pctBoxUserPicture
            // 
            this.pctBoxUserPicture.BaseColor = System.Drawing.Color.White;
            this.pctBoxUserPicture.Image = global::pharma_.Properties.Resources.photo;
            this.pctBoxUserPicture.Location = new System.Drawing.Point(29, 48);
            this.pctBoxUserPicture.Name = "pctBoxUserPicture";
            this.pctBoxUserPicture.Size = new System.Drawing.Size(200, 200);
            this.pctBoxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxUserPicture.TabIndex = 5;
            this.pctBoxUserPicture.TabStop = false;
            this.pctBoxUserPicture.UseTransfarantBackground = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(14, 46);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(299, 20);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Редагуйте ваше ім\'я, зображення та інше.";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(130, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(170, 32);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.Text = "%user_name%";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblAccount.ForeColor = System.Drawing.Color.DimGray;
            this.lblAccount.Location = new System.Drawing.Point(12, 10);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(102, 32);
            this.lblAccount.TabIndex = 23;
            this.lblAccount.Text = "Аккаунт";
            // 
            // pctBoxDividerRight
            // 
            this.pctBoxDividerRight.BaseColor = System.Drawing.Color.White;
            this.pctBoxDividerRight.Image = global::pharma_.Properties.Resources.more_than;
            this.pctBoxDividerRight.Location = new System.Drawing.Point(114, 10);
            this.pctBoxDividerRight.Name = "pctBoxDividerRight";
            this.pctBoxDividerRight.Size = new System.Drawing.Size(12, 38);
            this.pctBoxDividerRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxDividerRight.TabIndex = 24;
            this.pctBoxDividerRight.TabStop = false;
            // 
            // pctBoxPasswordConfirm
            // 
            this.pctBoxPasswordConfirm.BackColor = System.Drawing.Color.White;
            this.pctBoxPasswordConfirm.BaseColor = System.Drawing.Color.Transparent;
            this.pctBoxPasswordConfirm.Location = new System.Drawing.Point(633, 482);
            this.pctBoxPasswordConfirm.Name = "pctBoxPasswordConfirm";
            this.pctBoxPasswordConfirm.Size = new System.Drawing.Size(26, 26);
            this.pctBoxPasswordConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxPasswordConfirm.TabIndex = 39;
            this.pctBoxPasswordConfirm.TabStop = false;
            // 
            // frmAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 591);
            this.Controls.Add(this.pctBoxDividerRight);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.pctBoxPasswordConfirm);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSecurity);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPersonalInfo);
            this.Controls.Add(this.lblRegisterDate);
            this.Controls.Add(this.pnlPictureFrame);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%title%";
            this.Activated += new System.EventHandler(this.frmAcc_Activated);
            this.pnlPictureFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDividerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPasswordConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox pctBoxPasswordConfirm;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaTextBox txtPasswordConfirmation;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaLabel lblSecurity;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaLabel lblContactInfo;
        private Guna.UI.WinForms.GunaTextBox txtBirthDate;
        private Guna.UI.WinForms.GunaTextBox txtFullName;
        private Guna.UI.WinForms.GunaLabel lblPersonalInfo;
        private Guna.UI.WinForms.GunaLabel lblRegisterDate;
        private Guna.UI.WinForms.GunaPanel pnlPictureFrame;
        private Guna.UI.WinForms.GunaButton btnNewPicture;
        private Guna.UI.WinForms.GunaCirclePictureBox pctBoxUserPicture;
        private Guna.UI.WinForms.GunaLabel lblDesc;
        private Guna.UI.WinForms.GunaLabel lblUserName;
        private Guna.UI.WinForms.GunaPictureBox pctBoxDividerRight;
        private Guna.UI.WinForms.GunaLabel lblAccount;
        private System.Windows.Forms.ToolTip Tips;
        private Guna.UI.WinForms.GunaButton btnDeletePicture;
        private Guna.UI.WinForms.GunaButton btnThemeChange;
    }
}