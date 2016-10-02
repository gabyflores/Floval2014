namespace WindowsFormsApplication1
{
    partial class MostrarVenta
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
            this.dgvMuestraVenta = new System.Windows.Forms.DataGridView();
            this.dgvMuestraDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresaMV = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pboxMostrarVenta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMostrarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuestraVenta
            // 
            this.dgvMuestraVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraVenta.Location = new System.Drawing.Point(25, 38);
            this.dgvMuestraVenta.Name = "dgvMuestraVenta";
            this.dgvMuestraVenta.ReadOnly = true;
            this.dgvMuestraVenta.Size = new System.Drawing.Size(361, 175);
            this.dgvMuestraVenta.TabIndex = 0;
            this.dgvMuestraVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestraVenta_CellClick);
            // 
            // dgvMuestraDetalle
            // 
            this.dgvMuestraDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuestraDetalle.Location = new System.Drawing.Point(37, 23);
            this.dgvMuestraDetalle.Name = "dgvMuestraDetalle";
            this.dgvMuestraDetalle.ReadOnly = true;
            this.dgvMuestraDetalle.Size = new System.Drawing.Size(324, 175);
            this.dgvMuestraDetalle.TabIndex = 1;
            this.dgvMuestraDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuestraDetalle_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvMuestraVenta);
            this.groupBox1.Location = new System.Drawing.Point(42, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Para ver los articulos de la venta de click en el folio";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvMuestraDetalle);
            this.groupBox2.Location = new System.Drawing.Point(481, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 228);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos por Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para ver la Imagen de click en el ID";
            // 
            // btnRegresaMV
            // 
            this.btnRegresaMV.Location = new System.Drawing.Point(951, 21);
            this.btnRegresaMV.Name = "btnRegresaMV";
            this.btnRegresaMV.Size = new System.Drawing.Size(75, 23);
            this.btnRegresaMV.TabIndex = 4;
            this.btnRegresaMV.Text = "Regresar";
            this.btnRegresaMV.UseVisualStyleBackColor = true;
            this.btnRegresaMV.Click += new System.EventHandler(this.btnRegresaMV_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.pboxMostrarVenta);
            this.groupBox3.Location = new System.Drawing.Point(898, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 183);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // pboxMostrarVenta
            // 
            this.pboxMostrarVenta.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.pboxMostrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxMostrarVenta.Location = new System.Drawing.Point(28, 30);
            this.pboxMostrarVenta.Name = "pboxMostrarVenta";
            this.pboxMostrarVenta.Size = new System.Drawing.Size(100, 128);
            this.pboxMostrarVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMostrarVenta.TabIndex = 5;
            this.pboxMostrarVenta.TabStop = false;
            // 
            // MostrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1066, 337);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegresaMV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MostrarVenta";
            this.Text = "MostrarVenta";
            this.Load += new System.EventHandler(this.MostrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuestraDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMostrarVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuestraVenta;
        private System.Windows.Forms.DataGridView dgvMuestraDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegresaMV;
        private System.Windows.Forms.PictureBox pboxMostrarVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}