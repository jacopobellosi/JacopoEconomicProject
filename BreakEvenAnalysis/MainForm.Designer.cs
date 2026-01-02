namespace Prova_1_econmics
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nome_benvenuto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nuovo_progetto = new System.Windows.Forms.Button();
            this.bottone_Esci = new System.Windows.Forms.Button();
            this.bottone_github = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome_benvenuto
            // 
            this.nome_benvenuto.AutoSize = true;
            this.nome_benvenuto.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_benvenuto.Location = new System.Drawing.Point(401, 32);
            this.nome_benvenuto.Name = "nome_benvenuto";
            this.nome_benvenuto.Size = new System.Drawing.Size(272, 50);
            this.nome_benvenuto.TabIndex = 0;
            this.nome_benvenuto.Text = "BENVENUTO!";
            this.nome_benvenuto.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Api un progetto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.TextChanged += new System.EventHandler(this.Prova);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nuovo_progetto
            // 
            this.nuovo_progetto.Location = new System.Drawing.Point(430, 158);
            this.nuovo_progetto.Name = "nuovo_progetto";
            this.nuovo_progetto.Size = new System.Drawing.Size(219, 27);
            this.nuovo_progetto.TabIndex = 3;
            this.nuovo_progetto.Text = "Crea un nuovo progetto";
            this.nuovo_progetto.UseVisualStyleBackColor = true;
            this.nuovo_progetto.Click += new System.EventHandler(this.Cambioi_colore_Click);
            // 
            // bottone_Esci
            // 
            this.bottone_Esci.Location = new System.Drawing.Point(430, 470);
            this.bottone_Esci.Name = "bottone_Esci";
            this.bottone_Esci.Size = new System.Drawing.Size(219, 23);
            this.bottone_Esci.TabIndex = 4;
            this.bottone_Esci.Text = "Esci";
            this.bottone_Esci.UseVisualStyleBackColor = true;
            this.bottone_Esci.Click += new System.EventHandler(this.button2_Click);
            // 
            // bottone_github
            // 
            this.bottone_github.Location = new System.Drawing.Point(430, 408);
            this.bottone_github.Name = "bottone_github";
            this.bottone_github.Size = new System.Drawing.Size(219, 23);
            this.bottone_github.TabIndex = 5;
            this.bottone_github.Text = "Visualizza crediti/codice";
            this.bottone_github.UseVisualStyleBackColor = true;
            this.bottone_github.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 541);
            this.Controls.Add(this.bottone_github);
            this.Controls.Add(this.bottone_Esci);
            this.Controls.Add(this.nuovo_progetto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nome_benvenuto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Analisi Break-Even";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome_benvenuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nuovo_progetto;
        private System.Windows.Forms.Button bottone_Esci;
        private System.Windows.Forms.Button bottone_github;
    }
}

