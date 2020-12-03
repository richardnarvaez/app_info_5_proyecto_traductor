namespace apps_info_5_proyecto_traductor
{
    partial class ItemListHistorial
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label_short = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label_short);
            this.guna2ShadowPanel1.Controls.Add(this.label_to);
            this.guna2ShadowPanel1.Controls.Add(this.label_from);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 4;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 30;
            this.guna2ShadowPanel1.ShadowShift = 2;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(345, 90);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // label_short
            // 
            this.label_short.AutoSize = true;
            this.label_short.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_short.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_short.Location = new System.Drawing.Point(231, 32);
            this.label_short.Name = "label_short";
            this.label_short.Size = new System.Drawing.Size(83, 20);
            this.label_short.TabIndex = 2;
            this.label_short.Text = "ES to EN";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(19, 49);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(67, 13);
            this.label_to.TabIndex = 1;
            this.label_to.Text = "To Translate";
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_from.Location = new System.Drawing.Point(19, 25);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(87, 13);
            this.label_from.TabIndex = 0;
            this.label_from.Text = "FromTranslate";
            // 
            // ItemListHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ItemListHistorial";
            this.Size = new System.Drawing.Size(351, 96);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_short;
    }
}
