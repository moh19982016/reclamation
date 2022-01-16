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
    public partial class suivie_d_une_reclamation : UserControl
    {
        SqlConnection cn = new SqlConnection("data source=.;initial catalog=reclamation;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        public suivie_d_une_reclamation()
        {
            InitializeComponent();
        }
          

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            //try
            //{
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into ProcéduresDeSuivie values (@a,@b,@c,@d,@e,@f,@g)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox5.Text);
                cmd.Parameters.AddWithValue("@b", textBox7.Text );
                cmd.Parameters.AddWithValue("@c", DateTime.Parse(dateTimePicker1.Value.ToString()));
                cmd.Parameters.AddWithValue("@d",textBox8.Text);
                cmd.Parameters.AddWithValue("@e", textBox6.Text);
                cmd.Parameters.AddWithValue("@f", textBox1.Text);
                cmd.Parameters.AddWithValue("@g", textBox2.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("لقد تم الاضافة الى قائمة التتبعات بنجاح");

                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();

            //}
            //catch
            //{
            //    MessageBox.Show("عذرا لم تتم الاضافة الى قائمة التتبعات المرجو التاكد من صحة المعلومات ");
            //}
            dataGridView1.Refresh();
        }
        afficher_reclamation afficher = new afficher_reclamation();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string reponse = "";
                if (radioButton1.Checked)
                {
                    reponse = "نعم";
                }
                else
                {
                    reponse = "لا";
                }
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into ResultatReclamation values (@a,@b,@c,@d)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a",afficher.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@c", textBox4.Text);
                cmd.Parameters.AddWithValue("@d", reponse);
                cmd.Parameters.AddWithValue("@e", textBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("لقد تم الاضافة الى قائمة التتبعات بنجاح");

                textBox4.Clear();
                textBox3.Clear();


            }
            catch
            {
                MessageBox.Show("عذرا لم تتم الاضافة الى قائمة التتبعات المرجو التاكد من صحة المعلومات ");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //string result = "";
            //if(radioButton1.Checked)
            //{
            //    result ="نعم";
            //}
            //else
            //{
            //    result = "لا";
            //}
            //cn.Open();
            //cmd.Connection = cn;
            //cmd.CommandText = "insert into ResultatReclamation([رقمالشكاية],[النتيجةالنهائية],[تماخبارالجهةالمهنية],[السبب]) values(@a,@b,@c,@d)";
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@a", "aaa");
            
            //cmd.Parameters.AddWithValue("@b",textBox4.Text);
            //cmd.Parameters.AddWithValue("@c",result);
            //cmd.Parameters.AddWithValue("@d",textBox3.Text);
            //cmd.ExecuteNonQuery();
            //cn.Close();
        }

        private void suivie_d_une_reclamation_Load(object sender, EventArgs e)
        {
            string num ="";
            
            num = textBox7.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from ProcéduresDeSuivie", "data source=.;initial catalog=reclamation;integrated security=true");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        //    dt.DefaultView.RowFilter = "[رقمالشكاية] ='"+num.ToString()+"'"  ;
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
