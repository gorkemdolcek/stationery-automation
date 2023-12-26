using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoldPencils
{
    internal class sqlconnect
    {
        public SqlConnection Baglanti = new SqlConnection("Data Source=KARLOS\\SQLEXPRESS;Database=kirtasiye;Integrated Security=SSPI;");
        public sqlconnect()
        {
        }
        public void ConnectionOpen()
        {
            Baglanti.Open();
        }
    }
}
