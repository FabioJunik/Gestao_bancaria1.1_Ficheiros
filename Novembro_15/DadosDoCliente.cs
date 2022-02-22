using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;


namespace Novembro_15
{
    class DadosDoCliente
    {
        public static ArrayList nome = new ArrayList();
        public static ArrayList BI = new ArrayList();
        public static ArrayList BIRepresentante = new ArrayList();
        public static ArrayList NIF = new ArrayList();
        public static ArrayList NIFNacional = new ArrayList();
        public static ArrayList NIFEmpresa = new ArrayList();
        public static ArrayList NIFRepresentante = new ArrayList();
        public static ArrayList sexo = new ArrayList();
        public static ArrayList senha = new ArrayList();
        public static ArrayList IBAN = new ArrayList();
        public static ArrayList saldo = new ArrayList();
        public static ArrayList nConta = new ArrayList();
        public static ArrayList E_mail = new ArrayList();
        public static ArrayList telefone = new ArrayList();
        public static ArrayList dataNascimento = new ArrayList();
        public static ArrayList ocupacao = new ArrayList();
        public static ArrayList abilitacao_literaria = new ArrayList();
        public static ArrayList tipoConta = new ArrayList();
        public static ArrayList tipoCidadao = new ArrayList();
        public static ArrayList credito = new ArrayList();

        public static void ReadFile()
        {
            ZerarArrayList();

            string[] fileDirectory = Directory.GetFiles(@"Clientes\Dados", "*.txt");

            for (int i = 0; i < fileDirectory.Length; i++)
            {
                StreamReader file = new StreamReader(fileDirectory[i]);

                while (!file.EndOfStream)
                {

                    string[] linha = file.ReadLine().Split(':');

                    if (linha.Length > 1)
                    {

                        string descricao = linha[0].ToLower().Trim();
                        string dado = linha[1].Trim();

                        /*Inserção dos dados na ArrayList*/
                        {
                            if (descricao == "nome")
                                nome.Add(dado);

                            if (descricao == "bi")
                                BI.Add(dado);

                            if (descricao == "bi do representante")
                                BIRepresentante.Add(dado);
                            else
                                BIRepresentante.Add(" ");

                            if (descricao == "data de nascimento")
                                dataNascimento.Add(dado);

                            if (descricao == "número de conta")
                                nConta.Add(dado);

                            if (descricao == "iban")
                                IBAN.Add(dado);

                            if (descricao == "saldo")
                                saldo.Add(dado);

                            if (descricao == "nif")
                                NIF.Add(dado);

                            if (descricao == "telefone")
                                telefone.Add(dado);

                            if (descricao == "coreio electronico")
                                E_mail.Add(dado);

                            if (descricao == "sexo")
                                sexo.Add(dado);

                            if (descricao == "senha")
                                senha.Add(dado);

                            if (descricao == "abilitação literária")
                                abilitacao_literaria.Add(dado);

                            if (descricao == "estado ocupacional")
                                ocupacao.Add(dado);

                            if (descricao == "tipo de conta")
                                tipoConta.Add(dado);

                            if (descricao == "cidadão")
                                tipoCidadao.Add(dado);

                            if (descricao == "nif da empresa")
                                NIFEmpresa.Add(dado);
                            else if (file.EndOfStream)
                                NIFEmpresa.Add(" ");

                            if (descricao == "nif nacional")
                                NIFNacional.Add(dado);

                            else if (file.EndOfStream)
                                NIFNacional.Add(" ");

                            if (descricao == "nif do representante")
                                NIFRepresentante.Add(dado);

                            else if (file.EndOfStream)
                                NIFRepresentante.Add(" ");

                            if (descricao == "credito")
                            {
                                credito.Add(dado);
                            }
                            else if (file.EndOfStream)
                                credito.Add(" ");

                        }
                    }
                }

                file.Close();
            }
        }

        public static void ActualizarFile(int index)
        {

            string _nome = nome[index].ToString().Trim();
            string _conta = tipoConta[index].ToString();
            string _cidadao = tipoCidadao[index].ToString();
            string _credito = credito[index].ToString();

            File.Delete(@"Clientes\Dados\" +_nome+ ".txt");
            StreamWriter file = new StreamWriter(@"Clientes\Dados\" +_nome+ ".txt", true);


            file.WriteLine("Nome : " + nome[index]);
            file.WriteLine("BI : " + BI[index]);
            file.WriteLine("Número de conta : " + nConta[index]);
            file.WriteLine("IBAN : " + IBAN[index]);
            file.WriteLine("Coreio electronico : " + E_mail[index]);
            file.WriteLine("Abilitação literária : " + abilitacao_literaria[index]);
            file.WriteLine("Saldo : " + saldo[index]);

            file.WriteLine("Data de nascimento : " + dataNascimento[index]);
            file.WriteLine("Telefone : " + telefone[index]);
            file.WriteLine("Sexo : " + sexo[index]);
            file.WriteLine("Senha : " + senha[index]);

            file.WriteLine("NIF : " + NIF[index]);


            if (_conta == "salario")
            {
                file.WriteLine("NIF da empresa : " + NIFEmpresa[index]);
            }

            if (_cidadao == "menor")
            {
                file.WriteLine("BI do representante: " + BIRepresentante[index]);
                file.WriteLine("NIF do representante : " + NIFRepresentante[index]);
                file.WriteLine("Cidadão : Menor de idade");
            }
            else if (_cidadao == "estrangiro")
            {
                file.WriteLine("NIF Nacinonal : " + NIFNacional[index]);
                file.WriteLine("Cidadão : Estrangeiro");
            }
            else
                file.WriteLine("Cidadão : Nacional");

            file.WriteLine("Tipo de conta : " + _conta);
            
            if(_credito != " " || _credito == "0")
            {
                file.WriteLine("Credito : " + _credito);
            }

            file.Close();

        }

        public static void Extrato(string nomeFicheiro, string descricao, double valorMovido, double saldoActual)
        {
            StreamWriter file = new StreamWriter(@"Clientes\Extratos\" + nomeFicheiro + ".txt",true);
            
            if(valorMovido < 0)
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy")+" : "+descricao+" :  : "+valorMovido*(-1)+" : "+saldoActual);

            else
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy") + " : " + descricao + " : " + valorMovido + " :  : " + saldoActual);

            file.Close();
        }

        public static void ZerarArrayList()
        {
            nome.Clear();
            BI.Clear();
            NIF.Clear();
            sexo.Clear();
            IBAN.Clear();
            saldo.Clear();
            nConta.Clear();
            E_mail.Clear();
            telefone.Clear();
            dataNascimento.Clear();
            ocupacao.Clear();
            abilitacao_literaria.Clear();
            senha.Clear();
            credito.Clear();
        }

    }
}
