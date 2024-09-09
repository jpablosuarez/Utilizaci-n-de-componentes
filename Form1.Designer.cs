namespace WindowsFormsApp1
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
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnMp = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(61, 169);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(197, 113);
            this.btnWeb.TabIndex = 0;
            this.btnWeb.Text = "Web";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnMp
            // 
            this.btnMp.Location = new System.Drawing.Point(302, 169);
            this.btnMp.Name = "btnMp";
            this.btnMp.Size = new System.Drawing.Size(197, 113);
            this.btnMp.TabIndex = 1;
            this.btnMp.Text = "Media Player";
            this.btnMp.UseVisualStyleBackColor = true;
            this.btnMp.Click += new System.EventHandler(this.btnMp_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(543, 169);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(197, 113);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "Reader PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnMp);
            this.Controls.Add(this.btnWeb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnMp;
        private System.Windows.Forms.Button btnPdf;
    }
}

