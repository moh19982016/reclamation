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
    public partial class imprimer : UserControl
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from FicheReclamation;select * from SuivieReclamation", @"Data Source=.;initial catalog=reclamation;integrated security=true");
        DataSet ds = new DataSet();
        public imprimer()
        {
            InitializeComponent();
        }

        private void imprimer_Load(object sender, EventArgs e)
        {
            

        }
    }
}
