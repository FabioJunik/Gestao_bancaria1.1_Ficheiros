﻿namespace Novembro_15
{
    partial class frm_televisao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_televisao));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nCartao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_carregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valorRecarga = new System.Windows.Forms.TextBox();
            this.cb_operadora = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 103;
            this.label1.Text = "Número do cartão";
            // 
            // txt_nCartao
            // 
            this.txt_nCartao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nCartao.Location = new System.Drawing.Point(371, 211);
            this.txt_nCartao.Name = "txt_nCartao";
            this.txt_nCartao.Size = new System.Drawing.Size(312, 27);
            this.txt_nCartao.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(181, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 48);
            this.label4.TabIndex = 101;
            this.label4.Text = "Efectuar recarga televisiva";
            // 
            // btn_carregar
            // 
            this.btn_carregar.ActiveBorderThickness = 1;
            this.btn_carregar.ActiveCornerRadius = 1;
            this.btn_carregar.ActiveFillColor = System.Drawing.Color.DimGray;
            this.btn_carregar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_carregar.ActiveLineColor = System.Drawing.Color.White;
            this.btn_carregar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_carregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_carregar.BackgroundImage")));
            this.btn_carregar.ButtonText = "Efectuar Recarga";
            this.btn_carregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_carregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carregar.ForeColor = System.Drawing.Color.Black;
            this.btn_carregar.IdleBorderThickness = 1;
            this.btn_carregar.IdleCornerRadius = 1;
            this.btn_carregar.IdleFillColor = System.Drawing.Color.White;
            this.btn_carregar.IdleForecolor = System.Drawing.Color.Black;
            this.btn_carregar.IdleLineColor = System.Drawing.Color.Gray;
            this.btn_carregar.Location = new System.Drawing.Point(441, 328);
            this.btn_carregar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(166, 51);
            this.btn_carregar.TabIndex = 100;
            this.btn_carregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 99;
            this.label3.Text = "Operadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 98;
            this.label2.Text = "Valor da recarga";
            // 
            // txt_valorRecarga
            // 
            this.txt_valorRecarga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorRecarga.Location = new System.Drawing.Point(371, 255);
            this.txt_valorRecarga.Name = "txt_valorRecarga";
            this.txt_valorRecarga.Size = new System.Drawing.Size(312, 27);
            this.txt_valorRecarga.TabIndex = 97;
            // 
            // cb_operadora
            // 
            this.cb_operadora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_operadora.FormattingEnabled = true;
            this.cb_operadora.Items.AddRange(new object[] {
            "Zap",
            "DSTV"});
            this.cb_operadora.Location = new System.Drawing.Point(371, 163);
            this.cb_operadora.Name = "cb_operadora";
            this.cb_operadora.Size = new System.Drawing.Size(312, 25);
            this.cb_operadora.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.5F);
            this.label5.Location = new System.Drawing.Point(656, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 104;
            this.label5.Text = "Kz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 106;
            this.label6.Text = "Número da Conta";
            // 
            // txt_nConta
            // 
            this.txt_nConta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nConta.Location = new System.Drawing.Point(371, 116);
            this.txt_nConta.Name = "txt_nConta";
            this.txt_nConta.Size = new System.Drawing.Size(312, 27);
            this.txt_nConta.TabIndex = 105;
            // 
            // frm_televisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nCartao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valorRecarga);
            this.Controls.Add(this.cb_operadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_televisao";
            this.Text = "frm_televisao";
            this.Load += new System.EventHandler(this.frm_televisao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nCartao;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_carregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valorRecarga;
        private System.Windows.Forms.ComboBox cb_operadora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nConta;
    }
}