namespace presentacion
{
    partial class frmBusquedaAvanzada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaAvanzada));
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampoBA = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCriterioBA = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroBA = new System.Windows.Forms.TextBox();
            this.btnBuscarAvanzado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProviderCampoBA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCriterioBA = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCampoBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCriterioBA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(3, 85);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 20);
            this.lblCampo.TabIndex = 2;
            this.lblCampo.Text = "Campo:";
            // 
            // cbxCampoBA
            // 
            this.cbxCampoBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampoBA.FormattingEnabled = true;
            this.cbxCampoBA.Location = new System.Drawing.Point(59, 82);
            this.cbxCampoBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCampoBA.Name = "cbxCampoBA";
            this.cbxCampoBA.Size = new System.Drawing.Size(160, 28);
            this.cbxCampoBA.TabIndex = 3;
            this.cbxCampoBA.SelectedIndexChanged += new System.EventHandler(this.cbxCampoBA_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(250, 86);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(61, 20);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cbxCriterioBA
            // 
            this.cbxCriterioBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterioBA.FormattingEnabled = true;
            this.cbxCriterioBA.Location = new System.Drawing.Point(308, 82);
            this.cbxCriterioBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCriterioBA.Name = "cbxCriterioBA";
            this.cbxCriterioBA.Size = new System.Drawing.Size(160, 28);
            this.cbxCriterioBA.TabIndex = 5;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(502, 86);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(46, 20);
            this.lblFiltroAvanzado.TabIndex = 6;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // txtFiltroBA
            // 
            this.txtFiltroBA.Location = new System.Drawing.Point(550, 83);
            this.txtFiltroBA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltroBA.Name = "txtFiltroBA";
            this.txtFiltroBA.Size = new System.Drawing.Size(220, 27);
            this.txtFiltroBA.TabIndex = 7;
            // 
            // btnBuscarAvanzado
            // 
            this.btnBuscarAvanzado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscarAvanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAvanzado.Location = new System.Drawing.Point(448, 181);
            this.btnBuscarAvanzado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarAvanzado.Name = "btnBuscarAvanzado";
            this.btnBuscarAvanzado.Size = new System.Drawing.Size(100, 35);
            this.btnBuscarAvanzado.TabIndex = 8;
            this.btnBuscarAvanzado.Text = "Buscar";
            this.btnBuscarAvanzado.UseVisualStyleBackColor = false;
            this.btnBuscarAvanzado.Click += new System.EventHandler(this.btnBuscarAvanzado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(223, 181);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProviderCampoBA
            // 
            this.errorProviderCampoBA.ContainerControl = this;
            // 
            // errorProviderCriterioBA
            // 
            this.errorProviderCriterioBA.ContainerControl = this;
            // 
            // frmBusquedaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 235);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarAvanzado);
            this.Controls.Add(this.txtFiltroBA);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cbxCriterioBA);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxCampoBA);
            this.Controls.Add(this.lblCampo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBusquedaAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada";
            this.Load += new System.EventHandler(this.frmBusquedaAvanzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCampoBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCriterioBA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbxCampoBA;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCriterioBA;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroBA;
        private System.Windows.Forms.Button btnBuscarAvanzado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProviderCampoBA;
        private System.Windows.Forms.ErrorProvider errorProviderCriterioBA;
    }
}