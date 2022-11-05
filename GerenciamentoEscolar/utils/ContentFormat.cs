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
                maskedText.Mask = "00,00000,000-0";
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

        public string ContentFormatZipCode(string cep)
        {
            MaskedTextBox maskedText = new MaskedTextBox();
            if (cep.Length == 8)
            {
                maskedText.Mask = "00000-000";
                maskedText.Text = cep;
                return maskedText.Text;
            }
            return cep;
        }

        public string GetContentIsNumber(string field)
        {
            field = Regex.Replace(field, @"[^\d]", "");
            return field;
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
