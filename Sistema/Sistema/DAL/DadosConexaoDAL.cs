using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// data revisão 21/10

namespace DAL
{
    public class DadosConexaoDAL
    {
        public static String StringDeConexão
        {
            get
            {
                return "Data Source = PC\\SQLEXPRESS;Initial Catalog = dbSistema; Integrated Security = True";
            }
        }
    }
}
