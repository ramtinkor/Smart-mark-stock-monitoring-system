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
        decimal pepsi = 2.00m;
        decimal nutella = 1.00m;


        private void Stock_Control_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<decimal> price = new List<decimal>();
            price.Add(Convert.ToDecimal( lblItem1P.Text));
            price.Add(Convert.ToDecimal(lblItem2P.Text));
            price.Add(Convert.ToDecimal(lblItem3P.Text));
            price.Sort();
            price.Reverse();

            
            if (price[0] == coke) { pbItem1.BackgroundImage = Properties.Resources.Coca; }
            else if (price[0] == pepsi) { pbItem1.BackgroundImage = Properties.Resources.pepsi; }
            else if (price[0] == nutella) { pbItem1.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; }

            price.RemoveAt(0);

            if (price[0] == coke) { pbItem2.BackgroundImage = Properties.Resources.Coca; coke = 0; }
            else if (price[0] == pepsi) { pbItem2.BackgroundImage = Properties.Resources.pepsi; }
            else if (price[0] == nutella) { pbItem2.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; }

            price.RemoveAt(0);

            if (price[0] == coke) { pbItem3.BackgroundImage = Properties.Resources.Coca; }
            else if (price[0] == pepsi) { pbItem3.BackgroundImage = Properties.Resources.pepsi; }
            else if (price[0] == nutella) { pbItem3.BackgroundImage = Properties.Resources.e50a3c3669e8d991a94413eac8f3d7fb; }




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
