using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class frmAddMedicine : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        private bool isDuplicate = false;

        public frmAddMedicine()
        {
            InitializeComponent();

            this.Text = "pharma+";
            this.Select();

            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            cmbRack.SelectedIndex = 0;

            GenerateCode(8);

            dtpStart.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dtpEnd.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            try {
                conn.Open();

                oda = new OleDbDataAdapter("SELECT category_name FROM Категорії", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                    cmbCategory.Items.Add(row["category_name"].ToString());

                oda = new OleDbDataAdapter("SELECT supplier_name FROM Постачальники", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                    cmbSupplier.Items.Add(row["supplier_name"].ToString());

                oda = new OleDbDataAdapter("SELECT rack_name FROM Стелажі", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                    cmbRack.Items.Add(row["rack_name"].ToString());
            } finally {
                conn.Close();
            }
        }

        private void frmNewMedicine_Activated(object sender, EventArgs e)
        {
            ChangeTheme(frmAcc.isNight);
        }

        private void txtMedicineName_Enter(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == "Введіть назву")
                txtMedicineName.Text = "";

            if (frmAcc.isNight == true) {
                txtMedicineName.BorderColor = Color.Gray;
                txtMedicineName.FocusedBorderColor = Color.Gray;
            } else {
                txtMedicineName.BorderColor = Color.Silver;
                txtMedicineName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtMedicineName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
                txtMedicineName.Text = "Введіть назву";

            if (frmAcc.isNight == true) {
                txtMedicineName.BorderColor = Color.Gray;
                txtMedicineName.FocusedBorderColor = Color.Gray;
            } else {
                txtMedicineName.BorderColor = Color.Silver;
                txtMedicineName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand("SELECT medicine_name FROM Медикаменти WHERE medicine_name ='" + txtMedicineName.Text + "'", conn);

                odr = cmd.ExecuteReader();

                if (odr.Read() == true)
                    isDuplicate = true;
                else
                    isDuplicate = false;
            }  finally {
                conn.Close();
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbCategory.BorderColor = Color.Gray;
            else
                cmbCategory.BorderColor = Color.Silver;
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbSupplier.BorderColor = Color.Gray;
            else
                cmbSupplier.BorderColor = Color.Silver;
        }

        private void cmbRack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbRack.BorderColor = Color.Gray;
            else
                cmbRack.BorderColor = Color.Silver;
        }

        private void txtBatchNo_Enter(object sender, EventArgs e)
        {
            if (txtBatchNo.Text == "Введіть номер")
                txtBatchNo.Text = "";

            if (frmAcc.isNight == true) {
                txtBatchNo.BorderColor = Color.Gray;
                txtBatchNo.FocusedBorderColor = Color.Gray;
            } else {
                txtBatchNo.BorderColor = Color.Silver;
                txtBatchNo.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtBatchNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBatchNo.Text))
                txtBatchNo.Text = "Введіть номер";

            if (frmAcc.isNight == true) {
                txtBatchNo.BorderColor = Color.Gray;
                txtBatchNo.FocusedBorderColor = Color.Gray;
            } else {
                txtBatchNo.BorderColor = Color.Silver;
                txtBatchNo.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "Введіть кількість")
                txtQuantity.Text = "";

            if (frmAcc.isNight == true) {
                txtQuantity.BorderColor = Color.Gray;
                txtQuantity.FocusedBorderColor = Color.Gray;
            } else {
                txtQuantity.BorderColor = Color.Silver;
                txtQuantity.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                txtQuantity.Text = "Введіть кількість";

            if (frmAcc.isNight == true) {
                txtQuantity.BorderColor = Color.Gray;
                txtQuantity.FocusedBorderColor = Color.Gray;
            } else {
                txtQuantity.BorderColor = Color.Silver;
                txtQuantity.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == (char)8)
                e.Handled = false;
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
            if (txtMedicineName.Text == "Введіть назву" || cmbCategory.Text == "- Категорія -" || cmbRack.Text == "- Стелаж -" || cmbSupplier.Text == "- Постачальник -" || txtBatchNo.Text == "Введіть номер" || txtQuantity.Text == "Введіть кількість" || isDuplicate == true) {
                if (txtMedicineName.Text == "Введіть назву")
                    txtMedicineName.BorderColor = Color.Red;

                if (cmbCategory.Text == "- Категорія -")
                    cmbCategory.BorderColor = Color.Red;

                if (cmbSupplier.Text == "- Постачальник -")
                    cmbSupplier.BorderColor = Color.Red;

                if (cmbRack.Text == "- Стелаж -")
                    cmbRack.BorderColor = Color.Red;

                if (txtBatchNo.Text == "Введіть номер")
                    txtBatchNo.BorderColor = Color.Red;

                if (txtQuantity.Text == "Введіть кількість")
                    txtQuantity.BorderColor = Color.Red;

                if (isDuplicate == true) {
                    txtMedicineName.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Медикамент з такою назвою вже існує.")).ShowDialog();
                }
            } else {
                try {
                    conn.Open();

                    cmd = new OleDbCommand("INSERT INTO Медикаменти (medicine_name, medicine_category, medicine_supplier, medicine_rack, medicine_batch_no, medicine_desc, medicine_quantity, medicine_start, medicine_end) VALUES ('" + txtMedicineName.Text
                        + "', '" + cmbCategory.Text
                        + "', '" + cmbSupplier.Text
                        + "', '" + cmbRack.Text
                        + "', '" + txtBatchNo.Text
                        + "', '" + txtDesc.Text
                        + "', '" + txtQuantity.Text
                        + "', '" + dtpStart.Value.ToLongDateString()
                        + "', '" + dtpEnd.Value.ToLongDateString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                        + "', '" + "Створення"
                        + "', '" + "Створення нового мед. препарата \"" + txtMedicineName.Text + "\" користувачем " + ucLog.acc
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно створили мед. препарат \"" + txtMedicineName.Text + "\".")).ShowDialog();

                    txtMedicineName.Text = "Введіть назву";
                    txtQuantity.Text = "Введіть кількість";
                    txtDesc.Text = "";

                    dtpStart.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    dtpEnd.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                    GenerateCode(8);

                    ucMedicine.instance.GetMedicineList("SELECT * FROM Медикаменти");
                    ucEvents.instance.GetEventList("SELECT * FROM Події");
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        private void GenerateCode(int lenght)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[lenght];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];

            var batch_no = new String(stringChars);

            txtBatchNo.Text = batch_no;
        }

        private void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                txtMedicineName.BaseColor = Color.FromArgb(39, 39, 39);
                txtMedicineName.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtMedicineName.BorderColor = Color.Gray;
                txtMedicineName.ForeColor = Color.Gray;
                txtMedicineName.FocusedForeColor = Color.Gray;

                cmbCategory.BaseColor = Color.FromArgb(39, 39, 39);
                cmbCategory.BorderColor = Color.Gray;
                cmbCategory.ForeColor = Color.Gray;

                cmbSupplier.BaseColor = Color.FromArgb(39, 39, 39);
                cmbSupplier.BorderColor = Color.Gray;
                cmbSupplier.ForeColor = Color.Gray;

                cmbRack.BaseColor = Color.FromArgb(39, 39, 39);
                cmbRack.BorderColor = Color.Gray;
                cmbRack.ForeColor = Color.Gray;

                txtBatchNo.BaseColor = Color.FromArgb(39, 39, 39);
                txtBatchNo.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtBatchNo.BorderColor = Color.Gray;
                txtBatchNo.ForeColor = Color.Gray;
                txtBatchNo.FocusedForeColor = Color.Gray;

                txtQuantity.BaseColor = Color.FromArgb(39, 39, 39);
                txtQuantity.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtQuantity.BorderColor = Color.Gray;
                txtQuantity.ForeColor = Color.Gray;
                txtQuantity.FocusedForeColor = Color.Gray;

                txtDesc.BaseColor = Color.FromArgb(39, 39, 39);
                txtDesc.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtDesc.BorderColor = Color.Gray;
                txtDesc.ForeColor = Color.Gray;
                txtDesc.FocusedForeColor = Color.Gray;

                dtpStart.BaseColor = Color.FromArgb(39, 39, 39);
                dtpStart.BorderColor = Color.Gray;
                dtpStart.OnHoverBorderColor = Color.Gray;
                dtpStart.ForeColor = Color.Gray;
                dtpStart.OnHoverForeColor = Color.Gray;
                dtpStart.OnHoverBaseColor = Color.FromArgb(39, 39, 39);

                dtpEnd.BaseColor = Color.FromArgb(39, 39, 39);
                dtpEnd.BorderColor = Color.Gray;
                dtpEnd.OnHoverBorderColor = Color.Gray;
                dtpEnd.ForeColor = Color.Gray;
                dtpEnd.OnHoverForeColor = Color.Gray;
                dtpEnd.OnHoverBaseColor = Color.FromArgb(39, 39, 39);

                btnAdd.BaseColor = Color.FromArgb(39, 39, 39);
                btnAdd.BorderColor = Color.Gray;
            }
        }
    }
}