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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       




        private void button8_Click(object sender, EventArgs e)
        {
          //  userControl_checkout1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button2.Height;
            panel_slide.Top = button2.Top;
            userControl_ajouter_client1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button3.Height;
            panel_slide.Top = button3.Top;
            userControl_chambre1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button4.Height;
            panel_slide.Top = button4.Top;
            userControl_ropas1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button5.Height;
            panel_slide.Top = button5.Top;
            userControl_ajouter_service1.BringToFront();
        }

      

      

        private void button1_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button1.Height;
            panel_slide.Top = button1.Top;
            userControl_accueil1.BringToFront();
        }


        private void label_exit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void label_exit_2_MouseEnter_1(object sender, EventArgs e)
        {
            label_exit_2.ForeColor = Color.Red;

        }

        private void label_exit_2_MouseLeave_1(object sender, EventArgs e)
        {
            label_exit_2.ForeColor = Color.Black;

        }

        private void userControl_accueil1_Load(object sender, EventArgs e)
        {

        }
    }
}
