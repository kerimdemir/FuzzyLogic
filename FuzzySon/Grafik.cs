using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace FuzzySon
{
    public partial class Grafik : Form
    {
        double sicaklik;
        double seviye;

  

        public Grafik()
        {
            InitializeComponent();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            CikisGrafik cikis = new CikisGrafik();
            cikis.label1.Text = label1.Text;
            
           
            cikis.Show();
            this.Close();

        }
        public void SicaklikGrafik()
        {
            GraphPane mypane = new GraphPane();
            //point pair list
            PointPairList listPointsOne = new PointPairList();
            PointPairList listPointsTwo = new PointPairList();
            //line item
            LineItem myCurve1, myCurve2, myCurve3, myCurve4, myCurve5,myCurve6;
            //set the pane
            mypane = zedGraphSicaklik.GraphPane;



            mypane.Title.IsVisible = true; // show the visibility of the title

            //set the X axis

            mypane.XAxis.Title.Text = "SICAKLIK";
            //  mypane.XAxis.MajorGrid.IsVisible = true;
            mypane.XAxis.MinorGrid.IsVisible = true;
            mypane.XAxis.Scale.MajorUnit = DateUnit.Minute;
            mypane.XAxis.Scale.MinorUnit = DateUnit.Minute;
            mypane.XAxis.Title.IsVisible = true;        //show the visibility of x axis title.
            mypane.XAxis.Scale.Min = 0;
            mypane.XAxis.Scale.Max = 120;
            mypane.XAxis.Scale.MajorStep = 20;
            mypane.XAxis.MinorTic.Size = 1;

            //set the Y axis
            mypane.YAxis.Type = AxisType.Linear;
            mypane.YAxis.Title.Text = "Üyelik Derecesi";
            mypane.YAxis.Scale.Format = @"0.0";
            mypane.YAxis.Title.IsVisible = true;
            // mypane.YAxis.MajorGrid.IsVisible = true;
            mypane.YAxis.Scale.Min = 0;
            mypane.YAxis.Scale.Max = 1;
            mypane.YAxis.Scale.MajorStep = 0.1;


            //Sıcaklık
            double[] y1 = { 1.0, 1.0, 0.0 };
            double[] x1 = { 0.0, 10, 20 };
            double[] y2 = { 0.0, 1.0, 0.0 };
            double[] x2 = { 15, 27.5, 40 };
            double[] y3 = { 0.0, 1.0, 0.0 };
            double[] x3 = { 30, 47.5, 60 };
            double[] y4 = { 0.0, 1.0, 0.0 };
            double[] x4 = { 55, 67.5, 80 };
            double[] y5 = { 0.0, 1.0, 1.0 };
            double[] x5 = { 75, 87.5, 100 };

            double[] y6 = { 1.0, 0.0, 0.0 };
            double[] x6 = { sicaklik, sicaklik, sicaklik };


            //add curve to the pane
            myCurve2 = mypane.AddCurve("Çok Az", x1, y1, Color.Blue, SymbolType.None);
            myCurve1 = mypane.AddCurve("Az", x2, y2, Color.Aqua, SymbolType.None);
            myCurve3 = mypane.AddCurve("Orta", x3, y3, Color.Green, SymbolType.None);
            myCurve4 = mypane.AddCurve("Çok", x4, y4, Color.Orange, SymbolType.None);
            myCurve5 = mypane.AddCurve("Aşırı Çok", x5, y5, Color.Magenta, SymbolType.None);
            myCurve6 = mypane.AddCurve("Sıcaklık", x6, y6, Color.Black, SymbolType.None);



            myCurve1.Line.Width = 2.0F;

            //function that makesure the graph updated automatically
            zedGraphSicaklik.AxisChange();
            zedGraphSicaklik.Invalidate();
            zedGraphSicaklik.Refresh();
        }

        public void SeviyeGrafik()
        {
            GraphPane mypane = new GraphPane();
            //point pair list
            PointPairList listPointsOne = new PointPairList();
            PointPairList listPointsTwo = new PointPairList();
            //line item
            LineItem myCurve1, myCurve2, myCurve3, myCurve4, myCurve5,myCurve6;
            //set the pane
            mypane = zedGraphSeviye.GraphPane;



            mypane.Title.IsVisible = true; // show the visibility of the title

            //set the X axis

            mypane.XAxis.Title.Text = "SEVİYE";
            //  mypane.XAxis.MajorGrid.IsVisible = true;
            mypane.XAxis.MinorGrid.IsVisible = true;
            mypane.XAxis.Scale.MajorUnit = DateUnit.Minute;
            mypane.XAxis.Scale.MinorUnit = DateUnit.Minute;
            mypane.XAxis.Title.IsVisible = true;        //show the visibility of x axis title.
            mypane.XAxis.Scale.Min = 0;
            mypane.XAxis.Scale.Max = 6;
            mypane.XAxis.Scale.MajorStep = 1;
            mypane.XAxis.MinorTic.Size = 1;

            //set the Y axis
            mypane.YAxis.Type = AxisType.Linear;
            mypane.YAxis.Title.Text = "Üyelik Derecesi";
            mypane.YAxis.Scale.Format = @"0.0";
            mypane.YAxis.Title.IsVisible = true;
            // mypane.YAxis.MajorGrid.IsVisible = true;
            mypane.YAxis.Scale.Min = 0;
            mypane.YAxis.Scale.Max = 1;
            mypane.YAxis.Scale.MajorStep = 0.1;


            //seviye
            double[] y1 = { 1.0, 1.0, 0.0 };
            double[] x1 = { 0.0, 0.5, 1.0 };
            double[] y2 = { 0.0, 1.0, 0.0 };
            double[] x2 = { 0.5, 1.25, 2.0 };
            double[] y3 = { 0.0, 1.0, 0.0 };
            double[] x3 = { 1.5, 2.5, 3.5 };
            double[] y4 = { 0.0, 1.0, 0.0 };
            double[] x4 = { 3.0, 3.75, 4.5 };
            double[] y5 = { 0.0, 1.0, 1.0 };
            double[] x5 = { 4.0, 4.5, 5.0 };
            double[] y6 = { 1.0, 0.0, 0.0 };
            double[] x6 = { seviye, seviye, seviye };


            //add curve to the pane
            myCurve2 = mypane.AddCurve("Çok Az", x1, y1, Color.Blue, SymbolType.None);
            myCurve1 = mypane.AddCurve("Az", x2, y2, Color.Aqua, SymbolType.None);
            myCurve3 = mypane.AddCurve("Orta", x3, y3, Color.Green, SymbolType.None);
            myCurve4 = mypane.AddCurve("Çok", x4, y4, Color.Orange, SymbolType.None);
            myCurve5 = mypane.AddCurve("Aşırı Çok", x5, y5, Color.Magenta, SymbolType.None);
            myCurve6 = mypane.AddCurve("Seviye", x6, y6, Color.Black, SymbolType.None);

            myCurve1.Line.Width = 2.0F;

            //function that makesure the graph updated automatically
            zedGraphSeviye.AxisChange();
            zedGraphSeviye.Invalidate();
            zedGraphSeviye.Refresh();
        }
        public void RezistansGrafik()
        {
        }

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
             sicaklik = Double.Parse(lblSicaklikDegeri.Text);
               seviye = Double.Parse(lblSeviyeDeger.Text);

            
            SicaklikGrafik();
            SeviyeGrafik();
            RezistansGrafik();


        }
    }
}