using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace pharma_
{
    public partial class frmMain : Form
    {
        public static string DBpath = Application.StartupPath + "\\pharma_plus.mdb";

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBpath);
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;

        private string picturePath;

        public frmMain()
        {
            InitializeComponent();

            this.Text = "pharma+";
            this.WindowState = FormWindowState.Maximized;

            if (!pnlControl.Controls.Contains(ucDashboard.instance)) {
                pnlControl.Controls.Add(ucDashboard.instance);
                ucDashboard.instance.Dock = DockStyle.Fill;
                ucDashboard.instance.BringToFront();
            }

            GetUserData(ucLog.acc);
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            ucDashboard.instance.GetStatistics("SELECT * FROM Медикаменти", ucDashboard.Stats.MEDICINE);
            ucDashboard.instance.GetStatistics("SELECT medicine_quantity FROM Медикаменти", ucDashboard.Stats.TOTALMEDICINE);
            ucDashboard.instance.GetStatistics("SELECT * FROM Постачальники", ucDashboard.Stats.SUPPLIERS);
            ucDashboard.instance.GetStatistics("SELECT * FROM Користувачи", ucDashboard.Stats.USERS);
            ucDashboard.instance.GetStatistics("SELECT * FROM Закупівля", ucDashboard.Stats.PURCHASE);
            ucDashboard.instance.GetStatistics("SELECT purchase_grand_total FROM Закупівля", ucDashboard.Stats.TOTALPURCHASE);
            ucDashboard.instance.GetStatistics("SELECT * FROM Категорії", ucDashboard.Stats.CATEGORY);
            ucDashboard.instance.GetStatistics("SELECT * FROM Стелажі", ucDashboard.Stats.RACKS);
            ucDashboard.instance.GetStatistics("SELECT * FROM Медикаменти WHERE medicine_quantity <= " + 100 + " ORDER BY medicine_quantity", ucDashboard.Stats.MEDICINESLOWTOCKLIST);

            ucDashboard.instance.ChangeTheme(frmAcc.isNight);
            ucCategory.instance.ChangeTheme(frmAcc.isNight);
            ucRacks.instance.ChangeTheme(frmAcc.isNight);
            ucMedicine.instance.ChangeTheme(frmAcc.isNight);
            ucSupplier.instance.ChangeTheme(frmAcc.isNight);
            ucPurchase.instance.ChangeTheme(frmAcc.isNight);
            ucEvents.instance.ChangeTheme(frmAcc.isNight);

            GetUserData(ucLog.acc);

            if (frmAcc.isNight == true) {
                lblAppName.ForeColor = Color.DimGray;

                pnlHeader.BackColor = Color.FromArgb(18, 18, 18);

                btnDashboard.BaseColor = Color.FromArgb(18, 18, 18);
                btnCategory.BaseColor = Color.FromArgb(18, 18, 18);
                btnRacks.BaseColor = Color.FromArgb(18, 18, 18);
                btnMedicine.BaseColor = Color.FromArgb(18, 18, 18);
                btnSuppliers.BaseColor = Color.FromArgb(18, 18, 18);
                btnPurchase.BaseColor = Color.FromArgb(18, 18, 18);
                btnEventList.BaseColor = Color.FromArgb(18, 18, 18);

                btnSighnOut.BaseColor = Color.FromArgb(18, 18, 18);
                btnSighnOut.OnHoverBaseColor = Color.FromArgb(18, 18, 18);

            } else {
                lblAppName.ForeColor = Color.Black;

                pnlHeader.BackColor = Color.White;

                btnDashboard.BaseColor = Color.White;
                btnCategory.BaseColor = Color.White;
                btnRacks.BaseColor = Color.White;
                btnMedicine.BaseColor = Color.White;
                btnSuppliers.BaseColor = Color.White;
                btnPurchase.BaseColor = Color.White;
                btnEventList.BaseColor = Color.White;

                btnSighnOut.BaseColor = Color.White;
                btnSighnOut.OnHoverBaseColor = Color.White;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!pnlControl.Controls.Contains(ucDashboard.instance)) {
                pnlControl.Controls.Add(ucDashboard.instance);
                ucDashboard.instance.Dock = DockStyle.Fill;
                ucDashboard.instance.BringToFront();
            } else{
                ucDashboard.instance.BringToFront();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (!pnlControl.Controls.Contains(ucCategory.instance)) {
                pnlControl.Controls.Add(ucCategory.instance);
                ucCategory.instance.Dock = DockStyle.Fill;
                ucCategory.instance.BringToFront();
            } else {
                ucCategory.instance.BringToFront();
            }
        }

        private void btnRacks_Click(object sender, EventArgs e)
        {
            if (!pnlControl.Controls.Contains(ucRacks.instance)) {
                pnlControl.Controls.Add(ucRacks.instance);
                ucRacks.instance.Dock = DockStyle.Fill;
                ucRacks.instance.BringToFront();
            } else {
                ucRacks.instance.BringToFront();
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            if (!pnlControl.Controls.Contains(ucMedicine.instance)) {
                pnlControl.Controls.Add(ucMedicine.instance);
                ucMedicine.instance.Dock = DockStyle.Fill;
                ucMedicine.instance.BringToFront();
            } else {
                ucMedicine.instance.BringToFront();
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (!pnlControl.Controls.Contains(ucSupplier.instance)) {
                pnlControl.Controls.Add(ucSupplier.instance);
                ucSupplier.instance.Dock = DockStyle.Fill;
                ucSupplier.instance.BringToFront();
            } else {
                ucSupplier.instance.BringToFront();
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!pnlControl.Controls.Contains(ucPurchase.instance)) {
                pnlControl.Controls.Add(ucPurchase.instance);
                ucPurchase.instance.Dock = DockStyle.Fill;
                ucPurchase.instance.BringToFront();
            } else {
                ucPurchase.instance.BringToFront();
            }
        }

        private void btnEventList_Click(object sender, EventArgs e)
        {
            if (!pnlControl.Controls.Contains(ucEvents.instance)) {
                pnlControl.Controls.Add(ucEvents.instance);
                ucEvents.instance.Dock = DockStyle.Fill;
                ucEvents.instance.BringToFront();
            } else {
                ucEvents.instance.BringToFront();
            }
        }

        private void lblUserName_MouseEnter(object sender, EventArgs e)
        {
            lblUserName.Font = new Font(lblUserName.Font.Name, lblUserName.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lblUserName_MouseLeave(object sender, EventArgs e)
        {
            lblUserName.Font = new Font(lblUserName.Font.Name, lblUserName.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lblAccountName_Click(object sender, EventArgs e)
        {
            (new frmAcc()).ShowDialog();
        }

        private void btnSighnOut_Click(object sender, EventArgs e)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                    + "', '" + "Вихід"
                    + "', '" + "Вихід користувача " + ucLog.acc + " з системи."
                    + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                ucEvents.instance.GetEventList("SELECT * FROM Події");
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }

            this.Hide();

            (new frmAuth()).ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                conn.Open();

                cmd = new OleDbCommand("INSERT INTO Події (event_initiator, event_name, event_desc, event_date_time) VALUES ('" + ucLog.acc
                    + "', '" + "Вихід"
                    + "', '" + "Вихід користувача " + ucLog.acc + " з системи."
                    + "', '" + DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString() + "')", conn);

                cmd.ExecuteNonQuery();

                conn.Close();
            } catch (Exception ex) {
                (new MsgBox(Type.ERROR, "Помилка", ex.ToString())).ShowDialog();
            }

            this.Dispose();

            System.Environment.Exit(1);
        }

        private void GetUserData(string user_login)
        {
            try {
                oda = new OleDbDataAdapter("SELECT * FROM Користувачи WHERE user_login ='" + user_login + "'", conn);
                dt = new DataTable();

                oda.Fill(dt);

                foreach (DataRow row in dt.Rows) {
                    picturePath = row["user_picture"].ToString();

                    lblUserName.Text = "Вітаємо, " + row["user_fullname"].ToString();

                    if (picturePath != "") {
                        try {
                            pctBoxUserPicture.Image = Image.FromFile(picturePath);
                        } catch (IOException) {
                            pctBoxUserPicture.Image = Properties.Resources.user;
                        }
                    } else {
                        pctBoxUserPicture.Image = Properties.Resources.user;
                    }
                }
            } finally {
                conn.Close();
            }
        }
    }
}