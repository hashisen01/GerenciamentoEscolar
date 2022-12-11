using System;
using System.Windows.Forms;

namespace GerenciamentoEscolar.utils
{
    public class StudentData
    {
        public CheckBox InProject { get; set; }
        public CheckBox DontHaveEmail { get; set; }

        public string ParentsId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }

        public string ContactId { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email { get; set; }

        public string AddressId { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }

        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime Birth { get; set; }
        public string Nis { get; set; }
        public string StudentCod { get; set; }
        public string Note { get; set; }
        public string Shift { get; set; }
        public string Serie { get; set; }
        public string ProjectName { get ; set; }
        public int Active { get; set; }
    }
}
