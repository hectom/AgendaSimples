using System;
using System.Windows.Forms;

namespace agenda_simples_t5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            Contato objetoContato = new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text, txtIdade.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
