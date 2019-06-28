namespace Sistema
{
    partial class frmRelProdutos
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
            this.rdbQtde = new System.Windows.Forms.RadioButton();
            this.rdbValor = new System.Windows.Forms.RadioButton();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtRel = new System.Windows.Forms.TextBox();
            this.gpbFiltro.SuspendLayout();
            this.gpbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbQtde
            // 
            this.rdbQtde.AutoSize = true;
            this.rdbQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQtde.Location = new System.Drawing.Point(29, 52);
            this.rdbQtde.Name = "rdbQtde";
            this.rdbQtde.Size = new System.Drawing.Size(214, 33);
            this.rdbQtde.TabIndex = 0;
            this.rdbQtde.Text = "Por Quantidade";
            this.rdbQtde.UseVisualStyleBackColor = true;
            this.rdbQtde.CheckedChanged += new System.EventHandler(this.RdbQtde_CheckedChanged);
            // 
            // rdbValor
            // 
            this.rdbValor.AutoSize = true;
            this.rdbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbValor.Location = new System.Drawing.Point(29, 93);
            this.rdbValor.Name = "rdbValor";
            this.rdbValor.Size = new System.Drawing.Size(140, 33);
            this.rdbValor.TabIndex = 1;
            this.rdbValor.Text = "Por Valor";
            this.rdbValor.UseVisualStyleBackColor = true;
            this.rdbValor.CheckedChanged += new System.EventHandler(this.RdbValor_CheckedChanged);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.button1);
            this.gpbFiltro.Controls.Add(this.rdbTodos);
            this.gpbFiltro.Controls.Add(this.gpbOrdenar);
            this.gpbFiltro.Controls.Add(this.btnFiltrar);
            this.gpbFiltro.Controls.Add(this.txtRel);
            this.gpbFiltro.Controls.Add(this.rdbQtde);
            this.gpbFiltro.Controls.Add(this.rdbValor);
            this.gpbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFiltro.Location = new System.Drawing.Point(214, 76);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(995, 328);
            this.gpbFiltro.TabIndex = 3;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = " Gerar Relatório de Produtos";
            this.gpbFiltro.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Sistema.Properties.Resources.exit_closethesession_close_6317;
            this.button1.Location = new System.Drawing.Point(878, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 98);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(29, 134);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(106, 33);
            this.rdbTodos.TabIndex = 11;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.RdbTodos_CheckedChanged);
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.rdbID);
            this.gpbOrdenar.Controls.Add(this.rdbNome);
            this.gpbOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOrdenar.Location = new System.Drawing.Point(612, 19);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Size = new System.Drawing.Size(216, 140);
            this.gpbOrdenar.TabIndex = 9;
            this.gpbOrdenar.TabStop = false;
            this.gpbOrdenar.Text = "Ordenar  ";
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Checked = true;
            this.rdbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbID.Location = new System.Drawing.Point(22, 51);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(56, 33);
            this.rdbID.TabIndex = 6;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "ID";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNome.Location = new System.Drawing.Point(22, 90);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(101, 33);
            this.rdbNome.TabIndex = 8;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::Sistema.Properties.Resources.generatetables_ok_home_out_edit_generar_1491;
            this.btnFiltrar.Location = new System.Drawing.Point(695, 180);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(134, 129);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // txtRel
            // 
            this.txtRel.Enabled = false;
            this.txtRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRel.Location = new System.Drawing.Point(29, 192);
            this.txtRel.Name = "txtRel";
            this.txtRel.Size = new System.Drawing.Size(420, 26);
            this.txtRel.TabIndex = 4;
            // 
            // frmRelProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 463);
            this.ControlBox = false;
            this.Controls.Add(this.gpbFiltro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbOrdenar.ResumeLayout(false);
            this.gpbOrdenar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbValor;
        private System.Windows.Forms.RadioButton rdbQtde;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.TextBox txtRel;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button button1;
    }
}