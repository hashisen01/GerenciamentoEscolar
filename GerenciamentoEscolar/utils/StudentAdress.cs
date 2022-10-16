using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEscolar.utils
{
    class StudentAdress
    {
        public string ZipCode { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string NumberAdress { get; set; }
        public string Complement { get; set; }

        public StudentAdress(string ZipCode, string District, string Street, string City, string NumberAdress, string Complement)
        {
            this.ZipCode = ZipCode;
            this.District = District;
            this.Street = Street;
            this.City = City;
            this.NumberAdress = NumberAdress;
            this.Complement = Complement;
        }
    }
}
