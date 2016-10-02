namespace WindowsFormsApplication1
{
    partial class ModificarProducto
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
            this.txtProductoBuscadoM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarProductoM = new System.Windows.Forms.Button();
            this.txtProveedorProductoBM = new System.Windows.Forms.TextBox();
            this.txtCostoProductoBM = new System.Windows.Forms.TextBox();
            this.txtPrecioProductoBM = new System.Windows.Forms.TextBox();
            this.txtCantidadProductoBM = new System.Windows.Forms.TextBox();
            this.txtProductoBM = new System.Windows.Forms.TextBox();
            this.txtIdProductoBM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificaProducto = new System.Windows.Forms.Button();
            this.btnCambiaImagen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegresaAP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbxmodificaimagen = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxmodificaimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductoBuscadoM
            // 
            this.txtProductoBuscadoM.Location = new System.Drawing.Point(103, 31);
            this.txtProductoBuscadoM.Name = "txtProductoBuscadoM";
            this.txtProductoBuscadoM.ReadOnly = true;
            this.txtProductoBuscadoM.Size = new System.Drawing.Size(100, 20);
            this.txtProductoBuscadoM.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "ID de producto a Buscar";
            // 
            // btnBuscarProductoM
            // 
            this.btnBuscarProductoM.Location = new System.Drawing.Point(261, 26);
            this.btnBuscarProductoM.Name = "btnBuscarProductoM";
            this.btnBuscarProductoM.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProductoM.TabIndex = 40;
            this.btnBuscarProductoM.Text = "Buscar";
            this.btnBuscarProductoM.UseVisualStyleBackColor = true;
            this.btnBuscarProductoM.Click += new System.EventHandler(this.btnBuscarProductoM_Click);
            // 
            // txtProveedorProductoBM
            // 
            this.txtProveedorProductoBM.Location = new System.Drawing.Point(103, 163);
            this.txtProveedorProductoBM.Name = "txtProveedorProductoBM";
            this.txtProveedorProductoBM.Size = new System.Drawing.Size(100, 20);
            this.txtProveedorProductoBM.TabIndex = 39;
            // 
            // txtCostoProductoBM
            // 
            this.txtCostoProductoBM.Location = new System.Drawing.Point(103, 137);
            this.txtCostoProductoBM.Name = "txtCostoProductoBM";
            this.txtCostoProductoBM.Size = new System.Drawing.Size(100, 20);
            this.txtCostoProductoBM.TabIndex = 38;
            // 
            // txtPrecioProductoBM
            // 
            this.txtPrecioProductoBM.Location = new System.Drawing.Point(103, 111);
            this.txtPrecioProductoBM.Name = "txtPrecioProductoBM";
            this.txtPrecioProductoBM.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProductoBM.TabIndex = 37;
            // 
            // txtCantidadProductoBM
            // 
            this.txtCantidadProductoBM.Location = new System.Drawing.Point(103, 85);
            this.txtCantidadProductoBM.Name = "txtCantidadProductoBM";
            this.txtCantidadProductoBM.ReadOnly = true;
            this.txtCantidadProductoBM.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadProductoBM.TabIndex = 36;
            // 
            // txtProductoBM
            // 
            this.txtProductoBM.Location = new System.Drawing.Point(103, 59);
            this.txtProductoBM.Name = "txtProductoBM";
            this.txtProductoBM.Size = new System.Drawing.Size(100, 20);
            this.txtProductoBM.TabIndex = 35;
            // 
            // txtIdProductoBM
            // 
            this.txtIdProductoBM.Location = new System.Drawing.Point(146, 28);
            this.txtIdProductoBM.Name = "txtIdProductoBM";
            this.txtIdProductoBM.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoBM.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID Producto";
            // 
            // btnModificaProducto
            // 
            this.btnModificaProducto.Location = new System.Drawing.Point(261, 62);
            this.btnModificaProducto.Name = "btnModificaProducto";
            this.btnModificaProducto.Size = new System.Drawing.Size(75, 23);
            this.btnModificaProducto.TabIndex = 47;
            this.btnModificaProducto.Text = "Modificar";
            this.btnModificaProducto.UseVisualStyleBackColor = true;
            this.btnModificaProducto.Click += new System.EventHandler(this.btnModificaProducto_Click);
            // 
            // btnCambiaImagen
            // 
            this.btnCambiaImagen.Location = new System.Drawing.Point(397, 251);
            this.btnCambiaImagen.Name = "btnCambiaImagen";
            this.btnCambiaImagen.Size = new System.Drawing.Size(130, 23);
            this.btnCambiaImagen.TabIndex = 48;
            this.btnCambiaImagen.Text = "Cambiar Imagen";
            this.btnCambiaImagen.UseVisualStyleBackColor = true;
            this.btnCambiaImagen.Click += new System.EventHandler(this.btnCambiaImagen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtProductoBuscadoM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProductoBM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidadProductoBM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProveedorProductoBM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecioProductoBM);
            this.groupBox1.Controls.Add(this.txtCostoProductoBM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(20, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 236);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Producto";
            // 
            // btnRegresaAP
            // 
            this.btnRegresaAP.Location = new System.Drawing.Point(520, 23);
            this.btnRegresaAP.Name = "btnRegresaAP";
            this.btnRegresaAP.Size = new System.Drawing.Size(75, 23);
            this.btnRegresaAP.TabIndex = 51;
            this.btnRegresaAP.Text = "Regresar";
            this.btnRegresaAP.UseVisualStyleBackColor = true;
            this.btnRegresaAP.Click += new System.EventHandler(this.btnRegresaAP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.pbxmodificaimagen);
            this.groupBox2.Location = new System.Drawing.Point(390, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 161);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // pbxmodificaimagen
            // 
            this.pbxmodificaimagen.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.pbxmodificaimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxmodificaimagen.InitialImage = null;
            this.pbxmodificaimagen.Location = new System.Drawing.Point(23, 20);
            this.pbxmodificaimagen.Name = "pbxmodificaimagen";
            this.pbxmodificaimagen.Size = new System.Drawing.Size(182, 118);
            this.pbxmodificaimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxmodificaimagen.TabIndex = 49;
            this.pbxmodificaimagen.TabStop = false;
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(623, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegresaAP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCambiaImagen);
            this.Controls.Add(this.btnModificaProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarProductoM);
            this.Controls.Add(this.txtIdProductoBM);
            this.Name = "ModificarProducto";
            this.Text = "Actualizar Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxmodificaimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductoBuscadoM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarProductoM;
        private System.Windows.Forms.TextBox txtProveedorProductoBM;
        private System.Windows.Forms.TextBox txtCostoProductoBM;
        private System.Windows.Forms.TextBox txtPrecioProductoBM;
        private System.Windows.Forms.TextBox txtCantidadProductoBM;
        private System.Windows.Forms.TextBox txtProductoBM;
        private System.Windows.Forms.TextBox txtIdProductoBM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificaProducto;
        private System.Windows.Forms.Button btnCambiaImagen;
        private System.Windows.Forms.PictureBox pbxmodificaimagen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegresaAP;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}