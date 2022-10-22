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
    public partial class UserControl_ajouter_service : UserControl
    {
        public UserControl_ajouter_service()
        {
            InitializeComponent();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(textBox1_service.Text, textBox2_service.Text, comboBox3_service.Text, comboBox4_service.Text, textBox5_service.Text + " dh", textBox6_service.Text + " dh"); //alternative 2

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
            {
                dataGridView3.Rows.RemoveAt(item.Index);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1_service.Text = "";
            textBox2_service.Text = "";
            comboBox3_service.Text = "";
            comboBox4_service.Text = "";
            textBox5_service.Text = "";
            textBox6_service.Text = "";

        }
    }
}
