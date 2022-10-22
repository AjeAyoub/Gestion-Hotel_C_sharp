using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Hotel_Submti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string usn = textbox_username.Text;
            string pass = textbox_password.Text;

            if(usn == "admin" && pass == "admin")
            {
                using (Form2 F = new Gestion_Hotel_Submti.Form2())
                {
                    F.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("password or username incorect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;

        }
    }
}
