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
    public partial class Loading_screen : Form
    {
        public Loading_screen()
        {
            InitializeComponent();
        }

        Login loginS = new Login();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        int timerSplahScreen = 0; //to check time.(when to close) 
        private void splashScreen_Tick(object sender, EventArgs e)
        {

            timerSplahScreen += 1;

            if (timerSplahScreen == 350) { loginS.Show();this.Hide(); } //once the timer gets to a time, exit the loading screen


        }

        private void Loading_screen_Load(object sender, EventArgs e)
        {

        }
    }
}
