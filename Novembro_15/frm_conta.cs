using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Novembro_15
{
    public partial class frm_conta : Form
    {
        public frm_conta()
        {
            InitializeComponent();
        }

        private void abrir_formulario(object formulario)
        {

            if (panel_conta.Controls.Count > 0)
            {
                panel_conta.Controls.RemoveAt(0);
            }
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panel_conta.Controls.Add(fh);
            panel_conta.Tag = fh;
            fh.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FormTrans_Load(object sender, EventArgs e)
        {
          //  abrir_formulario(new frm_conta_nacional());
           
        }
        /*-----------------------------------------------------*/



        private void cb_nacional_OnChange(object sender, EventArgs e)
        {
            if (cb_menor.Checked || cb_estrangeiro.Checked)
            {
                cb_menor.Checked = false;
                cb_estrangeiro.Checked = false;
            }

            if (cb_nacional.Checked && cb_conta_ordem.Checked)
                abrir_formulario(new frm_conta_nacional("nacional","ordem"));

            else if(cb_nacional.Checked && cb_conta_salario.Checked)
                abrir_formulario(new frm_conta_nacional("nacional","salario"));    

        }

        private void cb_estrangeiro_OnChange(object sender, EventArgs e)
        {
            if (cb_menor.Checked || cb_nacional.Checked)
            {
                cb_menor.Checked = false;
                cb_nacional.Checked = false;
            }

            if(cb_estrangeiro.Checked && cb_conta_ordem.Checked)
                abrir_formulario(new frm_conta_estrangeira("estrageiro","ordem"));

            else if (cb_estrangeiro.Checked && cb_conta_salario.Checked)
                abrir_formulario(new frm_conta_estrangeira("estrageiro", "salario"));
        }

        private void cb_menor_OnChange(object sender, EventArgs e)
        {
            if (cb_nacional.Checked || cb_estrangeiro.Checked)
            {
                cb_nacional.Checked = false;
                cb_estrangeiro.Checked = false;
            }

            if (cb_menor.Checked && cb_conta_ordem.Checked)
                abrir_formulario(new frm_Menor_de_idade("menor de idade","ordem"));
            
            else if (cb_menor.Checked && cb_conta_salario.Checked)
                abrir_formulario(new frm_Menor_de_idade("menor de idade", "salario"));

        }

        private void cb_conta_ordem_OnChange(object sender, EventArgs e)
        {
            if(cb_conta_salario.Checked)
                cb_conta_salario.Checked= false;

            if (cb_nacional.Checked && cb_conta_ordem.Checked)
                abrir_formulario(new frm_conta_nacional("nacional", "ordem"));

            else if (cb_estrangeiro.Checked && cb_conta_ordem.Checked)
                abrir_formulario(new frm_conta_estrangeira("estrangeiro", "ordem"));

            else if (cb_menor.Checked && cb_conta_ordem.Checked)
                abrir_formulario(new frm_Menor_de_idade("menor de idade", "ordem"));
        }

        private void cb_conta_salario_OnChange(object sender, EventArgs e)
        {
            if (cb_conta_ordem.Checked)
                cb_conta_ordem.Checked = false;

            if (cb_conta_salario.Checked && cb_nacional.Checked)
                abrir_formulario(new frm_conta_nacional("nacional", "salario"));

            else if (cb_conta_salario.Checked && cb_estrangeiro.Checked)
                abrir_formulario(new frm_conta_estrangeira("estrangeiro", "salario"));

            else if (cb_conta_salario.Checked && cb_menor.Checked)
                abrir_formulario(new frm_Menor_de_idade("menor de idade", "salario"));
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }
    }
}
