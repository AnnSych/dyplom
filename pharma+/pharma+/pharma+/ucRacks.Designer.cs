
namespace pharma_
{
    partial class ucRacks
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRacks = new Guna.UI.WinForms.GunaLabel();
            this.pnlLayoutRack = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRack = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.lblDesc1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.txtRackName = new Guna.UI.WinForms.GunaTextBox();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblRackName = new Guna.UI.WinForms.GunaLabel();
            this.lblNewRack = new Guna.UI.WinForms.GunaLabel();
            this.pnlRacksList = new Guna.UI.WinForms.GunaShadowPanel();
            this.HSeparator3 = new Guna.UI.WinForms.GunaSeparator();
            this.lblDesc2 = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.dataGridRacks = new Guna.UI.WinForms.GunaDataGridView();
            this.rack_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rack_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_rack = new System.Windows.Forms.DataGridViewImageColumn();
            this.HSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lblRackList = new Guna.UI.WinForms.GunaLabel();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLayoutRack.SuspendLayout();
            this.pnlRack.SuspendLayout();
            this.pnlRacksList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRacks
            // 
            this.lblRacks.AutoSize = true;
            this.lblRacks.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblRacks.ForeColor = System.Drawing.Color.DimGray;
            this.lblRacks.Location = new System.Drawing.Point(18, 14);
            this.lblRacks.Name = "lblRacks";
            this.lblRacks.Size = new System.Drawing.Size(135, 45);
            this.lblRacks.TabIndex = 12;
            this.lblRacks.Text = "Стелажі";
            // 
            // pnlLayoutRack
            // 
            this.pnlLayoutRack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLayoutRack.ColumnCount = 2;
            this.pnlLayoutRack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayoutRack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayoutRack.Controls.Add(this.pnlRack, 0, 0);
            this.pnlLayoutRack.Controls.Add(this.pnlRacksList, 1, 0);
            this.pnlLayoutRack.Location = new System.Drawing.Point(22, 76);
            this.pnlLayoutRack.Name = "pnlLayoutRack";
            this.pnlLayoutRack.RowCount = 1;
            this.pnlLayoutRack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayoutRack.Size = new System.Drawing.Size(1136, 508);
            this.pnlLayoutRack.TabIndex = 42;
            // 
            // pnlRack
            // 
            this.pnlRack.BackColor = System.Drawing.Color.Transparent;
            this.pnlRack.BaseColor = System.Drawing.Color.White;
            this.pnlRack.Controls.Add(this.btnAdd);
            this.pnlRack.Controls.Add(this.lblDesc1);
            this.pnlRack.Controls.Add(this.txtDesc);
            this.pnlRack.Controls.Add(this.txtRackName);
            this.pnlRack.Controls.Add(this.HSeparator1);
            this.pnlRack.Controls.Add(this.lblRackName);
            this.pnlRack.Controls.Add(this.lblNewRack);
            this.pnlRack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRack.Location = new System.Drawing.Point(3, 3);
            this.pnlRack.Name = "pnlRack";
            this.pnlRack.ShadowColor = System.Drawing.Color.Black;
            this.pnlRack.ShadowDepth = 40;
            this.pnlRack.Size = new System.Drawing.Size(562, 502);
            this.pnlRack.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Animated = true;
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.Image = null;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(366, 436);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 6;
            this.btnAdd.Size = new System.Drawing.Size(142, 39);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Додати";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc1.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc1.Location = new System.Drawing.Point(30, 167);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(49, 21);
            this.lblDesc1.TabIndex = 19;
            this.lblDesc1.Text = "Опис";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtDesc.BorderColor = System.Drawing.Color.Silver;
            this.txtDesc.BorderSize = 1;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtDesc.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtDesc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDesc.ForeColor = System.Drawing.Color.DimGray;
            this.txtDesc.Location = new System.Drawing.Point(34, 201);
            this.txtDesc.MaxLength = 256;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.Radius = 6;
            this.txtDesc.SelectedText = "";
            this.txtDesc.Size = new System.Drawing.Size(474, 212);
            this.txtDesc.TabIndex = 18;
            this.txtDesc.TextOffsetX = 4;
            this.txtDesc.Enter += new System.EventHandler(this.txtDesc_Enter);
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // txtRackName
            // 
            this.txtRackName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRackName.BackColor = System.Drawing.Color.Transparent;
            this.txtRackName.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtRackName.BorderColor = System.Drawing.Color.Silver;
            this.txtRackName.BorderSize = 1;
            this.txtRackName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRackName.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtRackName.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtRackName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRackName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRackName.ForeColor = System.Drawing.Color.DimGray;
            this.txtRackName.Location = new System.Drawing.Point(34, 122);
            this.txtRackName.MaxLength = 60;
            this.txtRackName.Name = "txtRackName";
            this.txtRackName.PasswordChar = '\0';
            this.txtRackName.Radius = 6;
            this.txtRackName.SelectedText = "";
            this.txtRackName.Size = new System.Drawing.Size(474, 32);
            this.txtRackName.TabIndex = 17;
            this.txtRackName.Text = "Введіть назву";
            this.txtRackName.TextOffsetX = 6;
            this.txtRackName.TextChanged += new System.EventHandler(this.txtRackName_TextChanged);
            this.txtRackName.Enter += new System.EventHandler(this.txtRackName_Enter);
            this.txtRackName.Leave += new System.EventHandler(this.txtRackName_Leave);
            // 
            // HSeparator1
            // 
            this.HSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.HSeparator1.Location = new System.Drawing.Point(34, 62);
            this.HSeparator1.Name = "HSeparator1";
            this.HSeparator1.Size = new System.Drawing.Size(474, 10);
            this.HSeparator1.TabIndex = 16;
            // 
            // lblRackName
            // 
            this.lblRackName.AutoSize = true;
            this.lblRackName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRackName.ForeColor = System.Drawing.Color.DimGray;
            this.lblRackName.Location = new System.Drawing.Point(30, 88);
            this.lblRackName.Name = "lblRackName";
            this.lblRackName.Size = new System.Drawing.Size(120, 21);
            this.lblRackName.TabIndex = 15;
            this.lblRackName.Text = "Назва стелажу";
            // 
            // lblNewRack
            // 
            this.lblNewRack.AutoSize = true;
            this.lblNewRack.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRack.ForeColor = System.Drawing.Color.DimGray;
            this.lblNewRack.Location = new System.Drawing.Point(26, 18);
            this.lblNewRack.Name = "lblNewRack";
            this.lblNewRack.Size = new System.Drawing.Size(174, 32);
            this.lblNewRack.TabIndex = 14;
            this.lblNewRack.Text = "Новий стелаж";
            // 
            // pnlRacksList
            // 
            this.pnlRacksList.BackColor = System.Drawing.Color.Transparent;
            this.pnlRacksList.BaseColor = System.Drawing.Color.White;
            this.pnlRacksList.Controls.Add(this.HSeparator3);
            this.pnlRacksList.Controls.Add(this.lblDesc2);
            this.pnlRacksList.Controls.Add(this.lblName);
            this.pnlRacksList.Controls.Add(this.dataGridRacks);
            this.pnlRacksList.Controls.Add(this.HSeparator2);
            this.pnlRacksList.Controls.Add(this.lblRackList);
            this.pnlRacksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRacksList.Location = new System.Drawing.Point(571, 3);
            this.pnlRacksList.Name = "pnlRacksList";
            this.pnlRacksList.ShadowColor = System.Drawing.Color.Black;
            this.pnlRacksList.ShadowDepth = 40;
            this.pnlRacksList.Size = new System.Drawing.Size(562, 502);
            this.pnlRacksList.TabIndex = 40;
            // 
            // HSeparator3
            // 
            this.HSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HSeparator3.LineColor = System.Drawing.Color.DimGray;
            this.HSeparator3.Location = new System.Drawing.Point(34, 118);
            this.HSeparator3.Name = "HSeparator3";
            this.HSeparator3.Size = new System.Drawing.Size(474, 10);
            this.HSeparator3.TabIndex = 42;
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc2.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc2.Location = new System.Drawing.Point(232, 88);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(49, 21);
            this.lblDesc2.TabIndex = 41;
            this.lblDesc2.Text = "Опис";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(48, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 21);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Назва";
            // 
            // dataGridRacks
            // 
            this.dataGridRacks.AllowUserToAddRows = false;
            this.dataGridRacks.AllowUserToDeleteRows = false;
            this.dataGridRacks.AllowUserToResizeColumns = false;
            this.dataGridRacks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridRacks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRacks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRacks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRacks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRacks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridRacks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridRacks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRacks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRacks.ColumnHeadersHeight = 30;
            this.dataGridRacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridRacks.ColumnHeadersVisible = false;
            this.dataGridRacks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rack_name,
            this.rack_desc,
            this.delete_rack});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRacks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRacks.EnableHeadersVisualStyles = false;
            this.dataGridRacks.GridColor = System.Drawing.Color.White;
            this.dataGridRacks.Location = new System.Drawing.Point(34, 134);
            this.dataGridRacks.MultiSelect = false;
            this.dataGridRacks.Name = "dataGridRacks";
            this.dataGridRacks.ReadOnly = true;
            this.dataGridRacks.RowHeadersVisible = false;
            this.dataGridRacks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridRacks.RowTemplate.Height = 50;
            this.dataGridRacks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridRacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRacks.ShowCellErrors = false;
            this.dataGridRacks.ShowCellToolTips = false;
            this.dataGridRacks.ShowEditingIcon = false;
            this.dataGridRacks.ShowRowErrors = false;
            this.dataGridRacks.Size = new System.Drawing.Size(474, 343);
            this.dataGridRacks.TabIndex = 40;
            this.dataGridRacks.TabStop = false;
            this.dataGridRacks.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridRacks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridRacks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridRacks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridRacks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridRacks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridRacks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridRacks.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridRacks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.dataGridRacks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridRacks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridRacks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridRacks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridRacks.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridRacks.ThemeStyle.ReadOnly = true;
            this.dataGridRacks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridRacks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridRacks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridRacks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridRacks.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridRacks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridRacks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridRacks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRacks_CellClick);
            // 
            // rack_name
            // 
            this.rack_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rack_name.FillWeight = 253.8071F;
            this.rack_name.HeaderText = "Назва стелажу";
            this.rack_name.Name = "rack_name";
            this.rack_name.ReadOnly = true;
            this.rack_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rack_name.Width = 200;
            // 
            // rack_desc
            // 
            this.rack_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rack_desc.FillWeight = 14.70838F;
            this.rack_desc.HeaderText = "Опис";
            this.rack_desc.Name = "rack_desc";
            this.rack_desc.ReadOnly = true;
            this.rack_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rack_desc.Width = 200;
            // 
            // delete_rack
            // 
            this.delete_rack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delete_rack.HeaderText = "Видалення";
            this.delete_rack.Image = global::pharma_.Properties.Resources.trash_small;
            this.delete_rack.Name = "delete_rack";
            this.delete_rack.ReadOnly = true;
            this.delete_rack.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HSeparator2
            // 
            this.HSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HSeparator2.LineColor = System.Drawing.Color.DimGray;
            this.HSeparator2.Location = new System.Drawing.Point(34, 62);
            this.HSeparator2.Name = "HSeparator2";
            this.HSeparator2.Size = new System.Drawing.Size(474, 10);
            this.HSeparator2.TabIndex = 16;
            // 
            // lblRackList
            // 
            this.lblRackList.AutoSize = true;
            this.lblRackList.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRackList.ForeColor = System.Drawing.Color.DimGray;
            this.lblRackList.Location = new System.Drawing.Point(26, 18);
            this.lblRackList.Name = "lblRackList";
            this.lblRackList.Size = new System.Drawing.Size(201, 32);
            this.lblRackList.TabIndex = 14;
            this.lblRackList.Text = "Список стелажів";
            // 
            // ucRacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlLayoutRack);
            this.Controls.Add(this.lblRacks);
            this.Name = "ucRacks";
            this.Size = new System.Drawing.Size(1184, 598);
            this.pnlLayoutRack.ResumeLayout(false);
            this.pnlRack.ResumeLayout(false);
            this.pnlRack.PerformLayout();
            this.pnlRacksList.ResumeLayout(false);
            this.pnlRacksList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblRacks;
        private System.Windows.Forms.TableLayoutPanel pnlLayoutRack;
        private Guna.UI.WinForms.GunaShadowPanel pnlRack;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaLabel lblDesc1;
        private Guna.UI.WinForms.GunaTextBox txtDesc;
        private Guna.UI.WinForms.GunaTextBox txtRackName;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblRackName;
        private Guna.UI.WinForms.GunaLabel lblNewRack;
        private Guna.UI.WinForms.GunaShadowPanel pnlRacksList;
        private Guna.UI.WinForms.GunaSeparator HSeparator3;
        private Guna.UI.WinForms.GunaLabel lblDesc2;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaDataGridView dataGridRacks;
        private Guna.UI.WinForms.GunaSeparator HSeparator2;
        private Guna.UI.WinForms.GunaLabel lblRackList;
        private System.Windows.Forms.DataGridViewTextBoxColumn rack_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rack_desc;
        private System.Windows.Forms.DataGridViewImageColumn delete_rack;
        private System.Windows.Forms.ToolTip Tips;
    }
}
