using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class ucMedicine : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbCommand cmd;

        public string selectedMedicineName, selectedMedicineBatchNo;

        private static ucMedicine _instance;

        public static ucMedicine instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMedicine();
                return _instance;
            }
        }

        public ucMedicine()
        {
            InitializeComponent();

            GetMedicineList("SELECT * FROM Медикаменти");
        }

        private void btnNewMedicine_Click(object sender, EventArgs e)
        {
            (new frmAddMedicine()).ShowDialog();
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
            if (txtSearch.Text != "Пошук" && dataGridMedicines != null)
                GetMedicineList("SELECT * FROM Медикаменти WHERE medicine_name LIKE '" + txtSearch.Text + "%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetMedicineList("SELECT * FROM Медикаменти");

            txtSearch.Text = "Пошук";
        }

        private void dataGridMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMedicines != null && dataGridMedicines.SelectedRows.Count != 0) {
                selectedMedicineName = dataGridMedicines.SelectedRows[0].Cells[1].Value.ToString();
                selectedMedicineBatchNo = dataGridMedicines.SelectedRows[0].Cells[4].Value.ToString();
            }

            if (e.ColumnIndex == 7)
                (new frmEditMedicine()).ShowDialog();

            if (e.ColumnIndex == 8) {
                try {
                    var answer = MessageBox.Show("Ви дійсно бажаєте видалити медикамент \"" + selectedMedicineName + "\" з списку?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (answer == DialogResult.Yes) {
                        conn.Open();

                        cmd = new OleDbCommand("DELETE * FROM Медикаменти WHERE medicine_batch_no = '" + selectedMedicineBatchNo + "'", conn);

                        cmd.ExecuteNonQuery();

                        cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                            + "', '" + "Видалення"
                            + "', '" + "Видалення мед. препарату \"" + selectedMedicineName + "\" користувачем " + ucLog.acc
                            + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно видалили мед. препарат \"" + selectedMedicineName + "\".")).ShowDialog();

                        GetMedicineList("SELECT * FROM Медикаменти");
                        ucEvents.instance.GetEventList("SELECT * FROM Події");
                    }
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        public void GetMedicineList(string query)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand(query, conn);

                dataGridMedicines.Rows.Clear();

                odr = cmd.ExecuteReader();

                int i = 0;

                while (odr.Read()) {
                    i++;

                    dataGridMedicines.Rows.Add();

                    dataGridMedicines.Rows[dataGridMedicines.Rows.Count - 1].Cells["medicine_no"].Value = "    " + i.ToString();
                    dataGridMedicines.Rows[dataGridMedicines.Rows.Count - 1].Cells["medicine_name"].Value = odr[1].ToString();
                    dataGridMedicines.Rows[dataGridMedicines.Rows.Count - 1].Cells["medicine_category"].Value = odr[2].ToString();
                    dataGridMedicines.Rows[dataGridMedicines.Rows.Count - 1].Cells["medicine_supplier"].Value = odr[3].ToString();
                    dataGridMedicines.Rows[dataGridMedicines.Rows.Count - 1].Cells["medicine_rack"].Value = odr[4].ToString();
                    dataGridMedicines.Rows[dataGridMedicines.Rows.Count - 1].Cells["medicine_batch_no"].Value = odr[5].ToString();
                    dataGridMedicines.Rows[dataGridMedicines.Rows.Count - 1].Cells["medicine_quantity"].Value = odr[7].ToString();
                }

                dataGridMedicines.ClearSelection();

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                btnNewMedicine.BaseColor = Color.FromArgb(39, 39, 39);
                btnNewMedicine.BorderColor = Color.Gray;

                pctBoxSearch.BackColor = Color.FromArgb(39, 39, 39);

                txtSearch.BaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.BorderColor = Color.Gray;
                txtSearch.ForeColor = Color.Gray;
                txtSearch.FocusedForeColor = Color.Gray;

                btnRefresh.BaseColor = Color.FromArgb(39, 39, 39);
                btnRefresh.BorderColor = Color.Gray;

                pnlMedicineList.BaseColor = Color.FromArgb(39, 39, 39);

                dataGridMedicines.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridMedicines.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridMedicines.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dataGridMedicines.ThemeStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridMedicines.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridMedicines.ThemeStyle.RowsStyle.SelectionForeColor = Color.Silver;
            } else {
                this.BackColor = Color.WhiteSmoke;

                btnNewMedicine.BaseColor = Color.WhiteSmoke;
                btnNewMedicine.BorderColor = Color.Silver;

                pctBoxSearch.BackColor = Color.WhiteSmoke;

                txtSearch.BaseColor = Color.WhiteSmoke;
                txtSearch.FocusedBaseColor = Color.WhiteSmoke;
                txtSearch.BorderColor = Color.Silver;
                txtSearch.ForeColor = Color.DimGray;
                txtSearch.FocusedForeColor = Color.Black;

                btnRefresh.BaseColor = Color.WhiteSmoke;
                btnRefresh.BorderColor = Color.Silver;

                pnlMedicineList.BaseColor = Color.White;

                dataGridMedicines.ThemeStyle.RowsStyle.BackColor = Color.White;
                dataGridMedicines.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
                dataGridMedicines.ThemeStyle.RowsStyle.SelectionBackColor = Color.WhiteSmoke;
                dataGridMedicines.ThemeStyle.BackColor = Color.White;
                dataGridMedicines.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridMedicines.ThemeStyle.RowsStyle.SelectionForeColor = Color.DimGray;
            }
        }
    }
}