namespace Novembro_15
{
    partial class frm_conta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_menor = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cb_nacional = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_estrangeiro = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_conta_salario = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_conta_ordem = new Bunifu.Framework.UI.BunifuCheckbox();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panel_conta = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_conta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 27);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 27);
            this.panel2.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.cb_menor);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.cb_nacional);
            this.panel5.Controls.Add(this.cb_estrangeiro);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cb_conta_salario);
            this.panel5.Controls.Add(this.cb_conta_ordem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(977, 202);
            this.panel5.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(539, 178);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 21);
            this.label24.TabIndex = 24;
            this.label24.Text = "Menor de idade";
            // 
            // cb_menor
            // 
            this.cb_menor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_menor.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_menor.Checked = false;
            this.cb_menor.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_menor.ForeColor = System.Drawing.Color.White;
            this.cb_menor.Location = new System.Drawing.Point(515, 180);
            this.cb_menor.Name = "cb_menor";
            this.cb_menor.Size = new System.Drawing.Size(20, 20);
            this.cb_menor.TabIndex = 23;
            this.cb_menor.OnChange += new System.EventHandler(this.cb_menor_OnChange);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(307, 180);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 21);
            this.label22.TabIndex = 22;
            this.label22.Text = "Cidadão estrangeiro";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(89, 181);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 21);
            this.label23.TabIndex = 21;
            this.label23.Text = "Cidadão nacional";
            // 
            // cb_nacional
            // 
            this.cb_nacional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_nacional.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_nacional.Checked = false;
            this.cb_nacional.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_nacional.ForeColor = System.Drawing.Color.White;
            this.cb_nacional.Location = new System.Drawing.Point(65, 182);
            this.cb_nacional.Name = "cb_nacional";
            this.cb_nacional.Size = new System.Drawing.Size(20, 20);
            this.cb_nacional.TabIndex = 20;
            this.cb_nacional.OnChange += new System.EventHandler(this.cb_nacional_OnChange);
            // 
            // cb_estrangeiro
            // 
            this.cb_estrangeiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_estrangeiro.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_estrangeiro.Checked = false;
            this.cb_estrangeiro.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_estrangeiro.ForeColor = System.Drawing.Color.White;
            this.cb_estrangeiro.Location = new System.Drawing.Point(285, 182);
            this.cb_estrangeiro.Name = "cb_estrangeiro";
            this.cb_estrangeiro.Size = new System.Drawing.Size(20, 20);
            this.cb_estrangeiro.TabIndex = 19;
            this.cb_estrangeiro.OnChange += new System.EventHandler(this.cb_estrangeiro_OnChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo de cidadão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Conta à ordem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Conta Salário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16F);
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de conta";
            // 
            // cb_conta_salario
            // 
            this.cb_conta_salario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_conta_salario.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_conta_salario.Checked = false;
            this.cb_conta_salario.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_conta_salario.ForeColor = System.Drawing.Color.White;
            this.cb_conta_salario.Location = new System.Drawing.Point(295, 63);
            this.cb_conta_salario.Name = "cb_conta_salario";
            this.cb_conta_salario.Size = new System.Drawing.Size(20, 20);
            this.cb_conta_salario.TabIndex = 11;
            this.cb_conta_salario.OnChange += new System.EventHandler(this.cb_conta_salario_OnChange);
            // 
            // cb_conta_ordem
            // 
            this.cb_conta_ordem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_conta_ordem.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_conta_ordem.Checked = false;
            this.cb_conta_ordem.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_conta_ordem.ForeColor = System.Drawing.Color.White;
            this.cb_conta_ordem.Location = new System.Drawing.Point(70, 63);
            this.cb_conta_ordem.Name = "cb_conta_ordem";
            this.cb_conta_ordem.Size = new System.Drawing.Size(20, 20);
            this.cb_conta_ordem.TabIndex = 9;
            this.cb_conta_ordem.OnChange += new System.EventHandler(this.cb_conta_ordem_OnChange);
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(1405, 553);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 26;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panel_conta
            // 
            this.panel_conta.BackColor = System.Drawing.SystemColors.Control;
            this.panel_conta.Controls.Add(this.doubleBitmapControl1);
            this.panel_conta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_conta.Location = new System.Drawing.Point(0, 199);
            this.panel_conta.Name = "panel_conta";
            this.panel_conta.Size = new System.Drawing.Size(977, 471);
            this.panel_conta.TabIndex = 11;
            // 
            // frm_conta
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(977, 670);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel_conta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_conta";
            this.Load += new System.EventHandler(this.FormTrans_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_conta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox cb_conta_salario;
        private Bunifu.Framework.UI.BunifuCheckbox cb_conta_ordem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuCheckbox cb_nacional;
        private Bunifu.Framework.UI.BunifuCheckbox cb_estrangeiro;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuCheckbox cb_menor;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panel_conta;

    }
}