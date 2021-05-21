using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class frmAddPurchase : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        private int current_medicineQuantity;

        public frmAddPurchase()
        {
            InitializeComponent();

            this.Text = "pharma+";
            this.Select();

            cmbMedicine.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            cmbPaymentMethod.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            GenerateCode(8);

            dtpPurchase.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            try {
                conn.Open();

                oda = new OleDbDataAdapter("SELECT medicine_name FROM Медикаменти", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                    cmbMedicine.Items.Add(row["medicine_name"].ToString());

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
            } finally {
                conn.Close();
            }
        }

        private void frmAddPurchase_Activated(object sender, EventArgs e)
        {
            ChangeTheme(frmAcc.isNight);
        }

        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                oda = new OleDbDataAdapter("SELECT medicine_category, medicine_supplier, medicine_quantity FROM Медикаменти WHERE medicine_name ='" + cmbMedicine.Text + "'", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows) {
                    cmbCategory.Text = row["medicine_category"].ToString();
                    cmbSupplier.Text = row["medicine_supplier"].ToString();

                    current_medicineQuantity = Convert.ToInt32(row["medicine_quantity"].ToString());
                }
            } finally {
                conn.Close();
            }

            if (frmAcc.isNight == true)
                cmbMedicine.BorderColor = Color.Gray;
            else
                cmbMedicine.BorderColor = Color.Silver;
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

        private void txtPurchaseCode_Enter(object sender, EventArgs e)
        {
            if (txtPurchaseCode.Text == "Введіть код")
                txtPurchaseCode.Text = "";

            if (frmAcc.isNight == true) {
                txtPurchaseCode.BorderColor = Color.Gray;
                txtPurchaseCode.FocusedBorderColor = Color.Gray;
            } else {
                txtPurchaseCode.BorderColor = Color.Silver;
                txtPurchaseCode.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtPurchaseCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurchaseCode.Text))
                txtPurchaseCode.Text = "Введіть код";

            if (frmAcc.isNight == true) {
                txtPurchaseCode.BorderColor = Color.Gray;
                txtPurchaseCode.FocusedBorderColor = Color.Gray;
            } else {
                txtPurchaseCode.BorderColor = Color.Silver;
                txtPurchaseCode.FocusedBorderColor = Color.Silver;
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

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbPaymentMethod.BorderColor = Color.Gray;
            else
                cmbPaymentMethod.BorderColor = Color.Silver;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbStatus.BorderColor = Color.Gray;
            else
                cmbStatus.BorderColor = Color.Silver;
        }

        private void txtGrandTotal_Enter(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true) {
                txtGrandTotal.BorderColor = Color.Gray;
                txtGrandTotal.FocusedBorderColor = Color.Gray;
            } else {
                txtGrandTotal.BorderColor = Color.Silver;
                txtGrandTotal.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtGrandTotal_Leave(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true) {
                txtGrandTotal.BorderColor = Color.Gray;
                txtGrandTotal.FocusedBorderColor = Color.Gray;
            } else {
                txtGrandTotal.BorderColor = Color.Silver;
                txtGrandTotal.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtGrandTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == (char)8)
                e.Handled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbMedicine.Text == "- Назва медикаменту -" || cmbCategory.Text == "- Категорія -" || cmbSupplier.Text == "- Постачальник -" || txtPurchaseCode.Text == "Введіть код" || txtQuantity.Text == "Введіть кількість" || cmbPaymentMethod.Text == "- Оберіть спосіб оплати -" || cmbStatus.Text == "- Статус -" || txtGrandTotal.Text == "") {
                if (cmbMedicine.Text == "- Назва медикаменту -")
                    cmbMedicine.BorderColor = Color.Red;

                if (cmbCategory.Text == "- Категорія -")
                    cmbCategory.BorderColor = Color.Red;

                if (cmbSupplier.Text == "- Постачальник -")
                    cmbSupplier.BorderColor = Color.Red;

                if (txtPurchaseCode.Text == "Введіть код")
                    txtPurchaseCode.BorderColor = Color.Red;

                if (txtQuantity.Text == "Введіть кількість")
                    txtQuantity.BorderColor = Color.Red;

                if (cmbPaymentMethod.Text == "- Оберіть спосіб оплати -")
                    cmbPaymentMethod.BorderColor = Color.Red;

                if (cmbStatus.Text == "- Статус -")
                    cmbStatus.BorderColor = Color.Red;

                if (txtGrandTotal.Text == "")
                    txtGrandTotal.BorderColor = Color.Red;
            } else {
                try {
                    conn.Open();

                    cmd = new OleDbCommand("INSERT INTO Закупівля (medicine_name, medicine_category, supplier_name, purchase_code, medicine_quantity, purchase_desc, puchase_payment_method, purchase_status, purchase_grand_total, purchase_date) VALUES ('" + cmbMedicine.Text
                        + "', '" + cmbCategory.Text
                        + "', '" + cmbSupplier.Text
                        + "', '" + txtPurchaseCode.Text
                        + "', '" + txtQuantity.Text
                        + "', '" + txtDesc.Text
                        + "', '" + cmbPaymentMethod.Text
                        + "', '" + cmbStatus.Text
                        + "', '" + txtGrandTotal.Text
                        + "', '" + dtpPurchase.Value.ToLongDateString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    if (cmbStatus.Text == "Сплачено") {
                        current_medicineQuantity = current_medicineQuantity + Convert.ToInt32(txtQuantity.Text);

                        cmd = new OleDbCommand("UPDATE Медикаменти SET medicine_quantity ='" + current_medicineQuantity +
                            "' WHERE medicine_name ='" + cmbMedicine.Text + "'", conn);

                        cmd.ExecuteNonQuery();
                    }

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                        + "', '" + "Створення"
                        + "', '" + "Cтворення замовлення #" + txtPurchaseCode.Text + " на закупівлю мед. препарата \"" + cmbMedicine.Text + "\" користувачем " + ucLog.acc
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно створили замовлення на закупівлю мед. препарата \"" + cmbMedicine.Text + "\".")).ShowDialog();

                    cmbMedicine.Text = "- Назва медикаменту -";
                    cmbCategory.Text = "- Категорія -";
                    cmbSupplier.Text = "- Постачальник -";

                    txtQuantity.Text = "Введіть кількість";
                    txtDesc.Text = "";

                    cmbPaymentMethod.Text = "- Оберіть спосіб оплати -";
                    cmbStatus.Text = "- Статус -";

                    txtGrandTotal.Text = "";

                    GenerateCode(8);

                    ucMedicine.instance.GetMedicineList("SELECT * FROM Медикаменти");
                    ucPurchase.instance.GetPurchaseList("SELECT * FROM Закупівля");
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

            var purchase_code = new String(stringChars);

            txtPurchaseCode.Text = purchase_code;
        }

        private void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                cmbMedicine.BaseColor = Color.FromArgb(39, 39, 39);
                cmbMedicine.BorderColor = Color.Gray;
                cmbMedicine.ForeColor = Color.Gray;

                cmbCategory.BaseColor = Color.FromArgb(39, 39, 39);
                cmbCategory.BorderColor = Color.Gray;
                cmbCategory.ForeColor = Color.Gray;

                cmbSupplier.BaseColor = Color.FromArgb(39, 39, 39);
                cmbSupplier.BorderColor = Color.Gray;
                cmbSupplier.ForeColor = Color.Gray;

                txtPurchaseCode.BaseColor = Color.FromArgb(39, 39, 39);
                txtPurchaseCode.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtPurchaseCode.BorderColor = Color.Gray;
                txtPurchaseCode.ForeColor = Color.Gray;
                txtPurchaseCode.FocusedForeColor = Color.Gray;

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

                cmbPaymentMethod.BaseColor = Color.FromArgb(39, 39, 39);
                cmbPaymentMethod.BorderColor = Color.Gray;
                cmbPaymentMethod.ForeColor = Color.Gray;

                cmbStatus.BaseColor = Color.FromArgb(39, 39, 39);
                cmbStatus.BorderColor = Color.Gray;
                cmbStatus.ForeColor = Color.Gray;

                dtpPurchase.BaseColor = Color.FromArgb(39, 39, 39);
                dtpPurchase.BorderColor = Color.Gray;
                dtpPurchase.OnHoverBorderColor = Color.Gray;
                dtpPurchase.ForeColor = Color.Gray;
                dtpPurchase.OnHoverForeColor = Color.Gray;
                dtpPurchase.OnHoverBaseColor = Color.FromArgb(39, 39, 39);

                txtGrandTotal.BaseColor = Color.FromArgb(39, 39, 39);
                txtGrandTotal.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtGrandTotal.BorderColor = Color.Gray;
                txtGrandTotal.ForeColor = Color.Gray;
                txtGrandTotal.FocusedForeColor = Color.Gray;

                btnAdd.BaseColor = Color.FromArgb(39, 39, 39);
                btnAdd.BorderColor = Color.Gray;
            }
        }
    }
}