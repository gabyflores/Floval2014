namespace WindowsFormsApplication1
{
    partial class BuscarVenta
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
            this.dgvBuscaDVenta = new System.Windows.Forms.DataGridView();
            this.folioVentaBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIvaBusca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteIdBus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescuentoBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtNombreClienteBusca = new System.Windows.Forms.TextBox();
            this.lblFechaVentaBusca = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipoVentaBusca = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolioVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubBVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescuentoAplicadoBusca = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.IvaAplicadoB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalBuscaVenta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMedioCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.txtCiudadCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtRFCCliente = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRegresarBV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaDVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaDVenta
            // 
            this.dgvBuscaDVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvBuscaDVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaDVenta.Location = new System.Drawing.Point(433, 22);
            this.dgvBuscaDVenta.Name = "dgvBuscaDVenta";
            this.dgvBuscaDVenta.ReadOnly = true;
            this.dgvBuscaDVenta.Size = new System.Drawing.Size(394, 328);
            this.dgvBuscaDVenta.TabIndex = 0;
            // 
            // folioVentaBusca
            // 
            this.folioVentaBusca.Location = new System.Drawing.Point(87, 23);
            this.folioVentaBusca.Name = "folioVentaBusca";
            this.folioVentaBusca.Size = new System.Drawing.Size(100, 20);
            this.folioVentaBusca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folio Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Venta";
            // 
            // txtIvaBusca
            // 
            this.txtIvaBusca.Location = new System.Drawing.Point(245, 24);
            this.txtIvaBusca.Name = "txtIvaBusca";
            this.txtIvaBusca.ReadOnly = true;
            this.txtIvaBusca.Size = new System.Drawing.Size(100, 20);
            this.txtIvaBusca.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // txtClienteIdBus
            // 
            this.txtClienteIdBus.Location = new System.Drawing.Point(85, 27);
            this.txtClienteIdBus.Name = "txtClienteIdBus";
            this.txtClienteIdBus.ReadOnly = true;
            this.txtClienteIdBus.Size = new System.Drawing.Size(142, 20);
            this.txtClienteIdBus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descuento";
            // 
            // txtDescuentoBusca
            // 
            this.txtDescuentoBusca.Location = new System.Drawing.Point(73, 59);
            this.txtDescuentoBusca.Name = "txtDescuentoBusca";
            this.txtDescuentoBusca.ReadOnly = true;
            this.txtDescuentoBusca.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoBusca.TabIndex = 10;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(309, 22);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVenta.TabIndex = 13;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(24, 67);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(44, 13);
            this.lbl7.TabIndex = 14;
            this.lbl7.Text = "Nombre";
            // 
            // txtNombreClienteBusca
            // 
            this.txtNombreClienteBusca.Location = new System.Drawing.Point(85, 60);
            this.txtNombreClienteBusca.Name = "txtNombreClienteBusca";
            this.txtNombreClienteBusca.ReadOnly = true;
            this.txtNombreClienteBusca.Size = new System.Drawing.Size(142, 20);
            this.txtNombreClienteBusca.TabIndex = 15;
            // 
            // lblFechaVentaBusca
            // 
            this.lblFechaVentaBusca.AutoSize = true;
            this.lblFechaVentaBusca.Location = new System.Drawing.Point(87, 79);
            this.lblFechaVentaBusca.Name = "lblFechaVentaBusca";
            this.lblFechaVentaBusca.Size = new System.Drawing.Size(13, 13);
            this.lblFechaVentaBusca.TabIndex = 16;
            this.lblFechaVentaBusca.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo";
            // 
            // lblTipoVentaBusca
            // 
            this.lblTipoVentaBusca.AutoSize = true;
            this.lblTipoVentaBusca.Location = new System.Drawing.Point(87, 107);
            this.lblTipoVentaBusca.Name = "lblTipoVentaBusca";
            this.lblTipoVentaBusca.Size = new System.Drawing.Size(13, 13);
            this.lblTipoVentaBusca.TabIndex = 18;
            this.lblTipoVentaBusca.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Folio";
            // 
            // txtFolioVenta
            // 
            this.txtFolioVenta.Location = new System.Drawing.Point(87, 53);
            this.txtFolioVenta.Name = "txtFolioVenta";
            this.txtFolioVenta.ReadOnly = true;
            this.txtFolioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtFolioVenta.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Subtotal";
            // 
            // txtSubBVenta
            // 
            this.txtSubBVenta.Location = new System.Drawing.Point(73, 27);
            this.txtSubBVenta.Name = "txtSubBVenta";
            this.txtSubBVenta.ReadOnly = true;
            this.txtSubBVenta.Size = new System.Drawing.Size(100, 20);
            this.txtSubBVenta.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Descuento Aplicado";
            // 
            // txtDescuentoAplicadoBusca
            // 
            this.txtDescuentoAplicadoBusca.Location = new System.Drawing.Point(73, 103);
            this.txtDescuentoAplicadoBusca.Name = "txtDescuentoAplicadoBusca";
            this.txtDescuentoAplicadoBusca.ReadOnly = true;
            this.txtDescuentoAplicadoBusca.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoAplicadoBusca.TabIndex = 25;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(179, 62);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(66, 13);
            this.l.TabIndex = 26;
            this.l.Text = "Iva Aplicado";
            // 
            // IvaAplicadoB
            // 
            this.IvaAplicadoB.Location = new System.Drawing.Point(245, 56);
            this.IvaAplicadoB.Name = "IvaAplicadoB";
            this.IvaAplicadoB.ReadOnly = true;
            this.IvaAplicadoB.Size = new System.Drawing.Size(100, 20);
            this.IvaAplicadoB.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total";
            // 
            // txtTotalBuscaVenta
            // 
            this.txtTotalBuscaVenta.Location = new System.Drawing.Point(245, 100);
            this.txtTotalBuscaVenta.Name = "txtTotalBuscaVenta";
            this.txtTotalBuscaVenta.ReadOnly = true;
            this.txtTotalBuscaVenta.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBuscaVenta.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.folioVentaBusca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFolioVenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFechaVentaBusca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTipoVentaBusca);
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 159);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta Buscada";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtMedioCliente);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtEstadoCliente);
            this.groupBox2.Controls.Add(this.txtCiudadCliente);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCorreoCliente);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCelularCliente);
            this.groupBox2.Controls.Add(this.txtTelefonoCliente);
            this.groupBox2.Controls.Add(this.txtRFCCliente);
            this.groupBox2.Controls.Add(this.txtClienteIdBus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNombreClienteBusca);
            this.groupBox2.Controls.Add(this.lbl7);
            this.groupBox2.Location = new System.Drawing.Point(854, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 325);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Medio de Contacto";
            // 
            // txtMedioCliente
            // 
            this.txtMedioCliente.Location = new System.Drawing.Point(88, 294);
            this.txtMedioCliente.Name = "txtMedioCliente";
            this.txtMedioCliente.ReadOnly = true;
            this.txtMedioCliente.Size = new System.Drawing.Size(139, 20);
            this.txtMedioCliente.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Ciudad";
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(85, 249);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.ReadOnly = true;
            this.txtEstadoCliente.Size = new System.Drawing.Size(142, 20);
            this.txtEstadoCliente.TabIndex = 25;
            // 
            // txtCiudadCliente
            // 
            this.txtCiudadCliente.Location = new System.Drawing.Point(85, 218);
            this.txtCiudadCliente.Name = "txtCiudadCliente";
            this.txtCiudadCliente.ReadOnly = true;
            this.txtCiudadCliente.Size = new System.Drawing.Size(142, 20);
            this.txtCiudadCliente.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Correo";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(85, 188);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(142, 20);
            this.txtCorreoCliente.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Celular";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "RFC";
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Location = new System.Drawing.Point(85, 159);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.ReadOnly = true;
            this.txtCelularCliente.Size = new System.Drawing.Size(142, 20);
            this.txtCelularCliente.TabIndex = 18;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(85, 128);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(142, 20);
            this.txtTelefonoCliente.TabIndex = 17;
            // 
            // txtRFCCliente
            // 
            this.txtRFCCliente.Location = new System.Drawing.Point(85, 94);
            this.txtRFCCliente.Name = "txtRFCCliente";
            this.txtRFCCliente.ReadOnly = true;
            this.txtRFCCliente.Size = new System.Drawing.Size(142, 20);
            this.txtRFCCliente.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.txtSubBVenta);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDescuentoBusca);
            this.groupBox3.Controls.Add(this.txtTotalBuscaVenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDescuentoAplicadoBusca);
            this.groupBox3.Controls.Add(this.l);
            this.groupBox3.Controls.Add(this.IvaAplicadoB);
            this.groupBox3.Controls.Add(this.txtIvaBusca);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(27, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 131);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // btnRegresarBV
            // 
            this.btnRegresarBV.Location = new System.Drawing.Point(309, 66);
            this.btnRegresarBV.Name = "btnRegresarBV";
            this.btnRegresarBV.Size = new System.Drawing.Size(75, 22);
            this.btnRegresarBV.TabIndex = 33;
            this.btnRegresarBV.Text = "Regresar";
            this.btnRegresarBV.UseVisualStyleBackColor = true;
            this.btnRegresarBV.Click += new System.EventHandler(this.btnRegresarBV_Click);
            // 
            // BuscarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1114, 384);
            this.Controls.Add(this.btnRegresarBV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvBuscaDVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarVenta);
            this.Name = "BuscarVenta";
            this.Text = "BuscarVenta";
            this.Load += new System.EventHandler(this.BuscarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaDVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaDVenta;
        private System.Windows.Forms.TextBox folioVentaBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIvaBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteIdBus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescuentoBusca;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox txtNombreClienteBusca;
        private System.Windows.Forms.Label lblFechaVentaBusca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipoVentaBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolioVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubBVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescuentoAplicadoBusca;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox IvaAplicadoB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalBuscaVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMedioCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.TextBox txtCiudadCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtRFCCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRegresarBV;
    }
}