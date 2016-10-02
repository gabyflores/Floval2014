using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApplication1
{
    public partial class AgregarPedido : Form
    {
        public AgregarPedido()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //this.txtIdClientePedido.Focus();
        }
       
        DataTable pedido = new DataTable();
        
        private void AgregarPedido_Load(object sender, EventArgs e)
        {
            try
            {
                //this.WindowState = FormWindowState.Maximized;
                //this.txtIdClientePedido.Focus();
                lblFechaPedido.Text = DateTime.Now.ToLongDateString();
                pedido.Columns.Add("ID");
                pedido.Columns.Add("Producto");
                pedido.Columns.Add("Cantidad");
                pedido.Columns.Add("Precio");
                pedido.Columns.Add("Importe");

                dgvRP.DataSource = pedido.DefaultView;
                groupBox1.Focus();
                try
                {
                    int x1 = 0;
                    int foliopedidoRP;

                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                    conexion.Open();

                    IDbCommand dbcmd2 = conexion.CreateCommand();
                    dbcmd2.CommandText = "select * from Pedido order by idpedido desc limit 1";
                    IDataReader reader2 = dbcmd2.ExecuteReader();
                    conexion.Close();

                    if (reader2.Read())
                    {
                        foliopedidoRP = reader2.GetInt32(reader2.GetOrdinal("idpedido"));
                        x1 = foliopedidoRP;
                        x1 += 1;
                        lblFolioPedido.Text = Convert.ToString(x1);


                    }
                    else
                    {

                        x1 = 1;
                        lblFolioPedido.Text = Convert.ToString(x1);

                    }



                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.ToString());
                }
            }
            catch (Exception msg) {

                MessageBox.Show(msg.ToString());
            }

        }

        
        int np,existp;
        private void txtIdProductoRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtIdProductoRP.Text == "")
                    {

                        MessageBox.Show("DEBES INTRODUCIR EL ID DEL PRODUCTO....");
                        txtIdProductoRP.Focus();
                    }
                    else
                    {
                        try
                        {

                            IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                            "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon.Open();
                            np = Convert.ToInt32(txtIdProductoRP.Text);
                            IDbCommand dbcmd = dbcon.CreateCommand();

                            dbcmd.CommandText = "select * from Producto where idproducto=" + np + "";
                            IDataReader reader = dbcmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtProductoRP.Text = reader.GetString(reader.GetOrdinal("producto"));
                                txtPrecioRP.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("precio")));
                                existp = reader.GetInt32(reader.GetOrdinal("cantidadp"));
                                string nombreimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                                pboxAgregarPedido.Image = new Bitmap(nombreimagen);

                                //txtIdProductoRP.Text = "";
                                dbcon.Close();
                                txtCantidadRP.Focus();
                            }
                            else
                            {
                                txtIdProductoRP.Text = "";
                                txtProductoRP.Text = "";
                                txtPrecioRP.Text = "";
                                MessageBox.Show("Producto no encontrado");
                            }



                        }
                        catch (Exception msg)
                        {
                            MessageBox.Show(msg.ToString());
                        }
                    }
                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void txtIdClientePedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtIdClientePedido.Text == "")
                    {

                        MessageBox.Show("Debe Introducir ID  del cliente");

                    }
                    else
                    {

                        try
                        {
                            int idclienteRP = Convert.ToInt32(txtIdClientePedido.Text);
                            string nombreclienteRP, rfcCliente;
                            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            conexion.Open();
                            NpgsqlCommand comando = conexion.CreateCommand();
                            comando.CommandText = "select * from Cliente where idcliente=" + idclienteRP + "";
                            IDataReader lector = comando.ExecuteReader();
                            int banderaencontradocliente = 0;
                            if (lector.Read())
                            {

                                nombreclienteRP = lector.GetString(lector.GetOrdinal("nombrec"));
                                txtNombreClientePedido.Text = nombreclienteRP;
                                rfcCliente = lector.GetString(lector.GetOrdinal("rfccliente"));
                                txtRFCPedido.Text = rfcCliente;
                                banderaencontradocliente = 1;

                            }
                            if (banderaencontradocliente == 0)
                            {
                                if (MessageBox.Show("El Id de Cliente no Existe, ¿Desea Agregar al Cliente?", "Agregar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {

                                    RegistroCliente nvocliente = new RegistroCliente();
                                    nvocliente.Show();
                                }
                                else
                                {

                                    txtIdClientePedido.Focus();
                                }
                            }

                        }
                        catch (Exception msg)
                        {
                            MessageBox.Show(msg.ToString());

                        }



                    }

                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            
            }
        }

        int ip=0,cantidadpiezasRP,nProductoP;
        double subtotalRP,pordesRP,desRP,desRP1;

        private void txtCantidadRP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtCantidadRP.Text == "" || txtIdProductoRP.Text=="")
                    {
                        MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD....");
                        txtCantidadRP.Focus();
                    }
                    else
                    {

                        if (Convert.ToInt32(txtCantidadRP.Text) <= existp)
                        {

                            if (MessageBox.Show("DESEAS AGREGAR EL ARTICULO AL PEDIDO", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                pedido.Rows.Add();
                                dgvRP.Rows[ip].Cells[0].Value = np;
                                dgvRP.Rows[ip].Cells[1].Value = txtProductoRP.Text;
                                dgvRP.Rows[ip].Cells[2].Value = txtCantidadRP.Text;
                                dgvRP.Rows[ip].Cells[3].Value = txtPrecioRP.Text;
                                dgvRP.Rows[ip].Cells[4].Value = Convert.ToDouble(txtPrecioRP.Text) * Convert.ToDouble(txtCantidadRP.Text);
                                subtotalRP = subtotalRP + Convert.ToDouble(dgvRP.Rows[ip].Cells[4].Value);
                                txtSubtotalRP.Text = Convert.ToString(subtotalRP);
                                cantidadpiezasRP = cantidadpiezasRP + Convert.ToInt32(dgvRP.Rows[ip].Cells[2].Value);
                                txtCantidadPiezasRP.Text = Convert.ToString(cantidadpiezasRP);
                                // txtIVARV.Text = Convert.ToString(subtotal * .16);
                                // txtTotalRV.Text = Convert.ToString(subtotal * 1.16);
                                dgvRP.Refresh();
                                //txtIdProductoRP.Text = "";
                                txtPrecioRP.Text = "";
                                txtCantidadRP.Text = "";
                                txtPrecioRP.Text = "";
                                txtProductoRP.Text = "";
                                txtIdProductoRP.Text = "";
                                txtIdProductoRP.Focus();
                                ip++;

                                if (cantidadpiezasRP < 3)
                                {


                                    pordesRP = 0;
                                    desRP = subtotalRP * 0;
                                    desRP1 = subtotalRP - desRP;

                                    txtporcRP.Text = Convert.ToString(pordesRP);
                                    txtDescRP.Text = Convert.ToString(desRP);
                                    txtDescCantRP.Text = Convert.ToString(desRP1);
                                    txtIvaRP.Text = Convert.ToString(subtotalRP * .16);
                                    txtTotalRP.Text = Convert.ToString(subtotalRP * 1.16);
                                }
                                if (cantidadpiezasRP >= 3)
                                {


                                    pordesRP = 10;
                                    desRP = subtotalRP * .10;
                                    desRP1 = subtotalRP - desRP;

                                    txtporcRP.Text = Convert.ToString(pordesRP);
                                    txtDescRP.Text = Convert.ToString(desRP);
                                    txtDescCantRP.Text = Convert.ToString(desRP1);
                                    txtIvaRP.Text = Convert.ToString(desRP1 * .16);
                                    txtTotalRP.Text = Convert.ToString(desRP1 * 1.16);


                                }
                                if (cantidadpiezasRP >= 6)
                                {


                                    pordesRP = 20;
                                    desRP = subtotalRP * .20;
                                    desRP1 = subtotalRP - desRP;

                                    txtporcRP.Text = Convert.ToString(pordesRP);
                                    txtDescRP.Text = Convert.ToString(desRP);
                                    txtDescCantRP.Text = Convert.ToString(desRP1);
                                    txtIvaRP.Text = Convert.ToString(desRP1 * .16);
                                    txtTotalRP.Text = Convert.ToString(desRP1 * 1.16);
                                }
                            }
                            else
                            {
                                txtProductoRP.Text = "";
                                txtPrecioRP.Text = "";
                                txtCantidadRP.Text = "";
                                txtIdProductoRP.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("EXCEDES LA EXISTENCIA, LA DISPONIBILIDAD ES DE " + existp + " PRODUCTOS");
                            txtCantidadRP.Text = "";
                            txtCantidadRP.Focus();
                        }



                    }


                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            
            }
        }

        string fechapagado,fechasurtido, fechaentregado;
        private void cmbPagado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPagado.Text == "1")
                {
                    dtpPagado.Enabled = true;
                    fechapagado = Convert.ToString(dtpPagado.Value.ToShortDateString());
                }
                else
                    fechapagado = "0000-00-00";
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void cmbSurtido_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSurtido.Text == "1")
                {
                    dtpSurtido.Enabled = true;
                    fechasurtido = Convert.ToString(dtpSurtido.Value.ToShortDateString());
                }
                else
                    fechasurtido = "0000-00-00";
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            
            }
        }

        private void cmbEntregado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEntregado.Text == "1")
                {
                    dtpEntregado.Enabled = true;
                    fechaentregado = Convert.ToString(dtpEntregado.Value.ToShortDateString());
                }
                else
                    fechaentregado = "0000-00-00";
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnGrabarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEAS GRABAR LA COMPRA", "CONFIRMACIÓN", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (ip > 0)
                    {
                        try
                        {

                            int folioRP = Convert.ToInt32(lblFolioPedido.Text);
                            int tipopedido = Convert.ToInt32(txtTipoPedido.Text);
                            string fechapedido = DateTime.Now.ToShortDateString();
                            double pordescRP = Convert.ToDouble(txtporcRP.Text);
                            //pordesRP
                            int idclienteRP = Convert.ToInt32(txtIdClientePedido.Text);
                            int estadopago = Convert.ToInt32(cmbPagado.Text);
                            int estadosurtido = Convert.ToInt32(cmbSurtido.Text);
                            int estadoentregado = Convert.ToInt32(cmbEntregado.Text);
                            string formapago = cmbFPRP.Text;

                            //-------------------------------------INSERTA NORMAL EN VENTA---------------------------------------------       


                            IDbConnection dbcon1 = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            dbcon1.Open();
                            IDbCommand dbcmd1 = dbcon1.CreateCommand();
                            dbcmd1.CommandText = "insert into Pedido values(" + folioRP + ",'" + tipopedido + "'," + pordescRP + "," + 16 + "," + idclienteRP + ",'" + fechapagado + "','" + fechasurtido + "','" + fechaentregado + "','" + formapago + "'," + estadopago + "," + estadosurtido + "," + estadoentregado + ",'" + fechapedido + "')";
                            IDataReader reader1 = dbcmd1.ExecuteReader();
                            //dbcon1.Close();
                            //-----------------------------------INSERTA DETALLE-------------------------------------------------------

                            int a = ip, b = 0;

                            while (b != a)
                            {

                                int foliodetalle = Convert.ToInt32(lblFolioPedido.Text);
                                int idproductodetalle = Convert.ToInt32(dgvRP.Rows[b].Cells[0].Value);
                                int cantidadetalle = Convert.ToInt32(dgvRP.Rows[b].Cells[2].Value);
                                double costodetalle = Convert.ToDouble(dgvRP.Rows[b].Cells[3].Value);


                                IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                dbcmd3.CommandText = "insert into DetallePedido values(" + foliodetalle + "," + idproductodetalle + "," + cantidadetalle + "," + costodetalle + ")";
                                IDataReader reader3 = dbcmd3.ExecuteReader();

                                b++;


                            }
                            dbcon1.Close();
                            //------------------------------------MODIFICA EXISTENCIA-------------------------------------------------------

                            int contador = 0, existnew;
                            NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                            "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon.Open();

                            while (ip != contador)
                            {
                                nProductoP = Convert.ToInt32(dgvRP.Rows[contador].Cells[0].Value);
                                existnew = Convert.ToInt32(dgvRP.Rows[contador].Cells[2].Value);
                                string queryUp = "update Producto set cantidadp=cantidadp-" + existnew + " where idproducto=" + nProductoP + "";
                                NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                cmdUp.ExecuteNonQuery();
                                contador++;

                            }
                            MessageBox.Show("PEDIDO REALIZADO CON EXITO.....");
                            dbcon.Close();
                            pedido.Rows.Clear();

                            //x.Rows.Clear();
                            //txtTipoPedido.Text = "";
                            txtIdClientePedido.Text = "";
                            txtNombreClientePedido.Text = "";
                            txtRFCPedido.Text = "";
                            txtIdProductoRP.Text = "";
                            txtProductoRP.Text = "";
                            txtPrecioRP.Text = "";
                            txtCantidadRP.Text = "";
                            cmbPagado.Text = "";
                            cmbSurtido.Text = "";
                            cmbPagado.Text = "";
                            cmbFPRP.Text = "";
                            txtSubtotalRP.Text = "";
                            txtDescCantRP.Text = "";
                            txtDescRP.Text = "";
                            txtporcRP.Text = "";
                            txtIvaRP.Text = "";
                            txtTotalRP.Text = "";
                            dtpEntregado.Text = "";

                            subtotalRP = 0;
                            ip = 0;


                            //-------------------- INSERTA FOLIO----------------------------------------  
                            IDbConnection dbcon2 = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon2.Open();
                            IDbCommand dbcmd2 = dbcon2.CreateCommand();
                            dbcmd2.CommandText = "select * from Pedido order by idpedido desc limit 1";
                            IDataReader reader2 = dbcmd2.ExecuteReader();
                            reader2.Read();
                            dbcon2.Close();

                            int x1;
                            x1 = reader2.GetInt32(reader2.GetOrdinal("idpedido"));
                            x1 = x1 + 1;

                            lblFolioPedido.Text = Convert.ToString(x1);

                            //-----------------Metodo para imprimir-----------------------------------
                            // imprimirfactura();

                        }
                        catch (Exception msg)
                        {
                            MessageBox.Show(msg.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("PRIMERO DEBES INTRODUCIR PRODUCTOS.....");
                    }
                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

       
            
            
            
        

        private void btnRegresaRP_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        }
    }
