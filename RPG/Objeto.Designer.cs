namespace RPG
{
    partial class Objeto
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
            this.btnPSalud = new System.Windows.Forms.Button();
            this.btnPEnergia = new System.Windows.Forms.Button();
            this.btnPRevivir = new System.Windows.Forms.Button();
            this.lblCantidadPS = new System.Windows.Forms.Label();
            this.lblCantidadPE = new System.Windows.Forms.Label();
            this.lblCantidadPR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPSalud
            // 
            this.btnPSalud.Location = new System.Drawing.Point(81, 104);
            this.btnPSalud.Name = "btnPSalud";
            this.btnPSalud.Size = new System.Drawing.Size(159, 63);
            this.btnPSalud.TabIndex = 0;
            this.btnPSalud.Text = "Poción de Salud - 300 $";
            this.btnPSalud.UseVisualStyleBackColor = true;
            this.btnPSalud.Click += new System.EventHandler(this.btnPSalud_Click);
            // 
            // btnPEnergia
            // 
            this.btnPEnergia.Location = new System.Drawing.Point(335, 104);
            this.btnPEnergia.Name = "btnPEnergia";
            this.btnPEnergia.Size = new System.Drawing.Size(159, 63);
            this.btnPEnergia.TabIndex = 1;
            this.btnPEnergia.Text = "Poción de Energía - 500$";
            this.btnPEnergia.UseVisualStyleBackColor = true;
            this.btnPEnergia.Click += new System.EventHandler(this.btnPEnergia_Click);
            // 
            // btnPRevivir
            // 
            this.btnPRevivir.Location = new System.Drawing.Point(581, 104);
            this.btnPRevivir.Name = "btnPRevivir";
            this.btnPRevivir.Size = new System.Drawing.Size(159, 63);
            this.btnPRevivir.TabIndex = 2;
            this.btnPRevivir.Text = "Poción Revivir - 700$";
            this.btnPRevivir.UseVisualStyleBackColor = true;
            this.btnPRevivir.Click += new System.EventHandler(this.btnPRevivir_Click);
            // 
            // lblCantidadPS
            // 
            this.lblCantidadPS.AutoSize = true;
            this.lblCantidadPS.Location = new System.Drawing.Point(136, 70);
            this.lblCantidadPS.Name = "lblCantidadPS";
            this.lblCantidadPS.Size = new System.Drawing.Size(46, 17);
            this.lblCantidadPS.TabIndex = 3;
            this.lblCantidadPS.Text = "label1";
            // 
            // lblCantidadPE
            // 
            this.lblCantidadPE.AutoSize = true;
            this.lblCantidadPE.Location = new System.Drawing.Point(389, 70);
            this.lblCantidadPE.Name = "lblCantidadPE";
            this.lblCantidadPE.Size = new System.Drawing.Size(46, 17);
            this.lblCantidadPE.TabIndex = 4;
            this.lblCantidadPE.Text = "label2";
            // 
            // lblCantidadPR
            // 
            this.lblCantidadPR.AutoSize = true;
            this.lblCantidadPR.Location = new System.Drawing.Point(638, 70);
            this.lblCantidadPR.Name = "lblCantidadPR";
            this.lblCantidadPR.Size = new System.Drawing.Size(46, 17);
            this.lblCantidadPR.TabIndex = 5;
            this.lblCantidadPR.Text = "label3";
            // 
            // Objeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.lblCantidadPR);
            this.Controls.Add(this.lblCantidadPE);
            this.Controls.Add(this.lblCantidadPS);
            this.Controls.Add(this.btnPRevivir);
            this.Controls.Add(this.btnPEnergia);
            this.Controls.Add(this.btnPSalud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Objeto";
            this.Text = "Objeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPSalud;
        private System.Windows.Forms.Button btnPEnergia;
        private System.Windows.Forms.Button btnPRevivir;
        private System.Windows.Forms.Label lblCantidadPS;
        private System.Windows.Forms.Label lblCantidadPE;
        private System.Windows.Forms.Label lblCantidadPR;
    }
}