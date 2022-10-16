
using System.Data.SqlClient;

namespace Gerenciamento_Escolar.str
{
    public class Login : db
    {
        //DECLARAÇÃO DO CONSTRUTOR
        public Login()
        {

        }

        //DECLARAÇÃO DE VARIÁVEIS
        public string username { get; set; }
        public string password { get; set; }
        public bool user_admin { get; set; }
        public bool response { get; set; }

        //DECLARAÇÃO DE MÉTODOS
        private void LoginUser()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM ADM_PINOQUIO WHERE (EMAIL = '" + username + "' AND SENHA = '" + password + "') OR (CPF = '" + username + "' AND SENHA = '" + password + "')";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        username = reader[1].ToString();
                        response = true;
                        //typeuser = int.Parse(reader[4].ToString());
                    }
                    else
                    {
                        response = false;
                    }
                }
            }
        }
        public bool IsEmpty(string username, string password)
        {
            this.username = username;
            this.password = password;
            if ((this.username != "" || this.password != ""))
            {
                LoginUser();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
