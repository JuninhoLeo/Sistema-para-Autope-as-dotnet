namespace Sistema
{
    partial class frmListProd
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
            this.dgvListaProd = new System.Windows.Forms.DataGridView();
            this.lblTextoapres = new System.Windows.Forms.Label();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.gpbOrganizar = new System.Windows.Forms.GroupBox();
            this.rdbAlfabetico = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.rdbBus = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbQtde = new System.Windows.Forms.ComboBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.gpbOrganizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Location = new System.Drawing.Point(284, 297);
            this.dgvListaProd.Name = "dgvListaProd";
            this.dgvListaProd.Size = new System.Drawing.Size(636, 335);
            this.dgvListaProd.TabIndex = 0;
            this.dgvListaProd.DoubleClick += new System.EventHandler(this.DgvListaProd_DoubleClick);
            // 
            // lblTextoapres
            // 
            this.lblTextoapres.AutoSize = true;
            this.lblTextoapres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoapres.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTextoapres.Location = new System.Drawing.Point(235, 247);
            this.lblTextoapres.Name = "lblTextoapres";
            this.lblTextoapres.Size = new System.Drawing.Size(391, 24);
            this.lblTextoapres.TabIndex = 1;
            this.lblTextoapres.Text = "Lista de Produtos Cadastrado no Sistema";
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.gpbOrganizar);
            this.gpbFiltro.Controls.Add(this.btnPesquisar);
            this.gpbFiltro.Controls.Add(this.txtBusca);
            this.gpbFiltro.Controls.Add(this.rdbBus);
            this.gpbFiltro.Location = new System.Drawing.Point(250, 37);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(396, 130);
            this.gpbFiltro.TabIndex = 2;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtrar";
            // 
            // gpbOrganizar
            // 
            this.gpbOrganizar.Controls.Add(this.rdbAlfabetico);
            this.gpbOrganizar.Controls.Add(this.rdbCodigo);
            this.gpbOrganizar.Location = new System.Drawing.Point(203, 17);
            this.gpbOrganizar.Name = "gpbOrganizar";
            this.gpbOrganizar.Size = new System.Drawing.Size(187, 60);
            this.gpbOrganizar.TabIndex = 5;
            this.gpbOrganizar.TabStop = false;
            this.gpbOrganizar.Text = "Organizar por:  ";
            // 
            // rdbAlfabetico
            // 
            this.rdbAlfabetico.AutoSize = true;
            this.rdbAlfabetico.Location = new System.Drawing.Point(6, 26);
            this.rdbAlfabetico.Name = "rdbAlfabetico";
            this.rdbAlfabetico.Size = new System.Drawing.Size(53, 17);
            this.rdbAlfabetico.TabIndex = 1;
            this.rdbAlfabetico.TabStop = true;
            this.rdbAlfabetico.Text = "Nome";
            this.rdbAlfabetico.UseVisualStyleBackColor = true;
            this.rdbAlfabetico.CheckedChanged += new System.EventHandler(this.RdbAlfabetico_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(96, 26);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 0;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.RdbCodigo_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(240, 93);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(150, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(6, 95);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(228, 20);
            this.txtBusca.TabIndex = 3;
            // 
            // rdbBus
            // 
            this.rdbBus.AutoSize = true;
            this.rdbBus.Location = new System.Drawing.Point(6, 60);
            this.rdbBus.Name = "rdbBus";
            this.rdbBus.Size = new System.Drawing.Size(113, 17);
            this.rdbBus.TabIndex = 2;
            this.rdbBus.TabStop = true;
            this.rdbBus.Text = "Buscar por Nome: ";
            this.rdbBus.UseVisualStyleBackColor = true;
            this.rdbBus.CheckedChanged += new System.EventHandler(this.RdbBus_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::Sistema.Properties.Resources.new_add_insert_file_1;
            this.btnUpdate.Location = new System.Drawing.Point(762, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 69);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Sistema.Properties.Resources.recycle_recyclebin_full_delete_trash_1772;
            this.btnDelete.Location = new System.Drawing.Point(853, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 69);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1221, 598);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // cmbQtde
            // 
            this.cmbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQtde.FormattingEnabled = true;
            this.cmbQtde.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbQtde.Location = new System.Drawing.Point(746, 193);
            this.cmbQtde.Name = "cmbQtde";
            this.cmbQtde.Size = new System.Drawing.Size(106, 23);
            this.cmbQtde.TabIndex = 26;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(659, 193);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(85, 15);
            this.lblQtde.TabIndex = 25;
            this.lblQtde.Text = "Quantidade:";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(746, 129);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(87, 22);
            this.txtAno.TabIndex = 24;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(709, 132);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 15);
            this.lblAno.TabIndex = 23;
            this.lblAno.Text = "Ano:";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(746, 96);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(216, 22);
            this.txtModelo.TabIndex = 22;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(685, 100);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(59, 15);
            this.lblModelo.TabIndex = 21;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(729, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(87, 17);
            this.txtID.TabIndex = 18;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(746, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 22);
            this.txtDescricao.TabIndex = 19;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(669, 66);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 15);
            this.lblDescricao.TabIndex = 16;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(746, 162);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(87, 22);
            this.txtValor.TabIndex = 20;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(700, 165);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(44, 15);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(702, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.ForeColor = System.Drawing.Color.Red;
            this.lblObs.Location = new System.Drawing.Point(875, 199);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(234, 13);
            this.lblObs.TabIndex = 27;
            this.lblObs.Text = "**Coloque apenas o valor a SOMAR no estoque";
            // 
            // frmListProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 660);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.cmbQtde);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.lblTextoapres);
            this.Controls.Add(this.dgvListaProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListProd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbOrganizar.ResumeLayout(false);
            this.gpbOrganizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProd;
        private System.Windows.Forms.Label lblTextoapres;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.GroupBox gpbOrganizar;
        private System.Windows.Forms.RadioButton rdbAlfabetico;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.RadioButton rdbBus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbQtde;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblObs;
    }
}