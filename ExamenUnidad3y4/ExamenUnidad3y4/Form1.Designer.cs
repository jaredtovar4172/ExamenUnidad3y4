namespace ExamenUnidad3y4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatoPorEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosSemestreParToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mostrarDatoPorEspecialidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.operacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDatosToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // agregarDatosToolStripMenuItem
            // 
            this.agregarDatosToolStripMenuItem.Name = "agregarDatosToolStripMenuItem";
            this.agregarDatosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarDatosToolStripMenuItem.Text = "Agregar datos";
            this.agregarDatosToolStripMenuItem.Click += new System.EventHandler(this.agregarDatosToolStripMenuItem_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDatoPorEspecialidadToolStripMenuItem,
            this.mostrarDatoPorEspecialidadToolStripMenuItem1});
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar datos";
            // 
            // mostrarDatoPorEspecialidadToolStripMenuItem
            // 
            this.mostrarDatoPorEspecialidadToolStripMenuItem.Name = "mostrarDatoPorEspecialidadToolStripMenuItem";
            this.mostrarDatoPorEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.mostrarDatoPorEspecialidadToolStripMenuItem.Text = "Mostrar todo";
            this.mostrarDatoPorEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatoPorEspecialidadToolStripMenuItem_Click);
            // 
            // operacionToolStripMenuItem
            // 
            this.operacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarDatosSemestreParToolStripMenuItem});
            this.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem";
            this.operacionToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.operacionToolStripMenuItem.Text = "Operacion";
            // 
            // mostrarDatosSemestreParToolStripMenuItem
            // 
            this.mostrarDatosSemestreParToolStripMenuItem.Name = "mostrarDatosSemestreParToolStripMenuItem";
            this.mostrarDatosSemestreParToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.mostrarDatosSemestreParToolStripMenuItem.Text = "Mostrar datos semestre par";
            this.mostrarDatosSemestreParToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatosSemestreParToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(814, 316);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matricula";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Especialidad";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Semestre";
            this.columnHeader4.Width = 151;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Promedio";
            this.columnHeader5.Width = 129;
            // 
            // mostrarDatoPorEspecialidadToolStripMenuItem1
            // 
            this.mostrarDatoPorEspecialidadToolStripMenuItem1.Name = "mostrarDatoPorEspecialidadToolStripMenuItem1";
            this.mostrarDatoPorEspecialidadToolStripMenuItem1.Size = new System.Drawing.Size(299, 26);
            this.mostrarDatoPorEspecialidadToolStripMenuItem1.Text = "Mostrar datos por especialidad";
            this.mostrarDatoPorEspecialidadToolStripMenuItem1.Click += new System.EventHandler(this.mostrarDatoPorEspecialidadToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 478);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatoPorEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosSemestreParToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatoPorEspecialidadToolStripMenuItem1;
    }
}

