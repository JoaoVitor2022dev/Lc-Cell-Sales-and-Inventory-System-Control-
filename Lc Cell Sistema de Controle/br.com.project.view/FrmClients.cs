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



        }
    }
}
