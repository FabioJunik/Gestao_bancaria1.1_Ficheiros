namespace Novembro_15
{
    partial class inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.dgv_lista = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminarConta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_mostrarExtrato = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_mostrarConta = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pesquisar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_lista
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_lista.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_lista.ColumnHeadersHeight = 30;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgv_lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_lista.DoubleBuffered = true;
            this.dgv_lista.EnableHeadersVisualStyles = false;
            this.dgv_lista.HeaderBgColor = System.Drawing.Color.SlateGray;
            this.dgv_lista.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_lista.Location = new System.Drawing.Point(0, 0);
            this.dgv_lista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_lista.RowHeadersVisible = false;
            this.dgv_lista.RowHeadersWidth = 50;
            this.dgv_lista.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lista.Size = new System.Drawing.Size(862, 442);
            this.dgv_lista.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 300;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nº de conta";
            this.Column2.MinimumWidth = 250;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "IBAN";
            this.Column3.MinimumWidth = 280;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "NIF";
            this.Column5.MinimumWidth = 150;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Saldo";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(376, 69);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(402, 27);
            this.txt_pesquisa.TabIndex = 2;
            this.txt_pesquisa.Text = "Pesquise pelo nome ou Nº conta  ";
            this.txt_pesquisa.Click += new System.EventHandler(this.txt_pesquisa_Click);
            this.txt_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisa_KeyPress);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.White;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.ImageActive = null;
            this.btn_pesquisar.Location = new System.Drawing.Point(748, 71);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(24, 23);
            this.btn_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.TabStop = false;
            this.btn_pesquisar.Zoom = 10;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_eliminarConta);
            this.panel1.Controls.Add(this.btn_mostrarExtrato);
            this.panel1.Controls.Add(this.btn_mostrarConta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 603);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 73);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_eliminarConta
            // 
            this.btn_eliminarConta.ActiveBorderThickness = 1;
            this.btn_eliminarConta.ActiveCornerRadius = 1;
            this.btn_eliminarConta.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_eliminarConta.ActiveForecolor = System.Drawing.Color.White;
            this.btn_eliminarConta.ActiveLineColor = System.Drawing.Color.White;
            this.btn_eliminarConta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_eliminarConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminarConta.BackgroundImage")));
            this.btn_eliminarConta.ButtonText = "Eliminar Conta";
            this.btn_eliminarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarConta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarConta.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminarConta.IdleBorderThickness = 1;
            this.btn_eliminarConta.IdleCornerRadius = 1;
            this.btn_eliminarConta.IdleFillColor = System.Drawing.Color.White;
            this.btn_eliminarConta.IdleForecolor = System.Drawing.Color.Black;
            this.btn_eliminarConta.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_eliminarConta.Location = new System.Drawing.Point(351, 12);
            this.btn_eliminarConta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_eliminarConta.Name = "btn_eliminarConta";
            this.btn_eliminarConta.Size = new System.Drawing.Size(150, 50);
            this.btn_eliminarConta.TabIndex = 30;
            this.btn_eliminarConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_eliminarConta.Click += new System.EventHandler(this.btn_eliminarConta_Click);
            // 
            // btn_mostrarExtrato
            // 
            this.btn_mostrarExtrato.ActiveBorderThickness = 1;
            this.btn_mostrarExtrato.ActiveCornerRadius = 1;
            this.btn_mostrarExtrato.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_mostrarExtrato.ActiveForecolor = System.Drawing.Color.White;
            this.btn_mostrarExtrato.ActiveLineColor = System.Drawing.Color.White;
            this.btn_mostrarExtrato.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_mostrarExtrato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mostrarExtrato.BackgroundImage")));
            this.btn_mostrarExtrato.ButtonText = "Mostrar extrato";
            this.btn_mostrarExtrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrarExtrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarExtrato.ForeColor = System.Drawing.Color.Black;
            this.btn_mostrarExtrato.IdleBorderThickness = 1;
            this.btn_mostrarExtrato.IdleCornerRadius = 1;
            this.btn_mostrarExtrato.IdleFillColor = System.Drawing.Color.White;
            this.btn_mostrarExtrato.IdleForecolor = System.Drawing.Color.Black;
            this.btn_mostrarExtrato.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_mostrarExtrato.Location = new System.Drawing.Point(190, 12);
            this.btn_mostrarExtrato.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_mostrarExtrato.Name = "btn_mostrarExtrato";
            this.btn_mostrarExtrato.Size = new System.Drawing.Size(150, 50);
            this.btn_mostrarExtrato.TabIndex = 29;
            this.btn_mostrarExtrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mostrarExtrato.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btn_mostrarConta
            // 
            this.btn_mostrarConta.ActiveBorderThickness = 1;
            this.btn_mostrarConta.ActiveCornerRadius = 1;
            this.btn_mostrarConta.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_mostrarConta.ActiveForecolor = System.Drawing.Color.White;
            this.btn_mostrarConta.ActiveLineColor = System.Drawing.Color.White;
            this.btn_mostrarConta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_mostrarConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mostrarConta.BackgroundImage")));
            this.btn_mostrarConta.ButtonText = "Mostrar conta";
            this.btn_mostrarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrarConta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarConta.ForeColor = System.Drawing.Color.Black;
            this.btn_mostrarConta.IdleBorderThickness = 1;
            this.btn_mostrarConta.IdleCornerRadius = 1;
            this.btn_mostrarConta.IdleFillColor = System.Drawing.Color.White;
            this.btn_mostrarConta.IdleForecolor = System.Drawing.Color.Black;
            this.btn_mostrarConta.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_mostrarConta.Location = new System.Drawing.Point(37, 12);
            this.btn_mostrarConta.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_mostrarConta.Name = "btn_mostrarConta";
            this.btn_mostrarConta.Size = new System.Drawing.Size(141, 50);
            this.btn_mostrarConta.TabIndex = 28;
            this.btn_mostrarConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mostrarConta.Click += new System.EventHandler(this.btn_mostrarConta_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_lista);
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 442);
            this.panel2.TabIndex = 5;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_pesquisa);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pesquisar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_lista;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private Bunifu.Framework.UI.BunifuImageButton btn_pesquisar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_mostrarConta;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_mostrarExtrato;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_eliminarConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel2;
    }
}