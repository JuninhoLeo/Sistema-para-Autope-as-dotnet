namespace Sistema
{
    partial class frmCadastrado
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmRelogio = new System.Windows.Forms.Timer(this.components);
            this.dgvListClientes = new System.Windows.Forms.DataGridView();
            this.txtApresentacao = new System.Windows.Forms.Label();
            this.rdbAlfabetico = new System.Windows.Forms.RadioButton();
            this.rdbPorID = new System.Windows.Forms.RadioButton();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rdbPrNome = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.ComboBox();
            this.gpbFiltrar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClientes)).BeginInit();
            this.gpbFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1238, 424);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 46);
            this.label1.TabIndex = 3;
            // 
            // tmRelogio
            // 
            this.tmRelogio.Enabled = true;
            this.tmRelogio.Interval = 1000;
            this.tmRelogio.Tick += new System.EventHandler(this.TmRelogio_Tick);
            // 
            // dgvListClientes
            // 
            this.dgvListClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClientes.Location = new System.Drawing.Point(222, 58);
            this.dgvListClientes.Name = "dgvListClientes";
            this.dgvListClientes.Size = new System.Drawing.Size(1076, 344);
            this.dgvListClientes.TabIndex = 0;
            this.dgvListClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgvListClientes.DoubleClick += new System.EventHandler(this.DgvListClientes_DoubleClick);
            // 
            // txtApresentacao
            // 
            this.txtApresentacao.AutoSize = true;
            this.txtApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApresentacao.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtApresentacao.Location = new System.Drawing.Point(235, 33);
            this.txtApresentacao.Name = "txtApresentacao";
            this.txtApresentacao.Size = new System.Drawing.Size(287, 20);
            this.txtApresentacao.TabIndex = 1;
            this.txtApresentacao.Text = "Lista de Vendedores Cadastrados ";
            // 
            // rdbAlfabetico
            // 
            this.rdbAlfabetico.AutoSize = true;
            this.rdbAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlfabetico.Location = new System.Drawing.Point(21, 56);
            this.rdbAlfabetico.Name = "rdbAlfabetico";
            this.rdbAlfabetico.Size = new System.Drawing.Size(47, 20);
            this.rdbAlfabetico.TabIndex = 5;
            this.rdbAlfabetico.Text = "A-Z";
            this.rdbAlfabetico.UseVisualStyleBackColor = true;
            this.rdbAlfabetico.CheckedChanged += new System.EventHandler(this.RdbAlfabetico_CheckedChanged);
            // 
            // rdbPorID
            // 
            this.rdbPorID.AutoSize = true;
            this.rdbPorID.Checked = true;
            this.rdbPorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPorID.Location = new System.Drawing.Point(21, 79);
            this.rdbPorID.Name = "rdbPorID";
            this.rdbPorID.Size = new System.Drawing.Size(70, 20);
            this.rdbPorID.TabIndex = 6;
            this.rdbPorID.TabStop = true;
            this.rdbPorID.Text = "Codigo";
            this.rdbPorID.UseVisualStyleBackColor = true;
            this.rdbPorID.CheckedChanged += new System.EventHandler(this.RdbPorID_CheckedChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(6, 16);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(45, 18);
            this.lblFiltrar.TabIndex = 5;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 137);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::Sistema.Properties.Resources.search_window_filter_find_6168;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(40, 176);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(131, 124);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // rdbPrNome
            // 
            this.rdbPrNome.AutoSize = true;
            this.rdbPrNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrNome.Location = new System.Drawing.Point(21, 105);
            this.rdbPrNome.Name = "rdbPrNome";
            this.rdbPrNome.Size = new System.Drawing.Size(63, 20);
            this.rdbPrNome.TabIndex = 7;
            this.rdbPrNome.Text = "Nome";
            this.rdbPrNome.UseVisualStyleBackColor = true;
            this.rdbPrNome.CheckedChanged += new System.EventHandler(this.RdbPrNome_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.FormattingEnabled = true;
            this.txtNome.Location = new System.Drawing.Point(50, 134);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(130, 21);
            this.txtNome.TabIndex = 5;
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // gpbFiltrar
            // 
            this.gpbFiltrar.Controls.Add(this.txtNome);
            this.gpbFiltrar.Controls.Add(this.rdbPrNome);
            this.gpbFiltrar.Controls.Add(this.btnFiltrar);
            this.gpbFiltrar.Controls.Add(this.lblNome);
            this.gpbFiltrar.Controls.Add(this.lblFiltrar);
            this.gpbFiltrar.Controls.Add(this.rdbPorID);
            this.gpbFiltrar.Controls.Add(this.rdbAlfabetico);
            this.gpbFiltrar.Location = new System.Drawing.Point(12, 58);
            this.gpbFiltrar.Name = "gpbFiltrar";
            this.gpbFiltrar.Size = new System.Drawing.Size(204, 319);
            this.gpbFiltrar.TabIndex = 4;
            this.gpbFiltrar.TabStop = false;
            // 
            // frmCadastrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 509);
            this.ControlBox = false;
            this.Controls.Add(this.gpbFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtApresentacao);
            this.Controls.Add(this.dgvListClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadastrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClientes)).EndInit();
            this.gpbFiltrar.ResumeLayout(false);
            this.gpbFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmRelogio;
        private System.Windows.Forms.DataGridView dgvListClientes;
        private System.Windows.Forms.Label txtApresentacao;
        private System.Windows.Forms.RadioButton rdbAlfabetico;
        private System.Windows.Forms.RadioButton rdbPorID;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rdbPrNome;
        private System.Windows.Forms.ComboBox txtNome;
        private System.Windows.Forms.GroupBox gpbFiltrar;
    }
}