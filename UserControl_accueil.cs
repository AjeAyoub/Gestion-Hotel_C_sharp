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
    public partial class UserControl_accueil : UserControl
    {
        public UserControl_accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView6.SelectedRows)
            {
                dataGridView6.Rows.RemoveAt(item.Index);

            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(dataGridView6.Rows.Count == 0)
            { 
               
                dataGridView6.Rows.Add(textBox1_disponile.Text, textBox2_single.Text, textBox3_double.Text, textBox4_famille.Text); //alternative 2
            }
            else
            {
                MessageBox.Show("Vous pouvez insérer une seule ligne","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1_disponile.Text = "";
            textBox2_single.Text = "";
            textBox3_double.Text = "";
            textBox4_famille.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
