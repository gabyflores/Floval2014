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
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }
        //String date = "'Current_Date'";

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProductoB.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el ID a buscar......");
                }
                else
                {

                    try
                    {

                        int bandera = 0;
                        int ID = Convert.ToInt32(txtIdProductoB.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select idproducto,producto,cantidadp,precio,costo,idproveedorp,rutaimagen,nombrep from Producto JOIN Proveedor ON idproveedorp=idproveedor where idproducto=" + ID + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtProductoBuscado.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idproducto")));
                            txtProductoB.Text = reader.GetString(reader.GetOrdinal("producto"));
                            txtCantidadProductoB.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("cantidadp")));
                            txtPrecioProductoB.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("precio")));
                            txtCostoProductoB.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("costo")));
                            txtProveedorProductoB.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idproveedorp")));
                            txtNombreProveedor.Text = reader.GetString(reader.GetOrdinal("nombrep"));
                            string rutaimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                            cajaimagenbusca.Image = new Bitmap(rutaimagen);
                            bandera = 1;
                            txtIdProductoB.Clear();
                        }
                        dbcon.Close();
                        if (bandera == 0)
                        {
                            MessageBox.Show("PRODUCTO NO ENCONTRADO......");
                            txtProductoBuscado.Text = "";
                            txtProductoB.Text = "";
                            txtCantidadProductoB.Text = "";
                            txtPrecioProductoB.Text = "";
                            txtCostoProductoB.Text = "";
                            txtProveedorProductoB.Text = "";
                            txtNombreProveedor.Text = "";

                            txtIdProductoB.Clear();
                        }

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("error.....\n\n" + msg.ToString());
                    }
                }
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }
        }

         private string IdProductoImprimir;
         private string ProductoImprimir;
         private string CantidadImprimir;
         private string PrecioProductoImprimir;
         private string CostoProductoImprimir;

         private Font fuente = new Font("Verdana",20);

         public void datosProducto(object objeto, PrintPageEventArgs evento) {
             try
             {
                 float posicionX = 10;
                 float posicionY = 20;

                 IdProductoImprimir = txtProductoBuscado.Text;
                 ProductoImprimir = txtProductoB.Text;
                 CantidadImprimir = txtCantidadProductoB.Text;
                 PrecioProductoImprimir = txtPrecioProductoB.Text;
                 CostoProductoImprimir = txtCostoProductoB.Text;

                 evento.Graphics.DrawString("Id Producto:", fuente, Brushes.Red, posicionX, posicionY, new StringFormat());
                 evento.Graphics.DrawString("Producto:", fuente, Brushes.Red, posicionX, posicionY + 50, new StringFormat());
                 evento.Graphics.DrawString("Cantidad Producto:", fuente, Brushes.Red, posicionX, posicionY + 100, new StringFormat());
                 evento.Graphics.DrawString("Precio:", fuente, Brushes.Red, posicionX, posicionY + 150, new StringFormat());
                 evento.Graphics.DrawString("Costo:", fuente, Brushes.Red, posicionX, posicionY + 200, new StringFormat());

                 evento.Graphics.DrawString(IdProductoImprimir, fuente, Brushes.Green, posicionX + 350, posicionY, new StringFormat());
                 evento.Graphics.DrawString(ProductoImprimir, fuente, Brushes.Green, posicionX + 350, posicionY + 50, new StringFormat());
                 evento.Graphics.DrawString(CantidadImprimir, fuente, Brushes.Green, posicionX + 350, posicionY + 100, new StringFormat());
                 evento.Graphics.DrawString(PrecioProductoImprimir, fuente, Brushes.Green, posicionX + 350, posicionY + 150, new StringFormat());
                 evento.Graphics.DrawString(CostoProductoImprimir, fuente, Brushes.Green, posicionX + 350, posicionY + 200, new StringFormat());
                 evento.Graphics.DrawImage(cajaimagenbusca.Image, 500, 20, 300, 300);
             }
             catch (Exception msg) {
                 MessageBox.Show(msg.ToString());
             }
         }

         public void ImprimirProducto() {
             try
             {
                 PrintDocument documento = new PrintDocument();
                 documento.PrintPage += new PrintPageEventHandler(datosProducto);
                 PrintDialog dialogoimpresion = new PrintDialog();
                 dialogoimpresion.Document = documento;
                 DialogResult resultado = dialogoimpresion.ShowDialog();

                 if (resultado == DialogResult.OK)
                 {
                     documento.Print();

                 }


             }catch(Exception msg){
                 MessageBox.Show(msg.ToString());
             }
         }
        
        
        private void btnImprimeProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProductoB.Text == "")
                {

                    MessageBox.Show("Primero ingrese un id a buscar");

                }
                else
                {

                    ImprimirProducto();

                }
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }

        }

        private void btnRegresarBP_Click(object sender, EventArgs e)
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
