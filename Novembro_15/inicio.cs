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
    public partial class inicio : Form
    {
        formManipulation manipulacao = new formManipulation();
        operacoes operacao = new operacoes();

        Panel mainPanel;


        bool pesquisa_Clicked = false;

        public inicio(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            DadosDoCliente.ReadFile();

            dgv_lista.Rows.Add(DadosDoCliente.nome.Count - 1);

            for (int i = 0; i < DadosDoCliente.nome.Count; i++)
            {

                dgv_lista[0, i].Value = DadosDoCliente.nome[i];
                dgv_lista[1, i].Value = DadosDoCliente.nConta[i];
                dgv_lista[2, i].Value = DadosDoCliente.IBAN[i];
                dgv_lista[3, i].Value = DadosDoCliente.NIF[i];
                dgv_lista[4, i].Value = DadosDoCliente.saldo[i];
                

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string ficheiro = dgv_lista.CurrentCell.Value.ToString().Trim();

            if(!File.Exists(@"Clientes\Dados\" + ficheiro + ".txt"))
            {
                MessageBox.Show("Selecione apenas o nome para exibir o extrato!");
                return;
            }
            if (!File.Exists(@"Clientes\Extratos\" + ficheiro + ".txt"))
            {
                MessageBox.Show("Esta conta ainda não fez nenhum movimeno!");
                return;
            }

            manipulacao.OpenForm(new frm_Mostrar_extrato(ficheiro), mainPanel);
        }

        private void btn_eliminarConta_Click(object sender, EventArgs e)
        {
            try
            {
                string ficheiro = dgv_lista.CurrentCell.Value.ToString().Trim();

                if (operacao.ArrayPosition(DadosDoCliente.nome, ficheiro) >= 0)
                {

                    var resposta = DialogResult;
                    resposta = MessageBox.Show("A eliminar a conta de : " + ficheiro +
                                      "\n Desaja continuar a operação? ", "Transferência"
                                       , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resposta == DialogResult.No)
                        MessageBox.Show("Operação cancelada");

                    else if (resposta == DialogResult.Yes)
                    {
                        dgv_lista.Rows.RemoveAt(dgv_lista.CurrentCell.RowIndex);

                        File.Delete(@"Clientes\Dados\" + ficheiro + ".txt");
                        MessageBox.Show(ficheiro);
                        MessageBox.Show("A conta foi eliminada com sucesso");
                    }
                }
                else
                {
                    MessageBox.Show("Operação invalida\nSelecione o nome para eliminar", "ERRO DE OPERAÇÃO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception b)
            {
                MessageBox.Show("Operação invalida\nSelecione o nome para eliminar", "ERRO DE OPERAÇÃO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    


        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dgv_lista.Rows.Clear();
            string nome = txt_pesquisa.Text.ToLower().Trim();

            int k = 0;
            for (int i = 0; i < DadosDoCliente.nome.Count; i++)
            {
                
                string Dnome = DadosDoCliente.nome[i].ToString().ToLower();
                for (int j = 0; j < Dnome.Length; j++)
                {
                    if (Dnome.Substring(0, j) == nome)
                    {
                        dgv_lista.Rows.Add();
                        dgv_lista[0, k].Value = DadosDoCliente.nome[i];
                        dgv_lista[1, k].Value = DadosDoCliente.nConta[i];
                        dgv_lista[2, k].Value = DadosDoCliente.IBAN[i];
                        dgv_lista[3, k].Value = DadosDoCliente.NIF[i];
                        dgv_lista[4, k].Value = DadosDoCliente.saldo[i];
                        k++;
                    }
                }
            }


        }

        private void txt_pesquisa_Click(object sender, EventArgs e)
        {
            if (!pesquisa_Clicked)
                txt_pesquisa.Text = "";

            pesquisa_Clicked = true;
        }

        private void txt_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                btn_pesquisar_Click(btn_pesquisar, e);
        }

        private void btn_mostrarConta_Click(object sender, EventArgs e)
        {
            string ficheiro = dgv_lista.CurrentCell.Value.ToString().Trim();

            if (!File.Exists(@"Clientes\Dados\" + ficheiro + ".txt"))
            {
                MessageBox.Show("Selecione o nome para continuar!");
                return;
            }

            manipulacao.OpenForm(new frm_dadosDoCliente(ficheiro), mainPanel);
        }
    }
}
