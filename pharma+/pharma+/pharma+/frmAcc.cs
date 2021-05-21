using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace pharma_
{
    public partial class frmAcc : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        private string picturePath;

        public static bool isNight;

        public frmAcc()
        {
            InitializeComponent();

            this.Text = "pharma+";
            this.Select();

            pctBoxPasswordConfirm.Visible = false;

            try {
                oda = new OleDbDataAdapter("SELECT * FROM Користувачи WHERE user_login ='" + ucLog.acc + "'", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows) {
                    lblUserName.Text = row["user_fullname"].ToString();

                    picturePath = row["user_picture"].ToString();

                    lblRegisterDate.Text = "Дата реєстрації                 " + row["user_registration_date"].ToString();

                    txtFullName.Text = row["user_fullname"].ToString();
                    txtBirthDate.Text = row["user_bith_date"].ToString();

                    if (txtBirthDate.Text == "")
                        txtBirthDate.Text = "День народження";

                    txtEmail.Text = row["user_email"].ToString();
                    txtPhone.Text = row["user_phone"].ToString();

                    if (picturePath != "") {
                        try {
                            pctBoxUserPicture.Image = Image.FromFile(picturePath);
                        }
                        catch (IOException) {
                            pctBoxUserPicture.Image = Properties.Resources.photo;
                        }
                    } else {
                        pctBoxUserPicture.Image = Properties.Resources.photo;
                    }
                }
            } finally {
                conn.Close();
            }
        }

        private void frmAcc_Activated(object sender, EventArgs e)
        {
            ChangeTheme(isNight);
        }

        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            picturePath = "";

            pctBoxUserPicture.Image = Properties.Resources.photo;
        }

        private void btnNewPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Файли зображення (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp" }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    pctBoxUserPicture.Image = new Bitmap(ofd.FileName);

                    picturePath = ofd.FileName;
                }
            }
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Ф.І.О")
                txtFullName.Text = "";

            if (isNight == true) {
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

            if (isNight == true) {
                txtFullName.BorderColor = Color.Gray;
                txtFullName.FocusedBorderColor = Color.Gray;
            } else {
                txtFullName.BorderColor = Color.Silver;
                txtFullName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtBirthDate_Enter(object sender, EventArgs e)
        {
            if (txtBirthDate.Text == "День народження")
                txtBirthDate.Text = "";

            if (isNight == true) {
                txtBirthDate.BorderColor = Color.Gray;
                txtBirthDate.FocusedBorderColor = Color.Gray;
            } else {
                txtBirthDate.BorderColor = Color.Silver;
                txtBirthDate.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtBirthDate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthDate.Text))
                txtBirthDate.Text = "День народження";

            if (isNight == true) {
                txtBirthDate.BorderColor = Color.Gray;
                txtBirthDate.FocusedBorderColor = Color.Gray;
            } else {
                txtBirthDate.BorderColor = Color.Silver;
                txtBirthDate.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Електронна пошта")
                txtEmail.Text = "";

            if (isNight == true) {
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
                txtEmail.Text = "Електронна пошта";

            if (isNight == true) {
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

            if (isNight == true) {
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

            if (isNight == true) {
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

            if (isNight == true) {
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

            if (isNight == true) {
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

            if (isNight == true) {
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

            if (isNight == true) {
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Ф.І.О" || txtBirthDate.Text == "День народження" || txtEmail.Text == "Електронна пошта" || !txtEmail.Text.Contains("@") || txtPhone.Text == "Телефон") {
                if (txtFullName.Text == "Ф.І.О")
                    txtFullName.BorderColor = Color.Red;

                if (txtBirthDate.Text == "День народження")
                    txtBirthDate.BorderColor = Color.Red;

                if (txtEmail.Text == "Електронна пошта")
                    txtEmail.BorderColor = Color.Red;

                if (txtEmail.Text != "Електронна пошта" && !txtEmail.Text.Contains("@")) {
                    txtEmail.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Недійсна електронна пошта.")).ShowDialog();
                }

                if (txtPhone.Text == "Телефон")
                    txtPhone.BorderColor = Color.Red;
            } else {
                if (txtPassword.Text != "Пароль" && txtPasswordConfirmation.Text != "Підтвердити пароль" && txtPassword.Text != txtPasswordConfirmation.Text) {
                    txtPassword.BorderColor = Color.Red;
                    txtPasswordConfirmation.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Уаага!", "Введені вами паролі не співбадають.")).ShowDialog();
                } else {
                    if (txtPassword.Text != "Пароль" && txtPasswordConfirmation.Text != "Підтвердити пароль") {
                        try {
                            conn.Open();

                            cmd = new OleDbCommand("UPDATE Користувачи SET user_fullname = '" + txtFullName.Text +
                                 "', user_bith_date = '" + txtBirthDate.Text +
                                 "', user_email = '" + txtEmail.Text +
                                 "', user_phone = '" + txtPhone.Text +
                                 "', user_password = '" + txtPasswordConfirmation.Text +
                                 "', user_picture = '" + picturePath + "' WHERE user_login = '" + ucLog.acc + "'", conn);

                            cmd.ExecuteNonQuery();

                            cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                                + "', '" + "Оновлення"
                                + "', '" + "Оновлення особистих даних користувачем " + ucLog.acc
                                + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                            cmd.ExecuteNonQuery();

                            (new MsgBox(Type.INFORMATION, "pharma+", "Ваші дані оновлено.")).ShowDialog();

                            lblUserName.Text = txtFullName.Text;

                            txtPassword.Text = "Пароль";
                            txtPassword.PasswordChar = '\0';
                            txtPasswordConfirmation.Text = "Підтвердити пароль";
                            txtPasswordConfirmation.PasswordChar = '\0';

                            conn.Close();

                            ucEvents.instance.GetEventList("SELECT * FROM Події");
                        } catch (Exception ex) {
                            (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                        }
                    } else {
                        try {
                            conn.Open();

                            cmd = new OleDbCommand("UPDATE Користувачи SET user_fullname = '" + txtFullName.Text +
                                 "', user_bith_date = '" + txtBirthDate.Text +
                                 "', user_email = '" + txtEmail.Text +
                                 "', user_phone = '" + txtPhone.Text +
                                 "', user_picture = '" + picturePath + "' WHERE user_login = '" + ucLog.acc + "'", conn);

                            cmd.ExecuteNonQuery();

                            cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                                + "', '" + "Оновлення"
                                + "', '" + "Оновлення особистих даних користувачем " + ucLog.acc
                                + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            (new MsgBox(Type.INFORMATION, "pharma+", "Ваші дані оновлено.")).ShowDialog();

                            lblUserName.Text = txtFullName.Text;

                            txtPassword.Text = "Пароль";
                            txtPassword.PasswordChar = '\0';
                            txtPasswordConfirmation.Text = "Підтвердити пароль";
                            txtPasswordConfirmation.PasswordChar = '\0';

                            ucEvents.instance.GetEventList("SELECT * FROM Події");
                        } catch (Exception ex) {
                            (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnThemeChange_Click(object sender, EventArgs e)
        {
            if (isNight == true) {
                isNight = false;

                ChangeTheme(false);
            } else {
                isNight = true;

                ChangeTheme(true);
            }
        }

        private void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                Tips.SetToolTip(btnThemeChange, "Увімкнути світлу тему");

                this.BackColor = Color.FromArgb(18, 18, 18);

                lblUserName.ForeColor = Color.DimGray;

                btnThemeChange.BaseColor = Color.FromArgb(18, 18, 18);
                btnThemeChange.BorderColor = Color.FromArgb(39, 39, 39);
                btnThemeChange.OnHoverBaseColor = Color.FromArgb(18, 18, 18);
                btnThemeChange.OnHoverBorderColor = Color.FromArgb(39, 39, 39);
                btnThemeChange.Image = Properties.Resources.night;
                btnThemeChange.ImageOffsetX = -6;

                btnDeletePicture.BaseColor = Color.FromArgb(39, 39, 39);
                btnDeletePicture.OnHoverBaseColor = Color.FromArgb(18, 18, 18);

                btnNewPicture.BaseColor = Color.FromArgb(39, 39, 39);
                btnNewPicture.BorderColor = Color.Gray;
                btnNewPicture.OnHoverBorderColor = Color.Gray;
                btnNewPicture.OnHoverBaseColor = Color.FromArgb(39, 39, 39);

                pnlPictureFrame.BackColor = Color.FromArgb(39, 39, 39);          

                txtFullName.BaseColor = Color.FromArgb(39, 39, 39);
                txtFullName.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtFullName.BorderColor = Color.Gray;
                txtFullName.ForeColor = Color.Gray;
                txtFullName.FocusedForeColor = Color.Gray;

                txtBirthDate.BaseColor = Color.FromArgb(39, 39, 39);
                txtBirthDate.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtBirthDate.BorderColor = Color.Gray;
                txtBirthDate.ForeColor = Color.Gray;
                txtBirthDate.FocusedForeColor = Color.Gray;

                txtEmail.BaseColor = Color.FromArgb(39, 39, 39);
                txtEmail.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtEmail.BorderColor = Color.Gray;
                txtEmail.ForeColor = Color.Gray;
                txtEmail.FocusedForeColor = Color.Gray;

                txtPhone.BaseColor = Color.FromArgb(39, 39, 39);
                txtPhone.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPhone.BorderColor = Color.Gray;
                txtPhone.ForeColor = Color.Gray;
                txtPhone.FocusedForeColor = Color.Gray;

                txtPassword.BaseColor = Color.FromArgb(39, 39, 39);
                txtPassword.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPassword.BorderColor = Color.Gray;
                txtPassword.ForeColor = Color.Gray;
                txtPassword.FocusedForeColor = Color.Gray;

                pctBoxPasswordConfirm.BackColor = Color.FromArgb(18, 18, 18);

                txtPasswordConfirmation.BaseColor = Color.FromArgb(39, 39, 39);
                txtPasswordConfirmation.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPasswordConfirmation.BorderColor = Color.Gray;
                txtPasswordConfirmation.ForeColor = Color.Gray;
                txtPasswordConfirmation.FocusedForeColor = Color.Gray;

                btnUpdate.BaseColor = Color.FromArgb(39, 39, 39);
                btnUpdate.BorderColor = Color.Gray;
            } else {
                Tips.SetToolTip(btnThemeChange, "Увімнкути темну тему");

                this.BackColor = Color.White;

                lblUserName.ForeColor = Color.Black;

                btnThemeChange.BaseColor = Color.White;
                btnThemeChange.BorderColor = Color.LightGray;
                btnThemeChange.OnHoverBaseColor = Color.White;
                btnThemeChange.OnHoverBorderColor = Color.LightGray;
                btnThemeChange.Image = Properties.Resources.day;
                btnThemeChange.ImageOffsetX = 8;

                btnDeletePicture.BaseColor = Color.WhiteSmoke;
                btnDeletePicture.OnHoverBaseColor = Color.Gainsboro;

                btnNewPicture.BaseColor = Color.WhiteSmoke;
                btnNewPicture.BorderColor = Color.Silver;
                btnNewPicture.OnHoverBorderColor = Color.Silver;
                btnNewPicture.OnHoverBaseColor = Color.WhiteSmoke;

                pnlPictureFrame.BackColor = Color.WhiteSmoke;

                txtFullName.BaseColor = Color.WhiteSmoke;
                txtFullName.FocusedBaseColor = Color.WhiteSmoke;
                txtFullName.BorderColor = Color.Silver;
                txtFullName.ForeColor = Color.DimGray;
                txtFullName.FocusedForeColor = Color.Black;

                txtBirthDate.BaseColor = Color.WhiteSmoke;
                txtBirthDate.FocusedBaseColor = Color.WhiteSmoke;
                txtBirthDate.BorderColor = Color.Silver;
                txtBirthDate.ForeColor = Color.Gray;
                txtBirthDate.FocusedForeColor = Color.Black;

                txtEmail.BaseColor = Color.WhiteSmoke;
                txtEmail.FocusedBaseColor = Color.WhiteSmoke;
                txtEmail.BorderColor = Color.Silver;
                txtEmail.ForeColor = Color.Gray;
                txtEmail.FocusedForeColor = Color.Black;

                txtPhone.BaseColor = Color.WhiteSmoke;
                txtPhone.FocusedBaseColor = Color.WhiteSmoke;
                txtPhone.BorderColor = Color.Silver;
                txtPhone.ForeColor = Color.Gray;
                txtPhone.FocusedForeColor = Color.Black;

                txtPassword.BaseColor = Color.WhiteSmoke;
                txtPassword.FocusedBaseColor = Color.WhiteSmoke;
                txtPassword.BorderColor = Color.Silver;
                txtPassword.ForeColor = Color.Gray;
                txtPassword.FocusedForeColor = Color.Black;

                pctBoxPasswordConfirm.BackColor = Color.White;

                txtPasswordConfirmation.BaseColor = Color.WhiteSmoke;
                txtPasswordConfirmation.FocusedBaseColor = Color.WhiteSmoke;
                txtPasswordConfirmation.BorderColor = Color.Silver;
                txtPasswordConfirmation.ForeColor = Color.Gray;
                txtPasswordConfirmation.FocusedForeColor = Color.Black;

                btnUpdate.BaseColor = Color.WhiteSmoke;
                btnUpdate.BorderColor = Color.Silver;
            }
        }
    }
}