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
    public partial class frm_transferencia : Form
    {
        //--------Objectos---------

        operacoes operacao = new operacoes();
        Verificacoes verificacao = new Verificacoes();

        //-------------------------

        //------------------------------

        bool contaOrigem_Clicked = false;
        bool contaDestino_Clicked = false;
        bool valor_Clicked = false;

        //------------------------------
        public frm_transferencia()
        {
            InitializeComponent();
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            if (verificacao.AlgumVazio(Controls) || (!contaDestino_Clicked || !contaOrigem_Clicked || !valor_Clicked))
            {
                MessageBox.Show("Preencha todos os campos\nPara efectuar a operação", "ERRO DE OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string nConta = txt_contaOrigem.Text.Trim();
                int indexOrigem = operacao.ArrayPosition(DadosDoCliente.nConta, nConta);

                string IBAN = ("AO06" + txt_contaDestino.Text).ToString().Trim();
                int indexDestino = operacao.ArrayPosition(DadosDoCliente.IBAN, IBAN);

                MessageBox.Show(indexOrigem.ToString());
                if (indexOrigem >= 0)
                {
                    string nomeOrigem = DadosDoCliente.nome[indexOrigem].ToString();

                    int valor = int.Parse(txt_valor.Text);
                    int saldoOrigem = int.Parse(DadosDoCliente.saldo[indexOrigem].ToString());

                    if (saldoOrigem >= valor)
                    {
                        if (indexDestino >= 0)
                        {
                            string nomeDestino = DadosDoCliente.nome[indexDestino].ToString();
                            var resposta = DialogResult;
                            resposta = MessageBox.Show("Transferencia sera feita" +
                                "                       \n\nDe : " + nomeOrigem +
                                                       "\n\nPara : "+nomeDestino+
                                                       "\n\nValor da transferencia:" + valor,  "Transferência"
                                               , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resposta == DialogResult.No)
                                MessageBox.Show("Operação cancelada");
                            if (resposta == DialogResult.Yes)
                            {
                                int saldoDestino = int.Parse(DadosDoCliente.saldo[indexDestino].ToString());

                                DadosDoCliente.saldo.RemoveAt(indexOrigem);
                                DadosDoCliente.saldo.Insert(indexOrigem, saldoOrigem - valor);

                                DadosDoCliente.saldo.RemoveAt(indexDestino);
                                DadosDoCliente.saldo.Insert(indexDestino, valor + saldoDestino);

                                DadosDoCliente.ActualizarFile(indexOrigem);
                                DadosDoCliente.ActualizarFile(indexDestino);

                                DadosDoCliente.Extrato(nomeOrigem, "Transferência bancaria", valor * (-1), saldoOrigem - valor);
                                DadosDoCliente.Extrato(nomeDestino, "Transferência bancaria", valor, saldoDestino + valor);


                                MessageBox.Show("Tranferencia feita com sucesso");

                                operacao.LimparTextBox(Controls);
                                textBox1.Text = "AO06";
                            }
                        }
                        else
                        {
                            var resposta = DialogResult;

                            resposta = MessageBox.Show("Transferencia sendo feita para uma conta disconhecida",
                                            "Transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (resposta == DialogResult.No)
                                MessageBox.Show("Operação cancelada");

                            if (resposta == DialogResult.Yes)
                            {
                                DadosDoCliente.saldo.RemoveAt(indexOrigem);
                                DadosDoCliente.saldo.Insert(indexOrigem, valor + saldoOrigem);
                                DadosDoCliente.ActualizarFile(indexOrigem);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Seu saldo actual é menor que o valor de transferencia!" +
                                        "\nCota: "+nomeOrigem+"\nSaldo: "+saldoOrigem);
                }
                else
                    MessageBox.Show("Conta inexistente\nCastre primeiro para poder fazer a transferencia!");
            }
        }

        private void txt_contaOrigem_Click(object sender, EventArgs e)
        {

            if(!contaOrigem_Clicked)
                txt_contaOrigem.Text = "";

            contaOrigem_Clicked = true;
        }

        private void txt_contaDestino_Click(object sender, EventArgs e)
        {
            if(!contaDestino_Clicked)
                txt_contaDestino.Text = "";

            contaDestino_Clicked = true;
        }

        private void txt_valor_Click(object sender, EventArgs e)
        {
            if(!valor_Clicked)
                txt_valor.Text = "";

            valor_Clicked = true;
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            operacao.ApenasNumero(e);
        }
    }
}
