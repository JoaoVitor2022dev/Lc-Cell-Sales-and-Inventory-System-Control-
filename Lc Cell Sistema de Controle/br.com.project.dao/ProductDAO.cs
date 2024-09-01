using Lc_Cell_Sistema_de_Controle.br.com.project.model;
using Lc_Cell_Sistema_de_Controle.br.com.projet.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lc_Cell_Sistema_de_Controle.br.com.project.dao
{
    internal class ProductDAO
    {
        private MySqlConnection conexao;
        public ProductDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region Register Product 
        public void RegisterProduct(Product obj)
        {
            try
            {
                string sql = "INSERT INTO tb_produtos (descricao, preco, qtd_estoque, for_id ) " +
                             "VALUES (@descricao, @preco, @qtd , @for_id  );";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Description);
                executacmd.Parameters.AddWithValue("@preco", obj.Price);
                executacmd.Parameters.AddWithValue("@qtd", obj.StockQuantity);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }
        #endregion

        #region list products
        public DataTable listProducts()
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT 
                            tb_produtos.id AS ""Código"", 
                            tb_produtos.descricao AS ""Descrição"",
                            tb_produtos.qtd_estoque AS ""Qtd Estoque"", 
                            tb_produtos.preco AS ""Preço"",
                            tb_fornecedores.nome AS ""Fornecedor""
                            FROM 
                            tb_produtos
                            JOIN 
                            tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaProduto);
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion

        #region Edit Product
        public void EdictProduct(Product obj)
        {
            try
            {
                string sql = "UPDATE tb_produtos SET descricao = @descricao, preco = @preco, qtd_estoque = @qtd, for_id = @for_id WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Description);
                executacmd.Parameters.AddWithValue("@preco", obj.Price);
                executacmd.Parameters.AddWithValue("@qtd", obj.StockQuantity);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto Alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }
        #endregion
    }
}
