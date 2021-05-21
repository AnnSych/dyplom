using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class frmEditPurchase : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        public frmEditPurchase()
        {
            InitializeComponent();

            this.Text = "pharma+";
            this.Select();

            cmbMedicine.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            cmbPaymentMethod.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

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

                oda = new OleDbDataAdapter("SELECT * FROM Закупівля WHERE purchase_code ='" + ucPurchase.instance.selectedPurchaseCode + "'", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows) {
                    cmbMedicine.Text = row["medicine_name"].ToString();
                    cmbCategory.Text = row["medicine_category"].ToString();
                    cmbSupplier.Text = row["supplier_name"].ToString();

                    txtPurchaseCode.Text = row["purchase_code"].ToString();
                    txtQuantity.Text = row["medicine_quantity"].ToString();
                    txtDesc.Text = row["purchase_desc"].ToString();

                    cmbPaymentMethod.Text = row["puchase_payment_method"].ToString();
                    cmbStatus.Text = row["purchase_status"].ToString();

                    txtGrandTotal.Text = row["purchase_grand_total"].ToString();

                    dtpPurchase.Value = Convert.ToDateTime(row["purchase_date"].ToString());
                }
            } finally {
                conn.Close();
            }
        }

        private void frmEditPurchase_Activated(object sender, EventArgs e)
        {
            ChangeTheme(frmAcc.isNight);
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

        private void cmbPaymentMethod_Enter(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbPaymentMethod.BorderColor = Color.Gray;
            else
                cmbPaymentMethod.BorderColor = Color.Silver;
        }

        private void cmbPaymentMethod_Leave(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbPaymentMethod.BorderColor = Color.Gray;
            else
                cmbPaymentMethod.BorderColor = Color.Silver;
        }

        private void cmbStatus_Enter(object sender, EventArgs e)
        {
            if (frmAcc.isNight == true)
                cmbStatus.BorderColor = Color.Gray;
            else
                cmbStatus.BorderColor = Color.Silver;
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "Введіть кількість" || cmbPaymentMethod.Text == "- Оберіть спосіб оплати -" || cmbStatus.Text == "- Статус -" || txtGrandTotal.Text == "") {
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

                    cmd = new OleDbCommand("UPDATE Закупівля SET medicine_quantity ='" + txtQuantity.Text +
                        "', puchase_payment_method ='" + cmbPaymentMethod.Text +
                        "', purchase_status ='" + cmbStatus.Text +
                        "', purchase_grand_total ='" + txtGrandTotal.Text + "' WHERE purchase_code ='" + ucPurchase.instance.selectedPurchaseCode + "'", conn);

                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                        + "', '" + "Оновлення"
                        + "', '" + "Оновлення даних заявки #" + ucPurchase.instance.selectedPurchaseCode + " на закупівлю мед. перепарата \"" + ucPurchase.instance.selectedMedicineName + "\" користувачем " + ucLog.acc
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    (new MsgBox(Type.INFORMATION, "pharma+", "Дані оновлено.")).ShowDialog();

                    ucPurchase.instance.GetPurchaseList("SELECT * FROM закупівля");
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

                btnUpdate.BaseColor = Color.FromArgb(39, 39, 39);
                btnUpdate.BorderColor = Color.Gray;
            }
        }
    }
}