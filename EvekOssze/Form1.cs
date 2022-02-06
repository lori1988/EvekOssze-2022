using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> ev = new List<int>() {1980,1981,1982,1983,1984,1985,1986,1987,1988,1989,1990,1991,1992,1993,1994,1995,
                1996,1997,1998,1999,2000,2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022};
        List<int> evErtek = new List<int> {1,1,1,1,1,1,1,1,2,2,2,2,2,4,4,4,4,4,8,8,8,8,8,16,16,
                16,16,16,33,33,33,33,33,65,65,65,65,65,130,130,130,130,130};
        List<int> temeto = new List<int> {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,20,20};

        private void button1_Click(object sender, EventArgs e)
        {
            int kezd = 0, veg = 0, kezdidx = 0, vegidx = 0, szemely = 0;
            
            bool joszemely = Int32.TryParse(textBox3.Text, out szemely);
            if (!joszemely)
            {
                MessageBox.Show("Kérem adja meg a személyek számát!");
                return;
            }
            bool jokezd = Int32.TryParse(textBox1.Text, out kezd);
            if (!jokezd)
            {
                MessageBox.Show("Hibás számformátum !", "Kezdő év hiba !");
                return;
            }
            if ((kezd < 1980) || (kezd > 2022))
            {
                MessageBox.Show("Az év 1980 - 2022 között lehet !", "Kezdő év hiba !");
                return;
            }
            bool joveg = Int32.TryParse(textBox2.Text, out veg);
            if (!joveg)
            {
                MessageBox.Show("Hibás számformátum !", "Utolsó év hiba !");
                return;
            }
            if ((veg < 1980) || (veg > 2022))
            {
                MessageBox.Show("Az év 1980 - 2022 között lehet !", "Utolsó év hiba !");
                return;
            }
            if (veg < kezd)
            {
                MessageBox.Show("Nehogymá' visszafelé számoljak !", "Év magadás hiba !");
                return;
            }
            kezdidx = ev.IndexOf(kezd);
            vegidx = ev.IndexOf(veg);
            double osszeg = 0;
            for (int i = kezdidx; i <= vegidx; i++) osszeg += evErtek[i] * szemely;                     
            textBox4.Text = osszeg.ToString("0.##");

            double tem_gond = 0;
            for (int i = kezdidx; i <= vegidx; i++) tem_gond += temeto[i] * szemely;
            textBox5.Text = tem_gond.ToString("0.##");

            double osszeg_vegleges = 0;
            osszeg_vegleges = osszeg + tem_gond;
            textBox6.Text = osszeg_vegleges.ToString("0.##");







            // MessageBox.Show("Az összeg " + szemely + " személyre " + textBox1.Text + "-" + textBox2.Text +
             //   " között: " + osszeg.ToString("0.##") + " ron", "Eredmény !");
       
           // MessageBox.Show("Az összeg: " + osszeg.ToString("0.##") + " Ron", "Eredmény !");


        }
 
     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
