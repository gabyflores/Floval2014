namespace WindowsFormsApplication1
{
    partial class BuscarCompra
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
            this.txtFolioCompraB = new System.Windows.Forms.TextBox();
            this.dgvBuscarCompra = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaAcordada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtTotalBC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIvaBC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPtosCompra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFolioBCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRetraso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubtotalBC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegresarBC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolioCompraB
            // 
            this.txtFolioCompraB.Location = new System.Drawing.Point(137, 19);
            this.txtFolioCompraB.Name = "txtFolioCompraB";
            this.txtFolioCompraB.ReadOnly = true;
            this.txtFolioCompraB.Size = new System.Drawing.Size(100, 20);
            this.txtFolioCompraB.TabIndex = 0;
            // 
            // dgvBuscarCompra
            // 
            this.dgvBuscarCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCompra.Location = new System.Drawing.Point(56, 190);
            this.dgvBuscarCompra.Name = "dgvBuscarCompra";
            this.dgvBuscarCompra.ReadOnly = true;
            this.dgvBuscarCompra.Size = new System.Drawing.Size(520, 150);
            this.dgvBuscarCompra.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(27, 22);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(68, 13);
            this.Id.TabIndex = 2;
            this.Id.Text = "Folio Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Acordada";
            // 
            // txtFechaAcordada
            // 
            this.txtFechaAcordada.Location = new System.Drawing.Point(137, 79);
            this.txtFechaAcordada.Name = "txtFechaAcordada";
            this.txtFechaAcordada.ReadOnly = true;
            this.txtFechaAcordada.Size = new System.Drawing.Size(259, 20);
            this.txtFechaAcordada.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(489, 50);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 7;
            // 
            // txtTotalBC
            // 
            this.txtTotalBC.Location = new System.Drawing.Point(80, 94);
            this.txtTotalBC.Name = "txtTotalBC";
            this.txtTotalBC.ReadOnly = true;
            this.txtTotalBC.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBC.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iva";
            // 
            // txtIvaBC
            // 
            this.txtIvaBC.Location = new System.Drawing.Point(80, 55);
            this.txtIvaBC.Name = "txtIvaBC";
            this.txtIvaBC.ReadOnly = true;
            this.txtIvaBC.Size = new System.Drawing.Size(100, 20);
            this.txtIvaBC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Puntos";
            // 
            // txtPtosCompra
            // 
            this.txtPtosCompra.Location = new System.Drawing.Point(489, 106);
            this.txtPtosCompra.Name = "txtPtosCompra";
            this.txtPtosCompra.ReadOnly = true;
            this.txtPtosCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPtosCompra.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Folio a Buscar";
            // 
            // txtFolioBCompra
            // 
            this.txtFolioBCompra.Location = new System.Drawing.Point(149, 9);
            this.txtFolioBCompra.Name = "txtFolioBCompra";
            this.txtFolioBCompra.Size = new System.Drawing.Size(100, 20);
            this.txtFolioBCompra.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Retraso";
            // 
            // txtRetraso
            // 
            this.txtRetraso.Location = new System.Drawing.Point(137, 116);
            this.txtRetraso.Name = "txtRetraso";
            this.txtRetraso.ReadOnly = true;
            this.txtRetraso.Size = new System.Drawing.Size(100, 20);
            this.txtRetraso.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(489, 79);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProveedor.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Subtotal";
            // 
            // txtSubtotalBC
            // 
            this.txtSubtotalBC.Location = new System.Drawing.Point(80, 21);
            this.txtSubtotalBC.Name = "txtSubtotalBC";
            this.txtSubtotalBC.ReadOnly = true;
            this.txtSubtotalBC.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalBC.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtFechaCompra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFolioCompraB);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.txtFechaAcordada);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPtosCompra);
            this.groupBox1.Controls.Add(this.txtRetraso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Location = new System.Drawing.Point(42, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 142);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra";
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.Location = new System.Drawing.Point(137, 47);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.ReadOnly = true;
            this.txtFechaCompra.Size = new System.Drawing.Size(259, 20);
            this.txtFechaCompra.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSubtotalBC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIvaBC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTotalBC);
            this.groupBox2.Location = new System.Drawing.Point(625, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 146);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // btnRegresarBC
            // 
            this.btnRegresarBC.Location = new System.Drawing.Point(373, 9);
            this.btnRegresarBC.Name = "btnRegresarBC";
            this.btnRegresarBC.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarBC.TabIndex = 24;
            this.btnRegresarBC.Text = "Regresar";
            this.btnRegresarBC.UseVisualStyleBackColor = true;
            this.btnRegresarBC.Click += new System.EventHandler(this.btnRegresarBC_Click);
            // 
            // BuscarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1010, 387);
            this.Controls.Add(this.btnRegresarBC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFolioBCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBuscarCompra);
            this.Name = "BuscarCompra";
            this.Text = "BuscarCompra";
            this.Load += new System.EventHandler(this.BuscarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolioCompraB;
        private System.Windows.Forms.DataGridView dgvBuscarCompra;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaAcordada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtTotalBC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIvaBC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPtosCompra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFolioBCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRetraso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubtotalBC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFechaCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegresarBC;
    }
}