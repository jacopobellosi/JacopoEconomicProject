using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prova_1_econmics
{
    public partial class Nuovo_progetto : Form
    {
        
        public Nuovo_progetto()
        {
            InitializeComponent();

        }

        static public bool carica = false;
        private void Nuovo_progetto_Load(object sender, EventArgs e)
        {
            if (carica)
            {
                carica_file();
                carica = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog salva = new SaveFileDialog();
            salva.Title = "scegli il file da aprire";
            salva.Filter = "JEP File|*.JEP|All Files|*.*";
            if (salva.ShowDialog() == DialogResult.OK)
            {
                StreamWriter scrivi = new StreamWriter(salva.FileName);

                scrivi.WriteLine("Costi Fissi:");

                foreach (object item in listBox1.Items)
                {
                    String riga = item.ToString();
                    const char V = '|';
                    String[] parti = riga.Split(V);

                    scrivi.WriteLine(riga);
                    //totale_costiFissi.Text = parti[0] + " +  " + parti[1];
                    //System.Threading.Thread.Sleep(1000);

                }
                scrivi.WriteLine("Costi Varibili:");

                foreach (object item in listBox2.Items)
                {
                    String riga = item.ToString();
                    const char V = '|';
                    String[] parti = riga.Split(V);



                    //System.Threading.Thread.Sleep(1000);
                    scrivi.WriteLine(riga);
                }
                scrivi.WriteLine("FINE");

                scrivi.Close();
            }
            salva.Dispose();
            
            Form1 f1 = new Form1(); // Instantiate a Form3 object.
            f1.Show();
            this.Close(); // closes the Form2 instance.
        }
        int i = 0;
        string[] nomi = new string[10];
        private void Salva_progetto_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Remove(listBox1.SelectedItem);
            aggiorna_costi_fissi();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && prezzo_numeric.Text != "")
            {
                listBox1.Items.Add(textBox1.Text + " | " + prezzo_numeric.Text);
                textBox1.Clear();
                textBox1.Focus();
                prezzo_numeric.Focus();
                prezzo_numeric.Value = 0;
                aggiorna_costi_fissi();
            }
            else
            {
                MessageBox.Show("Compilare TUTTI i campi!", "Errore", MessageBoxButtons.OK);
            }
        }
        public void aggiorna_costi_fissi()
        {
            Double costi_fissi = 0;
            foreach (object item in listBox1.Items)
            {
                String riga = item.ToString();
                const char V = '|';
                String[] parti = riga.Split(V);


                //totale_costiFissi.Text = parti[0] + " +  " + parti[1];
                //System.Threading.Thread.Sleep(1000);
                costi_fissi += Double.Parse(parti[1]);
            }
            totale_costiFissi.Text = costi_fissi.ToString();
        }
        public Double getCostiFissi()
        {
            Double costi_fissi = 0;
            foreach (object item in listBox1.Items)
            {
                String riga = item.ToString();
                const char V = '|';
                String[] parti = riga.Split(V);


                //totale_costiFissi.Text = parti[0] + " +  " + parti[1];
                //System.Threading.Thread.Sleep(1000);
                costi_fissi += Double.Parse(parti[1]);
            }
            return costi_fissi;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public Double percentuali_inserite()
        {
            Double valore = 100;

            foreach (object item in listBox2.Items)
            {
                String riga = item.ToString();
                const char V = '|';
                String[] parti = riga.Split(V);



                //System.Threading.Thread.Sleep(1000);
                valore -= Double.Parse(parti[3]);
            }


            return valore;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Double percentuale_massima = percentuali_inserite();
            if (nome_costo_varibile.Text != "" && prezzo_vendita_varibile.Text != "" && Percentuale_costo_fisso.Text != "" && costo_fisso_acquisto.Text != "")
            {
                if (percentuale_massima >= Double.Parse(Percentuale_costo_fisso.Text))
                {
                    if (Double.Parse(prezzo_vendita_varibile.Text) > Double.Parse(costo_fisso_acquisto.Text))
                    {
                        listBox2.Items.Add(nome_costo_varibile.Text + " | " + prezzo_vendita_varibile.Text + " | " + costo_fisso_acquisto.Text + " | " + Percentuale_costo_fisso.Text);
                        nome_costo_varibile.Clear();
                        textBox1.Focus();
                        prezzo_numeric.Focus();
                        prezzo_vendita_varibile.Value = 0;
                        Percentuale_costo_fisso.Value = 0;
                        costo_fisso_acquisto.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Non puoi vendere qualcosa a meno di quanto l'acquisti", "Errore di vendita", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Percentuale troppo alta, massimo 100!", "Errore di percentuale", MessageBoxButtons.OK);
                }



            }
            else
            {
                MessageBox.Show("Compilare TUTTI i campi!", "Errore", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            aggiorna_costi_fissi();
            Double margine = 0;
            Double MCUE = 0;
            Double breakeven = 0;
            Double passaggi = 0;
            Double prezzo_unitario = 0;
            Double prezzo_unitario_passaggio = 0;
            listBox3.Items.Clear();
            foreach (object item in listBox2.Items)
            {
                String riga = item.ToString();
                const char V = '|';
                String[] parti = riga.Split(V);

                margine = Double.Parse(parti[1]) - Double.Parse(parti[2]);

                passaggi = margine * (Double.Parse(parti[3]) / 100);
                //System.Threading.Thread.Sleep(1000);

                prezzo_unitario_passaggio = Double.Parse(parti[1]) * (Double.Parse(parti[3]) / 100);

                MCUE += passaggi;
                prezzo_unitario += prezzo_unitario_passaggio;


            }
            mcue.Text = System.Math.Round(MCUE, 2).ToString();

            breakeven = Double.Parse(totale_costiFissi.Text) / MCUE;

            valore_breakeven.Text = System.Math.Round(breakeven, 2).ToString() + "€";


            prezzo_unitario_valore.Text = System.Math.Round(prezzo_unitario, 2).ToString() + "€";
            Double valore_fatturato_be = breakeven * prezzo_unitario;
            valore_fatturato_BE.Text = System.Math.Round(valore_fatturato_be, 2).ToString() + "€";
            Double salvo_totale = 0;
            Double prezzo_vendita_totale = 0;
            Double totale_valore_percentuali = 0;
            groupBox3.Show();
            foreach (object item in listBox2.Items)
            {
                String riga = item.ToString();
                const char V = '|';
                String[] parti = riga.Split(V);



                listBox3.Show();
                label15.Show();
                label16.Show();
                buttone_grafico.Show();
                Double salvo = System.Math.Round(((Double.Parse(parti[3]) / 100)) * breakeven);
                Double prezzo_vendita = System.Math.Round(salvo * Double.Parse(parti[1]), 2);
                Double nuova_percentuale = System.Math.Round(prezzo_vendita / valore_fatturato_be, 2);
                listBox3.Items.Add(parti[0].ToString() + " | " + salvo.ToString() + " | " + prezzo_vendita.ToString() + " | " + (nuova_percentuale*100).ToString()+"%");
                totale_valore_percentuali += nuova_percentuale;
                salvo_totale += salvo;
                prezzo_vendita_totale += prezzo_vendita;

            }
            listBox3.Items.Add(" ");
            listBox3.Items.Add("TOTALE:");
            listBox3.Items.Add("        | " + salvo_totale.ToString() + " | " + System.Math.Round(prezzo_vendita_totale, 2).ToString() + " | " + totale_valore_percentuali+"00%");

            Grafico.CostiFissi = getCostiFissi();
            Grafico.NBE = breakeven;
            Grafico.MCUE = MCUE;
            Grafico.Costo_break = prezzo_unitario * breakeven;
        }

        public void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Grafico grafico = new Grafico();
            
            grafico.ShowDialog();
        }
        public void carica_file()
        {
            OpenFileDialog apri = new OpenFileDialog();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            nome_costo_varibile.Clear();
            textBox1.Focus();
            prezzo_numeric.Focus();
            prezzo_vendita_varibile.Value = 0;
            Percentuale_costo_fisso.Value = 0;
            costo_fisso_acquisto.Value = 0;
            textBox1.Clear();
            textBox1.Focus();
            prezzo_numeric.Focus();
            prezzo_numeric.Value = 0;

            apri.Title = "scegli il file da aprire";
            apri.Filter = "JEP File|*.JEP|All Files|*.*";
            if (apri.ShowDialog() == DialogResult.OK)
            {
                StreamReader leggi = new StreamReader(apri.FileName);
                String controllo = leggi.ReadLine();
                if (controllo == "Costi Fissi:")
                {
                    string letto = leggi.ReadLine();

                    while (letto != "Costi Varibili:")
                    {

                        listBox1.Items.Add(letto);
                        letto = leggi.ReadLine();
                        //System.Threading.Thread.Sleep(1000);
                    }
                    letto = leggi.ReadLine();
                    while (letto != "FINE")
                    {
                        listBox2.Items.Add(letto);

                        letto = leggi.ReadLine();
                    }
                    
                    string[] nome_file = apri.SafeFileName.Split('.');
                    this.Text = nome_file[0] + " - Analisi di Break-Even";
                }
                else
                {
                    MessageBox.Show("Il file selezionato non è compatibile ", "Errore: ", MessageBoxButtons.OK);
                }

                leggi.Close();
                aggiorna_costi_fissi();
            }

            apri.Dispose();
        
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            //SaveFileDialog salva = new SaveFileDialog();
            OpenFileDialog apri = new OpenFileDialog();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            nome_costo_varibile.Clear();
            textBox1.Focus();
            prezzo_numeric.Focus();
            prezzo_vendita_varibile.Value = 0;
            Percentuale_costo_fisso.Value = 0;
            costo_fisso_acquisto.Value = 0;
            textBox1.Clear();
            textBox1.Focus();
            prezzo_numeric.Focus();
            prezzo_numeric.Value = 0;

            apri.Title = "scegli il file da aprire";
            apri.Filter = "JEP File|*.JEP|All Files|*.*";
            if (apri.ShowDialog() == DialogResult.OK)
            {
                StreamReader leggi = new StreamReader(apri.FileName);
                String controllo = leggi.ReadLine();
                if (controllo == "Costi Fissi:")
                {
                    string letto = leggi.ReadLine();

                    while (letto != "Costi Varibili:")
                    {

                        listBox1.Items.Add(letto);
                        letto = leggi.ReadLine();
                        //System.Threading.Thread.Sleep(1000);
                    }
                    letto = leggi.ReadLine();
                    while (letto != "FINE")
                    {
                        listBox2.Items.Add(letto);

                        letto = leggi.ReadLine();
                    }

                }
                else
                {
                    MessageBox.Show("Il file selezionato non è compatibile ", "Errore: ", MessageBoxButtons.OK);
                }

                leggi.Close();
                aggiorna_costi_fissi();
            }

            apri.Dispose();
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
