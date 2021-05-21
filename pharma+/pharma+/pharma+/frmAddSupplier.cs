using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class frmAddSupplier : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbCommand cmd;

        private bool isDuplicate = false;

        public frmAddSupplier()
        {
            InitializeComponent();

            this.Text = "pharma+";
            this.Select();
        }

        private void frmAddSupplier_Activated(object sender, EventArgs e)
        {
            ChangeTheme(frmAcc.isNight);
        }

        private void txtSupplierName_Enter(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "Введіть назву")
                txtSupplierName.Text = "";

            if (frmAcc.isNight == true) {
                txtSupplierName.BorderColor = Color.Gray;
                txtSupplierName.FocusedBorderColor = Color.Gray;
            } else {
                txtSupplierName.BorderColor = Color.Silver;
                txtSupplierName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtSupplierName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
                txtSupplierName.Text = "Введіть назву";

            if (frmAcc.isNight == true) {
                txtSupplierName.BorderColor = Color.Gray;
                txtSupplierName.FocusedBorderColor = Color.Gray;
            } else {
                txtSupplierName.BorderColor = Color.Silver;
                txtSupplierName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand("SELECT supplier_name FROM Постачальники WHERE supplier_name ='" + txtSupplierName.Text + "'", conn);

                odr = cmd.ExecuteReader();

                if (odr.Read() == true)
                    isDuplicate = true;
                else
                    isDuplicate = false;
            } finally {
                conn.Close();
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Введіть електронну пошту")
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
                txtEmail.Text = "Введіть електронну пошту";

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
            if (txtPhone.Text == "Введіть телефон")
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
                txtPhone.Text = "Введіть телефон";

            if (frmAcc.isNight == true) {
                txtPhone.BorderColor = Color.Gray;
                txtPhone.FocusedBorderColor = Color.Gray;
            } else {
                txtPhone.BorderColor = Color.Silver;
                txtPhone.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true) {
                txtAddress.BorderColor = Color.Gray;
                txtAddress.FocusedBorderColor = Color.Gray;
            } else {
                txtAddress.BorderColor = Color.Silver;
                txtAddress.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true) {
                txtAddress.BorderColor = Color.Gray;
                txtAddress.FocusedBorderColor = Color.Gray;
            } else {
                txtAddress.BorderColor = Color.Silver;
                txtAddress.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtDesc_Enter(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true) {
                txtDesc.BorderColor = Color.Gray;
                txtDesc.FocusedBorderColor = Color.Gray;
            } else {
                txtDesc.BorderColor = Color.Silver;
                txtDesc.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true) {
                txtDesc.BorderColor = Color.Gray;
                txtDesc.FocusedBorderColor = Color.Gray;
            } else {
                txtDesc.BorderColor = Color.Silver;
                txtDesc.FocusedBorderColor = Color.Silver;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "Введіть назву" || txtEmail.Text == "Введіть електронну пошту" || !txtEmail.Text.Contains("@") || txtPhone.Text == "Введіть телефон" || txtAddress.Text == "" || isDuplicate == true) {
                if (txtSupplierName.Text == "Введіть назву")
                    txtSupplierName.BorderColor = Color.Red;

                if (txtEmail.Text == "Введіть електронну пошту")
                    txtEmail.BorderColor = Color.Red;

                if (txtEmail.Text != "Введіть електронну пошту" && !txtEmail.Text.Contains("@")) {
                    txtEmail.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Недійсна електронна пошта.")).ShowDialog();
                }

                if (txtPhone.Text == "Введіть телефон")
                    txtPhone.BorderColor = Color.Red;

                if (txtAddress.Text == "")
                    txtAddress.BorderColor = Color.Red;

                if (isDuplicate == true) {
                    txtSupplierName.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Постачальник з такою назвою вже існує.")).ShowDialog();
                }
            } else {
                try {
                    conn.Open();

                    cmd = new OleDbCommand("INSERT INTO Постачальники (supplier_name, supplier_email, supplier_phone, supplier_address, supplier_desc) VALUES ('" + txtSupplierName.Text
                        + "', '" + txtEmail.Text
                        + "', '" + txtPhone.Text
                        + "', '" + txtAddress.Text
                        + "', '" + txtDesc.Text + "')", conn);

                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                        + "', '" + "Створення"
                        + "', '" + "Створення нового постачальника \"" + txtSupplierName.Text + "\" користувачем " + ucLog.acc
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно створили постачальника \"" + txtSupplierName.Text + "\".")).ShowDialog();

                    txtSupplierName.Text = "Введіть назву";
                    txtEmail.Text = "Введіть електронну пошту";
                    txtPhone.Text = "Введіть телефон";
                    txtAddress.Text = "";
                    txtDesc.Text = "";

                    ucSupplier.instance.GetSupplierList("SELECT * FROM Постачальники");
                    ucEvents.instance.GetEventList("SELECT * FROM Події");
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        private void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                txtSupplierName.BaseColor = Color.FromArgb(39, 39, 39);
                txtSupplierName.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtSupplierName.BorderColor = Color.Gray;
                txtSupplierName.ForeColor = Color.Gray;
                txtSupplierName.FocusedForeColor = Color.Gray;

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

                txtAddress.BaseColor = Color.FromArgb(39, 39, 39);
                txtAddress.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtAddress.BorderColor = Color.Gray;
                txtAddress.ForeColor = Color.Gray;
                txtAddress.FocusedForeColor = Color.Gray;

                txtDesc.BaseColor = Color.FromArgb(39, 39, 39);
                txtDesc.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtDesc.BorderColor = Color.Gray;
                txtDesc.ForeColor = Color.Gray;
                txtDesc.FocusedForeColor = Color.Gray;

                btnAdd.BaseColor = Color.FromArgb(39, 39, 39);
                btnAdd.BorderColor = Color.Gray;
            }
        }
    }
}