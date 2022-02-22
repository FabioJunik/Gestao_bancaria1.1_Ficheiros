using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novembro_15
{
    class stringManipulation:Constante
    {
        public string SortNumber(string number) 
        {
            char[] fragmentsOfNumber = number.ToCharArray();
            string SortedStrings = "";
            int tamanho = fragmentsOfNumber.Length;
            

            for (int i = fragmentsOfNumber.Length-1; i >= 0; i--) 
            {
                SortedStrings += "" + fragmentsOfNumber[i];
                if (tamanho == 8) {
                    if (i == 5 || i == 2) SortedStrings += "  ";
                }

                if (tamanho == 7)
                {
                    if (i == 4 || i == 1) SortedStrings += "  ";
                }

                if (tamanho == 6)
                {
                    if (i == 3) SortedStrings += "  ";
                }
                if (tamanho == 5)
                {
                    if (i == 2) SortedStrings += "  ";
                }
                    
                
            }

            char[] finalSorted = SortedStrings.ToCharArray();
            SortedStrings = "";

            for (int i = finalSorted.Length-1; i >= 0; i--)
            {
                SortedStrings += "" + finalSorted[i];
            }


            return SortedStrings;
        }

        public string OrganizarNome(string texto)
        {
            string superTexto = texto[0].ToString().ToUpper();

            for (int i = 0; i < texto.Length; i++)
            {
                if (i > 0)
                    if (texto[i - 1] == ' ')
                        superTexto += texto[i].ToString().ToUpper();
                    else
                        superTexto += texto[i].ToString().ToLower();

            }

            return superTexto;
        }
    }
}
