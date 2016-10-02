namespace WindowsFormsApplication1
{
    partial class BuscarProducto
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
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtProveedorProductoB = new System.Windows.Forms.TextBox();
            this.txtCostoProductoB = new System.Windows.Forms.TextBox();
            this.txtPrecioProductoB = new System.Windows.Forms.TextBox();
            this.txtCantidadProductoB = new System.Windows.Forms.TextBox();
            this.txtProductoB = new System.Windows.Forms.TextBox();
            this.txtIdProductoB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductoBuscado = new System.Windows.Forms.TextBox();
            this.btnImprimeProducto = new System.Windows.Forms.Button();
            this.btnRegresarBP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cajaimagenbusca = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaimagenbusca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(321, 12);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 25;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtProveedorProductoB
            // 
            this.txtProveedorProductoB.Location = new System.Drawing.Point(131, 238);
            this.txtProveedorProductoB.Name = "txtProveedorProductoB";
            this.txtProveedorProductoB.ReadOnly = true;
            this.txtProveedorProductoB.Size = new System.Drawing.Size(149, 20);
            this.txtProveedorProductoB.TabIndex = 24;
            // 
            // txtCostoProductoB
            // 
            this.txtCostoProductoB.Location = new System.Drawing.Point(131, 201);
            this.txtCostoProductoB.Name = "txtCostoProductoB";
            this.txtCostoProductoB.ReadOnly = true;
            this.txtCostoProductoB.Size = new System.Drawing.Size(149, 20);
            this.txtCostoProductoB.TabIndex = 23;
            // 
            // txtPrecioProductoB
            // 
            this.txtPrecioProductoB.Location = new System.Drawing.Point(131, 167);
            this.txtPrecioProductoB.Name = "txtPrecioProductoB";
            this.txtPrecioProductoB.ReadOnly = true;
            this.txtPrecioProductoB.Size = new System.Drawing.Size(149, 20);
            this.txtPrecioProductoB.TabIndex = 22;
            // 
            // txtCantidadProductoB
            // 
            this.txtCantidadProductoB.Location = new System.Drawing.Point(131, 138);
            this.txtCantidadProductoB.Name = "txtCantidadProductoB";
            this.txtCantidadProductoB.ReadOnly = true;
            this.txtCantidadProductoB.Size = new System.Drawing.Size(149, 20);
            this.txtCantidadProductoB.TabIndex = 21;
            // 
            // txtProductoB
            // 
            this.txtProductoB.Location = new System.Drawing.Point(131, 101);
            this.txtProductoB.Name = "txtProductoB";
            this.txtProductoB.ReadOnly = true;
            this.txtProductoB.Size = new System.Drawing.Size(149, 20);
            this.txtProductoB.TabIndex = 20;
            // 
            // txtIdProductoB
            // 
            this.txtIdProductoB.Location = new System.Drawing.Point(135, 37);
            this.txtIdProductoB.Name = "txtIdProductoB";
            this.txtIdProductoB.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoB.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID de producto a Buscar";
            // 
            // txtProductoBuscado
            // 
            this.txtProductoBuscado.Location = new System.Drawing.Point(131, 66);
            this.txtProductoBuscado.Name = "txtProductoBuscado";
            this.txtProductoBuscado.ReadOnly = true;
            this.txtProductoBuscado.Size = new System.Drawing.Size(149, 20);
            this.txtProductoBuscado.TabIndex = 27;
            // 
            // btnImprimeProducto
            // 
            this.btnImprimeProducto.Location = new System.Drawing.Point(484, 216);
            this.btnImprimeProducto.Name = "btnImprimeProducto";
            this.btnImprimeProducto.Size = new System.Drawing.Size(75, 23);
            this.btnImprimeProducto.TabIndex = 29;
            this.btnImprimeProducto.Text = "Imprimir";
            this.btnImprimeProducto.UseVisualStyleBackColor = true;
            this.btnImprimeProducto.Click += new System.EventHandler(this.btnImprimeProducto_Click);
            // 
            // btnRegresarBP
            // 
            this.btnRegresarBP.Location = new System.Drawing.Point(579, 12);
            this.btnRegresarBP.Name = "btnRegresarBP";
            this.btnRegresarBP.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarBP.TabIndex = 30;
            this.btnRegresarBP.Text = "Regresar";
            this.btnRegresarBP.UseVisualStyleBackColor = true;
            this.btnRegresarBP.Click += new System.EventHandler(this.btnRegresarBP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Nombre Proveedor";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(131, 271);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(149, 20);
            this.txtNombreProveedor.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtProveedorProductoB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdProductoB);
            this.groupBox1.Controls.Add(this.txtProductoBuscado);
            this.groupBox1.Controls.Add(this.txtCostoProductoB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecioProductoB);
            this.groupBox1.Controls.Add(this.txtProductoB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidadProductoB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 318);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.cajaimagenbusca);
            this.groupBox2.Location = new System.Drawing.Point(429, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 172);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // cajaimagenbusca
            // 
            this.cajaimagenbusca.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.cajaimagenbusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cajaimagenbusca.Location = new System.Drawing.Point(23, 19);
            this.cajaimagenbusca.Name = "cajaimagenbusca";
            this.cajaimagenbusca.Size = new System.Drawing.Size(136, 125);
            this.cajaimagenbusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cajaimagenbusca.TabIndex = 28;
            this.cajaimagenbusca.TabStop = false;
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(679, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarBP);
            this.Controls.Add(this.btnImprimeProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Name = "BuscarProducto";
            this.Text = "Buscar Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cajaimagenbusca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtProveedorProductoB;
        private System.Windows.Forms.TextBox txtCostoProductoB;
        private System.Windows.Forms.TextBox txtPrecioProductoB;
        private System.Windows.Forms.TextBox txtCantidadProductoB;
        private System.Windows.Forms.TextBox txtProductoB;
        private System.Windows.Forms.TextBox txtIdProductoB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductoBuscado;
        private System.Windows.Forms.PictureBox cajaimagenbusca;
        private System.Windows.Forms.Button btnImprimeProducto;
        private System.Windows.Forms.Button btnRegresarBP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}