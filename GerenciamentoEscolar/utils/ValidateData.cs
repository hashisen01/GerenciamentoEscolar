using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEscolar.utils
{
    public class ValidateData : AbstractValidator<StudentData>
    {
        public ValidateData()
        {
            RuleFor(_parentId => _parentId.ParentsId).NotEmpty().NotNull().WithMessage("ParentsID vazio ou null. Por favor, entre em contato com o dev se o erro persistir");
            RuleFor(_fatherName => _fatherName.FatherName).MaximumLength(100).WithMessage("Nome do pai deve conter no máximo 100 caracteres");
            RuleFor(_fatherName => _fatherName.FatherName).MinimumLength(3).WithMessage("Nome do pai deve conter pelos menos 3 caracteres");
            RuleFor(_motherName => _motherName.MotherName).MaximumLength(100).WithMessage("Nome da mãe deve conter no máximo 100 caracteres");
            RuleFor(_motherName => _motherName.MotherName).MinimumLength(3).WithMessage("Nome da mãe deve conter pelos menos 3 caracteres");

            RuleFor(_contactId => _contactId.ContactId).NotEmpty().NotNull().WithMessage("ContactID vazio ou null. Por favor, entre em contato com o dev se o erro persistir");
            RuleFor(_tel1 => _tel1.Telephone1).NotEmpty().When(_tel2 => (string.IsNullOrEmpty(_tel2.Telephone2)) && string.IsNullOrEmpty(_tel2.Email)).WithMessage("Preencha pelo menos uma forma de contato");
            RuleFor(_tel1 => _tel1.Telephone1).MinimumLength(11).When(_tel2 => (string.IsNullOrEmpty(_tel2.Telephone2))).WithMessage("Número de telefone 1 inválido");
            RuleFor(_tel2 => _tel2.Telephone2).NotEmpty().When(_tel1 => (string.IsNullOrEmpty(_tel1.Telephone1)) && string.IsNullOrEmpty(_tel1.Email)).WithMessage("Preencha pelo menos uma forma de contato");
            RuleFor(_tel2 => _tel2.Telephone2).Must(ContactLegth).When(_tel1 => (string.IsNullOrEmpty(_tel1.Telephone1))).WithMessage("Número de telefone 2 inválido");
            RuleFor(_email => _email.Email).Must(IsValidEmail).When(_dontHaveEmail => (!_dontHaveEmail.DontHaveEmail.Checked)).WithMessage("Endereço de email inválido");

            RuleFor(_addressId => _addressId.AddressId).NotEmpty().NotNull().WithMessage("AddressID vazio ou null. Por favor, entre em contato com o dev se o erro persistir");
            RuleFor(_cep => _cep.ZipCode).NotEmpty().WithMessage("CEP é inválido");
            RuleFor(_street => _street.Street).NotEmpty().WithMessage("Campo Rua não pode ser vazio");
            RuleFor(_district => _district.District).NotEmpty().WithMessage("Campo Bairro não pode ser vazio");
            RuleFor(_number => _number.Number).MaximumLength(7).WithMessage("Não pode conter mais que 7 caracteres");
            RuleFor(_number => _number.Number).NotEmpty().WithMessage("O campo Número não pode ser vazio");
            RuleFor(_city => _city.Street).NotEmpty().WithMessage("Campo Cidade não pode ser vazio");
            RuleFor(_complement => _complement.Complement).NotEmpty().When(_complement => (string.IsNullOrWhiteSpace(_complement.Complement))).WithMessage("Campo Complemento não aceita espaço em branco");

            RuleFor(_studentId => _studentId.StudentId).NotEmpty().NotNull().WithMessage("StudentID vazio ou null. Por favor, entre em contato com o dev se o erro persistir"); ;
            RuleFor(_name => _name.Name).MinimumLength(3).WithMessage("O nome do estudante deve conter pelo menos 3 caracteres");
            RuleFor(_name => _name.Name).MaximumLength(100).WithMessage("O nome do estudante não pode conter mais que 100 caracteres");
            RuleFor(_cpf => _cpf.Cpf).Length(11,11).WithMessage("CPF inválido");
            RuleFor(_dateBirth => _dateBirth.Birth).Must(BeAValidAge).WithMessage("Data de nascimento inválida");
            RuleFor(_nis => _nis.Nis).Length(11, 11).WithMessage("NIS/PIS é inválido");
            RuleFor(_codStudent => _codStudent.StudentCod).Length(12, 13).WithMessage("Código do aluno é inválido");
            RuleFor(_note => _note.Note).MinimumLength(3).WithMessage("A observação deve conter pelo menos 3 caracteres");
            RuleFor(_note => _note.Note).MaximumLength(300).WithMessage("A observação não pode conter mais que 300 caracteres");
            RuleFor(_shift => _shift.Shift).NotEmpty().WithMessage("Informe um turno");
            RuleFor(_serie => _serie.Serie).NotEmpty().WithMessage("Nenhuma série selecionada");
            RuleFor(_projectName => _projectName.ProjectName).NotEmpty().When(_inProject => (_inProject.InProject.Checked)).WithMessage("Nome do projeto não pode ser vazio");
            RuleFor(_projectName => _projectName.ProjectName).MinimumLength(3).When(_inProject => (_inProject.InProject.Checked)).WithMessage("O nome do projeto deve conter pelo menos que 3 caracteres");
            RuleFor(_projectName => _projectName.ProjectName).MaximumLength(100).When(_inProject => (_inProject.InProject.Checked)).WithMessage("O nome do projeto não pode conter mais que 100 caracteres");
        }

        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }

        public bool IsValidEmail(string email)
        {
            string emailValid = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            
            if (System.Text.RegularExpressions.Regex.IsMatch(email, emailValid))
            {
                return true;
            }

            return false;
        }

        protected bool ContactLegth(string contact)
        {
            try
            {
                long _contact = Convert.ToInt64(contact);
                if ((long)Math.Floor(Math.Log10(_contact)) + 1 < 11 && (long)Math.Floor(Math.Log10(_contact)) + 1 != 0)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
