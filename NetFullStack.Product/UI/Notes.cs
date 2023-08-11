using NetFullStack.Product.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFullStack.Product.UI
{

    public partial class Notes : Form
    {
        int NoteId = 0;
        Operations operations = new Operations();
        string NuserFullName;
        public Notes(string userFullName)
        {
            InitializeComponent();
            this.NuserFullName = userFullName;
            lblUser.Text = userFullName;

        }

        private void Notes_Load(object sender, EventArgs e)
        {
            Reload();
        }


        public void Reload()
        {
            listNotes.DataSource = operations.ListNotes();
            listNotes.DisplayMember = "Description";
            listNotes.ValueMember = "Id";

        }

        public void clearempty()
        {
            NoteId = 0;
            rcSoz.Text = string.Empty;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearempty();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();

            if (NoteId <= 0)
            {

                try
                {

                    string Description = rcSoz.Text;
                    string UpdateUser = lblUser.Text;
                    operations.SaveNotes(Description, UpdateUser);
                    Reload();
                    clearempty();
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen Notu Giriniz");
                }

            }

            else
            {

                string NameNotes = rcSoz.Text;

                operations.UpdateNotes(NameNotes, lblUser.Text, NoteId);
                Reload();
                clearempty();
            }



        }

        private void listNotes_DoubleClick(object sender, EventArgs e)
        {


            var selectedNotes = listNotes.SelectedItem as Entities.Notes;

            rcSoz.Text = selectedNotes.Description.ToString();
            NoteId = selectedNotes.Id;
            lblUpdateUser.Text=selectedNotes.UpdateUser.ToString(); 

            //var seletedProduct = ProductList.SelectedItem as Entities.Product;
            //txtProductName.Text = seletedProduct.ProductName.ToString();
            //txtUrunId.Text = seletedProduct.Id.ToString();
            //ProductId = seletedProduct.Id;
            //txtProductQuantity.Text = seletedProduct.Stock.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (NoteId > 0)
            {
                operations.DeleteNotes(NoteId);
                Reload();

            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Olan Veriyi Listeden Çift Tıklayınız");

            }
            clearempty();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

