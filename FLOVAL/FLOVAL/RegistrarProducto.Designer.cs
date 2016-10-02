namespace WindowsFormsApplication1
{
    partial class RegistrarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCostoProducto = new System.Windows.Forms.TextBox();
            this.txtProveedorProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.EtiquetaId = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnRegresarAP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.cajaimagenproducto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaimagenproducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Proveedor";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(72, 44);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 7;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(72, 76);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.ReadOnly = true;
            this.txtCantidadProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadProducto.TabIndex = 8;
            this.txtCantidadProducto.Text = "0";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(72, 109);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 9;
            // 
            // txtCostoProducto
            // 
            this.txtCostoProducto.Location = new System.Drawing.Point(74, 144);
            this.txtCostoProducto.Name = "txtCostoProducto";
            this.txtCostoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCostoProducto.TabIndex = 10;
            // 
            // txtProveedorProducto
            // 
            this.txtProveedorProducto.Location = new System.Drawing.Point(74, 180);
            this.txtProveedorProducto.Name = "txtProveedorProducto";
            this.txtProveedorProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProveedorProducto.TabIndex = 11;
            this.txtProveedorProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedorProducto_KeyPress);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(190, 22);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 12;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // EtiquetaId
            // 
            this.EtiquetaId.AutoSize = true;
            this.EtiquetaId.Location = new System.Drawing.Point(84, 22);
            this.EtiquetaId.Name = "EtiquetaId";
            this.EtiquetaId.Size = new System.Drawing.Size(13, 13);
            this.EtiquetaId.TabIndex = 13;
            this.EtiquetaId.Text = "0";
            // 
            // btnImagen
            // 
            this.btnImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImagen.Location = new System.Drawing.Point(413, 212);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(105, 23);
            this.btnImagen.TabIndex = 15;
            this.btnImagen.Text = "Agregar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // btnRegresarAP
            // 
            this.btnRegresarAP.Location = new System.Drawing.Point(533, 212);
            this.btnRegresarAP.Name = "btnRegresarAP";
            this.btnRegresarAP.Size = new System.Drawing.Size(70, 23);
            this.btnRegresarAP.TabIndex = 16;
            this.btnRegresarAP.Text = "Regresar";
            this.btnRegresarAP.UseVisualStyleBackColor = true;
            this.btnRegresarAP.Click += new System.EventHandler(this.btnRegresarAP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EtiquetaId);
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProveedorProducto);
            this.groupBox1.Controls.Add(this.txtCantidadProducto);
            this.groupBox1.Controls.Add(this.txtCostoProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(41, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 248);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nombre";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(72, 206);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(226, 20);
            this.txtNombreProveedor.TabIndex = 18;
            // 
            // cajaimagenproducto
            // 
            this.cajaimagenproducto.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.cajaimagenproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cajaimagenproducto.InitialImage = null;
            this.cajaimagenproducto.Location = new System.Drawing.Point(16, 36);
            this.cajaimagenproducto.Name = "cajaimagenproducto";
            this.cajaimagenproducto.Size = new System.Drawing.Size(171, 111);
            this.cajaimagenproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cajaimagenproducto.TabIndex = 14;
            this.cajaimagenproducto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.cajaimagenproducto);
            this.groupBox2.Location = new System.Drawing.Point(397, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 179);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // RegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.ClientSize = new System.Drawing.Size(615, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarAP);
            this.Controls.Add(this.btnImagen);
            this.Name = "RegistrarProducto";
            this.Text = "Alta de Producto";
            this.Load += new System.EventHandler(this.RegistrarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaimagenproducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCostoProducto;
        private System.Windows.Forms.TextBox txtProveedorProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label EtiquetaId;
        private System.Windows.Forms.PictureBox cajaimagenproducto;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnRegresarAP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}