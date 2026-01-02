namespace Prova_1_econmics
{
    partial class Nuovo_progetto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuovo_progetto));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prezzo_numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Crea_Elemento = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totale_costiFissi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Percentuale_costo_fisso = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.costo_fisso_acquisto = new System.Windows.Forms.NumericUpDown();
            this.prezzo_vendita_varibile = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nome_costo_varibile = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valore_fatturato_BE = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.prezzo_unitario_valore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.valore_breakeven = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mcue = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttone_grafico = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prezzo_numeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Percentuale_costo_fisso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costo_fisso_acquisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prezzo_vendita_varibile)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1176, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salva ed Esci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(328, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 108);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserisci i Costi Fissi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prezzo_numeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Crea_Elemento);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(17, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costi fissi ( ANNO )";
            // 
            // prezzo_numeric
            // 
            this.prezzo_numeric.DecimalPlaces = 2;
            this.prezzo_numeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.prezzo_numeric.Location = new System.Drawing.Point(159, 38);
            this.prezzo_numeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.prezzo_numeric.Name = "prezzo_numeric";
            this.prezzo_numeric.Size = new System.Drawing.Size(120, 20);
            this.prezzo_numeric.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezzo costo ( x ANNO )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome costo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Crea_Elemento
            // 
            this.Crea_Elemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crea_Elemento.Location = new System.Drawing.Point(6, 93);
            this.Crea_Elemento.Name = "Crea_Elemento";
            this.Crea_Elemento.Size = new System.Drawing.Size(110, 51);
            this.Crea_Elemento.TabIndex = 1;
            this.Crea_Elemento.Text = "Crea Elemento";
            this.Crea_Elemento.UseVisualStyleBackColor = true;
            this.Crea_Elemento.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(179, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cancella Elemento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome costo |  Valore:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Totale costi fissi( € ANNO):";
            // 
            // totale_costiFissi
            // 
            this.totale_costiFissi.AutoSize = true;
            this.totale_costiFissi.Location = new System.Drawing.Point(465, 252);
            this.totale_costiFissi.Name = "totale_costiFissi";
            this.totale_costiFissi.Size = new System.Drawing.Size(0, 13);
            this.totale_costiFissi.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(970, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nome costo | Prezzo vendita | Costo fisso di acquisto | Percentuale";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Percentuale_costo_fisso);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.costo_fisso_acquisto);
            this.groupBox2.Controls.Add(this.prezzo_vendita_varibile);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nome_costo_varibile);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(616, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 219);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Costi Varibili";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Percentuale:";
            // 
            // Percentuale_costo_fisso
            // 
            this.Percentuale_costo_fisso.DecimalPlaces = 2;
            this.Percentuale_costo_fisso.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Percentuale_costo_fisso.Location = new System.Drawing.Point(6, 175);
            this.Percentuale_costo_fisso.Name = "Percentuale_costo_fisso";
            this.Percentuale_costo_fisso.Size = new System.Drawing.Size(120, 20);
            this.Percentuale_costo_fisso.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Costo fisso di acquisto:";
            // 
            // costo_fisso_acquisto
            // 
            this.costo_fisso_acquisto.DecimalPlaces = 2;
            this.costo_fisso_acquisto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.costo_fisso_acquisto.Location = new System.Drawing.Point(6, 133);
            this.costo_fisso_acquisto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.costo_fisso_acquisto.Name = "costo_fisso_acquisto";
            this.costo_fisso_acquisto.Size = new System.Drawing.Size(120, 20);
            this.costo_fisso_acquisto.TabIndex = 17;
            // 
            // prezzo_vendita_varibile
            // 
            this.prezzo_vendita_varibile.DecimalPlaces = 2;
            this.prezzo_vendita_varibile.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.prezzo_vendita_varibile.Location = new System.Drawing.Point(6, 83);
            this.prezzo_vendita_varibile.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.prezzo_vendita_varibile.Name = "prezzo_vendita_varibile";
            this.prezzo_vendita_varibile.Size = new System.Drawing.Size(120, 20);
            this.prezzo_vendita_varibile.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Prezzo vendita:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nome costo:";
            // 
            // nome_costo_varibile
            // 
            this.nome_costo_varibile.Location = new System.Drawing.Point(6, 37);
            this.nome_costo_varibile.Name = "nome_costo_varibile";
            this.nome_costo_varibile.Size = new System.Drawing.Size(129, 20);
            this.nome_costo_varibile.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(216, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 51);
            this.button3.TabIndex = 1;
            this.button3.Text = "Crea Elemento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(216, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 59);
            this.button4.TabIndex = 0;
            this.button4.Text = "Cancella elemento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(611, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Inserisci i Costi Varibili:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(970, 121);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(342, 121);
            this.listBox2.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(626, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 43);
            this.button5.TabIndex = 15;
            this.button5.Text = "Calcola il punto di Break-Even";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Margine contribuzione unitario equivalente (MCUE):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.valore_fatturato_BE);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.prezzo_unitario_valore);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.valore_breakeven);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.mcue);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(17, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 209);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Break-Even";
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // valore_fatturato_BE
            // 
            this.valore_fatturato_BE.AutoSize = true;
            this.valore_fatturato_BE.Location = new System.Drawing.Point(101, 122);
            this.valore_fatturato_BE.Name = "valore_fatturato_BE";
            this.valore_fatturato_BE.Size = new System.Drawing.Size(0, 13);
            this.valore_fatturato_BE.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Il fatturato in BE:";
            // 
            // prezzo_unitario_valore
            // 
            this.prezzo_unitario_valore.AutoSize = true;
            this.prezzo_unitario_valore.Location = new System.Drawing.Point(155, 94);
            this.prezzo_unitario_valore.Name = "prezzo_unitario_valore";
            this.prezzo_unitario_valore.Size = new System.Drawing.Size(0, 13);
            this.prezzo_unitario_valore.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Prezzo unitario equivalente:";
            // 
            // valore_breakeven
            // 
            this.valore_breakeven.AutoSize = true;
            this.valore_breakeven.Location = new System.Drawing.Point(173, 68);
            this.valore_breakeven.Name = "valore_breakeven";
            this.valore_breakeven.Size = new System.Drawing.Size(0, 13);
            this.valore_breakeven.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "NBE ( quanittà di break even) :";
            // 
            // mcue
            // 
            this.mcue.AutoSize = true;
            this.mcue.Location = new System.Drawing.Point(273, 36);
            this.mcue.Name = "mcue";
            this.mcue.Size = new System.Drawing.Size(0, 13);
            this.mcue.TabIndex = 17;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(664, 463);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(456, 134);
            this.listBox3.TabIndex = 18;
            this.listBox3.Visible = false;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(655, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Il fatturato in Break-Even:";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(667, 447);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(358, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Nome costo varibile | Quantità | Ricavi (fatturato) € | Incidenza sui ricavi (%)";
            this.label16.Visible = false;
            // 
            // buttone_grafico
            // 
            this.buttone_grafico.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttone_grafico.Location = new System.Drawing.Point(1165, 549);
            this.buttone_grafico.Name = "buttone_grafico";
            this.buttone_grafico.Size = new System.Drawing.Size(147, 86);
            this.buttone_grafico.TabIndex = 21;
            this.buttone_grafico.Text = "Visualizza grafico";
            this.buttone_grafico.UseVisualStyleBackColor = true;
            this.buttone_grafico.Visible = false;
            this.buttone_grafico.Click += new System.EventHandler(this.button6_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Carica da file";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Nuovo_progetto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1335, 672);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttone_grafico);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.totale_costiFissi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nuovo_progetto";
            this.Text = "Nuovo Progetto - Analisi di Break-Even";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Nuovo_progetto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prezzo_numeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Percentuale_costo_fisso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costo_fisso_acquisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prezzo_vendita_varibile)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Crea_Elemento;
        private System.Windows.Forms.NumericUpDown prezzo_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totale_costiFissi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown prezzo_vendita_varibile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nome_costo_varibile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Percentuale_costo_fisso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown costo_fisso_acquisto;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label mcue;
        private System.Windows.Forms.Label valore_breakeven;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label prezzo_unitario_valore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label valore_fatturato_BE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttone_grafico;
        private System.Windows.Forms.Button button6;
    }
}