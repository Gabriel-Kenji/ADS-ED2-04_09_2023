using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS_ED2_04_09_2023
{
    public partial class Form1 : Form
    {
        public Contatos contatos = new Contatos();
        public Form1()
        {
            InitializeComponent();
            txtDia.Text = "0";
            txtMes.Text = "0";
            txtAno.Text = "0000";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gContato.Columns.Clear();
            string emailPesquisa = txtEmail.Text;
            Contato contatoEncontrado = contatos.pesquisar(emailPesquisa);
            if (contatoEncontrado != null)
            {
                var conta = new []{
                    new {email = contatoEncontrado.email, nome = contatoEncontrado.nome , dtNasc = contatoEncontrado.dtNasc.ToString(), idade = contatoEncontrado.getIdade(), telefono = contatoEncontrado.getTelefonePrincipal()},
                };
                var bindingList = new BindingList<Telefone>(contatoEncontrado.telefones);
                var source = new BindingSource(bindingList, null);
                
                gTelefones.DataSource = source;
                gContato.DataSource = conta;
            }
            else
            {
                MessageBox.Show("Contato não encontrado" , "Erro", MessageBoxButtons.OK);
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            int dia = int.Parse(txtDia.Text);
            int mes =  int.Parse(txtMes.Text);
            int ano =  int.Parse(txtAno.Text);
            Data data = new Data();
            data.setData(dia, mes, ano);
            Contato contato = new Contato(email, nome, data);
            contatos.adicionar(contato);
            MessageBox.Show(contatos.listar() , "aa", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailPesquisa = txtEmail.Text;
            Contato contatoEncontrado = contatos.pesquisar(emailPesquisa);
            if (contatoEncontrado != null)
            {
                string numero = txtNumero.Text;
                string tipo = cbTipo.Text;
                bool principal = cbPrincipal.Checked;
                Telefone novoTelefone = new Telefone(tipo, numero, principal);
                contatoEncontrado.adicionarTelefone(novoTelefone);
                MessageBox.Show("Telefone adicionado" , "Sucesso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Contato não encontrado" , "Erro", MessageBoxButtons.OK);
            }
        }

        private void gContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string emailPesquisa = txtEmail.Text;
            Contato contatoEncontrado = contatos.pesquisar(emailPesquisa);
            if (contatoEncontrado != null)
            {
                contatos.remover(contatoEncontrado);
                MessageBox.Show("Contato Removido com sucesso!!!" , "Sucesso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Contato não encontrado" , "Erro", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gContato.Columns.Clear();
            gContato.Columns.Add("email", "E-mail");
            gContato.Columns.Add("nome", "Nome");
            gContato.Columns.Add("dtnasc", "Data Nasc");
            gContato.Columns.Add("idade", "Idade");
            gContato.Columns.Add("telefone", "Telefone");
            string js = "";
            foreach (var conta in contatos.agenda)
            {
                gContato.Rows.Add(new object[] { conta.email, conta.nome, conta.dtNasc.ToString(), conta.getIdade().ToString(), conta.getTelefonePrincipal() });
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string emailPesquisa = txtEmail.Text;
            Contato contatoEncontrado = contatos.pesquisar(emailPesquisa);
            if (contatoEncontrado != null)
            {
                string nome = txtNome.Text;
                int dia = int.Parse(txtDia.Text);
                int mes =  int.Parse(txtMes.Text);
                int ano =  int.Parse(txtAno.Text);
                Data novaDataNasc = new Data();
                novaDataNasc.setData(dia, mes, ano);
                Contato contatoModificado = new Contato(contatoEncontrado.email, nome, novaDataNasc);
                if (contatos.alterar(contatoModificado))
                {
                    MessageBox.Show("Contato alterado com sucesso!!!" , "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Falha ao alterar contato" , "Erro", MessageBoxButtons.OK);

                }
                
            }
            else
            {
                MessageBox.Show("Contato não encontrado" , "Erro", MessageBoxButtons.OK);
            }
        }
    }
}