namespace Novembro_15
{
    partial class frm_transacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_transacoes));
            this.btn_transferencia = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_saque = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_deposito = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_transferencia
            // 
            this.btn_transferencia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_transferencia.color = System.Drawing.Color.DarkSlateGray;
            this.btn_transferencia.colorActive = System.Drawing.Color.Gray;
            this.btn_transferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transferencia.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_transferencia.ForeColor = System.Drawing.Color.White;
            this.btn_transferencia.Image = ((System.Drawing.Image)(resources.GetObject("btn_transferencia.Image")));
            this.btn_transferencia.ImagePosition = 20;
            this.btn_transferencia.ImageZoom = 50;
            this.btn_transferencia.LabelPosition = 41;
            this.btn_transferencia.LabelText = "Transferência";
            this.btn_transferencia.Location = new System.Drawing.Point(637, 105);
            this.btn_transferencia.Margin = new System.Windows.Forms.Padding(6);
            this.btn_transferencia.Name = "btn_transferencia";
            this.btn_transferencia.Size = new System.Drawing.Size(145, 129);
            this.btn_transferencia.TabIndex = 0;
            this.btn_transferencia.Click += new System.EventHandler(this.btn_transferencia_Click);
            // 
            // btn_saque
            // 
            this.btn_saque.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_saque.color = System.Drawing.Color.DarkSlateGray;
            this.btn_saque.colorActive = System.Drawing.Color.Gray;
            this.btn_saque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saque.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_saque.ForeColor = System.Drawing.Color.White;
            this.btn_saque.Image = ((System.Drawing.Image)(resources.GetObject("btn_saque.Image")));
            this.btn_saque.ImagePosition = 20;
            this.btn_saque.ImageZoom = 50;
            this.btn_saque.LabelPosition = 41;
            this.btn_saque.LabelText = "Saque";
            this.btn_saque.Location = new System.Drawing.Point(442, 105);
            this.btn_saque.Margin = new System.Windows.Forms.Padding(6);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(145, 129);
            this.btn_saque.TabIndex = 1;
            this.btn_saque.Click += new System.EventHandler(this.btn_saque_Click);
            // 
            // btn_deposito
            // 
            this.btn_deposito.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_deposito.color = System.Drawing.Color.DarkSlateGray;
            this.btn_deposito.colorActive = System.Drawing.Color.Gray;
            this.btn_deposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deposito.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_deposito.ForeColor = System.Drawing.Color.White;
            this.btn_deposito.Image = ((System.Drawing.Image)(resources.GetObject("btn_deposito.Image")));
            this.btn_deposito.ImagePosition = 20;
            this.btn_deposito.ImageZoom = 50;
            this.btn_deposito.LabelPosition = 41;
            this.btn_deposito.LabelText = "Deposito";
            this.btn_deposito.Location = new System.Drawing.Point(251, 105);
            this.btn_deposito.Margin = new System.Windows.Forms.Padding(6);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(145, 129);
            this.btn_deposito.TabIndex = 2;
            this.btn_deposito.Click += new System.EventHandler(this.btn_deposito_Click);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_main.Location = new System.Drawing.Point(0, 207);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1034, 437);
            this.panel_main.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione a opção desejada";
            // 
            // frm_transacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.btn_saque);
            this.Controls.Add(this.btn_transferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_transacoes";
            this.Text = "frm_transacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btn_transferencia;
        private Bunifu.Framework.UI.BunifuTileButton btn_saque;
        private Bunifu.Framework.UI.BunifuTileButton btn_deposito;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label1;
    }
}