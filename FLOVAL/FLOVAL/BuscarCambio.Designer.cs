namespace WindowsFormsApplication1
{
    partial class BuscarCambio
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
            this.txtCambioBusca = new System.Windows.Forms.TextBox();
            this.dgvRegresados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaCambioBusca = new System.Windows.Forms.TextBox();
            this.btnBuscaCambio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolioVentaBusca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotivoCambio = new System.Windows.Forms.TextBox();
            this.dgvLlevados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolioC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotalReg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotalLleva = new System.Windows.Forms.TextBox();
            this.btnRegresarBC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegresados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlevados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCambioBusca
            // 
            this.txtCambioBusca.Location = new System.Drawing.Point(173, 36);
            this.txtCambioBusca.Name = "txtCambioBusca";
            this.txtCambioBusca.Size = new System.Drawing.Size(100, 20);
            this.txtCambioBusca.TabIndex = 0;
            // 
            // dgvRegresados
            // 
            this.dgvRegresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegresados.Location = new System.Drawing.Point(26, 21);
            this.dgvRegresados.Name = "dgvRegresados";
            this.dgvRegresados.ReadOnly = true;
            this.dgvRegresados.Size = new System.Drawing.Size(359, 134);
            this.dgvRegresados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folio Cambio a Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // txtFechaCambioBusca
            // 
            this.txtFechaCambioBusca.Location = new System.Drawing.Point(173, 99);
            this.txtFechaCambioBusca.Name = "txtFechaCambioBusca";
            this.txtFechaCambioBusca.ReadOnly = true;
            this.txtFechaCambioBusca.Size = new System.Drawing.Size(182, 20);
            this.txtFechaCambioBusca.TabIndex = 4;
            // 
            // btnBuscaCambio
            // 
            this.btnBuscaCambio.Location = new System.Drawing.Point(298, 36);
            this.btnBuscaCambio.Name = "btnBuscaCambio";
            this.btnBuscaCambio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaCambio.TabIndex = 5;
            this.btnBuscaCambio.Text = "Buscar";
            this.btnBuscaCambio.UseVisualStyleBackColor = true;
            this.btnBuscaCambio.Click += new System.EventHandler(this.btnBuscaCambio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Folio Venta";
            // 
            // txtFolioVentaBusca
            // 
            this.txtFolioVentaBusca.Location = new System.Drawing.Point(345, 70);
            this.txtFolioVentaBusca.Name = "txtFolioVentaBusca";
            this.txtFolioVentaBusca.ReadOnly = true;
            this.txtFolioVentaBusca.Size = new System.Drawing.Size(171, 20);
            this.txtFolioVentaBusca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Motivo";
            // 
            // txtMotivoCambio
            // 
            this.txtMotivoCambio.Location = new System.Drawing.Point(585, 70);
            this.txtMotivoCambio.Name = "txtMotivoCambio";
            this.txtMotivoCambio.ReadOnly = true;
            this.txtMotivoCambio.Size = new System.Drawing.Size(166, 20);
            this.txtMotivoCambio.TabIndex = 34;
            // 
            // dgvLlevados
            // 
            this.dgvLlevados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlevados.Location = new System.Drawing.Point(17, 19);
            this.dgvLlevados.Name = "dgvLlevados";
            this.dgvLlevados.ReadOnly = true;
            this.dgvLlevados.Size = new System.Drawing.Size(337, 136);
            this.dgvLlevados.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Folio Cambio";
            // 
            // txtFolioC
            // 
            this.txtFolioC.Location = new System.Drawing.Point(173, 70);
            this.txtFolioC.Name = "txtFolioC";
            this.txtFolioC.ReadOnly = true;
            this.txtFolioC.Size = new System.Drawing.Size(100, 20);
            this.txtFolioC.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Subtotal";
            // 
            // txtSubtotalReg
            // 
            this.txtSubtotalReg.Location = new System.Drawing.Point(165, 324);
            this.txtSubtotalReg.Name = "txtSubtotalReg";
            this.txtSubtotalReg.ReadOnly = true;
            this.txtSubtotalReg.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalReg.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Subtotal";
            // 
            // txtSubtotalLleva
            // 
            this.txtSubtotalLleva.Location = new System.Drawing.Point(611, 320);
            this.txtSubtotalLleva.Name = "txtSubtotalLleva";
            this.txtSubtotalLleva.ReadOnly = true;
            this.txtSubtotalLleva.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalLleva.TabIndex = 41;
            // 
            // btnRegresarBC
            // 
            this.btnRegresarBC.Location = new System.Drawing.Point(829, 29);
            this.btnRegresarBC.Name = "btnRegresarBC";
            this.btnRegresarBC.Size = new System.Drawing.Size(72, 20);
            this.btnRegresarBC.TabIndex = 42;
            this.btnRegresarBC.Text = "Regresar";
            this.btnRegresarBC.UseVisualStyleBackColor = true;
            this.btnRegresarBC.Click += new System.EventHandler(this.btnRegresarBC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dgvRegresados);
            this.groupBox1.Location = new System.Drawing.Point(68, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 171);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regresados";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dgvLlevados);
            this.groupBox2.Location = new System.Drawing.Point(495, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 171);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Levados";
            // 
            // BuscarCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(926, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarBC);
            this.Controls.Add(this.txtSubtotalLleva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubtotalReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFolioC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMotivoCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFolioVentaBusca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscaCambio);
            this.Controls.Add(this.txtFechaCambioBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCambioBusca);
            this.Name = "BuscarCambio";
            this.Text = "Buscar Cambio";
            this.Load += new System.EventHandler(this.BuscarCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegresados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlevados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCambioBusca;
        private System.Windows.Forms.DataGridView dgvRegresados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaCambioBusca;
        private System.Windows.Forms.Button btnBuscaCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolioVentaBusca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMotivoCambio;
        private System.Windows.Forms.DataGridView dgvLlevados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolioC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubtotalReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotalLleva;
        private System.Windows.Forms.Button btnRegresarBC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}