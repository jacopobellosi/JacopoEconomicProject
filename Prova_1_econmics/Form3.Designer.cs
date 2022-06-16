namespace Prova_1_econmics
{
    partial class Progetto_importato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progetto_importato));
            this.Bottone_importa_dati = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Bottone_importa_dati
            // 
            this.Bottone_importa_dati.Location = new System.Drawing.Point(12, 12);
            this.Bottone_importa_dati.Name = "Bottone_importa_dati";
            this.Bottone_importa_dati.Size = new System.Drawing.Size(75, 23);
            this.Bottone_importa_dati.TabIndex = 0;
            this.Bottone_importa_dati.Text = "Importa dati";
            this.Bottone_importa_dati.UseVisualStyleBackColor = true;
            this.Bottone_importa_dati.Click += new System.EventHandler(this.Bottone_importa_dati_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(224, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(471, 95);
            this.listBox1.TabIndex = 1;
            // 
            // Progetto_importato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 539);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Bottone_importa_dati);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Progetto_importato";
            this.Text = "Calcola Break-even";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bottone_importa_dati;
        private System.Windows.Forms.ListBox listBox1;
    }
}