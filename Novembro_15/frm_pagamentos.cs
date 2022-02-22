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
    public partial class frm_pagamentos : Form
    {
        //---------Objectos--------------

        formManipulation formManipulation = new formManipulation();

        //-------------------------------
        public frm_pagamentos()
        {
            InitializeComponent();
        }

        private void btn_telefonia_Click(object sender, EventArgs e)
        {
            formManipulation.OpenForm(new frm_telefonia(), mainPanel);
        }

        private void btn_televisao_Click(object sender, EventArgs e)
        {
            formManipulation.OpenForm(new frm_televisao(), mainPanel);
        }
    }
}
