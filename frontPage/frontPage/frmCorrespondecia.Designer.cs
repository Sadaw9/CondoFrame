namespace frontPage
{
    partial class frmCorrespondecia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorrespondecia));
            this.lblPara = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.MaskedTextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtAss = new System.Windows.Forms.TextBox();
            this.txtMSG = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.file = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.txtSen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.file)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(9, 31);
            this.lblPara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para:";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(75, 28);
            this.txtDest.Margin = new System.Windows.Forms.Padding(2);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(293, 20);
            this.txtDest.TabIndex = 3;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(11, 179);
            this.lblAssunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 6;
            this.lblAssunto.Text = "Assunto:";
            // 
            // txtAss
            // 
            this.txtAss.Location = new System.Drawing.Point(75, 179);
            this.txtAss.Margin = new System.Windows.Forms.Padding(2);
            this.txtAss.Name = "txtAss";
            this.txtAss.Size = new System.Drawing.Size(498, 20);
            this.txtAss.TabIndex = 8;
            // 
            // txtMSG
            // 
            this.txtMSG.Location = new System.Drawing.Point(75, 226);
            this.txtMSG.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSG.Name = "txtMSG";
            this.txtMSG.Size = new System.Drawing.Size(498, 145);
            this.txtMSG.TabIndex = 10;
            this.txtMSG.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(378, 36);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(195, 100);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // file
            // 
            this.file.EnableRaisingEvents = true;
            this.file.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Senha:";
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(75, 76);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(293, 20);
            this.txtRem.TabIndex = 16;
            // 
            // txtSen
            // 
            this.txtSen.Location = new System.Drawing.Point(75, 116);
            this.txtSen.Name = "txtSen";
            this.txtSen.Size = new System.Drawing.Size(293, 20);
            this.txtSen.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mensagem:";
            // 
            // frmCorrespondecia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSen);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMSG);
            this.Controls.Add(this.txtAss);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.lblPara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCorrespondecia";
            this.Text = "Correspondência";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCorrespondecia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.MaskedTextBox txtDest;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtAss;
        private System.Windows.Forms.RichTextBox txtMSG;
        private System.Windows.Forms.Button btnEnviar;
        private System.IO.FileSystemWatcher file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSen;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}