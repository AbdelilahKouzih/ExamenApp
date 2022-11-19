using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void connection()
        {

            cnx.Open();
           
            cmd.Connection = cnx;
            




        }

        static string chaine = @"Data Source=DESKTOP-ID5FAVQ\SQLEXPRESS;Initial Catalog=CreationExamen;Integrated Security=True";
       
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void Form1_Load(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "select * from E_xamen";
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrExamen.DataSource = dt;
            cnx.Close();


        }

        private void lbrid_q_Click(object sender, EventArgs e)
        {

        }

        private void lbrt_ype_Click(object sender, EventArgs e)
        {

        }

        private void dgrExamen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {

            connection();
            cmd.CommandText = "insert into E_xamen(id_e,date_debut,id_qu) values('" + txrid_e.Text + "','" + txrdate_debut.Text + "','" + txrid_qu.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();


        }

        private void txrid_q_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "select * from E_xamen";
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrExamen.DataSource = dt;
            cnx.Close();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "UPDATE E_xamen set date_debut ='" + txrdate_debut.Text + "' where id_e='" + txrid_e.Text + "' ";
            cnx.Close();
        }
    }
}
