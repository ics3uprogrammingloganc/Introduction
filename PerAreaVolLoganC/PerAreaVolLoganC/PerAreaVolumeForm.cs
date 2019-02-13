/*
 * Created by: Logan Cantin
 * Created on: February 6th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - PerAreaVolume
 * This program calculates and displays Perimeter, Area, and Volume
 * and displays it for the user
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PerAreaVolLoganC
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        //Rounding function that reduces the number of decimals in a double
        private double round(double number, int decimalPlaces)
        {
            number *= Math.Pow(10, decimalPlaces);
            number = Math.Round(number);
            number /= Math.Pow(10, decimalPlaces);
            return number;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            //Calculating perimeter of a 5cm by 8cm rectangle, and updating the label with the answer
            lblPerimeter.Text = "Perimeter = " + Convert.ToString(2 * (5 + 8)) + "cm";
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            //Calculating the area of a circle with radius 7, and updating the label with the rounded answer
            double area = Math.PI * Math.Pow(7, 2);
            lblArea.Text = "Area = " + round(area, 2).ToString() + "cm²";
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            // Calculating the volume of a sphere with radius 4cm, rounding the answer and updating the label
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(4, 3);
            lblVolume.Text = "Volume = " + round(volume, 3).ToString() + "cm³";
        }
    }
}
