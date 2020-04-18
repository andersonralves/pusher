namespace Client
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbContratados = new System.Windows.Forms.ListBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lsbDemitidos = new System.Windows.Forms.ListBox();
            this.btnOpenServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contratados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Demitidos";
            // 
            // lsbContratados
            // 
            this.lsbContratados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbContratados.FormattingEnabled = true;
            this.lsbContratados.ItemHeight = 18;
            this.lsbContratados.Location = new System.Drawing.Point(16, 38);
            this.lsbContratados.Name = "lsbContratados";
            this.lsbContratados.Size = new System.Drawing.Size(177, 166);
            this.lsbContratados.TabIndex = 4;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEncerrar.Location = new System.Drawing.Point(303, 221);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(104, 42);
            this.btnEncerrar.TabIndex = 5;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lsbDemitidos
            // 
            this.lsbDemitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDemitidos.FormattingEnabled = true;
            this.lsbDemitidos.ItemHeight = 18;
            this.lsbDemitidos.Location = new System.Drawing.Point(230, 38);
            this.lsbDemitidos.Name = "lsbDemitidos";
            this.lsbDemitidos.Size = new System.Drawing.Size(177, 166);
            this.lsbDemitidos.TabIndex = 6;
            // 
            // btnOpenServer
            // 
            this.btnOpenServer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenServer.Location = new System.Drawing.Point(12, 227);
            this.btnOpenServer.Name = "btnOpenServer";
            this.btnOpenServer.Size = new System.Drawing.Size(118, 31);
            this.btnOpenServer.TabIndex = 7;
            this.btnOpenServer.Text = "SERVER";
            this.btnOpenServer.UseVisualStyleBackColor = false;
            this.btnOpenServer.Click += new System.EventHandler(this.btnOpenServer_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 275);
            this.Controls.Add(this.btnOpenServer);
            this.Controls.Add(this.lsbDemitidos);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lsbContratados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Pusher Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbContratados;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.ListBox lsbDemitidos;
        private System.Windows.Forms.Button btnOpenServer;
    }
}

