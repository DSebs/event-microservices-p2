namespace Cliente_Eventos.Cliente.Vista
{
    partial class ListarCanciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListarXDuracion = new System.Windows.Forms.Button();
            this.txtDuracionFiltro = new System.Windows.Forms.TextBox();
            this.lblSecundario = new System.Windows.Forms.Label();
            this.tblConciertos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblConciertos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnListarXDuracion);
            this.panel1.Controls.Add(this.txtDuracionFiltro);
            this.panel1.Controls.Add(this.lblSecundario);
            this.panel1.Location = new System.Drawing.Point(219, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 72);
            this.panel1.TabIndex = 20;
            // 
            // btnListarXDuracion
            // 
            this.btnListarXDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.btnListarXDuracion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarXDuracion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarXDuracion.Location = new System.Drawing.Point(45, 30);
            this.btnListarXDuracion.Name = "btnListarXDuracion";
            this.btnListarXDuracion.Size = new System.Drawing.Size(96, 34);
            this.btnListarXDuracion.TabIndex = 17;
            this.btnListarXDuracion.Text = "Filtrar";
            this.btnListarXDuracion.UseVisualStyleBackColor = false;
            this.btnListarXDuracion.Click += new System.EventHandler(this.btnListarXDuracion_Click);
            // 
            // txtDuracionFiltro
            // 
            this.txtDuracionFiltro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDuracionFiltro.Location = new System.Drawing.Point(160, 39);
            this.txtDuracionFiltro.Name = "txtDuracionFiltro";
            this.txtDuracionFiltro.Size = new System.Drawing.Size(138, 20);
            this.txtDuracionFiltro.TabIndex = 18;
            this.txtDuracionFiltro.Text = "Digite la duracion minima";
            this.txtDuracionFiltro.Enter += new System.EventHandler(this.txtDuracionFiltro_Enter);
            // 
            // lblSecundario
            // 
            this.lblSecundario.AutoSize = true;
            this.lblSecundario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecundario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.lblSecundario.Location = new System.Drawing.Point(75, 9);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSecundario.Size = new System.Drawing.Size(203, 18);
            this.lblSecundario.TabIndex = 17;
            this.lblSecundario.Text = "Listar por duracion minima";
            // 
            // tblConciertos
            // 
            this.tblConciertos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tblConciertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblConciertos.Location = new System.Drawing.Point(21, 120);
            this.tblConciertos.Name = "tblConciertos";
            this.tblConciertos.Size = new System.Drawing.Size(538, 190);
            this.tblConciertos.TabIndex = 19;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.btnListar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListar.Location = new System.Drawing.Point(63, 350);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 34);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.lblPrincipal.Location = new System.Drawing.Point(121, 29);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(311, 44);
            this.lblPrincipal.TabIndex = 17;
            this.lblPrincipal.Text = "Listar Canciones";
            // 
            // ListarCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblConciertos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListarCanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarCanciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblConciertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListarXDuracion;
        private System.Windows.Forms.TextBox txtDuracionFiltro;
        private System.Windows.Forms.Label lblSecundario;
        private System.Windows.Forms.DataGridView tblConciertos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblPrincipal;
    }
}