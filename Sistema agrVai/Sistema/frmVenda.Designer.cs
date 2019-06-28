namespace Sistema
{
    partial class frmVenda
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
            this.components = new System.ComponentModel.Container();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.ComboBox();
            this.rdbCliTodos = new System.Windows.Forms.RadioButton();
            this.rdbCliID = new System.Windows.Forms.RadioButton();
            this.rdbCliNome = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gpbDetalhe = new System.Windows.Forms.GroupBox();
            this.cmbQtde = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtQtdeVenda = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gpbButon = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.gpbPesquisarProd = new System.Windows.Forms.GroupBox();
            this.rdbProdTodos = new System.Windows.Forms.RadioButton();
            this.txtBusca = new System.Windows.Forms.ComboBox();
            this.rdbProdID = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rdbProdNome = new System.Windows.Forms.RadioButton();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblObs1 = new System.Windows.Forms.Label();
            this.lblObs2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpbCliente.SuspendLayout();
            this.gpbDetalhe.SuspendLayout();
            this.gpbButon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.gpbPesquisarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.txtNome);
            this.gpbCliente.Controls.Add(this.rdbCliTodos);
            this.gpbCliente.Controls.Add(this.rdbCliID);
            this.gpbCliente.Controls.Add(this.rdbCliNome);
            this.gpbCliente.Controls.Add(this.btnFiltrar);
            this.gpbCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(494, 93);
            this.gpbCliente.TabIndex = 0;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Pesquisar por Vendedor";
            // 
            // txtNome
            // 
            this.txtNome.FormattingEnabled = true;
            this.txtNome.Location = new System.Drawing.Point(12, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(369, 21);
            this.txtNome.TabIndex = 12;
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // rdbCliTodos
            // 
            this.rdbCliTodos.AutoSize = true;
            this.rdbCliTodos.Location = new System.Drawing.Point(116, 33);
            this.rdbCliTodos.Name = "rdbCliTodos";
            this.rdbCliTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbCliTodos.TabIndex = 11;
            this.rdbCliTodos.Text = "Todos";
            this.rdbCliTodos.UseVisualStyleBackColor = true;
            this.rdbCliTodos.CheckedChanged += new System.EventHandler(this.RdbTodos_CheckedChanged);
            // 
            // rdbCliID
            // 
            this.rdbCliID.AutoSize = true;
            this.rdbCliID.Location = new System.Drawing.Point(74, 33);
            this.rdbCliID.Name = "rdbCliID";
            this.rdbCliID.Size = new System.Drawing.Size(36, 17);
            this.rdbCliID.TabIndex = 10;
            this.rdbCliID.Text = "ID";
            this.rdbCliID.UseVisualStyleBackColor = true;
            this.rdbCliID.CheckedChanged += new System.EventHandler(this.RdbCliID_CheckedChanged);
            // 
            // rdbCliNome
            // 
            this.rdbCliNome.AutoSize = true;
            this.rdbCliNome.Location = new System.Drawing.Point(15, 33);
            this.rdbCliNome.Name = "rdbCliNome";
            this.rdbCliNome.Size = new System.Drawing.Size(53, 17);
            this.rdbCliNome.TabIndex = 9;
            this.rdbCliNome.Text = "Nome";
            this.rdbCliNome.UseVisualStyleBackColor = true;
            this.rdbCliNome.CheckedChanged += new System.EventHandler(this.RdbCliNome_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(387, 54);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "&Search";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // gpbDetalhe
            // 
            this.gpbDetalhe.Controls.Add(this.cmbQtde);
            this.gpbDetalhe.Controls.Add(this.txtId);
            this.gpbDetalhe.Controls.Add(this.lblID);
            this.gpbDetalhe.Controls.Add(this.txtQtdeVenda);
            this.gpbDetalhe.Controls.Add(this.txtCliente);
            this.gpbDetalhe.Controls.Add(this.txtQtde);
            this.gpbDetalhe.Controls.Add(this.txtAno);
            this.gpbDetalhe.Controls.Add(this.txtModelo);
            this.gpbDetalhe.Controls.Add(this.txtDescricao);
            this.gpbDetalhe.Controls.Add(this.txtValor);
            this.gpbDetalhe.Controls.Add(this.lblQuantidade);
            this.gpbDetalhe.Controls.Add(this.lblAno);
            this.gpbDetalhe.Controls.Add(this.lblModelo);
            this.gpbDetalhe.Controls.Add(this.lblDescricao);
            this.gpbDetalhe.Controls.Add(this.lblValor);
            this.gpbDetalhe.Controls.Add(this.lblCliente);
            this.gpbDetalhe.Location = new System.Drawing.Point(12, 262);
            this.gpbDetalhe.Name = "gpbDetalhe";
            this.gpbDetalhe.Size = new System.Drawing.Size(597, 152);
            this.gpbDetalhe.TabIndex = 1;
            this.gpbDetalhe.TabStop = false;
            this.gpbDetalhe.Text = "Detalhes do produto";
            // 
            // cmbQtde
            // 
            this.cmbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQtde.Location = new System.Drawing.Point(498, 91);
            this.cmbQtde.Name = "cmbQtde";
            this.cmbQtde.Size = new System.Drawing.Size(87, 20);
            this.cmbQtde.TabIndex = 44;
            this.cmbQtde.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(77, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(149, 13);
            this.txtId.TabIndex = 43;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "ID da Venda:";
            // 
            // txtQtdeVenda
            // 
            this.txtQtdeVenda.AutoSize = true;
            this.txtQtdeVenda.Location = new System.Drawing.Point(430, 94);
            this.txtQtdeVenda.Name = "txtQtdeVenda";
            this.txtQtdeVenda.Size = new System.Drawing.Size(65, 13);
            this.txtQtdeVenda.TabIndex = 41;
            this.txtQtdeVenda.Text = "Quantidade:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(74, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(297, 20);
            this.txtCliente.TabIndex = 39;
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(498, 24);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(87, 20);
            this.txtQtde.TabIndex = 38;
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(74, 121);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(87, 20);
            this.txtAno.TabIndex = 37;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(74, 95);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(216, 20);
            this.txtModelo.TabIndex = 36;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(74, 69);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 20);
            this.txtDescricao.TabIndex = 34;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(498, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(87, 20);
            this.txtValor.TabIndex = 35;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(378, 28);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(117, 13);
            this.lblQuantidade.TabIndex = 33;
            this.lblQuantidade.Text = "Quantidade disponível:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(42, 125);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 31;
            this.lblAno.Text = "Ano:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(26, 99);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 30;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(13, 73);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 27;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(402, 56);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(93, 13);
            this.lblValor.TabIndex = 28;
            this.lblValor.Text = "Valor por unidade:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(16, 47);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 13);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Vendedor:";
            // 
            // gpbButon
            // 
            this.gpbButon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpbButon.BackColor = System.Drawing.Color.Transparent;
            this.gpbButon.Controls.Add(this.button3);
            this.gpbButon.Controls.Add(this.btnSalvar);
            this.gpbButon.Controls.Add(this.btnNovo);
            this.gpbButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbButon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gpbButon.Location = new System.Drawing.Point(791, 341);
            this.gpbButon.Name = "gpbButon";
            this.gpbButon.Size = new System.Drawing.Size(549, 181);
            this.gpbButon.TabIndex = 2;
            this.gpbButon.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Sistema.Properties.Resources.folder_delete_256_icon_icons_com_75999;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(216, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 128);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackgroundImage = global::Sistema.Properties.Resources.Save_icon_icons_com_73702;
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSalvar.Location = new System.Drawing.Point(18, 26);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(127, 128);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::Sistema.Properties.Resources.new_folder_13775;
            this.btnNovo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(414, 26);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(127, 128);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(625, 120);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(643, 215);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.DoubleClick += new System.EventHandler(this.DgvProduto_DoubleClick);
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(12, 420);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(739, 209);
            this.dgvVenda.TabIndex = 4;
            this.dgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVenda_CellContentClick);
            this.dgvVenda.DoubleClick += new System.EventHandler(this.DgvVenda_DoubleClick);
            // 
            // gpbPesquisarProd
            // 
            this.gpbPesquisarProd.Controls.Add(this.rdbProdTodos);
            this.gpbPesquisarProd.Controls.Add(this.txtBusca);
            this.gpbPesquisarProd.Controls.Add(this.rdbProdID);
            this.gpbPesquisarProd.Controls.Add(this.btnPesquisar);
            this.gpbPesquisarProd.Controls.Add(this.rdbProdNome);
            this.gpbPesquisarProd.Location = new System.Drawing.Point(626, 12);
            this.gpbPesquisarProd.Name = "gpbPesquisarProd";
            this.gpbPesquisarProd.Size = new System.Drawing.Size(516, 93);
            this.gpbPesquisarProd.TabIndex = 1;
            this.gpbPesquisarProd.TabStop = false;
            this.gpbPesquisarProd.Text = "Pesquisar por produtos";
            // 
            // rdbProdTodos
            // 
            this.rdbProdTodos.AutoSize = true;
            this.rdbProdTodos.Location = new System.Drawing.Point(117, 31);
            this.rdbProdTodos.Name = "rdbProdTodos";
            this.rdbProdTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbProdTodos.TabIndex = 13;
            this.rdbProdTodos.Text = "Todos";
            this.rdbProdTodos.UseVisualStyleBackColor = true;
            this.rdbProdTodos.CheckedChanged += new System.EventHandler(this.RdbProdTodos_CheckedChanged);
            // 
            // txtBusca
            // 
            this.txtBusca.FormattingEnabled = true;
            this.txtBusca.Location = new System.Drawing.Point(23, 54);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(369, 21);
            this.txtBusca.TabIndex = 13;
            // 
            // rdbProdID
            // 
            this.rdbProdID.AutoSize = true;
            this.rdbProdID.Location = new System.Drawing.Point(75, 30);
            this.rdbProdID.Name = "rdbProdID";
            this.rdbProdID.Size = new System.Drawing.Size(36, 17);
            this.rdbProdID.TabIndex = 12;
            this.rdbProdID.Text = "ID";
            this.rdbProdID.UseVisualStyleBackColor = true;
            this.rdbProdID.CheckedChanged += new System.EventHandler(this.RdbProdID_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(398, 53);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // rdbProdNome
            // 
            this.rdbProdNome.AutoSize = true;
            this.rdbProdNome.Location = new System.Drawing.Point(16, 30);
            this.rdbProdNome.Name = "rdbProdNome";
            this.rdbProdNome.Size = new System.Drawing.Size(53, 17);
            this.rdbProdNome.TabIndex = 11;
            this.rdbProdNome.Text = "Nome";
            this.rdbProdNome.UseVisualStyleBackColor = true;
            this.rdbProdNome.CheckedChanged += new System.EventHandler(this.RdbProdNome_CheckedChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 120);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(585, 136);
            this.dgvCliente.TabIndex = 5;
            this.dgvCliente.DoubleClick += new System.EventHandler(this.DgvCliente_DoubleClick);
            // 
            // lblObs1
            // 
            this.lblObs1.AutoSize = true;
            this.lblObs1.ForeColor = System.Drawing.Color.Red;
            this.lblObs1.Location = new System.Drawing.Point(15, 104);
            this.lblObs1.Name = "lblObs1";
            this.lblObs1.Size = new System.Drawing.Size(244, 13);
            this.lblObs1.TabIndex = 6;
            this.lblObs1.Text = "** Selecione qual vendedor esta usando o sistema";
            // 
            // lblObs2
            // 
            this.lblObs2.AutoSize = true;
            this.lblObs2.ForeColor = System.Drawing.Color.Red;
            this.lblObs2.Location = new System.Drawing.Point(627, 104);
            this.lblObs2.Name = "lblObs2";
            this.lblObs2.Size = new System.Drawing.Size(142, 13);
            this.lblObs2.TabIndex = 7;
            this.lblObs2.Text = "** Selecione o item desejado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(798, 549);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(160, 61);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(941, 549);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(129, 61);
            this.lblReal.TabIndex = 9;
            this.lblReal.Text = "0,00";
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTimer.Location = new System.Drawing.Point(1205, 9);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(135, 96);
            this.txtTimer.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 662);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblObs2);
            this.Controls.Add(this.lblObs1);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.gpbPesquisarProd);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.gpbButon);
            this.Controls.Add(this.gpbDetalhe);
            this.Controls.Add(this.gpbCliente);
            this.Name = "frmVenda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbDetalhe.ResumeLayout(false);
            this.gpbDetalhe.PerformLayout();
            this.gpbButon.ResumeLayout(false);
            this.gpbButon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.gpbPesquisarProd.ResumeLayout(false);
            this.gpbPesquisarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.GroupBox gpbDetalhe;
        private System.Windows.Forms.GroupBox gpbButon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.GroupBox gpbPesquisarProd;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label txtQtdeVenda;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RadioButton rdbCliID;
        private System.Windows.Forms.RadioButton rdbCliNome;
        private System.Windows.Forms.RadioButton rdbProdID;
        private System.Windows.Forms.RadioButton rdbProdNome;
        private System.Windows.Forms.RadioButton rdbCliTodos;
        private System.Windows.Forms.ComboBox txtNome;
        private System.Windows.Forms.ComboBox txtBusca;
        private System.Windows.Forms.RadioButton rdbProdTodos;
        private System.Windows.Forms.Label lblObs1;
        private System.Windows.Forms.Label lblObs2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.TextBox cmbQtde;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Timer timer1;
    }
}