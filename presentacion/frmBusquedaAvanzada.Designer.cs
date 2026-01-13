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
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampoBA = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCriterioBA = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroBA = new System.Windows.Forms.TextBox();
            this.btnBuscarAvanzado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(16, 73);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 2;
            this.lblCampo.Text = "Campo:";
            // 
            // cbxCampoBA
            // 
            this.cbxCampoBA.FormattingEnabled = true;
            this.cbxCampoBA.Location = new System.Drawing.Point(81, 69);
            this.cbxCampoBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCampoBA.Name = "cbxCampoBA";
            this.cbxCampoBA.Size = new System.Drawing.Size(160, 24);
            this.cbxCampoBA.TabIndex = 3;
            this.cbxCampoBA.SelectedIndexChanged += new System.EventHandler(this.cbxCampoBA_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(251, 73);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cbxCriterioBA
            // 
            this.cbxCriterioBA.FormattingEnabled = true;
            this.cbxCriterioBA.Location = new System.Drawing.Point(315, 68);
            this.cbxCriterioBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCriterioBA.Name = "cbxCriterioBA";
            this.cbxCriterioBA.Size = new System.Drawing.Size(160, 24);
            this.cbxCriterioBA.TabIndex = 5;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(484, 73);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(39, 16);
            this.lblFiltroAvanzado.TabIndex = 6;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // txtFiltroBA
            // 
            this.txtFiltroBA.Location = new System.Drawing.Point(535, 68);
            this.txtFiltroBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroBA.Name = "txtFiltroBA";
            this.txtFiltroBA.Size = new System.Drawing.Size(220, 22);
            this.txtFiltroBA.TabIndex = 7;
            // 
            // btnBuscarAvanzado
            // 
            this.btnBuscarAvanzado.Location = new System.Drawing.Point(448, 145);
            this.btnBuscarAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarAvanzado.Name = "btnBuscarAvanzado";
            this.btnBuscarAvanzado.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarAvanzado.TabIndex = 8;
            this.btnBuscarAvanzado.Text = "Buscar";
            this.btnBuscarAvanzado.UseVisualStyleBackColor = true;
            this.btnBuscarAvanzado.Click += new System.EventHandler(this.btnBuscarAvanzado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 145);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBusquedaAvanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 188);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscarAvanzado);
            this.Controls.Add(this.txtFiltroBA);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cbxCriterioBA);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxCampoBA);
            this.Controls.Add(this.lblCampo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBusquedaAvanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada";
            this.Load += new System.EventHandler(this.frmBusquedaAvanzada_Load);
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
    }
}