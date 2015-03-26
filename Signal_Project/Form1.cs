using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal_Project
{
    public partial class Sgnal_Project : Form
    {
        public Sgnal_Project()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0.0;
            try
            {
                double b = Convert.ToDouble(txtB.Text);
                double w = Convert.ToDouble(txtW.Text);

                chart1.Series["X(w)"].Points.Clear();

                for (double i = -w + 1; i < w; i += 1)
                {
                    y = 1 / Math.Sqrt(i * i + b * b);

                    chart1.Series["X(w)"].Points.AddXY(i, y);

                }
                chart1.Series[0].BorderWidth = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void txtCalculate2_Click(object sender, EventArgs e)
        {
            double y = 0.0;

            try
            {
                double t1 = Convert.ToDouble(txtT1.Text);
                double w = Convert.ToDouble(txtW2.Text);

                chart2.Series["X(w)"].Points.Clear();

                for (double i = -w + 1; i < w; i += 1)
                {
                    y = (2 * Math.Sin(i * t1)) / i;


                    chart2.Series["X(w)"].Points.AddXY(i, y);

                }
                chart2.Series[0].BorderWidth = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

      
    }
}
