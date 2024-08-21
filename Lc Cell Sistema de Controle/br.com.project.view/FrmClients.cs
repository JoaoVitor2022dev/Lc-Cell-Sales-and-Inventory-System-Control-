using Lc_Cell_Sistema_de_Controle.br.com.project.dao;
using Lc_Cell_Sistema_de_Controle.br.com.project.model;
using MySqlX.XDevAPI.Relational;
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
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
        private void FrmClients_Load(object sender, EventArgs e)
        {
            CustomerTable.DefaultCellStyle.ForeColor = Color.Black;
            ClientDAO dao = new ClientDAO();
            CustomerTable.DataSource = dao.ListCustomers();
        }
        private void TabelaClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeClient.Text = CustomerTable.CurrentRow.Cells[0].Value.ToString();
            txtNameClient.Text = CustomerTable.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = CustomerTable.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = CustomerTable.CurrentRow.Cells[3].Value.ToString();


            txtEmailClient.Text = CustomerTable.CurrentRow.Cells[4].Value.ToString();
            txtTelephoneClient.Text = CustomerTable.CurrentRow.Cells[5].Value.ToString();
            txtPhoneClient.Text = CustomerTable.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = CustomerTable.CurrentRow.Cells[7].Value.ToString();
            txtAddress.Text = CustomerTable.CurrentRow.Cells[8].Value.ToString();
            txtNumberHome.Text = CustomerTable.CurrentRow.Cells[9].Value.ToString();
            txtComplement.Text = CustomerTable.CurrentRow.Cells[10].Value.ToString();
            txtNeighborhood.Text = CustomerTable.CurrentRow.Cells[11].Value.ToString();
            txtCity.Text = CustomerTable.CurrentRow.Cells[12].Value.ToString();
            txtUf.Text = CustomerTable.CurrentRow.Cells[13].Value.ToString();

            //Update the phone number on the consultation page with the values from the input fields

            TabClient.SelectedTab = tabPage1;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // method of storing data in the model

                Client client = new Client();

                client.Code = int.Parse(txtCodeClient.Text); 
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
                dao.ChangeCustomer(client);

                // change page
                TabClient.SelectedTab = tabPage2;

                // to list table customer
                CustomerTable.DataSource = dao.ListCustomers();

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
            catch (Exception)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
    }
}
