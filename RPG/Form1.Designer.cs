namespace RPG
{
    partial class FrmMenuPrin
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevaPar = new System.Windows.Forms.Button();
            this.btnCargarPar = new System.Windows.Forms.Button();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(171, 95);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(869, 135);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Aqui va el titulo";
            // 
            // btnNuevaPar
            // 
            this.btnNuevaPar.Location = new System.Drawing.Point(389, 330);
            this.btnNuevaPar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaPar.Name = "btnNuevaPar";
            this.btnNuevaPar.Size = new System.Drawing.Size(148, 42);
            this.btnNuevaPar.TabIndex = 1;
            this.btnNuevaPar.Text = "Nueva Partida";
            this.btnNuevaPar.UseVisualStyleBackColor = true;
            this.btnNuevaPar.Click += new System.EventHandler(this.btnNuevaPar_Click);
            // 
            // btnCargarPar
            // 
            this.btnCargarPar.Location = new System.Drawing.Point(587, 330);
            this.btnCargarPar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarPar.Name = "btnCargarPar";
            this.btnCargarPar.Size = new System.Drawing.Size(156, 42);
            this.btnCargarPar.TabIndex = 2;
            this.btnCargarPar.Text = "Cargar Partida";
            this.btnCargarPar.UseVisualStyleBackColor = true;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Location = new System.Drawing.Point(492, 399);
            this.btnOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(152, 41);
            this.btnOpciones.TabIndex = 3;
            this.btnOpciones.Text = "Opciones";
            this.btnOpciones.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(492, 473);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 38);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenuPrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 562);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOpciones);
            this.Controls.Add(this.btnCargarPar);
            this.Controls.Add(this.btnNuevaPar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrin";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNuevaPar;
        private System.Windows.Forms.Button btnCargarPar;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Button btnSalir;
    }
}

