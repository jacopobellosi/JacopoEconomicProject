using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_1_econmics
{
    public partial class Grafico : Form
    {
        public Grafico()
        {
            InitializeComponent();
            //carica_grafico();
        }

        static public Double CostiFissi=0;
        static public Double NBE = 0;
        static public Double Costo_break = 0;
        static public Double MCUE = 0;
        static void prendo_dati(Double CF)
        {
            CostiFissi = CF;
        }

        public void carica_grafico()
        {
            
        }
        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            var coso = chart1.ChartAreas[0];

            coso.AxisX.Minimum = 0;
            coso.AxisX.Maximum = MCUE*4;

            coso.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            coso.AxisY.Minimum = 0;
            coso.AxisY.Maximum = CostiFissi*8;



            chart1.Series.Clear();

            chart1.Series.Add("Costi Fissi");
            chart1.Series["Costi Fissi"].Color = Color.Blue;
            chart1.Series["Costi Fissi"].BorderWidth = 1;
            chart1.Series["Costi Fissi"].Legend = "Legend1";
            chart1.Series["Costi Fissi"].ChartArea = "ChartArea1";
            chart1.Series["Costi Fissi"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series["Costi Fissi"].Points.AddXY(0, CostiFissi);
            chart1.Series["Costi Fissi"].Points.AddXY(coso.AxisX.Maximum, CostiFissi);

            chart1.Series.Add("Costi Totali");
            chart1.Series["Costi Totali"].Color = Color.Green;
            chart1.Series["Costi Totali"].Legend = "Legend1";
            chart1.Series["Costi Totali"].BorderWidth = 3;
            chart1.Series["Costi Totali"].ChartArea = "ChartArea1";
            chart1.Series["Costi Totali"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series["Costi Totali"].Points.AddXY(0, CostiFissi);
            chart1.Series["Costi Totali"].Points.AddXY(MCUE, Costo_break);
            chart1.Series["Costi Totali"].Points.AddXY(MCUE*2, (Costo_break*2) - CostiFissi);

            chart1.Series.Add("Ricavi Totale");
            chart1.Series["Ricavi Totale"].Color = Color.Red;
            chart1.Series["Ricavi Totale"].BorderWidth = 3;
            chart1.Series["Ricavi Totale"].Legend = "Legend1";
            chart1.Series["Ricavi Totale"].ChartArea = "ChartArea1";
            chart1.Series["Ricavi Totale"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series["Ricavi Totale"].Points.AddXY(0, 0);
            chart1.Series["Ricavi Totale"].Points.AddXY(MCUE, Costo_break);
            chart1.Series["Ricavi Totale"].Points.AddXY(MCUE*2, Costo_break*2);
            
            chart1.Series.Add("NBE");
            chart1.Series["NBE"].Color = Color.Yellow;
            chart1.Series["NBE"].Legend = "Legend1";
            chart1.Series["Ricavi Totale"].BorderWidth = 4;
            chart1.Series["NBE"].ChartArea = "ChartArea1";
            chart1.Series["NBE"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series["NBE"].Points.AddXY(MCUE, Costo_break);

            coordinate_break.Text = "( " + System.Math.Round(NBE,2).ToString() + " , " + System.Math.Round(Costo_break,2).ToString() + " )";
        }
    }
}
