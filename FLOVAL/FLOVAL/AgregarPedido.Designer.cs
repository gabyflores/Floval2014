namespace WindowsFormsApplication1
{
    partial class AgregarPedido
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbFPRP = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpEntregado = new System.Windows.Forms.DateTimePicker();
            this.dtpSurtido = new System.Windows.Forms.DateTimePicker();
            this.dtpPagado = new System.Windows.Forms.DateTimePicker();
            this.cmbEntregado = new System.Windows.Forms.ComboBox();
            this.cmbSurtido = new System.Windows.Forms.ComboBox();
            this.cmbPagado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFolioPedido = new System.Windows.Forms.Label();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.txtTipoPedido = new System.Windows.Forms.TextBox();
            this.dgvRP = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdClientePedido = new System.Windows.Forms.TextBox();
            this.txtNombreClientePedido = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSubtotalRP = new System.Windows.Forms.TextBox();
            this.txtIvaRP = new System.Windows.Forms.TextBox();
            this.txtTotalRP = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDescCantRP = new System.Windows.Forms.TextBox();
            this.txtDescRP = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtporcRP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrabarProducto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRFCPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidadRP = new System.Windows.Forms.TextBox();
            this.txtPrecioRP = new System.Windows.Forms.TextBox();
            this.txtProductoRP = new System.Windows.Forms.TextBox();
            this.txtIdProductoRP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCantidadPiezasRP = new System.Windows.Forms.TextBox();
            this.btnRegresaRP = new System.Windows.Forms.Button();
            this.pboxAgregarPedido = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRP)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.cmbFPRP);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dtpEntregado);
            this.groupBox3.Controls.Add(this.dtpSurtido);
            this.groupBox3.Controls.Add(this.dtpPagado);
            this.groupBox3.Controls.Add(this.cmbEntregado);
            this.groupBox3.Controls.Add(this.cmbSurtido);
            this.groupBox3.Controls.Add(this.cmbPagado);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(612, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 155);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 132);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "0 =hecho 1=no hecho";
            // 
            // cmbFPRP
            // 
            this.cmbFPRP.FormattingEnabled = true;
            this.cmbFPRP.Items.AddRange(new object[] {
            "",
            "Efectivo",
            "Deposito",
            "Cheque"});
            this.cmbFPRP.Location = new System.Drawing.Point(189, 108);
            this.cmbFPRP.Name = "cmbFPRP";
            this.cmbFPRP.Size = new System.Drawing.Size(121, 21);
            this.cmbFPRP.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Forma de Pago";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(199, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Fecha Entregado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(219, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Fecha Surtido";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Fecha de Pago";
            // 
            // dtpEntregado
            // 
            this.dtpEntregado.Enabled = false;
            this.dtpEntregado.Location = new System.Drawing.Point(294, 80);
            this.dtpEntregado.Name = "dtpEntregado";
            this.dtpEntregado.Size = new System.Drawing.Size(194, 20);
            this.dtpEntregado.TabIndex = 90;
            // 
            // dtpSurtido
            // 
            this.dtpSurtido.Enabled = false;
            this.dtpSurtido.Location = new System.Drawing.Point(294, 53);
            this.dtpSurtido.Name = "dtpSurtido";
            this.dtpSurtido.Size = new System.Drawing.Size(194, 20);
            this.dtpSurtido.TabIndex = 80;
            // 
            // dtpPagado
            // 
            this.dtpPagado.Enabled = false;
            this.dtpPagado.Location = new System.Drawing.Point(294, 24);
            this.dtpPagado.Name = "dtpPagado";
            this.dtpPagado.Size = new System.Drawing.Size(194, 20);
            this.dtpPagado.TabIndex = 70;
            // 
            // cmbEntregado
            // 
            this.cmbEntregado.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "0",
            "1"});
            this.cmbEntregado.FormattingEnabled = true;
            this.cmbEntregado.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbEntregado.Location = new System.Drawing.Point(64, 77);
            this.cmbEntregado.Name = "cmbEntregado";
            this.cmbEntregado.Size = new System.Drawing.Size(121, 21);
            this.cmbEntregado.TabIndex = 50;
            this.cmbEntregado.SelectedIndexChanged += new System.EventHandler(this.cmbEntregado_SelectedIndexChanged);
            // 
            // cmbSurtido
            // 
            this.cmbSurtido.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "0",
            "1"});
            this.cmbSurtido.FormattingEnabled = true;
            this.cmbSurtido.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbSurtido.Location = new System.Drawing.Point(64, 51);
            this.cmbSurtido.Name = "cmbSurtido";
            this.cmbSurtido.Size = new System.Drawing.Size(121, 21);
            this.cmbSurtido.TabIndex = 40;
            this.cmbSurtido.SelectedIndexChanged += new System.EventHandler(this.cmbSurtido_SelectedIndexChanged);
            // 
            // cmbPagado
            // 
            this.cmbPagado.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "0",
            "1"});
            this.cmbPagado.FormattingEnabled = true;
            this.cmbPagado.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbPagado.Location = new System.Drawing.Point(64, 24);
            this.cmbPagado.Name = "cmbPagado";
            this.cmbPagado.Size = new System.Drawing.Size(121, 21);
            this.cmbPagado.TabIndex = 30;
            this.cmbPagado.SelectedIndexChanged += new System.EventHandler(this.cmbPagado_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Entregado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Surtido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pagado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Cliente";
            // 
            // lblFolioPedido
            // 
            this.lblFolioPedido.AutoSize = true;
            this.lblFolioPedido.Location = new System.Drawing.Point(70, 32);
            this.lblFolioPedido.Name = "lblFolioPedido";
            this.lblFolioPedido.Size = new System.Drawing.Size(13, 13);
            this.lblFolioPedido.TabIndex = 5;
            this.lblFolioPedido.Text = "0";
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(70, 61);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(13, 13);
            this.lblFechaPedido.TabIndex = 6;
            this.lblFechaPedido.Text = "0";
            // 
            // txtTipoPedido
            // 
            this.txtTipoPedido.Location = new System.Drawing.Point(57, 90);
            this.txtTipoPedido.Name = "txtTipoPedido";
            this.txtTipoPedido.ReadOnly = true;
            this.txtTipoPedido.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPedido.TabIndex = 7;
            this.txtTipoPedido.Text = "3";
            // 
            // dgvRP
            // 
            this.dgvRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRP.Location = new System.Drawing.Point(26, 273);
            this.dgvRP.Name = "dgvRP";
            this.dgvRP.ReadOnly = true;
            this.dgvRP.Size = new System.Drawing.Size(548, 164);
            this.dgvRP.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre";
            // 
            // txtIdClientePedido
            // 
            this.txtIdClientePedido.Location = new System.Drawing.Point(63, 21);
            this.txtIdClientePedido.Name = "txtIdClientePedido";
            this.txtIdClientePedido.Size = new System.Drawing.Size(85, 20);
            this.txtIdClientePedido.TabIndex = 10;
            this.txtIdClientePedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdClientePedido_KeyPress);
            // 
            // txtNombreClientePedido
            // 
            this.txtNombreClientePedido.Location = new System.Drawing.Point(63, 54);
            this.txtNombreClientePedido.Name = "txtNombreClientePedido";
            this.txtNombreClientePedido.ReadOnly = true;
            this.txtNombreClientePedido.Size = new System.Drawing.Size(231, 20);
            this.txtNombreClientePedido.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(109, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Iva";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(85, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Subtotal";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(100, 113);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Total";
            // 
            // txtSubtotalRP
            // 
            this.txtSubtotalRP.Location = new System.Drawing.Point(137, 31);
            this.txtSubtotalRP.Name = "txtSubtotalRP";
            this.txtSubtotalRP.ReadOnly = true;
            this.txtSubtotalRP.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalRP.TabIndex = 92;
            // 
            // txtIvaRP
            // 
            this.txtIvaRP.Location = new System.Drawing.Point(137, 83);
            this.txtIvaRP.Name = "txtIvaRP";
            this.txtIvaRP.ReadOnly = true;
            this.txtIvaRP.Size = new System.Drawing.Size(100, 20);
            this.txtIvaRP.TabIndex = 95;
            // 
            // txtTotalRP
            // 
            this.txtTotalRP.Location = new System.Drawing.Point(137, 113);
            this.txtTotalRP.Name = "txtTotalRP";
            this.txtTotalRP.ReadOnly = true;
            this.txtTotalRP.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRP.TabIndex = 98;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(247, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Descuento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Cantidad con Descuento";
            // 
            // txtDescCantRP
            // 
            this.txtDescCantRP.Location = new System.Drawing.Point(137, 56);
            this.txtDescCantRP.Name = "txtDescCantRP";
            this.txtDescCantRP.ReadOnly = true;
            this.txtDescCantRP.Size = new System.Drawing.Size(100, 20);
            this.txtDescCantRP.TabIndex = 94;
            // 
            // txtDescRP
            // 
            this.txtDescRP.Location = new System.Drawing.Point(312, 85);
            this.txtDescRP.Name = "txtDescRP";
            this.txtDescRP.ReadOnly = true;
            this.txtDescRP.Size = new System.Drawing.Size(100, 20);
            this.txtDescRP.TabIndex = 101;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(371, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "%";
            // 
            // txtporcRP
            // 
            this.txtporcRP.Location = new System.Drawing.Point(251, 54);
            this.txtporcRP.Name = "txtporcRP";
            this.txtporcRP.ReadOnly = true;
            this.txtporcRP.Size = new System.Drawing.Size(100, 20);
            this.txtporcRP.TabIndex = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(248, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Porcentaje";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtDescRP);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtporcRP);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtSubtotalRP);
            this.groupBox4.Controls.Add(this.txtDescCantRP);
            this.groupBox4.Controls.Add(this.txtTotalRP);
            this.groupBox4.Controls.Add(this.txtIvaRP);
            this.groupBox4.Location = new System.Drawing.Point(630, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 167);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Totales";
            // 
            // btnGrabarProducto
            // 
            this.btnGrabarProducto.Location = new System.Drawing.Point(407, 227);
            this.btnGrabarProducto.Name = "btnGrabarProducto";
            this.btnGrabarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnGrabarProducto.TabIndex = 26;
            this.btnGrabarProducto.Text = "Grabar";
            this.btnGrabarProducto.UseVisualStyleBackColor = true;
            this.btnGrabarProducto.Click += new System.EventHandler(this.btnGrabarProducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.txtRFCPedido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdClientePedido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreClientePedido);
            this.groupBox1.Location = new System.Drawing.Point(26, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // txtRFCPedido
            // 
            this.txtRFCPedido.Location = new System.Drawing.Point(63, 80);
            this.txtRFCPedido.Name = "txtRFCPedido";
            this.txtRFCPedido.ReadOnly = true;
            this.txtRFCPedido.Size = new System.Drawing.Size(231, 20);
            this.txtRFCPedido.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "RFC";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Violet;
            this.groupBox2.Controls.Add(this.txtCantidadRP);
            this.groupBox2.Controls.Add(this.txtPrecioRP);
            this.groupBox2.Controls.Add(this.txtProductoRP);
            this.groupBox2.Controls.Add(this.txtIdProductoRP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(407, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 196);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // txtCantidadRP
            // 
            this.txtCantidadRP.Location = new System.Drawing.Point(74, 140);
            this.txtCantidadRP.Name = "txtCantidadRP";
            this.txtCantidadRP.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadRP.TabIndex = 20;
            this.txtCantidadRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadRP_KeyPress);
            // 
            // txtPrecioRP
            // 
            this.txtPrecioRP.Location = new System.Drawing.Point(74, 111);
            this.txtPrecioRP.Name = "txtPrecioRP";
            this.txtPrecioRP.ReadOnly = true;
            this.txtPrecioRP.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioRP.TabIndex = 6;
            // 
            // txtProductoRP
            // 
            this.txtProductoRP.Location = new System.Drawing.Point(74, 79);
            this.txtProductoRP.Name = "txtProductoRP";
            this.txtProductoRP.ReadOnly = true;
            this.txtProductoRP.Size = new System.Drawing.Size(100, 20);
            this.txtProductoRP.TabIndex = 5;
            // 
            // txtIdProductoRP
            // 
            this.txtIdProductoRP.Location = new System.Drawing.Point(74, 44);
            this.txtIdProductoRP.Name = "txtIdProductoRP";
            this.txtIdProductoRP.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoRP.TabIndex = 15;
            this.txtIdProductoRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProductoRP_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id Producto";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 446);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Cantidad de  Piezas";
            // 
            // txtCantidadPiezasRP
            // 
            this.txtCantidadPiezasRP.Location = new System.Drawing.Point(146, 443);
            this.txtCantidadPiezasRP.Name = "txtCantidadPiezasRP";
            this.txtCantidadPiezasRP.ReadOnly = true;
            this.txtCantidadPiezasRP.Size = new System.Drawing.Size(101, 20);
            this.txtCantidadPiezasRP.TabIndex = 106;
            // 
            // btnRegresaRP
            // 
            this.btnRegresaRP.Location = new System.Drawing.Point(520, 227);
            this.btnRegresaRP.Name = "btnRegresaRP";
            this.btnRegresaRP.Size = new System.Drawing.Size(75, 23);
            this.btnRegresaRP.TabIndex = 33;
            this.btnRegresaRP.Text = "Regresar";
            this.btnRegresaRP.UseVisualStyleBackColor = true;
            this.btnRegresaRP.Click += new System.EventHandler(this.btnRegresaRP_Click);
            // 
            // pboxAgregarPedido
            // 
            this.pboxAgregarPedido.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.pboxAgregarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxAgregarPedido.Location = new System.Drawing.Point(273, 8);
            this.pboxAgregarPedido.Name = "pboxAgregarPedido";
            this.pboxAgregarPedido.Size = new System.Drawing.Size(119, 98);
            this.pboxAgregarPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAgregarPedido.TabIndex = 34;
            this.pboxAgregarPedido.TabStop = false;
            // 
            // AgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1127, 475);
            this.Controls.Add(this.pboxAgregarPedido);
            this.Controls.Add(this.btnRegresaRP);
            this.Controls.Add(this.txtCantidadPiezasRP);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGrabarProducto);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvRP);
            this.Controls.Add(this.txtTipoPedido);
            this.Controls.Add(this.lblFechaPedido);
            this.Controls.Add(this.lblFolioPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "AgregarPedido";
            this.Text = "Agregar Pedido";
            this.Load += new System.EventHandler(this.AgregarPedido_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEntregado;
        private System.Windows.Forms.ComboBox cmbSurtido;
        private System.Windows.Forms.ComboBox cmbPagado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFolioPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.TextBox txtTipoPedido;
        private System.Windows.Forms.ComboBox cmbFPRP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpEntregado;
        private System.Windows.Forms.DateTimePicker dtpSurtido;
        private System.Windows.Forms.DateTimePicker dtpPagado;
        private System.Windows.Forms.DataGridView dgvRP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdClientePedido;
        private System.Windows.Forms.TextBox txtNombreClientePedido;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSubtotalRP;
        private System.Windows.Forms.TextBox txtIvaRP;
        private System.Windows.Forms.TextBox txtTotalRP;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDescCantRP;
        private System.Windows.Forms.TextBox txtDescRP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtporcRP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGrabarProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidadRP;
        private System.Windows.Forms.TextBox txtPrecioRP;
        private System.Windows.Forms.TextBox txtProductoRP;
        private System.Windows.Forms.TextBox txtIdProductoRP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRFCPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCantidadPiezasRP;
        private System.Windows.Forms.Button btnRegresaRP;
        private System.Windows.Forms.PictureBox pboxAgregarPedido;
        private System.Windows.Forms.Label label26;
    }
}