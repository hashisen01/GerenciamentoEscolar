using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_Escolar
{
    public partial class db
    {
        //DECLARAÇÃO DE VARIÁVEIS
        private readonly string connection;
        //CONSTRUTOR
        public db()
        {
            connection = "";
        }
        //DECLARAÇÃO DE MÉTODO
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connection);
        }
    }
}
