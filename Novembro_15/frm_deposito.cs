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
    public partial class frm_deposito : Form
    {
        //--------Objectos---------

        operacoes operacao = new operacoes();
        Verificacoes verificacao = new Verificacoes();
        
        //-------------------------

        public frm_deposito()
        {
            InitializeComponent();
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            if(txt_nConta.Text=="" || txt_valor.Text=="")
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
                    double saldo = double.Parse(DadosDoCliente.saldo[index].ToString());
                    double deposito = double.Parse(txt_valor.Text);

                    if (deposito <= 0)
                        MessageBox.Show("Valor invalido");
                    else
                    {
                        var resposta = DialogResult;

                        resposta = MessageBox.Show("O deposito esta sendo feito para : " + nome + "\nSaldo : " + saldo
                                         + "\nDeseja fazer o deposito ?", "Conta em questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resposta == DialogResult.Yes)
                        {
                            double novoSaldo = saldo + deposito;

                            DadosDoCliente.Extrato(nome, "Deposito", deposito, novoSaldo);

                            string credito = DadosDoCliente.credito[index].ToString();

                            if (credito != " " && credito != "0")
                            {
                                MessageBox.Show("Não esqueça que 50% ou menos serve para liquidar o credito", nome,
                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                double saida;

                                if (deposito / 2 > double.Parse(credito))
                                    saida = double.Parse(credito);
                                else
                                    saida = deposito / 2;

                                
                                DadosDoCliente.credito[index] = double.Parse(credito)-saida;

                                novoSaldo = novoSaldo - saida;

                                DadosDoCliente.Extrato(nome, "Apagamento parcial do credito", -saida, novoSaldo);
                            }

                            DadosDoCliente.saldo[index] = novoSaldo;

                            DadosDoCliente.ActualizarFile(index);

                            MessageBox.Show("Deposito feito com sucesso!\nSaldo Actual: " + DadosDoCliente.saldo[index]
                                            , nome);
                        }
                        else if (resposta == DialogResult.No)
                            MessageBox.Show("Operação cancelada");

                        txt_nConta.Text = "";
                        txt_valor.Text = "";
                    }
                }

                else
                {
                    MessageBox.Show("A conta inexistente", "ERRO DE OPERAÇÃO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            operacao.ApenasNumero(e);
        }
    }
}
