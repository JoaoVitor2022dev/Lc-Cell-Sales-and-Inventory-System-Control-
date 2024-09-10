using Lc_Cell_Sistema_de_Controle.br.com.projet.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lc_Cell_Sistema_de_Controle.br.com.project.dao
{
    internal class ItemSaleDAO
    {
        private MySqlConnection conexao;
        public ItemSaleDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
    }
}
