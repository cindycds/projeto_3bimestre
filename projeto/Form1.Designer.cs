﻿namespace projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(363, 354);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(66, 40);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(376, 290);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(36, 13);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "senha";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(346, 238);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(100, 20);
            this.txbemail.TabIndex = 3;
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(346, 306);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(100, 20);
            this.txbsenha.TabIndex = 4;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(381, 222);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::projeto.Properties.Resources._14448996_5463002;
            this.ClientSize = new System.Drawing.Size(830, 654);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label lblemail;
    }
}

