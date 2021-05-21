using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.Lib;

namespace pharma_
{
    public enum Type { ERROR, WARNING, INFORMATION }

    public partial class MsgBox : Form
    {
        public MsgBox(Type type, string title, string message)
        {
            InitializeComponent();

            GraphicsHelper.ShadowForm(this);

            if (frmAcc.isNight == true) {

                ControlButtonClose.IconColor = Color.Gray;

                lblTitle.ForeColor = Color.Gray;
                lblMessage.ForeColor = Color.Gray;

                btnOK.BaseColor = Color.FromArgb(39, 39, 39);
                btnOK.BorderColor = Color.Gray;

                pnlFrame.BackColor = Color.FromArgb(18, 18, 18);
            } else {
                ControlButtonClose.IconColor = Color.Black;

                lblTitle.ForeColor = Color.Black;
                lblMessage.ForeColor = Color.Black;

                btnOK.BaseColor = Color.White;
                btnOK.BorderColor = Color.Silver;

                pnlFrame.BackColor = Color.White;
            }

            if (type == Type.ERROR) {
                pctBoxWindowIcon.Image = Properties.Resources.error;

                btnOK.OnHoverBorderColor = Color.FromArgb(244, 67, 54);
                btnOK.OnHoverBaseColor = Color.FromArgb(244, 67, 54);
            } 
            
            if (type == Type.WARNING) {
                pctBoxWindowIcon.Image = Properties.Resources.warning;

                btnOK.OnHoverBorderColor = Color.FromArgb(255, 202, 40);
                btnOK.OnHoverBaseColor = Color.FromArgb(255, 202, 40);
            } 
            
            if (type == Type.INFORMATION) {
                pctBoxWindowIcon.Image = Properties.Resources.info;

                btnOK.OnHoverBorderColor = Color.FromArgb(33, 150, 243);
                btnOK.OnHoverBaseColor = Color.FromArgb(33, 150, 243);
            }

            lblTitle.Text = title;
            lblMessage.Text = message;

            if (lblMessage.Text.Length >= 260)
                this.Size = new Size(540, 350);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}