
namespace pharma_
{
    partial class ucCategory
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
            this.lblCategory = new Guna.UI.WinForms.GunaLabel();
            this.pnlCategory = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.lblDesc1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.txtCategoryName = new Guna.UI.WinForms.GunaTextBox();
            this.HSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lblCategoryName = new Guna.UI.WinForms.GunaLabel();
            this.lblNewCategory = new Guna.UI.WinForms.GunaLabel();
            this.pnlCategoryList = new Guna.UI.WinForms.GunaShadowPanel();
            this.HSeparator3 = new Guna.UI.WinForms.GunaSeparator();
            this.lblDesc2 = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.dataGridCategory = new Guna.UI.WinForms.GunaDataGridView();
            this.HSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.lblCategoryList = new Guna.UI.WinForms.GunaLabel();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLayoutCategory = new System.Windows.Forms.TableLayoutPanel();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_category = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlCategory.SuspendLayout();
            this.pnlCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
            this.pnlLayoutCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.lblCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategory.Location = new System.Drawing.Point(18, 14);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(151, 45);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Категорії";
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategory.BaseColor = System.Drawing.Color.White;
            this.pnlCategory.Controls.Add(this.btnAdd);
            this.pnlCategory.Controls.Add(this.lblDesc1);
            this.pnlCategory.Controls.Add(this.txtDesc);
            this.pnlCategory.Controls.Add(this.txtCategoryName);
            this.pnlCategory.Controls.Add(this.HSeparator1);
            this.pnlCategory.Controls.Add(this.lblCategoryName);
            this.pnlCategory.Controls.Add(this.lblNewCategory);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(3, 3);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.ShadowColor = System.Drawing.Color.Black;
            this.pnlCategory.ShadowDepth = 40;
            this.pnlCategory.Size = new System.Drawing.Size(562, 502);
            this.pnlCategory.TabIndex = 13;
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
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoryName.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtCategoryName.BorderColor = System.Drawing.Color.Silver;
            this.txtCategoryName.BorderSize = 1;
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtCategoryName.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtCategoryName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCategoryName.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategoryName.Location = new System.Drawing.Point(34, 122);
            this.txtCategoryName.MaxLength = 60;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.Radius = 6;
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(474, 32);
            this.txtCategoryName.TabIndex = 17;
            this.txtCategoryName.Text = "Введіть назву";
            this.txtCategoryName.TextOffsetX = 6;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            this.txtCategoryName.Enter += new System.EventHandler(this.txtCategoryName_Enter);
            this.txtCategoryName.Leave += new System.EventHandler(this.txtCategoryName_Leave);
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
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryName.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoryName.Location = new System.Drawing.Point(30, 88);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(124, 21);
            this.lblCategoryName.TabIndex = 15;
            this.lblCategoryName.Text = "Назва категорії";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCategory.ForeColor = System.Drawing.Color.DimGray;
            this.lblNewCategory.Location = new System.Drawing.Point(26, 18);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(185, 32);
            this.lblNewCategory.TabIndex = 14;
            this.lblNewCategory.Text = "Нова категорія";
            // 
            // pnlCategoryList
            // 
            this.pnlCategoryList.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategoryList.BaseColor = System.Drawing.Color.White;
            this.pnlCategoryList.Controls.Add(this.HSeparator3);
            this.pnlCategoryList.Controls.Add(this.lblDesc2);
            this.pnlCategoryList.Controls.Add(this.lblName);
            this.pnlCategoryList.Controls.Add(this.dataGridCategory);
            this.pnlCategoryList.Controls.Add(this.HSeparator2);
            this.pnlCategoryList.Controls.Add(this.lblCategoryList);
            this.pnlCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategoryList.Location = new System.Drawing.Point(571, 3);
            this.pnlCategoryList.Name = "pnlCategoryList";
            this.pnlCategoryList.ShadowColor = System.Drawing.Color.Black;
            this.pnlCategoryList.ShadowDepth = 40;
            this.pnlCategoryList.Size = new System.Drawing.Size(562, 502);
            this.pnlCategoryList.TabIndex = 40;
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
            // dataGridCategory
            // 
            this.dataGridCategory.AllowUserToAddRows = false;
            this.dataGridCategory.AllowUserToDeleteRows = false;
            this.dataGridCategory.AllowUserToResizeColumns = false;
            this.dataGridCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCategory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCategory.ColumnHeadersHeight = 30;
            this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCategory.ColumnHeadersVisible = false;
            this.dataGridCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category_name,
            this.category_desc,
            this.delete_category});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCategory.EnableHeadersVisualStyles = false;
            this.dataGridCategory.GridColor = System.Drawing.Color.White;
            this.dataGridCategory.Location = new System.Drawing.Point(34, 134);
            this.dataGridCategory.MultiSelect = false;
            this.dataGridCategory.Name = "dataGridCategory";
            this.dataGridCategory.ReadOnly = true;
            this.dataGridCategory.RowHeadersVisible = false;
            this.dataGridCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCategory.RowTemplate.Height = 50;
            this.dataGridCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCategory.ShowCellErrors = false;
            this.dataGridCategory.ShowCellToolTips = false;
            this.dataGridCategory.ShowEditingIcon = false;
            this.dataGridCategory.ShowRowErrors = false;
            this.dataGridCategory.Size = new System.Drawing.Size(474, 343);
            this.dataGridCategory.TabIndex = 40;
            this.dataGridCategory.TabStop = false;
            this.dataGridCategory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridCategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCategory.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.dataGridCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCategory.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridCategory.ThemeStyle.ReadOnly = true;
            this.dataGridCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataGridCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dataGridCategory.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Window;
            this.dataGridCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dataGridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategory_CellClick);
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
            // lblCategoryList
            // 
            this.lblCategoryList.AutoSize = true;
            this.lblCategoryList.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryList.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoryList.Location = new System.Drawing.Point(26, 18);
            this.lblCategoryList.Name = "lblCategoryList";
            this.lblCategoryList.Size = new System.Drawing.Size(209, 32);
            this.lblCategoryList.TabIndex = 14;
            this.lblCategoryList.Text = "Список категорій";
            // 
            // Tips
            // 
            this.Tips.AutoPopDelay = 300000;
            this.Tips.InitialDelay = 500;
            this.Tips.ReshowDelay = 100;
            // 
            // pnlLayoutCategory
            // 
            this.pnlLayoutCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLayoutCategory.ColumnCount = 2;
            this.pnlLayoutCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayoutCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayoutCategory.Controls.Add(this.pnlCategory, 0, 0);
            this.pnlLayoutCategory.Controls.Add(this.pnlCategoryList, 1, 0);
            this.pnlLayoutCategory.Location = new System.Drawing.Point(22, 76);
            this.pnlLayoutCategory.Name = "pnlLayoutCategory";
            this.pnlLayoutCategory.RowCount = 1;
            this.pnlLayoutCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayoutCategory.Size = new System.Drawing.Size(1136, 508);
            this.pnlLayoutCategory.TabIndex = 41;
            // 
            // category_name
            // 
            this.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.category_name.FillWeight = 253.8071F;
            this.category_name.HeaderText = "Назва категорії";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.category_name.Width = 200;
            // 
            // category_desc
            // 
            this.category_desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.category_desc.FillWeight = 14.70838F;
            this.category_desc.HeaderText = "Опис";
            this.category_desc.Name = "category_desc";
            this.category_desc.ReadOnly = true;
            this.category_desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.category_desc.Width = 200;
            // 
            // delete_category
            // 
            this.delete_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delete_category.HeaderText = "Видалення";
            this.delete_category.Image = global::pharma_.Properties.Resources.trash_small;
            this.delete_category.Name = "delete_category";
            this.delete_category.ReadOnly = true;
            this.delete_category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ucCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlLayoutCategory);
            this.Controls.Add(this.lblCategory);
            this.Name = "ucCategory";
            this.Size = new System.Drawing.Size(1184, 598);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlCategoryList.ResumeLayout(false);
            this.pnlCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
            this.pnlLayoutCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblCategory;
        private Guna.UI.WinForms.GunaShadowPanel pnlCategory;
        private Guna.UI.WinForms.GunaLabel lblNewCategory;
        private Guna.UI.WinForms.GunaSeparator HSeparator1;
        private Guna.UI.WinForms.GunaLabel lblCategoryName;
        private Guna.UI.WinForms.GunaTextBox txtCategoryName;
        private Guna.UI.WinForms.GunaTextBox txtDesc;
        private Guna.UI.WinForms.GunaLabel lblDesc1;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaShadowPanel pnlCategoryList;
        private Guna.UI.WinForms.GunaSeparator HSeparator2;
        private Guna.UI.WinForms.GunaLabel lblCategoryList;
        private Guna.UI.WinForms.GunaDataGridView dataGridCategory;
        private Guna.UI.WinForms.GunaSeparator HSeparator3;
        private Guna.UI.WinForms.GunaLabel lblDesc2;
        private Guna.UI.WinForms.GunaLabel lblName;
        private System.Windows.Forms.ToolTip Tips;
        private System.Windows.Forms.TableLayoutPanel pnlLayoutCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_desc;
        private System.Windows.Forms.DataGridViewImageColumn delete_category;
    }
}
