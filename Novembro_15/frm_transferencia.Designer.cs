namespace Novembro_15
{
    partial class frm_transferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_transferencia));
            this.btn_transferir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_contaOrigem = new System.Windows.Forms.TextBox();
            this.txt_contaDestino = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_transferir
            // 
            this.btn_transferir.ActiveBorderThickness = 1;
            this.btn_transferir.ActiveCornerRadius = 1;
            this.btn_transferir.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_transferir.ActiveForecolor = System.Drawing.Color.White;
            this.btn_transferir.ActiveLineColor = System.Drawing.Color.White;
            this.btn_transferir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_transferir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transferir.BackgroundImage")));
            this.btn_transferir.ButtonText = "Transferir";
            this.btn_transferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transferir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transferir.ForeColor = System.Drawing.Color.Black;
            this.btn_transferir.IdleBorderThickness = 1;
            this.btn_transferir.IdleCornerRadius = 1;
            this.btn_transferir.IdleFillColor = System.Drawing.Color.White;
            this.btn_transferir.IdleForecolor = System.Drawing.Color.Black;
            this.btn_transferir.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_transferir.Location = new System.Drawing.Point(522, 304);
            this.btn_transferir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(168, 59);
            this.btn_transferir.TabIndex = 64;
            this.btn_transferir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(210, 247);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(229, 34);
            this.bunifuCustomLabel3.TabIndex = 63;
            this.bunifuCustomLabel3.Text = "Valor da transferência";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(210, 116);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(178, 34);
            this.bunifuCustomLabel2.TabIndex = 62;
            this.bunifuCustomLabel2.Text = "Conta de origem";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(339, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(485, 65);
            this.bunifuCustomLabel1.TabIndex = 61;
            this.bunifuCustomLabel1.Text = "Transferência de valores";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(210, 179);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(180, 34);
            this.bunifuCustomLabel4.TabIndex = 67;
            this.bunifuCustomLabel4.Text = "Conta de destino";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(396, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(61, 28);
            this.textBox1.TabIndex = 70;
            this.textBox1.Text = "AO06";
            // 
            // txt_contaOrigem
            // 
            this.txt_contaOrigem.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contaOrigem.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txt_contaOrigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contaOrigem.Location = new System.Drawing.Point(396, 116);
            this.txt_contaOrigem.Name = "txt_contaOrigem";
            this.txt_contaOrigem.Size = new System.Drawing.Size(405, 29);
            this.txt_contaOrigem.TabIndex = 71;
            this.txt_contaOrigem.Text = "Númeor de conta";
            this.txt_contaOrigem.Click += new System.EventHandler(this.txt_contaOrigem_Click);
            // 
            // txt_contaDestino
            // 
            this.txt_contaDestino.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contaDestino.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txt_contaDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contaDestino.Location = new System.Drawing.Point(462, 183);
            this.txt_contaDestino.Name = "txt_contaDestino";
            this.txt_contaDestino.Size = new System.Drawing.Size(339, 29);
            this.txt_contaDestino.TabIndex = 72;
            this.txt_contaDestino.Text = "IBAN do destinatário";
            this.txt_contaDestino.Click += new System.EventHandler(this.txt_contaDestino_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.SystemColors.Window;
            this.txt_valor.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.txt_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_valor.Location = new System.Drawing.Point(447, 252);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(354, 29);
            this.txt_valor.TabIndex = 73;
            this.txt_valor.Text = "Valor da transferência";
            this.txt_valor.Click += new System.EventHandler(this.txt_valor_Click);
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            // 
            // frm_transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 408);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_contaDestino);
            this.Controls.Add(this.txt_contaOrigem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btn_transferir);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_transferencia";
            this.Text = "frm_transferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btn_transferir;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_contaOrigem;
        private System.Windows.Forms.TextBox txt_contaDestino;
        private System.Windows.Forms.TextBox txt_valor;
    }
}