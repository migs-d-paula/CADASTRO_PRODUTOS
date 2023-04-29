using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CADASTRO_PRODUTOS
{
    public partial class FormLISTA : Form
    {
        string servidor;
        string lista;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormLISTA()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=produtos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_produtos(descricao, categoria, preco) VALUES ('" + textBoxDESCRICAO.Text + "', '" + textBoxCATEGORIA.Text + "', '" + textBoxPRECO.Text + "');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado");

                label6.Text = "";

                label4.Enabled = true;
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao cadastrar produto, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "select id, descricao, categoria, preco from tbl_produtos;";
                comando.ExecuteNonQuery();
                MySqlDataReader nome = comando.ExecuteReader();

                label6.Text = "ID    DESCRIÇÃO     CATEGORIA     PREÇO\n\n";

                while (nome.Read())
                {
                    for (int i = 0; i < nome.FieldCount; i++)
                    lista = (nome.GetString(0) + "      " + nome.GetString(1) + "           " + nome.GetString(2) + "              " + nome.GetString(3) + "R$\n");
                    label6.Text = label6.Text + lista;
                }
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void labelEXCLUIR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "DELETE from tbl_produtos where id = '" + textBoxEXCLUIR.Text + "';";
                comando.ExecuteNonQuery();
                MessageBox.Show("produto excluido com sucesso");
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao excluir produto, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
