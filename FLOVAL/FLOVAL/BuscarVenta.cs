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
    public partial class BuscarVenta : Form
    {
        public BuscarVenta()
        {
            InitializeComponent();
        }

        private void BuscarVenta_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable memo = new DataTable();
                memo.Columns.Add("ID");
                memo.Columns.Add("Producto");
                memo.Columns.Add("Cantidad");
                memo.Columns.Add("Precio");
                dgvBuscaDVenta.DataSource = memo.DefaultView;
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }


            
        }
        int IDbuscaVenta;

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (folioVentaBusca.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el Folio a buscar......");
                }
                else
                {
                    int bandera = 0;

                    try
                    {
                        //bandera

                        IDbuscaVenta = Convert.ToInt32(folioVentaBusca.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select * from Venta JOIN Cliente ON idclientev=idcliente where folioventa=" + IDbuscaVenta + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFolioVenta.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("folioventa")));
                            lblFechaVentaBusca.Text = reader.GetString(reader.GetOrdinal("fechaventa"));
                            lblTipoVentaBusca.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("tipoventa")));

                            txtDescuentoBusca.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("porcentajedesv")));
                            txtIvaBusca.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("ivav")));

                            txtClienteIdBus.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idclientev")));
                            txtNombreClienteBusca.Text = reader.GetString(reader.GetOrdinal("nombrec"));
                            txtRFCCliente.Text = reader.GetString(reader.GetOrdinal("rfccliente"));
                            txtTelefonoCliente.Text = reader.GetString(reader.GetOrdinal("telefono"));
                            txtCelularCliente.Text = reader.GetString(reader.GetOrdinal("celular"));
                            txtCorreoCliente.Text = reader.GetString(reader.GetOrdinal("correo"));
                            txtCiudadCliente.Text = reader.GetString(reader.GetOrdinal("ciudad"));
                            txtEstadoCliente.Text = reader.GetString(reader.GetOrdinal("estado"));
                            txtMedioCliente.Text = reader.GetString(reader.GetOrdinal("mediodecontacto"));

                            // string rutaimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                            // cajaimagenbusca.Image = new Bitmap(rutaimagen);
                            bandera = 1;
                            //txtIdProductoB.Clear();
                        }
                        dbcon.Close();
                        /*if (bandera == 0)
                        {
                            MessageBox.Show("VENTA NO ENCONTRADA......");
                            txtFolioVenta.Text = "";
                            lblFechaVentaBusca.Text = "";
                            lblTipoVentaBusca.Text = "";
                            txtClienteIdBus.Text = "";
                            txtNombreClienteBusca.Text = "";
                            txtDescuentoBusca.Text = "";
                            txtIvaBusca.Text = "";
                            txtDescuentoAplicadoBusca.Text = "";
                            txtCiudadCliente.Text = "";
                            txtCelularCliente.Text = "";
                            txtEstadoCliente.Text = "";
                            txtCorreoCliente.Text = "";
                            txtTelefonoCliente.Text = "";
                            txtRFCCliente.Text = "";
                            txtMedioCliente.Text = "";
                            txtSubBVenta.Text ="";
                            txtTotalBuscaVenta.Text = "";
                            IvaAplicadoB.Text = "";
                            txtSubBVenta.Clear();
                        
                       
                        
                        
                        
                           folioVentaBusca.Clear();
                           folioVentaBusca.Focus();
                        }*/

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("error.....\n\n" + msg.ToString());
                    }


                    DataTable memoria = new DataTable();
                    try
                    {

                        NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                + "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                        NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idproductod,producto,cantidadv,preciov from Venta JOIN DetalleVenta ON folioventa=folioventad JOIN Producto ON idproductod=idproducto where folioventa=" + IDbuscaVenta + "", conexion);
                        datosConsulta.Fill(memoria);
                        dgvBuscaDVenta.DataSource = memoria.DefaultView;

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }


                    try
                    {
                        double subtotal = 0, precio;
                        for (int counter = 0; counter < (dgvBuscaDVenta.Rows.Count); counter++)
                        {
                            precio = Convert.ToDouble(dgvBuscaDVenta.Rows[counter].Cells[3].Value);
                            subtotal = subtotal + precio;

                        }
                        txtSubBVenta.Text = Convert.ToString(subtotal);

                        string iva1, des1;
                        double totalconiva, totalcondes;
                        iva1 = txtIvaBusca.Text;
                        double iva = Convert.ToDouble(iva1);
                        iva = iva * .01;
                        des1 = txtDescuentoBusca.Text;
                        double des = Convert.ToDouble(des1);
                        des = des * .01;

                        txtDescuentoAplicadoBusca.Text = Convert.ToString(subtotal * des);
                        totalcondes = subtotal - Convert.ToDouble(txtDescuentoAplicadoBusca.Text);
                        IvaAplicadoB.Text = Convert.ToString(totalcondes * iva);
                        totalconiva = totalcondes + Convert.ToDouble(IvaAplicadoB.Text);
                        txtTotalBuscaVenta.Text = Convert.ToString(totalconiva);


                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
                    if (bandera == 0)
                    {
                        MessageBox.Show("VENTA NO ENCONTRADA......");
                        txtFolioVenta.Text = "";
                        lblFechaVentaBusca.Text = "";
                        lblTipoVentaBusca.Text = "";
                        txtClienteIdBus.Text = "";
                        txtNombreClienteBusca.Text = "";
                        txtDescuentoBusca.Text = "";
                        txtIvaBusca.Text = "";
                        txtDescuentoAplicadoBusca.Text = "";
                        txtCiudadCliente.Text = "";
                        txtCelularCliente.Text = "";
                        txtEstadoCliente.Text = "";
                        txtCorreoCliente.Text = "";
                        txtTelefonoCliente.Text = "";
                        txtRFCCliente.Text = "";
                        txtMedioCliente.Text = "";
                        txtSubBVenta.Text = "";
                        txtTotalBuscaVenta.Text = "";
                        IvaAplicadoB.Text = "";
                        txtSubBVenta.Clear();





                        folioVentaBusca.Clear();
                        folioVentaBusca.Focus();
                    }



                    folioVentaBusca.Clear();
                    folioVentaBusca.Focus();
                }
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        private void btnRegresarBV_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
