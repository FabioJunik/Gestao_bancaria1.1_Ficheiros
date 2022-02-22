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
    public partial class frm_credito : Form
    {
        //---------Objectos---------------------------

        stringManipulation txt = new stringManipulation();
        operacoes operacao = new operacoes();
        Verificacoes verificacao = new Verificacoes();

       //--------------------------------------------

        double valorJuros;
        double percentagemJuros=3;
        double valorFinalPagar;
        int valorCredito=0 ;
        int prazo=1 ;

        int index=-1;
        string nome ;

        public frm_credito()
        {
            InitializeComponent();
            
        }

        private void sld_valor_ValueChanged_1(object sender, EventArgs e)
        {
            if (sld_valor.Value < 500000 && lbl_estadoCredito.Text == "Automovel")
                sld_valor.Value = 500000;

            else if(sld_valor.Value < 10000 && lbl_estadoCredito.Text == "Salário")
                sld_valor.Value = 10000;

            else if (sld_valor.Value < 100000 && lbl_estadoCredito.Text == "Seguro")
                sld_valor.Value = 100000;

            else if (sld_valor.Value < 100000 && lbl_estadoCredito.Text == "Pessoal")
                sld_valor.Value = 100000;

            else if (sld_valor.Value < 1000000 && lbl_estadoCredito.Text == "Habitação")
                sld_valor.Value = 1000000;


            valorCredito = sld_valor.Value;
            valorJuros = valorCredito * percentagemJuros / 100;
            valorFinalPagar = valorCredito + valorJuros;

            txt_valorNecessario.Text = txt.SortNumber(sld_valor.Value.ToString());

            lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";

            lbl_valorJuros.Text = valorJuros.ToString() +" Kz";
        }

        private void slb_meses_ValueChanged(object sender, EventArgs e)
        {
            if (sld_meses.Value == 0)
                sld_meses.Value = 1;

            if(sld_meses.Value >= 1)
                lbl_meses.Text = sld_meses.Value.ToString()+" Meses";


            if (lbl_estadoCredito.Text == "Automovel")
                lbl_percentagemJuros.Text = ((sld_meses.Value - 1) * 0.1) + 3 + "";

            else if (lbl_estadoCredito.Text == "Salário" || lbl_estadoCredito.Text == "Pessoal")
                lbl_percentagemJuros.Text = ((sld_meses.Value - 1) * 0.09) + 3 + "";

            else if (lbl_estadoCredito.Text == "Seguro")
                lbl_percentagemJuros.Text = ((sld_meses.Value - 1) * 0.2) + 3 + "";

            else if (lbl_estadoCredito.Text == "Habitação")
                lbl_percentagemJuros.Text = ((sld_meses.Value - 1) * 0.05 ) +3  + "";


            percentagemJuros = double.Parse(lbl_percentagemJuros.Text);
            prazo = sld_meses.Value;
            valorJuros = valorCredito*percentagemJuros/100;
            valorFinalPagar = valorCredito + valorJuros;

            lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";
            lbl_valorJuros.Text =  valorJuros +" Kz";
        }

        private void frm_credito_Load(object sender, EventArgs e)
        {
            //sld_meses.Value = 1;
            //sld_valor.Value = 500000;
            //txt_valorNecessario.Text = "500 000";
        }

        private void btn_credito_Click(object sender, EventArgs e)
        {
            string nConta = txt_nConta.Text;

            index = operacao.ArrayPosition(DadosDoCliente.nConta, nConta);

            if (index >=0)
            {
                nome = DadosDoCliente.nome[index].ToString();

                ValidarPedido();
            }
            else
            {
                MessageBox.Show("Conta inexistente");
            }
        }

        private void txt_valorNecessario_Leave(object sender, EventArgs e)
        {

        }

        private void txt_valorNecessario_KeyPress(object sender, KeyPressEventArgs e)
        {
            operacao.ApenasNumero(e);
            try
            {
                if (e.KeyChar == 13)
                {
                    int valor = int.Parse(txt_valorNecessario.Text);

                    string tipoCredito = lbl_estadoCredito.Text;

                    if (tipoCredito == "Automovel")
                    {
                        if (valor > 100000000)
                        {
                            MessageBox.Show("O valor máximo para o credito Automóvel é de 100 000 000 Kz");
                            sld_valor.Value = 100000000;
                            txt_valorNecessario.Text = "100 000 000";
                        }

                        else if (valor >= 500000)  
                            sld_valor.Value = int.Parse(txt_valorNecessario.Text);
                        else
                            MessageBox.Show("O valor minimo para o credito Automóvel é de 500 000 Kz");
                    }

                    else if (lbl_estadoCredito.Text == "Seguro")
                    {
                        if (valor > 50000000)
                        {
                            MessageBox.Show("O valor máximo para o credito Seguro é de 50 000 000 Kz");
                            sld_valor.Value = 50000000;
                            txt_valorNecessario.Text = "50 000 000";
                        }
                        else if (valor >= 100000)
                            sld_valor.Value = int.Parse(txt_valorNecessario.Text);
                        else
                            MessageBox.Show("O valor minimo para o credito Seguro é de 100 000 Kz");
                    }

                    else if (lbl_estadoCredito.Text == "Salario")
                    {
                        if (valor > 20000000)
                        {
                            MessageBox.Show("O valor máximo para o credito Salario é de 20 000 000 Kz");
                            sld_valor.Value = 20000000;
                            txt_valorNecessario.Text = "20 000 000";
                        }

                        else if (valor >= 10000)
                            sld_valor.Value = int.Parse(txt_valorNecessario.Text);
                        else
                            MessageBox.Show("O valor minimo para o credito Salario é de 10 000 Kz");
                    }

                    else if (lbl_estadoCredito.Text == "Pessoal")
                    {
                        if (valor > 20000000)
                        {
                            MessageBox.Show("O valor máximo para o credito Pessoal é de 150 000 000 Kz");
                            sld_valor.Value = 150000000;
                            txt_valorNecessario.Text = "150 000 000";
                        }
                        else if (valor >= 100000)
                            sld_valor.Value = int.Parse(txt_valorNecessario.Text);
                        else
                            MessageBox.Show("O valor minimo para o credito Pessoal é de 100 000 Kz");
                    }
                    else if (lbl_estadoCredito.Text == "Habitação")
                    {
                        if (valor > 500000000)
                        {
                            MessageBox.Show("O valor máximo para o credito Habitação é de 500 000 000 Kz");
                            sld_valor.Value = 500000000;
                            txt_valorNecessario.Text = "500 000 000";
                        }
                        if (valor >= 1000000)
                            sld_valor.Value = int.Parse(txt_valorNecessario.Text);
                        else
                            MessageBox.Show("O valor minimo para o credito Habitação é de 1 000 000 Kz");
                    }

                    valorCredito = sld_valor.Value;

                    valorJuros = valorCredito * percentagemJuros / 100;
                    valorFinalPagar = valorCredito + valorJuros;

                    lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";
                    lbl_valorJuros.Text = valorJuros + " Kz";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ao informar o valor do credito :\nNão de espaços \nNem coloque ',' ou '.'",
                        "Messengem de erro", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void btn_credioAutomovel_Click(object sender, EventArgs e)
        {
            lbl_estadoCredito.Text = "Automovel";
            btn_credioAutomovel.Enabled = false;
            btn_creditoPessoal.Enabled = true;
            btn_creditoSalario.Enabled = true;
            btn_creditoHabitacao.Enabled = true;
            btn_creditoSeguro.Enabled = true;

            lbl_meses.Text = "1 mês";
            txt_valorNecessario.Text = "500 000";

            valorCredito = 500000;
            sld_valor.Value = valorCredito;
            sld_valor.MaximumValue = 100000000;

            sld_meses.Value = 1;
            sld_meses.MaximumValue = 48;

            valorJuros = valorCredito * percentagemJuros / 100;
            valorFinalPagar = valorCredito + valorJuros;


            lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";
            lbl_valorJuros.Text = valorJuros.ToString() + " Kz";
        }

        private void btn_creditoSeguro_Click(object sender, EventArgs e)
        {
            lbl_estadoCredito.Text = "Seguro";
            btn_credioAutomovel.Enabled = true;
            btn_creditoPessoal.Enabled = true;
            btn_creditoSalario.Enabled = true;
            btn_creditoHabitacao.Enabled = true;
            btn_creditoSeguro.Enabled = false;

            sld_valor.MaximumValue = 50000000;
            valorCredito = 100000;
            sld_valor.Value = valorCredito;

            txt_valorNecessario.Text = "100 000";
            lbl_meses.Text = "1 mês";


            sld_meses.Value = 1;
            sld_meses.MaximumValue = 12;

            valorJuros = valorCredito * percentagemJuros / 100;
            valorFinalPagar = valorCredito + valorJuros;


            lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";
            lbl_valorJuros.Text = valorJuros.ToString() + " Kz";
        }

        private void btn_creditoPessoal_Click(object sender, EventArgs e)
        {
            lbl_estadoCredito.Text = "Pessoal";
            btn_credioAutomovel.Enabled = true;
            btn_creditoPessoal.Enabled = false;
            btn_creditoSalario.Enabled = true;
            btn_creditoHabitacao.Enabled = true;
            btn_creditoSeguro.Enabled = true;

            lbl_meses.Text = "1 mês";
            txt_valorNecessario.Text = "100 000";

            valorCredito = 100000;
            sld_valor.Value = valorCredito;
            sld_valor.MaximumValue = 150000000;

            sld_meses.Value = 1;
            sld_meses.MaximumValue = 60;

            valorJuros = valorCredito * percentagemJuros / 100;
            valorFinalPagar = valorCredito + valorJuros;


            lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";
            lbl_valorJuros.Text = valorJuros.ToString() + " Kz";
        }

        private void btn_creditoSalario_Click(object sender, EventArgs e)
        {
            lbl_estadoCredito.Text = "Salário";
            btn_credioAutomovel.Enabled = true;
            btn_creditoPessoal.Enabled = true;
            btn_creditoSalario.Enabled = false;
            btn_creditoHabitacao.Enabled = true;
            btn_creditoSeguro.Enabled = true;

            valorCredito = 10000;
            sld_valor.Value = valorCredito;
            sld_valor.MaximumValue = 20000000;

            txt_valorNecessario.Text = "10 000";
            lbl_meses.Text = "1 mês";

            sld_meses.Value = 1;
            sld_meses.MaximumValue = 60;

            valorJuros = valorCredito * percentagemJuros / 100;
            valorFinalPagar = valorCredito + valorJuros;


            lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";
            lbl_valorJuros.Text = valorJuros.ToString() + " Kz";
        }

        private void btn_creditoHabitacao_Click(object sender, EventArgs e)
        {
            lbl_estadoCredito.Text = "Habitação";
            btn_credioAutomovel.Enabled = true;
            btn_creditoPessoal.Enabled = true;
            btn_creditoSalario.Enabled = true;
            btn_creditoHabitacao.Enabled = false;
            btn_creditoSeguro.Enabled = true;

            lbl_meses.Text = "1 mês";
            txt_valorNecessario.Text = "1 000 000";

            valorCredito = 1000000;
            sld_valor.Value = valorCredito;
            sld_valor.MaximumValue = 500000000;

            sld_meses.Value = 1;
            sld_meses.MaximumValue = 200;

            valorJuros = valorCredito * percentagemJuros / 100;
            valorFinalPagar = valorCredito + valorJuros;


            lbl_valorApagarPorMes.Text = txt.SortNumber((valorFinalPagar / prazo).ToString()) + " Kz";
            lbl_valorJuros.Text = valorJuros.ToString() + " Kz";
        }



        private void RealizarCredito()
        {
            StreamWriter file = new StreamWriter(@"Clientes\Dados\" + nome + ".txt", true);

            file.WriteLine("\nCredito : "+valorFinalPagar);

            file.Close();

            DadosDoCliente.credito[index] = valorFinalPagar;
        }

        private void ValidarPedido()
        {
            if (valorCredito == 0)
            {
                MessageBox.Show("Selecione o motivo do credito", "Operação interronpida", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            else if (DadosDoCliente.credito[index].ToString() != " " && DadosDoCliente.credito[index].ToString() != "0")
            {
                MessageBox.Show("Esta conta já tem um credito ativo!");
            }
            else
            {

                RealizarCredito();
                MessageBox.Show("Credito realiado com sucesso",nome);

                double saldo = double.Parse(DadosDoCliente.saldo[index].ToString());

                DadosDoCliente.saldo.RemoveAt(index);
                DadosDoCliente.saldo.Insert(index, saldo + valorCredito);

                DadosDoCliente.Extrato(nome, "Ativação de credito", valorCredito, saldo+valorCredito);


                DadosDoCliente.ActualizarFile(index);

            }
        }
    }
}
