using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class ucSupplier : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbCommand cmd;

        private string selectedSupplierName, selectedSupplierEmail, selectedSupplierPhone, selectedSupplierAddress, selectedSupplierDesc;

        private static ucSupplier _instance;

        public static ucSupplier instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSupplier();
                return _instance;
            }
        }

        public ucSupplier()
        {
            InitializeComponent();

            GetSupplierList("SELECT * FROM Постачальники");
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            (new frmAddSupplier()).ShowDialog();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Пошук")
                txtSearch.Text = "";

            if (frmAcc.isNight == true) {
                txtSearch.BorderColor = Color.Gray;
                txtSearch.FocusedBorderColor = Color.Gray;
            } else {
                txtSearch.BorderColor = Color.Silver;
                txtSearch.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = "Пошук";

            if (frmAcc.isNight == true) {
                txtSearch.BorderColor = Color.Gray;
                txtSearch.FocusedBorderColor = Color.Gray;
            } else {
                txtSearch.BorderColor = Color.Silver;
                txtSearch.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Пошук" && dataGridSuppliers != null)
                GetSupplierList("SELECT * FROM Постачальники WHERE supplier_name LIKE '" + txtSearch.Text + "%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetSupplierList("SELECT * FROM Постачальники");

            txtSearch.Text = "Пошук";
        }

        private void dataGridSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSuppliers != null && dataGridSuppliers.SelectedRows.Count != 0) {
                selectedSupplierName = dataGridSuppliers.SelectedRows[0].Cells[1].Value.ToString();
                selectedSupplierEmail = dataGridSuppliers.SelectedRows[0].Cells[2].Value.ToString();
                selectedSupplierPhone = dataGridSuppliers.SelectedRows[0].Cells[3].Value.ToString();
                selectedSupplierAddress = dataGridSuppliers.SelectedRows[0].Cells[4].Value.ToString();
                selectedSupplierDesc = dataGridSuppliers.SelectedRows[0].Cells[5].Value.ToString();
            }

            if (e.ColumnIndex == 6)
                (new MsgBox(Type.INFORMATION, "pharma+", "Постачальник: " + selectedSupplierName + "\n" + "Електронна пошта: " + selectedSupplierEmail + "\n" + "Телефон: " + selectedSupplierPhone + "\n" + "Адреса: " + selectedSupplierAddress + "\n\n" + "Опис:\n" + selectedSupplierDesc)).ShowDialog();

            if (e.ColumnIndex == 7) {
                try {
                    var answer = MessageBox.Show("Ви дійсно бажаєте видалити постачальника \"" + selectedSupplierName + "\" з списку?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (answer == DialogResult.Yes) {
                        conn.Open();

                        cmd = new OleDbCommand("DELETE * FROM Постачальники WHERE supplier_name = '" + selectedSupplierName + "'", conn);

                        cmd.ExecuteNonQuery();

                        cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                            + "', '" + "Видалення"
                            + "', '" + "Видалення постачальника \"" + selectedSupplierName + "\" користувачем " + ucLog.acc
                            + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно видалили постачальнкиа \"" + selectedSupplierName + "\".")).ShowDialog();

                        GetSupplierList("SELECT * FROM Постачальники");
                        ucEvents.instance.GetEventList("SELECT * FROM Події");
                    }
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        public void GetSupplierList(string query)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand(query, conn);

                dataGridSuppliers.Rows.Clear();

                odr = cmd.ExecuteReader();

                int i = 0;

                while (odr.Read()) {
                    i++;

                    dataGridSuppliers.Rows.Add();

                    dataGridSuppliers.Rows[dataGridSuppliers.Rows.Count - 1].Cells["supplier_no"].Value = "    " + i.ToString();
                    dataGridSuppliers.Rows[dataGridSuppliers.Rows.Count - 1].Cells["supplier_name"].Value = odr[1].ToString();
                    dataGridSuppliers.Rows[dataGridSuppliers.Rows.Count - 1].Cells["supplier_email"].Value = odr[2].ToString();
                    dataGridSuppliers.Rows[dataGridSuppliers.Rows.Count - 1].Cells["supplier_phone"].Value = odr[3].ToString();
                    dataGridSuppliers.Rows[dataGridSuppliers.Rows.Count - 1].Cells["supplier_address"].Value = odr[4].ToString();
                    dataGridSuppliers.Rows[dataGridSuppliers.Rows.Count - 1].Cells["supplier_desc"].Value = odr[5].ToString();
                }

                dataGridSuppliers.ClearSelection();

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                btnNewSupplier.BaseColor = Color.FromArgb(39, 39, 39);
                btnNewSupplier.BorderColor = Color.Gray;

                pctBoxSearch.BackColor = Color.FromArgb(39, 39, 39);

                txtSearch.BaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.BorderColor = Color.Gray;
                txtSearch.ForeColor = Color.Gray;
                txtSearch.FocusedForeColor = Color.Gray;

                btnRefresh.BaseColor = Color.FromArgb(39, 39, 39);
                btnRefresh.BorderColor = Color.Gray;

                pnlSuppliersList.BaseColor = Color.FromArgb(39, 39, 39);

                dataGridSuppliers.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridSuppliers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridSuppliers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dataGridSuppliers.ThemeStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridSuppliers.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridSuppliers.ThemeStyle.RowsStyle.SelectionForeColor = Color.Silver;
            } else {
                this.BackColor = Color.WhiteSmoke;

                btnNewSupplier.BaseColor = Color.WhiteSmoke;
                btnNewSupplier.BorderColor = Color.Silver;

                pctBoxSearch.BackColor = Color.WhiteSmoke;

                txtSearch.BaseColor = Color.WhiteSmoke;
                txtSearch.FocusedBaseColor = Color.WhiteSmoke;
                txtSearch.BorderColor = Color.Silver;
                txtSearch.ForeColor = Color.DimGray;
                txtSearch.FocusedForeColor = Color.Black;

                btnRefresh.BaseColor = Color.WhiteSmoke;
                btnRefresh.BorderColor = Color.Silver;

                pnlSuppliersList.BaseColor = Color.White;

                dataGridSuppliers.ThemeStyle.RowsStyle.BackColor = Color.White;
                dataGridSuppliers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
                dataGridSuppliers.ThemeStyle.RowsStyle.SelectionBackColor = Color.WhiteSmoke;
                dataGridSuppliers.ThemeStyle.BackColor = Color.White;
                dataGridSuppliers.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridSuppliers.ThemeStyle.RowsStyle.SelectionForeColor = Color.DimGray;
            }
        }
    }
}