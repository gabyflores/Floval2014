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
    public partial class RegistrarProducto : Form
    {
        string rutaimagen;

        public RegistrarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProducto.Text == "" || txtCantidadProducto.Text == "" || txtPrecioProducto.Text == "" || txtCostoProducto.Text == "" || txtProveedorProducto.Text == "" || rutaimagen == null)
                {
                    MessageBox.Show("Favor de Introducir los Datos del Producto y una Imagen");
                }
                else
                {
                    try
                    {
                        //-----------------------------------------------Pide Datos--------------------------------------------------
                        int Id = Convert.ToInt32(EtiquetaId.Text);
                        // int Id = Convert.ToInt32(txtIdProducto.Text);
                        string Producto = txtProducto.Text;
                        int CantidadProducto = Convert.ToInt32(txtCantidadProducto.Text);
                        double Precio = Convert.ToDouble(txtPrecioProducto.Text);
                        double Costo = Convert.ToDouble(txtCostoProducto.Text);
                        int IdProveedorProducto = Convert.ToInt32(txtProveedorProducto.Text);



                        //-----------------------------------------------------------Conexion-----------------------------------------

                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "insert into Producto values(" + Id + ",'" + Producto + "'," + CantidadProducto + "," + Precio + "," + Costo + "," + IdProveedorProducto + ",'" + rutaimagen + "')";
                        IDataReader reader = dbcmd.ExecuteReader();
                        dbcon.Close();

                        //---------------------------------------------------Limpiar------------------------------------------------------
                        //txtIdProducto.Text = "";
                        txtProducto.Text = "";
                        //txtCantidadProducto.Text = "";
                        txtPrecioProducto.Text = "";
                        txtCostoProducto.Text = "";
                        txtProveedorProducto.Text = "";
                        txtNombreProveedor.Text = "";

                        IDbConnection dbcon1 = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon1.Open();
                        IDbCommand dbcmd1 = dbcon1.CreateCommand();
                        dbcmd1.CommandText = "select * from Producto order by idproducto desc limit 1";
                        IDataReader reader1 = dbcmd1.ExecuteReader();
                        reader1.Read();
                        dbcon1.Close();

                        int x;
                        x = reader1.GetInt32(reader1.GetOrdinal("idproducto"));
                        x = x + 1; ;

                        EtiquetaId.Text = Convert.ToString(x);

                        MessageBox.Show("Producto Registrado correctamente");
                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("error.....\n\n" + msg.ToString());
                    }
                }
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            try {
                int x = 0;
                int idproducto;

                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                conexion.Open();
                
                IDbCommand dbcmd2 = conexion.CreateCommand();
                dbcmd2.CommandText = "select * from Producto order by idproducto desc limit 1";
                IDataReader reader2 = dbcmd2.ExecuteReader();
                conexion.Close();

                if (reader2.Read())
                {
                    idproducto = reader2.GetInt32(reader2.GetOrdinal("idproducto"));
                    //EtiquetaId.Text = Convert.ToString(idproducto);
                    x = idproducto;
                    x += 1;
                    EtiquetaId.Text = Convert.ToString(x);


                }
                else {

                    x = 1;
                    EtiquetaId.Text = Convert.ToString(x);
                
                }
            
            
            
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog seleccionimagen = new OpenFileDialog();
                seleccionimagen.Filter = "image files (*.jpg)|*.jpg|All files(*.*)|*.*";
                seleccionimagen.InitialDirectory = "c:\\users\\Gaby\\mis imagenes";
                seleccionimagen.Title = "Seleccione Imagen para el producto";

                if (seleccionimagen.ShowDialog() == DialogResult.OK)
                {
                    cajaimagenproducto.ImageLocation = seleccionimagen.FileName;
                    rutaimagen = seleccionimagen.FileName;
                    string direccion = seleccionimagen.FileName;
                    rutaimagen = seleccionimagen.SafeFileName;
                    string direccioncopiar = Application.StartupPath + @"\" + rutaimagen;

                    System.IO.File.Copy(direccion, direccioncopiar, true);

                }
            }catch(Exception msg){
               MessageBox.Show( msg.ToString());
            
            }
        }

        private void btnRegresarAP_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        private void txtProveedorProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtProveedorProducto.Text == "")
                    {

                        MessageBox.Show("Debe Introducir ID  del cliente");

                    }
                    else
                    {

                        try
                        {
                            int idclienteRV = Convert.ToInt32(txtProveedorProducto.Text);
                            string nombreclienteRV;
                            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                             + "Database=Bolsa;" +
                             "User ID=gabrielaflores;" + "Port=5344");
                            conexion.Open();
                            NpgsqlCommand comando = conexion.CreateCommand();
                            comando.CommandText = "select nombrep from Proveedor where idproveedor=" + idclienteRV + "";
                            IDataReader lector = comando.ExecuteReader();
                            int banderaencontradocliente = 0;
                            if (lector.Read())
                            {

                                nombreclienteRV = lector.GetString(lector.GetOrdinal("nombrep"));
                                txtNombreProveedor.Text = nombreclienteRV;
                                banderaencontradocliente = 1;

                            }
                            if (banderaencontradocliente == 0)
                            {
                                if (MessageBox.Show("El Id de Proveedor no Existe, ¿Desea Agregar al Proveedor?", "Agregar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {

                                    RegistrarProveedor nvocliente = new RegistrarProveedor();
                                    nvocliente.Show();
                                }
                                else
                                {

                                    txtProveedorProducto.Focus();
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
