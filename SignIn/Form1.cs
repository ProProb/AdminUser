using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void log_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sign_Click(object sender, EventArgs e)
        {
           
            if (log.Text == "AS" && pass.Text == "12")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (log.Text == "SA" && pass.Text == "21")
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
                MessageBox.Show("Incorrect password or login!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Text = "";
            pass.Text = "";
            Close();
           

        }
        private bool tf = true;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            char a;
                if (tf == true)
                {
                for( i = 0; i != pass.Text.Length; i++)
                {
                    a = pass.Text[i];
                    pass.Text += a;
                }
                pass.Text += "m";
                tf = false;
                
                }
            else
            {
                pass.PasswordChar = '*';
                tf = true;
            }



        }


    }
}
