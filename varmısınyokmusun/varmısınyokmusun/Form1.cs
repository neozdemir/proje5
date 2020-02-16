using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varmısınyokmusun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           




            Form2 yf = new Form2();
            this.Hide();
            yf.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {


                progressBar1.Value = progressBar1.Value + 2;
            }


            else
            {



                timer1.Stop();
                

                label1.Visible = true;
                label1.ForeColor = Color.Green;
                label1.Text = "%100 Yüklendi";
           
            
            
            
            

            
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
