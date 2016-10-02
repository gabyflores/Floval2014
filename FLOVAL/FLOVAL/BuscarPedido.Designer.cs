namespace WindowsFormsApplication1
{
    partial class BuscarPedido
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbk = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMedioCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.txtCiudadCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtRFCCliente = new System.Windows.Forms.TextBox();
            this.txtClienteIdBus = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNombreClienteBusca = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFolioPedidoBusca = new System.Windows.Forms.TextBox();
            this.lblFechaPedidoBusca = new System.Windows.Forms.Label();
            this.lblTipoPedidoBusca = new System.Windows.Forms.Label();
            this.lblFolioBuscaPedido = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSubBVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuentoBusca = new System.Windows.Forms.TextBox();
            this.txtTotalBuscaVenta = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtDescuentoAplicadoBusca = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.IvaAplicadoB = new System.Windows.Forms.TextBox();
            this.txtIvaBusca = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFechaEntregado = new System.Windows.Forms.TextBox();
            this.txtFechaSurtido = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.dtpEntregado = new System.Windows.Forms.DateTimePicker();
            this.dtpSurtido = new System.Windows.Forms.DateTimePicker();
            this.dtpPago = new System.Windows.Forms.DateTimePicker();
            this.cmbEntregado = new System.Windows.Forms.ComboBox();
            this.cmbSurtido = new System.Windows.Forms.ComboBox();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvBuscaCompra = new System.Windows.Forms.DataGridView();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.rbModificaEstado = new System.Windows.Forms.RadioButton();
            this.rbBuscarPedido = new System.Windows.Forms.RadioButton();
            this.btnModificarEstado = new System.Windows.Forms.Button();
            this.btnRegresarBuscaPedido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio a Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado de Pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado de Surtido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado de Entregado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fecha Surtido";
            // 
            // lbk
            // 
            this.lbk.AutoSize = true;
            this.lbk.Location = new System.Drawing.Point(228, 104);
            this.lbk.Name = "lbk";
            this.lbk.Size = new System.Drawing.Size(89, 13);
            this.lbk.TabIndex = 11;
            this.lbk.Text = "Fecha Entregado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Medio de Contacto";
            // 
            // txtMedioCliente
            // 
            this.txtMedioCliente.Location = new System.Drawing.Point(83, 294);
            this.txtMedioCliente.Name = "txtMedioCliente";
            this.txtMedioCliente.ReadOnly = true;
            this.txtMedioCliente.Size = new System.Drawing.Size(97, 20);
            this.txtMedioCliente.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Ciudad";
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(80, 249);
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.ReadOnly = true;
            this.txtEstadoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtEstadoCliente.TabIndex = 44;
            // 
            // txtCiudadCliente
            // 
            this.txtCiudadCliente.Location = new System.Drawing.Point(80, 218);
            this.txtCiudadCliente.Name = "txtCiudadCliente";
            this.txtCiudadCliente.ReadOnly = true;
            this.txtCiudadCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCiudadCliente.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Correo";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(80, 188);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoCliente.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Celular";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Telefono";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "RFC";
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Location = new System.Drawing.Point(80, 159);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.ReadOnly = true;
            this.txtCelularCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCelularCliente.TabIndex = 37;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(80, 128);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoCliente.TabIndex = 36;
            // 
            // txtRFCCliente
            // 
            this.txtRFCCliente.Location = new System.Drawing.Point(80, 94);
            this.txtRFCCliente.Name = "txtRFCCliente";
            this.txtRFCCliente.ReadOnly = true;
            this.txtRFCCliente.Size = new System.Drawing.Size(100, 20);
            this.txtRFCCliente.TabIndex = 35;
            // 
            // txtClienteIdBus
            // 
            this.txtClienteIdBus.Location = new System.Drawing.Point(80, 27);
            this.txtClienteIdBus.Name = "txtClienteIdBus";
            this.txtClienteIdBus.ReadOnly = true;
            this.txtClienteIdBus.Size = new System.Drawing.Size(100, 20);
            this.txtClienteIdBus.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Cliente";
            // 
            // txtNombreClienteBusca
            // 
            this.txtNombreClienteBusca.Location = new System.Drawing.Point(80, 60);
            this.txtNombreClienteBusca.Name = "txtNombreClienteBusca";
            this.txtNombreClienteBusca.ReadOnly = true;
            this.txtNombreClienteBusca.Size = new System.Drawing.Size(100, 20);
            this.txtNombreClienteBusca.TabIndex = 34;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(19, 67);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(44, 13);
            this.lbl7.TabIndex = 33;
            this.lbl7.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtFolioPedidoBusca);
            this.groupBox1.Controls.Add(this.lblFechaPedidoBusca);
            this.groupBox1.Controls.Add(this.lblTipoPedidoBusca);
            this.groupBox1.Controls.Add(this.lblFolioBuscaPedido);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 118);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido a Buscar";
            // 
            // txtFolioPedidoBusca
            // 
            this.txtFolioPedidoBusca.Location = new System.Drawing.Point(86, 19);
            this.txtFolioPedidoBusca.Name = "txtFolioPedidoBusca";
            this.txtFolioPedidoBusca.ReadOnly = true;
            this.txtFolioPedidoBusca.Size = new System.Drawing.Size(100, 20);
            this.txtFolioPedidoBusca.TabIndex = 55;
            // 
            // lblFechaPedidoBusca
            // 
            this.lblFechaPedidoBusca.AutoSize = true;
            this.lblFechaPedidoBusca.Location = new System.Drawing.Point(93, 93);
            this.lblFechaPedidoBusca.Name = "lblFechaPedidoBusca";
            this.lblFechaPedidoBusca.Size = new System.Drawing.Size(13, 13);
            this.lblFechaPedidoBusca.TabIndex = 55;
            this.lblFechaPedidoBusca.Text = "0";
            // 
            // lblTipoPedidoBusca
            // 
            this.lblTipoPedidoBusca.AutoSize = true;
            this.lblTipoPedidoBusca.Location = new System.Drawing.Point(93, 66);
            this.lblTipoPedidoBusca.Name = "lblTipoPedidoBusca";
            this.lblTipoPedidoBusca.Size = new System.Drawing.Size(13, 13);
            this.lblTipoPedidoBusca.TabIndex = 55;
            this.lblTipoPedidoBusca.Text = "0";
            // 
            // lblFolioBuscaPedido
            // 
            this.lblFolioBuscaPedido.AutoSize = true;
            this.lblFolioBuscaPedido.Location = new System.Drawing.Point(93, 42);
            this.lblFolioBuscaPedido.Name = "lblFolioBuscaPedido";
            this.lblFolioBuscaPedido.Size = new System.Drawing.Size(13, 13);
            this.lblFolioBuscaPedido.TabIndex = 55;
            this.lblFolioBuscaPedido.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Tipo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtSubBVenta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDescuentoBusca);
            this.groupBox2.Controls.Add(this.txtTotalBuscaVenta);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtDescuentoAplicadoBusca);
            this.groupBox2.Controls.Add(this.l);
            this.groupBox2.Controls.Add(this.IvaAplicadoB);
            this.groupBox2.Controls.Add(this.txtIvaBusca);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 175);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // txtSubBVenta
            // 
            this.txtSubBVenta.Location = new System.Drawing.Point(92, 38);
            this.txtSubBVenta.Name = "txtSubBVenta";
            this.txtSubBVenta.ReadOnly = true;
            this.txtSubBVenta.Size = new System.Drawing.Size(100, 20);
            this.txtSubBVenta.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Descuento";
            // 
            // txtDescuentoBusca
            // 
            this.txtDescuentoBusca.Location = new System.Drawing.Point(92, 73);
            this.txtDescuentoBusca.Name = "txtDescuentoBusca";
            this.txtDescuentoBusca.ReadOnly = true;
            this.txtDescuentoBusca.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoBusca.TabIndex = 32;
            // 
            // txtTotalBuscaVenta
            // 
            this.txtTotalBuscaVenta.Location = new System.Drawing.Point(264, 114);
            this.txtTotalBuscaVenta.Name = "txtTotalBuscaVenta";
            this.txtTotalBuscaVenta.ReadOnly = true;
            this.txtTotalBuscaVenta.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBuscaVenta.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "Descuento Aplicado";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(227, 117);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Total";
            // 
            // txtDescuentoAplicadoBusca
            // 
            this.txtDescuentoAplicadoBusca.Location = new System.Drawing.Point(92, 117);
            this.txtDescuentoAplicadoBusca.Name = "txtDescuentoAplicadoBusca";
            this.txtDescuentoAplicadoBusca.ReadOnly = true;
            this.txtDescuentoAplicadoBusca.Size = new System.Drawing.Size(100, 20);
            this.txtDescuentoAplicadoBusca.TabIndex = 37;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(198, 76);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(66, 13);
            this.l.TabIndex = 38;
            this.l.Text = "Iva Aplicado";
            // 
            // IvaAplicadoB
            // 
            this.IvaAplicadoB.Location = new System.Drawing.Point(264, 70);
            this.IvaAplicadoB.Name = "IvaAplicadoB";
            this.IvaAplicadoB.ReadOnly = true;
            this.IvaAplicadoB.Size = new System.Drawing.Size(100, 20);
            this.IvaAplicadoB.TabIndex = 39;
            // 
            // txtIvaBusca
            // 
            this.txtIvaBusca.Location = new System.Drawing.Point(264, 38);
            this.txtIvaBusca.Name = "txtIvaBusca";
            this.txtIvaBusca.ReadOnly = true;
            this.txtIvaBusca.Size = new System.Drawing.Size(100, 20);
            this.txtIvaBusca.TabIndex = 30;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(234, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 13);
            this.label24.TabIndex = 33;
            this.label24.Text = "IVA";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.txtFechaEntregado);
            this.groupBox3.Controls.Add(this.txtFechaSurtido);
            this.groupBox3.Controls.Add(this.txtFechaPago);
            this.groupBox3.Controls.Add(this.dtpEntregado);
            this.groupBox3.Controls.Add(this.dtpSurtido);
            this.groupBox3.Controls.Add(this.dtpPago);
            this.groupBox3.Controls.Add(this.cmbEntregado);
            this.groupBox3.Controls.Add(this.cmbSurtido);
            this.groupBox3.Controls.Add(this.cmbPago);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbk);
            this.groupBox3.Location = new System.Drawing.Point(411, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 189);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado";
            // 
            // txtFechaEntregado
            // 
            this.txtFechaEntregado.Location = new System.Drawing.Point(226, 119);
            this.txtFechaEntregado.Name = "txtFechaEntregado";
            this.txtFechaEntregado.ReadOnly = true;
            this.txtFechaEntregado.Size = new System.Drawing.Size(182, 20);
            this.txtFechaEntregado.TabIndex = 20;
            // 
            // txtFechaSurtido
            // 
            this.txtFechaSurtido.Location = new System.Drawing.Point(226, 81);
            this.txtFechaSurtido.Name = "txtFechaSurtido";
            this.txtFechaSurtido.ReadOnly = true;
            this.txtFechaSurtido.Size = new System.Drawing.Size(182, 20);
            this.txtFechaSurtido.TabIndex = 19;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.Location = new System.Drawing.Point(226, 45);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.ReadOnly = true;
            this.txtFechaPago.Size = new System.Drawing.Size(182, 20);
            this.txtFechaPago.TabIndex = 18;
            // 
            // dtpEntregado
            // 
            this.dtpEntregado.Enabled = false;
            this.dtpEntregado.Location = new System.Drawing.Point(414, 111);
            this.dtpEntregado.Name = "dtpEntregado";
            this.dtpEntregado.Size = new System.Drawing.Size(200, 20);
            this.dtpEntregado.TabIndex = 17;
            // 
            // dtpSurtido
            // 
            this.dtpSurtido.Enabled = false;
            this.dtpSurtido.Location = new System.Drawing.Point(414, 81);
            this.dtpSurtido.Name = "dtpSurtido";
            this.dtpSurtido.Size = new System.Drawing.Size(200, 20);
            this.dtpSurtido.TabIndex = 16;
            // 
            // dtpPago
            // 
            this.dtpPago.Enabled = false;
            this.dtpPago.Location = new System.Drawing.Point(414, 46);
            this.dtpPago.Name = "dtpPago";
            this.dtpPago.Size = new System.Drawing.Size(200, 20);
            this.dtpPago.TabIndex = 15;
            // 
            // cmbEntregado
            // 
            this.cmbEntregado.Enabled = false;
            this.cmbEntregado.FormattingEnabled = true;
            this.cmbEntregado.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbEntregado.Location = new System.Drawing.Point(135, 114);
            this.cmbEntregado.Name = "cmbEntregado";
            this.cmbEntregado.Size = new System.Drawing.Size(87, 21);
            this.cmbEntregado.TabIndex = 14;
            // 
            // cmbSurtido
            // 
            this.cmbSurtido.Enabled = false;
            this.cmbSurtido.FormattingEnabled = true;
            this.cmbSurtido.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbSurtido.Location = new System.Drawing.Point(135, 80);
            this.cmbSurtido.Name = "cmbSurtido";
            this.cmbSurtido.Size = new System.Drawing.Size(85, 21);
            this.cmbSurtido.TabIndex = 13;
            // 
            // cmbPago
            // 
            this.cmbPago.Enabled = false;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbPago.Location = new System.Drawing.Point(135, 42);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(85, 21);
            this.cmbPago.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.lbl7);
            this.groupBox4.Controls.Add(this.txtNombreClienteBusca);
            this.groupBox4.Controls.Add(this.txtClienteIdBus);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtRFCCliente);
            this.groupBox4.Controls.Add(this.txtMedioCliente);
            this.groupBox4.Controls.Add(this.txtTelefonoCliente);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtCelularCliente);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtEstadoCliente);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtCiudadCliente);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtCorreoCliente);
            this.groupBox4.Location = new System.Drawing.Point(1056, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 336);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // dgvBuscaCompra
            // 
            this.dgvBuscaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaCompra.Location = new System.Drawing.Point(513, 24);
            this.dgvBuscaCompra.Name = "dgvBuscaCompra";
            this.dgvBuscaCompra.ReadOnly = true;
            this.dgvBuscaCompra.Size = new System.Drawing.Size(429, 172);
            this.dgvBuscaCompra.TabIndex = 53;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Location = new System.Drawing.Point(353, 61);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPedido.TabIndex = 54;
            this.btnBuscarPedido.Text = "Buscar";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // rbModificaEstado
            // 
            this.rbModificaEstado.AutoSize = true;
            this.rbModificaEstado.Location = new System.Drawing.Point(353, 91);
            this.rbModificaEstado.Name = "rbModificaEstado";
            this.rbModificaEstado.Size = new System.Drawing.Size(104, 17);
            this.rbModificaEstado.TabIndex = 55;
            this.rbModificaEstado.TabStop = true;
            this.rbModificaEstado.Text = "Modificar Estado";
            this.rbModificaEstado.UseVisualStyleBackColor = true;
            this.rbModificaEstado.CheckedChanged += new System.EventHandler(this.rbModificaEstado_CheckedChanged);
            // 
            // rbBuscarPedido
            // 
            this.rbBuscarPedido.AutoSize = true;
            this.rbBuscarPedido.Location = new System.Drawing.Point(353, 24);
            this.rbBuscarPedido.Name = "rbBuscarPedido";
            this.rbBuscarPedido.Size = new System.Drawing.Size(58, 17);
            this.rbBuscarPedido.TabIndex = 56;
            this.rbBuscarPedido.TabStop = true;
            this.rbBuscarPedido.Text = "Buscar";
            this.rbBuscarPedido.UseVisualStyleBackColor = true;
            this.rbBuscarPedido.CheckedChanged += new System.EventHandler(this.rbBuscarPedido_CheckedChanged);
            // 
            // btnModificarEstado
            // 
            this.btnModificarEstado.Enabled = false;
            this.btnModificarEstado.Location = new System.Drawing.Point(353, 116);
            this.btnModificarEstado.Name = "btnModificarEstado";
            this.btnModificarEstado.Size = new System.Drawing.Size(121, 23);
            this.btnModificarEstado.TabIndex = 57;
            this.btnModificarEstado.Text = "Modificar Estado";
            this.btnModificarEstado.UseVisualStyleBackColor = true;
            this.btnModificarEstado.Click += new System.EventHandler(this.btnModificarEstado_Click);
            // 
            // btnRegresarBuscaPedido
            // 
            this.btnRegresarBuscaPedido.Location = new System.Drawing.Point(356, 159);
            this.btnRegresarBuscaPedido.Name = "btnRegresarBuscaPedido";
            this.btnRegresarBuscaPedido.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarBuscaPedido.TabIndex = 58;
            this.btnRegresarBuscaPedido.Text = "Regresar";
            this.btnRegresarBuscaPedido.UseVisualStyleBackColor = true;
            this.btnRegresarBuscaPedido.Click += new System.EventHandler(this.btnRegresarBuscaPedido_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Seleccione una de las Opciones";
            // 
            // BuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1268, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegresarBuscaPedido);
            this.Controls.Add(this.btnModificarEstado);
            this.Controls.Add(this.rbBuscarPedido);
            this.Controls.Add(this.rbModificaEstado);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.dgvBuscaCompra);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarPedido";
            this.Text = "Buscar Pedido";
            this.Load += new System.EventHandler(this.BuscarPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbk;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMedioCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.TextBox txtCiudadCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtRFCCliente;
        private System.Windows.Forms.TextBox txtClienteIdBus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNombreClienteBusca;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvBuscaCompra;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Label lblFolioBuscaPedido;
        private System.Windows.Forms.DateTimePicker dtpSurtido;
        private System.Windows.Forms.DateTimePicker dtpPago;
        private System.Windows.Forms.ComboBox cmbEntregado;
        private System.Windows.Forms.ComboBox cmbSurtido;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Label lblFechaPedidoBusca;
        private System.Windows.Forms.Label lblTipoPedidoBusca;
        private System.Windows.Forms.DateTimePicker dtpEntregado;
        private System.Windows.Forms.TextBox txtFolioPedidoBusca;
        private System.Windows.Forms.TextBox txtSubBVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescuentoBusca;
        private System.Windows.Forms.TextBox txtTotalBuscaVenta;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDescuentoAplicadoBusca;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox IvaAplicadoB;
        private System.Windows.Forms.TextBox txtIvaBusca;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtFechaEntregado;
        private System.Windows.Forms.TextBox txtFechaSurtido;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.RadioButton rbModificaEstado;
        private System.Windows.Forms.RadioButton rbBuscarPedido;
        private System.Windows.Forms.Button btnModificarEstado;
        private System.Windows.Forms.Button btnRegresarBuscaPedido;
        private System.Windows.Forms.Label label6;
    }
}