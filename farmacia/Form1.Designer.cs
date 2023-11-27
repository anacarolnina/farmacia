
namespace farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ENTRAR
            // 
            this.ENTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ENTRAR.BackgroundImage = global::farmacia.Properties.Resources.Logo_Farmacia_Salud_y_Bienestar_Minimalista_Azul_Celeste;
            this.ENTRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ENTRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENTRAR.ForeColor = System.Drawing.Color.White;
            this.ENTRAR.Location = new System.Drawing.Point(195, 398);
            this.ENTRAR.Name = "ENTRAR";
            this.ENTRAR.Size = new System.Drawing.Size(111, 47);
            this.ENTRAR.TabIndex = 0;
            this.ENTRAR.Text = "ENTRAR";
            this.ENTRAR.UseVisualStyleBackColor = false;
            this.ENTRAR.Click += new System.EventHandler(this.ENTRAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::farmacia.Properties.Resources.Logo_Farmacia_Salud_y_Bienestar_Minimalista_Azul_Celeste;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(494, 495);
            this.Controls.Add(this.ENTRAR);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(514, 538);
            this.MinimumSize = new System.Drawing.Size(514, 538);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FARMACIA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ENTRAR;
    }
}

