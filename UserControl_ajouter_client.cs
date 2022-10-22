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
    public partial class UserControl_ajouter_client : UserControl
    {
        public UserControl_ajouter_client()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 7;





        }
        

        private void button_save_Click(object sender, EventArgs e)
        {
         

                dataGridView1.Rows.Add(textBox_fname.Text, textBox_lname.Text, textBox_adrresse.Text, textBox_id.Text, comboBox_genre.Text, comboBox_statut.Text,textBox_nchambre.Text); //alternative 2

                
        }

       

        private void UserControl_ajouter_client_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            textBox_adrresse.Text = "";
            textBox_id.Text = "";
            comboBox_genre.Text = "";
            comboBox_statut.Text = "";
            textBox_nchambre.Text = "";

        }
    }
}
