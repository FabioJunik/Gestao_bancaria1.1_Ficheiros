using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Novembro_15
{
    class operacoes
    {
        public string GerarNConta()
        {
            Random a = new Random();

            int nConta = a.Next(1000000, 9999999);
            int nConta2 = a.Next(100000, 999999);

            return nConta.ToString() + nConta2.ToString();

        }

        public string GerarSenha()
        {
            Random aleatorio = new Random();

            return aleatorio.Next(1000, 9999).ToString();
        }

        public string GerarIBAM(string nConta)
        {
            return "AO0600400000" + nConta;
        }

        public void ApenasNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        public void ApenasTexto(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
                e.Handled = true;

        }

        public void LimparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        public int ArrayPosition(ArrayList lista, string item)
        {
            for (int i = 0; i < lista.Count; i++)
            { 
                if (lista[i].ToString() == item)
                    return i;
            } 

            return -1;
        }

        public void BI_KeyPress(string nBI , KeyPressEventArgs e)
        {
            if (nBI.Length < 9)
                ApenasNumero(e);
            else if (nBI.Length < 11)
                ApenasTexto(e);
            else if (nBI.Length < 14)
                ApenasNumero(e);
            else
                e.Handled = true;

            if (e.KeyChar == 8)
                e.Handled = false;
        }


    }
}
