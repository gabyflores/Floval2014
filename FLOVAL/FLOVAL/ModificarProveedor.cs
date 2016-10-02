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
    public partial class ModificarProveedor : Form
    {
        public ModificarProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscarProveedorM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProveedor.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el ID a buscar......");
                }
                else
                {

                    try
                    {
                        int bandera = 0;
                        int ID = Convert.ToInt32(txtIdProveedor.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select * from Proveedor where idproveedor=" + ID + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtIdProveedorM.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idproveedor")));
                            txtNombreProveedorM.Text = reader.GetString(reader.GetOrdinal("nombrep"));
                            txtPtsProveedorM.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("ptosproveedor")));
                            txtMarcaM.Text = reader.GetString(reader.GetOrdinal("marca"));
                            txtCiudadProveedorM.Text = reader.GetString(reader.GetOrdinal("ciudad"));
                            txtEstadoProveedorM.Text = reader.GetString(reader.GetOrdinal("estado"));
                            txtDireccionProveedorM.Text = reader.GetString(reader.GetOrdinal("direccion"));
                            txtTelefonoProveedorM.Text = reader.GetString(reader.GetOrdinal("telefonop"));
                            txtCelularProveedorM.Text = reader.GetString(reader.GetOrdinal("celularp"));
                            txtCorreoProveedorM.Text = reader.GetString(reader.GetOrdinal("correop"));


                            bandera = 1;

                            //txtIdProveedorM.ReadOnly = false;
                            txtNombreProveedorM.ReadOnly = false;
                            //txtPtsProveedorM.ReadOnly = false;
                            txtMarcaM.ReadOnly = false;
                            txtCiudadProveedorM.ReadOnly = false;
                            txtEstadoProveedorM.ReadOnly = false;
                            txtDireccionProveedorM.ReadOnly = false;
                            txtTelefonoProveedorM.ReadOnly = false;
                            txtCelularProveedorM.ReadOnly = false;
                            txtCorreoProveedorM.ReadOnly = false;


                            // txtBuscado.Clear();
                        }
                        dbcon.Close();
                        if (bandera == 0)
                        {
                            MessageBox.Show("REGISTRO NO ENCONTRADO......");
                            txtIdProveedorM.Text = "";
                            txtNombreProveedorM.Text = "";
                            txtPtsProveedorM.Text = "";
                            txtMarcaM.Text = "";
                            txtCiudadProveedorM.Text = "";
                            txtEstadoProveedorM.Text = "";
                            txtDireccionProveedorM.Text = "";
                            txtTelefonoProveedorM.Text = "";
                            txtCelularProveedorM.Text = "";
                            txtCorreoProveedorM.Text = "";

                            //  txtID.Text = "";
                            txtIdProveedor.Clear();
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

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdProveedor.Text == "")
                {
                    MessageBox.Show("DEBES INTRODUCIR El ID A ACTUALIZAR Y LA INFORMACION QUE QUIERAS CAMBIAR....");
                    txtIdProveedor.Focus();
                }
                else
                {

                    //DataTable memoria = new DataTable();

                    try
                    {
                        int n = Convert.ToInt32(txtIdProveedor.Text);
                        NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();

                        string nombrenew = txtNombreProveedorM.Text;
                        //int puntosnew = txtPtsProveedorM.Text;//NO MODIFICA PTOS
                        string marcanew = txtMarcaM.Text;
                        string ciudadnew = txtCiudadProveedorM.Text;
                        string estadonew = txtEstadoProveedorM.Text;
                        string direccionnew = txtDireccionProveedorM.Text;
                        string telefononew = txtTelefonoProveedorM.Text;
                        string celularnew = txtCelularProveedorM.Text;
                        string correonew = txtCorreoProveedorM.Text;

                        string queryUp = "update Proveedor set nombrep='" + nombrenew + "',marca='" + marcanew + "',ciudad='" + ciudadnew + "',estado='" + estadonew + "',direccion='" + direccionnew + "', telefonop='" + telefononew + "',celularp='" + celularnew + "', correop='" + correonew + "' where idproveedor=" + n + "";
                        NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                        cmdUp.ExecuteNonQuery();
                        MessageBox.Show("REGISTRO MODIFICADO.....");
                        txtIdProveedor.Text = "";
                        txtIdProveedorM.Text = "";
                        txtNombreProveedorM.Text = "";
                        txtPtsProveedorM.Text = "";
                        txtMarcaM.Text = "";
                        txtCiudadProveedorM.Text = "";
                        txtEstadoProveedorM.Text = "";
                        txtDireccionProveedorM.Text = "";
                        txtTelefonoProveedorM.Text = "";
                        txtCelularProveedorM.Text = "";
                        txtCorreoProveedorM.Text = "";


                        dbcon.Close();

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }

                    /*switch (comboModificaProveedor.SelectedIndex)
                    {

                        case 0:
                            break;
                        case 1:
                            //---------------------------------------------------------------------------------------------     
                            if (txtIdProveedor.Text == "" || txtINModificaProveedor.Text == "")
                            {
                                MessageBox.Show("DEBES INTRODUCIR EL ID Y NOMBRE PARA MODIFICAR...");
                                txtIdProveedor.Focus();
                            }
                            else
                            {
                                try
                                {
                                    int n = Convert.ToInt32(txtIdProveedor.Text);
                                    NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                    "Database=Bolsa;" +
                                    "User ID=gabrielaflores;" + "Port=5344");
                                    dbcon.Open();

                                    string nombrenew = txtINModificaProveedor.Text;
                                    string queryUp = "update Proveedor set nombrep='" + nombrenew + "' where idproveedor=" + n + "";
                                    NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                    cmdUp.ExecuteNonQuery();
                                    MessageBox.Show("REGISTRO MODIFICADO.....");
                                    txtIdProveedor.Text = "";
                                    txtINModificaProveedor.Text = "";
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
                            if (txtIdProveedor.Text == "" || txtINModificaProveedor.Text == "")
                            {
                                MessageBox.Show("DEBES INTRODUCIR EL ID Y CIUDAD PARA MODIFICAR...");
                                txtIdProveedor.Focus();
                            }
                            else
                            {
                                try
                                {
                                    int n = Convert.ToInt32(txtIdProveedor.Text);
                                    NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                    "Database=Bolsa;" +
                                    "User ID=gabrielaflores;" + "Port=5344");
                                    dbcon.Open();

                                    string ciudadnew = txtINModificaProveedor.Text;
                                    string queryUp = "update Proveedor set ciudad='" + ciudadnew + "' where idproveedor=" + n + "";
                                    NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                    cmdUp.ExecuteNonQuery();
                                    MessageBox.Show("REGISTRO MODIFICADO.....");
                                    txtIdProveedor.Text = "";
                                    txtINModificaProveedor.Text = "";
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
                            if (txtIdProveedor.Text == "" || txtINModificaProveedor.Text == "")
                            {
                                MessageBox.Show("DEBES INTRODUCIR EL ID Y TELEFONO PARA MODIFICAR...");
                                txtIdProveedor.Focus();
                            }
                            else
                            {
                                try
                                {
                                    int n = Convert.ToInt32(txtIdProveedor.Text);
                                    NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                                    "Database=Bolsa;" +
                                    "User ID=gabrielaflores;" + "Port=5344");
                                    dbcon.Open();

                                    string telnew = txtINModificaProveedor.Text;
                                    string queryUp = "update Proveedor set telefonop='" + telnew + "' where idproveedor=" + n + "";
                                    NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                                    cmdUp.ExecuteNonQuery();
                                    MessageBox.Show("REGISTRO MODIFICADO.....");
                                    txtIdProveedor.Text = "";
                                    txtINModificaProveedor.Text = "";
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
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresarAP_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
