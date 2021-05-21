
namespace pharma_
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlFrame = new Guna.UI.WinForms.GunaPanel();
            this.pnlControl = new Guna.UI.WinForms.GunaPanel();
            this.pnlHeader = new Guna.UI.WinForms.GunaPanel();
            this.btnPurchase = new Guna.UI.WinForms.GunaButton();
            this.pctBoxUserPicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblUserName = new Guna.UI.WinForms.GunaLabel();
            this.btnSighnOut = new Guna.UI.WinForms.GunaButton();
            this.btnEventList = new Guna.UI.WinForms.GunaButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.btnSuppliers = new Guna.UI.WinForms.GunaButton();
            this.pctBoxPlus = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMedicine = new Guna.UI.WinForms.GunaButton();
            this.btnCategory = new Guna.UI.WinForms.GunaButton();
            this.lblAppName = new Guna.UI.WinForms.GunaLabel();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.btnRacks = new Guna.UI.WinForms.GunaButton();
            this.pnlFrame.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFrame.Controls.Add(this.pnlControl);
            this.pnlFrame.Controls.Add(this.pnlHeader);
            this.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1184, 660);
            this.pnlFrame.TabIndex = 0;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.BackColor = System.Drawing.Color.Gray;
            this.pnlControl.Location = new System.Drawing.Point(0, 62);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1184, 598);
            this.pnlControl.TabIndex = 4;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnEventList);
            this.pnlHeader.Controls.Add(this.btnPurchase);
            this.pnlHeader.Controls.Add(this.btnSuppliers);
            this.pnlHeader.Controls.Add(this.btnRacks);
            this.pnlHeader.Controls.Add(this.pctBoxUserPicture);
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Controls.Add(this.btnSighnOut);
            this.pnlHeader.Controls.Add(this.btnDashboard);
            this.pnlHeader.Controls.Add(this.pctBoxPlus);
            this.pnlHeader.Controls.Add(this.btnMedicine);
            this.pnlHeader.Controls.Add(this.btnCategory);
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1184, 63);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Animated = true;
            this.btnPurchase.AnimationHoverSpeed = 0.07F;
            this.btnPurchase.AnimationSpeed = 0.03F;
            this.btnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchase.BaseColor = System.Drawing.Color.White;
            this.btnPurchase.BorderColor = System.Drawing.Color.Black;
            this.btnPurchase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPurchase.FocusedColor = System.Drawing.Color.Empty;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPurchase.ForeColor = System.Drawing.Color.Gray;
            this.btnPurchase.Image = global::pharma_.Properties.Resources.cart;
            this.btnPurchase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPurchase.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPurchase.Location = new System.Drawing.Point(458, 8);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnPurchase.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPurchase.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnPurchase.OnHoverImage = global::pharma_.Properties.Resources.cart_hover;
            this.btnPurchase.OnPressedColor = System.Drawing.Color.Black;
            this.btnPurchase.Radius = 6;
            this.btnPurchase.Size = new System.Drawing.Size(46, 46);
            this.btnPurchase.TabIndex = 14;
            this.Tips.SetToolTip(this.btnPurchase, "Закупівля");
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // pctBoxUserPicture
            // 
            this.pctBoxUserPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxUserPicture.BaseColor = System.Drawing.Color.White;
            this.pctBoxUserPicture.Image = global::pharma_.Properties.Resources.user;
            this.pctBoxUserPicture.Location = new System.Drawing.Point(1101, 12);
            this.pctBoxUserPicture.Name = "pctBoxUserPicture";
            this.pctBoxUserPicture.Size = new System.Drawing.Size(36, 36);
            this.pctBoxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxUserPicture.TabIndex = 5;
            this.pctBoxUserPicture.TabStop = false;
            this.pctBoxUserPicture.UseTransfarantBackground = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoEllipsis = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserName.Location = new System.Drawing.Point(847, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(248, 23);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Вітаємо, %user_name%";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tips.SetToolTip(this.lblUserName, "Налаштування аккаунту");
            this.lblUserName.Click += new System.EventHandler(this.lblAccountName_Click);
            this.lblUserName.MouseEnter += new System.EventHandler(this.lblUserName_MouseEnter);
            this.lblUserName.MouseLeave += new System.EventHandler(this.lblUserName_MouseLeave);
            // 
            // btnSighnOut
            // 
            this.btnSighnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSighnOut.Animated = true;
            this.btnSighnOut.AnimationHoverSpeed = 0.07F;
            this.btnSighnOut.AnimationSpeed = 0.03F;
            this.btnSighnOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSighnOut.BaseColor = System.Drawing.Color.White;
            this.btnSighnOut.BorderColor = System.Drawing.Color.Black;
            this.btnSighnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSighnOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSighnOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnSighnOut.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSighnOut.ForeColor = System.Drawing.Color.Gray;
            this.btnSighnOut.Image = global::pharma_.Properties.Resources.sighn_out;
            this.btnSighnOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSighnOut.ImageSize = new System.Drawing.Size(22, 26);
            this.btnSighnOut.Location = new System.Drawing.Point(1142, 9);
            this.btnSighnOut.Name = "btnSighnOut";
            this.btnSighnOut.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSighnOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSighnOut.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSighnOut.OnHoverImage = null;
            this.btnSighnOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnSighnOut.Radius = 6;
            this.btnSighnOut.Size = new System.Drawing.Size(32, 43);
            this.btnSighnOut.TabIndex = 13;
            this.Tips.SetToolTip(this.btnSighnOut, "Вийти з системи");
            this.btnSighnOut.Click += new System.EventHandler(this.btnSighnOut_Click);
            // 
            // btnEventList
            // 
            this.btnEventList.Animated = true;
            this.btnEventList.AnimationHoverSpeed = 0.07F;
            this.btnEventList.AnimationSpeed = 0.03F;
            this.btnEventList.BackColor = System.Drawing.Color.Transparent;
            this.btnEventList.BaseColor = System.Drawing.Color.White;
            this.btnEventList.BorderColor = System.Drawing.Color.Black;
            this.btnEventList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEventList.FocusedColor = System.Drawing.Color.Empty;
            this.btnEventList.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEventList.ForeColor = System.Drawing.Color.Gray;
            this.btnEventList.Image = global::pharma_.Properties.Resources.note;
            this.btnEventList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEventList.ImageSize = new System.Drawing.Size(22, 22);
            this.btnEventList.Location = new System.Drawing.Point(510, 8);
            this.btnEventList.Name = "btnEventList";
            this.btnEventList.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnEventList.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEventList.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnEventList.OnHoverImage = global::pharma_.Properties.Resources.note_hover;
            this.btnEventList.OnPressedColor = System.Drawing.Color.Black;
            this.btnEventList.Radius = 6;
            this.btnEventList.Size = new System.Drawing.Size(46, 46);
            this.btnEventList.TabIndex = 12;
            this.Tips.SetToolTip(this.btnEventList, "Список подій");
            this.btnEventList.Click += new System.EventHandler(this.btnEventList_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BaseColor = System.Drawing.Color.White;
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Gray;
            this.btnDashboard.Image = global::pharma_.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.ImageSize = new System.Drawing.Size(22, 22);
            this.btnDashboard.Location = new System.Drawing.Point(198, 8);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverImage = global::pharma_.Properties.Resources.dashboard_hover;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Radius = 6;
            this.btnDashboard.Size = new System.Drawing.Size(46, 46);
            this.btnDashboard.TabIndex = 5;
            this.Tips.SetToolTip(this.btnDashboard, "Статистика");
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Animated = true;
            this.btnSuppliers.AnimationHoverSpeed = 0.07F;
            this.btnSuppliers.AnimationSpeed = 0.03F;
            this.btnSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnSuppliers.BaseColor = System.Drawing.Color.White;
            this.btnSuppliers.BorderColor = System.Drawing.Color.Black;
            this.btnSuppliers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuppliers.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSuppliers.ForeColor = System.Drawing.Color.Gray;
            this.btnSuppliers.Image = global::pharma_.Properties.Resources.caduceus;
            this.btnSuppliers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuppliers.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSuppliers.Location = new System.Drawing.Point(406, 8);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnSuppliers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuppliers.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSuppliers.OnHoverImage = global::pharma_.Properties.Resources.caduceus_hover;
            this.btnSuppliers.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuppliers.Radius = 6;
            this.btnSuppliers.Size = new System.Drawing.Size(46, 46);
            this.btnSuppliers.TabIndex = 11;
            this.Tips.SetToolTip(this.btnSuppliers, "Постачальники");
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // pctBoxPlus
            // 
            this.pctBoxPlus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pctBoxPlus.BaseColor = System.Drawing.Color.White;
            this.pctBoxPlus.Image = global::pharma_.Properties.Resources.plus;
            this.pctBoxPlus.Location = new System.Drawing.Point(142, 4);
            this.pctBoxPlus.Name = "pctBoxPlus";
            this.pctBoxPlus.Size = new System.Drawing.Size(32, 32);
            this.pctBoxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxPlus.TabIndex = 6;
            this.pctBoxPlus.TabStop = false;
            // 
            // btnMedicine
            // 
            this.btnMedicine.Animated = true;
            this.btnMedicine.AnimationHoverSpeed = 0.07F;
            this.btnMedicine.AnimationSpeed = 0.03F;
            this.btnMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicine.BaseColor = System.Drawing.Color.White;
            this.btnMedicine.BorderColor = System.Drawing.Color.Black;
            this.btnMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicine.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMedicine.ForeColor = System.Drawing.Color.Gray;
            this.btnMedicine.Image = global::pharma_.Properties.Resources.medicine;
            this.btnMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMedicine.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMedicine.Location = new System.Drawing.Point(354, 8);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicine.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnMedicine.OnHoverImage = global::pharma_.Properties.Resources.medicine_hover;
            this.btnMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedicine.Radius = 6;
            this.btnMedicine.Size = new System.Drawing.Size(46, 46);
            this.btnMedicine.TabIndex = 9;
            this.Tips.SetToolTip(this.btnMedicine, "Медикаменти");
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Animated = true;
            this.btnCategory.AnimationHoverSpeed = 0.07F;
            this.btnCategory.AnimationSpeed = 0.03F;
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.BaseColor = System.Drawing.Color.White;
            this.btnCategory.BorderColor = System.Drawing.Color.Black;
            this.btnCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCategory.ForeColor = System.Drawing.Color.Gray;
            this.btnCategory.Image = global::pharma_.Properties.Resources.tag;
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCategory.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCategory.Location = new System.Drawing.Point(250, 8);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCategory.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnCategory.OnHoverImage = global::pharma_.Properties.Resources.tag_hover;
            this.btnCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnCategory.Radius = 6;
            this.btnCategory.Size = new System.Drawing.Size(46, 46);
            this.btnCategory.TabIndex = 8;
            this.Tips.SetToolTip(this.btnCategory, "Категорії");
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.Black;
            this.lblAppName.Location = new System.Drawing.Point(16, 6);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(141, 47);
            this.lblAppName.TabIndex = 5;
            this.lblAppName.Text = "pharma";
            // 
            // btnRacks
            // 
            this.btnRacks.Animated = true;
            this.btnRacks.AnimationHoverSpeed = 0.07F;
            this.btnRacks.AnimationSpeed = 0.03F;
            this.btnRacks.BackColor = System.Drawing.Color.Transparent;
            this.btnRacks.BaseColor = System.Drawing.Color.White;
            this.btnRacks.BorderColor = System.Drawing.Color.Black;
            this.btnRacks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRacks.FocusedColor = System.Drawing.Color.Empty;
            this.btnRacks.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRacks.ForeColor = System.Drawing.Color.Gray;
            this.btnRacks.Image = global::pharma_.Properties.Resources.stack;
            this.btnRacks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRacks.ImageSize = new System.Drawing.Size(22, 22);
            this.btnRacks.Location = new System.Drawing.Point(302, 8);
            this.btnRacks.Name = "btnRacks";
            this.btnRacks.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnRacks.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRacks.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRacks.OnHoverImage = global::pharma_.Properties.Resources.stack_hover;
            this.btnRacks.OnPressedColor = System.Drawing.Color.Black;
            this.btnRacks.Radius = 6;
            this.btnRacks.Size = new System.Drawing.Size(46, 46);
            this.btnRacks.TabIndex = 15;
            this.Tips.SetToolTip(this.btnRacks, "Стелажі");
            this.btnRacks.Click += new System.EventHandler(this.btnRacks_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 660);
            this.Controls.Add(this.pnlFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%title%";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlFrame.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPlus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlFrame;
        private Guna.UI.WinForms.GunaPanel pnlHeader;
        private Guna.UI.WinForms.GunaCirclePictureBox pctBoxUserPicture;
        private Guna.UI.WinForms.GunaLabel lblUserName;
        private Guna.UI.WinForms.GunaPictureBox pctBoxPlus;
        private Guna.UI.WinForms.GunaLabel lblAppName;
        private System.Windows.Forms.ToolTip Tips;
        private Guna.UI.WinForms.GunaButton btnDashboard;
        private Guna.UI.WinForms.GunaButton btnMedicine;
        private Guna.UI.WinForms.GunaButton btnCategory;
        private Guna.UI.WinForms.GunaButton btnEventList;
        private Guna.UI.WinForms.GunaButton btnSuppliers;
        private Guna.UI.WinForms.GunaPanel pnlControl;
        private Guna.UI.WinForms.GunaButton btnSighnOut;
        private Guna.UI.WinForms.GunaButton btnPurchase;
        private Guna.UI.WinForms.GunaButton btnRacks;
    }
}