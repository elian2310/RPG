namespace RPG
{
    partial class Habilidad
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
            this.lblHFis = new System.Windows.Forms.Label();
            this.lblHMag = new System.Windows.Forms.Label();
            this.lblHabCur = new System.Windows.Forms.Label();
            this.btnHFDebil = new System.Windows.Forms.Button();
            this.btnHFMedia = new System.Windows.Forms.Button();
            this.btnHFFuerte = new System.Windows.Forms.Button();
            this.btnHMDebil = new System.Windows.Forms.Button();
            this.btnHMMedia = new System.Windows.Forms.Button();
            this.btnHMFuerte = new System.Windows.Forms.Button();
            this.btnHCDebil = new System.Windows.Forms.Button();
            this.btnHCMedia = new System.Windows.Forms.Button();
            this.btnHCCompleta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHFis
            // 
            this.lblHFis.AutoSize = true;
            this.lblHFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHFis.Location = new System.Drawing.Point(191, 49);
            this.lblHFis.Name = "lblHFis";
            this.lblHFis.Size = new System.Drawing.Size(73, 25);
            this.lblHFis.TabIndex = 0;
            this.lblHFis.Text = "Físicas";
            // 
            // lblHMag
            // 
            this.lblHMag.AutoSize = true;
            this.lblHMag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMag.Location = new System.Drawing.Point(577, 49);
            this.lblHMag.Name = "lblHMag";
            this.lblHMag.Size = new System.Drawing.Size(86, 25);
            this.lblHMag.TabIndex = 1;
            this.lblHMag.Text = "Mágicas";
            // 
            // lblHabCur
            // 
            this.lblHabCur.AutoSize = true;
            this.lblHabCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabCur.Location = new System.Drawing.Point(316, 266);
            this.lblHabCur.Name = "lblHabCur";
            this.lblHabCur.Size = new System.Drawing.Size(91, 25);
            this.lblHabCur.TabIndex = 2;
            this.lblHabCur.Text = "Curación";
            // 
            // btnHFDebil
            // 
            this.btnHFDebil.Location = new System.Drawing.Point(56, 98);
            this.btnHFDebil.Name = "btnHFDebil";
            this.btnHFDebil.Size = new System.Drawing.Size(108, 64);
            this.btnHFDebil.TabIndex = 3;
            this.btnHFDebil.Text = "Débil - 5% Salud";
            this.btnHFDebil.UseVisualStyleBackColor = true;
            this.btnHFDebil.Click += new System.EventHandler(this.btnHFDebil_Click);
            // 
            // btnHFMedia
            // 
            this.btnHFMedia.Location = new System.Drawing.Point(170, 97);
            this.btnHFMedia.Name = "btnHFMedia";
            this.btnHFMedia.Size = new System.Drawing.Size(108, 65);
            this.btnHFMedia.TabIndex = 4;
            this.btnHFMedia.Text = "Media - 13% Salud";
            this.btnHFMedia.UseVisualStyleBackColor = true;
            this.btnHFMedia.Click += new System.EventHandler(this.btnHFMedia_Click);
            // 
            // btnHFFuerte
            // 
            this.btnHFFuerte.Location = new System.Drawing.Point(284, 97);
            this.btnHFFuerte.Name = "btnHFFuerte";
            this.btnHFFuerte.Size = new System.Drawing.Size(112, 65);
            this.btnHFFuerte.TabIndex = 5;
            this.btnHFFuerte.Text = "Fuerte - 21% Salud";
            this.btnHFFuerte.UseVisualStyleBackColor = true;
            this.btnHFFuerte.Click += new System.EventHandler(this.btnHFFuerte_Click);
            // 
            // btnHMDebil
            // 
            this.btnHMDebil.Location = new System.Drawing.Point(453, 97);
            this.btnHMDebil.Name = "btnHMDebil";
            this.btnHMDebil.Size = new System.Drawing.Size(106, 65);
            this.btnHMDebil.TabIndex = 6;
            this.btnHMDebil.Text = "Débil - 4 Energía";
            this.btnHMDebil.UseVisualStyleBackColor = true;
            this.btnHMDebil.Click += new System.EventHandler(this.btnHMDebil_Click);
            // 
            // btnHMMedia
            // 
            this.btnHMMedia.Location = new System.Drawing.Point(565, 97);
            this.btnHMMedia.Name = "btnHMMedia";
            this.btnHMMedia.Size = new System.Drawing.Size(108, 65);
            this.btnHMMedia.TabIndex = 7;
            this.btnHMMedia.Text = "Media - 8 Energía ";
            this.btnHMMedia.UseVisualStyleBackColor = true;
            this.btnHMMedia.Click += new System.EventHandler(this.btnHMMedia_Click);
            // 
            // btnHMFuerte
            // 
            this.btnHMFuerte.Location = new System.Drawing.Point(679, 97);
            this.btnHMFuerte.Name = "btnHMFuerte";
            this.btnHMFuerte.Size = new System.Drawing.Size(109, 65);
            this.btnHMFuerte.TabIndex = 8;
            this.btnHMFuerte.Text = "Fuerte - 12 Energía";
            this.btnHMFuerte.UseVisualStyleBackColor = true;
            this.btnHMFuerte.Click += new System.EventHandler(this.btnHMFuerte_Click);
            // 
            // btnHCDebil
            // 
            this.btnHCDebil.Location = new System.Drawing.Point(183, 315);
            this.btnHCDebil.Name = "btnHCDebil";
            this.btnHCDebil.Size = new System.Drawing.Size(111, 65);
            this.btnHCDebil.TabIndex = 9;
            this.btnHCDebil.Text = "Débil - 3 Energía";
            this.btnHCDebil.UseVisualStyleBackColor = true;
            this.btnHCDebil.Click += new System.EventHandler(this.btnHCDebil_Click);
            // 
            // btnHCMedia
            // 
            this.btnHCMedia.Location = new System.Drawing.Point(300, 315);
            this.btnHCMedia.Name = "btnHCMedia";
            this.btnHCMedia.Size = new System.Drawing.Size(107, 65);
            this.btnHCMedia.TabIndex = 10;
            this.btnHCMedia.Text = "Media - 6 Energía";
            this.btnHCMedia.UseVisualStyleBackColor = true;
            this.btnHCMedia.Click += new System.EventHandler(this.btnHCMedia_Click);
            // 
            // btnHCCompleta
            // 
            this.btnHCCompleta.Location = new System.Drawing.Point(413, 315);
            this.btnHCCompleta.Name = "btnHCCompleta";
            this.btnHCCompleta.Size = new System.Drawing.Size(110, 65);
            this.btnHCCompleta.TabIndex = 11;
            this.btnHCCompleta.Text = "Completa - 18 Energía";
            this.btnHCCompleta.UseVisualStyleBackColor = true;
            this.btnHCCompleta.Click += new System.EventHandler(this.btnHCCompleta_Click);
            // 
            // Habilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHCCompleta);
            this.Controls.Add(this.btnHCMedia);
            this.Controls.Add(this.btnHCDebil);
            this.Controls.Add(this.btnHMFuerte);
            this.Controls.Add(this.btnHMMedia);
            this.Controls.Add(this.btnHMDebil);
            this.Controls.Add(this.btnHFFuerte);
            this.Controls.Add(this.btnHFMedia);
            this.Controls.Add(this.btnHFDebil);
            this.Controls.Add(this.lblHabCur);
            this.Controls.Add(this.lblHMag);
            this.Controls.Add(this.lblHFis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Habilidad";
            this.Text = "Habilidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHFis;
        private System.Windows.Forms.Label lblHMag;
        private System.Windows.Forms.Label lblHabCur;
        private System.Windows.Forms.Button btnHFDebil;
        private System.Windows.Forms.Button btnHFMedia;
        private System.Windows.Forms.Button btnHFFuerte;
        private System.Windows.Forms.Button btnHMDebil;
        private System.Windows.Forms.Button btnHMMedia;
        private System.Windows.Forms.Button btnHMFuerte;
        private System.Windows.Forms.Button btnHCDebil;
        private System.Windows.Forms.Button btnHCMedia;
        private System.Windows.Forms.Button btnHCCompleta;
    }
}