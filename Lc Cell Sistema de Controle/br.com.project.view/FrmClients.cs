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
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // method of storing data in the model

            Client client = new Client();

            client.Name = txtNameClient.Text;
            client.Rg = txtRg.Text; 
            client.Cpf = txtCpf.Text;   
            client.Email = txtEmailClient.Text;
            client.Telephone = txtTelephoneClient.Text;
            client.Phone = txtPhoneClient.Text;
            client.Cep = txtCep.Text;
            client.Address = txtAddress.Text;
            client.Number = int.Parse(txtNumberHome.Text);
            client.Complement = txtComplement.Text;
            client.Neighborhood = txtNeighborhood.Text;
            client.City = txtCity.Text;
            client.State = txtUf.Text;

            //invoking the register method
            ClientDAO dao = new ClientDAO();
            dao.RegisterCustomer(client);
        }

        private void TabelaClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            CustomerTable.DefaultCellStyle.ForeColor = Color.Black;
            ClientDAO dao = new ClientDAO();
            CustomerTable.DataSource = dao.ListCustomers();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            /// cleaning the inputs
            txtNameClient.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtEmailClient.Clear();
            txtTelephoneClient.Clear();
            txtPhoneClient.Clear();
            txtCep.Clear();
            txtAddress.Clear();
            txtNumberHome.Clear();
            txtComplement.Clear();
            txtNeighborhood.Clear();
            txtCity.Clear();
            txtUf.SelectedIndex = -1;
        }
    }
}
