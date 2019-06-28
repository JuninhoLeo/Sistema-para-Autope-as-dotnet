namespace Sistema
{
    partial class frmCliente
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNomecli = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbNem = new System.Windows.Forms.RadioButton();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.gpbLocalização = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gpbCliente.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            this.gpbLocalização.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(103, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblNomecli
            // 
            this.lblNomecli.AutoSize = true;
            this.lblNomecli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomecli.Location = new System.Drawing.Point(77, 58);
            this.lblNomecli.Name = "lblNomecli";
            this.lblNomecli.Size = new System.Drawing.Size(53, 16);
            this.lblNomecli.TabIndex = 3;
            this.lblNomecli.Text = "Nome:";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.Location = new System.Drawing.Point(2, 23);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(79, 16);
            this.lblEndereço.TabIndex = 4;
            this.lblEndereço.Text = "Endereço:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(132, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(61, 19);
            this.txtID.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(132, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(459, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(74, 387);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(229, 29);
            this.txtTelefone.TabIndex = 7;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(1240, 585);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(105, 49);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "&Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(75, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "e-mail:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(15, 47);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 16);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(39, 71);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(42, 16);
            this.lblCep.TabIndex = 15;
            this.lblCep.Text = "CEP:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(36, 133);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(94, 16);
            this.lblNascimento.TabIndex = 16;
            this.lblNascimento.Text = "Nascimento:";
            this.lblNascimento.Click += new System.EventHandler(this.LblNascimento_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(89, 108);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 16);
            this.lblCPF.TabIndex = 18;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(85, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(130, 21);
            this.txtNumero.TabIndex = 20;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(85, 21);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(459, 21);
            this.txtEndereco.TabIndex = 19;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(85, 69);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(274, 21);
            this.txtCEP.TabIndex = 21;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(132, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(459, 21);
            this.txtNome.TabIndex = 23;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(132, 105);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(162, 21);
            this.txtCPF.TabIndex = 24;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasc.Location = new System.Drawing.Point(14, 22);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(91, 19);
            this.rdbMasc.TabIndex = 25;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFem.Location = new System.Drawing.Point(14, 49);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(85, 19);
            this.rdbFem.TabIndex = 26;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbNem
            // 
            this.rdbNem.AutoSize = true;
            this.rdbNem.Checked = true;
            this.rdbNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNem.Location = new System.Drawing.Point(14, 76);
            this.rdbNem.Name = "rdbNem";
            this.rdbNem.Size = new System.Drawing.Size(79, 19);
            this.rdbNem.TabIndex = 27;
            this.rdbNem.TabStop = true;
            this.rdbNem.Text = "Nenhum";
            this.rdbNem.UseVisualStyleBackColor = true;
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.lblTelefone);
            this.gpbCliente.Controls.Add(this.txtTel);
            this.gpbCliente.Controls.Add(this.txtNascimento);
            this.gpbCliente.Controls.Add(this.txtEmail);
            this.gpbCliente.Controls.Add(this.gpbSexo);
            this.gpbCliente.Controls.Add(this.lblID);
            this.gpbCliente.Controls.Add(this.lblNomecli);
            this.gpbCliente.Controls.Add(this.txtCPF);
            this.gpbCliente.Controls.Add(this.txtID);
            this.gpbCliente.Controls.Add(this.txtNome);
            this.gpbCliente.Controls.Add(this.txtTelefone);
            this.gpbCliente.Controls.Add(this.lblEmail);
            this.gpbCliente.Controls.Add(this.lblCPF);
            this.gpbCliente.Controls.Add(this.lblNascimento);
            this.gpbCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(617, 256);
            this.gpbCliente.TabIndex = 28;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Dados do Vendedor";
            this.gpbCliente.Enter += new System.EventHandler(this.GpbCliente_Enter);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(54, 160);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(74, 16);
            this.lblTelefone.TabIndex = 30;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(132, 158);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(95, 21);
            this.txtTel.TabIndex = 31;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Location = new System.Drawing.Point(132, 131);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(69, 21);
            this.txtNascimento.TabIndex = 29;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbMasc);
            this.gpbSexo.Controls.Add(this.rdbFem);
            this.gpbSexo.Controls.Add(this.rdbNem);
            this.gpbSexo.Location = new System.Drawing.Point(430, 111);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(161, 110);
            this.gpbSexo.TabIndex = 28;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // gpbLocalização
            // 
            this.gpbLocalização.Controls.Add(this.txtUF);
            this.gpbLocalização.Controls.Add(this.txtCidade);
            this.gpbLocalização.Controls.Add(this.lblUF);
            this.gpbLocalização.Controls.Add(this.lblCidade);
            this.gpbLocalização.Controls.Add(this.txtEndereco);
            this.gpbLocalização.Controls.Add(this.lblCep);
            this.gpbLocalização.Controls.Add(this.lblNumero);
            this.gpbLocalização.Controls.Add(this.lblEndereço);
            this.gpbLocalização.Controls.Add(this.txtNumero);
            this.gpbLocalização.Controls.Add(this.txtCEP);
            this.gpbLocalização.Location = new System.Drawing.Point(646, 23);
            this.gpbLocalização.Name = "gpbLocalização";
            this.gpbLocalização.Size = new System.Drawing.Size(558, 210);
            this.gpbLocalização.TabIndex = 29;
            this.gpbLocalização.TabStop = false;
            this.gpbLocalização.Text = "Lougradouro";
            this.gpbLocalização.Enter += new System.EventHandler(this.GpbLocalização_Enter);
            // 
            // txtUF
            // 
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(85, 117);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(130, 21);
            this.txtUF.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(85, 93);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(130, 21);
            this.txtCidade.TabIndex = 24;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(49, 119);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(32, 16);
            this.lblUF.TabIndex = 23;
            this.lblUF.Text = "UF:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(19, 95);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(62, 16);
            this.lblCidade.TabIndex = 22;
            this.lblCidade.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 77);
            this.label1.TabIndex = 36;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(176, 350);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1028, 282);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            this.dgvClientes.DoubleClick += new System.EventHandler(this.DgvClientes_DoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::Sistema.Properties.Resources.new_add_insert_file_1;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(688, 265);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 69);
            this.btnNovo.TabIndex = 35;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click_2);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Sistema.Properties.Resources.Cancel_icon_icons_com_73703;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1073, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 69);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::Sistema.Properties.Resources.recycle_recyclebin_full_delete_trash_1772;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(842, 265);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(65, 69);
            this.btnRemover.TabIndex = 31;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::Sistema.Properties.Resources.refresh_file_icon_icons_com_69963;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(919, 265);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(65, 69);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::Sistema.Properties.Resources.edit_icon_icons_com_66118;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(996, 265);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 69);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::Sistema.Properties.Resources.new_add_user_16734__1_;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(765, 265);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(65, 69);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1357, 646);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.gpbLocalização);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gpbCliente);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbLocalização.ResumeLayout(false);
            this.gpbLocalização.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNomecli;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbNem;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.GroupBox gpbLocalização;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}