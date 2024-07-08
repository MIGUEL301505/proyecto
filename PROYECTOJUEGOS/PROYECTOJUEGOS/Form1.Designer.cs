namespace PROYECTOJUEGOS
{
    partial class Form1
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
            this.lblpuntos = new System.Windows.Forms.Label();
            this.txbjuego = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.cbperdi = new System.Windows.Forms.CheckBox();
            this.cbgane = new System.Windows.Forms.CheckBox();
            this.lv1 = new System.Windows.Forms.ListView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpuntos
            // 
            this.lblpuntos.AutoSize = true;
            this.lblpuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntos.Location = new System.Drawing.Point(280, 554);
            this.lblpuntos.Name = "lblpuntos";
            this.lblpuntos.Size = new System.Drawing.Size(110, 29);
            this.lblpuntos.TabIndex = 0;
            this.lblpuntos.Text = "POINTS";
            // 
            // txbjuego
            // 
            this.txbjuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbjuego.Location = new System.Drawing.Point(28, 87);
            this.txbjuego.Name = "txbjuego";
            this.txbjuego.Size = new System.Drawing.Size(206, 32);
            this.txbjuego.TabIndex = 1;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(268, 87);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(180, 52);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // cbperdi
            // 
            this.cbperdi.AutoSize = true;
            this.cbperdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbperdi.Location = new System.Drawing.Point(48, 180);
            this.cbperdi.Name = "cbperdi";
            this.cbperdi.Size = new System.Drawing.Size(130, 36);
            this.cbperdi.TabIndex = 3;
            this.cbperdi.Text = "PERDI";
            this.cbperdi.UseVisualStyleBackColor = true;
            // 
            // cbgane
            // 
            this.cbgane.AutoSize = true;
            this.cbgane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgane.Location = new System.Drawing.Point(218, 180);
            this.cbgane.Name = "cbgane";
            this.cbgane.Size = new System.Drawing.Size(124, 36);
            this.cbgane.TabIndex = 4;
            this.cbgane.Text = "GANE";
            this.cbgane.UseVisualStyleBackColor = true;
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(28, 271);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(537, 259);
            this.lv1.TabIndex = 5;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(12, 563);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(196, 66);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(595, 707);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.cbgane);
            this.Controls.Add(this.cbperdi);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txbjuego);
            this.Controls.Add(this.lblpuntos);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpuntos;
        private System.Windows.Forms.TextBox txbjuego;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.CheckBox cbperdi;
        private System.Windows.Forms.CheckBox cbgane;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.Button btnguardar;
    }
}

