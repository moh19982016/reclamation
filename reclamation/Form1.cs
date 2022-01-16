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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void cart_reclamation1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acceuil1.BringToFront();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cart_reclamation1.BringToFront();
            guna2Button1.FillColor =Color.FromArgb(209, 209, 209);
            guna2Button2.FillColor = Color.FromArgb(150,150,150);
            guna2Button3.FillColor = Color.FromArgb(150, 150, 150);
            guna2Button4.FillColor= Color.FromArgb(150, 150, 150);
            guna2ImageButton7.Visible = true;
            guna2ImageButton4.Visible = false;
            guna2ImageButton5.Visible = false;
            guna2ImageButton6.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            afficher_reclamation1.BringToFront();
            guna2Button2.FillColor = Color.FromArgb(209, 209, 209);
            guna2Button1.FillColor = Color.FromArgb(150, 150, 150);
            guna2Button3.FillColor = Color.FromArgb(150, 150, 150);
            guna2Button4.FillColor = Color.FromArgb(150, 150, 150);
            guna2ImageButton7.Visible = false;
            guna2ImageButton4.Visible = true;
            guna2ImageButton5.Visible = false;
            guna2ImageButton6.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            imprimer1.BringToFront();
            guna2Button3.FillColor = Color.FromArgb(209, 209, 209);
            guna2Button1.FillColor = Color.FromArgb(150, 150, 150);
            guna2Button2.FillColor = Color.FromArgb(150, 150, 150);
            guna2Button4.FillColor = Color.FromArgb(150, 150, 150);
            guna2ImageButton7.Visible = false;
            guna2ImageButton4.Visible = false;
            guna2ImageButton5.Visible = false;
            guna2ImageButton6.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ajouter_etablissement1.BringToFront();
            guna2Button3.FillColor = Color.FromArgb(150,150,150);
            guna2Button1.FillColor = Color.FromArgb(150, 150, 150);
            guna2Button2.FillColor = Color.FromArgb(150, 150, 150);
            guna2Button4.FillColor = Color.FromArgb(209, 209, 209);
            guna2ImageButton7.Visible = false;
            guna2ImageButton4.Visible = false;
            guna2ImageButton5.Visible = true;
            guna2ImageButton6.Visible = false;
        }
    }
}
