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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPri = new System.Windows.Forms.Button();
            this.btnSeg = new System.Windows.Forms.Button();
            this.btnTerc = new System.Windows.Forms.Button();
            this.btnQua = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Controls.Add(this.btnPri);
            this.flowLayoutPanel1.Controls.Add(this.btnSeg);
            this.flowLayoutPanel1.Controls.Add(this.btnTerc);
            this.flowLayoutPanel1.Controls.Add(this.btnQua);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 515);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPri
            // 
            this.btnPri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPri.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPri.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPri.Image = ((System.Drawing.Image)(resources.GetObject("btnPri.Image")));
            this.btnPri.Location = new System.Drawing.Point(3, 3);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(478, 254);
            this.btnPri.TabIndex = 1;
            this.btnPri.Text = "Portaria\r\n";
            this.btnPri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPri.UseVisualStyleBackColor = false;
            this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
            // 
            // btnSeg
            // 
            this.btnSeg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeg.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeg.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSeg.Image = ((System.Drawing.Image)(resources.GetObject("btnSeg.Image")));
            this.btnSeg.Location = new System.Drawing.Point(487, 3);
            this.btnSeg.Name = "btnSeg";
            this.btnSeg.Size = new System.Drawing.Size(443, 254);
            this.btnSeg.TabIndex = 2;
            this.btnSeg.Text = "Correspondência";
            this.btnSeg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeg.UseVisualStyleBackColor = false;
            this.btnSeg.Click += new System.EventHandler(this.btnSeg_Click);
            // 
            // btnTerc
            // 
            this.btnTerc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerc.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerc.ForeColor = System.Drawing.Color.LightCyan;
            this.btnTerc.Image = ((System.Drawing.Image)(resources.GetObject("btnTerc.Image")));
            this.btnTerc.Location = new System.Drawing.Point(3, 263);
            this.btnTerc.Name = "btnTerc";
            this.btnTerc.Size = new System.Drawing.Size(447, 242);
            this.btnTerc.TabIndex = 3;
            this.btnTerc.Text = "Mensagens";
            this.btnTerc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTerc.UseVisualStyleBackColor = false;
            this.btnTerc.Click += new System.EventHandler(this.btnTerc_Click);
            // 
            // btnQua
            // 
            this.btnQua.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQua.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQua.ForeColor = System.Drawing.Color.LightCyan;
            this.btnQua.Image = ((System.Drawing.Image)(resources.GetObject("btnQua.Image")));
            this.btnQua.Location = new System.Drawing.Point(456, 263);
            this.btnQua.Name = "btnQua";
            this.btnQua.Size = new System.Drawing.Size(474, 242);
            this.btnQua.TabIndex = 4;
            this.btnQua.Text = "Reservas";
            this.btnQua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQua.UseVisualStyleBackColor = false;
            this.btnQua.Click += new System.EventHandler(this.btnQua_Click);
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
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(938, 547);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CondoFrame";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSeg;
        private System.Windows.Forms.Button btnTerc;
        private System.Windows.Forms.Button btnQua;
        private System.Windows.Forms.Button btnPri;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
    }
}

