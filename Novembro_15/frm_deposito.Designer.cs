namespace Novembro_15
{
    partial class frm_deposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_deposito));
            this.txt_valor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_nConta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_depositar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.SystemColors.Window;
            this.txt_valor.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_valor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_valor.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_valor.BorderThickness = 1;
            this.txt_valor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_valor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_valor.isPassword = false;
            this.txt_valor.Location = new System.Drawing.Point(394, 190);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(471, 32);
            this.txt_valor.TabIndex = 54;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            // 
            // txt_nConta
            // 
            this.txt_nConta.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nConta.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_nConta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nConta.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_nConta.BorderThickness = 1;
            this.txt_nConta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nConta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nConta.isPassword = false;
            this.txt_nConta.Location = new System.Drawing.Point(394, 116);
            this.txt_nConta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_nConta.Name = "txt_nConta";
            this.txt_nConta.Size = new System.Drawing.Size(471, 32);
            this.txt_nConta.TabIndex = 53;
            this.txt_nConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_depositar
            // 
            this.btn_depositar.ActiveBorderThickness = 1;
            this.btn_depositar.ActiveCornerRadius = 1;
            this.btn_depositar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_depositar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_depositar.ActiveLineColor = System.Drawing.Color.White;
            this.btn_depositar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_depositar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_depositar.BackgroundImage")));
            this.btn_depositar.ButtonText = "Depositar ";
            this.btn_depositar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_depositar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depositar.ForeColor = System.Drawing.Color.Black;
            this.btn_depositar.IdleBorderThickness = 1;
            this.btn_depositar.IdleCornerRadius = 1;
            this.btn_depositar.IdleFillColor = System.Drawing.Color.White;
            this.btn_depositar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_depositar.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_depositar.Location = new System.Drawing.Point(558, 251);
            this.btn_depositar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(168, 59);
            this.btn_depositar.TabIndex = 52;
            this.btn_depositar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_depositar.Click += new System.EventHandler(this.btn_depositar_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(204, 190);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(184, 34);
            this.bunifuCustomLabel3.TabIndex = 51;
            this.bunifuCustomLabel3.Text = "Valor do deposito";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(204, 116);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(182, 34);
            this.bunifuCustomLabel2.TabIndex = 50;
            this.bunifuCustomLabel2.Text = "Número de conta";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(383, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(394, 65);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "Deposito de valores";
            // 
            // frm_deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 356);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_nConta);
            this.Controls.Add(this.btn_depositar);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_deposito";
            this.Text = "frm_deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txt_valor;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_nConta;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_depositar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}