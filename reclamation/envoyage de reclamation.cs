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
    public partial class envoyage_de_reclamation : UserControl
    {
        SqlConnection cn = new SqlConnection("data source=.;initial catalog=reclamation;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        public envoyage_de_reclamation()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int duree = int.Parse(numericUpDown1.Value.ToString());
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into SuivieReclamation values (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox1.Text);
                cmd.Parameters.AddWithValue("@b", textBox2.Text);
                cmd.Parameters.AddWithValue("@c", textBox7.Text);
                cmd.Parameters.AddWithValue("@d", textBox8.Text);
                cmd.Parameters.AddWithValue("@e", textBox3.Text);
                cmd.Parameters.AddWithValue("@f", comboBox2.Text);
                cmd.Parameters.AddWithValue("@g", textBox10.Text);
                cmd.Parameters.AddWithValue("@h", DateTime.Parse(dateTimePicker2.Value.ToString()));
                cmd.Parameters.AddWithValue("@i", DateTime.Parse(dateTimePicker2.Value.ToString()).AddDays(duree));
                cmd.Parameters.AddWithValue("@j", DateTime.Parse(dateTimePicker3.Value.ToString()));
                cmd.Parameters.AddWithValue("@k", textBox11.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("لقد تم اضافة الشكاية بنجاح");
                textBox1.Clear();
                textBox2.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox10.Clear();
                textBox11.Clear();
                dateTimePicker2.Value = DateTime.Today;
                dateTimePicker3.Value = DateTime.Today;
            }
            catch
            {
                MessageBox.Show("عذرا لم تتم عملية التسليم المرجو التاكد من صحة المعلومات ");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) groupBox2.Enabled = true;
            else groupBox2.Enabled = false;
        }

        private void envoyage_de_reclamation_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           


        }
    }
}
