namespace Ropa
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
            this.almacenM = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesM = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasM = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenM,
            this.clientesM,
            this.ventasM,
            this.vendedoresM,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // almacenM
            // 
            this.almacenM.Name = "almacenM";
            this.almacenM.Size = new System.Drawing.Size(79, 24);
            this.almacenM.Text = "Almacen";
            this.almacenM.Click += new System.EventHandler(this.almacenM_Click);
            // 
            // clientesM
            // 
            this.clientesM.Name = "clientesM";
            this.clientesM.Size = new System.Drawing.Size(73, 24);
            this.clientesM.Text = "Clientes";
            this.clientesM.Click += new System.EventHandler(this.clientesM_Click);
            // 
            // ventasM
            // 
            this.ventasM.Name = "ventasM";
            this.ventasM.Size = new System.Drawing.Size(64, 24);
            this.ventasM.Text = "Ventas";
            this.ventasM.Click += new System.EventHandler(this.ventasM_Click);
            // 
            // vendedoresM
            // 
            this.vendedoresM.Name = "vendedoresM";
            this.vendedoresM.Size = new System.Drawing.Size(99, 24);
            this.vendedoresM.Text = "Vendedores";
            this.vendedoresM.Click += new System.EventHandler(this.vendedoresM_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(50, 24);
            this.toolStripMenuItem3.Text = "Salir";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 644);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de Ropa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem almacenM;
        private System.Windows.Forms.ToolStripMenuItem clientesM;
        private System.Windows.Forms.ToolStripMenuItem ventasM;
        private System.Windows.Forms.ToolStripMenuItem vendedoresM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

