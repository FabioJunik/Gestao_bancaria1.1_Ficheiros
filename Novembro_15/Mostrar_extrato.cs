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
    public partial class frm_Mostrar_extrato : Form
    {
        operacoes operacao = new operacoes();
        string fileName;
        public frm_Mostrar_extrato(string fileName)
        {
            InitializeComponent();

            this.fileName = fileName;
        }

        private void frm_Mostrar_extrato_Load(object sender, EventArgs e)
        {
            int index = operacao.ArrayPosition(DadosDoCliente.nome, fileName);
            lbl_nome.Text = fileName;
            lbl_nConta.Text = DadosDoCliente.nConta[index].ToString();
            lbl_saldo.Text = DadosDoCliente.saldo[index].ToString();
            lbl_credito.Text = DadosDoCliente.credito[index].ToString();

            StreamReader file = new StreamReader(@"Clientes\Extratos\" + fileName + ".txt");
            int cont = 0;
            while (!file.EndOfStream)
            {
             
                string[] linha = file.ReadLine().ToString().Split(':');
                
                if(linha.Length > 3)
                {
                    dgv_extrato.Rows.Add();
                    dgv_extrato[0, cont].Value = linha[0];
                    dgv_extrato[1, cont].Value = linha[1];
                    dgv_extrato[2, cont].Value = linha[2];
                    dgv_extrato[3, cont].Value = linha[3];
                    dgv_extrato[4, cont].Value = linha[4];

                    cont++;
                }
                
            }

            file.Close();
        }

        
    }
}
