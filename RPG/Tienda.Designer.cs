namespace RPG
{
    partial class Tienda
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
            this.lbldinero = new System.Windows.Forms.Label();
            this.lblpreciopv = new System.Windows.Forms.Label();
            this.lblpreciope = new System.Windows.Forms.Label();
            this.lblpreciopr = new System.Windows.Forms.Label();
            this.btncomprarpv = new System.Windows.Forms.Button();
            this.btncomprarpe = new System.Windows.Forms.Button();
            this.lblcomprarpr = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldinero
            // 
            this.lbldinero.AutoSize = true;
            this.lbldinero.Location = new System.Drawing.Point(27, 31);
            this.lbldinero.Name = "lbldinero";
            this.lbldinero.Size = new System.Drawing.Size(46, 17);
            this.lbldinero.TabIndex = 0;
            this.lbldinero.Text = "label1";
            // 
            // lblpreciopv
            // 
            this.lblpreciopv.AutoSize = true;
            this.lblpreciopv.Location = new System.Drawing.Point(26, 169);
            this.lblpreciopv.Name = "lblpreciopv";
            this.lblpreciopv.Size = new System.Drawing.Size(46, 17);
            this.lblpreciopv.TabIndex = 1;
            this.lblpreciopv.Text = "label2";
            // 
            // lblpreciope
            // 
            this.lblpreciope.AutoSize = true;
            this.lblpreciope.Location = new System.Drawing.Point(29, 226);
            this.lblpreciope.Name = "lblpreciope";
            this.lblpreciope.Size = new System.Drawing.Size(46, 17);
            this.lblpreciope.TabIndex = 2;
            this.lblpreciope.Text = "label3";
            // 
            // lblpreciopr
            // 
            this.lblpreciopr.AutoSize = true;
            this.lblpreciopr.Location = new System.Drawing.Point(29, 288);
            this.lblpreciopr.Name = "lblpreciopr";
            this.lblpreciopr.Size = new System.Drawing.Size(46, 17);
            this.lblpreciopr.TabIndex = 3;
            this.lblpreciopr.Text = "label4";
            // 
            // btncomprarpv
            // 
            this.btncomprarpv.Location = new System.Drawing.Point(141, 150);
            this.btncomprarpv.Name = "btncomprarpv";
            this.btncomprarpv.Size = new System.Drawing.Size(116, 56);
            this.btncomprarpv.TabIndex = 4;
            this.btncomprarpv.Text = "Pocion de Vida";
            this.btncomprarpv.UseVisualStyleBackColor = true;
            // 
            // btncomprarpe
            // 
            this.btncomprarpe.Location = new System.Drawing.Point(141, 212);
            this.btncomprarpe.Name = "btncomprarpe";
            this.btncomprarpe.Size = new System.Drawing.Size(116, 56);
            this.btncomprarpe.TabIndex = 5;
            this.btncomprarpe.Text = "Pocion de Energia";
            this.btncomprarpe.UseVisualStyleBackColor = true;
            // 
            // lblcomprarpr
            // 
            this.lblcomprarpr.Location = new System.Drawing.Point(141, 274);
            this.lblcomprarpr.Name = "lblcomprarpr";
            this.lblcomprarpr.Size = new System.Drawing.Size(116, 55);
            this.lblcomprarpr.TabIndex = 6;
            this.lblcomprarpr.Text = "Pocion Revivir";
            this.lblcomprarpr.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(247, 358);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 401);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblcomprarpr);
            this.Controls.Add(this.btncomprarpe);
            this.Controls.Add(this.btncomprarpv);
            this.Controls.Add(this.lblpreciopr);
            this.Controls.Add(this.lblpreciope);
            this.Controls.Add(this.lblpreciopv);
            this.Controls.Add(this.lbldinero);
            this.Name = "Tienda";
            this.Text = "Tienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldinero;
        private System.Windows.Forms.Label lblpreciopv;
        private System.Windows.Forms.Label lblpreciope;
        private System.Windows.Forms.Label lblpreciopr;
        private System.Windows.Forms.Button btncomprarpv;
        private System.Windows.Forms.Button btncomprarpe;
        private System.Windows.Forms.Button lblcomprarpr;
        private System.Windows.Forms.Button btnsalir;
    }
}