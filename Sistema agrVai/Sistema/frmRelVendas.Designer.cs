namespace Sistema
{
    partial class frmRelVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelVendas));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.rdbMaior = new System.Windows.Forms.RadioButton();
            this.rdbMenor = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtRel = new System.Windows.Forms.TextBox();
            this.rdbQtde = new System.Windows.Forms.RadioButton();
            this.gpbFiltro.SuspendLayout();
            this.gpbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.button1);
            this.gpbFiltro.Controls.Add(this.rdbTodos);
            this.gpbFiltro.Controls.Add(this.gpbOrdenar);
            this.gpbFiltro.Controls.Add(this.btnFiltrar);
            this.gpbFiltro.Controls.Add(this.txtRel);
            this.gpbFiltro.Controls.Add(this.rdbQtde);
            resources.ApplyResources(this.gpbFiltro, "gpbFiltro");
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Sistema.Properties.Resources.exit_closethesession_close_6317;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rdbTodos
            // 
            resources.ApplyResources(this.rdbTodos, "rdbTodos");
            this.rdbTodos.Checked = true;
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.TabStop = true;
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.RdbTodos_CheckedChanged);
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.rdbMaior);
            this.gpbOrdenar.Controls.Add(this.rdbMenor);
            resources.ApplyResources(this.gpbOrdenar, "gpbOrdenar");
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.TabStop = false;
            // 
            // rdbMaior
            // 
            resources.ApplyResources(this.rdbMaior, "rdbMaior");
            this.rdbMaior.Checked = true;
            this.rdbMaior.Name = "rdbMaior";
            this.rdbMaior.TabStop = true;
            this.rdbMaior.UseVisualStyleBackColor = true;
            // 
            // rdbMenor
            // 
            resources.ApplyResources(this.rdbMenor, "rdbMenor");
            this.rdbMenor.Name = "rdbMenor";
            this.rdbMenor.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImage = global::Sistema.Properties.Resources.generatetables_ok_home_out_edit_generar_1491;
            resources.ApplyResources(this.btnFiltrar, "btnFiltrar");
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // txtRel
            // 
            resources.ApplyResources(this.txtRel, "txtRel");
            this.txtRel.Name = "txtRel";
            // 
            // rdbQtde
            // 
            resources.ApplyResources(this.rdbQtde, "rdbQtde");
            this.rdbQtde.Name = "rdbQtde";
            this.rdbQtde.UseVisualStyleBackColor = true;
            this.rdbQtde.CheckedChanged += new System.EventHandler(this.RdbQtde_CheckedChanged);
            // 
            // frmRelVendas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.gpbFiltro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelVendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.gpbOrdenar.ResumeLayout(false);
            this.gpbOrdenar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton rdbMaior;
        private System.Windows.Forms.RadioButton rdbMenor;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtRel;
        private System.Windows.Forms.RadioButton rdbQtde;
    }
}