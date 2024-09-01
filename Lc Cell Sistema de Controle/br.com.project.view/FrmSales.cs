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
    public partial class FrmSales : Form
    {
        Client client = new Client();
        ClientDAO cdao = new ClientDAO();

        Product product = new Product();
        ProductDAO pdao = new ProductDAO();

        int qtd;
        decimal prico;
        decimal subtotal, total;

        DataTable ShoppingCart = new DataTable();
        public FrmSales()
        {
            InitializeComponent();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                client = cdao.ReturnCustomersCPF(txtCpf.Text);
                txtNameClient.Text = client.Name; 
            }
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
