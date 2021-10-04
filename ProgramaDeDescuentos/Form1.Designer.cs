
namespace ProgramaDeDescuentos
{
    partial class Principal
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
            this.Pnl_bolitas = new System.Windows.Forms.Panel();
            this.Pnl_Resultados = new System.Windows.Forms.Panel();
            this.Pnl_bolanaranja = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_bolitas.SuspendLayout();
            this.Pnl_bolanaranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_bolitas
            // 
            this.Pnl_bolitas.Controls.Add(this.Pnl_bolanaranja);
            this.Pnl_bolitas.Location = new System.Drawing.Point(12, 12);
            this.Pnl_bolitas.Name = "Pnl_bolitas";
            this.Pnl_bolitas.Size = new System.Drawing.Size(984, 512);
            this.Pnl_bolitas.TabIndex = 0;
            // 
            // Pnl_Resultados
            // 
            this.Pnl_Resultados.Location = new System.Drawing.Point(12, 530);
            this.Pnl_Resultados.Name = "Pnl_Resultados";
            this.Pnl_Resultados.Size = new System.Drawing.Size(984, 187);
            this.Pnl_Resultados.TabIndex = 1;
            // 
            // Pnl_bolanaranja
            // 
            this.Pnl_bolanaranja.Controls.Add(this.label2);
            this.Pnl_bolanaranja.Controls.Add(this.pictureBox1);
            this.Pnl_bolanaranja.Controls.Add(this.label1);
            this.Pnl_bolanaranja.Location = new System.Drawing.Point(21, 20);
            this.Pnl_bolanaranja.Name = "Pnl_bolanaranja";
            this.Pnl_bolanaranja.Size = new System.Drawing.Size(201, 246);
            this.Pnl_bolanaranja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naranja 15% de descuento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Pnl_Resultados);
            this.Controls.Add(this.Pnl_bolitas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Pnl_bolitas.ResumeLayout(false);
            this.Pnl_bolanaranja.ResumeLayout(false);
            this.Pnl_bolanaranja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_bolitas;
        private System.Windows.Forms.Panel Pnl_bolanaranja;
        private System.Windows.Forms.Panel Pnl_Resultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

