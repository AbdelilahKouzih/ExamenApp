using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btnexamen_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
        }

        private void btnquestion_Click(object sender, EventArgs e)
        {
            Question f = new Question();
            f.Show();
        }

        private void btnproposition_Click(object sender, EventArgs e)
        {
            Proposition f = new Proposition();
            f.Show();
        }
    }
}
