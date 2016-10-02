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
    public partial class BuscarCambio : Form
    {
        public BuscarCambio()
        {
            InitializeComponent();
        }

        private void BuscarCambio_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable regresa = new DataTable();
                regresa.Columns.Add("ID");
                regresa.Columns.Add("Producto");
                regresa.Columns.Add("Cantidad");
                regresa.Columns.Add("Precio");
                regresa.Columns.Add("Importe");
                dgvRegresados.DataSource = regresa.DefaultView;

                DataTable lleva = new DataTable();
                lleva.Columns.Add("ID");
                lleva.Columns.Add("Producto");
                lleva.Columns.Add("Cantidad");
                lleva.Columns.Add("Precio");
                lleva.Columns.Add("Importe");

                dgvLlevados.DataSource = lleva.DefaultView;
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }
        }


        int IDCambioBusca;
        private void btnBuscaCambio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCambioBusca.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el Folio a buscar......");
                }
                else
                {

                    try
                    {

                        int bandera = 0;
                        IDCambioBusca = Convert.ToInt32(txtCambioBusca.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select * from Cambio JOIN Venta ON folioventa=folioventac where foliocambio=" + IDCambioBusca + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFolioC.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("foliocambio")));
                            string fechaC = Convert.ToString(reader.GetDateTime(reader.GetOrdinal("fechacambio")));
                            DateTime F1 = Convert.ToDateTime(fechaC);
                            txtFechaCambioBusca.Text = F1.ToLongDateString();

                            txtFolioVentaBusca.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("folioventa")));
                            txtMotivoCambio.Text = reader.GetString(reader.GetOrdinal("motivo"));


                            // string rutaimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                            // cajaimagenbusca.Image = new Bitmap(rutaimagen);
                            bandera = 1;
                            //txtIdProductoB.Clear();
                        }
                        dbcon.Close();
                        if (bandera == 0)
                        {
                            MessageBox.Show("CAMBIO NO ENCONTRADO......");
                            txtFolioC.Text = "";
                            txtFechaCambioBusca.Text = "";
                            txtFolioVentaBusca.Text = "";
                            txtMotivoCambio.Text = "";
                            txtCambioBusca.Clear();
                            txtFolioVentaBusca.Text = "";
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
                        NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select idproductoreg,producto,cantidadreg,precioreg from Cambio JOIN DetalleCambio ON foliocambio=foliocambiod JOIN Producto ON idproductoreg=idproducto where foliocambio=" + IDCambioBusca + "", conexion);
                        datosConsulta.Fill(memoria);
                        dgvRegresados.DataSource = memoria.DefaultView;

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }

                    DataTable memoria1 = new DataTable();
                    try
                    {

                        NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                + "Database=Bolsa;" +
                            "User ID=gabrielaflores;" + "Port=5344");
                        NpgsqlDataAdapter datosConsulta1 = new NpgsqlDataAdapter("select idproductolleva,producto,cantidadlleva,preciolleva from Cambio JOIN DetalleCambio ON foliocambio=foliocambiod JOIN Producto ON idproductolleva=idproducto where foliocambio=" + IDCambioBusca + "", conexion);
                        datosConsulta1.Fill(memoria1);
                        dgvLlevados.DataSource = memoria1.DefaultView;

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }


                    try
                    {
                        double subtotal = 0, precio, subtotal1 = 0, precio1;
                        for (int counter = 0; counter < (dgvLlevados.Rows.Count); counter++)
                        {
                            precio = Convert.ToDouble(dgvLlevados.Rows[counter].Cells[3].Value);
                            subtotal = subtotal + precio;

                        }
                        txtSubtotalLleva.Text = Convert.ToString(subtotal);

                        for (int counter1 = 0; counter1 < (dgvRegresados.Rows.Count); counter1++)
                        {
                            precio1 = Convert.ToDouble(dgvRegresados.Rows[counter1].Cells[3].Value);
                            subtotal1 = subtotal1 + precio1;

                        }
                        txtSubtotalReg.Text = Convert.ToString(subtotal1);

                        //txtIvaBC.Text = Convert.ToString(subtotal * 0.16);
                        //txtTotalBC.Text = Convert.ToString(subtotal * 1.16);
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
                txtCambioBusca.Text = "";
                txtCambioBusca.Focus();
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresarBC_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
