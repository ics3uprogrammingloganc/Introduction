/*
 * Created by: Logan Canttin
 * Created on: February 6, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - HelloWorldInternational
 * This program displays hello world 4 languages. The user can select the language with radio buttons
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

namespace InternationalHelloWorldLogan
{
    public partial class FrmHelloWorldInternational : Form
    {
        public FrmHelloWorldInternational()
        {
            InitializeComponent();
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello, World!";
        }

        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Bonjour, Monde!";
        }

        private void radSpanish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hola, Mundo!";
        }

        private void radItalian_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Ciao, Mondo!";
        }
    }
}
