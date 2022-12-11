using GerenciamentoEscolar.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Gerenciamento_Escolar.str
{
    public partial class DbConnections : db
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
            bool response = false;
            string query = $"INSERT INTO [_ADDRESS] VALUES('{studentData.AddressId}', '{studentData.ZipCode}', '{studentData.Street}', '{studentData.District}', '{studentData.City}', '{studentData.Number}', '{studentData.Complement}')";
            response = registerStudentData(query);
            return response;
        }

        public bool RegisterContactStudent(StudentData studentData)
        {
            bool response = false;
            string query = $"INSERT INTO [CONTACTS] VALUES('{studentData.ContactId}', '{studentData.Telephone1}', '{studentData.Telephone2}', '{studentData.Email}')";
            response = registerStudentData(query);
            return response;
        }

        public bool RegisterParentsStudent(StudentData studentData)
        {
            bool response = false;
            string query = $"INSERT INTO [PARENTS] VALUES('{studentData.ParentsId}', '{studentData.FatherName}', '{studentData.MotherName}')";
            response = registerStudentData(query);
            return response;
        }

        public bool RegisterStudent(StudentData studentData)
        {
            bool response = false;
            string query = $"INSERT INTO [STUDENTS] VALUES('{studentData.StudentId}', '{studentData.Name}', '{studentData.Cpf}', '{studentData.Birth}', '{studentData.Nis}', '{studentData.StudentCod}', '{studentData.Serie}', '{studentData.ProjectName}', '{studentData.Shift}', '{studentData.AddressId}', '{studentData.ContactId}', '{studentData.ParentsId}', '{studentData.Active}', '{studentData.Note}')";
            response = registerStudentData(query);
            return response;
        }

        public List<StudentData> ShearchAllStudent()
        {
            List<StudentData> studentData = new List<StudentData>();
            string query = $"SELECT A._NAME, A.CPF, A.BIRTH_DATE, A.NIS, A.STUDENT_CODE, A.SERIE, A.ACTIVE, D.MOTHER_NAME, D.FATHER_NAME FROM STUDENTS A INNER JOIN _ADDRESS B ON A.ADDRESS_ID = B.ID INNER JOIN CONTACTS C ON A.CONTACT_ID = C.ID INNER JOIN PARENTS D ON A.PARENTS_ID = D.ID ORDER BY A._NAME ASC";
            studentData = selectStudents(query);
            return studentData;
        }

        public List<StudentData> ShearchByCPF(string cpf)
        {
            List<StudentData> studentData = new List<StudentData>();
            string query = $"SELECT A._NAME, A.CPF, A.BIRTH_DATE, A.NIS, A.STUDENT_CODE, A.SERIE, A.ACTIVE, D.MOTHER_NAME, D.FATHER_NAME FROM STUDENTS A INNER JOIN _ADDRESS B ON A.ADDRESS_ID = B.ID INNER JOIN CONTACTS C ON A.CONTACT_ID = C.ID INNER JOIN PARENTS D ON A.PARENTS_ID = D.ID WHERE A.CPF = '{cpf}' ORDER BY A._NAME ASC";
            studentData = selectStudents(query);
            return studentData;
        }

        public List<StudentData> ShearchByStatus(byte status)
        {
            Console.WriteLine(status);
            List<StudentData> studentData = new List<StudentData>();
            string query = $"SELECT A._NAME, A.CPF, A.BIRTH_DATE, A.NIS, A.STUDENT_CODE, A.SERIE, A.ACTIVE, D.MOTHER_NAME, D.FATHER_NAME FROM STUDENTS A INNER JOIN _ADDRESS B ON A.ADDRESS_ID = B.ID INNER JOIN CONTACTS C ON A.CONTACT_ID = C.ID INNER JOIN PARENTS D ON A.PARENTS_ID = D.ID WHERE A.ACTIVE = {status} ORDER BY A._NAME ASC";
            studentData = selectStudents(query);
            return studentData;
        }

        public List<StudentData> ShearchByNameAndBirthDate(string name, DateTime birthDate)
        {
            List<StudentData> studentData = new List<StudentData>();
            string query = $"SELECT A._NAME, A.CPF, A.BIRTH_DATE, A.NIS, A.STUDENT_CODE, A.SERIE, A.ACTIVE, D.MOTHER_NAME, D.FATHER_NAME FROM STUDENTS A INNER JOIN _ADDRESS B ON A.ADDRESS_ID = B.ID INNER JOIN CONTACTS C ON A.CONTACT_ID = C.ID INNER JOIN PARENTS D ON A.PARENTS_ID = D.ID  WHERE A._NAME = '{name}' AND A.BIRTH_DATE = '{birthDate.Date}' ORDER BY A._NAME ASC";
            studentData = selectStudents(query);
            return studentData;
        }

        public List<StudentData> SelectAllDataStudent(string cpf)
        {
            List<StudentData> studentData = new List<StudentData>();
            string query = "SELECT A.ID, A._NAME, A.CPF, A.BIRTH_DATE, A.NIS, A.STUDENT_CODE, A.SERIE, A.PROJECT_NAME, A.SHIFT_, A.ACTIVE, A.NOTE, A.ADDRESS_ID, A.CONTACT_ID, A.PARENTS_ID, " +
                           "B.ZIP_CODE, B.STREET, B.DISTRICT, B.CITY, B.NUMBER, B.COMPLEMENT, " +
                           "C.CONTACT_TEL1, C.CONTACT_TEL2, C.EMAIL, " +
                           "D.FATHER_NAME, D.MOTHER_NAME " +
                          $"FROM STUDENTS A INNER JOIN _ADDRESS B ON A.ADDRESS_ID = B.ID INNER JOIN CONTACTS C ON A.CONTACT_ID = C.ID INNER JOIN PARENTS D ON A.PARENTS_ID = D.ID WHERE A.CPF = '{cpf}' ORDER BY A._NAME ASC";
            studentData = selectAllDataStudent(query);
            return studentData;
        }

        public string[] UpdateByStatus(string cpf, byte active)
        {
            string[] response = new string[2];
            string query = $"UPDATE STUDENTS SET ACTIVE = {active} WHERE CPF = '{cpf}'";
            response = alterStudentData(query);
            return response;
        }

        public bool[] UpdateAllDataStudent(StudentData studentData)
        {
            bool[] response = new bool[4];
            string[] querys = { $"UPDATE STUDENTS SET [_NAME] = '{studentData.Name}', [CPF] = '{studentData.Cpf}', [BIRTH_DATE] = '{studentData.Birth}', [NIS] = '{studentData.Nis}', [STUDENT_CODE] = '{studentData.StudentCod}', [SERIE] = '{studentData.Serie}', [SHIFT_] = '{studentData.Shift}', [PROJECT_NAME] = '{studentData.ProjectName}', [NOTE] = '{studentData.Note}' WHERE ID = '{studentData.StudentId}'",
                                $"UPDATE _ADDRESS SET [ZIP_CODE] = '{studentData.ZipCode}', [STREET] = '{studentData.Street}', [DISTRICT] = '{studentData.District}', [CITY] = '{studentData.City}', [NUMBER] = '{studentData.Number}', [COMPLEMENT] = '{studentData.Complement}' WHERE ID = '{studentData.AddressId}'",
                                $"UPDATE CONTACTS SET [CONTACT_TEL1] = '{studentData.Telephone1}', [CONTACT_TEL2] = '{studentData.Telephone2}', [EMAIL] = '{studentData.Email}' WHERE ID = '{studentData.ContactId}'",
                                $"UPDATE PARENTS SET [FATHER_NAME] = '{studentData.FatherName}', [MOTHER_NAME] = '{studentData.MotherName}' WHERE ID = '{studentData.ParentsId}'" };

            response[0] = updateStudent(querys[0]);
            response[1] = updateStudent(querys[1]);
            response[2] = updateStudent(querys[2]);
            response[3] = updateStudent(querys[3]);
            return response;
        }

        public string[] DeleteSudent(string cpf, byte delete)
        {
            string[] response = new string[2];
            string query = $"UPDATE STUDENTS SET DELETED = {delete} WHERE CPF = '{cpf}'";
            response = alterStudentData(query);
            return response;
        }

        protected void LoginConnection()
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
                    }
                    else
                    {
                        response = false;
                    }
                }
            }
        }

        protected bool registerStudentData(string query)
        {
            using (var connection = GetConnection())
            {
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

        protected List<StudentData> selectStudents(string query)
        {
            using (var connection = GetConnection())
            {
                List<StudentData> studentData = new List<StudentData>();
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
                            studentData.Add(new StudentData()
                            {
                                Name = reader["_NAME"].ToString(),
                                Cpf = reader["CPF"].ToString(),
                                Birth = Convert.ToDateTime(reader["BIRTH_DATE"]),
                                Nis = reader["NIS"].ToString(),
                                StudentCod = reader["STUDENT_CODE"].ToString(),
                                Serie = reader["SERIE"].ToString(),
                                Active = Convert.ToInt16(reader["ACTIVE"]),
                                FatherName = reader["FATHER_NAME"].ToString(),
                                MotherName = reader["MOTHER_NAME"].ToString(),
                            });
                        }
                    }
                    return studentData;
                }
            }
        }

        protected List<StudentData> selectAllDataStudent(string query)
        {
            using (var connection = GetConnection())
            {
                List<StudentData> studentData = new List<StudentData>();
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
                            studentData.Add(new StudentData()
                            {
                                StudentId = reader["ID"].ToString(),
                                Name = reader["_NAME"].ToString(),
                                Cpf = reader["CPF"].ToString(),
                                Birth = Convert.ToDateTime(reader["BIRTH_DATE"]),
                                Nis = reader["NIS"].ToString(),
                                StudentCod = reader["STUDENT_CODE"].ToString(),
                                Serie = reader["SERIE"].ToString(),
                                ProjectName = reader["PROJECT_NAME"].ToString(),
                                Shift = reader["SHIFT_"].ToString(),
                                Active = Convert.ToInt32(reader["ACTIVE"]),
                                Note = reader["NOTE"].ToString(),
                                AddressId = reader["ADDRESS_ID"].ToString(),
                                ZipCode = reader["ZIP_CODE"].ToString(),
                                Street = reader["STREET"].ToString(),
                                District = reader["DISTRICT"].ToString(),
                                City = reader["CITY"].ToString(),
                                Number = reader["NUMBER"].ToString(),
                                Complement = reader["COMPLEMENT"].ToString(),
                                ContactId = reader["CONTACT_ID"].ToString(),
                                Telephone1 = reader["CONTACT_TEL1"].ToString(),
                                Telephone2 = reader["CONTACT_TEL2"].ToString(),
                                Email = reader["EMAIL"].ToString(),
                                ParentsId = reader["PARENTS_ID"].ToString(),
                                FatherName = reader["FATHER_NAME"].ToString(),
                                MotherName = reader["MOTHER_NAME"].ToString(),
                            });
                        }
                    }
                    return studentData;
                }
            }
        }

        protected string[] alterStudentData(string query)
        {
            string[] response = new string[2];

            using (var connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                    {
                        response[0] = "ERRO INTERNO!";
                        response[1] = "Ops! Algo deu errado! Verifique a base de dados e tente novamente.";
                    }
                    else if (result == 0)
                    {
                        response[0] = "Não foi possível realizar está ação";
                        response[1] = "O estudante não foi encontrado na base de dados";
                    }
                    else if (result >= 1)
                    {
                        response[0] = "Sucesso!";
                        response[1] = "Ação realizada com sucesso!";
                    }
                }
            }
            return response;
        }

        protected bool updateStudent(string query)
        {
            bool response = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = query;
                    int result = cmd.ExecuteNonQuery();

                    if (result < 1)
                        return response;
                    else
                        response = true;

                    return response;
                }
            }
        }
    }
}
