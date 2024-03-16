using _01.EFDbFirstApplication.Models;

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

            if(string.IsNullOrEmpty(txtMin.Text) || string.IsNullOrEmpty(txtMax.Text))
            {
                MessageBox.Show("Please enter min and max price");
                return;
            }

            NorthwndContext db = new NorthwndContext();
            List<Product> product = db.Products.Where(x => x.UnitPrice > minPrice && x.UnitPrice < maxPrice).ToList();
            dvgProducts.DataSource= product;
        }
    }
}
