using Lc_Cell_Sistema_de_Controle.br.com.project.dao;
using Lc_Cell_Sistema_de_Controle.br.com.project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lc_Cell_Sistema_de_Controle.br.com.project.view
{
    public partial class FrmPayments : Form
    {
        Client client = new Client();
        DataTable shoppingCart = new DataTable();
        DateTime currentDate;
        public FrmPayments(Client cliente, DataTable shoppingCart, DateTime currentDate)
        {
            InitializeComponent();
            this.client = cliente;
            this.shoppingCart = shoppingCart;
            this.currentDate = currentDate;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
