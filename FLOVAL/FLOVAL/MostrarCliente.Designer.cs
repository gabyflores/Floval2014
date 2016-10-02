namespace WindowsFormsApplication1
{
    partial class MostrarCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClienteMuestra = new System.Windows.Forms.DataGridView();
            this.btnRegresarCR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteMuestra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClienteMuestra
            // 
            this.dgvClienteMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteMuestra.Location = new System.Drawing.Point(16, 31);
            this.dgvClienteMuestra.Name = "dgvClienteMuestra";
            this.dgvClienteMuestra.Size = new System.Drawing.Size(523, 185);
            this.dgvClienteMuestra.TabIndex = 0;
            // 
            // btnRegresarCR
            // 
            this.btnRegresarCR.Location = new System.Drawing.Point(638, 47);
            this.btnRegresarCR.Name = "btnRegresarCR";
            this.btnRegresarCR.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarCR.TabIndex = 1;
            this.btnRegresarCR.Text = "Regresar";
            this.btnRegresarCR.UseVisualStyleBackColor = true;
            this.btnRegresarCR.Click += new System.EventHandler(this.btnRegresarCR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dgvClienteMuestra);
            this.groupBox1.Location = new System.Drawing.Point(61, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // MostrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(746, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarCR);
            this.Name = "MostrarCliente";
            this.Text = "Clientes Registrados";
            this.Load += new System.EventHandler(this.MostrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteMuestra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienteMuestra;
        private System.Windows.Forms.Button btnRegresarCR;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}