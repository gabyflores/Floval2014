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
    public partial class ModificarProducto : Form
    {  string imagenmodifica;
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscarProductoM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProductoBM.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el ID a buscar......");
                }
                else
                {
                    try
                    {
                        int bandera = 0;
                        int ID = Convert.ToInt32(txtIdProductoBM.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select * from  Producto where idproducto=" + ID + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtProductoBuscadoM.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idproducto")));
                            txtProductoBM.Text = reader.GetString(reader.GetOrdinal("producto"));
                            txtCantidadProductoBM.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("cantidadp")));
                            txtPrecioProductoBM.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("precio")));
                            txtCostoProductoBM.Text = Convert.ToString(reader.GetDouble(reader.GetOrdinal("costo")));
                            txtProveedorProductoBM.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idproveedorp")));
                            //string rutaimagen1 = reader.GetString(reader.GetOrdinal("rutaimagen"));
                            //pbxmodificaimagen.Image =new Bitmap(rutaimagen1);
                            imagenmodifica = reader.GetString(reader.GetOrdinal("rutaimagen"));
                            pbxmodificaimagen.Image = new Bitmap(imagenmodifica);

                            bandera = 1;

                            //txtProductoBuscadoM.ReadOnly = false;
                            txtProductoBM.ReadOnly = false;
                            //txtCantidadProductoBM.ReadOnly = false;
                            txtPrecioProductoBM.ReadOnly = false;
                            txtCostoProductoBM.ReadOnly = false;
                            txtProveedorProductoBM.ReadOnly = false;




                            // txtBuscado.Clear();
                        }
                        dbcon.Close();
                        if (bandera == 0)
                        {
                            MessageBox.Show("REGISTRO NO ENCONTRADO......");
                            txtProductoBuscadoM.Text = "";
                            txtProductoBM.Text = "";
                            txtCantidadProductoBM.Text = "";
                            txtPrecioProductoBM.Text = "";
                            txtCostoProductoBM.Text = "";
                            txtProveedorProductoBM.Text = "";


                            //  txtID.Text = "";
                            txtIdProductoBM.Clear();
                        }

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("error.....\n\n" + msg.ToString());
                    }
                }
            }
            catch (Exception msg) {

                MessageBox.Show(msg.ToString());
            }
        }


        private void btnModificaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProductoBM.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR El ID A ACTUALIZAR Y LA INFORMACION QUE QUIERAS CAMBIAR....");
                    txtIdProductoBM.Focus();
                }
                else
                {
                    try
                    {
                        int n = Convert.ToInt32(txtIdProductoBM.Text);
                        NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        string producto = txtIdProductoBM.Text;
                        int cantidadnew = Convert.ToInt32(txtCantidadProductoBM.Text);
                        double precionew = Convert.ToDouble(txtPrecioProductoBM.Text);
                        double costonew = Convert.ToDouble(txtCostoProductoBM.Text);
                        int proveedornew = Convert.ToInt32(txtProveedorProductoBM.Text);

                        string queryUp = "update Producto set producto='" + producto + "',precio=" + precionew + ",costo=" + costonew + ", idproveedorp=" + proveedornew + ", rutaimagen='" + imagenmodifica + "' where idproducto=" + n + "";
                        NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                        cmdUp.ExecuteNonQuery();
                        MessageBox.Show("REGISTRO MODIFICADO.....");
                        txtIdProductoBM.Text = "";
                        txtProductoBuscadoM.Text = "";
                        txtProductoBM.Text = "";
                        txtPrecioProductoBM.Text = "";
                        txtCostoProductoBM.Text = "";
                        txtProveedorProductoBM.Text = "";
                        txtCantidadProductoBM.Text = "";

                        dbcon.Close();

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }

                    // DataTable memoria = new DataTable();

                    /* switch (comboModificaProducto.SelectedIndex)
                     {

                         case 0:
                             break;
                         case 1:
                             //---------------------------------------------------------------------------------------------     
                             if (txtIdProductoBM.Text == "" || txtINMProductoM.Text == "")
                             {
                                 MessageBox.Show("DEBES INTRODUCIR EL ID PARA MODIFICAR...");
                                 txtIdProductoBM.Focus();
                             }
                             else
                             {
                                 try
                                 {
                                     int n = Convert.ToInt32(txtIdProductoBM.Text);
                                     NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                     "Database=Bolsa;" +
                                     "User ID=gabrielaflores;" + "Port=5344");
                                     dbcon.Open();

                                     int cantidadnew =Convert.ToInt32(txtINMProductoM.Text);
                                     string queryUp = "update Producto set cantidadp=" + cantidadnew + " where idproducto=" + n + "";
                                     NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                     cmdUp.ExecuteNonQuery();
                                     MessageBox.Show("REGISTRO MODIFICADO.....");
                                     txtIdProductoBM.Text = "";
                                     txtINMProductoM.Text = "";
                                     dbcon.Close();

                                 }
                                 catch (Exception msg)
                                 {
                                     MessageBox.Show(msg.ToString());
                                 }
                             }
                             break;
                         //--------------------------------------------------------------------------------------------
                         case 2:
                             if (txtIdProductoBM.Text == "" || txtINMProductoM.Text == "")
                             {
                                 MessageBox.Show("DEBES INTRODUCIR EL ID Y CIUDAD PARA MODIFICAR...");
                                 txtIdProductoBM.Focus();
                             }
                             else
                             {
                                 try
                                 {
                                     int n = Convert.ToInt32(txtIdProductoBM.Text);
                                     NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                     "Database=Bolsa;" +
                                     "User ID=gabrielaflores;" + "Port=5344");
                                     dbcon.Open();

                                     int precionew = Convert.ToInt32(txtINMProductoM.Text); ;
                                     string queryUp = "update Producto set precio=" + precionew + " where idproducto=" + n + "";
                                     NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                     cmdUp.ExecuteNonQuery();
                                     MessageBox.Show("REGISTRO MODIFICADO.....");
                                     txtIdProductoBM.Text = "";
                                     txtINMProductoM.Text = "";
                                     dbcon.Close();

                                 }
                                 catch (Exception msg)
                                 {
                                     MessageBox.Show(msg.ToString());
                                 }
                             }


                             break;
                         //------------------------------------------------------------------------------------------------------------------------
                         case 3:
                             if (txtIdProductoBM.Text == "" || txtINMProductoM.Text == "")
                             {
                                 MessageBox.Show("DEBES INTRODUCIR EL ID Y TELEFONO PARA MODIFICAR...");
                                 txtIdProductoBM.Focus();
                             }
                             else
                             {
                                 try
                                 {
                                     int n = Convert.ToInt32(txtIdProductoBM.Text);
                                     NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                     "Database=Bolsa;" +
                                     "User ID=gabrielaflores;" + "Port=5344");
                                     dbcon.Open();

                                     int costonew = Convert.ToInt32(txtINMProductoM.Text);
                                     string queryUp = "update Producto set costo=" + costonew + " where idproducto=" + n + "";
                                     NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                     cmdUp.ExecuteNonQuery();
                                     MessageBox.Show("REGISTRO MODIFICADO.....");
                                     txtIdProductoBM.Text = "";
                                     txtINMProductoM.Text = "";
                                     dbcon.Close();

                                 }
                                 catch (Exception msg)
                                 {
                                     MessageBox.Show(msg.ToString());
                                 }
                             }


                             break;
                         //-----------------------------------------------------------------------------------------------------------------------


                     }*/
                }
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnCambiaImagen_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog seleccionimagenmodifica = new OpenFileDialog();
            seleccionimagenmodifica.Filter = "image files (*.jpg)|*.jpg|All files(*.*)|*.*";
            seleccionimagenmodifica.InitialDirectory = "c:\\users\\Gaby\\mis imagenes";
            seleccionimagenmodifica.Title = "Seleccione Imagen para el producto";

            if (seleccionimagenmodifica.ShowDialog() == DialogResult.OK)
            {
                //pbxmodificaimagen.ImageLocation = seleccionimagenmodifica.FileName;
                //imagenmodifica = seleccionimagenmodifica.FileName;
                //MessageBox.Show(rutaimagenmodifica);*/
            try
            {
                OpenFileDialog seleccionimagen = new OpenFileDialog();
                seleccionimagen.Filter = "image files (*.jpg)|*.jpg|All files(*.*)|*.*";
                seleccionimagen.InitialDirectory = "c:\\users\\Gaby\\mis imagenes";
                seleccionimagen.Title = "Seleccione Imagen para el producto";

                if (seleccionimagen.ShowDialog() == DialogResult.OK)
                {
                    pbxmodificaimagen.ImageLocation = seleccionimagen.FileName;
                    imagenmodifica = seleccionimagen.FileName;
                    string direccion = seleccionimagen.FileName;
                    imagenmodifica = seleccionimagen.SafeFileName;
                    string direccioncopiar = Application.StartupPath + @"\" + imagenmodifica;

                    System.IO.File.Copy(direccion, direccioncopiar, true);

                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());}
            
            }
      
    
        private void btnRegresaAP_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }


    }
}