using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class Form1 : Form
    {
        public int brojac = 0;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = imageList1.Images[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            brojac++;
            pictureBox1.Image = imageList1.Images[brojac % 2];
        }
    }
}
