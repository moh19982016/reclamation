using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace reclamation
{
    public partial class afficher_reclamation : UserControl
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from FicheReclamation", @"Data Source=.;initial catalog=reclamation;integrated security=true");
        DataSet ds = new DataSet();
        
        //;select* from SuivieReclamation
        public afficher_reclamation()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void afficher_reclamation_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ds.Tables[0].DefaultView.RowFilter = "رقمالشكاية=" + textBox1.Text;
            }
            else if (radioButton2.Checked)
            {
                ds.Tables[0].DefaultView.RowFilter = "الموضوع=" + comboBox1.Text;
            }
            else
            {
                ds.Tables[0].DefaultView.RowFilter = "التاريخ>=" + DateTime.Parse(dateTimePicker1.Value.ToString()) + "and التاريخ <= " + DateTime.Parse(dateTimePicker2.Value.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            suivie sv = new suivie();
            sv.Show();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = radioButton2.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = radioButton3.Checked;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
