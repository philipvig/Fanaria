using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fanaria
{
    public partial class Form1 : Form

    {
        Point initialposition2;
        Point initialposition3;
        Point initialposition1;
        Point initialposition12;
        Point initialposition13;
        Point initialposition14;
        public Form1()
        {
            InitializeComponent();
            
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            initialposition2 = pictureBox2.Location;
            initialposition3 = pictureBox3.Location;
            initialposition1 = pictureBox1.Location;
            initialposition12 = pictureBox12.Location;
            initialposition13 = pictureBox13.Location;
            initialposition14 = pictureBox14.Location;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox12.Refresh();
            pictureBox13.Refresh();
            pictureBox14.Refresh();
            pictureBox12.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox12.Refresh();
            pictureBox13.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox13.Refresh();
            pictureBox14.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox14.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            
            if (pictureBox3.Location.X >= 450)
                pictureBox3.Location = initialposition3;
            if (pictureBox2.Location.X >= 450)
                pictureBox2.Location = initialposition2;
            if (pictureBox1.Location.X >= 450)
                pictureBox1.Location = initialposition1;
            
                if (pictureBox3.Location.X <= 33 & pictureBox7.Visible)
                {
                    pictureBox3.Left = 0;
                }else if(pictureBox3.Location.X<=33 & pictureBox6.Visible)
            {
                pictureBox3.Left += 1;
            }
            else pictureBox3.Left += 2;
                if (pictureBox1.Location.X <= 33 & pictureBox7.Visible)
                {
                    pictureBox1.Left = 0;
                }else if (pictureBox1.Location.X<=33& pictureBox6.Visible)
            {
                pictureBox1.Left += 1;
            }
            else pictureBox1.Left += 2;
            if (pictureBox2.Location.X <= 33 & pictureBox7.Visible)
                {
                    pictureBox2.Left = 0;
                }else if (pictureBox2.Location.X<=33 & pictureBox6.Visible)
            {
                pictureBox2.Left += 1;
            }
            else pictureBox2.Left += 2;

            if (pictureBox12.Location.Y <= 5)
                pictureBox12.Location = initialposition12;
            if (pictureBox13.Location.Y <= 5)
                pictureBox13.Location = initialposition13;
            if (pictureBox14.Location.Y <= 5)
                pictureBox14.Location = initialposition14;


            if (pictureBox12.Location.Y >= 507 & pictureBox11.Visible)
            {
                pictureBox12.Top = 0;
            }
            else if (pictureBox12.Location.Y >= 507 & pictureBox10.Visible)
            {
                pictureBox12.Top += -1;
            }
            else pictureBox12.Top += -2;
            if (pictureBox13.Location.Y >= 507 & pictureBox11.Visible)
            {
                pictureBox1.Top = 0;
            }
            else if (pictureBox13.Location.Y >= 507 & pictureBox10.Visible)
            {
                pictureBox13.Top += -1;
            }
            else pictureBox13.Top += -2;
            if (pictureBox14.Location.Y >= 507 & pictureBox10.Visible)
            {
                pictureBox14.Top = 0;
            }
            else if (pictureBox14.Location.X >= 507 & pictureBox11.Visible)
            {
                pictureBox14.Top += -1;
            }
            else pictureBox14.Top += -2;







        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            
                
                

                
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox5.Visible)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                
                pictureBox11.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
            }
            else if (pictureBox6.Visible)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox5.Visible = false;
                
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
            }
            else
            {
                pictureBox7.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                
                pictureBox11.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }

           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
