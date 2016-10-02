namespace WindowsFormsApplication1
{
    partial class BuscarCliente
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtMedioClienteB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstadoClienteB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCiudadClienteB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreoClienteB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelularClienteB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoClienteB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRfcClienteB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreClienteB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdClienteB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClienteBuscado = new System.Windows.Forms.TextBox();
            this.comboBuscarClientes = new System.Windows.Forms.ComboBox();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBuscaCliente = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(244, 25);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 37;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtMedioClienteB
            // 
            this.txtMedioClienteB.Location = new System.Drawing.Point(110, 293);
            this.txtMedioClienteB.Name = "txtMedioClienteB";
            this.txtMedioClienteB.ReadOnly = true;
            this.txtMedioClienteB.Size = new System.Drawing.Size(319, 20);
            this.txtMedioClienteB.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Medio de Contacto Principal";
            // 
            // txtEstadoClienteB
            // 
            this.txtEstadoClienteB.Location = new System.Drawing.Point(110, 254);
            this.txtEstadoClienteB.Name = "txtEstadoClienteB";
            this.txtEstadoClienteB.ReadOnly = true;
            this.txtEstadoClienteB.Size = new System.Drawing.Size(209, 20);
            this.txtEstadoClienteB.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Estado";
            // 
            // txtCiudadClienteB
            // 
            this.txtCiudadClienteB.Location = new System.Drawing.Point(108, 228);
            this.txtCiudadClienteB.Name = "txtCiudadClienteB";
            this.txtCiudadClienteB.ReadOnly = true;
            this.txtCiudadClienteB.Size = new System.Drawing.Size(211, 20);
            this.txtCiudadClienteB.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ciudad o Municipio";
            // 
            // txtCorreoClienteB
            // 
            this.txtCorreoClienteB.Location = new System.Drawing.Point(110, 202);
            this.txtCorreoClienteB.Name = "txtCorreoClienteB";
            this.txtCorreoClienteB.ReadOnly = true;
            this.txtCorreoClienteB.Size = new System.Drawing.Size(209, 20);
            this.txtCorreoClienteB.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Correo";
            // 
            // txtCelularClienteB
            // 
            this.txtCelularClienteB.Location = new System.Drawing.Point(110, 174);
            this.txtCelularClienteB.Name = "txtCelularClienteB";
            this.txtCelularClienteB.ReadOnly = true;
            this.txtCelularClienteB.Size = new System.Drawing.Size(209, 20);
            this.txtCelularClienteB.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Celular";
            // 
            // txtTelefonoClienteB
            // 
            this.txtTelefonoClienteB.Location = new System.Drawing.Point(110, 147);
            this.txtTelefonoClienteB.Name = "txtTelefonoClienteB";
            this.txtTelefonoClienteB.ReadOnly = true;
            this.txtTelefonoClienteB.Size = new System.Drawing.Size(209, 20);
            this.txtTelefonoClienteB.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefono con Lada";
            // 
            // txtRfcClienteB
            // 
            this.txtRfcClienteB.Location = new System.Drawing.Point(108, 115);
            this.txtRfcClienteB.Name = "txtRfcClienteB";
            this.txtRfcClienteB.ReadOnly = true;
            this.txtRfcClienteB.Size = new System.Drawing.Size(303, 20);
            this.txtRfcClienteB.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "RFC";
            // 
            // txtNombreClienteB
            // 
            this.txtNombreClienteB.Location = new System.Drawing.Point(108, 83);
            this.txtNombreClienteB.Name = "txtNombreClienteB";
            this.txtNombreClienteB.ReadOnly = true;
            this.txtNombreClienteB.Size = new System.Drawing.Size(303, 20);
            this.txtNombreClienteB.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre Completo";
            // 
            // txtIdClienteB
            // 
            this.txtIdClienteB.Location = new System.Drawing.Point(110, 23);
            this.txtIdClienteB.Name = "txtIdClienteB";
            this.txtIdClienteB.Size = new System.Drawing.Size(100, 20);
            this.txtIdClienteB.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "ID a Buscar";
            // 
            // txtClienteBuscado
            // 
            this.txtClienteBuscado.Location = new System.Drawing.Point(108, 54);
            this.txtClienteBuscado.Name = "txtClienteBuscado";
            this.txtClienteBuscado.ReadOnly = true;
            this.txtClienteBuscado.Size = new System.Drawing.Size(100, 20);
            this.txtClienteBuscado.TabIndex = 39;
            // 
            // comboBuscarClientes
            // 
            this.comboBuscarClientes.FormattingEnabled = true;
            this.comboBuscarClientes.Items.AddRange(new object[] {
            "",
            "Nombre",
            "RFC",
            "Estado"});
            this.comboBuscarClientes.Location = new System.Drawing.Point(110, 23);
            this.comboBuscarClientes.Name = "comboBuscarClientes";
            this.comboBuscarClientes.Size = new System.Drawing.Size(121, 21);
            this.comboBuscarClientes.TabIndex = 40;
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Location = new System.Drawing.Point(110, 60);
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(121, 20);
            this.txtBuscaCliente.TabIndex = 41;
            this.txtBuscaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaCliente_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Buscar por:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Coincidencia";
            // 
            // dgvBuscaCliente
            // 
            this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaCliente.Location = new System.Drawing.Point(23, 19);
            this.dgvBuscaCliente.Name = "dgvBuscaCliente";
            this.dgvBuscaCliente.ReadOnly = true;
            this.dgvBuscaCliente.Size = new System.Drawing.Size(474, 241);
            this.dgvBuscaCliente.TabIndex = 44;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(906, 14);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(89, 25);
            this.btnRegresar.TabIndex = 45;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClienteBuscado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreClienteB);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRfcClienteB);
            this.groupBox1.Controls.Add(this.txtIdClienteB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefonoClienteB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMedioClienteB);
            this.groupBox1.Controls.Add(this.txtCelularClienteB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEstadoClienteB);
            this.groupBox1.Controls.Add(this.txtCorreoClienteB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCiudadClienteB);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 348);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBuscarClientes);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtBuscaCliente);
            this.groupBox2.Location = new System.Drawing.Point(545, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 103);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Varios";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.dgvBuscaCliente);
            this.groupBox3.Location = new System.Drawing.Point(538, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 276);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes con la misma Coincidencia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "De enter para mostrar las coindidencias";
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1069, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Name = "BuscarCliente";
            this.Text = "Busqueda de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtMedioClienteB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstadoClienteB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCiudadClienteB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreoClienteB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCelularClienteB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoClienteB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRfcClienteB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreClienteB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdClienteB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClienteBuscado;
        private System.Windows.Forms.ComboBox comboBuscarClientes;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBuscaCliente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}