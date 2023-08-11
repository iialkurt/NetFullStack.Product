using NetFullStack.Product.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFullStack.Product.UI
{
    public partial class LoginForm : Form
    {
        // ilk önce buraya userFullname stringi ekledik
        string? userFullName;



        public LoginForm()
        {
            InitializeComponent();
        


        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginControlManager login = new LoginControlManager();
            // userfullname ikisi de aynı isim mi olacak
           
            string logincontrol = login.LoginControl(txtUserName.Text, txtPassword.Text);

            if (logincontrol != "")
            {
                //3. ncü forma userFullName Ekledik
                //Form1 form = new Form1(userFullName);
                //yukarıdaki userFullname ye logincontrol deki dönen değeri aktardırk.
                userFullName = logincontrol;
                Navigation navigation = new Navigation(userFullName);
                navigation.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!");
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }



        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
