using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class ucCategory : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbCommand cmd;

        private bool isDuplicate = false;
        private string selectedCategory, selectedDescription;

        private static ucCategory _instance;

        public static ucCategory instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCategory();
                return _instance;
            }
        }

        public ucCategory()
        {
            InitializeComponent();

            GetCategoryList("SELECT * FROM Категорії");
        }

        private void txtCategoryName_Enter(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "Введіть назву")
                txtCategoryName.Text = "";

            if (frmAcc.isNight == true) {
                txtCategoryName.BorderColor = Color.Gray;
                txtCategoryName.FocusedBorderColor = Color.Gray;
            } else {
                txtCategoryName.BorderColor = Color.Silver;
                txtCategoryName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtCategoryName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                txtCategoryName.Text = "Введіть назву";

            if (frmAcc.isNight == true) {
                txtCategoryName.BorderColor = Color.Gray;
                txtCategoryName.FocusedBorderColor = Color.Gray;
            } else {
                txtCategoryName.BorderColor = Color.Silver;
                txtCategoryName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand("SELECT category_name FROM Категорії WHERE category_name ='" + txtCategoryName.Text + "'", conn);

                odr = cmd.ExecuteReader();

                if (odr.Read() == true)
                    isDuplicate = true;
                else
                    isDuplicate = false;
            } finally {
                conn.Close();
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
            if (txtCategoryName.Text == "Введіть назву" || isDuplicate == true) {
                if (txtCategoryName.Text == "Введіть назву")
                    txtCategoryName.BorderColor = Color.Red;

                if (isDuplicate == true) {
                    txtCategoryName.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Категорія з такою назвою вже існує.")).ShowDialog();
                }
            } else {
                try {
                    conn.Open();

                    cmd = new OleDbCommand("INSERT INTO Категорії (category_name, category_desc) VALUES ('" + txtCategoryName.Text 
                        + "', '" + txtDesc.Text + "')", conn);

                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                        + "', '" + "Створення"
                        + "', '" + "Створення нової категорії \"" + txtCategoryName.Text + "\" користувачем " + ucLog.acc
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    txtCategoryName.Text = "Введіть назву";
                    txtDesc.Text = "";

                    GetCategoryList("SELECT * FROM Категорії");
                    ucEvents.instance.GetEventList("SELECT * FROM Події");
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                } 
            }
        }

        private void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCategory != null && dataGridCategory.SelectedRows.Count != 0) {
                selectedCategory = dataGridCategory.SelectedRows[0].Cells[0].Value.ToString().Trim();
                selectedDescription = dataGridCategory.SelectedRows[0].Cells[1].Value.ToString();

                Tips.SetToolTip(dataGridCategory, selectedDescription);
            }        

            if (e.ColumnIndex == 2) {
                try {
                    var answer = MessageBox.Show("Ви дійсно бажаєте видалити категорію \"" + selectedCategory + "\" з списку?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (answer == DialogResult.Yes)  {
                        conn.Open();

                        cmd = new OleDbCommand("DELETE * FROM Категорії WHERE category_name = '" + selectedCategory + "'", conn);

                        cmd.ExecuteNonQuery();

                        cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                            + "', '" + "Видалення"
                            + "', '" + "Видалення категорії \"" + selectedCategory + "\" користувачем " + ucLog.acc
                            + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно видалили категорію \"" + selectedCategory + "\".")).ShowDialog();

                        GetCategoryList("SELECT * FROM Категорії");
                        ucEvents.instance.GetEventList("SELECT * FROM Події");
                    }
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        public void GetCategoryList(string query)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand(query, conn);

                dataGridCategory.Rows.Clear();

                odr = cmd.ExecuteReader();

                while (odr.Read()) {
                    dataGridCategory.Rows.Add();

                    dataGridCategory.Rows[dataGridCategory.Rows.Count - 1].Cells["category_name"].Value = "    " + odr[1].ToString();
                    dataGridCategory.Rows[dataGridCategory.Rows.Count - 1].Cells["category_desc"].Value = odr[2].ToString();
                }

                dataGridCategory.ClearSelection();

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                txtCategoryName.BaseColor = Color.FromArgb(18, 18, 18);
                txtCategoryName.FocusedBaseColor = Color.FromArgb(18, 18, 18);
                txtCategoryName.BorderColor = Color.Gray;
                txtCategoryName.ForeColor = Color.Gray;
                txtCategoryName.FocusedForeColor = Color.Gray;

                txtDesc.BaseColor = Color.FromArgb(18, 18, 18);
                txtDesc.FocusedBaseColor = Color.FromArgb(18, 18, 18);
                txtDesc.BorderColor = Color.Gray;
                txtDesc.ForeColor = Color.Gray;
                txtDesc.FocusedForeColor = Color.Gray;

                btnAdd.BaseColor = Color.FromArgb(39, 39, 39);
                btnAdd.BorderColor = Color.Gray;

                pnlCategory.BaseColor = Color.FromArgb(39, 39, 39);

                dataGridCategory.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridCategory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridCategory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dataGridCategory.ThemeStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridCategory.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridCategory.ThemeStyle.RowsStyle.SelectionForeColor = Color.Silver;

                pnlCategoryList.BaseColor = Color.FromArgb(39, 39, 39);
            } else {
                this.BackColor = Color.WhiteSmoke;

                txtCategoryName.BaseColor = Color.WhiteSmoke;
                txtCategoryName.FocusedBaseColor = Color.WhiteSmoke;
                txtCategoryName.BorderColor = Color.Silver;
                txtCategoryName.ForeColor = Color.Gray;
                txtCategoryName.FocusedForeColor = Color.Black;

                txtDesc.BaseColor = Color.WhiteSmoke;
                txtDesc.FocusedBaseColor = Color.WhiteSmoke;
                txtDesc.BorderColor = Color.Silver;
                txtDesc.ForeColor = Color.Gray;
                txtDesc.FocusedForeColor = Color.Black;

                btnAdd.BaseColor = Color.WhiteSmoke;
                btnAdd.BorderColor = Color.Silver;

                pnlCategory.BaseColor = Color.White;

                dataGridCategory.ThemeStyle.RowsStyle.BackColor = Color.White;
                dataGridCategory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
                dataGridCategory.ThemeStyle.RowsStyle.SelectionBackColor = Color.WhiteSmoke;
                dataGridCategory.ThemeStyle.BackColor = Color.White;
                dataGridCategory.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridCategory.ThemeStyle.RowsStyle.SelectionForeColor = Color.DimGray;

                pnlCategoryList.BaseColor = Color.White;
            }
        }
    }
}