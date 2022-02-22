using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novembro_15
{
    public partial class frm_transacoes : Form
    {
        formManipulation formManipulation = new formManipulation();
        public frm_transacoes()
        {
            InitializeComponent();
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            formManipulation.OpenForm(new frm_deposito(), panel_main);
        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            formManipulation.OpenForm(new frm_saque(), panel_main);
        }

        private void btn_transferencia_Click(object sender, EventArgs e)
        {
            formManipulation.OpenForm(new frm_transferencia(), panel_main);
        }
    }
}
