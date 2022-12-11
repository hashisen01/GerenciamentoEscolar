using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEscolar.utils
{
    class ContentFormat
    {
        public ContentFormat()
        {
            
        }

        public void DateFormat(DateTimePicker date)
        {
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "dd/MM/yyyy";
        }

        public string ContentFormatCpf(string cpf)
        {
            MaskedTextBox maskedText = new MaskedTextBox();
            if (cpf.Length > 10)
            {
                maskedText.Mask = "000,000,000-00";
                maskedText.Text = cpf;
                return maskedText.Text;
            }
            return cpf;
        }

        public string ContentFormatNis(string nis)
        {
            MaskedTextBox maskedText = new MaskedTextBox();
            if (nis.Length > 10)
            {
                maskedText.Mask = "000,00000,00-0";
                maskedText.Text = nis;
                return maskedText.Text;
            }
            return nis;
        }


        public string ContentFormatTelephone(string telephone)
        {
            MaskedTextBox maskedText = new MaskedTextBox();
            if (telephone.Length > 10)
            {
                maskedText.Mask = "(00)00000-0000";
                maskedText.Text = telephone;
                return maskedText.Text;
            }
            return telephone;
        }

        public string ContentFormatZipCode(string zipCode)
        {
            MaskedTextBox maskedText = new MaskedTextBox();
            if (zipCode.Length == 8)
            {
                maskedText.Mask = "00000-000";
                maskedText.Text = zipCode;
                return maskedText.Text;
            }
            return zipCode;
        }

        public string GetContentIsNumber(string field)
        {
            field = Regex.Replace(field, @"[^\d]", "");
            return field;
        }
        
        public bool IsValidName(string fullName)
        {
            if (Regex.IsMatch(fullName, @"^[a-zA-Z\u00C0-\u017F´]+\s+[a-zA-Z\u00C0-\u017F´]{0,}$"))
                return true;

            return false;
        }

        public string RemoveContentFormat(string feild)
        {
            return feild.Replace("(", "").Replace(")", "").Replace(" ", "").Replace(".", "").Replace("-", "");
        }

        public int GetCaretPositionCpf(int fieldLength, int position)
        {
            if ((fieldLength == position && position != 10) || (fieldLength == 14 && position == 11))
                return fieldLength;

            else if (fieldLength == 10 && position == 12)
                return position - 3;

            else if (fieldLength == 14 && position == 10)
                return position + 3;

            else if (fieldLength == 10 && position <= 10 && position > 6)
                return position - 2;

            else if (fieldLength == 14 && position <= 9 && position > 6)
                return position + 2;

            else if (fieldLength == 14 && position <= 6 && position > 3)
                return position + 1;

            else if (fieldLength == 10 && position <= 6 && position >= 3)
                return position - 1;

            return position;
        }

        public int GetCaretPositionNis(int fieldLength, int position)
        {

            if ((fieldLength == position && position != 10) || (fieldLength == 14 && position == 11))
                return fieldLength;

            else if (fieldLength == 14 && position == 10)
                return position + 3;

            else if (fieldLength == 14 && position < 10 && position > 7)
                return position + 2;

            else if (fieldLength == 14 && position <= 7 && position > 2)
                return position + 1;

            else if (fieldLength == 10 && position == 12)
                return position - 3;

            else if (fieldLength == 10 && position <= 11 && position > 7)
                return position - 2;

            else if (fieldLength == 10 && position <= 7 && position >= 2)
                return position - 1;

            return position;
        }

        public int GetCaretPositionTelephone(int fieldLength, int position)
        {
            if ((fieldLength == position && position != 10) || (fieldLength == 14 && position == 11))
                return fieldLength;

            else if (fieldLength == 14 && position < 3 && position >= 1)
                return position + 1;

            else if (fieldLength == 10 && position <= 3 && position >= 1)
                return position - 1;

            else if (fieldLength == 14 && position >= 3 && position < 9)
                return position + 2;

            else if (fieldLength == 10 && position > 3 && position <= 9)
                return position - 2;

            else if (fieldLength == 14 && position >= 9 && position <= 13)
                return position + 3;

            else if (fieldLength == 10 && position >= 9 && position <= 13)
                return position - 3;

            return position;
        }

        public int GetCaretPositionZipCode(int fielfLength, int position)
        {
            if (fielfLength == 7 && position > 5)
                return position - 1;

            else if (fielfLength == 9 && position > 5)
                return position + 1;

            else
                return position;
        }
    }
}
