
namespace pharma_
{
    partial class ucLog
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
            this.lblAppName = new Guna.UI.WinForms.GunaLabel();
            this.txtLogin = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.chkShowPass = new Guna.UI.WinForms.GunaCheckBox();
            this.lblAppDesc = new Guna.UI.WinForms.GunaLabel();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.btnLog = new Guna.UI.WinForms.GunaButton();
            this.lblReg = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pctBoxLock = new Guna.UI.WinForms.GunaPictureBox();
            this.pctBoxUser = new Guna.UI.WinForms.GunaPictureBox();
            this.pctBoxPlus = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold);
            this.lblAppName.Location = new System.Drawing.Point(48, 22);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(260, 86);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "pharma";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtLogin.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.BorderColor = System.Drawing.Color.Silver;
            this.txtLogin.BorderSize = 1;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLogin.ForeColor = System.Drawing.Color.DimGray;
            this.txtLogin.Location = new System.Drawing.Point(63, 194);
            this.txtLogin.MaxLength = 256;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.Radius = 6;
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(271, 39);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Логін";
            this.txtLogin.TextOffsetX = 28;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
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
            this.txtPassword.Location = new System.Drawing.Point(63, 252);
            this.txtPassword.MaxLength = 256;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 6;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(271, 39);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Пароль";
            this.txtPassword.TextOffsetX = 28;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // chkShowPass
            // 
            this.chkShowPass.BaseColor = System.Drawing.Color.White;
            this.chkShowPass.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkShowPass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.chkShowPass.FillColor = System.Drawing.Color.White;
            this.chkShowPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkShowPass.Location = new System.Drawing.Point(73, 307);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(136, 21);
            this.chkShowPass.TabIndex = 2;
            this.chkShowPass.Text = "показати пароль";
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // lblAppDesc
            // 
            this.lblAppDesc.AutoSize = true;
            this.lblAppDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAppDesc.Location = new System.Drawing.Point(63, 120);
            this.lblAppDesc.Name = "lblAppDesc";
            this.lblAppDesc.Size = new System.Drawing.Size(204, 40);
            this.lblAppDesc.TabIndex = 7;
            this.lblAppDesc.Text = "Вітаємо, для авторизації\r\nвведіть ваш логін та пароль";
            // 
            // btnLog
            // 
            this.btnLog.Animated = true;
            this.btnLog.AnimationHoverSpeed = 0.07F;
            this.btnLog.AnimationSpeed = 0.03F;
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnLog.BorderColor = System.Drawing.Color.Black;
            this.btnLog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLog.FocusedColor = System.Drawing.Color.Empty;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Image = global::pharma_.Properties.Resources.arrow_right;
            this.btnLog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLog.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLog.Location = new System.Drawing.Point(282, 326);
            this.btnLog.Name = "btnLog";
            this.btnLog.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnLog.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLog.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLog.OnHoverImage = global::pharma_.Properties.Resources.arrow_right_hover;
            this.btnLog.OnPressedColor = System.Drawing.Color.Black;
            this.btnLog.Radius = 6;
            this.btnLog.Size = new System.Drawing.Size(52, 39);
            this.btnLog.TabIndex = 2;
            this.btnLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tips.SetToolTip(this.btnLog, "Авторизуватися");
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblReg.Location = new System.Drawing.Point(164, 558);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(63, 19);
            this.lblReg.TabIndex = 3;
            this.lblReg.Text = "Створіть";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(126, 530);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(142, 20);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Не маєте аккаунту?";
            // 
            // pctBoxLock
            // 
            this.pctBoxLock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pctBoxLock.BaseColor = System.Drawing.Color.Transparent;
            this.pctBoxLock.Image = global::pharma_.Properties.Resources._lock;
            this.pctBoxLock.Location = new System.Drawing.Point(70, 261);
            this.pctBoxLock.Name = "pctBoxLock";
            this.pctBoxLock.Size = new System.Drawing.Size(20, 20);
            this.pctBoxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxLock.TabIndex = 5;
            this.pctBoxLock.TabStop = false;
            // 
            // pctBoxUser
            // 
            this.pctBoxUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pctBoxUser.BaseColor = System.Drawing.Color.Transparent;
            this.pctBoxUser.Image = global::pharma_.Properties.Resources.user;
            this.pctBoxUser.Location = new System.Drawing.Point(70, 204);
            this.pctBoxUser.Name = "pctBoxUser";
            this.pctBoxUser.Size = new System.Drawing.Size(20, 20);
            this.pctBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxUser.TabIndex = 3;
            this.pctBoxUser.TabStop = false;
            // 
            // pctBoxPlus
            // 
            this.pctBoxPlus.BaseColor = System.Drawing.Color.White;
            this.pctBoxPlus.Image = global::pharma_.Properties.Resources.plus;
            this.pctBoxPlus.Location = new System.Drawing.Point(282, 20);
            this.pctBoxPlus.Name = "pctBoxPlus";
            this.pctBoxPlus.Size = new System.Drawing.Size(52, 52);
            this.pctBoxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxPlus.TabIndex = 1;
            this.pctBoxPlus.TabStop = false;
            // 
            // ucLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblAppDesc);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.pctBoxLock);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pctBoxUser);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.pctBoxPlus);
            this.Controls.Add(this.lblAppName);
            this.Name = "ucLog";
            this.Size = new System.Drawing.Size(390, 601);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblAppName;
        private Guna.UI.WinForms.GunaPictureBox pctBoxPlus;
        private Guna.UI.WinForms.GunaTextBox txtLogin;
        private Guna.UI.WinForms.GunaPictureBox pctBoxUser;
        private Guna.UI.WinForms.GunaPictureBox pctBoxLock;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaCheckBox chkShowPass;
        private Guna.UI.WinForms.GunaLabel lblAppDesc;
        private Guna.UI.WinForms.GunaButton btnLog;
        private System.Windows.Forms.ToolTip Tips;
        private Guna.UI.WinForms.GunaLabel lblReg;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
