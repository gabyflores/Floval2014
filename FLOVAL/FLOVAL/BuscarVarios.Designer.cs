namespace WindowsFormsApplication1
{
    partial class BuscarVarios
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
            this.comboBuscaVariosP = new System.Windows.Forms.ComboBox();
            this.txtBuscaVarios = new System.Windows.Forms.TextBox();
            this.dgvBuscaVarios = new System.Windows.Forms.DataGridView();
            this.btnRegresaBuscaVarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pboxBuscaVariosProductos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaVarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBuscaVariosProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBuscaVariosP
            // 
            this.comboBuscaVariosP.FormattingEnabled = true;
            this.comboBuscaVariosP.Items.AddRange(new object[] {
            "",
            "Existencia",
            "Precio",
            "Costo"});
            this.comboBuscaVariosP.Location = new System.Drawing.Point(102, 22);
            this.comboBuscaVariosP.Name = "comboBuscaVariosP";
            this.comboBuscaVariosP.Size = new System.Drawing.Size(121, 21);
            this.comboBuscaVariosP.TabIndex = 0;
            // 
            // txtBuscaVarios
            // 
            this.txtBuscaVarios.Location = new System.Drawing.Point(102, 62);
            this.txtBuscaVarios.Name = "txtBuscaVarios";
            this.txtBuscaVarios.Size = new System.Drawing.Size(121, 20);
            this.txtBuscaVarios.TabIndex = 1;
            this.txtBuscaVarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaVarios_KeyPress);
            // 
            // dgvBuscaVarios
            // 
            this.dgvBuscaVarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaVarios.Location = new System.Drawing.Point(36, 29);
            this.dgvBuscaVarios.Name = "dgvBuscaVarios";
            this.dgvBuscaVarios.Size = new System.Drawing.Size(496, 194);
            this.dgvBuscaVarios.TabIndex = 2;
            this.dgvBuscaVarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaVarios_CellClick);
            // 
            // btnRegresaBuscaVarios
            // 
            this.btnRegresaBuscaVarios.Location = new System.Drawing.Point(628, 12);
            this.btnRegresaBuscaVarios.Name = "btnRegresaBuscaVarios";
            this.btnRegresaBuscaVarios.Size = new System.Drawing.Size(75, 23);
            this.btnRegresaBuscaVarios.TabIndex = 3;
            this.btnRegresaBuscaVarios.Text = "Regresar";
            this.btnRegresaBuscaVarios.UseVisualStyleBackColor = true;
            this.btnRegresaBuscaVarios.Click += new System.EventHandler(this.btnRegresaBuscaVarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese una caracteristica y de enter";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.comboBuscaVariosP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscaVarios);
            this.groupBox1.Location = new System.Drawing.Point(55, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvBuscaVarios);
            this.groupBox2.Location = new System.Drawing.Point(37, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 242);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encontrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "De click en el ID para mostrat la Imagen";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.pboxBuscaVariosProductos);
            this.groupBox3.Location = new System.Drawing.Point(412, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 132);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen";
            // 
            // pboxBuscaVariosProductos
            // 
            this.pboxBuscaVariosProductos.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bolsa1;
            this.pboxBuscaVariosProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxBuscaVariosProductos.Location = new System.Drawing.Point(19, 19);
            this.pboxBuscaVariosProductos.Name = "pboxBuscaVariosProductos";
            this.pboxBuscaVariosProductos.Size = new System.Drawing.Size(166, 100);
            this.pboxBuscaVariosProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBuscaVariosProductos.TabIndex = 8;
            this.pboxBuscaVariosProductos.TabStop = false;
            // 
            // BuscarVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresaBuscaVarios);
            this.Name = "BuscarVarios";
            this.Text = "BuscarVarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaVarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBuscaVariosProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBuscaVariosP;
        private System.Windows.Forms.TextBox txtBuscaVarios;
        private System.Windows.Forms.DataGridView dgvBuscaVarios;
        private System.Windows.Forms.Button btnRegresaBuscaVarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pboxBuscaVariosProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}