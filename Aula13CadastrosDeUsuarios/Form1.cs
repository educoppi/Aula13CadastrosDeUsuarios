using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula13CadastrosDeUsuarios
{
    public partial class Form1 : Form
    {

        void limpaCampos()
        {
            txtNome.Text = null;
            txtIdade.Text = null;
            txtRua.Text = null;
            txtCidade.Text = null;
        }

        public void AtualizaInterface()
        {
            listView1.Clear();

            for (int i = 0; i < pessoas.Count(); i++)
            {
                listView1.Items.Add(pessoas[i].nome);
            }
        }

        public bool camposPreenchidos(TextBox nome, TextBox idade, TextBox rua, TextBox cidade)
        {

            if (nome.Text == "" || idade.Text == "" || rua.Text == "" || cidade.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        List<Pessoa> pessoas = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (camposPreenchidos(txtNome, txtIdade, txtRua, txtCidade) == false)
            {
                MessageBox.Show("Preencha todos os campos!!!");
                limpaCampos();
                return;
            }

            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string rua = txtRua.Text;
            string cidade = txtCidade.Text;

            Pessoa pessoa = new Pessoa(nome, idade, rua, cidade);
            pessoas.Add(pessoa);

            limpaCampos();
            AtualizaInterface();
        }
    }
}
