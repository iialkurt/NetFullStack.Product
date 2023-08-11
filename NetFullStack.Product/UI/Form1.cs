using NetFullStack.Product.Entities;
using System.Data.SqlClient;
namespace NetFullStack.Product
{
    public partial class Form1 : Form
    {


        string userFullName;
        int ProductId = 0;
        Operations operations = new Operations();

        public Form1(string PuserFullName)
        {
            InitializeComponent();
            this.userFullName = PuserFullName;
            lblUser.Text = userFullName;

            Reload();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearempty();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();

            if (ProductId <= 0)
            {

                try
                {

                    int Quantity = int.Parse(txtProductQuantity.Text);
                    string NameProduct = txtProductName.Text;
                    operations.SaveProduct(NameProduct, Quantity);
                    Reload();
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen Ürün Ýsmini Giriniz ve Ürün Miktarýný Sayý Olarak Giriniz Ürün Eklenemedi");
                }

            }

            else
            {
                int Quantity = int.Parse(txtProductQuantity.Text);
                string NameProduct = txtProductName.Text;

                operations.UpdateProduct(NameProduct, Quantity, ProductId);
                Reload();
            }

            clearempty();

        }

        public void clearempty()
        {
            ProductId = 0;
            txtProductName.Text = string.Empty;
            txtProductQuantity.Text = string.Empty;
            txtUrunId.Text = string.Empty;
        }
        public void Reload()
        {


            ProductList.DataSource = operations.ListNotes();
            ProductList.DisplayMember = "ProductName";
            ProductList.ValueMember = "Id";
        }

        private void ProductList_DoubleClick(object sender, EventArgs e)
        {
            var seletedProduct = ProductList.SelectedItem as Entities.Product;
            txtProductName.Text = seletedProduct.ProductName.ToString();
            txtUrunId.Text = seletedProduct.Id.ToString();
            ProductId = seletedProduct.Id;
            txtProductQuantity.Text = seletedProduct.Stock.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ProductId > 0)
            {
                operations.DeleteProduct(ProductId);
                Reload();

            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Olan Veriyi Listeden Çift Týklayýnýz");

            }
            clearempty();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}