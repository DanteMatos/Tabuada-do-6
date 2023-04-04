namespace Tabuadado6
{
    partial class FrmPosto
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
            this.lblgas = new System.Windows.Forms.Label();
            this.txtgas = new System.Windows.Forms.TextBox();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.lblquant = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgas
            // 
            this.lblgas.AutoSize = true;
            this.lblgas.Location = new System.Drawing.Point(28, 42);
            this.lblgas.Name = "lblgas";
            this.lblgas.Size = new System.Drawing.Size(188, 13);
            this.lblgas.TabIndex = 0;
            this.lblgas.Text = "Digite A para álcool e G para gasolina:";
            // 
            // txtgas
            // 
            this.txtgas.Location = new System.Drawing.Point(222, 42);
            this.txtgas.Name = "txtgas";
            this.txtgas.Size = new System.Drawing.Size(100, 20);
            this.txtgas.TabIndex = 1;
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(222, 97);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(100, 20);
            this.txtquant.TabIndex = 2;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(222, 157);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 3;
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Location = new System.Drawing.Point(102, 100);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(114, 13);
            this.lblquant.TabIndex = 4;
            this.lblquant.Text = "Escreva a quantidade:";
            this.lblquant.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(125, 160);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(91, 13);
            this.lblpreco.TabIndex = 5;
            this.lblpreco.Text = "Preço a se pagar:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(118, 317);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(98, 30);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(293, 317);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(98, 30);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(469, 317);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(98, 30);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // FrmPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.txtgas);
            this.Controls.Add(this.lblgas);
            this.Name = "FrmPosto";
            this.Text = "Posto de Gasolina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgas;
        private System.Windows.Forms.TextBox txtgas;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}