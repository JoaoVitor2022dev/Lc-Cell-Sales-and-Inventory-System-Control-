using Lc_Cell_Sistema_de_Controle.br.com.projet.connection;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lc_Cell_Sistema_de_Controle.br.com.project.model;
using Mysqlx.Crud;
using System.Data;
using MySqlX.XDevAPI.Relational;

namespace Lc_Cell_Sistema_de_Controle.br.com.project.dao
{
    public class ClientDAO
    {
        private MySqlConnection conexao;
        public ClientDAO()
        {
           this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Register Customer
        public void RegisterCustomer(Client obj)
        {
            try
            {
                // Set COMMAND SQL -insert into
                string sql = @"INSERT INTO tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                  VALUES (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento , @bairro, @cidade, @estado);";

                // Organize the sql command   
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Name);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telephone);
                executacmd.Parameters.AddWithValue("@celular", obj.Phone);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Address);
                executacmd.Parameters.AddWithValue("@numero", obj.Number);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complement);
                executacmd.Parameters.AddWithValue("@bairro", obj.Neighborhood);
                executacmd.Parameters.AddWithValue("@cidade", obj.City);
                executacmd.Parameters.AddWithValue("@estado", obj.State);

                // Execute the sql command
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um error: " + erro);
            }
        }
        #endregion

        #region list customers
        public DataTable ListCustomers()
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable customerTable = new DataTable();
                string sql = "SELECT * FROM tb_clientes;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(customerTable);

                return customerTable;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion
    }
}
