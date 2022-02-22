namespace Novembro_15
{
    partial class frm_conta_nacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conta_nacional));
            this.lbl_tipoDeConta = new System.Windows.Forms.Label();
            this.btn_criarConta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_codigoPais = new System.Windows.Forms.TextBox();
            this.dp_data = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label13 = new System.Windows.Forms.Label();
            this.rb_femenino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_nBI = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_estadoOcupacional = new System.Windows.Forms.ComboBox();
            this.lb_ocupacao = new System.Windows.Forms.Label();
            this.cbx_abilitacaoLiteraria = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_NIF = new System.Windows.Forms.TextBox();
            this.txt_valorInicial = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_NIFEmpresa = new System.Windows.Forms.TextBox();
            this.lbl_NIFEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tipoDeConta
            // 
            this.lbl_tipoDeConta.AutoSize = true;
            this.lbl_tipoDeConta.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDeConta.Location = new System.Drawing.Point(79, 24);
            this.lbl_tipoDeConta.Name = "lbl_tipoDeConta";
            this.lbl_tipoDeConta.Size = new System.Drawing.Size(394, 42);
            this.lbl_tipoDeConta.TabIndex = 49;
            this.lbl_tipoDeConta.Text = "Formulário de criação de conta";
            // 
            // btn_criarConta
            // 
            this.btn_criarConta.ActiveBorderThickness = 1;
            this.btn_criarConta.ActiveCornerRadius = 1;
            this.btn_criarConta.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_criarConta.ActiveForecolor = System.Drawing.Color.White;
            this.btn_criarConta.ActiveLineColor = System.Drawing.Color.White;
            this.btn_criarConta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_criarConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_criarConta.BackgroundImage")));
            this.btn_criarConta.ButtonText = "Criar conta";
            this.btn_criarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_criarConta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criarConta.ForeColor = System.Drawing.Color.Black;
            this.btn_criarConta.IdleBorderThickness = 1;
            this.btn_criarConta.IdleCornerRadius = 1;
            this.btn_criarConta.IdleFillColor = System.Drawing.Color.White;
            this.btn_criarConta.IdleForecolor = System.Drawing.Color.Black;
            this.btn_criarConta.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_criarConta.Location = new System.Drawing.Point(384, 346);
            this.btn_criarConta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_criarConta.Name = "btn_criarConta";
            this.btn_criarConta.Size = new System.Drawing.Size(148, 51);
            this.btn_criarConta.TabIndex = 63;
            this.btn_criarConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_criarConta.Click += new System.EventHandler(this.btn_criarConta_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(81, 276);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 26);
            this.label25.TabIndex = 101;
            this.label25.Text = "CÓD país";
            // 
            // txt_codigoPais
            // 
            this.txt_codigoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoPais.Location = new System.Drawing.Point(86, 303);
            this.txt_codigoPais.Name = "txt_codigoPais";
            this.txt_codigoPais.Size = new System.Drawing.Size(69, 26);
            this.txt_codigoPais.TabIndex = 100;
            // 
            // dp_data
            // 
            this.dp_data.BackColor = System.Drawing.Color.White;
            this.dp_data.BorderRadius = 0;
            this.dp_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_data.ForeColor = System.Drawing.Color.Black;
            this.dp_data.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dp_data.FormatCustom = null;
            this.dp_data.Location = new System.Drawing.Point(86, 239);
            this.dp_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dp_data.Name = "dp_data";
            this.dp_data.Size = new System.Drawing.Size(229, 25);
            this.dp_data.TabIndex = 99;
            this.dp_data.Value = new System.DateTime(2021, 11, 12, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(342, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 28);
            this.label13.TabIndex = 98;
            this.label13.Text = "Sexo";
            // 
            // rb_femenino
            // 
            this.rb_femenino.AutoSize = true;
            this.rb_femenino.Checked = true;
            this.rb_femenino.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_femenino.Location = new System.Drawing.Point(347, 234);
            this.rb_femenino.Name = "rb_femenino";
            this.rb_femenino.Size = new System.Drawing.Size(100, 30);
            this.rb_femenino.TabIndex = 97;
            this.rb_femenino.TabStop = true;
            this.rb_femenino.Text = "Feminino";
            this.rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_masculino.Location = new System.Drawing.Point(347, 262);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(108, 30);
            this.rb_masculino.TabIndex = 96;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(170, 303);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(145, 26);
            this.txt_telefone.TabIndex = 95;
            // 
            // txt_nBI
            // 
            this.txt_nBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nBI.Location = new System.Drawing.Point(86, 167);
            this.txt_nBI.Name = "txt_nBI";
            this.txt_nBI.Size = new System.Drawing.Size(349, 26);
            this.txt_nBI.TabIndex = 94;
            this.txt_nBI.TextChanged += new System.EventHandler(this.txt_nBI_TextChanged);
            this.txt_nBI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nBI_KeyPress);
            this.txt_nBI.Leave += new System.EventHandler(this.txt_nBI_Leave);
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(86, 111);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(349, 26);
            this.txt_nome.TabIndex = 93;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(171, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 28);
            this.label14.TabIndex = 92;
            this.label14.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 28);
            this.label12.TabIndex = 91;
            this.label12.Text = "Data de nascimento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 28);
            this.label11.TabIndex = 90;
            this.label11.Text = "Nº BI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 28);
            this.label10.TabIndex = 89;
            this.label10.Text = "Nome completo";
            // 
            // cbx_estadoOcupacional
            // 
            this.cbx_estadoOcupacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estadoOcupacional.FormattingEnabled = true;
            this.cbx_estadoOcupacional.Items.AddRange(new object[] {
            "Trabalhador por conta de Outrem",
            "Trabalhador por conta própria",
            "Estudante"});
            this.cbx_estadoOcupacional.Location = new System.Drawing.Point(554, 232);
            this.cbx_estadoOcupacional.Name = "cbx_estadoOcupacional";
            this.cbx_estadoOcupacional.Size = new System.Drawing.Size(349, 28);
            this.cbx_estadoOcupacional.TabIndex = 112;
            // 
            // lb_ocupacao
            // 
            this.lb_ocupacao.AutoSize = true;
            this.lb_ocupacao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ocupacao.Location = new System.Drawing.Point(552, 205);
            this.lb_ocupacao.Name = "lb_ocupacao";
            this.lb_ocupacao.Size = new System.Drawing.Size(171, 28);
            this.lb_ocupacao.TabIndex = 111;
            this.lb_ocupacao.Text = "Estado ocupacional";
            // 
            // cbx_abilitacaoLiteraria
            // 
            this.cbx_abilitacaoLiteraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_abilitacaoLiteraria.FormattingEnabled = true;
            this.cbx_abilitacaoLiteraria.Items.AddRange(new object[] {
            "Ensino Primário",
            "Ensino Médio",
            "Ensino Superior"});
            this.cbx_abilitacaoLiteraria.Location = new System.Drawing.Point(554, 294);
            this.cbx_abilitacaoLiteraria.Name = "cbx_abilitacaoLiteraria";
            this.cbx_abilitacaoLiteraria.Size = new System.Drawing.Size(184, 24);
            this.cbx_abilitacaoLiteraria.TabIndex = 110;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(549, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 28);
            this.label16.TabIndex = 109;
            this.label16.Text = "Abilitação literária";
            // 
            // txt_NIF
            // 
            this.txt_NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIF.Location = new System.Drawing.Point(554, 106);
            this.txt_NIF.Name = "txt_NIF";
            this.txt_NIF.Size = new System.Drawing.Size(349, 26);
            this.txt_NIF.TabIndex = 108;
            this.txt_NIF.Leave += new System.EventHandler(this.txt_NIF_Leave);
            // 
            // txt_valorInicial
            // 
            this.txt_valorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorInicial.Location = new System.Drawing.Point(746, 294);
            this.txt_valorInicial.Name = "txt_valorInicial";
            this.txt_valorInicial.Size = new System.Drawing.Size(159, 26);
            this.txt_valorInicial.TabIndex = 107;
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(554, 167);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(349, 26);
            this.txt_mail.TabIndex = 106;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(741, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 28);
            this.label15.TabIndex = 105;
            this.label15.Text = "Valor de entrada";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(551, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(550, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 28);
            this.label18.TabIndex = 103;
            this.label18.Text = "Correio electrónico";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(550, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 28);
            this.label19.TabIndex = 102;
            this.label19.Text = "NIF";
            // 
            // txt_NIFEmpresa
            // 
            this.txt_NIFEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIFEmpresa.Location = new System.Drawing.Point(554, 233);
            this.txt_NIFEmpresa.Name = "txt_NIFEmpresa";
            this.txt_NIFEmpresa.Size = new System.Drawing.Size(349, 26);
            this.txt_NIFEmpresa.TabIndex = 114;
            this.txt_NIFEmpresa.Visible = false;
            // 
            // lbl_NIFEmpresa
            // 
            this.lbl_NIFEmpresa.AutoSize = true;
            this.lbl_NIFEmpresa.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NIFEmpresa.Location = new System.Drawing.Point(552, 203);
            this.lbl_NIFEmpresa.Name = "lbl_NIFEmpresa";
            this.lbl_NIFEmpresa.Size = new System.Drawing.Size(137, 28);
            this.lbl_NIFEmpresa.TabIndex = 113;
            this.lbl_NIFEmpresa.Text = "NIF da empresa";
            this.lbl_NIFEmpresa.Visible = false;
            // 
            // frm_conta_nacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 432);
            this.Controls.Add(this.txt_NIFEmpresa);
            this.Controls.Add(this.lbl_NIFEmpresa);
            this.Controls.Add(this.cbx_estadoOcupacional);
            this.Controls.Add(this.lb_ocupacao);
            this.Controls.Add(this.cbx_abilitacaoLiteraria);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_NIF);
            this.Controls.Add(this.txt_valorInicial);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txt_codigoPais);
            this.Controls.Add(this.dp_data);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rb_femenino);
            this.Controls.Add(this.rb_masculino);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_nBI);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_criarConta);
            this.Controls.Add(this.lbl_tipoDeConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_conta_nacional";
            this.Text = "frm_conta_nacional";
            this.Load += new System.EventHandler(this.frm_conta_nacional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_tipoDeConta;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_criarConta;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_codigoPais;
        private Bunifu.Framework.UI.BunifuDatepicker dp_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rb_femenino;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_nBI;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_estadoOcupacional;
        private System.Windows.Forms.Label lb_ocupacao;
        private System.Windows.Forms.ComboBox cbx_abilitacaoLiteraria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_NIF;
        private System.Windows.Forms.TextBox txt_valorInicial;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_NIFEmpresa;
        private System.Windows.Forms.Label lbl_NIFEmpresa;
    }
}