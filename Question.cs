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
    public partial class Question : Form
    {
        public Question()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "select * from Question";
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrq1.DataSource = dt;
            cnx.Close();
        }

        private void btnqajouter_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "insert into Question(id_q,t_ype,id_pro,question) values('" + txtqid_q.Text + "','" + txtqtype.Text + "','" + txtqid_pro.Text + "','" + txtqquestion.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void txtid_q_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnqmodifier_Click(object sender, EventArgs e)
        {
          
            connection();
            cmd.CommandText = "UPDATE Question set t_ype ='" + txtqtype.Text + "' , question= '" + txtqquestion.Text + "' where id_q= '" + txtqid_q.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnqannuler_Click(object sender, EventArgs e)
        {
            txtqid_q.Text = null;
            txtqtype.Text = null;
            txtqid_pro.Text = null;
            txtqquestion.Text = null;
        }

        private void btnqsupprimer_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "DELETE FROM Question where id_q ='" + txtqid_q.Text + "' ";
            cmd.ExecuteNonQuery(); 
            cnx.Close();
        }

        private void btnexamen_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void btnproposition_Click(object sender, EventArgs e)
        {
            Proposition p = new Proposition();
            p.Show();
        }
    }
}
