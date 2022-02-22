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
    public partial class frm_telefonia : Form
    {
        //-----------Objectos------------

        operacoes operacao = new operacoes();
        Verificacoes verificacao = new Verificacoes();

        //-------------------------------


        string nConta;
        string telefone;
        int valor;
        string operadora;

        public frm_telefonia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            LerCampos();
            ValidarCampos();
        }

        private void LerCampos()
        {
            telefone = txt_nTelefone.Text;
            valor = int.Parse(txt_valorRecarga.Text);
            operadora = cb_operadora.Text;
            nConta = txt_nConta.Text.Trim();
        }

        private void ValidarCampos()
        {
            if (verificacao.AlgumVazio(Controls))
            {
                MessageBox.Show("Recarga interronpida\nPreencha todos os campos!", "Mensaguem de erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (operadora.ToLower() =="movicel" && !verificacao.IsMovicelNumber(telefone))
            {
                    MessageBox.Show("Número de telefone invalido\nEste número não pertence a Movicel!", "Mensaguem de erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nTelefone.Text = "";
                    txt_nTelefone.Focus();
            }
            else if (operadora.ToLower() == "unitel" && !verificacao.IsUnitelNumber(telefone))
            {
                    MessageBox.Show("Número de telefone invalido\nEste número não pertence a Unitel!", "Mensaguem de erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nTelefone.Text = "";
                    txt_nTelefone.Focus();
            }
            else if (valor <= 0)
            {
                MessageBox.Show("Valor da recarga invalido!", "Mensaguem de erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int index = operacao.ArrayPosition(DadosDoCliente.nConta, nConta);

                if (index >= 0)
                {
                    string nome = DadosDoCliente.nome[index].ToString();
                    int saldo = int.Parse(DadosDoCliente.saldo[index].ToString());

                    if (valor <= 0)
                        MessageBox.Show("Valor invalido");
                    else
                    {
                        var resposta = DialogResult;

                        resposta = MessageBox.Show("Conta em questão: " + nome + "\nSaldo : " + saldo
                                         + "\nDeseja fazer a recarga ?", "Conta em questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resposta == DialogResult.Yes)
                        {
                            int novoSaldo = saldo - valor;

                            DadosDoCliente.saldo.RemoveAt(index);
                            DadosDoCliente.saldo.Insert(index, novoSaldo);

                            DadosDoCliente.ActualizarFile(index);

                            DadosDoCliente.Extrato(nome,"Recarga telefonica "+operadora, valor*(-1), novoSaldo);

                            MessageBox.Show("Recarga feita com sucesso!\nSaldo Actual: " + DadosDoCliente.saldo[index]
                                            , nome);
                        }
                        else if (resposta == DialogResult.No)
                            MessageBox.Show("Operação cancelada");

                        txt_nConta.Text = "";
                        txt_valorRecarga.Text = "";
                    }
                }

                else
                {
                    MessageBox.Show("A conta inexistente", "ERRO DE OPERAÇÃO",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
