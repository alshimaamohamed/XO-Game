using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryxo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           var F1 = new Form3();
      F1.Closed += (s, args) => this.Close();
      progressBar1.Minimum = 0;
      progressBar1.Maximum = 200;

      for (int i = 0; i <= 200; i++)
      {
          progressBar1.Value = i;
      }
            F1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a  simple game  in which  Win  is achieved when\nthree consecutive blocks in a Row, Column or Diagonal\nare occupied before the opponent does the same.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Alaa , Al Shimaa , Sara & Amira ");
        }


    }
}
