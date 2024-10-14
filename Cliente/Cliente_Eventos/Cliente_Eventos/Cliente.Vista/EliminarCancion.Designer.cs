namespace Cliente_Eventos.Cliente.Vista
{
    partial class EliminarCancion
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
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCompositor = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCompositor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBuscarID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.panelAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panelAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAgregar.Controls.Add(this.txtFecha);
            this.panelAgregar.Controls.Add(this.txtCompositor);
            this.panelAgregar.Controls.Add(this.txtDuracion);
            this.panelAgregar.Controls.Add(this.txtNombre);
            this.panelAgregar.Controls.Add(this.txtID);
            this.panelAgregar.Controls.Add(this.btnEliminar);
            this.panelAgregar.Controls.Add(this.lblCompositor);
            this.panelAgregar.Controls.Add(this.lblFecha);
            this.panelAgregar.Controls.Add(this.lblDuracion);
            this.panelAgregar.Controls.Add(this.lblNombre);
            this.panelAgregar.Controls.Add(this.lblID);
            this.panelAgregar.Location = new System.Drawing.Point(61, 126);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(378, 364);
            this.panelAgregar.TabIndex = 6;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(181, 199);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(145, 20);
            this.txtFecha.TabIndex = 12;
            // 
            // txtCompositor
            // 
            this.txtCompositor.Enabled = false;
            this.txtCompositor.Location = new System.Drawing.Point(181, 246);
            this.txtCompositor.Name = "txtCompositor";
            this.txtCompositor.Size = new System.Drawing.Size(145, 20);
            this.txtCompositor.TabIndex = 10;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Location = new System.Drawing.Point(181, 154);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(145, 20);
            this.txtDuracion.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(181, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(181, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 20);
            this.txtID.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(139, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCompositor
            // 
            this.lblCompositor.AutoSize = true;
            this.lblCompositor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompositor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.lblCompositor.Location = new System.Drawing.Point(20, 240);
            this.lblCompositor.Name = "lblCompositor";
            this.lblCompositor.Size = new System.Drawing.Size(117, 23);
            this.lblCompositor.TabIndex = 4;
            this.lblCompositor.Text = "Compositor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.lblFecha.Location = new System.Drawing.Point(20, 194);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(128, 23);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Lanzamiento";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.lblDuracion.Location = new System.Drawing.Point(20, 148);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(93, 23);
            this.lblDuracion.TabIndex = 2;
            this.lblDuracion.Text = "Duracion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.lblNombre.Location = new System.Drawing.Point(20, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.lblID.Location = new System.Drawing.Point(20, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarID.Location = new System.Drawing.Point(226, 94);
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(163, 20);
            this.txtBuscarID.TabIndex = 18;
            this.txtBuscarID.Text = "Digite el ID";
            this.txtBuscarID.Enter += new System.EventHandler(this.txtBuscarID_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(119, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 34);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.lblPrincipal.Location = new System.Drawing.Point(78, 24);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(332, 44);
            this.lblPrincipal.TabIndex = 16;
            this.lblPrincipal.Text = " Eliminar Cancion";
            // 
            // EliminarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 525);
            this.Controls.Add(this.txtBuscarID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.panelAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EliminarCancion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCancion";
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.TextBox txtCompositor;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCompositor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBuscarID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtFecha;
    }
}