using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace NetFullStack.Product.Entities
  
{
    public class ConnectionManager
    {

  
        public SqlConnection con()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TutorialDb;Integrated Security=true");
            con.Open();
            return con; 

        }

       
    }
}
