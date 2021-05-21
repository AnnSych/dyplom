using System;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pharma_
{
    public partial class ucLog : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Application.StartupPath + "\\pharma_plus.mdb");
        OleDbDataReader dr;
        OleDbCommand cmd;

        public static string acc;

        private static ucLog _instance;

        public static ucLog instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLog();
                return _instance;
            }
        }

        public ucLog()
        {
            InitializeComponent();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Логін")
                txtLogin.Text = "";

            if (frmAcc.isNight == true) {
                txtLogin.BorderColor = Color.Gray;
                txtLogin.FocusedBorderColor = Color.Gray;
            } else {
                txtLogin.BorderColor = Color.Silver;
                txtLogin.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
                txtLogin.Text = "Логін";

            if (frmAcc.isNight == true) {
                txtLogin.BorderColor = Color.Gray;
                txtLogin.FocusedBorderColor = Color.Gray;
            } else {
                txtLogin.BorderColor = Color.Silver;
                txtLogin.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Пароль") {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '●';
            }

            if (frmAcc.isNight == true) {
                txtPassword.BorderColor = Color.Gray;
                txtPassword.FocusedBorderColor = Color.Gray;
            } else {
                txtPassword.BorderColor = Color.Silver;
                txtPassword.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Пароль";
            }

            if (frmAcc.isNight == true) {
                txtPassword.BorderColor = Color.Gray;
                txtPassword.FocusedBorderColor = Color.Gray;
            } else {
                txtPassword.BorderColor = Color.Silver;
                txtPassword.FocusedBorderColor = Color.Silver;
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Пароль") {
                if (chkShowPass.Checked == true)
                    txtPassword.PasswordChar = '\0';
                else
                    txtPassword.PasswordChar = '●';
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "Логін" || txtPassword.Text != "Пароль") {
                if (txtLogin.Text != "Логін") {
                    if (txtPassword.Text != "Пароль") {
                        try {
                            conn.Open();

                            cmd = new OleDbCommand("SELECT * FROM Користувачи WHERE user_login = '" + txtLogin.Text + "' AND user_password = '" + txtPassword.Text + "'", conn);

                            dr = cmd.ExecuteReader();

                            if (dr.Read()) {
                                acc = txtLogin.Text;

                                Form.ActiveForm.Hide();

                                cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + acc
                                    + "', '" + "Авторизація"
                                    + "', '" + "Авторизіція користувачем " + acc + " в системі."
                                    + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                                cmd.ExecuteNonQuery();

                                conn.Close();

                                txtPassword.Text = "Пароль";
                                txtPassword.PasswordChar = '\0';

                                (new frmMain()).ShowDialog();

                                ucEvents.instance.GetEventList("SELECT * FROM Події");
                            } else {
                                txtLogin.BorderColor = Color.Red;
                                txtPassword.BorderColor = Color.Red;

                                (new MsgBox(Type.ERROR, "Полмика", "Виникла проблема з доступом до системи.\nБудь-ласка, перевірте свої дані для входу.")).ShowDialog();
                            }
                        } catch (Exception ex) {
                            (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                        } finally {
                            conn.Close();

                            ucEvents.instance.GetEventList("SELECT * FROM Події");
                        }
                    } else {
                        txtPassword.BorderColor = Color.Red;
                    }
                } else {
                    txtLogin.BorderColor = Color.Red;
                }
            } else {
                txtLogin.BorderColor = Color.Red;
                txtPassword.BorderColor = Color.Red;
            }
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Text = "pharma+ > Реєстарція";

            if (!Form.ActiveForm.Controls.Contains(ucReg.instance)) {
                Form.ActiveForm.Controls.Add(ucReg.instance);
                ucReg.instance.Dock = DockStyle.Fill;
                ucReg.instance.BringToFront();
            } else {
                ucReg.instance.BringToFront();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                lblAppName.ForeColor = Color.DimGray;
                lblAppDesc.ForeColor = Color.DimGray;

                pctBoxUser.BackColor = Color.FromArgb(39, 39, 39);

                txtLogin.BaseColor = Color.FromArgb(39, 39, 39);
                txtLogin.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtLogin.BorderColor = Color.Gray;
                txtLogin.ForeColor = Color.Gray;
                txtLogin.FocusedForeColor = Color.Gray;

                pctBoxLock.BackColor = Color.FromArgb(39, 39, 39);

                txtPassword.BaseColor = Color.FromArgb(39, 39, 39);
                txtPassword.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPassword.BorderColor = Color.Gray;
                txtPassword.ForeColor = Color.Gray;
                txtPassword.FocusedForeColor = Color.Gray;

                chkShowPass.ForeColor = Color.Gray;
                chkShowPass.BaseColor = Color.FromArgb(39, 39, 39);

                btnLog.BaseColor = Color.FromArgb(39, 39, 39);
            } else {
                this.BackColor = Color.White;

                lblAppName.ForeColor = Color.Black;
                lblAppDesc.ForeColor = Color.Black;

                pctBoxUser.BackColor = Color.WhiteSmoke;

                txtLogin.BaseColor = Color.WhiteSmoke;
                txtLogin.FocusedBaseColor = Color.WhiteSmoke;
                txtLogin.BorderColor = Color.Silver;
                txtLogin.ForeColor = Color.DimGray;
                txtLogin.FocusedForeColor = Color.Black;

                pctBoxLock.BackColor = Color.WhiteSmoke;

                txtPassword.BaseColor = Color.WhiteSmoke;
                txtPassword.FocusedBaseColor = Color.WhiteSmoke;
                txtPassword.BorderColor = Color.Silver;
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.FocusedForeColor = Color.Black;

                chkShowPass.ForeColor = Color.Black;
                chkShowPass.BaseColor = Color.White;

                btnLog.BaseColor = Color.Gainsboro;
            }
        }
    }
}