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
    public partial class Navigation : Form
    {
        string userFullName;
        public Navigation(string NuserFullName)
        {
            InitializeComponent();
            this.userFullName = NuserFullName;
            lblUser.Text = userFullName;

        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        private void Navigation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(userFullName);
            form.Show();
            // this.Hide();
        }

        private void btnDictonary_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes(userFullName);
            notes.Show();
        }
    }
}
