namespace RPG
{
    partial class FrmCrearPersonaje
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
            this.lblNombrePers = new System.Windows.Forms.Label();
            this.txtbNombrePers = new System.Windows.Forms.TextBox();
            this.gbGeneroPer = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblClaseFis = new System.Windows.Forms.Label();
            this.cboxClaseFis = new System.Windows.Forms.ComboBox();
            this.lblClaseMag = new System.Windows.Forms.Label();
            this.cboxClaseMag = new System.Windows.Forms.ComboBox();
            this.pboxMasculino = new System.Windows.Forms.PictureBox();
            this.pboxFemenino = new System.Windows.Forms.PictureBox();
            this.btnCrearPer = new System.Windows.Forms.Button();
            this.gbGeneroPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMasculino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFemenino)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePers
            // 
            this.lblNombrePers.AutoSize = true;
            this.lblNombrePers.Location = new System.Drawing.Point(361, 79);
            this.lblNombrePers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePers.Name = "lblNombrePers";
            this.lblNombrePers.Size = new System.Drawing.Size(58, 17);
            this.lblNombrePers.TabIndex = 0;
            this.lblNombrePers.Text = "Nombre";
            // 
            // txtbNombrePers
            // 
            this.txtbNombrePers.Location = new System.Drawing.Point(511, 79);
            this.txtbNombrePers.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNombrePers.Name = "txtbNombrePers";
            this.txtbNombrePers.Size = new System.Drawing.Size(168, 22);
            this.txtbNombrePers.TabIndex = 1;
            // 
            // gbGeneroPer
            // 
            this.gbGeneroPer.Controls.Add(this.rdbFemenino);
            this.gbGeneroPer.Controls.Add(this.rdbMasculino);
            this.gbGeneroPer.Location = new System.Drawing.Point(365, 303);
            this.gbGeneroPer.Margin = new System.Windows.Forms.Padding(4);
            this.gbGeneroPer.Name = "gbGeneroPer";
            this.gbGeneroPer.Padding = new System.Windows.Forms.Padding(4);
            this.gbGeneroPer.Size = new System.Drawing.Size(439, 101);
            this.gbGeneroPer.TabIndex = 2;
            this.gbGeneroPer.TabStop = false;
            this.gbGeneroPer.Text = "Genero";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(291, 58);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(35, 58);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblClaseFis
            // 
            this.lblClaseFis.AutoSize = true;
            this.lblClaseFis.Location = new System.Drawing.Point(365, 431);
            this.lblClaseFis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaseFis.Name = "lblClaseFis";
            this.lblClaseFis.Size = new System.Drawing.Size(83, 17);
            this.lblClaseFis.TabIndex = 3;
            this.lblClaseFis.Text = "Clase Física";
            // 
            // cboxClaseFis
            // 
            this.cboxClaseFis.FormattingEnabled = true;
            this.cboxClaseFis.Items.AddRange(new object[] {
            "Arco",
            "Espada",
            "Lanza"});
            this.cboxClaseFis.Location = new System.Drawing.Point(480, 431);
            this.cboxClaseFis.Margin = new System.Windows.Forms.Padding(4);
            this.cboxClaseFis.Name = "cboxClaseFis";
            this.cboxClaseFis.Size = new System.Drawing.Size(160, 24);
            this.cboxClaseFis.TabIndex = 4;
            // 
            // lblClaseMag
            // 
            this.lblClaseMag.AutoSize = true;
            this.lblClaseMag.Location = new System.Drawing.Point(365, 497);
            this.lblClaseMag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaseMag.Name = "lblClaseMag";
            this.lblClaseMag.Size = new System.Drawing.Size(92, 17);
            this.lblClaseMag.TabIndex = 5;
            this.lblClaseMag.Text = "Clase Mágica";
            // 
            // cboxClaseMag
            // 
            this.cboxClaseMag.FormattingEnabled = true;
            this.cboxClaseMag.Items.AddRange(new object[] {
            "Agua",
            "Fuego",
            "Planta"});
            this.cboxClaseMag.Location = new System.Drawing.Point(480, 497);
            this.cboxClaseMag.Margin = new System.Windows.Forms.Padding(4);
            this.cboxClaseMag.Name = "cboxClaseMag";
            this.cboxClaseMag.Size = new System.Drawing.Size(160, 24);
            this.cboxClaseMag.TabIndex = 6;
            // 
            // pboxMasculino
            // 
            this.pboxMasculino.Location = new System.Drawing.Point(369, 123);
            this.pboxMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.pboxMasculino.Name = "pboxMasculino";
            this.pboxMasculino.Size = new System.Drawing.Size(187, 159);
            this.pboxMasculino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMasculino.TabIndex = 7;
            this.pboxMasculino.TabStop = false;
            // 
            // pboxFemenino
            // 
            this.pboxFemenino.Location = new System.Drawing.Point(617, 123);
            this.pboxFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.pboxFemenino.Name = "pboxFemenino";
            this.pboxFemenino.Size = new System.Drawing.Size(187, 159);
            this.pboxFemenino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFemenino.TabIndex = 8;
            this.pboxFemenino.TabStop = false;
            // 
            // btnCrearPer
            // 
            this.btnCrearPer.Location = new System.Drawing.Point(656, 459);
            this.btnCrearPer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearPer.Name = "btnCrearPer";
            this.btnCrearPer.Size = new System.Drawing.Size(148, 34);
            this.btnCrearPer.TabIndex = 9;
            this.btnCrearPer.Text = "Crear Personaje";
            this.btnCrearPer.UseVisualStyleBackColor = true;
            this.btnCrearPer.Click += new System.EventHandler(this.btnCrearPer_Click);
            // 
            // FrmCrearPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 562);
            this.Controls.Add(this.btnCrearPer);
            this.Controls.Add(this.pboxFemenino);
            this.Controls.Add(this.pboxMasculino);
            this.Controls.Add(this.cboxClaseMag);
            this.Controls.Add(this.lblClaseMag);
            this.Controls.Add(this.cboxClaseFis);
            this.Controls.Add(this.lblClaseFis);
            this.Controls.Add(this.gbGeneroPer);
            this.Controls.Add(this.txtbNombrePers);
            this.Controls.Add(this.lblNombrePers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCrearPersonaje";
            this.Text = "Crear Personaje";
            this.gbGeneroPer.ResumeLayout(false);
            this.gbGeneroPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMasculino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFemenino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePers;
        private System.Windows.Forms.TextBox txtbNombrePers;
        private System.Windows.Forms.GroupBox gbGeneroPer;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblClaseFis;
        private System.Windows.Forms.ComboBox cboxClaseFis;
        private System.Windows.Forms.Label lblClaseMag;
        private System.Windows.Forms.ComboBox cboxClaseMag;
        private System.Windows.Forms.PictureBox pboxMasculino;
        private System.Windows.Forms.PictureBox pboxFemenino;
        private System.Windows.Forms.Button btnCrearPer;
    }
}