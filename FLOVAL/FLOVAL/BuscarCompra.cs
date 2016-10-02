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
    public partial class BuscarCompra : Form
    {
        public BuscarCompra()
        {
            InitializeComponent();
        }

        private void BuscarCompra_Load(object sender, EventArgs e)
        {
            DataTable memo = new DataTable();
            memo.Columns.Add("ID");
            memo.Columns.Add("Producto");
            memo.Columns.Add("Cantidad");
            memo.Columns.Add("Precio");
            dgvBuscarCompra.DataSource = memo.DefaultView;

        }
        int IDbuscaCompra;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFolioBCompra.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el Folio a buscar......");
                }
                else
                {

                    try
                    {

                        int bandera = 0;
                        IDbuscaCompra = Convert.ToInt32(txtFolioBCompra.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select * from Compra JOIN Proveedor ON idproveedor=idproveedorc where foliocompra=" + IDbuscaCompra + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFolioCompraB.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("foliocompra")));
                            string fechaC = Convert.ToString(reader.GetDateTime(reader.GetOrdinal("fechacompra")));
                            string fechaacor = Convert.ToString(reader.GetDateTime(reader.GetOrdinal("fechaacordada")));

                            DateTime F1 = Convert.ToDateTime(fechaC);
                            DateTime F2 = Convert.ToDateTime(fechaacor);
                            txtFechaCompra.Text = F1.ToLongDateString();
                            txtFechaAcordada.Text = F2.ToLongDateString();

                            txtRetraso.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("retraso")));
                            txtProveedor.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idproveedor")));
                            txtNombreProveedor.Text = reader.GetString(reader.GetOrdinal("nombrep"));
                            txtPtosCompra.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("ptoscompra")));


                            // string rutaimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                            // cajaimagenbusca.Image = new Bitmap(rutaimagen);
                            bandera = 1;
                            //txtIdProductoB.Clear();
                        }
                        dbcon.Close();
                        if (bandera == 0)
                        {
                            MessageBox.Show("VENTA NO ENCONTRADA......");
                            txtFolioCompraB.Text = "";
                            txtFechaCompra.Text = "";
                            txtFechaAcordada.Text = "";
                            txtRetraso.Text = "";
                            txtProveedor.Text = "";
                            txtNombreProveedor.Text = "";
                            txtPtosCompra.Text = "";

                            txtFolioBCompra.Clear();
                        }

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
                        NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idproductod,producto,cantidadv,preciov from Venta JOIN DetalleVenta ON folioventa=folioventad JOIN Producto ON idproductod=idproducto where folioventa=" + IDbuscaCompra + "", conexion);
                        datosConsulta.Fill(memoria);
                        dgvBuscarCompra.DataSource = memoria.DefaultView;

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }


                    try
                    {
                        double subtotal = 0, precio;
                        for (int counter = 0; counter < (dgvBuscarCompra.Rows.Count); counter++)
                        {
                            precio = Convert.ToDouble(dgvBuscarCompra.Rows[counter].Cells[3].Value);
                            subtotal = subtotal + precio;

                        }
                        txtSubtotalBC.Text = Convert.ToString(subtotal);
                        txtIvaBC.Text = Convert.ToString(subtotal * 0.16);
                        txtTotalBC.Text = Convert.ToString(subtotal * 1.16);
                        txtFolioBCompra.Text = "";
                        txtFolioBCompra.Focus();
                        // double iva, des, totalconiva, totalcondes;
                        //iva = Convert.ToDouble(txtIvaBusca.Text);
                        //iva = iva / 100;
                        // des = Convert.ToDouble(txtDescuentoBusca.Text);
                        //des = des / 100;

                        // txtDescuentoAplicadoBusca.Text = Convert.ToString(subtotal * des);
                        // totalcondes = subtotal - Convert.ToDouble(txtDescuentoAplicadoBusca.Text);
                        //IvaAplicadoB.Text = Convert.ToString(totalcondes * iva);
                        //totalconiva = totalcondes + Convert.ToDouble(IvaAplicadoB.Text);
                        //txtTotalBuscaVenta.Text = Convert.ToString(totalconiva);


                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
                }
        }catch(Exception msg){
            
            MessageBox.Show(msg.ToString());
            }
    }

        private void btnRegresarBC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
