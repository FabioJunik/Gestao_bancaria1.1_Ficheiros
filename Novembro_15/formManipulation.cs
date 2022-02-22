using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novembro_15
{
    class formManipulation
    {
        public void OpenForm(object formulario, Panel controlador)
        {

            if (controlador.Controls.Count > 0)
            {
                controlador.Controls.RemoveAt(0);
            }
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            controlador.Controls.Add(fh);
            controlador.Tag = fh;
            fh.Show();

        }
    }
}
