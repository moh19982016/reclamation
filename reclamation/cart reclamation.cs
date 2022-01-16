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
    public partial class cart_reclamation : UserControl
    {
        SqlConnection cn = new SqlConnection("data source=.;initial catalog=reclamation;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter("select * from etablissement", @"data source=.;initial catalog=reclamation;integrated security=true");
        DataTable dt = new DataTable();
        public cart_reclamation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into FicheReclamation values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox12.Text);
                cmd.Parameters.AddWithValue("@b", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@c", textBox1.Text);
                cmd.Parameters.AddWithValue("@d", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@e", textBox2.Text);
                cmd.Parameters.AddWithValue("@f", comboBox2.Text);
                cmd.Parameters.AddWithValue("@g", maskedTextBox2.Text);
                cmd.Parameters.AddWithValue("@h", textBox4.Text);
                cmd.Parameters.AddWithValue("@i", textBox5.Text);
                cmd.Parameters.AddWithValue("@j", comboBox1.Text);
                cmd.Parameters.AddWithValue("@k", textBox6.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("لقد تم اضافة الشكاية بنجاح");
                textBox6.Clear();
                textBox1.Clear();
                textBox2.Clear();
                comboBox2.Text=string.Empty;
                textBox4.Clear();
                textBox5.Clear();
                maskedTextBox2.Clear();
                maskedTextBox1.Clear();
                dateTimePicker1.Value = DateTime.Today;


            }
            catch
            {
                MessageBox.Show("عذرا لم تتم اضافة الشكاية المرجو التاكد من صحة المعلومات ");
            }
        }

     

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            envoyage en = new envoyage();
            en.Show();

            en.envoyage_de_reclamation1.textBox2.Text = textBox12.Text;
        }

        private void cart_reclamation_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
