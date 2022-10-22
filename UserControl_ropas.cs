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
    public partial class UserControl_ropas : UserControl
    {
        public UserControl_ropas()
        {
            InitializeComponent();
        }

        private void UserControl_ropas_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
            {
                dataGridView4.Rows.RemoveAt(item.Index);

            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Add(textBox1_repas.Text, textBox2_repas.Text, comboBox3_repas.Text, comboBox4_repas.Text, textBox5_repas.Text+" dh", textBox6_repas.Text + " dh"); //alternative 2

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1_repas.Text = "";
            textBox2_repas.Text = "";
            comboBox3_repas.Text = "";
            comboBox4_repas.Text = "";
            textBox5_repas.Text = "";
            textBox6_repas.Text = "";
        }

        private void comboBox4_repas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
