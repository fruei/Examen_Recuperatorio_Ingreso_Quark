
namespace Examen_Recuperatorio_Ingreso_Quark
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSocios = new System.Windows.Forms.ListBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.btnCancelarPrestamo = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(261, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Biblioteca Quark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(55, 8, 55, 8);
            this.label2.Size = new System.Drawing.Size(174, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Socios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(261, 70);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(36, 8, 36, 8);
            this.label3.Size = new System.Drawing.Size(249, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prestamos del socio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(565, 70);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(43, 8, 42, 8);
            this.label4.Size = new System.Drawing.Size(247, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Libros disponibles";
            // 
            // lstSocios
            // 
            this.lstSocios.FormattingEnabled = true;
            this.lstSocios.Location = new System.Drawing.Point(16, 124);
            this.lstSocios.Name = "lstSocios";
            this.lstSocios.Size = new System.Drawing.Size(219, 303);
            this.lstSocios.TabIndex = 4;
            this.lstSocios.SelectedValueChanged += new System.EventHandler(this.SocioSelectedValueChange);
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(265, 124);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(273, 199);
            this.lstPrestamos.TabIndex = 5;
            this.lstPrestamos.SelectedValueChanged += new System.EventHandler(this.PrestamosSelectedValueChange);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.Location = new System.Drawing.Point(567, 124);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(283, 251);
            this.lstLibros.TabIndex = 6;
            this.lstLibros.SelectedValueChanged += new System.EventHandler(this.LibroDisponibleSelectedValueChange);
            // 
            // btnCancelarPrestamo
            // 
            this.btnCancelarPrestamo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btnCancelarPrestamo.FlatAppearance.BorderSize = 3;
            this.btnCancelarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarPrestamo.Location = new System.Drawing.Point(265, 340);
            this.btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            this.btnCancelarPrestamo.Size = new System.Drawing.Size(273, 35);
            this.btnCancelarPrestamo.TabIndex = 7;
            this.btnCancelarPrestamo.Text = "Cancelar Prestamo";
            this.btnCancelarPrestamo.UseVisualStyleBackColor = false;
            this.btnCancelarPrestamo.Click += new System.EventHandler(this.btnCancelarPrestamo_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnPrestamo.FlatAppearance.BorderSize = 4;
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrestamo.Location = new System.Drawing.Point(567, 392);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(283, 35);
            this.btnPrestamo.TabIndex = 8;
            this.btnPrestamo.Text = "Prestar Libro";
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(862, 442);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnCancelarPrestamo);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.lstSocios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSocios;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Button btnCancelarPrestamo;
        private System.Windows.Forms.Button btnPrestamo;
    }
}

