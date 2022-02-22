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
    public partial class frm_saque : Form
    {
        //--------Objectos---------
 
        operacoes operacao = new operacoes();
        Verificacoes verificacao = new Verificacoes();

        //-------------------------

        public frm_saque()
        {
            InitializeComponent();
        }

        private void btn_saquar_Click(object sender, EventArgs e)
        {
            if (txt_nConta.Text == "" || txt_valor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos\nPara efectuar a operação", "ERRO DE OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nConta = txt_nConta.Text.Trim();

                int index = operacao.ArrayPosition(DadosDoCliente.nConta, nConta);
                if (index >= 0)
                {
                    string nome = DadosDoCliente.nome[index].ToString();
                    int saldo = int.Parse(DadosDoCliente.saldo[index].ToString());
                    int saque = int.Parse(txt_valor.Text);

                    if (saque <= 0)
                        MessageBox.Show("Valor invalido");

                    else if(saque > saldo)
                    {
                        MessageBox.Show("Operação cancelado\nValor do saque não pode ser superior ou saldo",
                                         "ERRO DE OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var resposta = DialogResult;

                        resposta = MessageBox.Show("O saque esta sendo feito para : " + nome + "\nSaldo : " + saldo
                                         + "\nDeseja fazer o saque ?", "Conta em questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resposta == DialogResult.Yes)
                        {
                            int novoSaldo = saldo - saque;

                            DadosDoCliente.saldo.RemoveAt(index);
                            DadosDoCliente.saldo.Insert(index, novoSaldo);

                            DadosDoCliente.ActualizarFile(index);
                            DadosDoCliente.Extrato(nome, "Saque", saque*(-1), novoSaldo);

                            MessageBox.Show("Saque feito com sucesso!\nSaldo Actual: " + DadosDoCliente.saldo[index]
                                            , nome);
                        }
                        else if (resposta == DialogResult.No)
                            MessageBox.Show("Operação cancelada");

                        txt_nConta.Text = "";
                        txt_valor.Text = "";
                    }
                }
            }


        }


    }
}
    

