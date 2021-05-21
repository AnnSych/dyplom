using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace pharma_
{
    public partial class ucRacks : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbCommand cmd;

        private bool isDuplicate = false;
        private string selectedRack, selectedDescription;

        private static ucRacks _instance;

        public static ucRacks instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRacks();
                return _instance;
            }
        }

        public ucRacks()
        {
            InitializeComponent();

            GeteRackList("SELECT * FROM Стелажі");
        }

        private void txtRackName_Enter(object sender, EventArgs e)
        {
            if (txtRackName.Text == "Введіть назву")
                txtRackName.Text = "";

            if (frmAcc.isNight == true) {
                txtRackName.BorderColor = Color.Gray;
                txtRackName.FocusedBorderColor = Color.Gray;
            } else {
                txtRackName.BorderColor = Color.Silver;
                txtRackName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtRackName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRackName.Text))
                txtRackName.Text = "Введіть назву";

            if (frmAcc.isNight == true) {
                txtRackName.BorderColor = Color.Gray;
                txtRackName.FocusedBorderColor = Color.Gray;
            } else {
                txtRackName.BorderColor = Color.Silver;
                txtRackName.FocusedBorderColor = Color.Silver;
            }
        }

        private void txtRackName_TextChanged(object sender, EventArgs e)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand("SELECT rack_name FROM Стелажі WHERE rack_name ='" + txtRackName.Text + "'", conn);

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
            if (txtRackName.Text == "Введіть назву" || isDuplicate == true) {
                if (txtRackName.Text == "Введіть назву")
                    txtRackName.BorderColor = Color.Red;

                if (isDuplicate == true) {
                    txtRackName.BorderColor = Color.Red;

                    (new MsgBox(Type.WARNING, "Увага!", "Стелаж з такою назвою вже існує.")).ShowDialog();
                }
            } else {
                try {
                    conn.Open();

                    cmd = new OleDbCommand("INSERT INTO Стелажі (rack_name, rack_desc) VALUES ('" + txtRackName.Text
                        + "', '" + txtDesc.Text + "')", conn);

                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                        + "', '" + "Створення"
                        + "', '" + "Створення нового стелажу \"" + txtRackName.Text + "\" користувачем " + ucLog.acc
                        + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    txtRackName.Text = "Введіть назву";
                    txtDesc.Text = "";

                    GeteRackList("SELECT * FROM Стелажі");
                    ucEvents.instance.GetEventList("SELECT * FROM Події");
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        private void dataGridRacks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridRacks != null && dataGridRacks.SelectedRows.Count != 0) {
                selectedRack = dataGridRacks.SelectedRows[0].Cells[0].Value.ToString().Trim();
                selectedDescription = dataGridRacks.SelectedRows[0].Cells[1].Value.ToString();

                Tips.SetToolTip(dataGridRacks, selectedDescription);
            }

            if (e.ColumnIndex == 2) {
                try {
                    var answer = MessageBox.Show("Ви дійсно бажаєте видалити стелаж \"" + selectedRack + "\" з списку?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (answer == DialogResult.Yes) {
                        conn.Open();

                        cmd = new OleDbCommand("DELETE * FROM Стелажі WHERE rack_name = '" + selectedRack + "'", conn);

                        cmd.ExecuteNonQuery();

                        cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                            + "', '" + "Видалення"
                            + "', '" + "Видалення стелажу \"" + selectedRack + "\" користувачем " + ucLog.acc
                            + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        (new MsgBox(Type.INFORMATION, "pharma+", "Ви успішно видалили стелаж \"" + selectedRack + "\".")).ShowDialog();

                        GeteRackList("SELECT * FROM Стелажі");
                        ucEvents.instance.GetEventList("SELECT * FROM Події");
                    }
                } catch (Exception ex) {
                    (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
                }
            }
        }

        public void GeteRackList(string query)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand(query, conn);

                dataGridRacks.Rows.Clear();

                odr = cmd.ExecuteReader();

                while (odr.Read()) {
                    dataGridRacks.Rows.Add();

                    dataGridRacks.Rows[dataGridRacks.Rows.Count - 1].Cells["rack_name"].Value = "    " + odr[1].ToString();
                    dataGridRacks.Rows[dataGridRacks.Rows.Count - 1].Cells["rack_desc"].Value = odr[2].ToString();
                }

                dataGridRacks.ClearSelection();

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                txtRackName.BaseColor = Color.FromArgb(18, 18, 18);
                txtRackName.FocusedBaseColor = Color.FromArgb(18, 18, 18);
                txtRackName.BorderColor = Color.Gray;
                txtRackName.ForeColor = Color.Gray;
                txtRackName.FocusedForeColor = Color.Gray;

                txtDesc.BaseColor = Color.FromArgb(18, 18, 18);
                txtDesc.FocusedBaseColor = Color.FromArgb(18, 18, 18);
                txtDesc.BorderColor = Color.Gray;
                txtDesc.ForeColor = Color.Gray;
                txtDesc.FocusedForeColor = Color.Gray;

                btnAdd.BaseColor = Color.FromArgb(39, 39, 39);
                btnAdd.BorderColor = Color.Gray;

                pnlRack.BaseColor = Color.FromArgb(39, 39, 39);

                dataGridRacks.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridRacks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridRacks.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dataGridRacks.ThemeStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridRacks.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridRacks.ThemeStyle.RowsStyle.SelectionForeColor = Color.Silver;

                pnlRacksList.BaseColor = Color.FromArgb(39, 39, 39);
            } else {
                this.BackColor = Color.WhiteSmoke;

                txtRackName.BaseColor = Color.WhiteSmoke;
                txtRackName.FocusedBaseColor = Color.WhiteSmoke;
                txtRackName.BorderColor = Color.Silver;
                txtRackName.ForeColor = Color.Gray;
                txtRackName.FocusedForeColor = Color.Black;

                txtDesc.BaseColor = Color.WhiteSmoke;
                txtDesc.FocusedBaseColor = Color.WhiteSmoke;
                txtDesc.BorderColor = Color.Silver;
                txtDesc.ForeColor = Color.Gray;
                txtDesc.FocusedForeColor = Color.Black;

                btnAdd.BaseColor = Color.WhiteSmoke;
                btnAdd.BorderColor = Color.Silver;

                pnlRack.BaseColor = Color.White;

                dataGridRacks.ThemeStyle.RowsStyle.BackColor = Color.White;
                dataGridRacks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
                dataGridRacks.ThemeStyle.RowsStyle.SelectionBackColor = Color.WhiteSmoke;
                dataGridRacks.ThemeStyle.BackColor = Color.White;
                dataGridRacks.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridRacks.ThemeStyle.RowsStyle.SelectionForeColor = Color.DimGray;

                pnlRacksList.BaseColor = Color.White;
            }
        }
    }
}