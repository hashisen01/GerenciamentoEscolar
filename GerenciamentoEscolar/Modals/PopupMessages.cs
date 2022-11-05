using GerenciamentoEscolar.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoEscolar.Modals
{
    public partial class PopupMessages : UserControl
    {
        MessageException messageException = new MessageException();
        bool success;
        public PopupMessages(bool success)
        {
            InitializeComponent();
            this.success = success;
        }

        private void popupMessages_Load(object sender, EventArgs e)
        {
            if (success == true)
                lblMessage.BackColor = Color.Lime;
            else
                lblMessage.BackColor = Color.FromArgb(240, 0, 30);

            lblMessage.Text = Message;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            for (int i = 0; i < progressBar.Maximum; i += 25)
            {
                Thread.Sleep(500);
                progressBar.Value += 25;
            }
        }
        private string message;
        private int progBar;

        public int ProgBar
        {
            get { return progBar; }
            set { progBar = progressBar.Value; }
        }

        public string Message
        {
            get { return message; }
            set 
            {
                if (success)
                    message = messageException.RegisterSuccess();
                else
                    message = messageException.RegisterError();
            }
        }
    }
}
