namespace Turnero
{
    partial class AdminLogin
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
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.estadisticasToolStripMenuItem.Text = "Estadísticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(100, 21);
            this.salirToolStripMenuItem1.Text = "Cerrar sesion";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnoToolStripMenuItem,
            this.documentacionToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.registroUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.turnoToolStripMenuItem.Text = "Turnos";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // documentacionToolStripMenuItem
            // 
            this.documentacionToolStripMenuItem.Name = "documentacionToolStripMenuItem";
            this.documentacionToolStripMenuItem.Size = new System.Drawing.Size(117, 21);
            this.documentacionToolStripMenuItem.Text = "Documentación";
            this.documentacionToolStripMenuItem.Click += new System.EventHandler(this.documentacionToolStripMenuItem_Click);
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(122, 21);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroUsuarioToolStripMenuItem_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Turnero.Properties.Resources.X42DLV2M5VH27AZ4AXMIQEK3M4;
            this.ClientSize = new System.Drawing.Size(505, 283);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.Text = "REGISTRO CIVIL LA CALERA : ACCESO ADMIN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
    }
}