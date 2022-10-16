using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEscolar.utils
{
    class StudentData
    {
        //CONSTRUCTOR
        public StudentData()
        {

        }

        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Birth { get; set; }
        public string PisNis { get; set; }
        public string CadSensus { get; set; }
        public string NameFather { get; set; }
        public string NameMother { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email { get; set; }
        public string Shift { get; set; }
        public string Serie { get; set; }
        public string Project { get; set; }
        public string OtherProject { get; set; }

        public StudentData(string Name, string Cpf, string Birth, string PisNis, string CadSensus, string NameFather, string NameMother, string Telephone1, string Telephone2, string Email, string Shift, string Serie, string Project, string OtherProjetc)
        {
            this.Name = Name;
            this.Cpf = Cpf;
            this.Birth = Birth;
            this.PisNis = PisNis;
            this.CadSensus = CadSensus;
            this.NameFather = NameFather;
            this.NameMother = NameMother;
            this.Telephone1 = Telephone1;
            this.Telephone2 = Telephone2;
            this.Email = Email;
            this.Shift = Shift;
            this.Serie = Serie;
            this.Project = Project;
            this.OtherProject = OtherProjetc;
        }
    }
}
