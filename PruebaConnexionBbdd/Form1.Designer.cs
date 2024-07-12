namespace PruebaConnexionBbdd
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
            this.butConnectar = new System.Windows.Forms.Button();
            this.butDesconnectar = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.butInsertar = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butConnectar
            // 
            this.butConnectar.Location = new System.Drawing.Point(130, 202);
            this.butConnectar.Name = "butConnectar";
            this.butConnectar.Size = new System.Drawing.Size(163, 83);
            this.butConnectar.TabIndex = 0;
            this.butConnectar.Text = "Connectar";
            this.butConnectar.UseVisualStyleBackColor = true;
            this.butConnectar.Click += new System.EventHandler(this.butConnectar_Click);
            // 
            // butDesconnectar
            // 
            this.butDesconnectar.Location = new System.Drawing.Point(479, 202);
            this.butDesconnectar.Name = "butDesconnectar";
            this.butDesconnectar.Size = new System.Drawing.Size(178, 83);
            this.butDesconnectar.TabIndex = 1;
            this.butDesconnectar.Text = "Desconnectar";
            this.butDesconnectar.UseVisualStyleBackColor = true;
            this.butDesconnectar.Click += new System.EventHandler(this.butDesconnectar_Click);
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrincipal.Location = new System.Drawing.Point(281, 124);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(244, 32);
            this.labelPrincipal.TabIndex = 2;
            this.labelPrincipal.Text = "Conexión Cerrada";
            // 
            // butInsertar
            // 
            this.butInsertar.Location = new System.Drawing.Point(335, 350);
            this.butInsertar.Name = "butInsertar";
            this.butInsertar.Size = new System.Drawing.Size(75, 23);
            this.butInsertar.TabIndex = 3;
            this.butInsertar.Text = "Insertar";
            this.butInsertar.UseVisualStyleBackColor = true;
            this.butInsertar.Click += new System.EventHandler(this.butInsertar_Click);
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(449, 350);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(75, 23);
            this.butSelect.TabIndex = 4;
            this.butSelect.Text = "Select";
            this.butSelect.UseVisualStyleBackColor = true;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butSelect);
            this.Controls.Add(this.butInsertar);
            this.Controls.Add(this.labelPrincipal);
            this.Controls.Add(this.butDesconnectar);
            this.Controls.Add(this.butConnectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConnectar;
        private System.Windows.Forms.Button butDesconnectar;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.Button butInsertar;
        private System.Windows.Forms.Button butSelect;
    }
}

