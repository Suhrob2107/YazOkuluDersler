using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-1GEE0JQ;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
//6. solution sag tik new project DataAccessLayer olusturucaz burada islemleri
//gercekleştiricez veri tabanina baglanmak icin
// class -> Baglanti.cs 