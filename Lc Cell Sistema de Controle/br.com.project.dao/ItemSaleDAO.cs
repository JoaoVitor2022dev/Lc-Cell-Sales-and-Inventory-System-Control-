using Lc_Cell_Sistema_de_Controle.br.com.project.model;
using Lc_Cell_Sistema_de_Controle.br.com.projet.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lc_Cell_Sistema_de_Controle.br.com.project.dao
{
    internal class ItemSaleDAO
    {
        private MySqlConnection conexao;
        public ItemSaleDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Method of registering sales item
        public void RegisteringSalesItem(ItemSale obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_itensvendas (venda_id, produto_id, qtd,subtotal)
                               VALUES (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.Sales_Id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.Product_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

                // 3 - executar o comando sql 
                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ocorreu um erro: {err}");
            }
        }
        #endregion
    }
}
