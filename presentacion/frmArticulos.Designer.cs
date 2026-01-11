namespace presentacion
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lblBusquedaRapida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(539, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Articulos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(52, 185);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(707, 207);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(765, 185);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(356, 207);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(203, 135);
            this.txbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(393, 27);
            this.txbBuscar.TabIndex = 3;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(765, 135);
            this.btnBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(176, 28);
            this.btnBusquedaAvanzada.TabIndex = 4;
            this.btnBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(52, 412);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(147, 412);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 31);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(765, 414);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(99, 30);
            this.btnDetalle.TabIndex = 7;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // lblBusquedaRapida
            // 
            this.lblBusquedaRapida.AutoSize = true;
            this.lblBusquedaRapida.Location = new System.Drawing.Point(57, 142);
            this.lblBusquedaRapida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusquedaRapida.Name = "lblBusquedaRapida";
            this.lblBusquedaRapida.Size = new System.Drawing.Size(120, 16);
            this.lblBusquedaRapida.TabIndex = 8;
            this.lblBusquedaRapida.Text = "Busqueda Rapida:";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 484);
            this.Controls.Add(this.lblBusquedaRapida);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lblBusquedaRapida;
    }
}

