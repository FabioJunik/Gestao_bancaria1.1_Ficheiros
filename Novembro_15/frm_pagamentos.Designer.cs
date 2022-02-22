namespace Novembro_15
{
    partial class frm_pagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pagamentos));
            this.btn_telefonia = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_televisao = new Bunifu.Framework.UI.BunifuTileButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_teste = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btn_telefonia
            // 
            this.btn_telefonia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_telefonia.color = System.Drawing.Color.DarkSlateGray;
            this.btn_telefonia.colorActive = System.Drawing.Color.Gray;
            this.btn_telefonia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_telefonia.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_telefonia.ForeColor = System.Drawing.Color.White;
            this.btn_telefonia.Image = ((System.Drawing.Image)(resources.GetObject("btn_telefonia.Image")));
            this.btn_telefonia.ImagePosition = 20;
            this.btn_telefonia.ImageZoom = 50;
            this.btn_telefonia.LabelPosition = 41;
            this.btn_telefonia.LabelText = "Telefone";
            this.btn_telefonia.Location = new System.Drawing.Point(83, 84);
            this.btn_telefonia.Margin = new System.Windows.Forms.Padding(6);
            this.btn_telefonia.Name = "btn_telefonia";
            this.btn_telefonia.Size = new System.Drawing.Size(128, 129);
            this.btn_telefonia.TabIndex = 3;
            this.btn_telefonia.Click += new System.EventHandler(this.btn_telefonia_Click);
            // 
            // btn_televisao
            // 
            this.btn_televisao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_televisao.color = System.Drawing.Color.DarkSlateGray;
            this.btn_televisao.colorActive = System.Drawing.Color.Gray;
            this.btn_televisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_televisao.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_televisao.ForeColor = System.Drawing.Color.White;
            this.btn_televisao.Image = ((System.Drawing.Image)(resources.GetObject("btn_televisao.Image")));
            this.btn_televisao.ImagePosition = 20;
            this.btn_televisao.ImageZoom = 50;
            this.btn_televisao.LabelPosition = 41;
            this.btn_televisao.LabelText = "Televisão";
            this.btn_televisao.Location = new System.Drawing.Point(293, 84);
            this.btn_televisao.Margin = new System.Windows.Forms.Padding(6);
            this.btn_televisao.Name = "btn_televisao";
            this.btn_televisao.Size = new System.Drawing.Size(128, 129);
            this.btn_televisao.TabIndex = 4;
            this.btn_televisao.Click += new System.EventHandler(this.btn_televisao_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 198);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(970, 446);
            this.mainPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o pagamento a efectuar";
            // 
            // btn_teste
            // 
            this.btn_teste.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_teste.color = System.Drawing.Color.DarkSlateGray;
            this.btn_teste.colorActive = System.Drawing.Color.Gray;
            this.btn_teste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teste.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btn_teste.ForeColor = System.Drawing.Color.White;
            this.btn_teste.Image = ((System.Drawing.Image)(resources.GetObject("btn_teste.Image")));
            this.btn_teste.ImagePosition = 20;
            this.btn_teste.ImageZoom = 50;
            this.btn_teste.LabelPosition = 41;
            this.btn_teste.LabelText = "Para testes";
            this.btn_teste.Location = new System.Drawing.Point(499, 84);
            this.btn_teste.Margin = new System.Windows.Forms.Padding(6);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(128, 129);
            this.btn_teste.TabIndex = 7;
            // 
            // frm_pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btn_televisao);
            this.Controls.Add(this.btn_telefonia);
            this.Controls.Add(this.btn_teste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_pagamentos";
            this.Text = "frm_pagamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btn_telefonia;
        private Bunifu.Framework.UI.BunifuTileButton btn_televisao;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_teste;
    }
}