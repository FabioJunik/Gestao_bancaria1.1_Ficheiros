using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Novembro_15
{
    public partial class Form1 : Form
    {

        formManipulation manipulacao = new formManipulation();

       
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_normalizar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_maximizar.Visible = true;
            btn_normalizar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DadosDoCliente.ReadFile();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
         [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);

         private void Barra_de_titulo_Paint(object sender, PaintEventArgs e)
         {
              
         }

         private void Barra_de_titulo_MouseDown(object sender, MouseEventArgs e)
         {
             ReleaseCapture();
             SendMessage(this.Handle,0x112,0xf012,0);
         }

         private void pictureBox8_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            manipulacao.OpenForm(new frm_poupancas(), controlador);
        }

        private void btn_conta_Click(object sender, EventArgs e)
        {
            manipulacao.OpenForm(new frm_conta(), controlador);
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            manipulacao.OpenForm(new inicio(controlador), controlador);
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            if(SubMenu.Visible)
                SubMenu.Visible = false;
            else
                SubMenu.Visible = true;
        }

        private void btn_movimento_Click(object sender, EventArgs e)
        {
            manipulacao.OpenForm(new frm_transacoes(), controlador);

        }

        private void btn_credito_Click(object sender, EventArgs e)
        {
            manipulacao.OpenForm(new frm_credito(), controlador);
        }

        private void btn_pagamento_Click(object sender, EventArgs e)
        {
            manipulacao.OpenForm(new frm_pagamentos(), controlador);
        }
    }
}
