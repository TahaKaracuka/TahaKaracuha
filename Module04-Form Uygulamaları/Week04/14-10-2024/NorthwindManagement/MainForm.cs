using NorthwindManagement.DataAccessLayer;
using NorthwindManagement.Models;
using System.Data;

namespace NorthwindManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            DataTable products = productDAL.GetAll();
            LoadProducts(products);

            CategoryDAL categoryDAL = new CategoryDAL();
            LinkedList<Category> categories = categoryDAL.GetAll();
            LoadCategories(categories);

        }

        private void LoadCategories(LinkedList<Category> categories)
        {
            cmbCategories.DataSource = categories.ToList();
            cmbCategories.ValueMember = "Id";
            cmbCategories.DisplayMember = "Name";

            categories.AddFirst(new Category { Id = 0, Name = "Hepsi" });
            cmbFilter.DataSource = categories.ToList();
            cmbFilter.ValueMember = "Id";
            cmbFilter.DisplayMember = "Name";
        }

        private void LoadProducts(DataTable products)
        {
            dgvProducts.DataSource = products;
            dgvProducts.Columns["Id"].Width = 50;

            dgvProducts.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProducts.Columns["Name"].HeaderText = "Ürün";

            dgvProducts.Columns["Price"].Width = 80;
            dgvProducts.Columns["Price"].DefaultCellStyle.Format = "C2";
            dgvProducts.Columns["Price"].HeaderText = "Fiyat";

            dgvProducts.Columns["Stock"].Width = 70;
            dgvProducts.Columns["Stock"].HeaderText = "Stok";

            dgvProducts.Columns["CategoryId"].Visible = false;

            dgvProducts.Columns["Category"].Width = 150;
            dgvProducts.Columns["Category"].HeaderText = "Kategori";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (searchText.Length > 0)
            {
                ProductDAL product = new ProductDAL();
                DataTable products = product.GetAll(searchText, rbWithStart.Checked);
                LoadProducts(products);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            rbWithStart.Checked = true;
            txtSearch.Focus();
            ProductDAL productDAL = new ProductDAL();
            DataTable products = productDAL.GetAll();
            LoadProducts(products);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDAL productDal = new ProductDAL();
            DataTable products;
            if (cmbFilter.SelectedIndex == 0)
            {
                products= productDal.GetAll();
            }
            else
            {
                int categoryId = Convert.ToInt32(cmbFilter.SelectedValue);
                products = productDal.GetAll(categoryId);
            }
            LoadProducts(products);
        }
    }
}
