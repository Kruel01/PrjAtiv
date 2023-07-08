using System.Diagnostics.Eventing.Reader;

namespace pjrAtiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


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







            MessageBox.Show("Cadastro criado");






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

            int reposition;
            reposition = 12;
            if (telaMenu.Height >= this.MaximumSize.Height)
            {
                telaMenu.Height -= reposition;




            }


        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void Esconder()
        {
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


        }
    }
}