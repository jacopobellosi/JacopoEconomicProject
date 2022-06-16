using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Prova_1_econmics
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void apri_altro(object obj)
        {
            Application.Run(new Nuovo_progetto());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nuovo_progetto.carica = true;
            this.Close();
            th = new Thread(apri_altro);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
            

            
            
        }

        private void Prova(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cambioi_colore_Click(object sender, EventArgs e)
        {
            
            //Nuovo_progetto f2 = new Nuovo_progetto();
            //f2.ShowDialog(); // Shows Form2
            //this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/jacopobellosi/JacopoEconomicsProject/");
            Process.Start(sInfo);
        }
    }
}
