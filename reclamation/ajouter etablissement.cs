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
    public partial class ajouter_etablissement : UserControl
    {
        SqlConnection cn = new SqlConnection("data source=.;initial catalog=reclamation;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        public ajouter_etablissement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "insert into etablissement values(@a,@b,@c)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@a",textBox1.Text);
            cmd.Parameters.AddWithValue("@b",textBox2.Text);
            cmd.Parameters.AddWithValue("@c",textBox3.Text);
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        private void ajouter_etablissement_Load(object sender, EventArgs e)
        {

        }
    }
}
