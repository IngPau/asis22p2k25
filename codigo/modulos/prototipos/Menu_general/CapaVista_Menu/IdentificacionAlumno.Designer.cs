
namespace CapaVista_Menu
{
    partial class IdentificacionAlumno
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
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(12, 199);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(743, 38);
            this.Lbl_nombre.TabIndex = 0;
            this.Lbl_nombre.Text = "Paula Daniela Leonardo Paredes  /  0901-22-9580";
            // 
            // IdentificacionAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_nombre);
            this.Name = "IdentificacionAlumno";
            this.Text = "IdentificacionAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_nombre;
    }
}