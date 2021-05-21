
namespace pharma_
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.pnlFrame = new Guna.UI.WinForms.GunaLinePanel();
            this.btnOK = new Guna.UI.WinForms.GunaButton();
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            this.ControlButtonClose = new Guna.UI.WinForms.GunaControlBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.pctBoxWindowIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxWindowIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFrame
            // 
            this.pnlFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrame.Controls.Add(this.btnOK);
            this.pnlFrame.Controls.Add(this.lblMessage);
            this.pnlFrame.Controls.Add(this.ControlButtonClose);
            this.pnlFrame.Controls.Add(this.lblTitle);
            this.pnlFrame.Controls.Add(this.pctBoxWindowIcon);
            this.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrame.LineColor = System.Drawing.Color.White;
            this.pnlFrame.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(460, 280);
            this.pnlFrame.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Animated = true;
            this.btnOK.AnimationHoverSpeed = 0.07F;
            this.btnOK.AnimationSpeed = 0.03F;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.White;
            this.btnOK.BorderColor = System.Drawing.Color.Silver;
            this.btnOK.BorderSize = 1;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.FocusedColor = System.Drawing.Color.Empty;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOK.ForeColor = System.Drawing.Color.Gray;
            this.btnOK.Image = null;
            this.btnOK.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOK.Location = new System.Drawing.Point(176, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBaseColor = System.Drawing.Color.Empty;
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnOK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOK.OnHoverImage = null;
            this.btnOK.OnPressedColor = System.Drawing.Color.Black;
            this.btnOK.Radius = 12;
            this.btnOK.Size = new System.Drawing.Size(110, 28);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMessage.Location = new System.Drawing.Point(10, 50);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(436, 180);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "%message_text%";
            // 
            // ControlButtonClose
            // 
            this.ControlButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlButtonClose.Animated = true;
            this.ControlButtonClose.AnimationHoverSpeed = 0.07F;
            this.ControlButtonClose.AnimationSpeed = 0.03F;
            this.ControlButtonClose.IconColor = System.Drawing.Color.Black;
            this.ControlButtonClose.IconSize = 15F;
            this.ControlButtonClose.Location = new System.Drawing.Point(412, 1);
            this.ControlButtonClose.Name = "ControlButtonClose";
            this.ControlButtonClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.ControlButtonClose.OnHoverIconColor = System.Drawing.Color.White;
            this.ControlButtonClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.ControlButtonClose.Size = new System.Drawing.Size(45, 29);
            this.ControlButtonClose.TabIndex = 6;
            this.ControlButtonClose.TabStop = false;
            this.Tips.SetToolTip(this.ControlButtonClose, "Закрити");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitle.Location = new System.Drawing.Point(40, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 21);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "%title%";
            // 
            // pctBoxWindowIcon
            // 
            this.pctBoxWindowIcon.BaseColor = System.Drawing.Color.White;
            this.pctBoxWindowIcon.Location = new System.Drawing.Point(8, 8);
            this.pctBoxWindowIcon.Name = "pctBoxWindowIcon";
            this.pctBoxWindowIcon.Size = new System.Drawing.Size(30, 30);
            this.pctBoxWindowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxWindowIcon.TabIndex = 0;
            this.pctBoxWindowIcon.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlFrame;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.pnlFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            this.pnlFrame.ResumeLayout(false);
            this.pnlFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxWindowIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel pnlFrame;
        private Guna.UI.WinForms.GunaButton btnOK;
        private Guna.UI.WinForms.GunaDragControl DragControl;
        private System.Windows.Forms.ToolTip Tips;
        private Guna.UI.WinForms.GunaControlBox ControlButtonClose;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaPictureBox pctBoxWindowIcon;
        private Guna.UI.WinForms.GunaLabel lblMessage;
    }
}