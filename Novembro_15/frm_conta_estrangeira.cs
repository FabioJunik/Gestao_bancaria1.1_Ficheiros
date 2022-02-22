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
    public partial class frm_conta_estrangeira : Form
    {
        //-------- Objectos-----------------

        operacoes operacao = new operacoes();
        Verificacoes verificacao = new Verificacoes();
        stringManipulation texto = new stringManipulation();

       //-----------------------------------
        string cidadaoChecked;
        string contaChecked;

        //-----------------------------------

        //----Declaração dos Campos do formulario--------

        string BI;
        string nome;
        string codPais;
        string telefone;
        string NIF;
        string NIFNacional;
        string NIFEmpresa;
        string IBAN;
        string nConta;
        string dataNascimento;
        string senha;
        string sexo;
        string e_mail;
        string saldo;
        string ocupacao;
        string abilitacao_literaria;

        //-----------------------------------

        public frm_conta_estrangeira(string cidadaoChecked, string contaChecked)
        {
            InitializeComponent();
            this.cidadaoChecked = cidadaoChecked;
            this.contaChecked = contaChecked;
        }

        private void frm_conta_estrangeira_Load(object sender, EventArgs e)
        {
            lbl_tipoDeConta.Text = "Conta Estrangeiro / À Ordem";

            if (contaChecked == "salario")
            {
                lbl_NIFEmpresa.Visible = true;
                txt_NIFEmpresa.Visible = true;

                lbl_ocupacao.Visible = false;
                cbx_estadoOcupacional.Visible = false;

                lbl_tipoDeConta.Text = "Conta Estrangeiro / Salário";

            }
        }

        private void btn_criarConta_Click(object sender, EventArgs e)
        {
            LerCampos();
            ValidarCadastro();
        }

        public void LerCampos()
        {
            BI = txt_nBI.Text;
            NIF = txt_NIF.Text;
            NIFNacional = txt_NIFNacional.Text;
            nome = txt_nome.Text;
            e_mail = txt_mail.Text;
            saldo = txt_valorInicial.Text;
            codPais = txt_codigoPais.Text.Trim();
            telefone = txt_telefone.Text;

            dataNascimento = dp_data.Value.ToString().Split(' ')[0];

            abilitacao_literaria = cbx_abilitacaoLiteraria.Text;

            nConta = operacao.GerarNConta();
            IBAN = operacao.GerarIBAM(nConta);
            senha = operacao.GerarSenha();

            if (rb_femenino.Checked)
                sexo = "Femenino";
            else
                sexo = "Masculino";

            if (contaChecked == "ordem")
            {
                ocupacao = cbx_estadoOcupacional.Text;
                txt_NIFEmpresa.Text = " ";
            }

            else if (contaChecked == "salario")
            {
                NIFEmpresa = txt_NIFEmpresa.Text;
                ocupacao = "Trabalhador";
            }

        }

        private void CreateFile()
        {
            if (!Directory.Exists(@"Clientes\Dados"))
                Directory.CreateDirectory(@"Clientes\Dados");

            StreamWriter file = new StreamWriter(@"Clientes\Dados\" + nome + ".txt", true);

            file.WriteLine("Nome : " + texto.OrganizarNome(nome));
            file.WriteLine("BI : " + BI);
            file.WriteLine("Data de nascimento : " + dataNascimento);
            file.WriteLine("Telefone : " + telefone);
            file.WriteLine("Sexo : " + sexo);
            file.WriteLine("Senha : " + senha);

            file.WriteLine("NIF : " + NIF);
            file.WriteLine("NIF Nacinonal : " + NIFNacional);

            if (contaChecked == "salario")
            {
                file.WriteLine("NIF da empresa : " + NIFEmpresa);
            }

            file.WriteLine("Número de conta : " + nConta);
            file.WriteLine("IBAN : " + IBAN);
            file.WriteLine("Coreio electronico : " + e_mail);
            file.WriteLine("Abilitação literária : " + abilitacao_literaria);
            file.WriteLine("Estado ocupacional : " + ocupacao);
            file.WriteLine("Saldo : " + saldo);

            file.WriteLine("Tipo de conta : " + contaChecked);
            file.WriteLine("Cidadão : Estrangeiro");

            file.Close();
        }

        public void ValidarCadastro()
        {
            if (verificacao.AlgumVazio(this.Controls))
            {
                MessageBox.Show("CADASTRO INTERRONPIDO\nPreencha todos os campos!", "Mensaguem de erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BI.Trim() != NIF.Trim())
            {
                MessageBox.Show("NIF invalido!", "Mensaguem de erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(saldo) < 5000)
            {
                MessageBox.Show("O valor de entrada tem que ser igual ou superior a 5000", "Valor de entrada",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_valorInicial.Focus();
            }
            
            else if ( (codPais == "+244" || codPais=="244") && !verificacao.IsPhoneNumberAO(telefone))
            {
                MessageBox.Show("Número de telefone invalido!");
                txt_telefone.Text = "";
                txt_telefone.Focus();
            }
            else if (!verificacao.NomeValido(txt_nome.Text))
            {
                MessageBox.Show("NOME INVALIDO!\nPor favor verifique se o seu nome esta bem escrito");
            }
            else
            {
                CreateFile();
                MessageBox.Show("Cadastro feito com sucesso\n Agora podes dispor dos nossos serviços"
                            ,"OPERAÇÃO EFECTUADA",MessageBoxButtons.OK, MessageBoxIcon.Information);

                operacao.LimparTextBox(Controls);
            }
        }

        private void txt_nBI_KeyPress(object sender, KeyPressEventArgs e)
        {
            //operacao.BI_KeyPress(txt_nBI.Text,e);
        }

        private void txt_nBI_Leave(object sender, EventArgs e)
        {
            txt_nBI.Text = txt_nBI.Text.ToUpper();
        }
    }
   
}
