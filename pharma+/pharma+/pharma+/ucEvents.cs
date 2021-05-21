using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace pharma_
{
    public partial class ucEvents : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBpath);
        OleDbDataReader odr;
        OleDbCommand cmd;

        private string selectedInitiator, selectedEventName, selectedEventDesc, selectedEventDateTime;

        private static ucEvents _instance;

        public static ucEvents instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEvents();
                return _instance;
            }
        }

        public ucEvents()
        {
            InitializeComponent();

            cmbEvent.SelectedIndex = 0;

            GetEventList("SELECT * FROM Події ORDER BY ID");
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (txtSearch.Text != "Пошук" && cmbEvent.Text == "Реєстрація" && dataGridEvents != null)
                    GetEventList("SELECT * FROM Події WHERE event_initiator LIKE '" + txtSearch.Text + "%' AND event_name ='" + cmbEvent.Text + "' ORDER BY ID");
                else if (txtSearch.Text != "Пошук" && cmbEvent.Text == "Авторизація" && dataGridEvents != null)
                    GetEventList("SELECT * FROM Події WHERE event_initiator LIKE '" + txtSearch.Text + "%' AND event_name ='" + cmbEvent.Text + "' ORDER BY ID");
                else if (txtSearch.Text != "Пошук" && cmbEvent.Text == "Вихід" && dataGridEvents != null)
                    GetEventList("SELECT * FROM Події WHERE event_initiator LIKE '" + txtSearch.Text + "%' AND event_name ='" + cmbEvent.Text + "' ORDER BY ID");
                else if (txtSearch.Text != "Пошук" && cmbEvent.Text == "Оновлення" && dataGridEvents != null)
                    GetEventList("SELECT * FROM Події WHERE event_initiator LIKE '" + txtSearch.Text + "%' AND event_name ='" + cmbEvent.Text + "' ORDER BY ID");
                else if (txtSearch.Text != "Пошук" && cmbEvent.Text == "Створення" && dataGridEvents != null)
                    GetEventList("SELECT * FROM Події WHERE event_initiator LIKE '" + txtSearch.Text + "%' AND event_name ='" + cmbEvent.Text + "' ORDER BY ID");
                else if (txtSearch.Text != "Пошук" && cmbEvent.Text == "Видалення" && dataGridEvents != null)
                    GetEventList("SELECT * FROM Події WHERE event_initiator LIKE '" + txtSearch.Text + "%' AND event_name ='" + cmbEvent.Text + "' ORDER BY ID");
                else
                    GetEventList("SELECT * FROM Події WHERE event_initiator LIKE '" + txtSearch.Text + "%' ORDER BY ID");
            }
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Пошук";

            if (cmbEvent.Text == "Реєстрація" && dataGridEvents != null)
                GetEventList("SELECT * FROM Події WHERE event_name ='" + cmbEvent.Text + "' ORDER BY ID");
            else if (cmbEvent.Text == "Авторизація" && dataGridEvents != null)
                GetEventList("SELECT * FROM Події WHERE event_name ='" + cmbEvent.Text + "' ORDER BY ID");
            else if (cmbEvent.Text == "Вихід" && dataGridEvents != null)
                GetEventList("SELECT * FROM Події WHERE event_name ='" + cmbEvent.Text + "' ORDER BY ID");
            else if (cmbEvent.Text == "Оновлення" && dataGridEvents != null)
                GetEventList("SELECT * FROM Події WHERE event_name ='" + cmbEvent.Text + "' ORDER BY ID");
            else if (cmbEvent.Text == "Створення" && dataGridEvents != null)
                GetEventList("SELECT * FROM Події WHERE event_name ='" + cmbEvent.Text + "' ORDER BY ID");
            else if (cmbEvent.Text == "Видалення" && dataGridEvents != null)
                GetEventList("SELECT * FROM Події WHERE event_name ='" + cmbEvent.Text + "' ORDER BY ID");
            else
                GetEventList("SELECT * FROM Події ORDER BY ID");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetEventList("SELECT * FROM Події ORDER BY ID");

            txtSearch.Text = "Пошук";

            cmbEvent.SelectedIndex = 0;
        }

        private void dataGridEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEvents != null && dataGridEvents.SelectedRows.Count != 0) {
                selectedInitiator = dataGridEvents.SelectedRows[0].Cells[1].Value.ToString();
                selectedEventName = dataGridEvents.SelectedRows[0].Cells[2].Value.ToString();
                selectedEventDesc = dataGridEvents.SelectedRows[0].Cells[3].Value.ToString();
                selectedEventDateTime = dataGridEvents.SelectedRows[0].Cells[4].Value.ToString();
            }

            if (e.ColumnIndex == 5)
                (new MsgBox(Type.INFORMATION, "[" + selectedEventDateTime + "]", "Ініціатор: користувач " + selectedInitiator + " => { " + selectedEventName + " }" + "\n\n" + "Опис:\n" + selectedEventDesc)).ShowDialog();
        }

        public void GetEventList(string query)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand(query, conn);

                dataGridEvents.Rows.Clear();

                odr = cmd.ExecuteReader();

                int i = 0;

                while (odr.Read()) {
                    i++;

                    dataGridEvents.Rows.Add();

                    dataGridEvents.Rows[dataGridEvents.Rows.Count - 1].Cells["event_no"].Value = "    " + i.ToString();
                    dataGridEvents.Rows[dataGridEvents.Rows.Count - 1].Cells["event_initiator"].Value = odr[1].ToString();
                    dataGridEvents.Rows[dataGridEvents.Rows.Count - 1].Cells["event_name"].Value = odr[2].ToString();
                    dataGridEvents.Rows[dataGridEvents.Rows.Count - 1].Cells["event_desc"].Value = odr[3].ToString();
                    dataGridEvents.Rows[dataGridEvents.Rows.Count - 1].Cells["event_date_time"].Value = odr[4].ToString();
                }

                dataGridEvents.ClearSelection();

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }
        }

        public void ChangeTheme(bool isNight)
        {
            if (isNight == true) {
                this.BackColor = Color.FromArgb(18, 18, 18);

                pctBoxSearch.BackColor = Color.FromArgb(39, 39, 39);

                txtSearch.BaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.FocusedBaseColor = Color.FromArgb(39, 39, 39);
                txtSearch.BorderColor = Color.Gray;
                txtSearch.ForeColor = Color.Gray;
                txtSearch.FocusedForeColor = Color.Gray;

                btnRefresh.BaseColor = Color.FromArgb(39, 39, 39);
                btnRefresh.BorderColor = Color.Gray;

                pnlEventsList.BaseColor = Color.FromArgb(39, 39, 39);

                cmbEvent.BaseColor = Color.FromArgb(39, 39, 39);
                cmbEvent.BorderColor = Color.Gray;
                cmbEvent.ForeColor = Color.Gray;

                dataGridEvents.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridEvents.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridEvents.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dataGridEvents.ThemeStyle.BackColor = Color.FromArgb(39, 39, 39);
                dataGridEvents.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridEvents.ThemeStyle.RowsStyle.SelectionForeColor = Color.Silver;
            } else {
                this.BackColor = Color.WhiteSmoke;

                pctBoxSearch.BackColor = Color.WhiteSmoke;

                txtSearch.BaseColor = Color.WhiteSmoke;
                txtSearch.FocusedBaseColor = Color.WhiteSmoke;
                txtSearch.BorderColor = Color.Silver;
                txtSearch.ForeColor = Color.DimGray;
                txtSearch.FocusedForeColor = Color.Black;

                btnRefresh.BaseColor = Color.WhiteSmoke;
                btnRefresh.BorderColor = Color.Silver;

                pnlEventsList.BaseColor = Color.White;

                cmbEvent.BaseColor = Color.WhiteSmoke;
                cmbEvent.BorderColor = Color.Silver;
                cmbEvent.ForeColor = Color.DimGray;

                dataGridEvents.ThemeStyle.RowsStyle.BackColor = Color.White;
                dataGridEvents.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
                dataGridEvents.ThemeStyle.RowsStyle.SelectionBackColor = Color.WhiteSmoke;
                dataGridEvents.ThemeStyle.BackColor = Color.White;
                dataGridEvents.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
                dataGridEvents.ThemeStyle.RowsStyle.SelectionForeColor = Color.DimGray;
            }
        }
    }
}