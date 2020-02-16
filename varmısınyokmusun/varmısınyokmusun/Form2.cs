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
    public partial class Form2 : Form
    {
        int sayac = 0;

       
        

        Button[] kutu = new Button[25];
      
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
           
            for (int i = 1; i < 25; i++)
            {


               


                kutu[i] = new Button();
               
                kutu[i].Text = i.ToString();
                kutu[i].AutoSize = false;
                kutu[i].Size = new Size(60, 60);
                
                kutu[i].BackColor = Color.Red;
                kutu[i].Parent = flowLayoutPanel1;

                kutu[i].Click += new EventHandler(yakala);
               
              
            }

            kutu[1].Name = "5";
            kutu[2].Name = "500";
            kutu[3].Name = "500,000";
            kutu[4].Name = "100,000";
            kutu[5].Name = "25";
            kutu[6].Name = "200";
            kutu[7].Name = "75,000";
            kutu[8].Name = "1";
            kutu[9].Name = "10";
            kutu[10].Name = "10,000";
            kutu[11].Name = "400";
            kutu[12].Name = "250,000";
            kutu[13].Name = "300";
            kutu[14].Name = "100";
            kutu[15].Name = "500,000";
            kutu[16].Name = "50";
            kutu[17].Name = "2";
            kutu[18].Name = "15,000";
            kutu[19].Name = "500";
            kutu[20].Name = "25,000";
            kutu[21].Name = "50,000";
            kutu[22].Name = "150,000";
            kutu[23].Name = "5,000";
            kutu[24].Name = "300,000";




           

        }


       



         public void yakala(object o, EventArgs a)
            {
                Button b = (Button)o;
                  
               
                    b.Visible = false;
                    label27.Text = b.Text + " NOLU KUTU SEÇİLDİ";
                    label24.Text = b.Text;

                    label28.Text = b.Name +"TL";
                    label28.Visible = true;
                    sayac++;

                  


             if(Convert.ToInt32(b.Text)==1)
             {

                 label3.Visible = false;




             }

            else if (Convert.ToInt32(b.Text) == 2)
             {

                 label11.Visible = false;




             }


             else if (Convert.ToInt32(b.Text) == 3)
             {

                 label22.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 4)
             {

                 label18.Visible = false;




             }



             else if (Convert.ToInt32(b.Text) == 5)
             {

                 label5.Visible = false;




             }



             else if (Convert.ToInt32(b.Text) == 6)
             {

                 label8.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 7)
             {

                 label17.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 8)
             {

                 label1.Visible = false;




             }


             else if (Convert.ToInt32(b.Text) == 9)
             {

                 label4.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 10)
             {

                 label13.Visible = false;




             }


             else if (Convert.ToInt32(b.Text) == 11)
             {

                 label10.Visible = false;




             }



             else if (Convert.ToInt32(b.Text) == 12)
             {

                 label20.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 13)
             {

                 label9.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 14)
             {

                 label7.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 15)
             {

                 label26.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 16)
             {

                 label6.Visible = false;




             }


             else if (Convert.ToInt32(b.Text) == 17)
             {

                 label2.Visible = false;




             }


             else if (Convert.ToInt32(b.Text) == 18)
             {

                 label14.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 19)
             {

                 label25.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 20)
             {

                 label15.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 21)
             {

                 label16.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 22)
             {

                 label19.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 23)
             {

                 label12.Visible = false;




             }

             else if (Convert.ToInt32(b.Text) == 24)
             {

                 label21.Visible = false;




             }
          
             if (sayac==3)
                    {

                        DialogResult sonuc = MessageBox.Show("Hamdi Bey 1000 TL Teklif ediyor",  "Hamdi Bey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (sonuc == DialogResult.Yes)
                        {
                            MessageBox.Show("1000 TL kazandınız");
                        }


                    }


                    if (sayac == 7)
                    {

                        DialogResult sonuc = MessageBox.Show("Hamdi Bey 10000 TL Teklif ediyor", "Hamdi Bey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (sonuc == DialogResult.Yes)
                        {
                            MessageBox.Show("10000 TL kazandınız");
                        }


                    }

                    if (sayac == 12)
                    {

                        DialogResult sonuc = MessageBox.Show("Hamdi Bey 30000 TL Teklif ediyor", "Hamdi Bey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (sonuc == DialogResult.Yes)
                        {
                            MessageBox.Show("30000 TL kazandınız");
                        }


                    }
                    if (sayac == 15)
                    {

                        DialogResult sonuc = MessageBox.Show("Hamdi Bey 40000 TL Teklif ediyor", "Hamdi Bey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (sonuc == DialogResult.Yes)
                        {
                            MessageBox.Show("40000 TL kazandınız");
                        }


                    }
                    if (sayac == 20)
                    {

                        DialogResult sonuc = MessageBox.Show("Hamdi Bey 50000 TL Teklif ediyor", "Hamdi Bey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (sonuc == DialogResult.Yes)
                        {
                            MessageBox.Show("50000 TL kazandınız");
                        }


                    }

                    if (sayac == 23)
                    {

                        DialogResult sonuc = MessageBox.Show("Hamdi Bey 60000 TL Teklif ediyor", "Hamdi Bey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (sonuc == DialogResult.Yes)
                        {
                            MessageBox.Show("60000 TL kazandınız");
                        }


                    }
               }
        private void button1_Click(object sender, EventArgs e)
        {
            


        }


        private void player(string path)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = path;

            player.Load();
            player.Play();








        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            player("aa.wav");
        }






    }








}
