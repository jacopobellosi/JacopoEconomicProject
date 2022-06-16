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
    public partial class Progetto_importato : Form
    {
        public Progetto_importato()
        {
            InitializeComponent();
        }

        int i = 0;
        string[] nomi = new string[10];
        private void Bottone_importa_dati_Click(object sender, EventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();
            apri.Title = "scegli il file da aprire";
            apri.Filter = "Text File|*.txt|All Files|*.*";

            if (apri.ShowDialog() == DialogResult.OK)
            {
                StreamReader leggi = new StreamReader(apri.FileName);
                string letto = leggi.ReadLine(); //sto leggendo la prima riga del file
                while (letto != null)
                {
                    listBox1.Items.Add(letto);
                    nomi[i] = letto;
                    i++;
                    letto = leggi.ReadLine();
                }
                leggi.Close();
            }
            apri.Dispose();
        }
    }
}
