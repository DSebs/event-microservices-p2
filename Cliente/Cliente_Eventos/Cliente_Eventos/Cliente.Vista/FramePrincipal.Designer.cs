namespace Cliente_Eventos
{
    partial class FramePrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FramePrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conciertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarConciertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarConciertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarConciertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarConciertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorIDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.conciertoToolStripMenuItem,
            this.cancionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(26, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuOpcion";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.AutoToolTip = true;
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // conciertoToolStripMenuItem
            // 
            this.conciertoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarConciertoToolStripMenuItem,
            this.buscaToolStripMenuItem,
            this.eliminarConciertoToolStripMenuItem,
            this.actualizarConciertoToolStripMenuItem,
            this.listarConciertosToolStripMenuItem});
            this.conciertoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conciertoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.conciertoToolStripMenuItem.Name = "conciertoToolStripMenuItem";
            this.conciertoToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.conciertoToolStripMenuItem.Text = "Concierto";
            // 
            // agregarConciertoToolStripMenuItem
            // 
            this.agregarConciertoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.agregarConciertoToolStripMenuItem.Name = "agregarConciertoToolStripMenuItem";
            this.agregarConciertoToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.agregarConciertoToolStripMenuItem.Text = "Agregar Concierto";
            this.agregarConciertoToolStripMenuItem.Click += new System.EventHandler(this.agregarConciertoToolStripMenuItem_Click);
            // 
            // buscaToolStripMenuItem
            // 
            this.buscaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorIDToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem});
            this.buscaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            this.buscaToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.buscaToolStripMenuItem.Text = "Buscar Concierto";
            this.buscaToolStripMenuItem.Click += new System.EventHandler(this.buscaToolStripMenuItem_Click);
            // 
            // buscarPorIDToolStripMenuItem
            // 
            this.buscarPorIDToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.buscarPorIDToolStripMenuItem.Name = "buscarPorIDToolStripMenuItem";
            this.buscarPorIDToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
            this.buscarPorIDToolStripMenuItem.Text = "Buscar por ID";
            this.buscarPorIDToolStripMenuItem.Click += new System.EventHandler(this.buscarPorIDToolStripMenuItem_Click);
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            this.buscarPorNombreToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            this.buscarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(281, 30);
            this.buscarPorNombreToolStripMenuItem.Text = "Buscar por Nombre";
            this.buscarPorNombreToolStripMenuItem.Click += new System.EventHandler(this.buscarPorNombreToolStripMenuItem_Click);
            // 
            // eliminarConciertoToolStripMenuItem
            // 
            this.eliminarConciertoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.eliminarConciertoToolStripMenuItem.Name = "eliminarConciertoToolStripMenuItem";
            this.eliminarConciertoToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.eliminarConciertoToolStripMenuItem.Text = "Eliminar Concierto";
            this.eliminarConciertoToolStripMenuItem.Click += new System.EventHandler(this.eliminarConciertoToolStripMenuItem_Click);
            // 
            // actualizarConciertoToolStripMenuItem
            // 
            this.actualizarConciertoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.actualizarConciertoToolStripMenuItem.Name = "actualizarConciertoToolStripMenuItem";
            this.actualizarConciertoToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.actualizarConciertoToolStripMenuItem.Text = "Actualizar Concierto";
            this.actualizarConciertoToolStripMenuItem.Click += new System.EventHandler(this.actualizarConciertoToolStripMenuItem_Click);
            // 
            // listarConciertosToolStripMenuItem
            // 
            this.listarConciertosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.listarConciertosToolStripMenuItem.Name = "listarConciertosToolStripMenuItem";
            this.listarConciertosToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.listarConciertosToolStripMenuItem.Text = "Listar Conciertos";
            this.listarConciertosToolStripMenuItem.Click += new System.EventHandler(this.listarConciertosToolStripMenuItem_Click);
            // 
            // cancionToolStripMenuItem
            // 
            this.cancionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCancionToolStripMenuItem,
            this.buscarCancionToolStripMenuItem,
            this.eliminarCancionToolStripMenuItem,
            this.actualizarCancionToolStripMenuItem,
            this.listarCancionesToolStripMenuItem});
            this.cancionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cancionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.cancionToolStripMenuItem.Name = "cancionToolStripMenuItem";
            this.cancionToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.cancionToolStripMenuItem.Text = "Cancion";
            // 
            // agregarCancionToolStripMenuItem
            // 
            this.agregarCancionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.agregarCancionToolStripMenuItem.Name = "agregarCancionToolStripMenuItem";
            this.agregarCancionToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.agregarCancionToolStripMenuItem.Text = "Agregar Cancion";
            this.agregarCancionToolStripMenuItem.Click += new System.EventHandler(this.agregarCancionToolStripMenuItem_Click);
            // 
            // buscarCancionToolStripMenuItem
            // 
            this.buscarCancionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorIDToolStripMenuItem1,
            this.buscarPorNombreToolStripMenuItem1});
            this.buscarCancionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.buscarCancionToolStripMenuItem.Name = "buscarCancionToolStripMenuItem";
            this.buscarCancionToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.buscarCancionToolStripMenuItem.Text = "Buscar Cancion";
            // 
            // buscarPorIDToolStripMenuItem1
            // 
            this.buscarPorIDToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.buscarPorIDToolStripMenuItem1.Name = "buscarPorIDToolStripMenuItem1";
            this.buscarPorIDToolStripMenuItem1.Size = new System.Drawing.Size(281, 30);
            this.buscarPorIDToolStripMenuItem1.Text = "Buscar por ID";
            this.buscarPorIDToolStripMenuItem1.Click += new System.EventHandler(this.buscarPorIDToolStripMenuItem1_Click);
            // 
            // buscarPorNombreToolStripMenuItem1
            // 
            this.buscarPorNombreToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.buscarPorNombreToolStripMenuItem1.Name = "buscarPorNombreToolStripMenuItem1";
            this.buscarPorNombreToolStripMenuItem1.Size = new System.Drawing.Size(281, 30);
            this.buscarPorNombreToolStripMenuItem1.Text = "Buscar por Nombre";
            this.buscarPorNombreToolStripMenuItem1.Click += new System.EventHandler(this.buscarPorNombreToolStripMenuItem1_Click);
            // 
            // eliminarCancionToolStripMenuItem
            // 
            this.eliminarCancionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.eliminarCancionToolStripMenuItem.Name = "eliminarCancionToolStripMenuItem";
            this.eliminarCancionToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.eliminarCancionToolStripMenuItem.Text = "Eliminar Cancion";
            this.eliminarCancionToolStripMenuItem.Click += new System.EventHandler(this.eliminarCancionToolStripMenuItem_Click);
            // 
            // actualizarCancionToolStripMenuItem
            // 
            this.actualizarCancionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.actualizarCancionToolStripMenuItem.Name = "actualizarCancionToolStripMenuItem";
            this.actualizarCancionToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.actualizarCancionToolStripMenuItem.Text = "Actualizar Cancion";
            this.actualizarCancionToolStripMenuItem.Click += new System.EventHandler(this.actualizarCancionToolStripMenuItem_Click);
            // 
            // listarCancionesToolStripMenuItem
            // 
            this.listarCancionesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.listarCancionesToolStripMenuItem.Name = "listarCancionesToolStripMenuItem";
            this.listarCancionesToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.listarCancionesToolStripMenuItem.Text = "Listar Canciones";
            this.listarCancionesToolStripMenuItem.Click += new System.EventHandler(this.listarCancionesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(107)))), ((int)(((byte)(32)))));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(102)))));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(89)))), ((int)(((byte)(165)))));
            this.lblPrincipal.Location = new System.Drawing.Point(70, 274);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(359, 44);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Text = "EventManagement";
            this.lblPrincipal.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgIcon.Image")));
            this.imgIcon.Location = new System.Drawing.Point(145, 70);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(204, 201);
            this.imgIcon.TabIndex = 2;
            this.imgIcon.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(496, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // FramePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 338);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.imgIcon);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FramePrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.FramePrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conciertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarConciertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarConciertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarConciertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarConciertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.ToolStripMenuItem buscarPorIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem cancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorIDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCancionesToolStripMenuItem;
    }
}

