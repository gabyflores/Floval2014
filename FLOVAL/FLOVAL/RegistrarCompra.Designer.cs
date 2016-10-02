namespace WindowsFormsApplication1
{
    partial class RegistrarCompra
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
            this.txtIdProductoRC = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvRCompra = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetrasoRC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProveedorRC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIvaRC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPuntosCompra = new System.Windows.Forms.TextBox();
            this.btnGrabarRC = new System.Windows.Forms.Button();
            this.lblfechaCompra = new System.Windows.Forms.Label();
            this.dtpVenta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFolioVenta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreProveedorRC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductoRC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCostoRC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCantidadRC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSubtotalRC = new System.Windows.Forms.TextBox();
            this.btnRegresarRC = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pboxRegistraCompra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRegistraCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // txtIdProductoRC
            // 
            this.txtIdProductoRC.Location = new System.Drawing.Point(94, 19);
            this.txtIdProductoRC.Name = "txtIdProductoRC";
            this.txtIdProductoRC.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoRC.TabIndex = 4;
            this.txtIdProductoRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProductoRC_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(76, 80);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // dgvRCompra
            // 
            this.dgvRCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRCompra.Location = new System.Drawing.Point(48, 208);
            this.dgvRCompra.Name = "dgvRCompra";
            this.dgvRCompra.Size = new System.Drawing.Size(540, 159);
            this.dgvRCompra.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // txtRetrasoRC
            // 
            this.txtRetrasoRC.Location = new System.Drawing.Point(60, 63);
            this.txtRetrasoRC.Name = "txtRetrasoRC";
            this.txtRetrasoRC.ReadOnly = true;
            this.txtRetrasoRC.Size = new System.Drawing.Size(98, 20);
            this.txtRetrasoRC.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID Proveedor";
            // 
            // txtIdProveedorRC
            // 
            this.txtIdProveedorRC.Location = new System.Drawing.Point(51, 49);
            this.txtIdProveedorRC.Name = "txtIdProveedorRC";
            this.txtIdProveedorRC.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedorRC.TabIndex = 11;
            this.txtIdProveedorRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProveedorRC_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Iva";
            // 
            // txtIvaRC
            // 
            this.txtIvaRC.Location = new System.Drawing.Point(76, 54);
            this.txtIvaRC.Name = "txtIvaRC";
            this.txtIvaRC.ReadOnly = true;
            this.txtIvaRC.Size = new System.Drawing.Size(100, 20);
            this.txtIvaRC.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Puntos";
            // 
            // txtPuntosCompra
            // 
            this.txtPuntosCompra.Location = new System.Drawing.Point(60, 30);
            this.txtPuntosCompra.Name = "txtPuntosCompra";
            this.txtPuntosCompra.ReadOnly = true;
            this.txtPuntosCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPuntosCompra.TabIndex = 15;
            // 
            // btnGrabarRC
            // 
            this.btnGrabarRC.Location = new System.Drawing.Point(726, 176);
            this.btnGrabarRC.Name = "btnGrabarRC";
            this.btnGrabarRC.Size = new System.Drawing.Size(75, 23);
            this.btnGrabarRC.TabIndex = 16;
            this.btnGrabarRC.Text = "Grabar";
            this.btnGrabarRC.UseVisualStyleBackColor = true;
            this.btnGrabarRC.Click += new System.EventHandler(this.btnGrabarRC_Click);
            // 
            // lblfechaCompra
            // 
            this.lblfechaCompra.AutoSize = true;
            this.lblfechaCompra.Location = new System.Drawing.Point(101, 36);
            this.lblfechaCompra.Name = "lblfechaCompra";
            this.lblfechaCompra.Size = new System.Drawing.Size(0, 13);
            this.lblfechaCompra.TabIndex = 17;
            // 
            // dtpVenta
            // 
            this.dtpVenta.Location = new System.Drawing.Point(377, 25);
            this.dtpVenta.Name = "dtpVenta";
            this.dtpVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpVenta.TabIndex = 18;
            this.dtpVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpVenta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha Acordada";
            // 
            // lblFolioVenta
            // 
            this.lblFolioVenta.AutoSize = true;
            this.lblFolioVenta.Location = new System.Drawing.Point(101, 9);
            this.lblFolioVenta.Name = "lblFolioVenta";
            this.lblFolioVenta.Size = new System.Drawing.Size(0, 13);
            this.lblFolioVenta.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Retraso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dias";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.txtNombreProveedorRC);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtIdProveedorRC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(267, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 109);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // txtNombreProveedorRC
            // 
            this.txtNombreProveedorRC.Location = new System.Drawing.Point(51, 75);
            this.txtNombreProveedorRC.Name = "txtNombreProveedorRC";
            this.txtNombreProveedorRC.ReadOnly = true;
            this.txtNombreProveedorRC.Size = new System.Drawing.Size(232, 20);
            this.txtNombreProveedorRC.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txtRetrasoRC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPuntosCompra);
            this.groupBox2.Location = new System.Drawing.Point(48, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Se Asignan:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Producto";
            // 
            // txtProductoRC
            // 
            this.txtProductoRC.Location = new System.Drawing.Point(94, 48);
            this.txtProductoRC.Name = "txtProductoRC";
            this.txtProductoRC.ReadOnly = true;
            this.txtProductoRC.Size = new System.Drawing.Size(100, 20);
            this.txtProductoRC.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Costo";
            // 
            // txtCostoRC
            // 
            this.txtCostoRC.Location = new System.Drawing.Point(94, 79);
            this.txtCostoRC.Name = "txtCostoRC";
            this.txtCostoRC.ReadOnly = true;
            this.txtCostoRC.Size = new System.Drawing.Size(100, 20);
            this.txtCostoRC.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cantidad";
            // 
            // txtCantidadRC
            // 
            this.txtCantidadRC.Location = new System.Drawing.Point(94, 113);
            this.txtCantidadRC.Name = "txtCantidadRC";
            this.txtCantidadRC.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadRC.TabIndex = 30;
            this.txtCantidadRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadRC_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.txtIdProductoRC);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtCantidadRC);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtProductoRC);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtCostoRC);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(583, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 150);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar y Agregar";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtSubtotalRC);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtIvaRC);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(603, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 124);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Totales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Subtotal";
            // 
            // txtSubtotalRC
            // 
            this.txtSubtotalRC.Location = new System.Drawing.Point(76, 28);
            this.txtSubtotalRC.Name = "txtSubtotalRC";
            this.txtSubtotalRC.ReadOnly = true;
            this.txtSubtotalRC.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalRC.TabIndex = 14;
            // 
            // btnRegresarRC
            // 
            this.btnRegresarRC.Location = new System.Drawing.Point(645, 176);
            this.btnRegresarRC.Name = "btnRegresarRC";
            this.btnRegresarRC.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarRC.TabIndex = 33;
            this.btnRegresarRC.Text = "Regresar";
            this.btnRegresarRC.UseVisualStyleBackColor = true;
            this.btnRegresarRC.Click += new System.EventHandler(this.btnRegresarRC_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(291, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "De enter para calcular los puntos";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox5.Controls.Add(this.pboxRegistraCompra);
            this.groupBox5.Location = new System.Drawing.Point(837, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 192);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Imagen";
            // 
            // pboxRegistraCompra
            // 
            this.pboxRegistraCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxRegistraCompra.Location = new System.Drawing.Point(28, 27);
            this.pboxRegistraCompra.Name = "pboxRegistraCompra";
            this.pboxRegistraCompra.Size = new System.Drawing.Size(128, 141);
            this.pboxRegistraCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRegistraCompra.TabIndex = 34;
            this.pboxRegistraCompra.TabStop = false;
            // 
            // RegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1035, 408);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnRegresarRC);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFolioVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpVenta);
            this.Controls.Add(this.lblfechaCompra);
            this.Controls.Add(this.btnGrabarRC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRCompra);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarCompra";
            this.Text = "Registrar Compra";
            this.Load += new System.EventHandler(this.RegistrarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxRegistraCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProductoRC;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvRCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetrasoRC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProveedorRC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIvaRC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPuntosCompra;
        private System.Windows.Forms.Button btnGrabarRC;
        private System.Windows.Forms.Label lblfechaCompra;
        private System.Windows.Forms.DateTimePicker dtpVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFolioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreProveedorRC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProductoRC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCostoRC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCantidadRC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSubtotalRC;
        private System.Windows.Forms.Button btnRegresarRC;
        private System.Windows.Forms.PictureBox pboxRegistraCompra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}