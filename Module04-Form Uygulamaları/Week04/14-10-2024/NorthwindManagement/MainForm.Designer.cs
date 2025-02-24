namespace NorthwindManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            cmbCategories = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            rbWithStart = new RadioButton();
            rbContains = new RadioButton();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            cmbFilter = new ComboBox();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(25, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(25, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 0;
            label2.Text = "Kategori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(520, 23);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 32);
            label3.TabIndex = 0;
            label3.Text = "Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(520, 73);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 0;
            label4.Text = "Stok:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(25, 234);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 32);
            label5.TabIndex = 0;
            label5.Text = "Ürün Arama:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(555, 234);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(259, 30);
            label6.TabIndex = 0;
            label6.Text = "Kategoriye Göre Filtrele";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.Location = new Point(154, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(336, 39);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 14F);
            txtPrice.Location = new Point(600, 20);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(206, 39);
            txtPrice.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 14F);
            txtStock.Location = new Point(600, 70);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(206, 39);
            txtStock.TabIndex = 3;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.Font = new Font("Segoe UI", 14F);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(154, 70);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(336, 39);
            cmbCategories.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(25, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(250, 70);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Yeni Ürün Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(290, 135);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(250, 70);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Ürün Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(555, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 70);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Ürün Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // rbWithStart
            // 
            rbWithStart.AutoSize = true;
            rbWithStart.Checked = true;
            rbWithStart.Font = new Font("Segoe UI", 12F);
            rbWithStart.Location = new Point(192, 231);
            rbWithStart.Name = "rbWithStart";
            rbWithStart.Size = new Size(127, 32);
            rbWithStart.TabIndex = 7;
            rbWithStart.TabStop = true;
            rbWithStart.Text = "... ile başlar";
            rbWithStart.UseVisualStyleBackColor = true;
            // 
            // rbContains
            // 
            rbContains.AutoSize = true;
            rbContains.Font = new Font("Segoe UI", 12F);
            rbContains.Location = new Point(325, 231);
            rbContains.Name = "rbContains";
            rbContains.Size = new Size(110, 32);
            rbContains.TabIndex = 8;
            rbContains.Text = "... içerir ...";
            rbContains.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(25, 287);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 39);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(441, 232);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 43);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.AccessibleDescription = "";
            btnClear.BackColor = Color.IndianRed;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(441, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 43);
            btnClear.TabIndex = 11;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Segoe UI", 14F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(555, 287);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(251, 39);
            cmbFilter.TabIndex = 12;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Bottom;
            dgvProducts.Location = new Point(0, 367);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(835, 336);
            dgvProducts.TabIndex = 5;
            dgvProducts.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 703);
            Controls.Add(dgvProducts);
            Controls.Add(rbContains);
            Controls.Add(rbWithStart);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(cmbFilter);
            Controls.Add(cmbCategories);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtSearch);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Northwind Management App";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private ComboBox cmbCategories;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private RadioButton rbWithStart;
        private RadioButton rbContains;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private ComboBox cmbFilter;
        private DataGridView dgvProducts;
    }
}
