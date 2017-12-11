using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_mark_stock_monitoring_system
{
    public partial class Stock_Control : Form
    {
        public Stock_Control()
        {
            InitializeComponent();
        }

        decimal coke = 1.00m;
        decimal pepsi = 1.00m;
        decimal nutella = 1.49m;
        decimal apple = 0.49m;
        decimal bottled_water = 0.29m;

        int cokeQ = 6;
        int pepsiQ = 99;
        int nutellaQ = 12;
        int appleQ = 29;
        int waterQ = 10;
        bool show = false;


        public void hide()
        { 

            if (show == true)
            {
                //when the user seaches they only want to be able to see the item they searched for this will hide them all. 
                pbItem2.Hide(); pbItem3.Hide(); pbItem4.Hide(); pbItem5.Hide();
                lblItem2P.Hide(); lblItem3P.Hide(); lblItem4P.Hide(); lblItem5P.Hide();
                lblName2.Hide(); lblName3.Hide(); lblName4.Hide(); lblName5.Hide();
                lblp1.Hide(); lblp2.Hide(); lblp3.Hide(); lblp4.Hide();
                lblq1.Hide(); lblq2.Hide(); lblq3.Hide(); lblq4.Hide();
                lbl2c.Hide(); lbl3c.Hide(); lbl4c.Hide(); lbl5c.Hide();

            }

            else if(show==false) {

                pbItem2.Show(); pbItem3.Show(); pbItem4.Show(); pbItem5.Show();
                lblItem2P.Show(); lblItem3P.Show(); lblItem4P.Show(); lblItem5P.Show();
                lblName2.Show(); lblName3.Show(); lblName4.Show(); lblName5.Show();
                lblp1.Show(); lblp2.Show(); lblp3.Show(); lblp4.Show();
                lblq1.Show(); lblq2.Show(); lblq3.Show(); lblq4.Show();
                lbl2c.Show(); lbl3c.Show(); lbl4c.Show(); lbl5c.Show();
            }

        }

        private void Stock_Control_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblName1_Click(object sender, EventArgs e)
        {

        }

        private void lblName5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show = false;
            hide();

            if (comboBox1.Text == "price")

            {

                coke = 1.00m;
                pepsi = 1.00m;
                nutella = 1.49m;
                apple = 0.49m;
                bottled_water = 0.29m;


                List<decimal> price = new List<decimal>();
                price.Add(coke);
                price.Add(pepsi);
                price.Add(nutella);
                price.Add(apple);
                price.Add(bottled_water);


                price.Sort();
                price.Reverse();


                if (price[0] == coke)
                {
                    pbItem1.BackgroundImage = Properties.Resources.Coca;
                    lblItem1P.Text = Convert.ToString(coke);
                    coke = 0; //advoids duplicate images 
                    lblName1.Text = "Coke";
                    lbl1q.Text = Convert.ToString(cokeQ);

                }

                else if (price[0] == pepsi) { pbItem1.BackgroundImage = Properties.Resources.pepsi; lblItem1P.Text = Convert.ToString(pepsi); pepsi = 0; lblName1.Text = "Pepsi"; lbl1q.Text = Convert.ToString(pepsiQ); }

                else if (price[0] == nutella) { pbItem1.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem1P.Text = Convert.ToString(nutella); nutella = 0; lblName1.Text = "Nutella"; lbl1q.Text = Convert.ToString(nutellaQ); }

                else if (price[0] == apple) { pbItem1.BackgroundImage = Properties.Resources.apple; lblItem1P.Text = Convert.ToString(apple); apple = 0; lblName1.Text = "Apples"; lbl1q.Text = Convert.ToString(appleQ);}

                else if (price[0] == bottled_water) { pbItem1.BackgroundImage = Properties.Resources.SmartWater; lblItem1P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName1.Text = "Bottled water"; lbl1q.Text = Convert.ToString(waterQ);}
          


            price.RemoveAt(0); //removes item in case 2 items cost the same.

                if (price[0] == coke) { pbItem2.BackgroundImage = Properties.Resources.Coca; lblItem2P.Text = Convert.ToString(coke); coke = 0; lblName2.Text = "Coke"; lbl2c.Text = Convert.ToString(cokeQ);}

                else if (price[0] == pepsi) { pbItem2.BackgroundImage = Properties.Resources.pepsi; Convert.ToString(pepsi); lblItem2P.Text = Convert.ToString(nutella); pepsi = 0; lblName2.Text = "Pepsi"; lbl2c.Text = Convert.ToString(pepsiQ);}

                else if (price[0] == nutella) { pbItem2.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem2P.Text = Convert.ToString(nutella); nutella = 0; lblName2.Text = "Nutella"; lbl2c.Text = Convert.ToString(nutellaQ);}

                else if (price[0] == apple) { pbItem2.BackgroundImage = Properties.Resources.apple; lblItem2P.Text = Convert.ToString(apple); apple = 0; lblName2.Text = "Apples"; lbl2c.Text = Convert.ToString(appleQ);}

                else if (price[0] == bottled_water) { pbItem2.BackgroundImage = Properties.Resources.SmartWater; lblItem2P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName2.Text = "Bottled water"; lbl2c.Text = Convert.ToString(waterQ);
                }


                price.RemoveAt(0);

                if (price[0] == coke) { pbItem3.BackgroundImage = Properties.Resources.Coca; lblItem3P.Text = Convert.ToString(coke); coke = 0; lblName3.Text = "Coke"; lbl3c.Text = Convert.ToString(cokeQ);}
                else if (price[0] == pepsi) { pbItem3.BackgroundImage = Properties.Resources.pepsi; lblItem3P.Text = Convert.ToString(pepsi); pepsi = 0; lblName3.Text = "Pepsi"; lbl3c.Text = Convert.ToString(pepsiQ);}
                else if (price[0] == nutella) { pbItem3.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem3P.Text = Convert.ToString(nutella); nutella = 0; lblName3.Text = "Nutella"; lbl3c.Text = Convert.ToString(nutellaQ);}
                else if (price[0] == apple) { pbItem3.BackgroundImage = Properties.Resources.apple; lblItem3P.Text = Convert.ToString(apple); apple = 0; lblName3.Text = "Apples"; lbl3c.Text = Convert.ToString(appleQ);}
                else if (price[0] == bottled_water) { pbItem3.BackgroundImage = Properties.Resources.SmartWater; lblItem3P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName3.Text = "Bottled water"; lbl3c.Text = Convert.ToString(waterQ);}

                price.RemoveAt(0);

                if (price[0] == coke) { pbItem4.BackgroundImage = Properties.Resources.Coca; lblItem4P.Text = Convert.ToString(coke); coke = 0; lblName4.Text = "Coke"; lbl4c.Text = Convert.ToString(cokeQ);}
                else if (price[0] == pepsi) { pbItem4.BackgroundImage = Properties.Resources.pepsi; lblItem4P.Text = Convert.ToString(pepsi); pepsi = 0; lblName4.Text = "Pepsi"; lbl4c.Text = Convert.ToString(pepsiQ);}
                else if (price[0] == nutella) { pbItem4.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem4P.Text = Convert.ToString(nutella); nutella = 0; lblName4.Text = "Nutella"; lbl4c.Text = Convert.ToString(nutellaQ);}
                else if (price[0] == apple) { pbItem4.BackgroundImage = Properties.Resources.apple; lblItem4P.Text = Convert.ToString(apple); apple = 0; lblName4.Text = "Apples"; lbl4c.Text = Convert.ToString(appleQ);}
                else if (price[0] == bottled_water) { pbItem4.BackgroundImage = Properties.Resources.SmartWater; lblItem4P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName4.Text = "Bottled water"; lbl4c.Text = Convert.ToString(waterQ);}


                price.RemoveAt(0);

                if (price[0] == coke) { pbItem5.BackgroundImage = Properties.Resources.Coca; lblItem5P.Text = Convert.ToString(coke); coke = 0; lblName5.Text = "Coke"; lbl5c.Text = Convert.ToString(cokeQ);}
                else if (price[0] == pepsi) { pbItem5.BackgroundImage = Properties.Resources.pepsi; lblItem5P.Text = Convert.ToString(pepsi); pepsi = 0; lblName5.Text = "Pepsi"; lbl5c.Text = Convert.ToString(pepsiQ);}
                else if (price[0] == nutella) { pbItem5.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem5P.Text = Convert.ToString(nutella); nutella = 0; lblName5.Text = "Nutella"; lbl5c.Text = Convert.ToString(nutellaQ);}
                else if (price[0] == apple) { pbItem5.BackgroundImage = Properties.Resources.apple; lblItem5P.Text = Convert.ToString(apple); apple = 0; lblName5.Text = "Apples"; lbl5c.Text = Convert.ToString(appleQ);}
                else if (price[0] == bottled_water) { pbItem5.BackgroundImage = Properties.Resources.SmartWater; lblItem5P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName5.Text = "Bottled water"; lbl5c.Text = Convert.ToString(waterQ);}

                coke = 1.00m;
                pepsi = 1.00m;
                nutella = 1.49m;
                apple = 0.49m;
                bottled_water = 0.29m;


            }


            if (comboBox1.Text == "quantity")

            {
                int cokeQ = 6;
                int pepsiQ = 99;
                int nutellaQ = 12;
                int appleQ = 29;
                int waterQ = 10;
          


                List<int> quantity = new List<int>();
                quantity.Add(cokeQ);
                quantity.Add(pepsiQ);
                quantity.Add(nutellaQ);
                quantity.Add(appleQ);
                quantity.Add(waterQ);

          
                quantity.Sort();
                quantity.Reverse();

                if (quantity[0] == cokeQ)
                {
                    pbItem1.BackgroundImage = Properties.Resources.Coca;
                    lblItem1P.Text = Convert.ToString(coke);
                    cokeQ = 0;
                    lblName1.Text = "Coke";
                    lbl1q.Text = Convert.ToString(cokeQ);
                }

                else if (quantity[0] == pepsiQ) { pbItem1.BackgroundImage = Properties.Resources.pepsi; lblItem1P.Text = Convert.ToString(pepsi); lbl1q.Text = Convert.ToString(pepsiQ);  pepsiQ = 0; lblName1.Text = "Pepsi"; }

                else if (quantity[0] == nutella) { pbItem1.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem1P.Text = Convert.ToString(nutella); nutella = 0; lblName1.Text = "Nutella"; lbl1q.Text = Convert.ToString(nutellaQ); }

                else if (quantity[0] == apple) { pbItem1.BackgroundImage = Properties.Resources.apple; lblItem1P.Text = Convert.ToString(apple); apple = 0; lblName1.Text = "Apples"; lbl1q.Text = Convert.ToString(appleQ); }

                else if (quantity[0] == bottled_water) { pbItem1.BackgroundImage = Properties.Resources.SmartWater; lblItem1P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName1.Text = "Bottled water"; lbl1q.Text = Convert.ToString(waterQ);}


                quantity.RemoveAt(0);

                if (quantity[0] == cokeQ) { pbItem2.BackgroundImage = Properties.Resources.Coca; lblItem2P.Text = Convert.ToString(coke); coke = 0; lblName2.Text = "Coke"; lbl2c.Text = Convert.ToString(cokeQ);}

                else if (quantity[0] == pepsiQ) { pbItem2.BackgroundImage = Properties.Resources.pepsi; Convert.ToString(pepsi); lblItem2P.Text = Convert.ToString(nutella); pepsi = 0; lblName2.Text = "Pepsi"; lbl2c.Text = Convert.ToString(pepsiQ); }

                else if (quantity[0] == nutellaQ) { pbItem2.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem2P.Text = Convert.ToString(nutella); nutella = 0; lblName2.Text = "Nutella"; lbl2c.Text = Convert.ToString(nutellaQ); }

                else if (quantity[0] == appleQ) { pbItem2.BackgroundImage = Properties.Resources.apple; lblItem2P.Text = Convert.ToString(apple); apple = 0; lblName2.Text = "Apples"; lbl2c.Text = Convert.ToString(appleQ); }

                else if (quantity[0] == waterQ) { pbItem2.BackgroundImage = Properties.Resources.SmartWater; lblItem2P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName2.Text = "Bottled water"; lbl2c.Text = Convert.ToString(waterQ); }


                quantity.RemoveAt(0);

                if (quantity[0] == cokeQ) { pbItem3.BackgroundImage = Properties.Resources.Coca; lblItem3P.Text = Convert.ToString(coke); coke = 0; lblName3.Text = "Coke"; lbl3c.Text = Convert.ToString(cokeQ);}
                else if (quantity[0] == pepsiQ) { pbItem3.BackgroundImage = Properties.Resources.pepsi; lblItem3P.Text = Convert.ToString(pepsi); pepsi = 0; lblName3.Text = "Pepsi"; lbl3c.Text = Convert.ToString(pepsiQ); }
                else if (quantity[0] == nutellaQ) { pbItem3.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem3P.Text = Convert.ToString(nutella); nutella = 0; lblName3.Text = "Nutella"; lbl3c.Text = Convert.ToString(nutellaQ); }
                else if (quantity[0] == appleQ) { pbItem3.BackgroundImage = Properties.Resources.apple; lblItem3P.Text = Convert.ToString(apple); apple = 0; lblName3.Text = "Apples"; lbl3c.Text = Convert.ToString(appleQ); }
                else if (quantity[0] == waterQ) { pbItem3.BackgroundImage = Properties.Resources.SmartWater; lblItem3P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName3.Text = "Bottled water"; lbl3c.Text = Convert.ToString(waterQ); }


                quantity.RemoveAt(0);


                if (quantity[0] == cokeQ) { pbItem4.BackgroundImage = Properties.Resources.Coca; lblItem4P.Text = Convert.ToString(coke); coke = 0; lblName4.Text = "Coke"; lbl4c.Text = Convert.ToString(cokeQ); }
                else if (quantity[0] == pepsiQ) { pbItem4.BackgroundImage = Properties.Resources.pepsi; lblItem4P.Text = Convert.ToString(pepsi); pepsi = 0; lblName4.Text = "Pepsi"; lbl4c.Text = Convert.ToString(pepsiQ); }
                else if (quantity[0] == nutellaQ) { pbItem4.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem4P.Text = Convert.ToString(nutella); nutella = 0; lblName4.Text = "Nutella"; lbl4c.Text = Convert.ToString(nutellaQ); }
                else if (quantity[0] == appleQ) { pbItem4.BackgroundImage = Properties.Resources.apple; lblItem4P.Text = Convert.ToString(apple); apple = 0; lblName4.Text = "Apples"; lbl4c.Text = Convert.ToString(appleQ); }
                else if (quantity[0] == waterQ) { pbItem4.BackgroundImage = Properties.Resources.SmartWater; lblItem4P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName4.Text = "Bottled water"; lbl4c.Text = Convert.ToString(waterQ); }

                quantity.RemoveAt(0);

                if (quantity[0] == cokeQ) { pbItem5.BackgroundImage = Properties.Resources.Coca; lblItem5P.Text = Convert.ToString(coke); coke = 0; lblName5.Text = "Coke"; lbl5c.Text = Convert.ToString(cokeQ); }
                else if (quantity[0] == pepsiQ) { pbItem5.BackgroundImage = Properties.Resources.pepsi; lblItem5P.Text = Convert.ToString(pepsi); pepsi = 0; lblName5.Text = "Pepsi"; lbl5c.Text = Convert.ToString(pepsiQ); }
                else if (quantity[0] == nutellaQ) { pbItem5.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem5P.Text = Convert.ToString(nutella); nutella = 0; lblName5.Text = "Nutella"; lbl5c.Text = Convert.ToString(nutellaQ); }
                else if (quantity[0] == appleQ) { pbItem5.BackgroundImage = Properties.Resources.apple; lblItem5P.Text = Convert.ToString(apple); apple = 0; lblName5.Text = "Apples"; lbl5c.Text = Convert.ToString(appleQ); }
                else if (quantity[0] == waterQ) { pbItem5.BackgroundImage = Properties.Resources.SmartWater; lblItem5P.Text = Convert.ToString(bottled_water); bottled_water = 0; lblName5.Text = "Bottled water"; lbl5c.Text = Convert.ToString(waterQ); }



                cokeQ = 6;
                pepsiQ = 10;
                nutellaQ = 12;
                appleQ = 29;
                waterQ = 10;


            }



        }
        
       

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtsearch.Text;

            if (search == "pepsi")
            {
                pbItem1.BackgroundImage = Properties.Resources.pepsi; lblItem1P.Text = Convert.ToString(pepsi); lblName1.Text = "Pepsi"; lbl1q.Text = Convert.ToString(pepsiQ);
                show = true;
                hide();
            }

            else if (search == "coke")
            {
                pbItem1.BackgroundImage = Properties.Resources.Coca;
                lblItem1P.Text = Convert.ToString(coke);
                lblName1.Text = "Coke";
                lbl1q.Text = Convert.ToString(cokeQ);
                show = true;
                hide();
            }

            else if (search == "water" | search == "bottle water")
            {
                pbItem1.BackgroundImage = Properties.Resources.SmartWater; lblItem1P.Text = Convert.ToString(bottled_water); lblName1.Text = "Bottled water"; lbl1q.Text = Convert.ToString(waterQ);
                show = true;
                hide();
            }


            else if (search == "nutella")
            {

                pbItem1.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; lblItem1P.Text = Convert.ToString(nutella); nutella = 0; lblName1.Text = "Nutella"; lbl1q.Text = Convert.ToString(nutellaQ);
                show = true;
                hide();
            }

            else if (search == "apples")
            {

                pbItem1.BackgroundImage = Properties.Resources.apple; lblItem1P.Text = Convert.ToString(apple); apple = 0; lblName1.Text = "Apples"; lbl1q.Text = Convert.ToString(appleQ);
                show = true;
                hide();
            }

            else {
                show = false;
                hide();
                pbItem1.BackgroundImage = Properties.Resources.Coca;
                lblItem1P.Text = Convert.ToString(coke);
                lblName1.Text = "Coke";
                lbl1q.Text = Convert.ToString(cokeQ);
            }


        }
    }
}
