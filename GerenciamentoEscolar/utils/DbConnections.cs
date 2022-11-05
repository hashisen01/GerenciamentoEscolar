using GerenciamentoEscolar.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Gerenciamento_Escolar.str
{
    public class DbConnections : db
    {
        //DECLARAÇÃO DO CONSTRUTOR
        public DbConnections()
        {

        }

        //DECLARAÇÃO DE VARIÁVEIS
        public string username { get; set; }
        public string password { get; set; }
        public bool user_admin { get; set; }
        public bool response { get; set; }

        //DECLARAÇÃO DE MÉTODOS
        private void LoginConnection()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = $"SELECT * FROM ADM_PINOQUIO WHERE (EMAIL = '{username}' AND SENHA = '{password}') OR (CPF = '{username}' AND SENHA = '{password}')";
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
        public bool LoginUser(string username, string password)
        {
            this.username = username;
            this.password = password;
            if (!string.IsNullOrEmpty(this.username) || !string.IsNullOrEmpty(this.password))
            {
                LoginConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegisterAddressStudent(StudentData studentData)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    var query = $"INSERT INTO [STUDENTS_ADDRESS] VALUES('{studentData.AddressId}', '{ studentData.ZipCode}', '{ studentData.Street}', '{studentData.District}', '{studentData.City}', '{studentData.Number}', '{studentData.Complement}')";
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = query;
                        int result = cmd.ExecuteNonQuery();
                        if (result < 1)
                            return false;
                        else
                            return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool RegisterContactStudent(StudentData studentData)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    var query = $"INSERT INTO [CONTACTS] VALUES('{ studentData.ContactId }', '{ studentData.Telephone1 }', '{ studentData.Telephone2 }', '{ studentData.Email }')";
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = query;
                        int result = cmd.ExecuteNonQuery();
                        if (result < 1)
                            return false;
                        else
                            return true;
                    }
                }
            } 
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool RegisterParentsStudent(StudentData studentData)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    var query = $"INSERT INTO [PARENTS] VALUES('{ studentData.ParentsId }', '{ studentData.FatherName }', '{ studentData.MotherName }')";
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = query;
                        int result = cmd.ExecuteNonQuery();
                        if (result < 1)
                            return false;
                        else
                            return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool RegisterStudent(StudentData studentData)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    var query = $"INSERT INTO [STUDENTS] VALUES('{ studentData.StudentId }', '{ studentData.Name }', '{ studentData.Cpf }', '{ studentData.Birth }', '{ studentData.Nis }', '{ studentData.StudentCod }', '{ studentData.Serie }', '{ studentData.ProjectName }', '{ studentData.Shift }', '{ studentData.AddressId }', '{ studentData.ContactId }', '{ studentData.ParentsId }', '{ studentData.Active }')";
                    connection.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = query;
                        int result = cmd.ExecuteNonQuery();
                        if (result < 1)
                            return false;
                        else
                            return true;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public StudentData ShearchStudent(string cpf)
        {
            Console.WriteLine(cpf);
            using (var connection = GetConnection())
            {
                int i = 0;
                int n = 0;
                var studentData = new StudentData();
                string query = $"SELECT * FROM STUDENTS A INNER JOIN STUDENTS_ADDRESS B ON A.ADDRESS_ID = B.ADDRESS_ID INNER JOIN CONTACTS C ON A.CONTACT_ID = C.CONTACT_ID INNER JOIN PARENTS D ON A.PARENTS_ID = D.PARENTS_ID WHERE A.CPF = '402.884.069-40'";
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["STUDENT_NAME"].ToString());
                        }
                        //studentData.Cpf = reader["CPF"].ToString();
                        //studentData.Birth = Convert.ToDateTime(reader["STUDENT_NAME"]);
                        //studentData.Nis = reader["STUDENT_NAME"].ToString();
                        //studentData.CadSensus = reader["STUDENT_NAME"].ToString();
                        //studentData.FatherName = reader["STUDENT_NAME"].ToString();
                        //studentData.MotherName = reader["STUDENT_NAME"].ToString();
                        //studentData.Telephone1 = reader["STUDENT_NAME"].ToString();
                        //studentData.Telephone2 = reader["STUDENT_NAME"].ToString();
                        //studentData.Email = reader["STUDENT_NAME"].ToString();
                        //studentData.Serie = reader["STUDENT_NAME"].ToString();
                        //studentData.Shift = reader["STUDENT_NAME"].ToString();
                        //studentData.ProjectName = reader["STUDENT_NAME"].ToString();
                        //studentData.ZipCode = reader["STUDENT_NAME"].ToString();
                        //studentData.Street = reader["STUDENT_NAME"].ToString();
                        //studentData.District = reader["STUDENT_NAME"].ToString();
                        //studentData.City = reader["STUDENT_NAME"].ToString();
                        //studentData.Number = reader["STUDENT_NAME"].ToString();
                        //studentData.Complement = reader["STUDENT_NAME"].ToString();
                    }
                    return studentData;
                }
            }
        }
    }
}
