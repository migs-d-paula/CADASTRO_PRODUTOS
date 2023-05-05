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
            textBoxEXCLUIR.Enabled = false;
            servidor = "Server=localhost;Database=produtos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            atualizar_dataGRID();
        }

        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_produtos;";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTOS = new DataTable();
                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridViewPRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridViewPRODUTOS.Columns["id"].HeaderText = "ID";
                dataGridViewPRODUTOS.Columns["descricao"].HeaderText = "DESCRIÇÃO";
                dataGridViewPRODUTOS.Columns["categoria"].HeaderText = "CATEGORIA";
                dataGridViewPRODUTOS.Columns["preco"].HeaderText = "PREÇO";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_produtos(descricao, categoria, preco) VALUES ('" + textBoxDESCRICAO.Text + "', '" + textBoxCATEGORIA.Text + "', '" + textBoxPRECO.Text + "');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado");

                atualizar_dataGRID();
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
                comando.CommandText = "select * from tbl_produtos;";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTOS = new DataTable();
                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridViewPRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridViewPRODUTOS.Columns["id"].HeaderText = "ID";
                dataGridViewPRODUTOS.Columns["descricao"].HeaderText = "DESCRIÇÃO";
                dataGridViewPRODUTOS.Columns["categoria"].HeaderText = "CATEGORIA";
                dataGridViewPRODUTOS.Columns["preco"].HeaderText = "PREÇO";
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

                atualizar_dataGRID();
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao atualizar produto, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE tbl_produtos SET descricao = '" + textBoxDESCRICAO.Text + "', categoria = '" + textBoxCATEGORIA.Text + "', preco = " + textBoxPRECO.Text + " WHERE id = '" + textBoxEXCLUIR.Text + "';";
                comando.ExecuteNonQuery();
                MessageBox.Show("produto alterado com sucesso");

                atualizar_dataGRID();
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

        private void dataGridViewPRODUTOS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxEXCLUIR.Text = dataGridViewPRODUTOS.CurrentRow.Cells[0].Value.ToString();
            textBoxDESCRICAO.Text = dataGridViewPRODUTOS.CurrentRow.Cells[1].Value.ToString();
            textBoxCATEGORIA.Text = dataGridViewPRODUTOS.CurrentRow.Cells[2].Value.ToString();
            textBoxPRECO.Text = dataGridViewPRODUTOS.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
