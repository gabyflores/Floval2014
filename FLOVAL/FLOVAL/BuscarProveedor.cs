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
    public partial class BuscarProveedor : Form
    {
        public BuscarProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
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
                    txtProveedorB.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idproveedor")));
                    txtNombreProveedorB.Text = reader.GetString(reader.GetOrdinal("nombrep"));
                    txtPtsProveedorB.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("ptosproveedor")));
                    txtMarcaB.Text = reader.GetString(reader.GetOrdinal("marca"));
                    txtCiudadProveedorB.Text = reader.GetString(reader.GetOrdinal("ciudad"));
                    txtEstadoProveedorB.Text = reader.GetString(reader.GetOrdinal("estado"));
                    txtDireccionProveedorB.Text = reader.GetString(reader.GetOrdinal("direccion"));
                    txtTelefonoProveedorB.Text = reader.GetString(reader.GetOrdinal("telefonop"));
                    txtCelularProveedorB.Text = reader.GetString(reader.GetOrdinal("celularp"));
                    txtCorreoProveedorB.Text = reader.GetString(reader.GetOrdinal("correop"));

                    bandera = 1;
                    //txtIdProveedor.Clear();
                }
                dbcon.Close();
                if (bandera == 0)
                {
                    MessageBox.Show("PROVEEDOR NO ENCONTRADO......");
                    txtProveedorB.Text = "";
                    txtNombreProveedorB.Text = "";
                    txtPtsProveedorB.Text = "";
                    txtMarcaB.Text = "";
                    txtCiudadProveedorB.Text = "";
                    txtEstadoProveedorB.Text = "";
                    txtDireccionProveedorB.Text = "";
                    txtTelefonoProveedorB.Text = "";
                    txtCelularProveedorB.Text = "";
                    txtCorreoProveedorB.Text = "";


                    txtIdProveedor.Clear();
                }

            }
            catch (Exception msg)
            {
                MessageBox.Show("error.....\n\n" + msg.ToString());
            }
        }

        private void comboBoxProveedorBus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txtBuscarCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtBuscarCombo.Text == "")
                    {
                        MessageBox.Show("DEBES INTRODUCIR UN VALOR A BUSCAR....");
                        txtBuscarCombo.Focus();
                    }
                    else
                    {

                        DataTable memoria = new DataTable();

                        switch (comboBoxProveedorBus.SelectedIndex)
                        {

                            case 0:
                                break;
                            case 1:
                                //---------------------------------------------------------------------------------------------     
                                try
                                {
                                    string buscado = txtBuscarCombo.Text;
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Proveedor where nombrep='" + buscado + "'", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscarProveedor.DataSource = memoria.DefaultView;
                                }
                                catch (Exception msg)
                                {
                                    MessageBox.Show(msg.ToString());
                                }

                                break;
                            //--------------------------------------------------------------------------------------------
                            case 2:

                                try
                                {
                                    int buscado1 = Convert.ToInt32(txtBuscarCombo.Text);
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Proveedor where ptosproveedor=" + buscado1 + "", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscarProveedor.DataSource = memoria.DefaultView;
                                }
                                catch (Exception msg)
                                {
                                    MessageBox.Show(msg.ToString());
                                }

                                break;
                            //------------------------------------------------------------------------------------------------------------------------
                            case 3:
                                try
                                {
                                    string buscado = txtBuscarCombo.Text;
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Proveedor where estado='" + buscado + "'", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscarProveedor.DataSource = memoria.DefaultView;
                                }
                                catch (Exception msg)
                                {
                                    MessageBox.Show(msg.ToString());
                                }


                                break;
                            //-----------------------------------------------------------------------------------------------------------------------


                        }
                    }
                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresrBP_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizarPtos_Click(object sender, EventArgs e)
        {        
            try {
                int idProveedor = Convert.ToInt32(txtIdProveedor.Text);
                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                              + "Database=Bolsa;" +
                              "User ID=gabrielaflores;" + "Port=5344");
                conexion.Open();
                NpgsqlCommand comando = conexion.CreateCommand();
                comando.CommandText = "select SUM(ptoscompra) AS suma from Compra where idproveedorc=" + idProveedor+ "";
                IDataReader lector = comando.ExecuteReader();
                
                long ptosproveedor=0;
                if (lector.Read()) {

                  ptosproveedor = lector.GetInt64(lector.GetOrdinal("suma"));
                  string queryUp = "update Proveedor set ptosproveedor=" + ptosproveedor + " where idproveedor=" + idProveedor + "";
                  NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, conexion);
                  cmdUp.ExecuteNonQuery();
                
                }

                txtPtsProveedorB.Text = Convert.ToString(ptosproveedor);
                conexion.Close();
            
            
            
            
            
            
            
            
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }
    }
}