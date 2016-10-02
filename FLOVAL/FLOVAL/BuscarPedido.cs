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
    public partial class BuscarPedido : Form
    {
        public BuscarPedido()
        {
            InitializeComponent();
        }

        private void BuscarPedido_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable memo = new DataTable();
                memo.Columns.Add("ID");
                memo.Columns.Add("Producto");
                memo.Columns.Add("Cantidad");
                memo.Columns.Add("Precio");
                dgvBuscaCompra.DataSource = memo.DefaultView;
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString()); ;
            }

        }
        int IDBuscaPedido;
        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFolioPedidoBusca.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el Folio a buscar......");
                }
                else
                {

                    try
                    {

                        int bandera = 0;
                        IDBuscaPedido = Convert.ToInt32(txtFolioPedidoBusca.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select * from Pedido JOIN Cliente ON idclientep=idcliente where idpedido=" + IDBuscaPedido + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblFolioBuscaPedido.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idpedido")));
                            string fechapedi = Convert.ToString(reader.GetDateTime(reader.GetOrdinal("fechapedido")));
                            DateTime F1 = Convert.ToDateTime(fechapedi);
                            lblFechaPedidoBusca.Text = F1.ToLongDateString();
                            lblTipoPedidoBusca.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("tipopedido")));

                            txtDescuentoBusca.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("porcentajedesp")));
                            txtIvaBusca.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("ivap")));

                            cmbPago.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("pagado")));
                            cmbSurtido.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("surtido")));
                            cmbEntregado.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("entregado")));

                            txtFechaPago.Text = reader.GetString(reader.GetOrdinal("fechapago"));
                            txtFechaSurtido.Text = reader.GetString(reader.GetOrdinal("fechasurtido"));
                            txtFechaEntregado.Text = reader.GetString(reader.GetOrdinal("fechaentrega"));


                            txtClienteIdBus.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idclientep")));
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

                            DataTable memoria = new DataTable();
                            try
                            {

                                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                        + "Database=Bolsa;" +
                                    "User ID=gabrielaflores;" + "Port=5344");
                                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idproductop,producto,cantidad,preciodp from Pedido JOIN DetallePedido ON idpedido=idpedidod JOIN Producto ON idproductop=idproducto where idpedido=" + IDBuscaPedido + "", conexion);
                                datosConsulta.Fill(memoria);
                                dgvBuscaCompra.DataSource = memoria.DefaultView;

                            }
                            catch (Exception msg)
                            {
                                MessageBox.Show(msg.ToString());
                            }


                            try
                            {
                                double subtotal = 0, precio;
                                for (int counter = 0; counter < (dgvBuscaCompra.Rows.Count); counter++)
                                {
                                    precio = Convert.ToDouble(dgvBuscaCompra.Rows[counter].Cells[3].Value);
                                    subtotal = subtotal + precio;

                                }
                                txtSubBVenta.Text = Convert.ToString(subtotal);


                                double iva, des, totalconiva, totalcondes;
                                iva = Convert.ToDouble(txtIvaBusca.Text);
                                iva = iva / 100;
                                des = Convert.ToDouble(txtDescuentoBusca.Text);
                                des = des / 100;

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
                        }
                        dbcon.Close();
                        if (bandera == 0)
                        {
                            MessageBox.Show("FOLIO NO ENCONTRADO......");
                            lblFolioBuscaPedido.Text = "";
                            lblFechaPedidoBusca.Text = "";
                            lblTipoPedidoBusca.Text = "";
                            txtClienteIdBus.Text = "";
                            txtNombreClienteBusca.Text = "";
                            txtDescuentoBusca.Text = "";
                            txtIvaBusca.Text = "";
                            txtCelularCliente.Text = "";
                            txtCiudadCliente.Text = "";
                            txtCorreoCliente.Text = "";
                            txtDescuentoAplicadoBusca.Text = "";
                            txtEstadoCliente.Text = "";
                            txtFechaEntregado.Text = "";
                            txtFechaPago.Text = "";
                            txtFechaSurtido.Text = "";
                            txtFolioPedidoBusca.Text = "";
                            txtMedioCliente.Text = "";
                            txtRFCCliente.Text = "";
                            txtSubBVenta.Text = "";
                            txtTelefonoCliente.Text = "";
                            txtTotalBuscaVenta.Text = "";
                            IvaAplicadoB.Text = "";
                            cmbEntregado.Text = "";
                            cmbPago.Text = "";
                            cmbSurtido.Text = "";

                            txtFolioPedidoBusca.Clear();
                        }

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("error.....\n\n" + msg.ToString());
                    }


                    /*DataTable memoria = new DataTable();
                
                    }*/
                    //txtFolioPedidoBusca.Text = "";
                    txtFolioPedidoBusca.Focus();
                }
            }catch(Exception msg){
            MessageBox.Show(msg.ToString());
            }

        }

        private void rbModificaEstado_CheckedChanged(object sender, EventArgs e)
        {  try{
            dtpEntregado.Enabled = true;
            dtpPago.Enabled = true;
            dtpSurtido.Enabled = true;

            cmbEntregado.Enabled = true;
            cmbPago.Enabled = true;
            cmbSurtido.Enabled = true;
            btnModificarEstado.Enabled = true;
            txtFolioPedidoBusca.ReadOnly = false;
           // btnBuscarPedido.Enabled = false;
        }
        catch (Exception msg) { MessageBox.Show(msg.ToString()); }


        }

        private void rbBuscarPedido_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtpEntregado.Enabled = false;
                dtpPago.Enabled = false;
                dtpSurtido.Enabled = false;

                cmbEntregado.Enabled = false;
                cmbPago.Enabled = false;
                cmbSurtido.Enabled = false;

                btnModificarEstado.Enabled = false;
                txtFolioPedidoBusca.ReadOnly = false;
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }

        }

        private void btnModificarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFolioPedidoBusca.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR El FOLIO A ACTUALIZAR Y LA INFORMACION QUE QUIERAS CAMBIAR....");
                    txtFolioPedidoBusca.Focus();
                }
                else
                {
                    try
                    {
                        int n = Convert.ToInt32(txtFolioPedidoBusca.Text);
                        NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();

                        string fpago = Convert.ToString(dtpPago.Value);
                        string fsurtido = Convert.ToString(dtpSurtido.Value.ToLongDateString());
                        string fentregado = Convert.ToString(dtpEntregado.Value.ToLongDateString());

                        int Epago = Convert.ToInt32(cmbPago.Text);
                        int Esurtido = Convert.ToInt32(cmbSurtido.Text);
                        int Eentregado = Convert.ToInt32(cmbEntregado.Text);

                        string queryUp = "update Pedido set fechapago='" + fpago + "',fechasurtido='" + fsurtido + "', fechaentrega='" + fentregado + "',pagado=" + Epago + ", surtido=" + Esurtido + ", entregado=" + Eentregado + " where idpedido=" + n + "";
                        NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                        cmdUp.ExecuteNonQuery();
                        MessageBox.Show("REGISTRO MODIFICADO.....");
                        dbcon.Close();

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresarBuscaPedido_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
