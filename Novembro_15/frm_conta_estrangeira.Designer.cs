namespace Novembro_15
{
    partial class frm_conta_estrangeira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conta_estrangeira));
            this.label25 = new System.Windows.Forms.Label();
            this.txt_codigoPais = new System.Windows.Forms.TextBox();
            this.cbx_estadoOcupacional = new System.Windows.Forms.ComboBox();
            this.lbl_ocupacao = new System.Windows.Forms.Label();
            this.cbx_abilitacaoLiteraria = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_NIF = new System.Windows.Forms.TextBox();
            this.dp_data = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label13 = new System.Windows.Forms.Label();
            this.rb_femenino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.txt_valorInicial = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_nBI = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_NIFNacional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_criarConta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_NIFEmpresa = new System.Windows.Forms.TextBox();
            this.lbl_NIFEmpresa = new System.Windows.Forms.Label();
            this.lbl_tipoDeConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Poppins", 10F);
            this.label25.Location = new System.Drawing.Point(110, 288);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 25);
            this.label25.TabIndex = 88;
            this.label25.Text = "CÓD país";
            // 
            // txt_codigoPais
            // 
            this.txt_codigoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoPais.Location = new System.Drawing.Point(117, 310);
            this.txt_codigoPais.Name = "txt_codigoPais";
            this.txt_codigoPais.Size = new System.Drawing.Size(65, 26);
            this.txt_codigoPais.TabIndex = 87;
            // 
            // cbx_estadoOcupacional
            // 
            this.cbx_estadoOcupacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estadoOcupacional.FormattingEnabled = true;
            this.cbx_estadoOcupacional.Items.AddRange(new object[] {
            "Trabalhador por conta de Outrem",
            "Trabalhador por conta própria",
            "Estudante"});
            this.cbx_estadoOcupacional.Location = new System.Drawing.Point(559, 244);
            this.cbx_estadoOcupacional.Name = "cbx_estadoOcupacional";
            this.cbx_estadoOcupacional.Size = new System.Drawing.Size(349, 24);
            this.cbx_estadoOcupacional.TabIndex = 85;
            // 
            // lbl_ocupacao
            // 
            this.lbl_ocupacao.AutoSize = true;
            this.lbl_ocupacao.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ocupacao.Location = new System.Drawing.Point(554, 221);
            this.lbl_ocupacao.Name = "lbl_ocupacao";
            this.lbl_ocupacao.Size = new System.Drawing.Size(171, 28);
            this.lbl_ocupacao.TabIndex = 84;
            this.lbl_ocupacao.Text = "Estado ocupacional";
            // 
            // cbx_abilitacaoLiteraria
            // 
            this.cbx_abilitacaoLiteraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_abilitacaoLiteraria.FormattingEnabled = true;
            this.cbx_abilitacaoLiteraria.Items.AddRange(new object[] {
            "Ensino Primário",
            "Ensino Médio",
            "Ensino Superior"});
            this.cbx_abilitacaoLiteraria.Location = new System.Drawing.Point(559, 307);
            this.cbx_abilitacaoLiteraria.Name = "cbx_abilitacaoLiteraria";
            this.cbx_abilitacaoLiteraria.Size = new System.Drawing.Size(184, 28);
            this.cbx_abilitacaoLiteraria.TabIndex = 83;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(554, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 28);
            this.label16.TabIndex = 82;
            this.label16.Text = "Abilitação literária";
            // 
            // txt_NIF
            // 
            this.txt_NIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIF.Location = new System.Drawing.Point(559, 75);
            this.txt_NIF.Name = "txt_NIF";
            this.txt_NIF.Size = new System.Drawing.Size(349, 26);
            this.txt_NIF.TabIndex = 81;
            // 
            // dp_data
            // 
            this.dp_data.BackColor = System.Drawing.Color.White;
            this.dp_data.BorderRadius = 0;
            this.dp_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_data.ForeColor = System.Drawing.Color.Black;
            this.dp_data.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dp_data.FormatCustom = null;
            this.dp_data.Location = new System.Drawing.Point(114, 243);
            this.dp_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dp_data.Name = "dp_data";
            this.dp_data.Size = new System.Drawing.Size(229, 25);
            this.dp_data.TabIndex = 80;
            this.dp_data.Value = new System.DateTime(2021, 11, 12, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(381, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 28);
            this.label13.TabIndex = 79;
            this.label13.Text = "Sexo";
            // 
            // rb_femenino
            // 
            this.rb_femenino.AutoSize = true;
            this.rb_femenino.Checked = true;
            this.rb_femenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_femenino.Location = new System.Drawing.Point(384, 240);
            this.rb_femenino.Name = "rb_femenino";
            this.rb_femenino.Size = new System.Drawing.Size(81, 20);
            this.rb_femenino.TabIndex = 78;
            this.rb_femenino.TabStop = true;
            this.rb_femenino.Text = "Feminino";
            this.rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_masculino.Location = new System.Drawing.Point(384, 262);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(87, 20);
            this.rb_masculino.TabIndex = 77;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // txt_valorInicial
            // 
            this.txt_valorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorInicial.Location = new System.Drawing.Point(749, 307);
            this.txt_valorInicial.Name = "txt_valorInicial";
            this.txt_valorInicial.Size = new System.Drawing.Size(159, 26);
            this.txt_valorInicial.TabIndex = 76;
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(559, 186);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(349, 26);
            this.txt_mail.TabIndex = 74;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(198, 310);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(145, 26);
            this.txt_telefone.TabIndex = 73;
            // 
            // txt_nBI
            // 
            this.txt_nBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nBI.Location = new System.Drawing.Point(115, 164);
            this.txt_nBI.Name = "txt_nBI";
            this.txt_nBI.Size = new System.Drawing.Size(349, 26);
            this.txt_nBI.TabIndex = 72;
            this.txt_nBI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nBI_KeyPress);
            this.txt_nBI.Leave += new System.EventHandler(this.txt_nBI_Leave);
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(114, 108);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(349, 26);
            this.txt_nome.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(747, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 28);
            this.label15.TabIndex = 70;
            this.label15.Text = "Valor de entrada";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(556, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(554, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 28);
            this.label18.TabIndex = 68;
            this.label18.Text = "Correio electrónico";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(554, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 28);
            this.label19.TabIndex = 67;
            this.label19.Text = "NIF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(193, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 28);
            this.label14.TabIndex = 66;
            this.label14.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(109, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 28);
            this.label12.TabIndex = 65;
            this.label12.Text = "Data de nascimento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(110, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 28);
            this.label11.TabIndex = 64;
            this.label11.Text = "Nº BI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 28);
            this.label10.TabIndex = 63;
            this.label10.Text = "Nome completo";
            // 
            // txt_NIFNacional
            // 
            this.txt_NIFNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIFNacional.Location = new System.Drawing.Point(559, 133);
            this.txt_NIFNacional.Name = "txt_NIFNacional";
            this.txt_NIFNacional.Size = new System.Drawing.Size(349, 26);
            this.txt_NIFNacional.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 89;
            this.label1.Text = "NIF Nacional";
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
            this.btn_criarConta.Location = new System.Drawing.Point(386, 384);
            this.btn_criarConta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_criarConta.Name = "btn_criarConta";
            this.btn_criarConta.Size = new System.Drawing.Size(148, 51);
            this.btn_criarConta.TabIndex = 91;
            this.btn_criarConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_criarConta.Click += new System.EventHandler(this.btn_criarConta_Click);
            // 
            // txt_NIFEmpresa
            // 
            this.txt_NIFEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIFEmpresa.Location = new System.Drawing.Point(559, 243);
            this.txt_NIFEmpresa.Name = "txt_NIFEmpresa";
            this.txt_NIFEmpresa.Size = new System.Drawing.Size(349, 26);
            this.txt_NIFEmpresa.TabIndex = 116;
            this.txt_NIFEmpresa.Visible = false;
            // 
            // lbl_NIFEmpresa
            // 
            this.lbl_NIFEmpresa.AutoSize = true;
            this.lbl_NIFEmpresa.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NIFEmpresa.Location = new System.Drawing.Point(554, 219);
            this.lbl_NIFEmpresa.Name = "lbl_NIFEmpresa";
            this.lbl_NIFEmpresa.Size = new System.Drawing.Size(137, 28);
            this.lbl_NIFEmpresa.TabIndex = 115;
            this.lbl_NIFEmpresa.Text = "NIF da empresa";
            this.lbl_NIFEmpresa.Visible = false;
            // 
            // lbl_tipoDeConta
            // 
            this.lbl_tipoDeConta.AutoSize = true;
            this.lbl_tipoDeConta.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoDeConta.Location = new System.Drawing.Point(110, 17);
            this.lbl_tipoDeConta.Name = "lbl_tipoDeConta";
            this.lbl_tipoDeConta.Size = new System.Drawing.Size(394, 42);
            this.lbl_tipoDeConta.TabIndex = 117;
            this.lbl_tipoDeConta.Text = "Formulário de criação de conta";
            // 
            // frm_conta_estrangeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 463);
            this.Controls.Add(this.lbl_tipoDeConta);
            this.Controls.Add(this.txt_NIFEmpresa);
            this.Controls.Add(this.lbl_NIFEmpresa);
            this.Controls.Add(this.btn_criarConta);
            this.Controls.Add(this.txt_NIFNacional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codigoPais);
            this.Controls.Add(this.cbx_estadoOcupacional);
            this.Controls.Add(this.lbl_ocupacao);
            this.Controls.Add(this.cbx_abilitacaoLiteraria);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_NIF);
            this.Controls.Add(this.dp_data);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rb_femenino);
            this.Controls.Add(this.rb_masculino);
            this.Controls.Add(this.txt_valorInicial);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_nBI);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label25);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_conta_estrangeira";
            this.Text = "frm_conta_estrangeira";
            this.Load += new System.EventHandler(this.frm_conta_estrangeira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_codigoPais;
        private System.Windows.Forms.ComboBox cbx_estadoOcupacional;
        private System.Windows.Forms.Label lbl_ocupacao;
        private System.Windows.Forms.ComboBox cbx_abilitacaoLiteraria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_NIF;
        private Bunifu.Framework.UI.BunifuDatepicker dp_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rb_femenino;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.TextBox txt_valorInicial;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_nBI;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_NIFNacional;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_criarConta;
        private System.Windows.Forms.TextBox txt_NIFEmpresa;
        private System.Windows.Forms.Label lbl_NIFEmpresa;
        private System.Windows.Forms.Label lbl_tipoDeConta;
    }
}