namespace CapaPresentacion1
{
    partial class frmInfoActividades
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
            this.dgvInfoActividades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoActividades
            // 
            this.dgvInfoActividades.AllowUserToAddRows = false;
            this.dgvInfoActividades.AllowUserToDeleteRows = false;
            this.dgvInfoActividades.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfoActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInfoActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoActividades.Location = new System.Drawing.Point(39, 21);
            this.dgvInfoActividades.Name = "dgvInfoActividades";
            this.dgvInfoActividades.ReadOnly = true;
            this.dgvInfoActividades.RowHeadersWidth = 62;
            this.dgvInfoActividades.RowTemplate.Height = 30;
            this.dgvInfoActividades.Size = new System.Drawing.Size(1440, 783);
            this.dgvInfoActividades.TabIndex = 0;
            // 
            // frmInfoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 831);
            this.Controls.Add(this.dgvInfoActividades);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInfoActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de Actividades";
            this.Load += new System.EventHandler(this.frmInfoActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoActividades;
    }
}