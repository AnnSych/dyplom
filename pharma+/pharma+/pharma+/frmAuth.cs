using System.Windows.Forms;

namespace pharma_
{
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();

            this.Text = "pharma+ > Авторизація";

            pnlControl.Select();

            if (!pnlControl.Controls.Contains(ucLog.instance)) {
                pnlControl.Controls.Add(ucLog.instance);
                ucLog.instance.Dock = DockStyle.Fill;
                ucLog.instance.BringToFront();
            }
        }

        private void frmAuth_Activated(object sender, System.EventArgs e)
        {
            ucLog.instance.ChangeTheme(frmAcc.isNight);
            ucReg.instance.ChangeTheme(frmAcc.isNight);
        }

        private void frmAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();

            System.Environment.Exit(1);
        }
    }
}