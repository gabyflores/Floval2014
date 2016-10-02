namespace WindowsFormsApplication1
{
    partial class RegistrarCambio
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
            this.dgvRC = new System.Windows.Forms.DataGridView();
            this.txtTotalRC = new System.Windows.Forms.TextBox();
            this.txtIdProductoRC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolioCambio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadRC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalRPC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductoRC = new System.Windows.Forms.TextBox();
            this.txtPrecioRC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFolioVentaRC = new System.Windows.Forms.TextBox();
            this.lblfechaRC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.dgvRPC = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdProductoRPC = new System.Windows.Forms.TextBox();
            this.txtProductoRPC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioRPC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCantidadRPC = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCantidadpiezasRCh = new System.Windows.Forms.TextBox();
            this.txtCantidadpiezasRCh1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRegresarRC = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFechaVentaRC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRPC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRC
            // 
            this.dgvRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRC.Location = new System.Drawing.Point(23, 19);
            this.dgvRC.Name = "dgvRC";
            this.dgvRC.ReadOnly = true;
            this.dgvRC.Size = new System.Drawing.Size(401, 168);
            this.dgvRC.TabIndex = 14;
            // 
            // txtTotalRC
            // 
            this.txtTotalRC.Location = new System.Drawing.Point(265, 410);
            this.txtTotalRC.Name = "txtTotalRC";
            this.txtTotalRC.ReadOnly = true;
            this.txtTotalRC.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRC.TabIndex = 13;
            // 
            // txtIdProductoRC
            // 
            this.txtIdProductoRC.Location = new System.Drawing.Point(69, 20);
            this.txtIdProductoRC.Name = "txtIdProductoRC";
            this.txtIdProductoRC.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoRC.TabIndex = 12;
            this.txtIdProductoRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProductoRC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folio";
            // 
            // lblFolioCambio
            // 
            this.lblFolioCambio.AutoSize = true;
            this.lblFolioCambio.Location = new System.Drawing.Point(66, 9);
            this.lblFolioCambio.Name = "lblFolioCambio";
            this.lblFolioCambio.Size = new System.Drawing.Size(13, 13);
            this.lblFolioCambio.TabIndex = 16;
            this.lblFolioCambio.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad";
            // 
            // txtCantidadRC
            // 
            this.txtCantidadRC.Location = new System.Drawing.Point(69, 129);
            this.txtCantidadRC.Name = "txtCantidadRC";
            this.txtCantidadRC.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadRC.TabIndex = 18;
            this.txtCantidadRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadRC_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Motivo";
            // 
            // txtTotalRPC
            // 
            this.txtTotalRPC.Location = new System.Drawing.Point(757, 410);
            this.txtTotalRPC.Name = "txtTotalRPC";
            this.txtTotalRPC.ReadOnly = true;
            this.txtTotalRPC.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRPC.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Precio";
            // 
            // txtProductoRC
            // 
            this.txtProductoRC.Location = new System.Drawing.Point(69, 46);
            this.txtProductoRC.Name = "txtProductoRC";
            this.txtProductoRC.ReadOnly = true;
            this.txtProductoRC.Size = new System.Drawing.Size(100, 20);
            this.txtProductoRC.TabIndex = 23;
            // 
            // txtPrecioRC
            // 
            this.txtPrecioRC.Location = new System.Drawing.Point(69, 74);
            this.txtPrecioRC.Name = "txtPrecioRC";
            this.txtPrecioRC.ReadOnly = true;
            this.txtPrecioRC.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioRC.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha";
            // 
            // txtFolioVentaRC
            // 
            this.txtFolioVentaRC.Location = new System.Drawing.Point(85, 67);
            this.txtFolioVentaRC.Name = "txtFolioVentaRC";
            this.txtFolioVentaRC.Size = new System.Drawing.Size(100, 20);
            this.txtFolioVentaRC.TabIndex = 26;
            this.txtFolioVentaRC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioVentaRC_KeyPress);
            // 
            // lblfechaRC
            // 
            this.lblfechaRC.AutoSize = true;
            this.lblfechaRC.Location = new System.Drawing.Point(73, 37);
            this.lblfechaRC.Name = "lblfechaRC";
            this.lblfechaRC.Size = new System.Drawing.Size(0, 13);
            this.lblfechaRC.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Folio Venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 29;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Items.AddRange(new object[] {
            "",
            "Desagrado del Modelo",
            "Desagrado del Color",
            "Defecto"});
            this.cmbMotivo.Location = new System.Drawing.Point(69, 102);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(100, 21);
            this.cmbMotivo.TabIndex = 31;
            // 
            // dgvRPC
            // 
            this.dgvRPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRPC.Location = new System.Drawing.Point(21, 27);
            this.dgvRPC.Name = "dgvRPC";
            this.dgvRPC.ReadOnly = true;
            this.dgvRPC.Size = new System.Drawing.Size(363, 160);
            this.dgvRPC.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtCantidadRC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIdProductoRC);
            this.groupBox2.Controls.Add(this.cmbMotivo);
            this.groupBox2.Controls.Add(this.txtProductoRC);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrecioRC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(319, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 161);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regresa";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtIdProductoRPC);
            this.groupBox3.Controls.Add(this.txtProductoRPC);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPrecioRPC);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtCantidadRPC);
            this.groupBox3.Location = new System.Drawing.Point(610, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 152);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lleva";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Id Producto";
            // 
            // txtIdProductoRPC
            // 
            this.txtIdProductoRPC.Location = new System.Drawing.Point(69, 20);
            this.txtIdProductoRPC.Name = "txtIdProductoRPC";
            this.txtIdProductoRPC.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoRPC.TabIndex = 12;
            this.txtIdProductoRPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProductoRPC_KeyPress);
            // 
            // txtProductoRPC
            // 
            this.txtProductoRPC.Location = new System.Drawing.Point(69, 46);
            this.txtProductoRPC.Name = "txtProductoRPC";
            this.txtProductoRPC.ReadOnly = true;
            this.txtProductoRPC.Size = new System.Drawing.Size(100, 20);
            this.txtProductoRPC.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Producto";
            // 
            // txtPrecioRPC
            // 
            this.txtPrecioRPC.Location = new System.Drawing.Point(69, 74);
            this.txtPrecioRPC.Name = "txtPrecioRPC";
            this.txtPrecioRPC.ReadOnly = true;
            this.txtPrecioRPC.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioRPC.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Precio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Cantidad";
            // 
            // txtCantidadRPC
            // 
            this.txtCantidadRPC.Location = new System.Drawing.Point(69, 100);
            this.txtCantidadRPC.Name = "txtCantidadRPC";
            this.txtCantidadRPC.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadRPC.TabIndex = 18;
            this.txtCantidadRPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadRPC_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(710, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 394);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Cantidad de Piezas";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(878, 394);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Cantidad de Piezas";
            // 
            // txtCantidadpiezasRCh
            // 
            this.txtCantidadpiezasRCh.Location = new System.Drawing.Point(117, 410);
            this.txtCantidadpiezasRCh.Name = "txtCantidadpiezasRCh";
            this.txtCantidadpiezasRCh.ReadOnly = true;
            this.txtCantidadpiezasRCh.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadpiezasRCh.TabIndex = 38;
            // 
            // txtCantidadpiezasRCh1
            // 
            this.txtCantidadpiezasRCh1.Location = new System.Drawing.Point(881, 410);
            this.txtCantidadpiezasRCh1.Name = "txtCantidadpiezasRCh1";
            this.txtCantidadpiezasRCh1.ReadOnly = true;
            this.txtCantidadpiezasRCh1.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadpiezasRCh1.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(538, 394);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Diferencia";
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.Location = new System.Drawing.Point(515, 410);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.ReadOnly = true;
            this.txtDiferencia.Size = new System.Drawing.Size(100, 20);
            this.txtDiferencia.TabIndex = 1;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(827, 12);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 40;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dgvRPC);
            this.groupBox1.Location = new System.Drawing.Point(610, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 207);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lleva";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.dgvRC);
            this.groupBox4.Location = new System.Drawing.Point(69, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 203);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Regresa";
            // 
            // btnRegresarRC
            // 
            this.btnRegresarRC.Location = new System.Drawing.Point(919, 12);
            this.btnRegresarRC.Name = "btnRegresarRC";
            this.btnRegresarRC.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarRC.TabIndex = 43;
            this.btnRegresarRC.Text = "Regresar";
            this.btnRegresarRC.UseVisualStyleBackColor = true;
            this.btnRegresarRC.Click += new System.EventHandler(this.btnRegresarRC_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Fecha Venta";
            // 
            // txtFechaVentaRC
            // 
            this.txtFechaVentaRC.Location = new System.Drawing.Point(92, 109);
            this.txtFechaVentaRC.Name = "txtFechaVentaRC";
            this.txtFechaVentaRC.ReadOnly = true;
            this.txtFechaVentaRC.Size = new System.Drawing.Size(208, 20);
            this.txtFechaVentaRC.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Presione enter para Validar la Venta";
            // 
            // RegistrarCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1067, 461);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtFechaVentaRC);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnRegresarRC);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDiferencia);
            this.Controls.Add(this.txtCantidadpiezasRCh1);
            this.Controls.Add(this.txtCantidadpiezasRCh);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalRC);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTotalRPC);
            this.Controls.Add(this.txtFolioVentaRC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblfechaRC);
            this.Controls.Add(this.lblFolioCambio);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarCambio";
            this.Text = "RegistrarCambio";
            this.Load += new System.EventHandler(this.RegistrarCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRPC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRC;
        private System.Windows.Forms.TextBox txtTotalRC;
        private System.Windows.Forms.TextBox txtIdProductoRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFolioCambio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalRPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductoRC;
        private System.Windows.Forms.TextBox txtPrecioRC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFolioVentaRC;
        private System.Windows.Forms.Label lblfechaRC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.DataGridView dgvRPC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdProductoRPC;
        private System.Windows.Forms.TextBox txtProductoRPC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioRPC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCantidadRPC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCantidadpiezasRCh;
        private System.Windows.Forms.TextBox txtCantidadpiezasRCh1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDiferencia;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRegresarRC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFechaVentaRC;
        private System.Windows.Forms.Label label20;
    }
}