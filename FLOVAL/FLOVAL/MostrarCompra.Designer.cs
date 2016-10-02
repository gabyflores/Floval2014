namespace WindowsFormsApplication1
{
    partial class MostrarCompra
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
            this.dgvMuestraVenta = new System.Windows.Forms.DataGridView();
            this.dgvMuestraDetalleCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegresMC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pboxImagenCompraM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetalleCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenCompraM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestraVenta
            // 
            this.dgvMuestraVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraVenta.Location = new System.Drawing.Point(21, 32);
            this.dgvMuestraVenta.Name = "dgvMuestraVenta";
            this.dgvMuestraVenta.Size = new System.Drawing.Size(459, 208);
            this.dgvMuestraVenta.TabIndex = 0;
            this.dgvMuestraVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestraVenta_CellClick);
            // 
            // dgvMuestraDetalleCompra
            // 
            this.dgvMuestraDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraDetalleCompra.Location = new System.Drawing.Point(19, 26);
            this.dgvMuestraDetalleCompra.Name = "dgvMuestraDetalleCompra";
            this.dgvMuestraDetalleCompra.Size = new System.Drawing.Size(403, 190);
            this.dgvMuestraDetalleCompra.TabIndex = 1;
            this.dgvMuestraDetalleCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestraDetalleCompra_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dgvMuestraVenta);
            this.groupBox1.Location = new System.Drawing.Point(41, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.dgvMuestraDetalleCompra);
            this.groupBox2.Location = new System.Drawing.Point(593, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 234);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos por Compra";
            // 
            // btnRegresMC
            // 
            this.btnRegresMC.Location = new System.Drawing.Point(1127, 12);
            this.btnRegresMC.Name = "btnRegresMC";
            this.btnRegresMC.Size = new System.Drawing.Size(75, 23);
            this.btnRegresMC.TabIndex = 4;
            this.btnRegresMC.Text = "Regresar";
            this.btnRegresMC.UseVisualStyleBackColor = true;
            this.btnRegresMC.Click += new System.EventHandler(this.btnRegresMC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.pboxImagenCompraM);
            this.groupBox3.Location = new System.Drawing.Point(1054, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 151);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // pboxImagenCompraM
            // 
            this.pboxImagenCompraM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxImagenCompraM.Location = new System.Drawing.Point(22, 19);
            this.pboxImagenCompraM.Name = "pboxImagenCompraM";
            this.pboxImagenCompraM.Size = new System.Drawing.Size(100, 110);
            this.pboxImagenCompraM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagenCompraM.TabIndex = 0;
            this.pboxImagenCompraM.TabStop = false;
            // 
            // MostrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1214, 329);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegresMC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MostrarCompra";
            this.Text = "Mostrar Compra";
            this.Load += new System.EventHandler(this.MostrarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetalleCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenCompraM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestraVenta;
        private System.Windows.Forms.DataGridView dgvMuestraDetalleCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegresMC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pboxImagenCompraM;
    }
}