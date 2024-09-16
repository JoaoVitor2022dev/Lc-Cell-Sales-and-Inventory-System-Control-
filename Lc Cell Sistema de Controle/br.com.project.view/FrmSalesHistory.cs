using Lc_Cell_Sistema_de_Controle.br.com.project.dao;
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
    public partial class FrmSalesHistory : Form
    {
        public FrmSalesHistory()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmSalesHistory_Load(object sender, EventArgs e)
        {
            SaleDAO dao = new SaleDAO();

            SaleTable.DataSource = dao.ListSales();
            SaleTable.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
