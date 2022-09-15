
namespace PilasyColas
{
    partial class FrmCola
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
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnVacia = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.lstcolas = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtColas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(12, 256);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 17;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnVacia
            // 
            this.btnVacia.Location = new System.Drawing.Point(99, 256);
            this.btnVacia.Name = "btnVacia";
            this.btnVacia.Size = new System.Drawing.Size(75, 23);
            this.btnVacia.TabIndex = 16;
            this.btnVacia.Text = "Vacia?";
            this.btnVacia.UseVisualStyleBackColor = true;
            this.btnVacia.Click += new System.EventHandler(this.btnVacia_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(189, 256);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 15;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // lstcolas
            // 
            this.lstcolas.FormattingEnabled = true;
            this.lstcolas.Location = new System.Drawing.Point(12, 38);
            this.lstcolas.Name = "lstcolas";
            this.lstcolas.Size = new System.Drawing.Size(252, 212);
            this.lstcolas.TabIndex = 14;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(189, 11);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 21);
            this.btnAñadir.TabIndex = 13;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtColas
            // 
            this.txtColas.Location = new System.Drawing.Point(12, 12);
            this.txtColas.Name = "txtColas";
            this.txtColas.Size = new System.Drawing.Size(162, 20);
            this.txtColas.TabIndex = 12;
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 286);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnVacia);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.lstcolas);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtColas);
            this.Name = "FrmCola";
            this.Text = "Colas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnVacia;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.ListBox lstcolas;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txtColas;
    }
}