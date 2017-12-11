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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();

        }


        Stock_Control search = new Stock_Control();


        private void button1_Click(object sender, EventArgs e)
        {
            search.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //make order
            checkStock.stock = 3;
            search.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //check stock
            checkStock.stock = 2;
            search.Show();
            this.Hide();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            checkStock.stock = 4;
            search.Show();
            this.Hide();
        }
    }
}
