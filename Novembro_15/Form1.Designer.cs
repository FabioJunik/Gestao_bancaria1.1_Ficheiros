namespace Novembro_15
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Barra_de_titulo = new System.Windows.Forms.Panel();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_normalizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu_lateral = new System.Windows.Forms.Panel();
            this.btn_pagamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_movimento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_produtos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_cliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_conta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubMenu = new System.Windows.Forms.Panel();
            this.btn_credito = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.controlador = new System.Windows.Forms.Panel();
            this.lbl_local = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Barra_de_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu_lateral.SuspendLayout();
            this.SubMenu.SuspendLayout();
            this.controlador.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra_de_titulo
            // 
            this.Barra_de_titulo.BackColor = System.Drawing.Color.DarkBlue;
            this.Barra_de_titulo.Controls.Add(this.btn_maximizar);
            this.Barra_de_titulo.Controls.Add(this.btn_normalizar);
            this.Barra_de_titulo.Controls.Add(this.pictureBox2);
            this.Barra_de_titulo.Controls.Add(this.pictureBox1);
            this.Barra_de_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_de_titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_de_titulo.Name = "Barra_de_titulo";
            this.Barra_de_titulo.Size = new System.Drawing.Size(1026, 36);
            this.Barra_de_titulo.TabIndex = 0;
            this.Barra_de_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Barra_de_titulo_Paint);
            this.Barra_de_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_de_titulo_MouseDown);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.BackColor = System.Drawing.Color.Green;
            this.btn_maximizar.Location = new System.Drawing.Point(973, 10);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(13, 13);
            this.btn_maximizar.TabIndex = 2;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_normalizar
            // 
            this.btn_normalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_normalizar.BackColor = System.Drawing.Color.Yellow;
            this.btn_normalizar.Location = new System.Drawing.Point(973, 10);
            this.btn_normalizar.Name = "btn_normalizar";
            this.btn_normalizar.Size = new System.Drawing.Size(13, 13);
            this.btn_normalizar.TabIndex = 3;
            this.btn_normalizar.TabStop = false;
            this.btn_normalizar.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(948, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 13);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(996, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu_lateral
            // 
            this.Menu_lateral.BackColor = System.Drawing.Color.SteelBlue;
            this.Menu_lateral.Controls.Add(this.label2);
            this.Menu_lateral.Controls.Add(this.label1);
            this.Menu_lateral.Controls.Add(this.label4);
            this.Menu_lateral.Controls.Add(this.btn_pagamento);
            this.Menu_lateral.Controls.Add(this.panel7);
            this.Menu_lateral.Controls.Add(this.btn_movimento);
            this.Menu_lateral.Controls.Add(this.panel3);
            this.Menu_lateral.Controls.Add(this.btn_produtos);
            this.Menu_lateral.Controls.Add(this.panel4);
            this.Menu_lateral.Controls.Add(this.btn_cliente);
            this.Menu_lateral.Controls.Add(this.panel2);
            this.Menu_lateral.Controls.Add(this.btn_conta);
            this.Menu_lateral.Controls.Add(this.panel1);
            this.Menu_lateral.Controls.Add(this.SubMenu);
            this.Menu_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_lateral.Location = new System.Drawing.Point(0, 36);
            this.Menu_lateral.Name = "Menu_lateral";
            this.Menu_lateral.Size = new System.Drawing.Size(294, 669);
            this.Menu_lateral.TabIndex = 2;
            // 
            // btn_pagamento
            // 
            this.btn_pagamento.Activecolor = System.Drawing.Color.LightSlateGray;
            this.btn_pagamento.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_pagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pagamento.BorderRadius = 0;
            this.btn_pagamento.ButtonText = "Pagamentos";
            this.btn_pagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagamento.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.btn_pagamento.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_pagamento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_pagamento.Iconimage")));
            this.btn_pagamento.Iconimage_right = null;
            this.btn_pagamento.Iconimage_right_Selected = null;
            this.btn_pagamento.Iconimage_Selected = null;
            this.btn_pagamento.IconMarginLeft = 0;
            this.btn_pagamento.IconMarginRight = 0;
            this.btn_pagamento.IconRightVisible = true;
            this.btn_pagamento.IconRightZoom = 0D;
            this.btn_pagamento.IconVisible = true;
            this.btn_pagamento.IconZoom = 60D;
            this.btn_pagamento.IsTab = false;
            this.btn_pagamento.Location = new System.Drawing.Point(6, 317);
            this.btn_pagamento.Name = "btn_pagamento";
            this.btn_pagamento.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btn_pagamento.OnHovercolor = System.Drawing.Color.White;
            this.btn_pagamento.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_pagamento.selected = false;
            this.btn_pagamento.Size = new System.Drawing.Size(292, 42);
            this.btn_pagamento.TabIndex = 19;
            this.btn_pagamento.Text = "Pagamentos";
            this.btn_pagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pagamento.Textcolor = System.Drawing.Color.White;
            this.btn_pagamento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagamento.Click += new System.EventHandler(this.btn_pagamento_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(1, 317);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 41);
            this.panel7.TabIndex = 20;
            // 
            // btn_movimento
            // 
            this.btn_movimento.Activecolor = System.Drawing.Color.LightSlateGray;
            this.btn_movimento.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_movimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_movimento.BorderRadius = 0;
            this.btn_movimento.ButtonText = "Movimentações";
            this.btn_movimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_movimento.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.btn_movimento.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_movimento.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_movimento.Iconimage")));
            this.btn_movimento.Iconimage_right = null;
            this.btn_movimento.Iconimage_right_Selected = null;
            this.btn_movimento.Iconimage_Selected = null;
            this.btn_movimento.IconMarginLeft = 0;
            this.btn_movimento.IconMarginRight = 0;
            this.btn_movimento.IconRightVisible = true;
            this.btn_movimento.IconRightZoom = 0D;
            this.btn_movimento.IconVisible = true;
            this.btn_movimento.IconZoom = 60D;
            this.btn_movimento.IsTab = false;
            this.btn_movimento.Location = new System.Drawing.Point(5, 221);
            this.btn_movimento.Name = "btn_movimento";
            this.btn_movimento.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btn_movimento.OnHovercolor = System.Drawing.Color.White;
            this.btn_movimento.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_movimento.selected = false;
            this.btn_movimento.Size = new System.Drawing.Size(292, 42);
            this.btn_movimento.TabIndex = 17;
            this.btn_movimento.Text = "Movimentações";
            this.btn_movimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_movimento.Textcolor = System.Drawing.Color.White;
            this.btn_movimento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movimento.Click += new System.EventHandler(this.btn_movimento_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 41);
            this.panel3.TabIndex = 18;
            // 
            // btn_produtos
            // 
            this.btn_produtos.Activecolor = System.Drawing.Color.LightSlateGray;
            this.btn_produtos.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_produtos.BorderRadius = 0;
            this.btn_produtos.ButtonText = "Produtos";
            this.btn_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_produtos.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.btn_produtos.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_produtos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_produtos.Iconimage")));
            this.btn_produtos.Iconimage_right = null;
            this.btn_produtos.Iconimage_right_Selected = null;
            this.btn_produtos.Iconimage_Selected = null;
            this.btn_produtos.IconMarginLeft = 0;
            this.btn_produtos.IconMarginRight = 0;
            this.btn_produtos.IconRightVisible = true;
            this.btn_produtos.IconRightZoom = 0D;
            this.btn_produtos.IconVisible = true;
            this.btn_produtos.IconZoom = 60D;
            this.btn_produtos.IsTab = false;
            this.btn_produtos.Location = new System.Drawing.Point(5, 367);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btn_produtos.OnHovercolor = System.Drawing.Color.White;
            this.btn_produtos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_produtos.selected = false;
            this.btn_produtos.Size = new System.Drawing.Size(292, 42);
            this.btn_produtos.TabIndex = 15;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_produtos.Textcolor = System.Drawing.Color.White;
            this.btn_produtos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 367);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 41);
            this.panel4.TabIndex = 16;
            // 
            // btn_cliente
            // 
            this.btn_cliente.Activecolor = System.Drawing.Color.LightSlateGray;
            this.btn_cliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cliente.BorderRadius = 0;
            this.btn_cliente.ButtonText = "Clientes";
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.btn_cliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Iconimage")));
            this.btn_cliente.Iconimage_right = null;
            this.btn_cliente.Iconimage_right_Selected = null;
            this.btn_cliente.Iconimage_Selected = null;
            this.btn_cliente.IconMarginLeft = 0;
            this.btn_cliente.IconMarginRight = 0;
            this.btn_cliente.IconRightVisible = true;
            this.btn_cliente.IconRightZoom = 0D;
            this.btn_cliente.IconVisible = true;
            this.btn_cliente.IconZoom = 60D;
            this.btn_cliente.IsTab = false;
            this.btn_cliente.Location = new System.Drawing.Point(5, 168);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btn_cliente.OnHovercolor = System.Drawing.Color.White;
            this.btn_cliente.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_cliente.selected = false;
            this.btn_cliente.Size = new System.Drawing.Size(292, 42);
            this.btn_cliente.TabIndex = 13;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cliente.Textcolor = System.Drawing.Color.White;
            this.btn_cliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 41);
            this.panel2.TabIndex = 14;
            // 
            // btn_conta
            // 
            this.btn_conta.Activecolor = System.Drawing.Color.LightSlateGray;
            this.btn_conta.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_conta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_conta.BorderRadius = 0;
            this.btn_conta.ButtonText = "Conta";
            this.btn_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_conta.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.btn_conta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_conta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_conta.Iconimage")));
            this.btn_conta.Iconimage_right = null;
            this.btn_conta.Iconimage_right_Selected = null;
            this.btn_conta.Iconimage_Selected = null;
            this.btn_conta.IconMarginLeft = 0;
            this.btn_conta.IconMarginRight = 0;
            this.btn_conta.IconRightVisible = true;
            this.btn_conta.IconRightZoom = 0D;
            this.btn_conta.IconVisible = true;
            this.btn_conta.IconZoom = 60D;
            this.btn_conta.IsTab = false;
            this.btn_conta.Location = new System.Drawing.Point(5, 269);
            this.btn_conta.Name = "btn_conta";
            this.btn_conta.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btn_conta.OnHovercolor = System.Drawing.Color.White;
            this.btn_conta.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_conta.selected = false;
            this.btn_conta.Size = new System.Drawing.Size(292, 42);
            this.btn_conta.TabIndex = 11;
            this.btn_conta.Text = "Conta";
            this.btn_conta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_conta.Textcolor = System.Drawing.Color.White;
            this.btn_conta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conta.Click += new System.EventHandler(this.btn_conta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 41);
            this.panel1.TabIndex = 12;
            // 
            // SubMenu
            // 
            this.SubMenu.Controls.Add(this.btn_credito);
            this.SubMenu.Controls.Add(this.panel6);
            this.SubMenu.Controls.Add(this.bunifuFlatButton1);
            this.SubMenu.Controls.Add(this.panel9);
            this.SubMenu.Location = new System.Drawing.Point(22, 410);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(279, 109);
            this.SubMenu.TabIndex = 4;
            this.SubMenu.Visible = false;
            // 
            // btn_credito
            // 
            this.btn_credito.Activecolor = System.Drawing.Color.LightSlateGray;
            this.btn_credito.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_credito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_credito.BorderRadius = 0;
            this.btn_credito.ButtonText = "Crédito";
            this.btn_credito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_credito.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.btn_credito.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_credito.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_credito.Iconimage")));
            this.btn_credito.Iconimage_right = null;
            this.btn_credito.Iconimage_right_Selected = null;
            this.btn_credito.Iconimage_Selected = null;
            this.btn_credito.IconMarginLeft = 0;
            this.btn_credito.IconMarginRight = 0;
            this.btn_credito.IconRightVisible = true;
            this.btn_credito.IconRightZoom = 0D;
            this.btn_credito.IconVisible = true;
            this.btn_credito.IconZoom = 60D;
            this.btn_credito.IsTab = false;
            this.btn_credito.Location = new System.Drawing.Point(5, 55);
            this.btn_credito.Name = "btn_credito";
            this.btn_credito.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btn_credito.OnHovercolor = System.Drawing.Color.White;
            this.btn_credito.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_credito.selected = false;
            this.btn_credito.Size = new System.Drawing.Size(270, 42);
            this.btn_credito.TabIndex = 11;
            this.btn_credito.Text = "Crédito";
            this.btn_credito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_credito.Textcolor = System.Drawing.Color.White;
            this.btn_credito.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_credito.Click += new System.EventHandler(this.btn_credito_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(1, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 41);
            this.panel6.TabIndex = 12;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LightSlateGray;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Poupaças";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(5, 10);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(270, 42);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Poupaças";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(1, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 41);
            this.panel9.TabIndex = 5;
            // 
            // controlador
            // 
            this.controlador.BackColor = System.Drawing.Color.White;
            this.controlador.Controls.Add(this.lbl_local);
            this.controlador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlador.Location = new System.Drawing.Point(294, 36);
            this.controlador.Name = "controlador";
            this.controlador.Size = new System.Drawing.Size(732, 669);
            this.controlador.TabIndex = 4;
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Location = new System.Drawing.Point(-3, 3);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(0, 13);
            this.lbl_local.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 58);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "_________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 705);
            this.Controls.Add(this.controlador);
            this.Controls.Add(this.Menu_lateral);
            this.Controls.Add(this.Barra_de_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Barra_de_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu_lateral.ResumeLayout(false);
            this.Menu_lateral.PerformLayout();
            this.SubMenu.ResumeLayout(false);
            this.controlador.ResumeLayout(false);
            this.controlador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_de_titulo;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_normalizar;
        private System.Windows.Forms.Panel Menu_lateral;
        private System.Windows.Forms.Panel SubMenu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel controlador;
        private System.Windows.Forms.Label lbl_local;
        private Bunifu.Framework.UI.BunifuFlatButton btn_conta;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_produtos;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cliente;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_movimento;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_credito;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_pagamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

