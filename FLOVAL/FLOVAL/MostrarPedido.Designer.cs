namespace WindowsFormsApplication1
{
    partial class MostrarPedido
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
            this.dgvMuestraPedido = new System.Windows.Forms.DataGridView();
            this.dgvMuetraDetallePedido = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresarMP = new System.Windows.Forms.Button();
            this.pboxPedidoMuestra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuetraDetallePedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPedidoMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestraPedido
            // 
            this.dgvMuestraPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraPedido.Location = new System.Drawing.Point(24, 19);
            this.dgvMuestraPedido.Name = "dgvMuestraPedido";
            this.dgvMuestraPedido.ReadOnly = true;
            this.dgvMuestraPedido.Size = new System.Drawing.Size(510, 208);
            this.dgvMuestraPedido.TabIndex = 0;
            this.dgvMuestraPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestraPedido_CellClick);
            // 
            // dgvMuetraDetallePedido
            // 
            this.dgvMuetraDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuetraDetallePedido.Location = new System.Drawing.Point(26, 20);
            this.dgvMuetraDetallePedido.Name = "dgvMuetraDetallePedido";
            this.dgvMuetraDetallePedido.ReadOnly = true;
            this.dgvMuetraDetallePedido.Size = new System.Drawing.Size(352, 188);
            this.dgvMuetraDetallePedido.TabIndex = 1;
            this.dgvMuetraDetallePedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuetraDetallePedido_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvMuestraPedido);
            this.groupBox1.Location = new System.Drawing.Point(28, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Para ver los articulos de la venta de click en el folio";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvMuetraDetallePedido);
            this.groupBox2.Location = new System.Drawing.Point(638, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos por Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para ver la Imagen de click en el ID";
            // 
            // btnRegresarMP
            // 
            this.btnRegresarMP.Location = new System.Drawing.Point(941, 21);
            this.btnRegresarMP.Name = "btnRegresarMP";
            this.btnRegresarMP.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarMP.TabIndex = 4;
            this.btnRegresarMP.Text = "Regresar";
            this.btnRegresarMP.UseVisualStyleBackColor = true;
            this.btnRegresarMP.Click += new System.EventHandler(this.btnRegresarMP_Click);
            // 
            // pboxPedidoMuestra
            // 
            this.pboxPedidoMuestra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxPedidoMuestra.Location = new System.Drawing.Point(1069, 90);
            this.pboxPedidoMuestra.Name = "pboxPedidoMuestra";
            this.pboxPedidoMuestra.Size = new System.Drawing.Size(119, 147);
            this.pboxPedidoMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPedidoMuestra.TabIndex = 5;
            this.pboxPedidoMuestra.TabStop = false;
            // 
            // MostrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.ClientSize = new System.Drawing.Size(1231, 359);
            this.Controls.Add(this.pboxPedidoMuestra);
            this.Controls.Add(this.btnRegresarMP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MostrarPedido";
            this.Text = "Mostrar Pedido";
            this.Load += new System.EventHandler(this.MostrarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuetraDetallePedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPedidoMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestraPedido;
        private System.Windows.Forms.DataGridView dgvMuetraDetallePedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegresarMP;
        private System.Windows.Forms.PictureBox pboxPedidoMuestra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}