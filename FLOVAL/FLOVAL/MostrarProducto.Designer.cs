namespace WindowsFormsApplication1
{
    partial class MostrarProducto
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
            this.dgvMostrarProductos = new System.Windows.Forms.DataGridView();
            this.btnRegresaRP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pboxProductoMuestra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProductoMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarProductos
            // 
            this.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProductos.Location = new System.Drawing.Point(20, 36);
            this.dgvMostrarProductos.Name = "dgvMostrarProductos";
            this.dgvMostrarProductos.Size = new System.Drawing.Size(364, 167);
            this.dgvMostrarProductos.TabIndex = 0;
            this.dgvMostrarProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarProductos_CellClick);
            // 
            // btnRegresaRP
            // 
            this.btnRegresaRP.Location = new System.Drawing.Point(617, 21);
            this.btnRegresaRP.Name = "btnRegresaRP";
            this.btnRegresaRP.Size = new System.Drawing.Size(75, 23);
            this.btnRegresaRP.TabIndex = 1;
            this.btnRegresaRP.Text = "Regresa";
            this.btnRegresaRP.UseVisualStyleBackColor = true;
            this.btnRegresaRP.Click += new System.EventHandler(this.btnRegresaRP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvMostrarProductos);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Da click en el ID para Mostrar la Imagen";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.pboxProductoMuestra);
            this.groupBox2.Location = new System.Drawing.Point(492, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 207);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // pboxProductoMuestra
            // 
            this.pboxProductoMuestra.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.pboxProductoMuestra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxProductoMuestra.Location = new System.Drawing.Point(23, 26);
            this.pboxProductoMuestra.Name = "pboxProductoMuestra";
            this.pboxProductoMuestra.Size = new System.Drawing.Size(151, 155);
            this.pboxProductoMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxProductoMuestra.TabIndex = 3;
            this.pboxProductoMuestra.TabStop = false;
            // 
            // MostrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(704, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresaRP);
            this.Name = "MostrarProducto";
            this.Text = "Productos Registrados";
            this.Load += new System.EventHandler(this.MostrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProductoMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarProductos;
        private System.Windows.Forms.Button btnRegresaRP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pboxProductoMuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}