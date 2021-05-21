using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace pharma_
{
    public partial class ucPurchase : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbCommand cmd;
        OleDbDataAdapter oda;
        DataTable dt;

        public string selectedMedicineName, selectedPurchaseCode;

        private static ucPurchase _instance;

        public static ucPurchase instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPurchase();
                return _instance;
            }
        }

        public ucPurchase()
        {
            InitializeComponent();

            GetPurchaseList("SELECT * FROM Закупівля");
        }

        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            (new frmAddPurchase()).ShowDialog();
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
            if (txtSearch.Text != "Пошук" && dataGridPurchases != null)
                GetPurchaseList("SELECT * FROM Закупівля WHERE medicine_name LIKE '" + txtSearch.Text + "%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetPurchaseList("SELECT * FROM Закупівля");

            txtSearch.Text = "Пошук";
        }

        private void dataGridPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPurchases != null && dataGridPurchases.SelectedRows.Count != 0) {
                selectedMedicineName = dataGridPurchases.SelectedRows[0].Cells[1].Value.ToString();
                selectedPurchaseCode = dataGridPurchases.SelectedRows[0].Cells[4].Value.ToString();
            }

            if (e.ColumnIndex == 6)
                (new frmEditPurchase()).ShowDialog();

            if (e.ColumnIndex == 7) {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Файл PDF |* .pdf", ValidateNames = true }) {
                    if (sfd.ShowDialog() == DialogResult.OK) {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);

                        string sysFont = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "GEORGIA.TTF");

                        BaseFont BaseFont = BaseFont.CreateFont(sysFont, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(BaseFont, 12, 0);

                        try {
                            conn.Open();

                            oda = new OleDbDataAdapter("SELECT * FROM Закупівля WHERE purchase_code ='" + selectedPurchaseCode + "'", conn);
                            dt = new DataTable();

                            oda.Fill(dt);

                            foreach (DataRow row in dt.Rows) {
                                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                                doc.Open();

                                doc.Add(new iTextSharp.text.Paragraph(
                                    "PHARMA+" + "\n" + "ID замовлення    #" + row["purchase_code"].ToString() + "\n" +
                                    "=================================================\n" +
                                    "Назва дед. препарату:                 " + row["medicine_name"].ToString() + "\n" +
                                    "Категорія:                                        " + row["medicine_category"].ToString() + "\n" +
                                    "Постачальник:                               " + row["supplier_name"].ToString() + "\n" +
                                    "Кількість (шт):                               " + row["medicine_quantity"].ToString() + "\n" +
                                    "Спосіб оплати:                               " + row["puchase_payment_method"].ToString() + "\n\n" +
                                    "Статус:                                              " + row["purchase_status"].ToString() + "\n" +
                                    "Загальна сумма:                            " + row["purchase_grand_total"].ToString() + " грн." + "\n" +
                                    "Опис:                                                 " + row["purchase_desc"].ToString() + "\n" +
                                    "=================================================\n\n" +
                                    "Дата замовлення:                          " + row["purchase_date"].ToString() + "\n"
                                    , font));
                            }

                            conn.Close();
                        } catch (Exception ex) {
                            (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                        } finally {
                            doc.Close();

                            System.Diagnostics.Process.Start(sfd.FileName);
                        }
                    }
                }
            }

            if (e.ColumnIndex == 8) {
                try {
                    var answer = MessageBox.Show("Ви дійсно бажаєте видалити заяву \"" + selectedPurchaseCode + "\" з списку?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (answer == DialogResult.Yes) {
                        conn.Open();

                        cmd = new OleDbCommand("DELETE * FROM Закупівля WHERE purchase_code = '" + selectedPurchaseCode + "'", conn);

                        cmd.ExecuteNonQuery();

                        cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                            + "', '" + "Видалення"
                            + "', '" + "Видалення заяви #" + selectedPurchaseCode + " на закупівлю мед. препарата \"" + selectedMedicineName + "\" користувачем " + ucLog.acc
                            + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно видалили заяву \"" + selectedPurchaseCode + "\".")).ShowDialog();

                        GetPurchaseList("SELECT * FROM Закупівля");
                        ucEvents.instance.GetEventList("SELECT * FROM Події");
                    }
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        public void GetPurchaseList(string query)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand(query, conn);

                dataGridPurchases.Rows.Clear();

                odr = cmd.ExecuteReader();

                int i = 0;

                while (odr.Read()) {
                    i++;

                    dataGridPurchases.Rows.Add();

                    dataGridPurchases.Rows[dataGridPurchases.Rows.Count - 1].Cells["purchase_no"].Value = "    " + i.ToString();
                    dataGridPurchases.Rows[dataGridPurchases.Rows.Count - 1].Cells["medicine_name"].Value = odr[1].ToString();
                    dataGridPurchases.Rows[dataGridPurchases.Rows.Count - 1].Cells["purchase_category"].Value = odr[2].ToString();
                    dataGridPurchases.Rows[dataGridPurchases.Rows.Count - 1].Cells["purchase_supplier"].Value = odr[3].ToString();
                    dataGridPurchases.Rows[dataGridPurchases.Rows.Count - 1].Cells["purchase_code"].Value = odr[4].ToString();
                    dataGridPurchases.Rows[dataGridPurchases.Rows.Count - 1].Cells["purchase_quantity"].Value = odr[5].ToString();
                }

                dataGridPurchases.ClearSelection();

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                btnNewPurchase.BaseColor = Color.FromArgb(39, 39, 39);
                btnNewPurchase.BorderColor = Color.Gray;

                pctBoxSearch.BackColor = Color.FromArgb(39, 39, 39);

                txtSearch.BaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.BorderColor = Color.Gray;
                txtSearch.ForeColor = Color.Gray;
                txtSearch.FocusedForeColor = Color.Gray;

                btnRefresh.BaseColor = Color.FromArgb(39, 39, 39);
                btnRefresh.BorderColor = Color.Gray;

                pnlPurchaseList.BaseColor = Color.FromArgb(39, 39, 39);

                dataGridPurchases.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridPurchases.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridPurchases.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dataGridPurchases.ThemeStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridPurchases.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridPurchases.ThemeStyle.RowsStyle.SelectionForeColor = Color.Silver;
            } else {
                this.BackColor = Color.WhiteSmoke;

                btnNewPurchase.BaseColor = Color.WhiteSmoke;
                btnNewPurchase.BorderColor = Color.Silver;

                pctBoxSearch.BackColor = Color.WhiteSmoke;

                txtSearch.BaseColor = Color.WhiteSmoke;
                txtSearch.FocusedBaseColor = Color.WhiteSmoke;
                txtSearch.BorderColor = Color.Silver;
                txtSearch.ForeColor = Color.DimGray;
                txtSearch.FocusedForeColor = Color.Black;

                btnRefresh.BaseColor = Color.WhiteSmoke;
                btnRefresh.BorderColor = Color.Silver;

                pnlPurchaseList.BaseColor = Color.White;

                dataGridPurchases.ThemeStyle.RowsStyle.BackColor = Color.White;
                dataGridPurchases.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
                dataGridPurchases.ThemeStyle.RowsStyle.SelectionBackColor = Color.WhiteSmoke;
                dataGridPurchases.ThemeStyle.BackColor = Color.White;
                dataGridPurchases.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridPurchases.ThemeStyle.RowsStyle.SelectionForeColor = Color.DimGray;
            }
        }
    }
}