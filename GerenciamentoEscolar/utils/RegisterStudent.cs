using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEscolar.utils
{
    public class RegisterStudent
    {
        List<StudentData> studentData;
        List<StudentAdress> studentAdresse;
        GenericMethods genericMethods = new GenericMethods();
        public List<string> StudentDataSave(string[] formData)
        {
            studentData = new List<StudentData>();
            List<string> invalidInput = new List<string>();

            studentData.Add(new StudentData(
                formData[0],
                formData[1],
                formData[2],
                formData[3],
                formData[4],
                formData[5],
                formData[6],
                formData[7],
                formData[8],
                formData[9],
                formData[10],
                formData[11],
                formData[12],
                formData[13]
            ));

            if (string.IsNullOrEmpty(studentData[0].Name) || string.IsNullOrEmpty(studentData[0].Name))
            {
                invalidInput.Add("Nome do(a) aluno(a):");
            }
            if (studentData[0].Cpf.Length < 11)
            {
                invalidInput.Add("CPF:");
            }
            if ((string.IsNullOrEmpty(studentData[0].NameFather) && string.IsNullOrWhiteSpace(studentData[0].NameFather)) && (string.IsNullOrEmpty(studentData[0].NameMother) || string.IsNullOrWhiteSpace(studentData[0].NameMother)))
            {
                invalidInput.Add("Informe pelo menos um responsável!");
            }
            if (string.IsNullOrEmpty(studentData[0].Birth) || string.IsNullOrWhiteSpace(studentData[0].Birth))
            {
                invalidInput.Add("Nascimento:");
            }
            if (!genericMethods.IsValidEmail(studentData[0].Email) && studentData[0].Email != "Não tem email")
            {
                invalidInput.Add("Email inválido!");
            }
            if (string.IsNullOrEmpty(studentData[0].Shift) || string.IsNullOrWhiteSpace(studentData[0].Shift))
            {
                invalidInput.Add("Turno:");
            }
            if (string.IsNullOrEmpty(studentData[0].Serie))
            {
                invalidInput.Add("Série/Ano:");
            }
            if (studentData[0].Project != null && studentData[0].Project.Length < 4)
            {
                invalidInput.Add("Projeto:");
            }
            if ((string.IsNullOrEmpty(studentData[0].OtherProject) || string.IsNullOrWhiteSpace(studentData[0].OtherProject)) && studentData[0].OtherProject != null)
            {
                invalidInput.Add("Nome projeto:");
            }

            return invalidInput;
        }

        public List<string> StudenAdressSave(string[] addressData)
        {
            studentAdresse = new List<StudentAdress>();
            List<string> invalidInput = new List<string>();

            studentAdresse.Add(new StudentAdress(
                    addressData[0],
                    addressData[1],
                    addressData[2],
                    addressData[3],
                    addressData[4],
                    addressData[5]
                ));
            if (studentAdresse[0].ZipCode.Length < 9)
            {
                invalidInput.Add("Cep:");
            }
            if (string.IsNullOrEmpty(studentAdresse[0].District) || string.IsNullOrWhiteSpace(studentAdresse[0].District))
            {
                invalidInput.Add("Bairro:");
            }
            if (string.IsNullOrEmpty(studentAdresse[0].Street) || string.IsNullOrWhiteSpace(studentAdresse[0].Street))
            {
                invalidInput.Add("Rua:");
            }
            if (string.IsNullOrEmpty(studentAdresse[0].City) || string.IsNullOrWhiteSpace(studentAdresse[0].City))
            {
                invalidInput.Add("Cidade:");
            }
            if (string.IsNullOrEmpty(studentAdresse[0].NumberAdress) || string.IsNullOrWhiteSpace(studentAdresse[0].NumberAdress))
            {
                invalidInput.Add("Número:");
            }
            return invalidInput;
        }
    }
}
