using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjrAtiv
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            TelaCadastro cadastro = new TelaCadastro();
            


            if (Application.OpenForms.OfType<TelaCadastro>().Any()) 
            {
                Application.OpenForms.OfType<TelaCadastro>().First().Close();



            }
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();

            
            if (Application.OpenForms.OfType<TelaLogin>().Any())
            {

                Application.OpenForms.OfType<TelaLogin>().First().Close();


            }
            login.MdiParent = this;
            login.Show();



        }

        private void Banco_Load(object sender, EventArgs e)
        {

        }
    }
}
