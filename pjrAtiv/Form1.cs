using System.Diagnostics.Eventing.Reader;

namespace pjrAtiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Colisao();
            menuStrip1.Visible = false;
        }

        TelaMenu telaMenu = new TelaMenu();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)

        {






        }
        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            long n;
            bool isNumeric = long.TryParse(txtCpf.Text, out n);
            if (isNumeric == false)
            {



            }


        }

        private void lblSenha_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarAcesso_Click(object sender, EventArgs e)
        {

            
            telaMenu.MdiParent = this;
            txtCelular.Visible = false;
            txtCpf.Visible = false;
            txtDataNasc.Visible = false;
            txtNomeCliente.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;
            txtConfirmaSenha.Visible = false;
            txtDataNasc.Visible = false;
            txtGenero.Visible = false;
            lblLogin.Visible = false;
            btnCriarAcesso.Visible = false;
            btnVoltar.Visible = false;
            lblMensagem.Visible = false;

            
            
            telaMenu.Show();
            





        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void Colisao()
        {
            if (telaMenu.Height >= this.MaximumSize.Height)
            {
                telaMenu.Height = telaMenu.Height-1;



            }


        }
        
    }
}