using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class frmEditMedicine : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        public frmEditMedicine()
        {
            InitializeComponent();

            this.Text = "pharma+";
            this.Select();

            cmbCategory.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            cmbRack.SelectedIndex = 0;

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

                oda = new OleDbDataAdapter("SELECT * FROM Медикаменти WHERE medicine_batch_no ='" + ucMedicine.instance.selectedMedicineBatchNo + "'", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows) {
                    txtMedicineName.Text = row["medicine_name"].ToString();

                    cmbCategory.Text = row["medicine_category"].ToString();
                    cmbSupplier.Text = row["medicine_supplier"].ToString();
                    cmbRack.Text = row["medicine_rack"].ToString();

                    txtBatchNo.Text = row["medicine_batch_no"].ToString();
                    txtQuantity.Text = row["medicine_quantity"].ToString();
                    txtDesc.Text = row["medicine_desc"].ToString();

                    dtpStart.Value = Convert.ToDateTime(row["medicine_start"].ToString());
                    dtpEnd.Value = Convert.ToDateTime(row["medicine_end"].ToString());
                }
            } finally {
                conn.Close();
            }
        }

        private void frmEditMedicine_Activated(object sender, EventArgs e)
        {
            ChangeTheme(frmAcc.isNight);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "- Категорія -" || cmbSupplier.Text == "- Постачальник -" || cmbRack.Text == "- Стелаж -" || txtQuantity.Text == "Введіть кількість") {
                if (cmbCategory.Text == "- Категорія -")
                    cmbCategory.BorderColor = Color.Red;

                if (cmbSupplier.Text == "- Постачальник -")
                    cmbSupplier.BorderColor = Color.Red;

                if (cmbRack.Text == "- Стелаж -")
                    cmbRack.BorderColor = Color.Red;

                if (txtQuantity.Text == "Введіть кількість")
                    txtQuantity.BorderColor = Color.Red;
            } else {
                try {
                    conn.Open();

                    cmd = new OleDbCommand("UPDATE Медикаменти SET medicine_category ='" + cmbCategory.Text +
                        "', medicine_supplier ='" + cmbSupplier.Text +
                        "', medicine_rack ='" + cmbRack.Text +
                        "', medicine_quantity ='" + txtQuantity.Text +
                        "', medicine_desc ='" + txtDesc.Text +
                        "', medicine_start ='" + dtpStart.Value.ToLongDateString() +
                        "', medicine_end ='" + dtpEnd.Value.ToLongDateString() + "' WHERE medicine_name ='" + ucMedicine.instance.selectedMedicineName + "'", conn);

                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                        + "', '" + "Оновлення"
                        + "', '" + "Оновлення даних мед. препарата \"" + ucMedicine.instance.selectedMedicineName + "\" користувачем " + ucLog.acc
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    (new MsgBox(Type.INFORMATION, "pharma+", "Дані оновлено.")).ShowDialog();

                    ucMedicine.instance.GetMedicineList("SELECT * FROM Медикаменти");
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

                btnUpdate.BaseColor = Color.FromArgb(39, 39, 39);
                btnUpdate.BorderColor = Color.Gray;
            }
        }
    }
}