namespace Turnero
{
    partial class Turnero
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tramite = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.lblcontar = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMODIFICACION = new System.Windows.Forms.Button();
            this.lblBaja = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtId.Location = new System.Drawing.Point(159, 6);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(204, 26);
            this.txtId.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Id";
            // 
            // Tramite
            // 
            this.Tramite.AutoSize = true;
            this.Tramite.Location = new System.Drawing.Point(25, 323);
            this.Tramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tramite.Name = "Tramite";
            this.Tramite.Size = new System.Drawing.Size(69, 18);
            this.Tramite.TabIndex = 69;
            this.Tramite.Text = "Tramite";
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(159, 260);
            this.txthora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(204, 26);
            this.txthora.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Hora";
            // 
            // dtpDia
            // 
            this.dtpDia.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDia.Location = new System.Drawing.Point(159, 199);
            this.dtpDia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(204, 26);
            this.dtpDia.TabIndex = 66;
            // 
            // lblcontar
            // 
            this.lblcontar.AutoSize = true;
            this.lblcontar.Location = new System.Drawing.Point(973, 213);
            this.lblcontar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontar.Name = "lblcontar";
            this.lblcontar.Size = new System.Drawing.Size(0, 18);
            this.lblcontar.TabIndex = 65;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(396, 245);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 40);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(649, 200);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblMODIFICACION
            // 
            this.lblMODIFICACION.Location = new System.Drawing.Point(396, 300);
            this.lblMODIFICACION.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblMODIFICACION.Name = "lblMODIFICACION";
            this.lblMODIFICACION.Size = new System.Drawing.Size(190, 41);
            this.lblMODIFICACION.TabIndex = 61;
            this.lblMODIFICACION.Text = "MODIFICACION";
            this.lblMODIFICACION.UseVisualStyleBackColor = true;
            this.lblMODIFICACION.Click += new System.EventHandler(this.lblMODIFICACION_Click);
            // 
            // lblBaja
            // 
            this.lblBaja.Location = new System.Drawing.Point(385, 352);
            this.lblBaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(190, 41);
            this.lblBaja.TabIndex = 60;
            this.lblBaja.Text = "BAJA";
            this.lblBaja.UseVisualStyleBackColor = true;
            this.lblBaja.Click += new System.EventHandler(this.lblBaja_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(159, 143);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(204, 26);
            this.txtEdad.TabIndex = 59;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(159, 83);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(204, 26);
            this.txtApellido.TabIndex = 58;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 26);
            this.txtNombre.TabIndex = 57;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 207);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 18);
            this.lblEmail.TabIndex = 56;
            this.lblEmail.Text = "Dia";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(25, 150);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(49, 18);
            this.lblEdad.TabIndex = 55;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(25, 91);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 54;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 18);
            this.lblNombre.TabIndex = 53;
            this.lblNombre.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 323);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 26);
            this.comboBox1.TabIndex = 73;
            // 
            // Turnero
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Turnero.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(1047, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tramite);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.lblcontar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMODIFICACION);
            this.Controls.Add(this.lblBaja);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Turnero";
            this.Text = "Turnero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tramite;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label lblcontar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lblMODIFICACION;
        private System.Windows.Forms.Button lblBaja;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

