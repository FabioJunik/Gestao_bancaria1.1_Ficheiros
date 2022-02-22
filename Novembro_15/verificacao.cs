using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Novembro_15
{
    class Verificacoes:stringManipulation
    {
        
        public bool Vazio(string campo)
        {
            return campo == "";
        }

        public bool Iguais(string txt1, string txt2)
        {
            return txt1.ToLower().Trim() == txt2.ToLower().Trim();
        }

        public bool AlgumVazio(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox && ctrl.Text == "")
                {
                    return true;
                }

            }
            return false;
        }

        public bool NomeValido(string nome)
        {
            nome.Trim();

            string[] subNomes = nome.Split(' ');
            bool retorno = true;

            if (subNomes.Length == 1)
                retorno = false;

            for (int i = 0; i < subNomes.Length; i++)
            {
                if (subNomes[0].Length < 2)
                    retorno = false;

                if (subNomes[i].Length <= 1)
                    retorno = false;
            }

            return retorno;
        }

        public bool IsPhoneNumberAO(string num)
        {

            if (num.Length < 2)
                return false;

            return AngoPhoneNumber.Contains(num.Substring(0, 2)) && num.Length == 9;
        }

        public bool IsMovicelNumber(string num)
        {


            if (num.Length < 2)
                return false;

            return MovicelPhoneNumber.Contains(num.Substring(0, 2)) && num.Length == 9;
        }

        public bool IsUnitelNumber(string num)
        {

            if (num.Length < 2)
                return false;

            return UnitelPhoneNumber.Contains(num.Substring(0, 2)) && num.Length == 9;
        }
        public bool BIValido(string numBI)
        {
            bool verifacao = false;

            if (numBI.Trim().Length == 13)
                verifacao = true;

           return verifacao;
        }

        public bool MaiorDeIdade(string data)
        {
            bool verificacao = false;

            string[] dataActual = DateTime.Now.ToString("dd/MM/yyyy").Split('/');
            string[] dataNascimento = data.Split(' ')[0].Split('/');

            //int diaActual = int.Parse(dataActual[0]);
            //int mesActual = int.Parse(dataActual[1]);
            int anoActual = int.Parse(dataActual[2]);

            //int diaNascimento = int.Parse(dataNascimento[0]);
            //int mesNascimento = int.Parse(dataNascimento[1]);
            int anoNascimento = int.Parse(dataNascimento[2]);

            int idadeActual = anoActual - anoNascimento;


            if (idadeActual >=18)
                verificacao = true;

            return verificacao;
        }

        public bool DataValida(string data)
        {
            bool verificacao = false;

            string[] dataActual = DateTime.Now.ToString("dd/MM/yyyy").Split('/');
            string[] dataNascimento = data.Split(' ')[0].Split('/');

            int diaActual = int.Parse(dataActual[0]);
            int mesActual = int.Parse(dataActual[1]);
            int anoActual = int.Parse(dataActual[2]);

            int diaNascimento = int.Parse(dataNascimento[0]);
            int mesNascimento = int.Parse(dataNascimento[1]);
            int anoNascimento = int.Parse(dataNascimento[2]);

            int idadeActual = anoActual - anoNascimento;


            if (idadeActual > -1)
                verificacao = true;

            return verificacao;
        }
    }
}
