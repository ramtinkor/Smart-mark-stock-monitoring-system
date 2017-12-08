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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        home homeS = new home();
        manager managerS = new manager();

        string stUserName = "lisa";
        string stPassWord = "password";

        string Musern = "david";
        string Mpassw = "password1";



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //check password if correct open next window otherwise show error message.

            if (txtUsername.Text==stUserName & txtPassWord.Text == stPassWord ) { homeS.Show(); this.Close();}
            else if (txtUsername.Text == Musern & txtPassWord.Text == Mpassw) { managerS.Show(); this.Close(); }
            else { MessageBox.Show("Username/Password are wrong", "error", MessageBoxButtons.OK,MessageBoxIcon.Error); }



        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear(); // clears the text when user starts to type
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            txtPassWord.Clear(); 
            txtPassWord.PasswordChar='*'; //when user starts typing the password is hidden.

        }
    }
}
