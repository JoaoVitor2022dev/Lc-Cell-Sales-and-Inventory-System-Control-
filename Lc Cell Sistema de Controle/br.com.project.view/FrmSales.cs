﻿using Lc_Cell_Sistema_de_Controle.br.com.project.dao;
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
        decimal price;
        decimal subtotal, total;

        DataTable ShoppingCart = new DataTable();
        public FrmSales()
        {
            InitializeComponent();

            ShoppingCart.Columns.Add("Codigo", typeof(string));
            ShoppingCart.Columns.Add("Produto", typeof(string));
            ShoppingCart.Columns.Add("Qtd", typeof(int));
            ShoppingCart.Columns.Add("Preço", typeof(decimal));
            ShoppingCart.Columns.Add("Subtotal", typeof(decimal));

            ProductTable.DataSource = ShoppingCart;
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                client = cdao.ReturnCustomersCPF(txtCpf.Text);

                if (client != null)
                {
                    txtNameClient.Text = client.Name;
                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }

            }
        }
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               product = pdao.ReturnsProductById(int.Parse(txtCode.Text));

                if (product != null)
                {
                    txtDescription.Text = product.Description;
                    txtPrice.Text = product.Price.ToString();
                }
                else
                {
                    txtCode.Clear();
                    txtCode.Focus();
                }
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtStockQuantity.Text);
            price = decimal.Parse(txtPrice.Text);

            subtotal = qtd * price;

            total += subtotal;

            // adicionando produto no carrinho 
            ShoppingCart.Rows.Add(int.Parse(txtCode.Text), txtDescription.Text, qtd, price, subtotal);

            // adicionar o valor no total 
            txtTotal.Text = total.ToString();

            // limpando os campos 
            txtCode.Clear();
            txtDescription.Clear();
            txtStockQuantity.Clear();
            txtPrice.Clear();

            txtCode.Focus();
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void btnPayment_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
