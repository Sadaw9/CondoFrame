namespace frontPage
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.condôminosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sindicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCaderno = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correspondênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblData.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCadastro,
            this.mCaderno,
            this.reclamaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mCadastro
            // 
            this.mCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.condôminosToolStripMenuItem,
            this.sindicosToolStripMenuItem});
            this.mCadastro.Name = "mCadastro";
            this.mCadastro.Size = new System.Drawing.Size(88, 24);
            this.mCadastro.Text = "Cadastros";
            this.mCadastro.Click += new System.EventHandler(this.mCadastro_Click);
            // 
            // condôminosToolStripMenuItem
            // 
            this.condôminosToolStripMenuItem.Name = "condôminosToolStripMenuItem";
            this.condôminosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.condôminosToolStripMenuItem.Text = "Condômino";
            this.condôminosToolStripMenuItem.Click += new System.EventHandler(this.condôminosToolStripMenuItem_Click);
            // 
            // sindicosToolStripMenuItem
            // 
            this.sindicosToolStripMenuItem.Name = "sindicosToolStripMenuItem";
            this.sindicosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sindicosToolStripMenuItem.Text = "Sindico";
            this.sindicosToolStripMenuItem.Click += new System.EventHandler(this.sindicosToolStripMenuItem_Click);
            // 
            // mCaderno
            // 
            this.mCaderno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.correspondênciaToolStripMenuItem});
            this.mCaderno.Name = "mCaderno";
            this.mCaderno.Size = new System.Drawing.Size(128, 24);
            this.mCaderno.Text = "Caderno Digital";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // correspondênciaToolStripMenuItem
            // 
            this.correspondênciaToolStripMenuItem.Name = "correspondênciaToolStripMenuItem";
            this.correspondênciaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.correspondênciaToolStripMenuItem.Text = "Correspondência";
            this.correspondênciaToolStripMenuItem.Click += new System.EventHandler(this.correspondênciaToolStripMenuItem_Click);
            // 
            // reclamaçõesToolStripMenuItem
            // 
            this.reclamaçõesToolStripMenuItem.Name = "reclamaçõesToolStripMenuItem";
            this.reclamaçõesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.reclamaçõesToolStripMenuItem.Text = "Reclamações";
            this.reclamaçõesToolStripMenuItem.Click += new System.EventHandler(this.reclamaçõesToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(938, 547);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondoFrame";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mCadastro;
        private System.Windows.Forms.ToolStripMenuItem condôminosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sindicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCaderno;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correspondênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamaçõesToolStripMenuItem;
    }
}

