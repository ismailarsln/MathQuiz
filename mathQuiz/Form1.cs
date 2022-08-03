using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mathQuiz
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int counter = 60; //determines how many seconds it will take..
        Random rd = new Random();

        private int[] sayilar = new int[4];

        private void Start()
        {

            int sayi11 = rd.Next(0, 51);
            int sayi12 = rd.Next(0, 51);
            int sayi21 = rd.Next(0, 51);
            int sayi22 = rd.Next(0, 51);
            int sayi31 = rd.Next(0, 51);
            int sayi32 = rd.Next(0, 20);
            int sayi41 = rd.Next(0, 51);
            int sayi42 = rd.Next(0, 51);

            int sayi13 = sayi11 + sayi12;
            int sayi23 = sayi21 - sayi22;
            int sayi33 = sayi31 * sayi32;
            int sayi43 = sayi41 / sayi42;

            say11.Text = sayi11.ToString();
            say12.Text = sayi12.ToString();
            say13.Text = sayi13.ToString();
            say21.Text = sayi21.ToString();
            say22.Text = sayi22.ToString();
            say23.Text = sayi23.ToString();
            say31.Text = sayi31.ToString();
            say32.Text = sayi32.ToString();
            say33.Text = sayi33.ToString();
            say41.Text = sayi41.ToString();
            say42.Text = sayi42.ToString();
            say43.Text = sayi43.ToString();

            sayilar[0] = sayi13;
            sayilar[1] = sayi23;
            sayilar[2] = sayi33;
            sayilar[3] = sayi43;
        }
        
        public void button1_Click(object sender, EventArgs e) //start button..
        {
            timer1.Start();
            button1.Text = "Quiz Started!";
            button1.Enabled = false;
            button2.Enabled = Enabled;

            Start();
        }

        private void timer1_Tick(object sender, EventArgs e) //timer code..
        {
            counter--;
            label1.Text = "Time Left: " + counter.ToString();
            if(counter == 0) 
            { 
                timer1.Stop();
                button1.Text = "Game Over!";
                MessageBox.Show("TIME IS UP!", ":(");
               // Close();
            }
        }

        public void button2_Click(object sender, EventArgs e) //check it button code..
        {

            int son1_1 = Convert.ToInt32(son1.Text);
            int son2_2 = Convert.ToInt32(son2.Text);
            int son3_3 = Convert.ToInt32(son3.Text);
            int son4_4 = Convert.ToInt32(son4.Text);

            say13.Visible = Enabled;
            say23.Visible = Enabled;
            say33.Visible = Enabled;
            say43.Visible = Enabled;
            trueA.Visible = Enabled;

            timer1.Stop();
            button1.Enabled = false;
            button2.Enabled = false;

            if (sayilar[0] == son1_1 && sayilar[1] == son2_2
                && sayilar[2] == son3_3 && sayilar[3] == son4_4)
            {
                MessageBox.Show("TRUE!", ":)");
            }
            else
            {
                MessageBox.Show("FALSE!", ":(");
            }
            button3.Visible = Enabled;
        }

        private void button3_Click(object sender, EventArgs e) //restart button..
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}