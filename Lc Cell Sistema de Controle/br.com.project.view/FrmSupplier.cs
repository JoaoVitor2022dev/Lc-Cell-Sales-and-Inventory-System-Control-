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
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier();

                supplier.Name = txtNameClient.Text;
                supplier.Cnpj = txtCnpj.Text;
                supplier.Email = txtEmailClient.Text;
                supplier.Telephone = txtTelephoneClient.Text;
                supplier.Phone = txtPhoneClient.Text;
                supplier.Cep = txtCep.Text;
                supplier.Address = txtAddress.Text;
                supplier.Number = int.Parse(txtNumberHome.Text);
                supplier.Complement = txtComplement.Text;
                supplier.Neighborhood = txtNeighborhood.Text;
                supplier.City = txtCity.Text;
                supplier.State = txtUf.Text;

                SupplierDAO dao = new SupplierDAO();

                dao.RegisterSupplier(supplier);

                SupplierTable.DataSource = dao.ListSupplier();

                TabSupplier.SelectedTab = tabPage2;

                new Helpers().LimparTela(this);
                txtUf.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Todos os campos tem que ser preenchidos.");
            }
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;

                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtAddress.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtNeighborhood.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCity.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }
    }
}
