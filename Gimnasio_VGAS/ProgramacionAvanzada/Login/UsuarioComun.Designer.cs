namespace ProgramacionAvanzada.Login
{
    partial class UsuarioComun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioComun));
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lbltipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(32, 39);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje.TabIndex = 0;
            // 
            // lbltipoUsuario
            // 
            this.lbltipoUsuario.AutoSize = true;
            this.lbltipoUsuario.Location = new System.Drawing.Point(35, 179);
            this.lbltipoUsuario.Name = "lbltipoUsuario";
            this.lbltipoUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbltipoUsuario.TabIndex = 1;
            this.lbltipoUsuario.Text = "Usuario";
            // 
            // UsuarioComun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramacionAvanzada.Properties.Resources.gym;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(442, 265);
            this.Controls.Add(this.lbltipoUsuario);
            this.Controls.Add(this.lblmensaje);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioComun";
            this.Text = "UsuarioComun";
            this.Load += new System.EventHandler(this.UsuarioComun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lbltipoUsuario;
    }
}