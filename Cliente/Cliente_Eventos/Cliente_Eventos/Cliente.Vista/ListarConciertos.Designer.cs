namespace Cliente_Eventos.Cliente.Vista
{
    partial class ListarConciertos
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tblConciertos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListarXPrecio = new System.Windows.Forms.Button();
            this.txtPrecioFiltro = new System.Windows.Forms.TextBox();
            this.lblSecundario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblConciertos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.lblPrincipal.Location = new System.Drawing.Point(123, 37);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(312, 44);
            this.lblPrincipal.TabIndex = 13;
            this.lblPrincipal.Text = "Listar Conciertos";
            this.lblPrincipal.Click += new System.EventHandler(this.lblPrincipal_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Location = new System.Drawing.Point(65, 358);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 34);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Listar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // tblConciertos
            // 
            this.tblConciertos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tblConciertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblConciertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Fecha,
            this.Artista});
            this.tblConciertos.Location = new System.Drawing.Point(23, 128);
            this.tblConciertos.Name = "tblConciertos";
            this.tblConciertos.Size = new System.Drawing.Size(538, 190);
            this.tblConciertos.TabIndex = 15;
            this.tblConciertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Artista
            // 
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnListarXPrecio);
            this.panel1.Controls.Add(this.txtPrecioFiltro);
            this.panel1.Controls.Add(this.lblSecundario);
            this.panel1.Location = new System.Drawing.Point(221, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 72);
            this.panel1.TabIndex = 16;
            // 
            // btnListarXPrecio
            // 
            this.btnListarXPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.btnListarXPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarXPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarXPrecio.Location = new System.Drawing.Point(45, 30);
            this.btnListarXPrecio.Name = "btnListarXPrecio";
            this.btnListarXPrecio.Size = new System.Drawing.Size(96, 34);
            this.btnListarXPrecio.TabIndex = 17;
            this.btnListarXPrecio.Text = "Filtrar";
            this.btnListarXPrecio.UseVisualStyleBackColor = false;
            // 
            // txtPrecioFiltro
            // 
            this.txtPrecioFiltro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrecioFiltro.Location = new System.Drawing.Point(160, 39);
            this.txtPrecioFiltro.Name = "txtPrecioFiltro";
            this.txtPrecioFiltro.Size = new System.Drawing.Size(138, 20);
            this.txtPrecioFiltro.TabIndex = 18;
            this.txtPrecioFiltro.Text = "Digite el precio minimo";
            this.txtPrecioFiltro.Enter += new System.EventHandler(this.txtPrecioFiltro_Enter);
            // 
            // lblSecundario
            // 
            this.lblSecundario.AutoSize = true;
            this.lblSecundario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecundario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.lblSecundario.Location = new System.Drawing.Point(75, 9);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSecundario.Size = new System.Drawing.Size(185, 18);
            this.lblSecundario.TabIndex = 17;
            this.lblSecundario.Text = "Listar por precio minimo";
            // 
            // ListarConciertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblConciertos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListarConciertos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarConciertos";
            ((System.ComponentModel.ISupportInitialize)(this.tblConciertos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView tblConciertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSecundario;
        private System.Windows.Forms.Button btnListarXPrecio;
        private System.Windows.Forms.TextBox txtPrecioFiltro;
    }
}