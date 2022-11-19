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
    public partial class Proposition : Form
    {
        public Proposition()
        {
            InitializeComponent();
        }
        static string chaine = @"Data Source=DESKTOP-ID5FAVQ\SQLEXPRESS;Initial Catalog=CreationExamen;Integrated Security=True";

        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public void connection()
        {

            cnx.Open();

            cmd.Connection = cnx;
        }

        private void lblproposition_Click(object sender, EventArgs e)
        {

        }

        private void btnpajouter_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "insert into Proposition(id_p,proposition) values('" + txtpid_p.Text + "','" + txtpproposition.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnpmodifier_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "UPDATE Proposition set proposition ='" + txtpproposition.Text + "' where id_p= '" + txtpid_p.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnpsupprimer_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "DELETE FROM Proposition where id_p ='" + txtpid_p.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnpafficher_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "select * from Proposition";
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgp.DataSource = dt;
            cnx.Close();
        }

        private void btnpannuler_Click(object sender, EventArgs e)
        {
            txtpid_p.Text = null;
            txtpproposition.Text = null;
           
            
        }

        private void btnexamen_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void btnquestion_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Show();
        }
    }
}
