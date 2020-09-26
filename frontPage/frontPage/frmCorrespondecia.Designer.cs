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
            this.lblCc = new System.Windows.Forms.Label();
            this.lblCco = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblAnexos = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAnexos = new System.Windows.Forms.Button();
            this.file = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.file)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(233, 30);
            this.lblPara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para:";
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.Location = new System.Drawing.Point(244, 54);
            this.lblCc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(23, 13);
            this.lblCc.TabIndex = 1;
            this.lblCc.Text = "Cc:";
            // 
            // lblCco
            // 
            this.lblCco.AutoSize = true;
            this.lblCco.Location = new System.Drawing.Point(238, 74);
            this.lblCco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCco.Name = "lblCco";
            this.lblCco.Size = new System.Drawing.Size(29, 13);
            this.lblCco.TabIndex = 2;
            this.lblCco.Text = "Cco:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(280, 28);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(293, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(6, 128);
            this.lblAssunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 6;
            this.lblAssunto.Text = "Assunto:";
            // 
            // lblAnexos
            // 
            this.lblAnexos.AutoSize = true;
            this.lblAnexos.Location = new System.Drawing.Point(10, 157);
            this.lblAnexos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnexos.Name = "lblAnexos";
            this.lblAnexos.Size = new System.Drawing.Size(45, 13);
            this.lblAnexos.TabIndex = 7;
            this.lblAnexos.Text = "Anexos:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 128);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(505, 20);
            this.textBox3.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 235);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(505, 145);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(68, 157);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 56);
            this.listBox1.TabIndex = 12;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 11);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(195, 100);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnexos
            // 
            this.btnAnexos.Location = new System.Drawing.Point(437, 157);
            this.btnAnexos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnexos.Name = "btnAnexos";
            this.btnAnexos.Size = new System.Drawing.Size(135, 55);
            this.btnAnexos.TabIndex = 14;
            this.btnAnexos.Text = "Anexar";
            this.btnAnexos.UseVisualStyleBackColor = true;
            this.btnAnexos.Click += new System.EventHandler(this.btnAnexos_Click);
            // 
            // file
            // 
            this.file.EnableRaisingEvents = true;
            this.file.SynchronizingObject = this;
            // 
            // frmCorrespondecia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 393);
            this.Controls.Add(this.btnAnexos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblAnexos);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblCco);
            this.Controls.Add(this.lblCc);
            this.Controls.Add(this.lblPara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.Label lblCco;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblAnexos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAnexos;
        private System.IO.FileSystemWatcher file;
    }
}