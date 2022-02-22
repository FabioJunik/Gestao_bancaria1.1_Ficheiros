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
    public partial class frm_poupancas : Form
    {
        /*Como calcular os juros?
        Os juros são calculados da seguinte forma:
        J=Capital* Tempo*Taxa/365 dias ou 360 (com base na moeda a escolher)
        Exemplo: Escalão 90 dias: 100 000;00*90*9,50%/365= 23 4324,65*/


        public frm_poupancas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_poupancas_Load(object sender, EventArgs e)
        {

        }

        private void sld_meses_ValueChanged(object sender, EventArgs e)
        {
            lbl_meses.Text =sld_meses.Value.ToString()+" Mêses";
        }

        private void btn_rendimento_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Rendimento Crescente";
            lbl_descricao.Text = "Uma aplicação financeira, que remunera o investidor a uma taxa de juro crescente. ";
            lbl_montanteMinino.Text = "100.000 Kz";
            lbl_prazo.Text = "365 dias";
        }

        private void btn_depositoPrazo_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Depósito a prazo";
            lbl_descricao.Text = "Um depósito a prazo em que o cliente faz uma aplicação não mobilizável por certo tempo," +
                                  " tendo como contrapartida o rendimento de juros.";
            lbl_montanteMinino.Text = "250.000 Kz";
            lbl_prazo.Text = "1, 2, 3, 6 e 12 meses";
        }

        private void btn_contaJovem_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Depósito a prazo";
            lbl_descricao.Text = "Uma conta para jovens de até 17 anos, que " +
                                "incentiva a criação de uma poupança precoce.";
            lbl_montanteMinino.Text = "30.000 Kz";
            lbl_prazo.Text = "....";
        }
    }
}
