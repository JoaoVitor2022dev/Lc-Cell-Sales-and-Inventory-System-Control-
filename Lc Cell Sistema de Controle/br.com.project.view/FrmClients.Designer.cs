﻿namespace Lc_Cell_Sistema_de_Controle.br.com.project.view
{
    partial class FrmClients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TabClient = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtUf = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtPhoneClient = new System.Windows.Forms.MaskedTextBox();
            this.txtTelephoneClient = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNumberHome = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TabelaClient = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.TabClient.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 155);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Clientes ";
            // 
            // TabClient
            // 
            this.TabClient.Controls.Add(this.tabPage1);
            this.TabClient.Controls.Add(this.tabPage2);
            this.TabClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabClient.Location = new System.Drawing.Point(3, 162);
            this.TabClient.Name = "TabClient";
            this.TabClient.SelectedIndex = 0;
            this.TabClient.Size = new System.Drawing.Size(927, 405);
            this.TabClient.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtUf);
            this.tabPage1.Controls.Add(this.txtCep);
            this.tabPage1.Controls.Add(this.txtPhoneClient);
            this.tabPage1.Controls.Add(this.txtTelephoneClient);
            this.tabPage1.Controls.Add(this.txtRg);
            this.tabPage1.Controls.Add(this.txtCpf);
            this.tabPage1.Controls.Add(this.txtNumberHome);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtNeighborhood);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtComplement);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtEmailClient);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNameClient);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CodeClient);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtUf
            // 
            this.txtUf.FormattingEnabled = true;
            this.txtUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtUf.Location = new System.Drawing.Point(429, 334);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(151, 26);
            this.txtUf.TabIndex = 34;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(473, 160);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(131, 26);
            this.txtCep.TabIndex = 33;
            // 
            // txtPhoneClient
            // 
            this.txtPhoneClient.Location = new System.Drawing.Point(114, 203);
            this.txtPhoneClient.Mask = "(00) 00000-0000";
            this.txtPhoneClient.Name = "txtPhoneClient";
            this.txtPhoneClient.Size = new System.Drawing.Size(215, 26);
            this.txtPhoneClient.TabIndex = 32;
            // 
            // txtTelephoneClient
            // 
            this.txtTelephoneClient.Location = new System.Drawing.Point(114, 164);
            this.txtTelephoneClient.Mask = "(00) 0000-0000";
            this.txtTelephoneClient.Name = "txtTelephoneClient";
            this.txtTelephoneClient.Size = new System.Drawing.Size(215, 26);
            this.txtTelephoneClient.TabIndex = 31;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(565, 29);
            this.txtRg.Mask = "00,000,000-00";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(131, 26);
            this.txtRg.TabIndex = 30;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(565, 66);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(131, 26);
            this.txtCpf.TabIndex = 29;
            // 
            // txtNumberHome
            // 
            this.txtNumberHome.Location = new System.Drawing.Point(249, 292);
            this.txtNumberHome.Name = "txtNumberHome";
            this.txtNumberHome.Size = new System.Drawing.Size(106, 26);
            this.txtNumberHome.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(163, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "Número:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(384, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "UF: ";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(500, 250);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(270, 26);
            this.txtCity.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(425, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cidade: ";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(87, 334);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(270, 26);
            this.txtNeighborhood.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Bairro:";
            // 
            // txtComplement
            // 
            this.txtComplement.Location = new System.Drawing.Point(149, 251);
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(270, 26);
            this.txtComplement.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Complemento: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(473, 198);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 26);
            this.txtAddress.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(412, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "WhatsApp: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(521, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG: ";
            // 
            // txtEmailClient
            // 
            this.txtEmailClient.Location = new System.Drawing.Point(114, 118);
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.Size = new System.Drawing.Size(353, 26);
            this.txtEmailClient.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail: ";
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(114, 73);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(353, 26);
            this.txtNameClient.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome: ";
            // 
            // CodeClient
            // 
            this.CodeClient.Location = new System.Drawing.Point(114, 34);
            this.CodeClient.Name = "CodeClient";
            this.CodeClient.Size = new System.Drawing.Size(131, 26);
            this.CodeClient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TabelaClient);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.Navy;
            this.BtnNew.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.Color.White;
            this.BtnNew.Location = new System.Drawing.Point(36, 591);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(193, 54);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "Novo";
            this.BtnNew.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(243, 591);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(193, 54);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Salvar";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.BtnEdit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.Black;
            this.BtnEdit.Location = new System.Drawing.Point(462, 591);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(193, 54);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(685, 591);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(193, 54);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Deletar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(157, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(383, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(85, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 22);
            this.label16.TabIndex = 2;
            this.label16.Text = "Nome:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(546, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(193, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // TabelaClient
            // 
            this.TabelaClient.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabelaClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaClient.Location = new System.Drawing.Point(0, 73);
            this.TabelaClient.Name = "TabelaClient";
            this.TabelaClient.Size = new System.Drawing.Size(923, 300);
            this.TabelaClient.TabIndex = 7;
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 657);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TabClient);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClients";
            this.Text = "Cadastrar Formulário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabClient.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabClient;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox CodeClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumberHome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtPhoneClient;
        private System.Windows.Forms.MaskedTextBox txtTelephoneClient;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.ComboBox txtUf;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView TabelaClient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label16;
    }
}