using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmUtilities_18
{
    public partial class Übercs : Form
    {
        public Übercs()
        {
            InitializeComponent();
            this.label1.Text= "FilmUtilities'18 Version "+Form1.ver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
