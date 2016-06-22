namespace Vista
{
    partial class recetaViewer
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbReceta = new System.Windows.Forms.PictureBox();
            this.lblNombreRec = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lbltipocom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReceta
            // 
            this.pbReceta.Location = new System.Drawing.Point(3, 3);
            this.pbReceta.Name = "pbReceta";
            this.pbReceta.Size = new System.Drawing.Size(130, 144);
            this.pbReceta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReceta.TabIndex = 0;
            this.pbReceta.TabStop = false;
            // 
            // lblNombreRec
            // 
            this.lblNombreRec.AutoSize = true;
            this.lblNombreRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRec.Location = new System.Drawing.Point(153, 15);
            this.lblNombreRec.Name = "lblNombreRec";
            this.lblNombreRec.Size = new System.Drawing.Size(0, 18);
            this.lblNombreRec.TabIndex = 1;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(142, 65);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(0, 16);
            this.lbldesc.TabIndex = 2;
            // 
            // lbltipocom
            // 
            this.lbltipocom.AutoSize = true;
            this.lbltipocom.Location = new System.Drawing.Point(140, 36);
            this.lbltipocom.Name = "lbltipocom";
            this.lbltipocom.Size = new System.Drawing.Size(0, 13);
            this.lbltipocom.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(522, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "۞";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // recetaViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltipocom);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblNombreRec);
            this.Controls.Add(this.pbReceta);
            this.Name = "recetaViewer";
            this.Size = new System.Drawing.Size(600, 150);
            this.Load += new System.EventHandler(this.recetaViewer_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recetaViewer_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReceta;
        private System.Windows.Forms.Label lblNombreRec;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lbltipocom;
        private System.Windows.Forms.Button button1;
    }
}
