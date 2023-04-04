namespace Tabuadado6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercícioDoPostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícioTabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícioTabuadaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercícioIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercícioDoPostoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercícioDoPostoToolStripMenuItem
            // 
            this.exercícioDoPostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercícioTabuadaToolStripMenuItem,
            this.exercícioTabuadaToolStripMenuItem1,
            this.exercícioIMCToolStripMenuItem});
            this.exercícioDoPostoToolStripMenuItem.Name = "exercícioDoPostoToolStripMenuItem";
            this.exercícioDoPostoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exercícioDoPostoToolStripMenuItem.Text = "Exercícios";
            // 
            // exercícioTabuadaToolStripMenuItem
            // 
            this.exercícioTabuadaToolStripMenuItem.Name = "exercícioTabuadaToolStripMenuItem";
            this.exercícioTabuadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercícioTabuadaToolStripMenuItem.Text = "Exercício Posto";
            this.exercícioTabuadaToolStripMenuItem.Click += new System.EventHandler(this.exercícioTabuadaToolStripMenuItem_Click);
            // 
            // exercícioTabuadaToolStripMenuItem1
            // 
            this.exercícioTabuadaToolStripMenuItem1.Name = "exercícioTabuadaToolStripMenuItem1";
            this.exercícioTabuadaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exercícioTabuadaToolStripMenuItem1.Text = "Exercício Tabuada";
            // 
            // exercícioIMCToolStripMenuItem
            // 
            this.exercícioIMCToolStripMenuItem.Name = "exercícioIMCToolStripMenuItem";
            this.exercícioIMCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercícioIMCToolStripMenuItem.Text = "Exercício IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Exercícios Condicional e Looping";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercícioDoPostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercícioTabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercícioTabuadaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exercícioIMCToolStripMenuItem;
    }
}

