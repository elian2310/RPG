namespace RPG
{
    partial class Aldea
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
            this.pbEscenarioA = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pbTorre1 = new System.Windows.Forms.PictureBox();
            this.pbTorre2 = new System.Windows.Forms.PictureBox();
            this.pbTorre3 = new System.Windows.Forms.PictureBox();
            this.pbCastillo = new System.Windows.Forms.PictureBox();
            this.pbTienda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscenarioA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCastillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEscenarioA
            // 
            this.pbEscenarioA.Location = new System.Drawing.Point(12, 12);
            this.pbEscenarioA.Name = "pbEscenarioA";
            this.pbEscenarioA.Size = new System.Drawing.Size(1149, 507);
            this.pbEscenarioA.TabIndex = 0;
            this.pbEscenarioA.TabStop = false;
            this.pbEscenarioA.Paint += new System.Windows.Forms.PaintEventHandler(this.pbEscenarioA_Paint);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1058, 527);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // pbTorre1
            // 
            this.pbTorre1.Location = new System.Drawing.Point(273, 12);
            this.pbTorre1.Name = "pbTorre1";
            this.pbTorre1.Size = new System.Drawing.Size(120, 101);
            this.pbTorre1.TabIndex = 2;
            this.pbTorre1.TabStop = false;
            // 
            // pbTorre2
            // 
            this.pbTorre2.Location = new System.Drawing.Point(522, 12);
            this.pbTorre2.Name = "pbTorre2";
            this.pbTorre2.Size = new System.Drawing.Size(120, 101);
            this.pbTorre2.TabIndex = 3;
            this.pbTorre2.TabStop = false;
            // 
            // pbTorre3
            // 
            this.pbTorre3.Location = new System.Drawing.Point(779, 12);
            this.pbTorre3.Name = "pbTorre3";
            this.pbTorre3.Size = new System.Drawing.Size(120, 101);
            this.pbTorre3.TabIndex = 4;
            this.pbTorre3.TabStop = false;
            // 
            // pbCastillo
            // 
            this.pbCastillo.Location = new System.Drawing.Point(977, 242);
            this.pbCastillo.Name = "pbCastillo";
            this.pbCastillo.Size = new System.Drawing.Size(184, 131);
            this.pbCastillo.TabIndex = 5;
            this.pbCastillo.TabStop = false;
            // 
            // pbTienda
            // 
            this.pbTienda.Location = new System.Drawing.Point(12, 242);
            this.pbTienda.Name = "pbTienda";
            this.pbTienda.Size = new System.Drawing.Size(184, 131);
            this.pbTienda.TabIndex = 6;
            this.pbTienda.TabStop = false;
            // 
            // Aldea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 562);
            this.Controls.Add(this.pbTienda);
            this.Controls.Add(this.pbCastillo);
            this.Controls.Add(this.pbTorre3);
            this.Controls.Add(this.pbTorre2);
            this.Controls.Add(this.pbTorre1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbEscenarioA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Aldea";
            this.Text = "Aldea";
            ((System.ComponentModel.ISupportInitialize)(this.pbEscenarioA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCastillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTienda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEscenarioA;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbTorre1;
        private System.Windows.Forms.PictureBox pbTorre2;
        private System.Windows.Forms.PictureBox pbTorre3;
        private System.Windows.Forms.PictureBox pbCastillo;
        private System.Windows.Forms.PictureBox pbTienda;
    }
}