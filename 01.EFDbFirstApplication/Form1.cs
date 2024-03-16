using _01.EFDbFirstApplication.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace _01.EFDbFirstApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        void LoadProducts()
        {
            NorthwndContext db = new NorthwndContext();
            List<Product> product = db.Products.ToList();
            dvgProducts.DataSource = product;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            decimal minPrice = Convert.ToDecimal(txtMin.Text);
            decimal maxPrice = Convert.ToDecimal(txtMax.Text);

            if (string.IsNullOrEmpty(txtMin.Text) || string.IsNullOrEmpty(txtMax.Text))
            {
                MessageBox.Show("Please enter min and max price");
                return;
            }

            NorthwndContext db = new NorthwndContext();
            List<Product> product = db.Products.Where(x => x.UnitPrice > minPrice && x.UnitPrice < maxPrice).ToList();
            dvgProducts.DataSource = product;
        }

        private void dvgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dvgProducts.CurrentRow.Cells[0].Value);

            NorthwndContext db = new NorthwndContext();
            Product product = db.Products.FirstOrDefault(x => x.ProductId == id);

            if (product != null)
            {
                txtName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtStock.Text = product.UnitsInStock.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dvgProducts.CurrentRow.Cells[0].Value);

            NorthwndContext db = new NorthwndContext();
            Product product = db.Products.FirstOrDefault(x => x.ProductId == id);
            product.ProductName = txtName.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);

            if(short.Parse(txtStock.Text) > 0  && short.Parse(txtStock.Text) < 100)
            {
                product.UnitsInStock = short.Parse(txtStock.Text);
            }
            else
            {
                MessageBox.Show("Error");
            }
            db.SaveChanges();
            LoadProducts();
        }
    }
}
