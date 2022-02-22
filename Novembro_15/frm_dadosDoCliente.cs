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
    public partial class frm_dadosDoCliente : Form
    {
        //-------------Objectos---------------------

        operacoes operacao = new operacoes();
        Verificacoes verificacao = new Verificacoes();

        //_---------------------------------------------

        int index;
        string fileName;

        public frm_dadosDoCliente(string fileName)
        {
            InitializeComponent();

            this.fileName = fileName;
        }

        private void frm_dadosDoCliente_Load(object sender, EventArgs e)
        {
            index = operacao.ArrayPosition(DadosDoCliente.nome, fileName);

            lbl_nome.Text = DadosDoCliente.nome[index].ToString();

            txt_nome.Text = DadosDoCliente.nome[index].ToString();
            txt_sexo.Text = DadosDoCliente.sexo[index].ToString();
            txt_nBI.Text = DadosDoCliente.BI[index].ToString();
            txt_nascimento.Text = DadosDoCliente.dataNascimento[index].ToString();
            txt_telefone.Text = DadosDoCliente.telefone[index].ToString();
            txt_NIF.Text = DadosDoCliente.NIF[index].ToString();
            txt_nConta.Text = DadosDoCliente.nConta[index].ToString();
            txt_IBAN.Text= DadosDoCliente.IBAN[index].ToString();
            txt_email.Text = DadosDoCliente.E_mail[index].ToString();
            txt_abilitacaoLiterario.Text = DadosDoCliente.abilitacao_literaria[index].ToString();
            txt_saldo.Text = DadosDoCliente.saldo[index].ToString();
            txt_senha.Text = DadosDoCliente.senha[index].ToString();
            txt_tipoCidadao.Text = DadosDoCliente.tipoCidadao[index].ToString();
            txt_tipoConta.Text = DadosDoCliente.tipoConta[index].ToString();


        }

        private void btn_editarConta_Click(object sender, EventArgs e)
        {
            txt_telefone.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_abilitacaoLiterario.ReadOnly = false;
            txt_senha.ReadOnly = false;

            txt_telefone.BackColor = Color.White;
            txt_email.BackColor = Color.White;
            txt_abilitacaoLiterario.BackColor = Color.White;
            txt_senha.BackColor = Color.White;
        }

        private void btn_salvarAlteracao_Click(object sender, EventArgs e)
        {
            DadosDoCliente.E_mail[index] = txt_email.Text;
            DadosDoCliente.telefone[index] = txt_telefone;
            DadosDoCliente.abilitacao_literaria[index] = txt_abilitacaoLiterario;
            DadosDoCliente.senha[index] = txt_senha;

            DadosDoCliente.ActualizarFile(index);

            MessageBox.Show("Dados salvos com sucesso", "Operação efectuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
