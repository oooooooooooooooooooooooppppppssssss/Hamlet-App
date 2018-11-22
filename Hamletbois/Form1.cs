using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamletbois
{
    public partial class Form1 : Form
    {
        Font Normal = new Font("Arial", 21, FontStyle.Bold);
        ProgressBar pBar = new ProgressBar();
      
        public Form1()
        {
            Controls.Add(pBar);
            pBar.Name = "progressBar1";
            pBar.Dock = DockStyle.Bottom;
            pBar.Minimum = 0;
            pBar.Maximum = 100;
            pBar.Value = 0;
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            pBar.Value = 20;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pBar.Value = 80;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
 
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pBar.Value = 100;
            MessageBox.Show("Congratulations! You've finished Hamlet!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pBar.Value = 40;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pBar.Value = 60;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 f18 = new Form18();
            f18.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 f14 = new Form14();
            f14.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 f16 = new Form16();
            f16.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 f17 = new Form17();
            f17.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 f19 = new Form19();
            f19.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form20 f20 = new Form20();
            f20.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form21 f21 = new Form21();
            f21.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form22 f22 = new Form22();
            f22.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
