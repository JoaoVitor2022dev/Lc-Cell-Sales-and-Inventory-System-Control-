namespace Lc_Cell_Sistema_de_Controle.br.com.project.view
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCustomerRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClientConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegisterEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEmployeeConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegisterSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSupplierConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegisterProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProductConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewSale = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHistorySale = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExitTheSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCliente,
            this.MenuEmployee,
            this.MenuSupplier,
            this.MenuProduct,
            this.MenuSales,
            this.MenuSettings});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1098, 56);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuCliente
            // 
            this.MenuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCustomerRegister,
            this.MenuClientConsultation});
            this.MenuCliente.Image = global::Lc_Cell_Sistema_de_Controle.Properties.Resources._4308184_client_costs_employee_finance_money_icon;
            this.MenuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(109, 52);
            this.MenuCliente.Text = "Clientes";
            // 
            // MenuCustomerRegister
            // 
            this.MenuCustomerRegister.Name = "MenuCustomerRegister";
            this.MenuCustomerRegister.Size = new System.Drawing.Size(180, 22);
            this.MenuCustomerRegister.Text = "Cadastrar Cliente";
            this.MenuCustomerRegister.Click += new System.EventHandler(this.MenuCustomerRegister_Click);
            // 
            // MenuClientConsultation
            // 
            this.MenuClientConsultation.Name = "MenuClientConsultation";
            this.MenuClientConsultation.Size = new System.Drawing.Size(180, 22);
            this.MenuClientConsultation.Text = "Consultar Cliente";
            // 
            // MenuEmployee
            // 
            this.MenuEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegisterEmployee,
            this.MenuEmployeeConsultation});
            this.MenuEmployee.Image = global::Lc_Cell_Sistema_de_Controle.Properties.Resources._2530821_business_man_employee_general_human_member_icon;
            this.MenuEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuEmployee.Name = "MenuEmployee";
            this.MenuEmployee.Size = new System.Drawing.Size(135, 52);
            this.MenuEmployee.Text = "Funcionários";
            // 
            // MenuRegisterEmployee
            // 
            this.MenuRegisterEmployee.Name = "MenuRegisterEmployee";
            this.MenuRegisterEmployee.Size = new System.Drawing.Size(191, 22);
            this.MenuRegisterEmployee.Text = "Cadastrar Funcionário";
            // 
            // MenuEmployeeConsultation
            // 
            this.MenuEmployeeConsultation.Name = "MenuEmployeeConsultation";
            this.MenuEmployeeConsultation.Size = new System.Drawing.Size(191, 22);
            this.MenuEmployeeConsultation.Text = "Consultar Funcionário";
            // 
            // MenuSupplier
            // 
            this.MenuSupplier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegisterSupplier,
            this.MenuSupplierConsultation});
            this.MenuSupplier.Image = global::Lc_Cell_Sistema_de_Controle.Properties.Resources._4172394_goods_merchandise_stock_supply_vendibles_icon;
            this.MenuSupplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuSupplier.Name = "MenuSupplier";
            this.MenuSupplier.Size = new System.Drawing.Size(138, 52);
            this.MenuSupplier.Text = "Fornecedores";
            // 
            // MenuRegisterSupplier
            // 
            this.MenuRegisterSupplier.Name = "MenuRegisterSupplier";
            this.MenuRegisterSupplier.Size = new System.Drawing.Size(198, 22);
            this.MenuRegisterSupplier.Text = "Cadastrar Fornecedores";
            // 
            // MenuSupplierConsultation
            // 
            this.MenuSupplierConsultation.Name = "MenuSupplierConsultation";
            this.MenuSupplierConsultation.Size = new System.Drawing.Size(198, 22);
            this.MenuSupplierConsultation.Text = "Consulta Fornecedores";
            // 
            // MenuProduct
            // 
            this.MenuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegisterProduct,
            this.MenuProductConsultation});
            this.MenuProduct.Image = global::Lc_Cell_Sistema_de_Controle.Properties.Resources._6843036_courier_deliver_delivery_package_product_icon;
            this.MenuProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.Size = new System.Drawing.Size(115, 52);
            this.MenuProduct.Text = "Produtos";
            // 
            // MenuRegisterProduct
            // 
            this.MenuRegisterProduct.Name = "MenuRegisterProduct";
            this.MenuRegisterProduct.Size = new System.Drawing.Size(175, 22);
            this.MenuRegisterProduct.Text = "Cadastrar Produtos";
            // 
            // MenuProductConsultation
            // 
            this.MenuProductConsultation.Name = "MenuProductConsultation";
            this.MenuProductConsultation.Size = new System.Drawing.Size(175, 22);
            this.MenuProductConsultation.Text = "Consulta Produtos ";
            // 
            // MenuSales
            // 
            this.MenuSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewSale,
            this.MenuHistorySale});
            this.MenuSales.Image = global::Lc_Cell_Sistema_de_Controle.Properties.Resources._465074_cart_purchase_shopping_basket_buy_icon;
            this.MenuSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuSales.Name = "MenuSales";
            this.MenuSales.Size = new System.Drawing.Size(104, 52);
            this.MenuSales.Text = "Vendas";
            // 
            // MenuNewSale
            // 
            this.MenuNewSale.Name = "MenuNewSale";
            this.MenuNewSale.Size = new System.Drawing.Size(173, 22);
            this.MenuNewSale.Text = "Nova Venda";
            this.MenuNewSale.Click += new System.EventHandler(this.registrarVendaToolStripMenuItem_Click);
            // 
            // MenuHistorySale
            // 
            this.MenuHistorySale.Name = "MenuHistorySale";
            this.MenuHistorySale.Size = new System.Drawing.Size(173, 22);
            this.MenuHistorySale.Text = "Histórico de Venda";
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuChangeUser,
            this.MenuExitTheSystem});
            this.MenuSettings.Image = global::Lc_Cell_Sistema_de_Controle.Properties.Resources._211670_b_gear_icon;
            this.MenuSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(144, 52);
            this.MenuSettings.Text = "Configuraçôes";
            // 
            // MenuChangeUser
            // 
            this.MenuChangeUser.Name = "MenuChangeUser";
            this.MenuChangeUser.Size = new System.Drawing.Size(154, 22);
            this.MenuChangeUser.Text = "Trocar Usuário";
            // 
            // MenuExitTheSystem
            // 
            this.MenuExitTheSystem.Name = "MenuExitTheSystem";
            this.MenuExitTheSystem.Size = new System.Drawing.Size(154, 22);
            this.MenuExitTheSystem.Text = "Sair do Sistema";
            this.MenuExitTheSystem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Data Atual:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel2.Text = "18/09/2024";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel3.Text = "Hora Atual:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel4.Text = "17:55:00";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel5.Text = "Usuário Logado:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel6.Text = "Joao Vitor Mocambite";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lc_Cell_Sistema_de_Controle.Properties.Resources.logo_lc_cell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 719);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Name = "FrmMenu";
            this.Text = "MENU LC CELL";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuEmployee;
        private System.Windows.Forms.ToolStripMenuItem MenuSupplier;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct;
        private System.Windows.Forms.ToolStripMenuItem MenuSales;
        private System.Windows.Forms.ToolStripMenuItem MenuCustomerRegister;
        private System.Windows.Forms.ToolStripMenuItem MenuClientConsultation;
        private System.Windows.Forms.ToolStripMenuItem MenuRegisterEmployee;
        private System.Windows.Forms.ToolStripMenuItem MenuEmployeeConsultation;
        private System.Windows.Forms.ToolStripMenuItem MenuRegisterSupplier;
        private System.Windows.Forms.ToolStripMenuItem MenuSupplierConsultation;
        private System.Windows.Forms.ToolStripMenuItem MenuRegisterProduct;
        private System.Windows.Forms.ToolStripMenuItem MenuProductConsultation;
        private System.Windows.Forms.ToolStripMenuItem MenuNewSale;
        private System.Windows.Forms.ToolStripMenuItem MenuHistorySale;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuChangeUser;
        private System.Windows.Forms.ToolStripMenuItem MenuExitTheSystem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
    }
}