namespace Novembro_15
{
    partial class frm_poupancas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_poupancas));
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_montanteMinino = new System.Windows.Forms.Label();
            this.btn_contaJovem = new System.Windows.Forms.Button();
            this.lbl_prazo = new System.Windows.Forms.Label();
            this.btn_rendimento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_depositoPrazo = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nConta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sld_meses = new Bunifu.Framework.UI.BunifuSlider();
            this.lbl_meses = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valorNecessario = new System.Windows.Forms.TextBox();
            this.sld_valor = new Bunifu.Framework.UI.BunifuSlider();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_descricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(553, 107);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(409, 76);
            this.lbl_descricao.TabIndex = 18;
            this.lbl_descricao.Text = "Um depósito a prazo em que o cliente faz uma aplicação não mobilizável por certo " +
    "tempo, tendo como contrapartida o rendimento de juros.";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_titulo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(548, 64);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(176, 34);
            this.lbl_titulo.TabIndex = 17;
            this.lbl_titulo.Text = "Depósito a prazo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lbl_montanteMinino);
            this.panel1.Controls.Add(this.btn_contaJovem);
            this.panel1.Controls.Add(this.lbl_prazo);
            this.panel1.Controls.Add(this.btn_rendimento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_depositoPrazo);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_descricao);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 379);
            this.panel1.TabIndex = 19;
            // 
            // lbl_montanteMinino
            // 
            this.lbl_montanteMinino.AutoSize = true;
            this.lbl_montanteMinino.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_montanteMinino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montanteMinino.Location = new System.Drawing.Point(556, 222);
            this.lbl_montanteMinino.Name = "lbl_montanteMinino";
            this.lbl_montanteMinino.Size = new System.Drawing.Size(69, 16);
            this.lbl_montanteMinino.TabIndex = 25;
            this.lbl_montanteMinino.Text = "250.000 kz";
            // 
            // btn_contaJovem
            // 
            this.btn_contaJovem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_contaJovem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contaJovem.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contaJovem.ForeColor = System.Drawing.Color.White;
            this.btn_contaJovem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contaJovem.Location = new System.Drawing.Point(142, 249);
            this.btn_contaJovem.Name = "btn_contaJovem";
            this.btn_contaJovem.Size = new System.Drawing.Size(345, 58);
            this.btn_contaJovem.TabIndex = 20;
            this.btn_contaJovem.Text = "Conta jovem";
            this.btn_contaJovem.UseVisualStyleBackColor = false;
            this.btn_contaJovem.Click += new System.EventHandler(this.btn_contaJovem_Click);
            // 
            // lbl_prazo
            // 
            this.lbl_prazo.AutoSize = true;
            this.lbl_prazo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_prazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prazo.Location = new System.Drawing.Point(551, 289);
            this.lbl_prazo.Name = "lbl_prazo";
            this.lbl_prazo.Size = new System.Drawing.Size(126, 16);
            this.lbl_prazo.TabIndex = 24;
            this.lbl_prazo.Text = "1, 2, 3, 6 e 12 meses";
            // 
            // btn_rendimento
            // 
            this.btn_rendimento.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_rendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rendimento.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rendimento.ForeColor = System.Drawing.Color.White;
            this.btn_rendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rendimento.Location = new System.Drawing.Point(142, 181);
            this.btn_rendimento.Name = "btn_rendimento";
            this.btn_rendimento.Size = new System.Drawing.Size(345, 57);
            this.btn_rendimento.TabIndex = 19;
            this.btn_rendimento.Text = "Rendimento crescente";
            this.btn_rendimento.UseVisualStyleBackColor = false;
            this.btn_rendimento.Click += new System.EventHandler(this.btn_rendimento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 34);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prazo:";
            // 
            // btn_depositoPrazo
            // 
            this.btn_depositoPrazo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_depositoPrazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_depositoPrazo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depositoPrazo.ForeColor = System.Drawing.Color.White;
            this.btn_depositoPrazo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depositoPrazo.Location = new System.Drawing.Point(143, 116);
            this.btn_depositoPrazo.Name = "btn_depositoPrazo";
            this.btn_depositoPrazo.Size = new System.Drawing.Size(345, 57);
            this.btn_depositoPrazo.TabIndex = 18;
            this.btn_depositoPrazo.Text = "Depósito a prazo";
            this.btn_depositoPrazo.UseVisualStyleBackColor = false;
            this.btn_depositoPrazo.Click += new System.EventHandler(this.btn_depositoPrazo_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.Window;
            this.lbl.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(553, 189);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(189, 34);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "Montante minimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Defina o tipo de poupança";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 28);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nº de conta";
            // 
            // txt_nConta
            // 
            this.txt_nConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nConta.Location = new System.Drawing.Point(139, 433);
            this.txt_nConta.Name = "txt_nConta";
            this.txt_nConta.Size = new System.Drawing.Size(270, 26);
            this.txt_nConta.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 544);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 28);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tempo";
            // 
            // sld_meses
            // 
            this.sld_meses.BackColor = System.Drawing.Color.Transparent;
            this.sld_meses.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sld_meses.BorderRadius = 0;
            this.sld_meses.IndicatorColor = System.Drawing.Color.LightSteelBlue;
            this.sld_meses.Location = new System.Drawing.Point(139, 574);
            this.sld_meses.MaximumValue = 12;
            this.sld_meses.Name = "sld_meses";
            this.sld_meses.Size = new System.Drawing.Size(793, 30);
            this.sld_meses.TabIndex = 32;
            this.sld_meses.Value = 1;
            this.sld_meses.ValueChanged += new System.EventHandler(this.sld_meses_ValueChanged);
            // 
            // lbl_meses
            // 
            this.lbl_meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meses.Location = new System.Drawing.Point(819, 555);
            this.lbl_meses.Name = "lbl_meses";
            this.lbl_meses.Size = new System.Drawing.Size(117, 16);
            this.lbl_meses.TabIndex = 33;
            this.lbl_meses.Text = "1 mês";
            this.lbl_meses.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Ativar poupança";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(115, 633);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(163, 47);
            this.bunifuThinButton21.TabIndex = 34;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(902, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "Kz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_valorNecessario
            // 
            this.txt_valorNecessario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_valorNecessario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorNecessario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorNecessario.Location = new System.Drawing.Point(723, 473);
            this.txt_valorNecessario.Name = "txt_valorNecessario";
            this.txt_valorNecessario.Size = new System.Drawing.Size(175, 19);
            this.txt_valorNecessario.TabIndex = 56;
            this.txt_valorNecessario.Text = "0";
            this.txt_valorNecessario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sld_valor
            // 
            this.sld_valor.BackColor = System.Drawing.Color.Transparent;
            this.sld_valor.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sld_valor.BorderRadius = 0;
            this.sld_valor.IndicatorColor = System.Drawing.Color.LightSteelBlue;
            this.sld_valor.Location = new System.Drawing.Point(139, 499);
            this.sld_valor.MaximumValue = 20000000;
            this.sld_valor.Name = "sld_valor";
            this.sld_valor.Size = new System.Drawing.Size(792, 30);
            this.sld_valor.TabIndex = 55;
            this.sld_valor.Value = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 54;
            this.label5.Text = "Quanto precisa?";
            // 
            // frm_poupancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 669);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valorNecessario);
            this.Controls.Add(this.sld_valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.lbl_meses);
            this.Controls.Add(this.sld_meses);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_nConta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_poupancas";
            this.Text = "poupancas";
            this.Load += new System.EventHandler(this.frm_poupancas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_contaJovem;
        private System.Windows.Forms.Button btn_rendimento;
        private System.Windows.Forms.Button btn_depositoPrazo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_prazo;
        private System.Windows.Forms.Label lbl_montanteMinino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nConta;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuSlider sld_meses;
        private System.Windows.Forms.Label lbl_meses;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valorNecessario;
        private Bunifu.Framework.UI.BunifuSlider sld_valor;
        private System.Windows.Forms.Label label5;
    }
}