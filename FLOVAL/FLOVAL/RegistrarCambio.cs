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
    public partial class RegistrarCambio : Form
    {
        public RegistrarCambio()
        {
            InitializeComponent();
        }

        int nCambio, nCambioLleva;
        int existCambio;

        /* private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == 13)
             {

                 if (txtIdProductoRC.Text == "")
                 {

                     MessageBox.Show("DEBES INTRODUCIR EL ID DEL PRODUCTO....");
                     txtIdProductoRC.Focus();
                 }
                 else
                 {
                     try
                     {

                         IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                         "Database=Bolsa;" +
                         "User ID=gabrielaflores;" + "Port=5344");
                         dbcon.Open();
                         nCambio = Convert.ToInt32(txtIdProductoRC.Text);
                         IDbCommand dbcmd = dbcon.CreateCommand();

                         dbcmd.CommandText = "select * from Producto where idproducto=" + nCambio + "";
                         IDataReader reader = dbcmd.ExecuteReader();

                         if (reader.Read())
                         {
                             txtProductoRC.Text = reader.GetString(reader.GetOrdinal("producto"));
                             txtPrecioRC.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("precio")));
                             existCambio = reader.GetInt32(reader.GetOrdinal("cantidadp"));
                             txtIdProductoRC.Text = "";
                             dbcon.Close();
                             txtCantidadRC.Focus();
                         }
                         else
                         {
                             txtIdProductoRC.Text = "";
                             txtProductoRC.Text = "";
                             txtPrecioRC.Text = "";
                             MessageBox.Show("Producto no encontrado");
                         }



                     }
                     catch (Exception msg)
                     {
                         MessageBox.Show(msg.ToString());
                     }
                 }
             }
         }*/


        DataTable xCambio = new DataTable();
        DataTable yCambio = new DataTable();

        private void RegistrarCambio_Load(object sender, EventArgs e)
        {
            try
            {
                lblfechaRC.Text = DateTime.Now.ToLongDateString();

                xCambio.Columns.Add("ID");
                xCambio.Columns.Add("Producto");
                //xCambio.Columns.Add("Motivo");
                xCambio.Columns.Add("Cantidad");
                xCambio.Columns.Add("Precio");
                xCambio.Columns.Add("Importe");

                yCambio.Columns.Add("ID");
                yCambio.Columns.Add("Producto");
                yCambio.Columns.Add("Cantidad");
                yCambio.Columns.Add("Precio");
                yCambio.Columns.Add("Importe");


                dgvRC.DataSource = xCambio.DefaultView;
                dgvRPC.DataSource = yCambio.DefaultView;

                try
                {
                    //int bandera = 0;
                    int idcambio;
                    int xRC;
                    IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                    dbcon.Open();
                    IDbCommand dbcmd = dbcon.CreateCommand();
                    dbcmd.CommandText = "select * from Cambio order by foliocambio desc limit 1";
                    IDataReader reader = dbcmd.ExecuteReader();
                    dbcon.Close();
                    if (reader.Read())
                    {
                        xRC = reader.GetInt32(reader.GetOrdinal("foliocambio"));
                        idcambio = xRC;
                        idcambio += 1;
                        lblFolioCambio.Text = Convert.ToString(idcambio);
                        //bandera = 1;
                    }
                    //dbcon.Close();
                    else//unica diferencia es el else
                    {
                        idcambio = 1;
                        lblFolioCambio.Text = Convert.ToString(idcambio);
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

        private void txtIdProductoRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtIdProductoRC.Text == "")
                    {

                        MessageBox.Show("DEBES INTRODUCIR EL ID DEL PRODUCTO....");
                        txtIdProductoRC.Focus();
                    }
                    else
                    {
                        try
                        {

                            IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                            "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon.Open();
                            nCambio = Convert.ToInt32(txtIdProductoRC.Text);
                            IDbCommand dbcmd = dbcon.CreateCommand();

                            dbcmd.CommandText = "select * from Producto where idproducto=" + nCambio + "";
                            IDataReader reader = dbcmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtProductoRC.Text = reader.GetString(reader.GetOrdinal("producto"));
                                txtPrecioRC.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("precio")));
                                //existCambio = reader.GetInt32(reader.GetOrdinal("cantidadp"));
                                // txtIdProductoRC.Text = "";
                                dbcon.Close();
                                txtCantidadRC.Focus();
                            }
                            else
                            {
                                txtIdProductoRC.Text = "";
                                txtProductoRC.Text = "";
                                txtPrecioRC.Text = "";
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

        private void txtIdProductoRPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtIdProductoRPC.Text == "")
                    {

                        MessageBox.Show("DEBES INTRODUCIR EL ID DEL PRODUCTO....");
                        txtIdProductoRPC.Focus();
                    }
                    else
                    {
                        try
                        {

                            IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                            "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon.Open();
                            nCambioLleva = Convert.ToInt32(txtIdProductoRPC.Text);
                            IDbCommand dbcmd = dbcon.CreateCommand();

                            dbcmd.CommandText = "select * from Producto where idproducto=" + nCambioLleva + "";
                            IDataReader reader = dbcmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtProductoRPC.Text = reader.GetString(reader.GetOrdinal("producto"));
                                txtPrecioRPC.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("precio")));
                                existCambio = reader.GetInt32(reader.GetOrdinal("cantidadp"));
                                //txtIdProductoRPC.Text = "";
                                dbcon.Close();
                                txtCantidadRPC.Focus();
                            }
                            else
                            {
                                txtIdProductoRPC.Text = "";
                                txtProductoRPC.Text = "";
                                txtPrecioRPC.Text = "";
                                MessageBox.Show("Producto no encontrado");
                            }



                        }
                        catch (Exception msg)
                        {
                            MessageBox.Show(msg.ToString());
                        }

                    }
                }
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }
        }
        
        
        int iChange, cantidadpiezasRCh;
        double subtotalCambio1;
        private void txtCantidadRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (txtCantidadRC.Text == "")
                    {
                        MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD....");
                        txtCantidadRC.Focus();
                    }
                    else
                    {
                        //if (Convert.ToInt32(txtCantidadRC.Text) <= exist)
                        //{

                        if (MessageBox.Show("DESEAS AGREGAR EL ARTICULO AL CAMBIO", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            xCambio.Rows.Add();
                            dgvRC.Rows[iChange].Cells[0].Value = nCambio;
                            dgvRC.Rows[iChange].Cells[1].Value = txtProductoRC.Text;
                            //dgvRC.Rows[iChange].Cells[2].Value = cmbMotivo.Text;
                            dgvRC.Rows[iChange].Cells[2].Value = txtCantidadRC.Text;
                            dgvRC.Rows[iChange].Cells[3].Value = txtPrecioRC.Text;
                            dgvRC.Rows[iChange].Cells[4].Value = Convert.ToDouble(txtPrecioRC.Text) * Convert.ToDouble(txtCantidadRC.Text);
                            subtotalCambio1 = subtotalCambio1 + Convert.ToDouble(dgvRC.Rows[iChange].Cells[3].Value);
                            txtTotalRC.Text = Convert.ToString(subtotalCambio1);
                            cantidadpiezasRCh = cantidadpiezasRCh + Convert.ToInt32(dgvRC.Rows[iChange].Cells[2].Value);
                            txtCantidadpiezasRCh.Text = Convert.ToString(cantidadpiezasRCh);
                            //txtIvaRC.Text = Convert.ToString(subtotalCompra * .16);
                            //txtTotal.Text = Convert.ToString(subtotalCompra * 1.16);
                            dgvRC.Refresh();
                            txtCantidadRC.Text = "";
                            txtProductoRC.Text = "";
                            txtPrecioRC.Text = "";
                            txtIdProductoRC.Text = "";
                            txtIdProductoRC.Focus();
                            iChange++;
                        }
                        else
                        {
                            txtCantidadRC.Text = "";
                            txtProductoRC.Text = "";
                            txtPrecioRC.Text = "";
                            txtIdProductoRC.Focus();
                        }
                        diferencia = subtotalCambio1 - subtotalCambio2;
                        txtDiferencia.Text = Convert.ToString(diferencia);

                        if (subtotalCambio2 > subtotalCambio1)
                        {

                            MessageBox.Show("Excedes la cantidad por la que se realizo la venta");

                        }

                    }
                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }
        
        double subtotalCambio2,diferencia;
        int iChange1,cantidadpiezasRCh1;

        private void txtCantidadRPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (txtCantidadRPC.Text == "")
                    {
                        MessageBox.Show("DEBES INTRODUCIR UNA CANTIDAD....");
                        txtCantidadRPC.Focus();
                    }
                    else
                    {
                        //if (Convert.ToInt32(txtCantidadRC.Text) <= exist)
                        //{

                        if (MessageBox.Show("DESEAS AGREGAR EL ARTICULO AL CAMBIO", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            yCambio.Rows.Add();
                            dgvRPC.Rows[iChange1].Cells[0].Value = nCambioLleva;
                            dgvRPC.Rows[iChange1].Cells[1].Value = txtProductoRPC.Text;
                            dgvRPC.Rows[iChange1].Cells[2].Value = txtCantidadRPC.Text;
                            dgvRPC.Rows[iChange1].Cells[3].Value = txtPrecioRPC.Text;
                            dgvRPC.Rows[iChange1].Cells[4].Value = Convert.ToDouble(txtPrecioRPC.Text) * Convert.ToDouble(txtCantidadRPC.Text);
                            subtotalCambio2 = subtotalCambio2 + Convert.ToDouble(dgvRPC.Rows[iChange1].Cells[4].Value);
                            txtTotalRPC.Text = Convert.ToString(subtotalCambio2);
                            cantidadpiezasRCh1 = cantidadpiezasRCh1 + Convert.ToInt32(dgvRPC.Rows[iChange1].Cells[2].Value);
                            txtCantidadpiezasRCh1.Text = Convert.ToString(cantidadpiezasRCh1);
                            //txtIvaRC.Text = Convert.ToString(subtotalCompra * .16);
                            //txtTotal.Text = Convert.ToString(subtotalCompra * 1.16);
                            dgvRPC.Refresh();
                            txtCantidadRPC.Text = "";
                            txtProductoRPC.Text = "";
                            txtPrecioRPC.Text = "";
                            txtIdProductoRPC.Text = "";
                            txtIdProductoRPC.Focus();
                            iChange1++;
                        }
                        else
                        {
                            txtCantidadRPC.Text = "";
                            txtProductoRPC.Text = "";
                            txtPrecioRPC.Text = "";
                            txtIdProductoRPC.Focus();
                        }
                        diferencia = subtotalCambio1 - subtotalCambio2;
                        txtDiferencia.Text = Convert.ToString(diferencia);
                        if (subtotalCambio2 > subtotalCambio1)
                        {

                            MessageBox.Show("Excedes la cantidad por la que se realizo la venta");

                        }
                    }
                }
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (subtotalCambio2 <= subtotalCambio1)
                {

                    MessageBox.Show("El Cambio se puede Realizar");

                    //-------------------COMIENZA INSERTAR------

                    if (MessageBox.Show("DESEAS GRABAR LA FACTURA", "CONFIRMACIÓN", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (iChange > 0 && iChange1 > 0)
                        {
                            try
                            {

                                int folioRCambio = Convert.ToInt32(lblFolioCambio.Text);
                                //int tipoventaRV=Convert.ToString(txtTipoRV);
                                //double porcentajeRV=
                                int idVentaRC = Convert.ToInt32(txtFolioVentaRC.Text);
                                string fechacambio = DateTime.Now.ToShortDateString();
                                string motivo = cmbMotivo.Text;

                                //-------------------------------------INSERTA NORMAL EN VENTA---------------------------------------------       


                                IDbConnection dbcon1 = new NpgsqlConnection("Server=localhost;"
                                 + "Database=Bolsa;" +
                                 "User ID=gabrielaflores;" + "Port=5344");
                                dbcon1.Open();
                                IDbCommand dbcmd1 = dbcon1.CreateCommand();
                                dbcmd1.CommandText = "insert into Cambio values(" + folioRCambio + ",'" + fechacambio + "'," + idVentaRC + ",'" + motivo + "')";
                                IDataReader reader1 = dbcmd1.ExecuteReader();
                                //dbcon1.Close();
                                //-----------------------------------INSERTA DETALLE-------------------------------------------------------

                                int a = iChange1, b = 0;
                                if (iChange == iChange1)
                                {
                                    while (b != a)
                                    {

                                        int foliodetalle = Convert.ToInt32(lblFolioCambio.Text);
                                        int idproductodetalle = Convert.ToInt32(dgvRPC.Rows[b].Cells[0].Value);
                                        int cantidadetalle = Convert.ToInt32(dgvRPC.Rows[b].Cells[2].Value);
                                        double preciodetalle = Convert.ToDouble(dgvRPC.Rows[b].Cells[3].Value);
                                        // MessageBox.Show(" "+foliodetalle+" "+idproductodetalle+" "+cantidadetalle+" "+preciodetalle);

                                        int idproductodetallereg = Convert.ToInt32(dgvRC.Rows[b].Cells[0].Value);
                                        int cantidadetallereg = Convert.ToInt32(dgvRC.Rows[b].Cells[2].Value);
                                        double preciodetallereg = Convert.ToDouble(dgvRC.Rows[b].Cells[3].Value);

                                        IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                        dbcmd3.CommandText = "insert into DetalleCambio values(" + foliodetalle + "," + idproductodetalle + "," + cantidadetalle + "," + preciodetalle + "," + idproductodetallereg + "," + cantidadetallereg + "," + preciodetallereg + ")";
                                        IDataReader reader3 = dbcmd3.ExecuteReader();

                                        b++;


                                    }
                                }
                                if (iChange > iChange1)//si las regresadas son mayor a las k se lleva
                                {
                                    int c = iChange, d = 0, f = iChange1;
                                    while (d < c)
                                    {

                                        int foliodetalle = Convert.ToInt32(lblFolioCambio.Text);
                                        int idproductodetalle = Convert.ToInt32(dgvRPC.Rows[d].Cells[0].Value);
                                        int cantidadetalle = Convert.ToInt32(dgvRPC.Rows[d].Cells[2].Value);
                                        double preciodetalle = Convert.ToDouble(dgvRPC.Rows[d].Cells[3].Value);
                                        // MessageBox.Show(" "+foliodetalle+" "+idproductodetalle+" "+cantidadetalle+" "+preciodetalle);

                                        int idproductodetallereg = Convert.ToInt32(dgvRC.Rows[d].Cells[0].Value);
                                        int cantidadetallereg = Convert.ToInt32(dgvRC.Rows[d].Cells[2].Value);
                                        double preciodetallereg = Convert.ToDouble(dgvRC.Rows[d].Cells[3].Value);

                                        if (d < f)
                                        {

                                            IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                            dbcmd3.CommandText = "insert into DetalleCambio values(" + foliodetalle + "," + idproductodetallereg + "," + cantidadetallereg + "," + preciodetallereg + "," + idproductodetalle + "," + cantidadetalle + "," + preciodetalle + ")";
                                            IDataReader reader3 = dbcmd3.ExecuteReader();
                                        }
                                        if (d >= f)
                                        {
                                            IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                            dbcmd3.CommandText = "insert into DetalleCambio values(" + foliodetalle + "," + idproductodetallereg + "," + cantidadetallereg + "," + preciodetallereg + "," + 0 + "," + 0 + "," + 0 + ")";
                                            IDataReader reader3 = dbcmd3.ExecuteReader();


                                        }

                                        d++;


                                    }
                                }

                                /* if (iChange < iChange1)//si las regresadas son menor a las k se lleva
                                 {
                                     int g = iChange, h = 0, j = iChange1;
                                     while (h < j)
                                     {

                                         int foliodetalle = Convert.ToInt32(lblFolioCambio.Text);
                                         int idproductodetalle = Convert.ToInt32(dgvRPC.Rows[b].Cells[0].Value);
                                         int cantidadetalle = Convert.ToInt32(dgvRPC.Rows[b].Cells[2].Value);
                                         double preciodetalle = Convert.ToDouble(dgvRPC.Rows[b].Cells[3].Value);
                                         // MessageBox.Show(" "+foliodetalle+" "+idproductodetalle+" "+cantidadetalle+" "+preciodetalle);

                                         int idproductodetallereg = Convert.ToInt32(dgvRC.Rows[b].Cells[0].Value);
                                         int cantidadetallereg = Convert.ToInt32(dgvRC.Rows[b].Cells[2].Value);
                                         double preciodetallereg = Convert.ToDouble(dgvRC.Rows[b].Cells[3].Value);

                                         if (h < g)
                                         {

                                             IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                             dbcmd3.CommandText = "insert into DetalleCambio values(" + foliodetalle + "," + idproductodetalle + "," + cantidadetalle + "," + preciodetalle + "," + idproductodetallereg + "," + cantidadetallereg + "," + preciodetallereg + ")";
                                             IDataReader reader3 = dbcmd3.ExecuteReader();
                                         }
                                         if (h >= g)
                                         {
                                        
                                             IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                             dbcmd3.CommandText = "insert into DetalleCambio values(" + foliodetalle + "," +  + "," + 0 + "," + 0 + "," + idproductodetallereg + "," + cantidadetallereg + "," + preciodetallereg + ")";
                                             IDataReader reader3 = dbcmd3.ExecuteReader();


                                         }

                                         h++;


                                     }
                                 }*/
                                dbcon1.Close();



                                //------------------------------------MODIFICA EXISTENCIA-------------------------------------------------------
                                int cambiodetalle;
                                int contador = 0, existnew;
                                NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                "Database=Bolsa;" +
                                "User ID=gabrielaflores;" + "Port=5344");
                                dbcon.Open();

                                while (iChange1 != contador)
                                {
                                    cambiodetalle = Convert.ToInt32(dgvRPC.Rows[contador].Cells[0].Value);
                                    existnew = Convert.ToInt32(dgvRPC.Rows[contador].Cells[2].Value);
                                    string queryUp = "update Producto set cantidadp=cantidadp-" + existnew + " where idproducto=" + cambiodetalle + "";
                                    NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                    cmdUp.ExecuteNonQuery();
                                    contador++;

                                }
                                int contador1 = 0, cambiodetalle2, existnew1;
                                while (iChange != contador1)
                                {
                                    cambiodetalle2 = Convert.ToInt32(dgvRC.Rows[contador1].Cells[0].Value);
                                    existnew1 = Convert.ToInt32(dgvRC.Rows[contador1].Cells[2].Value);
                                    string queryUp = "update Producto set cantidadp=cantidadp+" + existnew1 + " where idproducto=" + cambiodetalle2 + "";
                                    NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                    cmdUp.ExecuteNonQuery();
                                    contador1++;

                                }





                                MessageBox.Show("VENTA REALIZADA CON EXITO.....");
                                dbcon.Close();
                                //x.Rows.Clear();
                                txtIdProductoRC.Focus();
                                txtTotalRC.Text = "";
                                txtTotalRPC.Text = "";
                                txtDiferencia.Text = "";
                                txtCantidadpiezasRCh.Text = "";
                                txtCantidadpiezasRCh1.Text = "";
                                cmbMotivo.Text = "";
                                txtFolioVentaRC.Text = "";
                                txtFechaVentaRC.Text="";
                                subtotalCambio1 = 0;
                                subtotalCambio2 = 0;
                                iChange1 = 0;
                                iChange = 0;


                                //-------------------- INSERTA FOLIO----------------------------------------  
                                IDbConnection dbcon2 = new NpgsqlConnection("Server=localhost;"
                                + "Database=Bolsa;" +
                                "User ID=gabrielaflores;" + "Port=5344");
                                dbcon2.Open();
                                IDbCommand dbcmd2 = dbcon2.CreateCommand();
                                dbcmd2.CommandText = "select * from Cambio order by foliocambio desc limit 1";
                                IDataReader reader2 = dbcmd2.ExecuteReader();
                                reader2.Read();
                                dbcon2.Close();

                                int x1;
                                x1 = reader2.GetInt32(reader2.GetOrdinal("foliocambio"));
                                x1 = x1 + 1;

                                lblFolioCambio.Text = Convert.ToString(x1);

                                //-----------------Metodo para imprimir-----------------------------------

                                xCambio.Rows.Clear();
                                yCambio.Rows.Clear();

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
                if (subtotalCambio2 > subtotalCambio1)
                {

                    MessageBox.Show("El Cambio no se puede Realizar");

                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresarRC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtFolioVentaRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtFolioVentaRC.Text == "")
                    {

                        MessageBox.Show("Debe Introducir ID  del cliente");

                    }
                    else
                    {

                        try
                        {
                            int idclienteRV = Convert.ToInt32( txtFolioVentaRC.Text);
                            
                            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            conexion.Open();
                            NpgsqlCommand comando = conexion.CreateCommand();
                            comando.CommandText = "select fechaventa from Venta where folioventa=" + idclienteRV + "";
                            IDataReader lector = comando.ExecuteReader();
                            int banderaencontradocliente = 0;
                            if (lector.Read())
                            {
                                txtFechaVentaRC.Text=lector.GetString(lector.GetOrdinal("fechaventa"));
                               
                               
                                banderaencontradocliente = 1;
                                
                            }
                            if (banderaencontradocliente == 0)
                            {
                                if (MessageBox.Show("El Folio de Venta no Existe, ¿Desea Realizar una Venta?", "Realizar Venta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {

                                    RegistrarVenta nvoventa = new RegistrarVenta();
                                    nvoventa.Show();
                                }
                                else
                                {

                                    txtFolioVentaRC.Focus();
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
    }
}