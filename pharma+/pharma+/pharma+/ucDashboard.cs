using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class ucDashboard : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        public enum Stats { MEDICINE, TOTALMEDICINE, SUPPLIERS, USERS, PURCHASE, TOTALPURCHASE, CATEGORY, RACKS, MEDICINESLOWTOCKLIST }

        private static ucDashboard _instance;

        public static ucDashboard instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDashboard();
                return _instance;
            }
        }

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetStatistics("SELECT * FROM Медикаменти", Stats.MEDICINE);
            GetStatistics("SELECT medicine_quantity FROM Медикаменти", Stats.TOTALMEDICINE); 
            GetStatistics("SELECT * FROM Постачальники", Stats.SUPPLIERS);
            GetStatistics("SELECT * FROM Користувачи", Stats.USERS);
            GetStatistics("SELECT * FROM Закупівля", Stats.PURCHASE);
            GetStatistics("SELECT purchase_grand_total FROM Закупівля", Stats.TOTALPURCHASE);
            GetStatistics("SELECT * FROM Категорії", Stats.CATEGORY);
            GetStatistics("SELECT * FROM Стелажі", Stats.RACKS);
            GetStatistics("SELECT * FROM Медикаменти WHERE medicine_quantity <= " + 100 + " ORDER BY medicine_quantity", Stats.MEDICINESLOWTOCKLIST);

            txtSearch.Text = "Пошук";
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
            if (txtSearch.Text != "Пошук" && dataGridMedicineLowStockList != null)
                GetStatistics("SELECT * FROM Медикаменти WHERE medicine_quantity <= " + 100 + " AND medicine_name LIKE '" + txtSearch.Text + "%'", Stats.MEDICINESLOWTOCKLIST);
        }

        public void GetStatistics(string query, Stats stats)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand(query, conn);

                odr = cmd.ExecuteReader();

                int i = 0;

                while (odr.Read())
                    i++;

                if (stats == Stats.MEDICINE)
                    lblMedicineCount.Text = i.ToString();

                if (stats == Stats.TOTALMEDICINE) {
                    oda = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();

                    oda.Fill(dt);

                    long total_quantity = 0;
                    long quantity = 0;

                    foreach (DataRow row in dt.Rows) {
                        quantity = Convert.ToInt64(row["medicine_quantity"].ToString());

                        total_quantity = total_quantity + quantity;
                    }

                    if (total_quantity == 0)
                        lblMedicineTotalCount.Text = Convert.ToString(total_quantity);
                    else
                        lblMedicineTotalCount.Text = Convert.ToString(total_quantity) + "+";
                }

                if (stats == Stats.SUPPLIERS)
                    if (i == 0)
                        lblSuppliersCount.Text = i.ToString();
                    else
                        lblSuppliersCount.Text = i.ToString() + "+";

                if (stats == Stats.USERS)
                    if (i == 0)
                        lblUserCount.Text = i.ToString();
                    else
                        lblUserCount.Text = i.ToString() + "+";

                if (stats == Stats.PURCHASE)
                    if (i == 0)
                        lblPurchaseCount.Text = i.ToString();
                    else
                        lblPurchaseCount.Text = i.ToString() + "";

                if (stats == Stats.TOTALPURCHASE) {
                    oda = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();

                    oda.Fill(dt);

                    long grand_total = 0;
                    long total = 0;

                    foreach (DataRow row in dt.Rows) {
                        total = Convert.ToInt64(row["purchase_grand_total"].ToString());

                        grand_total = grand_total + total;
                    }

                    if (grand_total == 0)
                        lblPurchaseTotalCount.Text = Convert.ToString(grand_total);
                    else
                        lblPurchaseTotalCount.Text = Convert.ToString(grand_total) + "+";
                }

                if (stats == Stats.CATEGORY)
                    if (i == 0)
                        lblCategoryCount.Text = i.ToString();
                    else
                        lblCategoryCount.Text = i.ToString() + "+";


                if (stats == Stats.RACKS)
                    if (i == 0)
                        lblRacksCount.Text = i.ToString();
                    else
                        lblRacksCount.Text = i.ToString() + "+";

                if (stats == Stats.MEDICINESLOWTOCKLIST) {
                    try {
                        cmd = new OleDbCommand(query, conn);

                        dataGridMedicineLowStockList.Rows.Clear();

                        odr = cmd.ExecuteReader();

                        i = 0;

                        while (odr.Read()) {
                            i++;

                            dataGridMedicineLowStockList.Rows.Add();

                            dataGridMedicineLowStockList.Rows[dataGridMedicineLowStockList.Rows.Count - 1].Cells["medicine_no"].Value = "    " + i.ToString();
                            dataGridMedicineLowStockList.Rows[dataGridMedicineLowStockList.Rows.Count - 1].Cells["medicine_name"].Value = odr[1].ToString();
                            dataGridMedicineLowStockList.Rows[dataGridMedicineLowStockList.Rows.Count - 1].Cells["medicine_batch_no"].Value = odr[5].ToString();
                            dataGridMedicineLowStockList.Rows[dataGridMedicineLowStockList.Rows.Count - 1].Cells["medicine_supplier"].Value = odr[3].ToString();
                            dataGridMedicineLowStockList.Rows[dataGridMedicineLowStockList.Rows.Count - 1].Cells["medicine_quantity"].Value = odr[7].ToString();
                        }

                        dataGridMedicineLowStockList.ClearSelection();

                        if (i == 0)
                            lblLowStockMedicineList.Text = "НИЗЬКА КІЛЬКІСТЬ МЕД. ПРЕПАРАТІВ (НЕМАЄ ДАНИХ)";
                        else
                            lblLowStockMedicineList.Text = "НИЗЬКА КІЛЬКІСТЬ МЕД. ПРЕПАРАТІВ";
                    } catch (Exception ex) {
                        (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                    }
                }

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                btnRefresh.BaseColor = Color.FromArgb(39, 39, 39);
                btnRefresh.BorderColor = Color.Gray;

                pnlMedicine.BaseColor = Color.FromArgb(39, 39, 39);
                pnlTotalMedicine.BaseColor = Color.FromArgb(39, 39, 39);
                pnlSuppliers.BaseColor = Color.FromArgb(39, 39, 39);
                pnlUsers.BaseColor = Color.FromArgb(39, 39, 39);
                pnlPurchase.BaseColor = Color.FromArgb(39, 39, 39);
                pnlTotalPurchase.BaseColor = Color.FromArgb(39, 39, 39);
                pnlCategory.BaseColor = Color.FromArgb(39, 39, 39);
                pnlRacks.BaseColor = Color.FromArgb(39, 39, 39);

                pnlLowStockMedicineList.BaseColor = Color.FromArgb(39, 39, 39);

                pctBoxSearch.BackColor = Color.FromArgb(18, 18, 18);

                txtSearch.BaseColor = Color.FromArgb(18, 18, 18);
                txtSearch.FocusedBaseColor = Color.FromArgb(18, 18, 18);
                txtSearch.BorderColor = Color.Gray;
                txtSearch.ForeColor = Color.Gray;
                txtSearch.FocusedForeColor = Color.Gray;

                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridMedicineLowStockList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dataGridMedicineLowStockList.ThemeStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.SelectionForeColor = Color.Silver;
            } else {
                this.BackColor = Color.WhiteSmoke;

                btnRefresh.BaseColor = Color.WhiteSmoke;
                btnRefresh.BorderColor = Color.Silver;

                pnlMedicine.BaseColor = Color.White;
                pnlTotalMedicine.BaseColor = Color.White;
                pnlSuppliers.BaseColor = Color.White;
                pnlUsers.BaseColor = Color.White;
                pnlPurchase.BaseColor = Color.White;
                pnlTotalPurchase.BaseColor = Color.White;
                pnlCategory.BaseColor = Color.White;
                pnlRacks.BaseColor = Color.White;

                pnlLowStockMedicineList.BaseColor = Color.White;

                pctBoxSearch.BackColor = Color.WhiteSmoke;

                txtSearch.BaseColor = Color.WhiteSmoke;
                txtSearch.FocusedBaseColor = Color.WhiteSmoke;
                txtSearch.BorderColor = Color.Silver;
                txtSearch.ForeColor = Color.DimGray;
                txtSearch.FocusedForeColor = Color.Black;

                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.BackColor = Color.White;
                dataGridMedicineLowStockList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.SelectionBackColor = Color.WhiteSmoke;
                dataGridMedicineLowStockList.ThemeStyle.BackColor = Color.White;
                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridMedicineLowStockList.ThemeStyle.RowsStyle.SelectionForeColor = Color.DimGray;
            }
        }
    }
}