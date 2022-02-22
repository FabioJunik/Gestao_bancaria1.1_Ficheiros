namespace Novembro_15
{
    partial class frm_credito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_credito));
            this.btn_creditoSeguro = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_creditoHabitacao = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_creditoSalario = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_creditoPessoal = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_credioAutomovel = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sld_valor = new Bunifu.Framework.UI.BunifuSlider();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_meses = new System.Windows.Forms.Label();
            this.sld_meses = new Bunifu.Framework.UI.BunifuSlider();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_valorApagarPorMes = new System.Windows.Forms.Label();
            this.btn_creditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_estadoCredito = new System.Windows.Forms.Label();
            this.txt_valorNecessario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_percentagemJuros = new System.Windows.Forms.Label();
            this.lbl_valorJuros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_nConta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // btn_creditoSeguro
            // 
            this.btn_creditoSeguro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoSeguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_creditoSeguro.color = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoSeguro.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_creditoSeguro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creditoSeguro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditoSeguro.ForeColor = System.Drawing.Color.White;
            this.btn_creditoSeguro.Image = ((System.Drawing.Image)(resources.GetObject("btn_creditoSeguro.Image")));
            this.btn_creditoSeguro.ImagePosition = 10;
            this.btn_creditoSeguro.ImageZoom = 50;
            this.btn_creditoSeguro.LabelPosition = 41;
            this.btn_creditoSeguro.LabelText = "Seguro";
            this.btn_creditoSeguro.Location = new System.Drawing.Point(338, 111);
            this.btn_creditoSeguro.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_creditoSeguro.Name = "btn_creditoSeguro";
            this.btn_creditoSeguro.Size = new System.Drawing.Size(128, 129);
            this.btn_creditoSeguro.TabIndex = 39;
            this.btn_creditoSeguro.Click += new System.EventHandler(this.btn_creditoSeguro_Click);
            // 
            // btn_creditoHabitacao
            // 
            this.btn_creditoHabitacao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoHabitacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_creditoHabitacao.color = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoHabitacao.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_creditoHabitacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creditoHabitacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditoHabitacao.ForeColor = System.Drawing.Color.White;
            this.btn_creditoHabitacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_creditoHabitacao.Image")));
            this.btn_creditoHabitacao.ImagePosition = 10;
            this.btn_creditoHabitacao.ImageZoom = 50;
            this.btn_creditoHabitacao.LabelPosition = 41;
            this.btn_creditoHabitacao.LabelText = "Habitação";
            this.btn_creditoHabitacao.Location = new System.Drawing.Point(756, 111);
            this.btn_creditoHabitacao.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_creditoHabitacao.Name = "btn_creditoHabitacao";
            this.btn_creditoHabitacao.Size = new System.Drawing.Size(128, 129);
            this.btn_creditoHabitacao.TabIndex = 38;
            this.btn_creditoHabitacao.Click += new System.EventHandler(this.btn_creditoHabitacao_Click);
            // 
            // btn_creditoSalario
            // 
            this.btn_creditoSalario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_creditoSalario.color = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoSalario.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_creditoSalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creditoSalario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditoSalario.ForeColor = System.Drawing.Color.White;
            this.btn_creditoSalario.Image = ((System.Drawing.Image)(resources.GetObject("btn_creditoSalario.Image")));
            this.btn_creditoSalario.ImagePosition = 10;
            this.btn_creditoSalario.ImageZoom = 50;
            this.btn_creditoSalario.LabelPosition = 41;
            this.btn_creditoSalario.LabelText = "Salário";
            this.btn_creditoSalario.Location = new System.Drawing.Point(617, 111);
            this.btn_creditoSalario.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_creditoSalario.Name = "btn_creditoSalario";
            this.btn_creditoSalario.Size = new System.Drawing.Size(128, 129);
            this.btn_creditoSalario.TabIndex = 37;
            this.btn_creditoSalario.Click += new System.EventHandler(this.btn_creditoSalario_Click);
            // 
            // btn_creditoPessoal
            // 
            this.btn_creditoPessoal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoPessoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_creditoPessoal.color = System.Drawing.Color.DarkSlateGray;
            this.btn_creditoPessoal.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_creditoPessoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creditoPessoal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditoPessoal.ForeColor = System.Drawing.Color.White;
            this.btn_creditoPessoal.Image = ((System.Drawing.Image)(resources.GetObject("btn_creditoPessoal.Image")));
            this.btn_creditoPessoal.ImagePosition = 10;
            this.btn_creditoPessoal.ImageZoom = 50;
            this.btn_creditoPessoal.LabelPosition = 41;
            this.btn_creditoPessoal.LabelText = "Pessoal";
            this.btn_creditoPessoal.Location = new System.Drawing.Point(478, 111);
            this.btn_creditoPessoal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_creditoPessoal.Name = "btn_creditoPessoal";
            this.btn_creditoPessoal.Size = new System.Drawing.Size(128, 129);
            this.btn_creditoPessoal.TabIndex = 36;
            this.btn_creditoPessoal.Click += new System.EventHandler(this.btn_creditoPessoal_Click);
            // 
            // btn_credioAutomovel
            // 
            this.btn_credioAutomovel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_credioAutomovel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_credioAutomovel.color = System.Drawing.Color.DarkSlateGray;
            this.btn_credioAutomovel.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_credioAutomovel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credioAutomovel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_credioAutomovel.ForeColor = System.Drawing.Color.White;
            this.btn_credioAutomovel.Image = ((System.Drawing.Image)(resources.GetObject("btn_credioAutomovel.Image")));
            this.btn_credioAutomovel.ImagePosition = 10;
            this.btn_credioAutomovel.ImageZoom = 50;
            this.btn_credioAutomovel.LabelPosition = 41;
            this.btn_credioAutomovel.LabelText = "Automovel";
            this.btn_credioAutomovel.Location = new System.Drawing.Point(190, 111);
            this.btn_credioAutomovel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_credioAutomovel.Name = "btn_credioAutomovel";
            this.btn_credioAutomovel.Size = new System.Drawing.Size(128, 129);
            this.btn_credioAutomovel.TabIndex = 35;
            this.btn_credioAutomovel.Click += new System.EventHandler(this.btn_credioAutomovel_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Poppins", 20.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(183, 57);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(433, 48);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Qual é a finalidade do crédito?";
            // 
            // sld_valor
            // 
            this.sld_valor.BackColor = System.Drawing.Color.Transparent;
            this.sld_valor.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sld_valor.BorderRadius = 0;
            this.sld_valor.IndicatorColor = System.Drawing.Color.LightSteelBlue;
            this.sld_valor.Location = new System.Drawing.Point(189, 331);
            this.sld_valor.MaximumValue = 20000000;
            this.sld_valor.Name = "sld_valor";
            this.sld_valor.Size = new System.Drawing.Size(685, 30);
            this.sld_valor.TabIndex = 42;
            this.sld_valor.Value = 1;
            this.sld_valor.ValueChanged += new System.EventHandler(this.sld_valor_ValueChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(184, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 28);
            this.label11.TabIndex = 41;
            this.label11.Text = "Quanto precisa?";
            // 
            // lbl_meses
            // 
            this.lbl_meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meses.Location = new System.Drawing.Point(693, 377);
            this.lbl_meses.Name = "lbl_meses";
            this.lbl_meses.Size = new System.Drawing.Size(179, 22);
            this.lbl_meses.TabIndex = 46;
            this.lbl_meses.Text = "1 mês";
            this.lbl_meses.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sld_meses
            // 
            this.sld_meses.BackColor = System.Drawing.Color.Transparent;
            this.sld_meses.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sld_meses.BorderRadius = 0;
            this.sld_meses.IndicatorColor = System.Drawing.Color.LightSteelBlue;
            this.sld_meses.Location = new System.Drawing.Point(190, 409);
            this.sld_meses.MaximumValue = 48;
            this.sld_meses.Name = "sld_meses";
            this.sld_meses.Size = new System.Drawing.Size(685, 30);
            this.sld_meses.TabIndex = 45;
            this.sld_meses.Value = 1;
            this.sld_meses.ValueChanged += new System.EventHandler(this.slb_meses_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Com que prazo?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Valor a pagar por mês";
            // 
            // lbl_valorApagarPorMes
            // 
            this.lbl_valorApagarPorMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorApagarPorMes.Location = new System.Drawing.Point(696, 495);
            this.lbl_valorApagarPorMes.Name = "lbl_valorApagarPorMes";
            this.lbl_valorApagarPorMes.Size = new System.Drawing.Size(179, 22);
            this.lbl_valorApagarPorMes.TabIndex = 49;
            this.lbl_valorApagarPorMes.Text = "0 Kz";
            this.lbl_valorApagarPorMes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_creditar
            // 
            this.btn_creditar.ActiveBorderThickness = 1;
            this.btn_creditar.ActiveCornerRadius = 1;
            this.btn_creditar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_creditar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_creditar.ActiveLineColor = System.Drawing.Color.White;
            this.btn_creditar.BackColor = System.Drawing.Color.White;
            this.btn_creditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_creditar.BackgroundImage")));
            this.btn_creditar.ButtonText = "Assinar contrato";
            this.btn_creditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditar.ForeColor = System.Drawing.Color.Black;
            this.btn_creditar.IdleBorderThickness = 1;
            this.btn_creditar.IdleCornerRadius = 1;
            this.btn_creditar.IdleFillColor = System.Drawing.Color.White;
            this.btn_creditar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_creditar.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_creditar.Location = new System.Drawing.Point(189, 611);
            this.btn_creditar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_creditar.Name = "btn_creditar";
            this.btn_creditar.Size = new System.Drawing.Size(163, 47);
            this.btn_creditar.TabIndex = 50;
            this.btn_creditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_creditar.Click += new System.EventHandler(this.btn_credito_Click);
            // 
            // lbl_estadoCredito
            // 
            this.lbl_estadoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estadoCredito.AutoSize = true;
            this.lbl_estadoCredito.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoCredito.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_estadoCredito.Location = new System.Drawing.Point(504, 239);
            this.lbl_estadoCredito.Name = "lbl_estadoCredito";
            this.lbl_estadoCredito.Size = new System.Drawing.Size(126, 42);
            this.lbl_estadoCredito.TabIndex = 51;
            this.lbl_estadoCredito.Text = "______";
            // 
            // txt_valorNecessario
            // 
            this.txt_valorNecessario.BackColor = System.Drawing.Color.White;
            this.txt_valorNecessario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorNecessario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorNecessario.Location = new System.Drawing.Point(662, 305);
            this.txt_valorNecessario.Name = "txt_valorNecessario";
            this.txt_valorNecessario.Size = new System.Drawing.Size(175, 19);
            this.txt_valorNecessario.TabIndex = 52;
            this.txt_valorNecessario.Text = "0";
            this.txt_valorNecessario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valorNecessario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valorNecessario_KeyPress);
            this.txt_valorNecessario.Leave += new System.EventHandler(this.txt_valorNecessario_Leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(841, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Kz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 22);
            this.label5.TabIndex = 61;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_percentagemJuros
            // 
            this.lbl_percentagemJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percentagemJuros.Location = new System.Drawing.Point(278, 454);
            this.lbl_percentagemJuros.Name = "lbl_percentagemJuros";
            this.lbl_percentagemJuros.Size = new System.Drawing.Size(75, 22);
            this.lbl_percentagemJuros.TabIndex = 60;
            this.lbl_percentagemJuros.Text = "3";
            this.lbl_percentagemJuros.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_valorJuros
            // 
            this.lbl_valorJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorJuros.Location = new System.Drawing.Point(696, 452);
            this.lbl_valorJuros.Name = "lbl_valorJuros";
            this.lbl_valorJuros.Size = new System.Drawing.Size(179, 22);
            this.lbl_valorJuros.TabIndex = 59;
            this.lbl_valorJuros.Text = "0 Kz";
            this.lbl_valorJuros.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 58;
            this.label6.Text = "Juros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 63;
            this.label3.Text = "Conta em questão";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 5;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(945, 1459);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(436, 89);
            this.bunifuMaterialTextbox1.TabIndex = 65;
            this.bunifuMaterialTextbox1.Text = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_nConta
            // 
            this.txt_nConta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nConta.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nConta.HintForeColor = System.Drawing.Color.Empty;
            this.txt_nConta.HintText = "";
            this.txt_nConta.isPassword = false;
            this.txt_nConta.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_nConta.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_nConta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_nConta.LineThickness = 2;
            this.txt_nConta.Location = new System.Drawing.Point(679, 524);
            this.txt_nConta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nConta.Name = "txt_nConta";
            this.txt_nConta.Size = new System.Drawing.Size(205, 42);
            this.txt_nConta.TabIndex = 67;
            this.txt_nConta.Text = "Número de conta";
            this.txt_nConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 644);
            this.Controls.Add(this.txt_nConta);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_percentagemJuros);
            this.Controls.Add(this.lbl_valorJuros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valorNecessario);
            this.Controls.Add(this.lbl_estadoCredito);
            this.Controls.Add(this.btn_creditar);
            this.Controls.Add(this.lbl_valorApagarPorMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_meses);
            this.Controls.Add(this.sld_meses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sld_valor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_creditoSeguro);
            this.Controls.Add(this.btn_creditoHabitacao);
            this.Controls.Add(this.btn_creditoSalario);
            this.Controls.Add(this.btn_creditoPessoal);
            this.Controls.Add(this.btn_credioAutomovel);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_credito";
            this.Text = "frm_credito";
            this.Load += new System.EventHandler(this.frm_credito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btn_creditoSeguro;
        private Bunifu.Framework.UI.BunifuTileButton btn_creditoHabitacao;
        private Bunifu.Framework.UI.BunifuTileButton btn_creditoSalario;
        private Bunifu.Framework.UI.BunifuTileButton btn_creditoPessoal;
        private Bunifu.Framework.UI.BunifuTileButton btn_credioAutomovel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSlider sld_valor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_meses;
        private Bunifu.Framework.UI.BunifuSlider sld_meses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_valorApagarPorMes;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_creditar;
        private System.Windows.Forms.Label lbl_estadoCredito;
        private System.Windows.Forms.TextBox txt_valorNecessario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_percentagemJuros;
        private System.Windows.Forms.Label lbl_valorJuros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nConta;
    }
}