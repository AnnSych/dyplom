using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class ucReg : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Application.StartupPath + "\\pharma_plus.mdb");
        OleDbCommand cmd;
        OleDbDataReader odr;

        private bool isDuplicate = false;

        private static ucReg _instance;

        public static ucReg instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucReg();
                return _instance;
            }
        }
        public ucReg()
        {
            InitializeComponent();

            pctBoxLoginConfirm.Visible = false;
            pctBoxPasswordConfirm.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "Ф.І.О";
            txtLogin.Text = "Логін";
            txtEmail.Text = "Е-пошта";
            txtPhone.Text = "Телефон";
            txtPassword.Text = "Пароль";
            txtPassword.PasswordChar = '\0';
            txtPasswordConfirmation.Text = "Підтвердити пароль";
            txtPasswordConfirmation.PasswordChar = '\0';

            txtFullName.BorderColor = Color.Gray;
            txtLogin.BorderColor = Color.Gray;
            txtEmail.BorderColor = Color.Gray;
            txtPhone.BorderColor = Color.Gray;
            txtPassword.BorderColor = Color.Gray;
            txtPasswordConfirmation.BorderColor = Color.Gray;

            Form.ActiveForm.Text = "pharma+ > Авторизація";

            if (!Form.ActiveForm.Controls.Contains(ucLog.instance)) {
                Form.ActiveForm.Controls.Add(ucLog.instance);
                ucLog.instance.Dock = DockStyle.Fill;
                ucLog.instance.BringToFront();
            } else {
                ucLog.instance.BringToFront();
            }
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Ф.І.О")
                txtFullName.Text = "";

            if (frmAcc.isNight == true) {
                txtFullName.BorderColor = Color.Gray;
                txtFullName.FocusedBorderColor = Color.Gray;
            } else {
                txtFullName.BorderColor = Color.Silver;
                txtFullName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
                txtFullName.Text = "Ф.І.О";

            if (frmAcc.isNight == true) {
                txtFullName.BorderColor = Color.Gray;
                txtFullName.FocusedBorderColor = Color.Gray;
            } else {
                txtFullName.BorderColor = Color.Silver;
                txtFullName.FocusedBorderColor = Color.Silver;
            }
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

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand("SELECT user_login FROM Користувачи WHERE user_login ='" + txtLogin.Text + "'", conn);

                odr = cmd.ExecuteReader();

                if (odr.Read() == true) {
                    isDuplicate = true;

                    pctBoxLoginConfirm.Image = Properties.Resources.no_match;

                    Tips.SetToolTip(pctBoxLoginConfirm, "Логін зайнятий");
                } else {
                    isDuplicate = false;

                    pctBoxLoginConfirm.Image = Properties.Resources.match;

                    Tips.SetToolTip(pctBoxLoginConfirm, "Логін дійсний");
                }

                if (txtLogin.Text == "Логін")
                    pctBoxLoginConfirm.Visible = false;

            } finally {
                conn.Close();
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            pctBoxLoginConfirm.Visible = true;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Е-пошта")
                txtEmail.Text = "";

            if (frmAcc.isNight == true) {
                txtEmail.BorderColor = Color.Gray;
                txtEmail.FocusedBorderColor = Color.Gray;
            } else {
                txtEmail.BorderColor = Color.Silver;
                txtEmail.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                txtEmail.Text = "Е-пошта";

            if (frmAcc.isNight == true) {
                txtEmail.BorderColor = Color.Gray;
                txtEmail.FocusedBorderColor = Color.Gray;
            } else {
                txtEmail.BorderColor = Color.Silver;
                txtEmail.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Телефон")
                txtPhone.Text = "";

            if (frmAcc.isNight == true) {
                txtPhone.BorderColor = Color.Gray;
                txtPhone.FocusedBorderColor = Color.Gray;
            } else {
                txtPhone.BorderColor = Color.Silver;
                txtPhone.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                txtPhone.Text = "Телефон";


            if (frmAcc.isNight == true) {
                txtPhone.BorderColor = Color.Gray;
                txtPhone.FocusedBorderColor = Color.Gray;
            } else {
                txtPhone.BorderColor = Color.Silver;
                txtPhone.FocusedBorderColor = Color.Silver;
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordConfirmation.Text == txtPassword.Text) {
                pctBoxPasswordConfirm.Image = Properties.Resources.match;

                Tips.SetToolTip(pctBoxPasswordConfirm, "Паролі співпадають");
            } else {
                pctBoxPasswordConfirm.Image = Properties.Resources.no_match;

                Tips.SetToolTip(pctBoxPasswordConfirm, "Паролі не співпадають");
            }

            if (txtPasswordConfirmation.Text == "Підтвердити пароль")
                pctBoxPasswordConfirm.Visible = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            pctBoxPasswordConfirm.Visible = true;
        }

        private void txtPasswordConfirmation_Enter(object sender, EventArgs e)
        {
            if (txtPasswordConfirmation.Text == "Підтвердити пароль") {
                txtPasswordConfirmation.Text = "";
                txtPasswordConfirmation.PasswordChar = '●';
            }

            if (frmAcc.isNight == true) {
                txtPasswordConfirmation.BorderColor = Color.Gray;
                txtPasswordConfirmation.FocusedBorderColor = Color.Gray;
            } else {
                txtPasswordConfirmation.BorderColor = Color.Silver;
                txtPasswordConfirmation.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtPasswordConfirmation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text)) {
                txtPasswordConfirmation.PasswordChar = '\0';
                txtPasswordConfirmation.Text = "Підтвердити пароль";
            }

            if (frmAcc.isNight == true) {
                txtPasswordConfirmation.BorderColor = Color.Gray;
                txtPasswordConfirmation.FocusedBorderColor = Color.Gray;
            } else {
                txtPasswordConfirmation.BorderColor = Color.Silver;
                txtPasswordConfirmation.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtPasswordConfirmation_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordConfirmation.Text == txtPassword.Text) {
                pctBoxPasswordConfirm.Image = Properties.Resources.match;

                Tips.SetToolTip(pctBoxPasswordConfirm, "Паролі співпадають");
            } else {
                pctBoxPasswordConfirm.Image = Properties.Resources.no_match;

                Tips.SetToolTip(pctBoxPasswordConfirm, "Паролі не співпадають");
            }

            if (txtPasswordConfirmation.Text == "Підтвердити пароль")
                pctBoxPasswordConfirm.Visible = false;
        }

        private void txtPasswordConfirmation_KeyPress(object sender, KeyPressEventArgs e)
        {
            pctBoxPasswordConfirm.Visible = true;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Ф.І.О" || txtLogin.Text == "Логін" || txtEmail.Text == "Е-пошта" || !txtEmail.Text.Contains("@") || txtPhone.Text == "Телефон" || txtPassword.Text == "Пароль" || txtPasswordConfirmation.Text == "Підтвердити пароль" || txtPassword.Text != txtPasswordConfirmation.Text || isDuplicate == true) {
                
                if (txtFullName.Text == "Ф.І.О")
                    txtFullName.BorderColor = Color.Red;

                if (txtLogin.Text == "Логін")
                   txtLogin.BorderColor = Color.Red;

                if (isDuplicate == true) {
                    txtLogin.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Користувач с таким логіном вже існує.")).ShowDialog();
                }

                if (txtEmail.Text == "Е-пошта")
                    txtEmail.BorderColor = Color.Red;

                if (txtEmail.Text != "Е-пошта" && !txtEmail.Text.Contains("@")) {
                    txtEmail.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Недійсна електронна адреса.")).ShowDialog();
                }

                if (txtPhone.Text == "Телефон")
                    txtPhone.BorderColor = Color.Red;

                if (txtPassword.Text == "Пароль")
                    txtPassword.BorderColor = Color.Red;

                if (txtPasswordConfirmation.Text == "Підтвердити пароль")
                    txtPasswordConfirmation.BorderColor = Color.Red;

                if (txtPassword.Text != "Пароль" && txtPasswordConfirmation.Text != "Підтвердити пароль" && txtPassword.Text != txtPasswordConfirmation.Text) {
                    txtPassword.BorderColor = Color.Red;
                    txtPasswordConfirmation.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Уаага!", "Введені вами паролі не співбадають.")).ShowDialog();
                }
            } else {
                try {
                    conn.Open();

                    cmd = new OleDbCommand("INSERT INTO Користувачи (user_fullname, user_login, user_email, user_phone, user_password, user_registration_date) VALUES ('" + txtFullName.Text
                        + "', '" + txtLogin.Text
                        + "', '" + txtEmail.Text
                        + "', '" + txtPhone.Text
                        + "', '" + txtPassword.Text
                        + "', '" + DateTime.Now.ToShortDateString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + txtLogin.Text
                        + "', '" + "Реєстрація"
                        + "', '" + "Реєстрація користувача " + txtLogin.Text + " в системі."
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно зараєструвались в системі \"pharma+\".")).ShowDialog();

                    txtFullName.Text = "Ф.І.О";
                    txtLogin.Text = "Логін";
                    txtEmail.Text = "Е-пошта";
                    txtPhone.Text = "Телефон";
                    txtPassword.Text = "Пароль";
                    txtPassword.PasswordChar = '\0';
                    txtPasswordConfirmation.Text = "Підтвердити пароль";
                    txtPasswordConfirmation.PasswordChar = '\0';

                    txtFullName.BorderColor = Color.Gray;
                    txtLogin.BorderColor = Color.Gray;
                    txtEmail.BorderColor = Color.Gray;
                    txtPhone.BorderColor = Color.Gray;
                    txtPassword.BorderColor = Color.Gray;
                    txtPasswordConfirmation.BorderColor = Color.Gray;

                    Form.ActiveForm.Text = "pharma+ > Авторизація";

                    if (!Form.ActiveForm.Controls.Contains(ucLog.instance)) {
                        Form.ActiveForm.Controls.Add(ucLog.instance);
                        ucLog.instance.Dock = DockStyle.Fill;
                        ucLog.instance.BringToFront();
                    } else {
                        ucLog.instance.BringToFront();
                    }

                    ucEvents.instance.GetEventList("SELECT * FROM Події");
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                btnBack.BaseColor = Color.FromArgb(18, 18, 18);

                lblAppName.ForeColor = Color.DimGray;
                lblAppDesc.ForeColor = Color.DimGray;

                pctBoxUser.BackColor = Color.FromArgb(39, 39, 39);

                txtFullName.BaseColor = Color.FromArgb(39, 39, 39);
                txtFullName.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtFullName.BorderColor = Color.Gray;
                txtFullName.ForeColor = Color.Gray;
                txtFullName.FocusedForeColor = Color.Gray;

                pctBoxUserLogin.BackColor = Color.FromArgb(39, 39, 39);
                pctBoxLoginConfirm.BackColor = Color.FromArgb(18, 18, 18);

                txtLogin.BaseColor = Color.FromArgb(39, 39, 39);
                txtLogin.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtLogin.BorderColor = Color.Gray;
                txtLogin.ForeColor = Color.Gray;
                txtLogin.FocusedForeColor = Color.Gray;

                pctBoxEmail.BackColor = Color.FromArgb(39, 39, 39);

                txtEmail.BaseColor = Color.FromArgb(39, 39, 39);
                txtEmail.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtEmail.BorderColor = Color.Gray;
                txtEmail.ForeColor = Color.Gray;
                txtEmail.FocusedForeColor = Color.Gray;

                pctBoxPhone.BackColor = Color.FromArgb(39, 39, 39);

                txtPhone.BaseColor = Color.FromArgb(39, 39, 39);
                txtPhone.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPhone.BorderColor = Color.Gray;
                txtPhone.ForeColor = Color.Gray;
                txtPhone.FocusedForeColor = Color.Gray;

                pctBoxLock1.BackColor = Color.FromArgb(39, 39, 39);

                txtPassword.BaseColor = Color.FromArgb(39, 39, 39);
                txtPassword.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPassword.BorderColor = Color.Gray;
                txtPassword.ForeColor = Color.Gray;
                txtPassword.FocusedForeColor = Color.Gray;

                pctBoxPasswordConfirm.BackColor = Color.FromArgb(18, 18, 18);
                pctBoxLock2.BackColor = Color.FromArgb(39, 39, 39);

                txtPasswordConfirmation.BaseColor = Color.FromArgb(39, 39, 39);
                txtPasswordConfirmation.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPasswordConfirmation.BorderColor = Color.Gray;
                txtPasswordConfirmation.ForeColor = Color.Gray;
                txtPasswordConfirmation.FocusedForeColor = Color.Gray;

                btnReg.BaseColor = Color.FromArgb(39, 39, 39);
            } else {
                this.BackColor = Color.White;

                lblAppName.ForeColor = Color.Black;
                lblAppDesc.ForeColor = Color.Black;

                btnBack.BaseColor = Color.White;

                pctBoxUser.BackColor = Color.WhiteSmoke;

                txtFullName.BaseColor = Color.WhiteSmoke;
                txtFullName.FocusedBaseColor = Color.WhiteSmoke;
                txtFullName.BorderColor = Color.Silver;
                txtFullName.ForeColor = Color.DimGray;
                txtFullName.FocusedForeColor = Color.Black;

                pctBoxUserLogin.BackColor = Color.WhiteSmoke;
                pctBoxLoginConfirm.BackColor = Color.White;

                txtLogin.BaseColor = Color.WhiteSmoke;
                txtLogin.FocusedBaseColor = Color.WhiteSmoke;
                txtLogin.BorderColor = Color.Silver;
                txtLogin.ForeColor = Color.DimGray;
                txtLogin.FocusedForeColor = Color.Black;

                pctBoxEmail.BackColor = Color.WhiteSmoke;

                txtEmail.BaseColor = Color.WhiteSmoke;
                txtEmail.FocusedBaseColor = Color.WhiteSmoke;
                txtEmail.BorderColor = Color.Silver;
                txtEmail.ForeColor = Color.DimGray;
                txtEmail.FocusedForeColor = Color.Black;

                pctBoxPhone.BackColor = Color.WhiteSmoke;

                txtPhone.BaseColor = Color.WhiteSmoke;
                txtPhone.FocusedBaseColor = Color.WhiteSmoke;
                txtPhone.BorderColor = Color.Silver;
                txtPhone.ForeColor = Color.DimGray;
                txtPhone.FocusedForeColor = Color.Black;

                pctBoxLock1.BackColor = Color.WhiteSmoke;

                txtPassword.BaseColor = Color.WhiteSmoke;
                txtPassword.FocusedBaseColor = Color.WhiteSmoke;
                txtPassword.BorderColor = Color.Silver;
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.FocusedForeColor = Color.Black;

                pctBoxPasswordConfirm.BackColor = Color.White;
                pctBoxLock2.BackColor = Color.WhiteSmoke;

                txtPasswordConfirmation.BaseColor = Color.WhiteSmoke;
                txtPasswordConfirmation.FocusedBaseColor = Color.WhiteSmoke;
                txtPasswordConfirmation.BorderColor = Color.Silver;
                txtPasswordConfirmation.ForeColor = Color.DimGray;
                txtPasswordConfirmation.FocusedForeColor = Color.Black;

                btnReg.BaseColor = Color.Gainsboro;
            }
        }
    }
}