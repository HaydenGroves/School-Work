using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApplication
{
    public partial class Form1 : Form
    {
        public static int Opacity;
        public static int r = 0;
        public static int b = 0;
        public static int g = 0;
        public static int inc = 1;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Maximum = 255;
            trackBar1.Minimum = 0;
            trackBar1.TickFrequency = 5;
            trackBar1.LargeChange = 3;
            trackBar1.SmallChange = 2;

            trackBar2.Maximum = 255;
            trackBar2.Minimum = 0;
            trackBar2.TickFrequency = 5;
            trackBar2.LargeChange = 3;
            trackBar2.SmallChange = 2;

            trackBar3.Maximum = 255;
            trackBar3.Minimum = 0;
            trackBar3.TickFrequency = 5;
            trackBar3.LargeChange = 3;
            trackBar3.SmallChange = 2;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          
            if (e.Button == System.Windows.Forms.MouseButtons.Left )
            {
                
                Random rnd = new Random();






                r = r + 3; g = g + 3; b = b + 3;
                

                    
                    if (r >= 255)
                    {
                    r = r % 1;
                    g = 50;
                    b = b % 1;
                    }

                    if (g >= 255)
                    {
                    r = r % 1;
                    g = g % 1;
                    b = 50;
                    }

                    if (b >= 255)
                    {
                    r = 50;
                    g = g % 1;
                    b = b % 1;
                } 
                System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(255, r, g, b));
                this.CreateGraphics().FillEllipse(brush, e.X, e.Y, 10, 10);


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.Opacity = Convert.ToInt32(textBox1.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            textBox2.Text = "" + trackBar1.Value;           
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
          
            textBox3.Text = "" + trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
       
            textBox4.Text = "" + trackBar3.Value;
        }
    }
}
