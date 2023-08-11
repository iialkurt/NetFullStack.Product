using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFullStack.Product.Entities
{
    public class Operations
    {
        ConnectionManager con = new ConnectionManager();
       
        public List<Product> ListProduct()
        {
            var productList = new List<Product>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "select * from Products";

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var product = new Product();
                product.Id = Convert.ToInt32(reader[0]);
                product.ProductName = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);
                productList.Add(product);
            }
            reader.Close();
            con.con().Close();
            return productList;
        }


        public void SaveProduct(string? ProductName, int Stock)
        {
        //    Product product = new Product();
         //   var productList = new List<Product>();
         
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "insert into Products (ProductName,Stock) values (@productName,@productQuantity)";
            cmd.Parameters.AddWithValue("productName", ProductName);
            cmd.Parameters.AddWithValue("productQuantity", Stock);
            //  product.ProductName = ProductName;
            //product.Stock = Stock;
            //productList.Add(product);
            DialogResult result = MessageBox.Show("Ürünü Eklemek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.con().Close();
                MessageBox.Show("Ürün Başarılı Şekilde Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün Ekleme İşleminden Vazgeçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
           

        }

        public void UpdateProduct(string ProductName, int Stock,int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "Update Products Set ProductName =@productName,Stock=@productQuantity where Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("productName", ProductName);
            cmd.Parameters.AddWithValue("productQuantity", Stock);
            DialogResult result =  MessageBox.Show("Ürünü Güncellemek İstediğinize Emin Misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if (result == DialogResult.Yes) {
            cmd.ExecuteNonQuery();
            con.con().Close();
            MessageBox.Show("Ürün Başarılı Şekilde Güncellendi");
            }
            else
            {
                MessageBox.Show("Ürün Güncellenmedi");
            }
        }

        public void DeleteProduct(int id)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "Delete From Products where Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            DialogResult result = MessageBox.Show("Ürünü Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.con().Close();
                MessageBox.Show("Ürün Başarılı Şekilde Silindi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün Silinme İşleminden Vazgeçildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }



        public List<Notes> ListNotes()
        {
            var notelist = new List<Notes>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "select * from Notes";

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var notes = new Notes();
                notes.Id = Convert.ToInt32(reader[0]);
                notes.Description = Convert.ToString(reader[1]);
                notes.UpdateUser = Convert.ToString(reader[2]);
                notelist.Add(notes);
            }
            reader.Close();
            con.con().Close();
            return notelist;
        }


        public void SaveNotes(string? Description, string? UpdateUser)
        {
        

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "insert into Notes (Description,UpdateUser) values (@description,@updateuser)";
            cmd.Parameters.AddWithValue("description", Description);
            cmd.Parameters.AddWithValue("updateuser", UpdateUser);
            //  product.ProductName = ProductName;
            //product.Stock = Stock;
            //productList.Add(product);
            DialogResult result = MessageBox.Show("Notu Eklemek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.con().Close();
                MessageBox.Show("Not Başarılı Şekilde Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not Ekleme İşleminden Vazgeçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        public void UpdateNotes(string Description, string UpdateUser, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "Update Notes Set Description =@description,UpdateUser=@updateuser where Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("description", Description);
            cmd.Parameters.AddWithValue("updateuser", UpdateUser);
            DialogResult result = MessageBox.Show("Notu Güncellemek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.con().Close();
                MessageBox.Show("Not Başarılı Şekilde Güncellendi");
            }
            else
            {
                MessageBox.Show("Not Güncellenmedi");
            }
        }

        public void DeleteNotes(int id)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con.con();
            cmd.CommandText = "Delete From Notes where Id=@id";
            cmd.Parameters.AddWithValue("id", id);
            DialogResult result = MessageBox.Show("Notu Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                con.con().Close();
                MessageBox.Show("Not Başarılı Şekilde Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not Silinme İşleminden Vazgeçildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }



}
