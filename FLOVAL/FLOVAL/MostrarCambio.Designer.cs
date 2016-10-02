namespace WindowsFormsApplication1
{
    partial class MostrarCambio
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
            this.dgvMuestraCambio = new System.Windows.Forms.DataGridView();
            this.dgvMuestraDetalleCambio = new System.Windows.Forms.DataGridView();
            this.btnRegresaMC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetalleCambio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMuestraCambio
            // 
            this.dgvMuestraCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraCambio.Location = new System.Drawing.Point(27, 29);
            this.dgvMuestraCambio.Name = "dgvMuestraCambio";
            this.dgvMuestraCambio.Size = new System.Drawing.Size(439, 180);
            this.dgvMuestraCambio.TabIndex = 0;
            this.dgvMuestraCambio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestraCambio_CellClick);
            // 
            // dgvMuestraDetalleCambio
            // 
            this.dgvMuestraDetalleCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraDetalleCambio.Location = new System.Drawing.Point(19, 35);
            this.dgvMuestraDetalleCambio.Name = "dgvMuestraDetalleCambio";
            this.dgvMuestraDetalleCambio.ReadOnly = true;
            this.dgvMuestraDetalleCambio.Size = new System.Drawing.Size(386, 169);
            this.dgvMuestraDetalleCambio.TabIndex = 1;
            // 
            // btnRegresaMC
            // 
            this.btnRegresaMC.Location = new System.Drawing.Point(854, 21);
            this.btnRegresaMC.Name = "btnRegresaMC";
            this.btnRegresaMC.Size = new System.Drawing.Size(75, 23);
            this.btnRegresaMC.TabIndex = 2;
            this.btnRegresaMC.Text = "Regresar";
            this.btnRegresaMC.UseVisualStyleBackColor = true;
            this.btnRegresaMC.Click += new System.EventHandler(this.btnRegresaMC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvMuestraCambio);
            this.groupBox1.Location = new System.Drawing.Point(27, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "De click en el folio m para mostrar los articulos por Cambio";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.dgvMuestraDetalleCambio);
            this.groupBox2.Location = new System.Drawing.Point(549, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 237);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos por Cambio";
            // 
            // MostrarCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresaMC);
            this.Name = "MostrarCambio";
            this.Text = "Mostrar Cambio";
            this.Load += new System.EventHandler(this.MostrarCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetalleCambio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestraCambio;
        private System.Windows.Forms.DataGridView dgvMuestraDetalleCambio;
        private System.Windows.Forms.Button btnRegresaMC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}