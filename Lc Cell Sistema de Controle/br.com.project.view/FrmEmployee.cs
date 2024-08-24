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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                // method of storing data in the model
                Employee employee = new Employee();

                employee.Name = txtNameClient.Text;
                employee.Rg = txtRg.Text;
                employee.Cpf = txtCpf.Text;
                employee.Email = txtEmailClient.Text;
                employee.Password = txtPassword.Text;
                employee.Position = txtPosition.Text; 
                employee.AccessLevel = txtAccessLevel.Text;
                employee.Telephone = txtTelephoneClient.Text;
                employee.Phone = txtPhoneClient.Text;
                employee.Cep = txtCep.Text;
                employee.Address = txtAddress.Text;
                employee.Number = int.Parse(txtNumberHome.Text);
                employee.Complement = txtComplement.Text;
                employee.Neighborhood = txtNeighborhood.Text;
                employee.City = txtCity.Text;
                employee.State = txtUf.Text;

                //invoking the register method
                EmployeeDAO dao = new EmployeeDAO();
                dao.RegisterEmployee(employee);

                // trocar de pagina 
                TabEmployee.SelectedTab = tabPage2;

                // to list table customer
                EmployeeTable.DataSource = dao.ListEmployee();

                // Programmed method for clearing operating Inputs
                new Helpers().LimparTela(this);
                txtUf.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos");
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

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeTable.DefaultCellStyle.ForeColor = Color.Black;
            EmployeeDAO dao = new EmployeeDAO();
            EmployeeTable.DataSource = dao.ListEmployee();
        }
    }
}
