namespace RPG
{
    partial class Estadisticas
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblclasefis = new System.Windows.Forms.Label();
            this.lblclasemag = new System.Windows.Forms.Label();
            this.btnhecho = new System.Windows.Forms.Button();
            this.btncambiar = new System.Windows.Forms.Button();
            this.pbPersonaje = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(400, 52);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(152, 55);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "label1";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(400, 132);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(93, 32);
            this.lblgenero.TabIndex = 1;
            this.lblgenero.Text = "label2";
            // 
            // lblclasefis
            // 
            this.lblclasefis.AutoSize = true;
            this.lblclasefis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasefis.Location = new System.Drawing.Point(400, 192);
            this.lblclasefis.Name = "lblclasefis";
            this.lblclasefis.Size = new System.Drawing.Size(93, 32);
            this.lblclasefis.TabIndex = 2;
            this.lblclasefis.Text = "label3";
            // 
            // lblclasemag
            // 
            this.lblclasemag.AutoSize = true;
            this.lblclasemag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasemag.Location = new System.Drawing.Point(555, 192);
            this.lblclasemag.Name = "lblclasemag";
            this.lblclasemag.Size = new System.Drawing.Size(93, 32);
            this.lblclasemag.TabIndex = 3;
            this.lblclasemag.Text = "label4";
            // 
            // btnhecho
            // 
            this.btnhecho.Location = new System.Drawing.Point(561, 483);
            this.btnhecho.Name = "btnhecho";
            this.btnhecho.Size = new System.Drawing.Size(75, 23);
            this.btnhecho.TabIndex = 4;
            this.btnhecho.Text = "Hecho";
            this.btnhecho.UseVisualStyleBackColor = true;
            this.btnhecho.Click += new System.EventHandler(this.btnhecho_Click);
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(406, 483);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(75, 23);
            this.btncambiar.TabIndex = 5;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // pbPersonaje
            // 
            this.pbPersonaje.Location = new System.Drawing.Point(406, 261);
            this.pbPersonaje.Name = "pbPersonaje";
            this.pbPersonaje.Size = new System.Drawing.Size(230, 175);
            this.pbPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonaje.TabIndex = 6;
            this.pbPersonaje.TabStop = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 562);
            this.Controls.Add(this.pbPersonaje);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.btnhecho);
            this.Controls.Add(this.lblclasemag);
            this.Controls.Add(this.lblclasefis);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lblnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblclasefis;
        private System.Windows.Forms.Label lblclasemag;
        private System.Windows.Forms.Button btnhecho;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.PictureBox pbPersonaje;
    }
}