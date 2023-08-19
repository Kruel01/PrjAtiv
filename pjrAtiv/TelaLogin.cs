using pjrAtiv.Classes;
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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        
        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
            Conta conta = new Conta();
            Banco f = this.MdiParent as Banco;
            // ParentForm.MainMenuStrip.Items["loginToolStripMenuItem"].Text = "teste";
            ParentForm.MainMenuStrip.Items.Add("teste");
            Control[] controls = this.MdiParent.Controls.Find("menuStrip1", true);
            foreach (Control control in controls) 
            {
                if (control.Name == "menuStrip1")
                {
                    MenuStrip strip = control as MenuStrip;
                    //strip.Items["loginToolStripMenuItem"].Enabled = false;
                    

                }
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
