namespace CapaPresentacion1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuAdministrador = new FontAwesome.Sharp.IconMenuItem();
            this.menuInfoActividades = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1488, 116);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuTitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienestar UNAULA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 50;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(182, 79);
            this.menuusuario.Text = "&Regustrarse";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.AutoSize = false;
            this.menuAdministrador.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuAdministrador.IconColor = System.Drawing.Color.Black;
            this.menuAdministrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAdministrador.IconSize = 50;
            this.menuAdministrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Size = new System.Drawing.Size(182, 79);
            this.menuAdministrador.Text = "&Administrador";
            this.menuAdministrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAdministrador.Click += new System.EventHandler(this.menumantenedor_Click);
            // 
            // menuInfoActividades
            // 
            this.menuInfoActividades.AutoSize = false;
            this.menuInfoActividades.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuInfoActividades.IconColor = System.Drawing.Color.Black;
            this.menuInfoActividades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInfoActividades.IconSize = 50;
            this.menuInfoActividades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInfoActividades.Name = "menuInfoActividades";
            this.menuInfoActividades.Size = new System.Drawing.Size(182, 79);
            this.menuInfoActividades.Text = "&Info de las actividades";
            this.menuInfoActividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuInfoActividades.Click += new System.EventHandler(this.menuInfoActividades_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menuAdministrador,
            this.menuInfoActividades});
            this.menuStrip1.Location = new System.Drawing.Point(0, 116);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1488, 83);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1269, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 830);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menuAdministrador;
        private FontAwesome.Sharp.IconMenuItem menuInfoActividades;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

