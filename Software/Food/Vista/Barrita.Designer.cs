namespace Vista
{
    partial class Barrita
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
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnsigue = new System.Windows.Forms.Button();
            this.btnfavoritos = new System.Windows.Forms.Button();
            this.btnreceta = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(45, 31);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnsigue
            // 
            this.btnsigue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsigue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsigue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsigue.Location = new System.Drawing.Point(0, 31);
            this.btnsigue.Name = "btnsigue";
            this.btnsigue.Size = new System.Drawing.Size(45, 31);
            this.btnsigue.TabIndex = 1;
            this.btnsigue.Text = "Sigue";
            this.btnsigue.UseVisualStyleBackColor = false;
            this.btnsigue.Click += new System.EventHandler(this.btnsigue_Click);
            // 
            // btnfavoritos
            // 
            this.btnfavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnfavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnfavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfavoritos.Location = new System.Drawing.Point(0, 62);
            this.btnfavoritos.Name = "btnfavoritos";
            this.btnfavoritos.Size = new System.Drawing.Size(45, 31);
            this.btnfavoritos.TabIndex = 2;
            this.btnfavoritos.Text = "favoritos";
            this.btnfavoritos.UseVisualStyleBackColor = false;
            this.btnfavoritos.Click += new System.EventHandler(this.btnfavoritos_Click);
            // 
            // btnreceta
            // 
            this.btnreceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnreceta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnreceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreceta.Location = new System.Drawing.Point(0, 93);
            this.btnreceta.Name = "btnreceta";
            this.btnreceta.Size = new System.Drawing.Size(45, 31);
            this.btnreceta.TabIndex = 3;
            this.btnreceta.Text = "Misrecetas";
            this.btnreceta.UseVisualStyleBackColor = false;
            this.btnreceta.Click += new System.EventHandler(this.btnreceta_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(0, 477);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(45, 31);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(0, 446);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Barrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnreceta);
            this.Controls.Add(this.btnfavoritos);
            this.Controls.Add(this.btnsigue);
            this.Controls.Add(this.btnPerfil);
            this.Name = "Barrita";
            this.Size = new System.Drawing.Size(45, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnsigue;
        private System.Windows.Forms.Button btnfavoritos;
        private System.Windows.Forms.Button btnreceta;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBuscar;
    }
}
