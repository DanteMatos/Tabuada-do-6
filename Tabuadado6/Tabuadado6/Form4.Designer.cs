namespace Tabuadado6
{
    partial class frm4
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
            this.lblatura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.bntcal = new System.Windows.Forms.Button();
            this.bntvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblatura
            // 
            this.lblatura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblatura.AutoSize = true;
            this.lblatura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblatura.Location = new System.Drawing.Point(362, 150);
            this.lblatura.Name = "lblatura";
            this.lblatura.Size = new System.Drawing.Size(86, 13);
            this.lblatura.TabIndex = 0;
            this.lblatura.Text = "Digite sua altura:";
            // 
            // lblpeso
            // 
            this.lblpeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpeso.AutoSize = true;
            this.lblpeso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpeso.Location = new System.Drawing.Point(362, 190);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(83, 13);
            this.lblpeso.TabIndex = 1;
            this.lblpeso.Text = "Digite seu peso:";
            // 
            // lblresult
            // 
            this.lblresult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblresult.AutoSize = true;
            this.lblresult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblresult.Location = new System.Drawing.Point(362, 224);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(110, 13);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Resultado do cálculo:";
            // 
            // txtalt
            // 
            this.txtalt.Location = new System.Drawing.Point(494, 142);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(182, 20);
            this.txtalt.TabIndex = 3;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(494, 224);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(182, 20);
            this.txtresult.TabIndex = 4;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(494, 183);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(182, 20);
            this.txtpeso.TabIndex = 5;
            // 
            // bntcal
            // 
            this.bntcal.Location = new System.Drawing.Point(837, 109);
            this.bntcal.Name = "bntcal";
            this.bntcal.Size = new System.Drawing.Size(163, 53);
            this.bntcal.TabIndex = 6;
            this.bntcal.Text = "Calcular";
            this.bntcal.UseVisualStyleBackColor = true;
            this.bntcal.Click += new System.EventHandler(this.bntcal_Click);
            // 
            // bntvoltar
            // 
            this.bntvoltar.Location = new System.Drawing.Point(837, 283);
            this.bntvoltar.Name = "bntvoltar";
            this.bntvoltar.Size = new System.Drawing.Size(163, 53);
            this.bntvoltar.TabIndex = 7;
            this.bntvoltar.Text = "Voltar";
            this.bntvoltar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(837, 196);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(163, 53);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1324, 638);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.bntvoltar);
            this.Controls.Add(this.bntcal);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtalt);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblatura);
            this.Name = "frm4";
            this.Text = "Calculo de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblatura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button bntcal;
        private System.Windows.Forms.Button bntvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}