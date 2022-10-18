namespace Turnero
{
    partial class Contador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXdia = new System.Windows.Forms.Button();
            this.lblporida = new System.Windows.Forms.Label();
            this.btnpormes = new System.Windows.Forms.Button();
            this.lblpormes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblxmes = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.lblContar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnXdia
            // 
            this.btnXdia.Location = new System.Drawing.Point(45, 388);
            this.btnXdia.Margin = new System.Windows.Forms.Padding(4);
            this.btnXdia.Name = "btnXdia";
            this.btnXdia.Size = new System.Drawing.Size(112, 28);
            this.btnXdia.TabIndex = 3;
            this.btnXdia.Text = "Por dia";
            this.btnXdia.UseVisualStyleBackColor = true;
            this.btnXdia.Click += new System.EventHandler(this.btnXdia_Click);
            // 
            // lblporida
            // 
            this.lblporida.AutoSize = true;
            this.lblporida.Location = new System.Drawing.Point(360, 315);
            this.lblporida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblporida.Name = "lblporida";
            this.lblporida.Size = new System.Drawing.Size(0, 16);
            this.lblporida.TabIndex = 4;
            // 
            // btnpormes
            // 
            this.btnpormes.Location = new System.Drawing.Point(45, 315);
            this.btnpormes.Margin = new System.Windows.Forms.Padding(4);
            this.btnpormes.Name = "btnpormes";
            this.btnpormes.Size = new System.Drawing.Size(112, 28);
            this.btnpormes.TabIndex = 5;
            this.btnpormes.Text = "Por semana";
            this.btnpormes.UseVisualStyleBackColor = true;
            this.btnpormes.Click += new System.EventHandler(this.btnpormes_Click);
            // 
            // lblpormes
            // 
            this.lblpormes.AutoSize = true;
            this.lblpormes.Location = new System.Drawing.Point(360, 388);
            this.lblpormes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpormes.Name = "lblpormes";
            this.lblpormes.Size = new System.Drawing.Size(0, 16);
            this.lblpormes.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Por mes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblxmes
            // 
            this.lblxmes.AutoSize = true;
            this.lblxmes.Location = new System.Drawing.Point(364, 460);
            this.lblxmes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblxmes.Name = "lblxmes";
            this.lblxmes.Size = new System.Drawing.Size(0, 16);
            this.lblxmes.TabIndex = 8;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(45, 252);
            this.btnContar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(112, 28);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lblContar
            // 
            this.lblContar.AutoSize = true;
            this.lblContar.Location = new System.Drawing.Point(360, 252);
            this.lblContar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContar.Name = "lblContar";
            this.lblContar.Size = new System.Drawing.Size(0, 16);
            this.lblContar.TabIndex = 2;
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Turnero.Properties.Resources.pexels_olya_kobruseva_5408818;
            this.ClientSize = new System.Drawing.Size(555, 492);
            this.Controls.Add(this.lblxmes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpormes);
            this.Controls.Add(this.btnpormes);
            this.Controls.Add(this.lblporida);
            this.Controls.Add(this.btnXdia);
            this.Controls.Add(this.lblContar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Contador";
            this.Text = "Contador";
            this.Load += new System.EventHandler(this.Contador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXdia;
        private System.Windows.Forms.Label lblporida;
        private System.Windows.Forms.Button btnpormes;
        private System.Windows.Forms.Label lblpormes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblxmes;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblContar;
    }
}