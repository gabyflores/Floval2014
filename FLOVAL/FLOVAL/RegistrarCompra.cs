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
    public partial class RegistrarCompra : Form
    {
        public RegistrarCompra()
        {
            InitializeComponent();
        }
        
        
        DataTable xCompra = new DataTable();
        private void RegistrarCompra_Load(object sender, EventArgs e)
        {
            try
            {
                //DateTime FechaCompra =
                lblfechaCompra.Text = DateTime.Now.ToLongDateString();//muestra fecha en formato largo mas presentable

                //string Fecha = DateTime.Now.ToShortDateString();
                // FechaCompra.ToString();

                xCompra.Columns.Add("ID");
                xCompra.Columns.Add("Producto");
                xCompra.Columns.Add("Cantidad");
                xCompra.Columns.Add("Costo");
                xCompra.Columns.Add("Importe");
                dgvRCompra.DataSource = xCompra.DefaultView;
                try
                {
                    int x1 = 0;
                    int folioCompraRC;

                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                    conexion.Open();

                    IDbCommand dbcmd2 = conexion.CreateCommand();
                    dbcmd2.CommandText = "select * from Compra order by foliocompra desc limit 1";
                    IDataReader reader2 = dbcmd2.ExecuteReader();
                    conexion.Close();

                    if (reader2.Read())
                    {
                        folioCompraRC = reader2.GetInt32(reader2.GetOrdinal("foliocompra"));
                        x1 = folioCompraRC;
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
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        
        
        int nProductoC;
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
                            nProductoC = Convert.ToInt32(txtIdProductoRC.Text);
                            IDbCommand dbcmd = dbcon.CreateCommand();

                            dbcmd.CommandText = "select * from Producto where idproducto=" + nProductoC + "";
                            IDataReader reader = dbcmd.ExecuteReader();

                            if (reader.Read())
                            {
                                txtProductoRC.Text = reader.GetString(reader.GetOrdinal("producto"));
                                txtCostoRC.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("costo")));
                                string nombreimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                                pboxRegistraCompra.Image = new Bitmap(nombreimagen);
                                //exist = reader.GetInt32(reader.GetOrdinal("cantidadp"));
                                txtIdProductoRC.Text = "";
                                dbcon.Close();
                                txtCantidadRC.Focus();
                            }
                            else
                            {
                                txtIdProductoRC.Text = "";
                                txtProductoRC.Text = "";
                                txtCostoRC.Text = "";
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

        int iC;
        double subtotalCompra;
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

                        if (MessageBox.Show("DESEAS AGREGAR EL ARTICULO A LA COMPRA", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            xCompra.Rows.Add();
                            dgvRCompra.Rows[iC].Cells[0].Value = nProductoC;
                            dgvRCompra.Rows[iC].Cells[1].Value = txtProductoRC.Text;
                            dgvRCompra.Rows[iC].Cells[2].Value = txtCantidadRC.Text;
                            dgvRCompra.Rows[iC].Cells[3].Value = txtCostoRC.Text;
                            dgvRCompra.Rows[iC].Cells[4].Value = Convert.ToDouble(txtCostoRC.Text) * Convert.ToDouble(txtCantidadRC.Text);
                            subtotalCompra = subtotalCompra + Convert.ToDouble(dgvRCompra.Rows[iC].Cells[4].Value);
                            txtSubtotalRC.Text = Convert.ToString(subtotalCompra);
                            txtIvaRC.Text = Convert.ToString(subtotalCompra * .16);
                            txtTotal.Text = Convert.ToString(subtotalCompra * 1.16);
                            dgvRCompra.Refresh();
                            txtCantidadRC.Text = "";
                            txtProductoRC.Text = "";
                            txtCostoRC.Text = "";
                            txtIdProductoRC.Focus();
                            iC++;
                        }
                        else
                        {
                            txtCantidadRC.Text = "";
                            txtProductoRC.Text = "";
                            txtCostoRC.Text = "";
                            txtIdProductoRC.Focus();
                        }
                        //}
                        /* else
                         {
                             MessageBox.Show("EXCEDES LA EXISTENCIA, LA DISPONIBILIDAD ES DE " + exist + " PRODUCTOS");
                             txtCantidad.Text = "";
                             txtCantidad.Focus();
                         }*/

                    }
                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }

        }
        
        
        int PtosCompra;
        private void dtpVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //-----------CONVERTIR  FECHAS DE CORTO A LARGO-----------
                /*string FechaAcordada = dtpVenta.Text;
                txtFechaAcordada.Text = FechaAcordada;
                DateTime F1 = Convert.ToDateTime(FechaAcordada);
                txtIdProveedorRC.Text = F1.ToShortDateString();
           
            
                ///------------RESTAR FECHAS------------
                DateTime FechaAcordada1 =dtpVenta.Value ;
                DateTime FechaActual1 = DateTime.Now;

                TimeSpan ts = FechaActual1 - FechaAcordada1;

                // Difference in days.
                int differenceInDays = ts.Days;
                txtIdProductoRC.Text = Convert.ToString(differenceInDays);*/
                DateTime FechaAcordada1 = dtpVenta.Value;
                DateTime FechaActual1 = DateTime.Now;
                TimeSpan ts = FechaActual1 - FechaAcordada1;
                int differenceInDays = ts.Days;
                txtRetrasoRC.Text = Convert.ToString(differenceInDays);

                if (differenceInDays == 0)
                {
                    PtosCompra = 2;
                    txtPuntosCompra.Text = Convert.ToString(PtosCompra);
                }
                if (differenceInDays == 1)
                {
                    PtosCompra = 1;
                    txtPuntosCompra.Text = Convert.ToString(PtosCompra);
                }
                if (differenceInDays > 1)
                {
                    PtosCompra = 0;
                    txtPuntosCompra.Text = Convert.ToString(PtosCompra);
                }
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnGrabarRC_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("DESEAS GRABAR LA COMPRA", "CONFIRMACIÓN", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (iC > 0)
                    {
                        try
                        {

                            int folioRC = Convert.ToInt32(lblFolioVenta.Text);
                            //int tipoventaRV=Convert.ToString(txtTipoRV);
                            //double porcentajeRV=
                            int idproveedorRC = Convert.ToInt32(txtIdProveedorRC.Text);
                            string fechacompra = DateTime.Now.ToShortDateString();
                            string fechaacordadaI = Convert.ToString(dtpVenta.Value.ToShortDateString());
                            int diferenciadias = Convert.ToInt32(txtRetrasoRC.Text);
                            int ptosCompraRC = Convert.ToInt32(txtPuntosCompra.Text);
                            //-------------------------------------INSERTA NORMAL EN VENTA---------------------------------------------       


                            IDbConnection dbcon1 = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            dbcon1.Open();
                            IDbCommand dbcmd1 = dbcon1.CreateCommand();
                            dbcmd1.CommandText = "insert into Compra values(" + folioRC + ",'" + fechacompra + "','" + fechaacordadaI + "'," + diferenciadias + "," + ptosCompraRC + "," + idproveedorRC + ")";
                            IDataReader reader1 = dbcmd1.ExecuteReader();
                            //dbcon1.Close();
                            //-----------------------------------INSERTA DETALLE-------------------------------------------------------

                            int a = iC, b = 0;

                            while (b != a)
                            {

                                int foliodetalle = Convert.ToInt32(lblFolioVenta.Text);
                                int idproductodetalle = Convert.ToInt32(dgvRCompra.Rows[b].Cells[0].Value);
                                int cantidadetalle = Convert.ToInt32(dgvRCompra.Rows[b].Cells[2].Value);
                                double costodetalle = Convert.ToDouble(dgvRCompra.Rows[b].Cells[3].Value);


                                IDbCommand dbcmd3 = dbcon1.CreateCommand();
                                dbcmd3.CommandText = "insert into DetalleCompra values(" + foliodetalle + "," + idproductodetalle + "," + cantidadetalle + "," + costodetalle + ")";
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

                            while (iC != contador)
                            {
                                nProductoC = Convert.ToInt32(dgvRCompra.Rows[contador].Cells[0].Value);
                                existnew = Convert.ToInt32(dgvRCompra.Rows[contador].Cells[2].Value);
                                string queryUp = "update Producto set cantidadp=cantidadp+" + existnew + " where idproducto=" + nProductoC + "";
                                NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                cmdUp.ExecuteNonQuery();
                                contador++;

                            }
                            MessageBox.Show("COMPRA REALIZADA CON EXITO.....");
                            dbcon.Close();
                            //x.Rows.Clear();
                            txtPuntosCompra.Text = "";
                            txtRetrasoRC.Text = "";
                            txtIdProveedorRC.Text = "";
                            txtNombreProveedorRC.Text = "";
                            txtIdProductoRC.Focus();
                            txtProductoRC.Text = "";
                            txtCostoRC.Text = "";
                            txtCantidadRC.Text = "";
                            txtSubtotalRC.Text = "";
                            txtIvaRC.Text = "";
                            txtTotal.Text = "";
                            txtIvaRC.Text = "";
                            subtotalCompra = 0;
                            iC = 0;


                            //-------------------- INSERTA FOLIO----------------------------------------  
                            IDbConnection dbcon2 = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                            dbcon2.Open();
                            IDbCommand dbcmd2 = dbcon2.CreateCommand();
                            dbcmd2.CommandText = "select * from Compra order by foliocompra desc limit 1";
                            IDataReader reader2 = dbcmd2.ExecuteReader();
                            reader2.Read();
                            dbcon2.Close();

                            int x1;
                            x1 = reader2.GetInt32(reader2.GetOrdinal("foliocompra"));
                            x1 = x1 + 1;

                            lblFolioVenta.Text = Convert.ToString(x1);

                            //-----------------Metodo para imprimir-----------------------------------
                            // imprimirfactura();
                            xCompra.Rows.Clear();

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

        private void txtIdProveedorRC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtIdProveedorRC.Text == "")
                    {

                        MessageBox.Show("Debe Introducir ID  del Proveedor");

                    }
                    else
                    {

                        try
                        {
                            int idproveedorRC = Convert.ToInt32(txtIdProveedorRC.Text);
                            string nombreproveedorRC;
                            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            conexion.Open();
                            NpgsqlCommand comando = conexion.CreateCommand();
                            comando.CommandText = "select * from Proveedor where idproveedor=" + idproveedorRC + "";
                            IDataReader lector = comando.ExecuteReader();
                            int banderaencontradoproveedor = 0;
                            if (lector.Read())
                            {

                                nombreproveedorRC = lector.GetString(lector.GetOrdinal("nombrep"));
                                txtNombreProveedorRC.Text = nombreproveedorRC;
                                banderaencontradoproveedor = 1;

                            }
                            if (banderaencontradoproveedor == 0)
                            {
                                if (MessageBox.Show("El Id de Proveedor no Existe, ¿Desea Agregar al Proveedor?", "Agregar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {

                                    RegistrarProveedor nvopvo = new RegistrarProveedor();
                                    nvopvo.Show();
                                }
                                else
                                {

                                    txtIdProveedorRC.Focus();
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

        private void btnRegresarRC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
