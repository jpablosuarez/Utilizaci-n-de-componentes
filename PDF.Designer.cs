namespace WindowsFormsApp1
{
    partial class PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF));
            this.axPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // axPDF1
            // 
            this.axPDF1.Enabled = true;
            this.axPDF1.Location = new System.Drawing.Point(32, 34);
            this.axPDF1.Name = "axPDF1";
            this.axPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPDF1.OcxState")));
            this.axPDF1.Size = new System.Drawing.Size(374, 299);
            this.axPDF1.TabIndex = 0;
            // 
            // PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axPDF1);
            this.Name = "PDF";
            this.Text = "PDF";
            this.Load += new System.EventHandler(this.PDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axPDF1;
    }
}