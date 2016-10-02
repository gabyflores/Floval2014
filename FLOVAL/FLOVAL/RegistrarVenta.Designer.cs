namespace WindowsFormsApplication1
{
    partial class RegistrarVenta
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRV = new System.Windows.Forms.DataGridView();
            this.txtTotalRV = new System.Windows.Forms.TextBox();
            this.txtIdProductoRV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoRV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClienteRV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIVARV = new System.Windows.Forms.TextBox();
            this.txtDescRV = new System.Windows.Forms.TextBox();
            this.btnGrabarVenta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductoRV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidadRV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioRV = new System.Windows.Forms.TextBox();
            this.lblFolioVenta = new System.Windows.Forms.Label();
            this.lblfechaRV = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSubtotalRV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidadPiezasRV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPorcDescRV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescuentoRV = new System.Windows.Forms.TextBox();
            this.gbTRV = new System.Windows.Forms.GroupBox();
            this.gb2RV = new System.Windows.Forms.GroupBox();
            this.txtNombreClienteRV = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegresarRV = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pbRV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRV)).BeginInit();
            this.gbTRV.SuspendLayout();
            this.gb2RV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRV)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha";
            // 
            // dgvRV
            // 
            this.dgvRV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRV.Location = new System.Drawing.Point(20, 26);
            this.dgvRV.Name = "dgvRV";
            this.dgvRV.ReadOnly = true;
            this.dgvRV.Size = new System.Drawing.Size(522, 174);
            this.dgvRV.TabIndex = 14;
            // 
            // txtTotalRV
            // 
            this.txtTotalRV.Location = new System.Drawing.Point(137, 107);
            this.txtTotalRV.Name = "txtTotalRV";
            this.txtTotalRV.ReadOnly = true;
            this.txtTotalRV.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRV.TabIndex = 13;
            // 
            // txtIdProductoRV
            // 
            this.txtIdProductoRV.Location = new System.Drawing.Point(104, 19);
            this.txtIdProductoRV.Name = "txtIdProductoRV";
            this.txtIdProductoRV.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoRV.TabIndex = 12;
            this.txtIdProductoRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProductoRV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo";
            // 
            // txtTipoRV
            // 
            this.txtTipoRV.Location = new System.Drawing.Point(151, 62);
            this.txtTipoRV.Name = "txtTipoRV";
            this.txtTipoRV.ReadOnly = true;
            this.txtTipoRV.Size = new System.Drawing.Size(100, 20);
            this.txtTipoRV.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "IVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Id Cliente";
            // 
            // txtClienteRV
            // 
            this.txtClienteRV.Location = new System.Drawing.Point(151, 88);
            this.txtClienteRV.Name = "txtClienteRV";
            this.txtClienteRV.Size = new System.Drawing.Size(100, 20);
            this.txtClienteRV.TabIndex = 0;
            this.txtClienteRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteRV_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cantidad con Descuento";
            // 
            // txtIVARV
            // 
            this.txtIVARV.Location = new System.Drawing.Point(137, 81);
            this.txtIVARV.Name = "txtIVARV";
            this.txtIVARV.ReadOnly = true;
            this.txtIVARV.Size = new System.Drawing.Size(100, 20);
            this.txtIVARV.TabIndex = 23;
            // 
            // txtDescRV
            // 
            this.txtDescRV.Location = new System.Drawing.Point(137, 51);
            this.txtDescRV.Name = "txtDescRV";
            this.txtDescRV.ReadOnly = true;
            this.txtDescRV.Size = new System.Drawing.Size(100, 20);
            this.txtDescRV.TabIndex = 24;
            // 
            // btnGrabarVenta
            // 
            this.btnGrabarVenta.Location = new System.Drawing.Point(605, 176);
            this.btnGrabarVenta.Name = "btnGrabarVenta";
            this.btnGrabarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnGrabarVenta.TabIndex = 25;
            this.btnGrabarVenta.Text = "Grabar";
            this.btnGrabarVenta.UseVisualStyleBackColor = true;
            this.btnGrabarVenta.Click += new System.EventHandler(this.btnGrabarVenta_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Producto";
            // 
            // txtProductoRV
            // 
            this.txtProductoRV.Location = new System.Drawing.Point(105, 49);
            this.txtProductoRV.Name = "txtProductoRV";
            this.txtProductoRV.ReadOnly = true;
            this.txtProductoRV.Size = new System.Drawing.Size(100, 20);
            this.txtProductoRV.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Cantidad";
            // 
            // txtCantidadRV
            // 
            this.txtCantidadRV.Location = new System.Drawing.Point(104, 104);
            this.txtCantidadRV.Name = "txtCantidadRV";
            this.txtCantidadRV.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadRV.TabIndex = 29;
            this.txtCantidadRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadRV_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Precio";
            // 
            // txtPrecioRV
            // 
            this.txtPrecioRV.Location = new System.Drawing.Point(105, 78);
            this.txtPrecioRV.Name = "txtPrecioRV";
            this.txtPrecioRV.ReadOnly = true;
            this.txtPrecioRV.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioRV.TabIndex = 31;
            // 
            // lblFolioVenta
            // 
            this.lblFolioVenta.AutoSize = true;
            this.lblFolioVenta.Location = new System.Drawing.Point(148, 9);
            this.lblFolioVenta.Name = "lblFolioVenta";
            this.lblFolioVenta.Size = new System.Drawing.Size(13, 13);
            this.lblFolioVenta.TabIndex = 32;
            this.lblFolioVenta.Text = "0";
            // 
            // lblfechaRV
            // 
            this.lblfechaRV.AutoSize = true;
            this.lblfechaRV.Location = new System.Drawing.Point(148, 36);
            this.lblfechaRV.Name = "lblfechaRV";
            this.lblfechaRV.Size = new System.Drawing.Size(0, 13);
            this.lblfechaRV.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "SubTotal";
            // 
            // txtSubtotalRV
            // 
            this.txtSubtotalRV.Location = new System.Drawing.Point(137, 19);
            this.txtSubtotalRV.Name = "txtSubtotalRV";
            this.txtSubtotalRV.ReadOnly = true;
            this.txtSubtotalRV.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalRV.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Cantidad Piezas";
            // 
            // txtCantidadPiezasRV
            // 
            this.txtCantidadPiezasRV.Location = new System.Drawing.Point(102, 206);
            this.txtCantidadPiezasRV.Name = "txtCantidadPiezasRV";
            this.txtCantidadPiezasRV.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadPiezasRV.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(375, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "%";
            // 
            // txtPorcDescRV
            // 
            this.txtPorcDescRV.Location = new System.Drawing.Point(272, 55);
            this.txtPorcDescRV.Name = "txtPorcDescRV";
            this.txtPorcDescRV.ReadOnly = true;
            this.txtPorcDescRV.Size = new System.Drawing.Size(100, 20);
            this.txtPorcDescRV.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(269, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Porcentaje";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(269, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Descuento";
            // 
            // txtDescuentoRV
            // 
            this.txtDescuentoRV.Location = new System.Drawing.Point(272, 102);
            this.txtDescuentoRV.Name = "txtDescuentoRV";
            this.txtDescuentoRV.ReadOnly = true;
            this.txtDescuentoRV.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoRV.TabIndex = 42;
            // 
            // gbTRV
            // 
            this.gbTRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbTRV.Controls.Add(this.txtTotalRV);
            this.gbTRV.Controls.Add(this.label15);
            this.gbTRV.Controls.Add(this.label16);
            this.gbTRV.Controls.Add(this.label12);
            this.gbTRV.Controls.Add(this.txtSubtotalRV);
            this.gbTRV.Controls.Add(this.label14);
            this.gbTRV.Controls.Add(this.txtPorcDescRV);
            this.gbTRV.Controls.Add(this.txtDescuentoRV);
            this.gbTRV.Controls.Add(this.label3);
            this.gbTRV.Controls.Add(this.txtIVARV);
            this.gbTRV.Controls.Add(this.label6);
            this.gbTRV.Controls.Add(this.txtDescRV);
            this.gbTRV.Controls.Add(this.label8);
            this.gbTRV.Location = new System.Drawing.Point(605, 217);
            this.gbTRV.Name = "gbTRV";
            this.gbTRV.Size = new System.Drawing.Size(396, 163);
            this.gbTRV.TabIndex = 43;
            this.gbTRV.TabStop = false;
            this.gbTRV.Text = "Totales";
            // 
            // gb2RV
            // 
            this.gb2RV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gb2RV.Controls.Add(this.dgvRV);
            this.gb2RV.Controls.Add(this.txtCantidadPiezasRV);
            this.gb2RV.Controls.Add(this.label13);
            this.gb2RV.Location = new System.Drawing.Point(12, 165);
            this.gb2RV.Name = "gb2RV";
            this.gb2RV.Size = new System.Drawing.Size(564, 236);
            this.gb2RV.TabIndex = 44;
            this.gb2RV.TabStop = false;
            this.gb2RV.Text = "Detalle";
            // 
            // txtNombreClienteRV
            // 
            this.txtNombreClienteRV.Location = new System.Drawing.Point(151, 129);
            this.txtNombreClienteRV.Name = "txtNombreClienteRV";
            this.txtNombreClienteRV.ReadOnly = true;
            this.txtNombreClienteRV.Size = new System.Drawing.Size(303, 20);
            this.txtNombreClienteRV.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(66, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Nombre Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtIdProductoRV);
            this.groupBox1.Controls.Add(this.txtProductoRV);
            this.groupBox1.Controls.Add(this.txtPrecioRV);
            this.groupBox1.Controls.Add(this.txtCantidadRV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(605, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 145);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // btnRegresarRV
            // 
            this.btnRegresarRV.Location = new System.Drawing.Point(706, 176);
            this.btnRegresarRV.Name = "btnRegresarRV";
            this.btnRegresarRV.Size = new System.Drawing.Size(75, 20);
            this.btnRegresarRV.TabIndex = 49;
            this.btnRegresarRV.Text = "Regresar";
            this.btnRegresarRV.UseVisualStyleBackColor = true;
            this.btnRegresarRV.Click += new System.EventHandler(this.btnRegresarRV_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(66, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "Presione enter para verificar al Cliente";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(611, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(260, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "Presione enter para verificar el Producto y la Cantidad";
            // 
            // pbRV
            // 
            this.pbRV.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.pbRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRV.Location = new System.Drawing.Point(877, 12);
            this.pbRV.Name = "pbRV";
            this.pbRV.Size = new System.Drawing.Size(119, 142);
            this.pbRV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRV.TabIndex = 48;
            this.pbRV.TabStop = false;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1022, 425);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnRegresarRV);
            this.Controls.Add(this.pbRV);
            this.Controls.Add(this.lblFolioVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreClienteRV);
            this.Controls.Add(this.gb2RV);
            this.Controls.Add(this.gbTRV);
            this.Controls.Add(this.lblfechaRV);
            this.Controls.Add(this.btnGrabarVenta);
            this.Controls.Add(this.txtClienteRV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipoRV);
            this.Controls.Add(this.label5);
            this.Name = "RegistrarVenta";
            this.Text = "RegistrarVenta";
            this.Load += new System.EventHandler(this.RegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRV)).EndInit();
            this.gbTRV.ResumeLayout(false);
            this.gbTRV.PerformLayout();
            this.gb2RV.ResumeLayout(false);
            this.gb2RV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRV;
        private System.Windows.Forms.TextBox txtTotalRV;
        private System.Windows.Forms.TextBox txtIdProductoRV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoRV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClienteRV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIVARV;
        private System.Windows.Forms.TextBox txtDescRV;
        private System.Windows.Forms.Button btnGrabarVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductoRV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidadRV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioRV;
        private System.Windows.Forms.Label lblFolioVenta;
        private System.Windows.Forms.Label lblfechaRV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSubtotalRV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidadPiezasRV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPorcDescRV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescuentoRV;
        private System.Windows.Forms.GroupBox gbTRV;
        private System.Windows.Forms.GroupBox gb2RV;
        private System.Windows.Forms.TextBox txtNombreClienteRV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbRV;
        private System.Windows.Forms.Button btnRegresarRV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}