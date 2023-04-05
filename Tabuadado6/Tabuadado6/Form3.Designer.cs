namespace Tabuadado6
{
    partial class Frm3
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.lblr = new System.Windows.Forms.Label();
            this.bntenquanto = new System.Windows.Forms.Button();
            this.bntpara = new System.Windows.Forms.Button();
            this.bntrepita = new System.Windows.Forms.Button();
            this.bntlimpar = new System.Windows.Forms.Button();
            this.bntvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl.Location = new System.Drawing.Point(393, 191);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(93, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Digite o número 6:";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(562, 184);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(232, 20);
            this.txtx.TabIndex = 1;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(562, 236);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(232, 20);
            this.txtresult.TabIndex = 2;
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblr.Location = new System.Drawing.Point(393, 243);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(143, 13);
            this.lblr.TabIndex = 3;
            this.lblr.Text = "Resultado da Tabuada do 6:";
            // 
            // bntenquanto
            // 
            this.bntenquanto.Location = new System.Drawing.Point(515, 387);
            this.bntenquanto.Name = "bntenquanto";
            this.bntenquanto.Size = new System.Drawing.Size(186, 64);
            this.bntenquanto.TabIndex = 4;
            this.bntenquanto.Text = "Calcular Enquanto";
            this.bntenquanto.UseVisualStyleBackColor = true;
            this.bntenquanto.Click += new System.EventHandler(this.bntenquanto_Click);
            // 
            // bntpara
            // 
            this.bntpara.Location = new System.Drawing.Point(515, 527);
            this.bntpara.Name = "bntpara";
            this.bntpara.Size = new System.Drawing.Size(186, 64);
            this.bntpara.TabIndex = 5;
            this.bntpara.Text = "Calcular Para";
            this.bntpara.UseVisualStyleBackColor = true;
            this.bntpara.Click += new System.EventHandler(this.bntpara_Click);
            // 
            // bntrepita
            // 
            this.bntrepita.Location = new System.Drawing.Point(515, 457);
            this.bntrepita.Name = "bntrepita";
            this.bntrepita.Size = new System.Drawing.Size(186, 64);
            this.bntrepita.TabIndex = 6;
            this.bntrepita.Text = "Calcular Repita";
            this.bntrepita.UseVisualStyleBackColor = true;
            this.bntrepita.Click += new System.EventHandler(this.bntrepita_Click);
            // 
            // bntlimpar
            // 
            this.bntlimpar.Location = new System.Drawing.Point(203, 457);
            this.bntlimpar.Name = "bntlimpar";
            this.bntlimpar.Size = new System.Drawing.Size(186, 64);
            this.bntlimpar.TabIndex = 7;
            this.bntlimpar.Text = "Limpar";
            this.bntlimpar.UseVisualStyleBackColor = true;
            this.bntlimpar.Click += new System.EventHandler(this.bntlimpar_Click);
            // 
            // bntvoltar
            // 
            this.bntvoltar.Location = new System.Drawing.Point(837, 457);
            this.bntvoltar.Name = "bntvoltar";
            this.bntvoltar.Size = new System.Drawing.Size(186, 64);
            this.bntvoltar.TabIndex = 8;
            this.bntvoltar.Text = "Voltar";
            this.bntvoltar.UseVisualStyleBackColor = true;
            this.bntvoltar.Click += new System.EventHandler(this.bntvoltar_Click);
            // 
            // Frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1236, 631);
            this.Controls.Add(this.bntvoltar);
            this.Controls.Add(this.bntlimpar);
            this.Controls.Add(this.bntrepita);
            this.Controls.Add(this.bntpara);
            this.Controls.Add(this.bntenquanto);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.lbl);
            this.Name = "Frm3";
            this.Text = "Tabuada do 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Button bntenquanto;
        private System.Windows.Forms.Button bntpara;
        private System.Windows.Forms.Button bntrepita;
        private System.Windows.Forms.Button bntlimpar;
        private System.Windows.Forms.Button bntvoltar;
    }
}