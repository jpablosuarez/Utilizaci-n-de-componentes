namespace WindowsFormsApp1
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.axMPCancion = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMPCancion)).BeginInit();
            this.SuspendLayout();
            // 
            // axMPCancion
            // 
            this.axMPCancion.Enabled = true;
            this.axMPCancion.Location = new System.Drawing.Point(12, 12);
            this.axMPCancion.Name = "axMPCancion";
            this.axMPCancion.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMPCancion.OcxState")));
            this.axMPCancion.Size = new System.Drawing.Size(455, 288);
            this.axMPCancion.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(358, 384);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(109, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.axMPCancion);
            this.Name = "MediaPlayer";
            this.Text = "MediaPlayer";
            this.Click += new System.EventHandler(this.MediaPlayer_Click);
            ((System.ComponentModel.ISupportInitialize)(this.axMPCancion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axMPCancion;
        private System.Windows.Forms.Button btnPlay;
    }
}