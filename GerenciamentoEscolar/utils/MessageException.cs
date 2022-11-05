using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEscolar.utils
{
    public class MessageException
    {
        public MessageException()
        {

        }
        public string InvalidLogin()
        {
            return "Credenciais inválidas!";
        }

        public string InvalidEmail()
        {
            return "Email inválido!\r\nFormato de email inválido ou o campo está vazio.";
        }

        public string InputEmailIsEmpty()
        {
            return "O campo email não pode ser vazio!";
        }

        public string ShiftNotSelecting()
        {
            return "Nenhum turno foi selecionado.";
        }

        public string SerieNotSelecting()
        {
            return "Selecione uma série/ano ou projeto.";
        }

        public string ProjectNotSelecting()
        {
            return "Nenhum projeto foi selecionado.";
        }

        public string ProjectNameIsEmpty()
        {
            return "Informe o nome do projeto.";
        }

        public string CampoEmVaizo(string nomeCampo)
        {
            return $"Campo {nomeCampo} não pode ser vazio.";
        }

        public string CampoEmBranco(string nomeCampo)
        {
            return $"O campo {nomeCampo} foi preenchico incorretamente.";
        }

        public string InformeUmResponsavel()
        {
            return "Informe pelo menos um responsável pelo estudando.";
        }

        public string RegisterSuccess()
        {
            return "Matrícula realizada";
        }

        public string RegisterError()
        {
            return "Não foi possível concluir essa ação";
        }
    }
}
