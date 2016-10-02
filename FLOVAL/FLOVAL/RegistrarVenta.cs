using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class RegistrarVenta : Form
    {
        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            try
            {
                lblfechaRV.Text = DateTime.Now.ToLongDateString();
                x.Columns.Add("ID");
                x.Columns.Add("Producto");
                x.Columns.Add("Cantidad");
                x.Columns.Add("Precio");
                x.Columns.Add("Importe");

                dgvRV.DataSource = x.DefaultView;
                txtClienteRV.Focus();
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }

            try
            {
                int x1 = 0;
                int folioventaRV;

                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                conexion.Open();

                IDbCommand dbcmd2 = conexion.CreateCommand();
                dbcmd2.CommandText = "select * from Venta order by folioventa desc limit 1";
                IDataReader reader2 = dbcmd2.ExecuteReader();
                conexion.Close();

                if (reader2.Read())
                {
                    folioventaRV = reader2.GetInt32(reader2.GetOrdinal("folioventa"));
                    x1 = folioventaRV;
                    x1 += 1;
                    lblFolioVenta.Text = Convert.ToString(x1);


                }
                else
                {

                    x1 = 1;
                    lblFolioVenta.Text = Convert.ToString(x1);

                }



            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        int exist;
        int n;
        DataTable x = new DataTable();
        private void txtIdProductoRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtIdProductoRV.Text == "")
                    {

                        MessageBox.Show("DEBES INTRODUCIR EL ID DEL PRODUCTO....");
                        txtIdProductoRV.Focus();
                    }
                    else
                    {
                        try
                        {

                            IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                            "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon.Open();
                            n = Convert.ToInt32(txtIdProductoRV.Text);
                            IDbCommand dbcmd = dbcon.CreateCommand();

                            dbcmd.CommandText = "select * from Producto where idproducto=" + n + "";
                            IDataReader reader = dbcmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtProductoRV.Text = reader.GetString(reader.GetOrdinal("producto"));
                                txtPrecioRV.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("precio")));
                                exist = reader.GetInt32(reader.GetOrdinal("cantidadp"));
                                string imagenRV = reader.GetString(reader.GetOrdinal("rutaimagen"));
                                pbRV.Image = new Bitmap(imagenRV);
                                txtIdProductoRV.Text = "";
                                dbcon.Close();
                                txtCantidadRV.Focus();

                            }
                            else
                            {
                                txtIdProductoRV.Text = "";
                                txtProductoRV.Text = "";
                                txtPrecioRV.Text = "";
                                MessageBox.Show("Producto no encontrado");
                            }



                        }
                        catch (Exception msg)
                        {
                            MessageBox.Show(msg.ToString());
                        }



                    }

                }//keychar
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        private void btnGrabarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEAS GRABAR LA FACTURA", "CONFIRMACIÓN", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (i > 0 && txtClienteRV.Text != "" && txtNombreClienteRV.Text != "")
                    {
                        try
                        {

                            int folioRV = Convert.ToInt32(lblFolioVenta.Text);
                            //int tipoventaRV=Convert.ToString(txtTipoRV);
                            //double porcentajeRV=
                            int idclienteRV = Convert.ToInt32(txtClienteRV.Text);
                            string fechaventa = DateTime.Now.ToLongDateString();

                            //-------------------------------------INSERTA NORMAL EN VENTA---------------------------------------------       


                            IDbConnection dbcon1 = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            dbcon1.Open();
                            IDbCommand dbcmd1 = dbcon1.CreateCommand();
                            dbcmd1.CommandText = "insert into Venta values(" + folioRV + "," + tipoventa + ",'" + fechaventa + "'," + pordesRV + "," + 16 + "," + idclienteRV + ")";
                            IDataReader reader1 = dbcmd1.ExecuteReader();
                            //dbcon1.Close();
                            //-----------------------------------INSERTA DETALLE-------------------------------------------------------

                            int a = i, b = 0;

                            while (b != a)
                            {

                                int foliodetalle = Convert.ToInt32(lblFolioVenta.Text);
                                int idproductodetalle = Convert.ToInt32(dgvRV.Rows[b].Cells[0].Value);
                                int cantidadetalle = Convert.ToInt32(dgvRV.Rows[b].Cells[2].Value);
                                double preciodetalle = Convert.ToDouble(dgvRV.Rows[b].Cells[3].Value);


                                IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                dbcmd3.CommandText = "insert into DetalleVenta values(" + foliodetalle + "," + idproductodetalle + "," + cantidadetalle + "," + preciodetalle + ")";
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

                            while (i != contador)
                            {
                                n = Convert.ToInt32(dgvRV.Rows[contador].Cells[0].Value);
                                existnew = Convert.ToInt32(dgvRV.Rows[contador].Cells[2].Value);
                                string queryUp = "update Producto set cantidadp=cantidadp-" + existnew + " where idproducto=" + n + "";
                                NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                cmdUp.ExecuteNonQuery();
                                contador++;

                            }
                            MessageBox.Show("VENTA REALIZADA CON EXITO.....");
                            dbcon.Close();
                            //x.Rows.Clear();
                            txtIdProductoRV.Focus();
                            txtSubtotalRV.Text = "";
                            txtIVARV.Text = "";
                            txtPorcDescRV.Text = "";
                            txtTipoRV.Text = "";
                            txtDescuentoRV.Text = "";
                            txtCantidadPiezasRV.Text = "";
                            txtDescRV.Text = "";
                            txtTotalRV.Text = "";
                            txtClienteRV.Text = "";
                            txtNombreClienteRV.Text = "";
                            subtotal = 0;
                            i = 0;


                            //-------------------- INSERTA FOLIO----------------------------------------  
                            IDbConnection dbcon2 = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon2.Open();
                            IDbCommand dbcmd2 = dbcon2.CreateCommand();
                            dbcmd2.CommandText = "select * from Venta order by folioventa desc limit 1";
                            IDataReader reader2 = dbcmd2.ExecuteReader();
                            reader2.Read();
                            dbcon2.Close();

                            int x1;
                            x1 = reader2.GetInt32(reader2.GetOrdinal("folioventa"));
                            x1 = x1 + 1;

                            lblFolioVenta.Text = Convert.ToString(x1);

                            //-----------------Metodo para imprimir-----------------------------------
                            imprimirfactura();
                            x.Rows.Clear();

                        }
                        catch (Exception msg)
                        {
                            MessageBox.Show(msg.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("PRIMERO DEBES INTRODUCIR PRODUCTOS Y UN CLIENTE VALIDO.....");
                    }
                }
                else
                {
                    txtIdProductoRV.Focus();
                    txtSubtotalRV.Text = "";
                    txtIVARV.Text = "";
                    txtPorcDescRV.Text = "";
                    txtTipoRV.Text = "";
                    txtDescuentoRV.Text = "";
                    txtCantidadPiezasRV.Text = "";
                    txtDescRV.Text = "";
                    txtTotalRV.Text = "";
                    txtClienteRV.Text = "";
                    txtNombreClienteRV.Text = "";
                    subtotal = 0;
                    i = 0;
                    x.Rows.Clear();
                
                
                
                
                }
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        
        
        
        int i,tipoventa;
        double subtotal,pordesRV,desRV,desRV1;
        int cantidadpiezasRV;
        
        
        
        private void txtCantidadRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtCantidadRV.Text == "")
                    {
                        MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD....");
                        txtCantidadRV.Focus();
                    }
                    else
                    {

                        if (Convert.ToInt32(txtCantidadRV.Text) <= exist)
                        {

                            if (MessageBox.Show("DESEAS AGREGAR EL ARTICULO A LA VENTA", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                x.Rows.Add();
                                dgvRV.Rows[i].Cells[0].Value = n;
                                dgvRV.Rows[i].Cells[1].Value = txtProductoRV.Text;
                                dgvRV.Rows[i].Cells[2].Value = txtCantidadRV.Text;
                                dgvRV.Rows[i].Cells[3].Value = txtPrecioRV.Text;
                                dgvRV.Rows[i].Cells[4].Value = Convert.ToDouble(txtPrecioRV.Text) * Convert.ToDouble(txtCantidadRV.Text);
                                subtotal = subtotal + Convert.ToDouble(dgvRV.Rows[i].Cells[4].Value);
                                txtSubtotalRV.Text = Convert.ToString(subtotal);
                                cantidadpiezasRV = cantidadpiezasRV + Convert.ToInt32(dgvRV.Rows[i].Cells[2].Value);
                                txtCantidadPiezasRV.Text = Convert.ToString(cantidadpiezasRV);
                                // txtIVARV.Text = Convert.ToString(subtotal * .16);
                                // txtTotalRV.Text = Convert.ToString(subtotal * 1.16);
                                dgvRV.Refresh();
                                txtIdProductoRV.Text = "";
                                txtProductoRV.Text = "";
                                txtPrecioRV.Text = "";
                                txtCantidadRV.Text = "";
                                txtPrecioRV.Text = "";
                                txtIdProductoRV.Focus();
                                i++;

                                if (cantidadpiezasRV < 3)
                                {

                                    tipoventa = 1;
                                    pordesRV = 0;
                                    desRV = subtotal * 0;
                                    desRV1 = subtotal - desRV;
                                    txtTipoRV.Text = Convert.ToString(tipoventa);
                                    txtPorcDescRV.Text = Convert.ToString(pordesRV);
                                    txtDescuentoRV.Text = Convert.ToString(desRV);
                                    txtDescRV.Text = Convert.ToString(desRV1);
                                    txtIVARV.Text = Convert.ToString(subtotal * .16);
                                    txtTotalRV.Text = Convert.ToString(subtotal * 1.16);
                                }
                                if (cantidadpiezasRV >= 3)
                                {
                                    tipoventa = 2;
                                    pordesRV = 10;
                                    pordesRV = 10;
                                    desRV = subtotal * .10;
                                    desRV1 = subtotal - desRV;
                                    txtTipoRV.Text = Convert.ToString(tipoventa);
                                    txtPorcDescRV.Text = Convert.ToString(pordesRV);
                                    txtDescuentoRV.Text = Convert.ToString(desRV);
                                    txtDescRV.Text = Convert.ToString(desRV1);
                                    txtIVARV.Text = Convert.ToString(desRV1 * .16);
                                    txtTotalRV.Text = Convert.ToString(desRV1 * 1.16);


                                }
                                if (cantidadpiezasRV >= 6)
                                {

                                    tipoventa = 2;
                                    pordesRV = 20;
                                    desRV = subtotal * .20;
                                    desRV1 = subtotal - desRV;
                                    txtTipoRV.Text = Convert.ToString(tipoventa);
                                    txtPorcDescRV.Text = Convert.ToString(pordesRV);
                                    txtDescuentoRV.Text = Convert.ToString(desRV);
                                    txtDescRV.Text = Convert.ToString(desRV1);
                                    txtIVARV.Text = Convert.ToString(desRV1 * .16);
                                    txtTotalRV.Text = Convert.ToString(desRV1 * 1.16);
                                }
                            }
                            else
                            {
                                txtIdProductoRV.Text = "";
                                txtProductoRV.Text = "";
                                txtClienteRV.Text = "";
                                txtNombreClienteRV.Text = "";
                                txtPrecioRV.Text = "";
                                txtCantidadRV.Text = "";
                                txtPrecioRV.Text = "";
                                txtIdProductoRV.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("EXCEDES LA EXISTENCIA, LA DISPONIBILIDAD ES DE " + exist + " PRODUCTOS");
                            txtCantidadRV.Text = "";
                            txtCantidadRV.Focus();
                        }



                    }


                }
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); 
            }
        }//fin de key press

      

       public void imprimirfactura() {
           try
           {
               if (MessageBox.Show("¿Desea Imprimir Ticket?", "Imprimir Ticket", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {

                   imprimirSolicitud();

               }
               else
                   x.Rows.Clear();
           }
           catch (Exception msg) { 
           MessageBox.Show(msg.ToString());
           }
       }

        

       public void impresion(object objeto,PrintPageEventArgs evento) {
           try
           {
               float x = 10;
               float y = 20;
               Font fuente = new Font("Arial", 14);

               int busqueda = Convert.ToInt32(lblFolioVenta.Text);
               int busqueda2 = busqueda - 1;

               IDbConnection conexion = new NpgsqlConnection("Server=localhost;"
                          + "Database=Bolsa;" +
                          "User ID=gabrielaflores;" + "Port=5344");
               conexion.Open();
               IDbCommand dbcmd2 = conexion.CreateCommand();
               dbcmd2.CommandText = "select * from Venta join Cliente on idclientev=idcliente where folioventa=" + busqueda2 + "";
               IDataReader reader2 = dbcmd2.ExecuteReader();
               // reader2.Read();
               conexion.Close();
               //"select * from Venta join Cliente on idclientev=idcliente join DetalleVenta on folioventa=folioventad where folioventa="+busqueda2+""
               if (reader2.Read())
               {

                   //-----------------------------------Datos Factura---------------------------------------------
                   string FolioVentaI = lblFolioVenta.Text;
                   string FechaVentaI = lblfechaRV.Text;
                   string TipoVentaI = txtTipoRV.Text;
                   //----------------------------------Datos Venta-----------------------------------------------
                   string porcentajeDes = Convert.ToString(reader2.GetDouble(reader2.GetOrdinal("porcentajedesv")));
                   string ivaVenta = Convert.ToString(reader2.GetDouble(reader2.GetOrdinal("ivav")));

                   //----------------------------------Datos cliente---------------
                   string nombreCliente = reader2.GetString(reader2.GetOrdinal("nombrec"));
                   string ciudadCliente = reader2.GetString(reader2.GetOrdinal("ciudad"));
                   string estadoCliente = reader2.GetString(reader2.GetOrdinal("estado"));

                   //---------------------------------Datos Factura----------------------
                   evento.Graphics.DrawString("Ticket de Venta:", fuente, Brushes.PaleVioletRed, x + 400, y, new StringFormat());
                   evento.Graphics.DrawString("Folio:", fuente, Brushes.PaleTurquoise, x + 400, y + 25, new StringFormat());
                   evento.Graphics.DrawString("Fecha:", fuente, Brushes.PaleGreen, x + 400, y + 50, new StringFormat());

                   //---------------------Escribe datos Cliente-------------------------------
                   evento.Graphics.DrawString("Nombre:", fuente, Brushes.Purple, x, y + 30, new StringFormat());
                   evento.Graphics.DrawString("Estado:", fuente, Brushes.Purple, x, y + 60, new StringFormat());
                   evento.Graphics.DrawString("Ciudad:", fuente, Brushes.Purple, x, y + 90, new StringFormat());

                   //----------------Encabezado de detalle----------------------------------
                   evento.Graphics.DrawString("Codigo", fuente, Brushes.Purple, x + 50, y + 200, new StringFormat());
                   evento.Graphics.DrawString("Descripcion", fuente, Brushes.Purple, x + 200, y + 200, new StringFormat());
                   evento.Graphics.DrawString("Cantidad:", fuente, Brushes.Purple, x + 350, y + 200, new StringFormat());
                   evento.Graphics.DrawString("Precio Unitario:", fuente, Brushes.Purple, x + 500, y + 200, new StringFormat());
                   evento.Graphics.DrawString("Total:", fuente, Brushes.Purple, x + 700, y + 200, new StringFormat());

                   //-----------------f--Encabezado Final--------------------------------------------------
                   evento.Graphics.DrawString("Subtotal:", fuente, Brushes.Red, x + 600, y + 900, new StringFormat());
                   evento.Graphics.DrawString("Iva:", fuente, Brushes.Red, x + 600, y + 930, new StringFormat());
                   evento.Graphics.DrawString("Total:", fuente, Brushes.Red, x + 600, y + 960, new StringFormat());


                   //---------------------Encabezado Venta------------------------------

                   evento.Graphics.DrawString(FolioVentaI, fuente, Brushes.Orchid, x + 500, y + 25, new StringFormat());
                   evento.Graphics.DrawString(FechaVentaI, fuente, Brushes.Orchid, x + 500, y + 50, new StringFormat());
                   evento.Graphics.DrawImage(pbRV.Image, 250, 75, 120, 120);
                   //-------------------Llenado de Cliente------------------------------
                   evento.Graphics.DrawString(nombreCliente, fuente, Brushes.Black, x + 80, y + 30, new StringFormat());
                   evento.Graphics.DrawString(ciudadCliente, fuente, Brushes.Black, x + 80, y + 60, new StringFormat());
                   evento.Graphics.DrawString(estadoCliente, fuente, Brushes.Black, x + 80, y + 90, new StringFormat());




                   //---------------------------------Detalle-----------------------------
                   float tabulador = 1;
                   double subtotalVenta = 0;
                   double totalCompra = 0;
                   double cantidadIva = 0;
                   for (int iConta = 0; iConta < dgvRV.Rows.Count - 1; iConta++)
                   {

                       tabulador += iConta + 30;
                       evento.Graphics.DrawString(dgvRV.Rows[iConta].Cells[0].Value.ToString(), fuente, Brushes.PowderBlue, x + 50, (y + 200 + tabulador), new StringFormat());
                       evento.Graphics.DrawString(dgvRV.Rows[iConta].Cells[1].Value.ToString(), fuente, Brushes.PowderBlue, x + 200, (y + 200 + tabulador), new StringFormat());
                       evento.Graphics.DrawString(dgvRV.Rows[iConta].Cells[2].Value.ToString(), fuente, Brushes.PowderBlue, x + 350, (y + 200 + tabulador), new StringFormat());
                       evento.Graphics.DrawString(dgvRV.Rows[iConta].Cells[3].Value.ToString(), fuente, Brushes.PowderBlue, x + 500, (y + 200 + tabulador), new StringFormat());
                       evento.Graphics.DrawString(dgvRV.Rows[iConta].Cells[4].Value.ToString(), fuente, Brushes.PowderBlue, x + 700, (y + 200 + tabulador), new StringFormat());

                       subtotalVenta += Convert.ToDouble(dgvRV.Rows[iConta].Cells[4].Value);
                       cantidadIva = (subtotalVenta * .16);
                       totalCompra = subtotalVenta + cantidadIva;



                   }//for

                   //-----------escribe totales----------
                   evento.Graphics.DrawString(Convert.ToString(subtotalVenta), fuente, Brushes.Black, x + 700, y + 900, new StringFormat());
                   evento.Graphics.DrawString(Convert.ToString(cantidadIva), fuente, Brushes.Black, x + 700, y + 930, new StringFormat());
                   evento.Graphics.DrawString(Convert.ToString(totalCompra), fuente, Brushes.Black, x + 700, y + 960, new StringFormat());

                   evento.HasMorePages = false;
                   //Pen cuadro = new Pen(Color.Black);
                   // evento.Graphics.DrawRectangle(cuadro,40,200,50,50);
               }
           }
           catch (Exception msg) {
               MessageBox.Show(msg.ToString());
           }           
        }

        public void imprimirSolicitud()
       {
           try
           {
               PrintDocument formulariot = new PrintDocument();
               formulariot.PrintPage += new PrintPageEventHandler(impresion);
               PrintDialog DialogoImpresionFormulariot = new PrintDialog();
               DialogResult resultado = DialogoImpresionFormulariot.ShowDialog();

               if (resultado == DialogResult.OK)
               {
                   formulariot.Print();

               }
           }
           catch (Exception msg) {

               MessageBox.Show(msg.ToString());
           }

        }//imprimirSolicitud

        private void txtClienteRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtClienteRV.Text == "")
                    {

                        MessageBox.Show("Debe Introducir ID  del cliente");

                    }
                    else
                    {

                        try
                        {
                            int idclienteRV = Convert.ToInt32(txtClienteRV.Text);
                            string nombreclienteRV;
                            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            conexion.Open();
                            NpgsqlCommand comando = conexion.CreateCommand();
                            comando.CommandText = "select * from Cliente where idcliente=" + idclienteRV + "";
                            IDataReader lector = comando.ExecuteReader();
                            int banderaencontradocliente = 0;
                            if (lector.Read())
                            {

                                nombreclienteRV = lector.GetString(lector.GetOrdinal("nombrec"));
                                txtNombreClienteRV.Text = nombreclienteRV;
                                banderaencontradocliente = 1;
                                txtIdProductoRV.Focus();
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

                                    txtClienteRV.Focus();
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
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        private void btnRegresarRV_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
