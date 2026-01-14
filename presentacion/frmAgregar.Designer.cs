namespace presentacion
{
    partial class frmAgregar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pbxAgregar = new System.Windows.Forms.PictureBox();
            this.btnAceptarAgregar = new System.Windows.Forms.Button();
            this.btnCancelarAgregar = new System.Windows.Forms.Button();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(36, 69);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 142);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(8, 216);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(42, 290);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(21, 365);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(35, 439);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(62, 20);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(41, 512);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 69);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 27);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 141);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(112, 214);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(160, 27);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(112, 359);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(160, 28);
            this.cbxCategoria.TabIndex = 4;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(112, 432);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(160, 27);
            this.txtImagen.TabIndex = 5;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(112, 505);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 27);
            this.txtPrecio.TabIndex = 6;
            // 
            // pbxAgregar
            // 
            this.pbxAgregar.Location = new System.Drawing.Point(315, 58);
            this.pbxAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxAgregar.Name = "pbxAgregar";
            this.pbxAgregar.Size = new System.Drawing.Size(396, 355);
            this.pbxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregar.TabIndex = 14;
            this.pbxAgregar.TabStop = false;
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAceptarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAgregar.Location = new System.Drawing.Point(547, 444);
            this.btnAceptarAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAceptarAgregar.TabIndex = 7;
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.UseVisualStyleBackColor = false;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click);
            // 
            // btnCancelarAgregar
            // 
            this.btnCancelarAgregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancelarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAgregar.Location = new System.Drawing.Point(353, 444);
            this.btnCancelarAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarAgregar.Name = "btnCancelarAgregar";
            this.btnCancelarAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelarAgregar.TabIndex = 8;
            this.btnCancelarAgregar.Text = "Cancelar";
            this.btnCancelarAgregar.UseVisualStyleBackColor = false;
            this.btnCancelarAgregar.Click += new System.EventHandler(this.btnCancelarAgregar_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(112, 290);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(160, 28);
            this.cbxMarca.TabIndex = 3;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Location = new System.Drawing.Point(279, 431);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(34, 28);
            this.btnAgregarImagen.TabIndex = 18;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            this.btnAgregarImagen.MouseEnter += new System.EventHandler(this.btnAgregarImagen_MouseEnter);
            this.btnAgregarImagen.MouseLeave += new System.EventHandler(this.btnAgregarImagen_MouseLeave);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 574);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.btnCancelarAgregar);
            this.Controls.Add(this.btnAceptarAgregar);
            this.Controls.Add(this.pbxAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pbxAgregar;
        private System.Windows.Forms.Button btnAceptarAgregar;
        private System.Windows.Forms.Button btnCancelarAgregar;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}