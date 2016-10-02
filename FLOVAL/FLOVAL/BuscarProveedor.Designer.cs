namespace WindowsFormsApplication1
{
    partial class BuscarProveedor
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
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtCorreoProveedorB = new System.Windows.Forms.TextBox();
            this.txtCelularProveedorB = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedorB = new System.Windows.Forms.TextBox();
            this.txtDireccionProveedorB = new System.Windows.Forms.TextBox();
            this.txtEstadoProveedorB = new System.Windows.Forms.TextBox();
            this.txtCiudadProveedorB = new System.Windows.Forms.TextBox();
            this.txtMarcaB = new System.Windows.Forms.TextBox();
            this.txtPtsProveedorB = new System.Windows.Forms.TextBox();
            this.txtNombreProveedorB = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProveedorB = new System.Windows.Forms.TextBox();
            this.comboBoxProveedorBus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBuscarCombo = new System.Windows.Forms.TextBox();
            this.dgvBuscarProveedor = new System.Windows.Forms.DataGridView();
            this.btnRegresrBP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnActualizarPtos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(293, 34);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 42;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtCorreoProveedorB
            // 
            this.txtCorreoProveedorB.Location = new System.Drawing.Point(136, 345);
            this.txtCorreoProveedorB.Name = "txtCorreoProveedorB";
            this.txtCorreoProveedorB.ReadOnly = true;
            this.txtCorreoProveedorB.Size = new System.Drawing.Size(222, 20);
            this.txtCorreoProveedorB.TabIndex = 41;
            // 
            // txtCelularProveedorB
            // 
            this.txtCelularProveedorB.Location = new System.Drawing.Point(136, 319);
            this.txtCelularProveedorB.Name = "txtCelularProveedorB";
            this.txtCelularProveedorB.ReadOnly = true;
            this.txtCelularProveedorB.Size = new System.Drawing.Size(222, 20);
            this.txtCelularProveedorB.TabIndex = 40;
            // 
            // txtTelefonoProveedorB
            // 
            this.txtTelefonoProveedorB.Location = new System.Drawing.Point(136, 291);
            this.txtTelefonoProveedorB.Name = "txtTelefonoProveedorB";
            this.txtTelefonoProveedorB.ReadOnly = true;
            this.txtTelefonoProveedorB.Size = new System.Drawing.Size(222, 20);
            this.txtTelefonoProveedorB.TabIndex = 39;
            // 
            // txtDireccionProveedorB
            // 
            this.txtDireccionProveedorB.Location = new System.Drawing.Point(136, 265);
            this.txtDireccionProveedorB.Name = "txtDireccionProveedorB";
            this.txtDireccionProveedorB.ReadOnly = true;
            this.txtDireccionProveedorB.Size = new System.Drawing.Size(334, 20);
            this.txtDireccionProveedorB.TabIndex = 38;
            // 
            // txtEstadoProveedorB
            // 
            this.txtEstadoProveedorB.Location = new System.Drawing.Point(136, 236);
            this.txtEstadoProveedorB.Name = "txtEstadoProveedorB";
            this.txtEstadoProveedorB.ReadOnly = true;
            this.txtEstadoProveedorB.Size = new System.Drawing.Size(222, 20);
            this.txtEstadoProveedorB.TabIndex = 37;
            // 
            // txtCiudadProveedorB
            // 
            this.txtCiudadProveedorB.Location = new System.Drawing.Point(136, 206);
            this.txtCiudadProveedorB.Name = "txtCiudadProveedorB";
            this.txtCiudadProveedorB.ReadOnly = true;
            this.txtCiudadProveedorB.Size = new System.Drawing.Size(222, 20);
            this.txtCiudadProveedorB.TabIndex = 36;
            // 
            // txtMarcaB
            // 
            this.txtMarcaB.Location = new System.Drawing.Point(136, 177);
            this.txtMarcaB.Name = "txtMarcaB";
            this.txtMarcaB.ReadOnly = true;
            this.txtMarcaB.Size = new System.Drawing.Size(222, 20);
            this.txtMarcaB.TabIndex = 35;
            // 
            // txtPtsProveedorB
            // 
            this.txtPtsProveedorB.Location = new System.Drawing.Point(136, 146);
            this.txtPtsProveedorB.Name = "txtPtsProveedorB";
            this.txtPtsProveedorB.ReadOnly = true;
            this.txtPtsProveedorB.Size = new System.Drawing.Size(100, 20);
            this.txtPtsProveedorB.TabIndex = 34;
            // 
            // txtNombreProveedorB
            // 
            this.txtNombreProveedorB.Location = new System.Drawing.Point(136, 113);
            this.txtNombreProveedorB.Name = "txtNombreProveedorB";
            this.txtNombreProveedorB.ReadOnly = true;
            this.txtNombreProveedorB.Size = new System.Drawing.Size(334, 20);
            this.txtNombreProveedorB.TabIndex = 33;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(136, 37);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedor.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ciudad o Municipio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Puntos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id Proveedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "ID de Proveedor a Buscar";
            // 
            // txtProveedorB
            // 
            this.txtProveedorB.Location = new System.Drawing.Point(136, 79);
            this.txtProveedorB.Name = "txtProveedorB";
            this.txtProveedorB.ReadOnly = true;
            this.txtProveedorB.Size = new System.Drawing.Size(100, 20);
            this.txtProveedorB.TabIndex = 44;
            // 
            // comboBoxProveedorBus
            // 
            this.comboBoxProveedorBus.FormattingEnabled = true;
            this.comboBoxProveedorBus.Items.AddRange(new object[] {
            "",
            "Nombre",
            "Puntos",
            "Estado"});
            this.comboBoxProveedorBus.Location = new System.Drawing.Point(553, 33);
            this.comboBoxProveedorBus.Name = "comboBoxProveedorBus";
            this.comboBoxProveedorBus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProveedorBus.TabIndex = 45;
            this.comboBoxProveedorBus.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveedorBus_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Buscar por:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(497, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Buscar";
            // 
            // txtBuscarCombo
            // 
            this.txtBuscarCombo.Location = new System.Drawing.Point(543, 73);
            this.txtBuscarCombo.Name = "txtBuscarCombo";
            this.txtBuscarCombo.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCombo.TabIndex = 48;
            this.txtBuscarCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCombo_KeyPress);
            // 
            // dgvBuscarProveedor
            // 
            this.dgvBuscarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProveedor.Location = new System.Drawing.Point(18, 19);
            this.dgvBuscarProveedor.Name = "dgvBuscarProveedor";
            this.dgvBuscarProveedor.Size = new System.Drawing.Size(492, 198);
            this.dgvBuscarProveedor.TabIndex = 49;
            // 
            // btnRegresrBP
            // 
            this.btnRegresrBP.Location = new System.Drawing.Point(293, 69);
            this.btnRegresrBP.Name = "btnRegresrBP";
            this.btnRegresrBP.Size = new System.Drawing.Size(75, 23);
            this.btnRegresrBP.TabIndex = 50;
            this.btnRegresrBP.Text = "Regresar";
            this.btnRegresrBP.UseVisualStyleBackColor = true;
            this.btnRegresrBP.Click += new System.EventHandler(this.btnRegresrBP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dgvBuscarProveedor);
            this.groupBox1.Location = new System.Drawing.Point(476, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 236);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Varios";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(649, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Presione enter para mostrar coincidencias";
            // 
            // btnActualizarPtos
            // 
            this.btnActualizarPtos.Location = new System.Drawing.Point(255, 146);
            this.btnActualizarPtos.Name = "btnActualizarPtos";
            this.btnActualizarPtos.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPtos.TabIndex = 53;
            this.btnActualizarPtos.Text = "Actualizar";
            this.btnActualizarPtos.UseVisualStyleBackColor = true;
            this.btnActualizarPtos.Click += new System.EventHandler(this.btnActualizarPtos_Click);
            // 
            // BuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1021, 412);
            this.Controls.Add(this.btnActualizarPtos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresrBP);
            this.Controls.Add(this.txtBuscarCombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxProveedorBus);
            this.Controls.Add(this.txtProveedorB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.txtCorreoProveedorB);
            this.Controls.Add(this.txtCelularProveedorB);
            this.Controls.Add(this.txtTelefonoProveedorB);
            this.Controls.Add(this.txtDireccionProveedorB);
            this.Controls.Add(this.txtEstadoProveedorB);
            this.Controls.Add(this.txtCiudadProveedorB);
            this.Controls.Add(this.txtMarcaB);
            this.Controls.Add(this.txtPtsProveedorB);
            this.Controls.Add(this.txtNombreProveedorB);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarProveedor";
            this.Text = "Busqueda de Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtCorreoProveedorB;
        private System.Windows.Forms.TextBox txtCelularProveedorB;
        private System.Windows.Forms.TextBox txtTelefonoProveedorB;
        private System.Windows.Forms.TextBox txtDireccionProveedorB;
        private System.Windows.Forms.TextBox txtEstadoProveedorB;
        private System.Windows.Forms.TextBox txtCiudadProveedorB;
        private System.Windows.Forms.TextBox txtMarcaB;
        private System.Windows.Forms.TextBox txtPtsProveedorB;
        private System.Windows.Forms.TextBox txtNombreProveedorB;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProveedorB;
        private System.Windows.Forms.ComboBox comboBoxProveedorBus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBuscarCombo;
        private System.Windows.Forms.DataGridView dgvBuscarProveedor;
        private System.Windows.Forms.Button btnRegresrBP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnActualizarPtos;
    }
}