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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdClienteB.Text == "") {
                    MessageBox.Show("FAVOR DE INTRODUCIR UN ID");
                }

                else{
                int bandera = 0;
                int ID = Convert.ToInt32(txtIdClienteB.Text);
                IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                    + "Database=Bolsa;" +
                "User ID=gabrielaflores;" + "Port=5344");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "select * from Cliente where idcliente=" + ID + "";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                    txtClienteBuscado.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idcliente")));
                    txtNombreClienteB.Text = reader.GetString(reader.GetOrdinal("nombrec"));
                    txtRfcClienteB.Text = reader.GetString(reader.GetOrdinal("rfccliente"));
                    txtTelefonoClienteB.Text = reader.GetString(reader.GetOrdinal("telefono"));
                    txtCelularClienteB.Text = reader.GetString(reader.GetOrdinal("celular"));
                    txtCorreoClienteB.Text = reader.GetString(reader.GetOrdinal("correo"));
                    txtCiudadClienteB.Text = reader.GetString(reader.GetOrdinal("ciudad"));
                    txtEstadoClienteB.Text = reader.GetString(reader.GetOrdinal("estado"));
                    txtMedioClienteB.Text = reader.GetString(reader.GetOrdinal("mediodecontacto"));
                    bandera = 1;
                    txtIdClienteB.Clear();
                }
                dbcon.Close();
                if (bandera == 0)
                {
                    MessageBox.Show("CLIENTE NO ENCONTRADO......");
                    txtClienteBuscado.Text ="";
                    txtNombreClienteB.Text ="";
                    txtRfcClienteB.Text ="";
                    txtTelefonoClienteB.Text ="";
                    txtCelularClienteB.Text ="";
                    txtCorreoClienteB.Text ="";
                    txtCiudadClienteB.Text ="";
                    txtEstadoClienteB.Text ="";
                    txtMedioClienteB.Text ="";
                    txtIdClienteB.Clear();
                }

            }

            }
            catch (Exception msg)
            {
                MessageBox.Show("error.....\n\n" + msg.ToString());
            }
        }

        private void txtBuscaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtBuscaCliente.Text == "")
                    {
                        MessageBox.Show("DEBES INTRODUCIR EL ID DEL PRODUCTO....");
                        txtBuscaCliente.Focus();
                    }
                    else
                    {

                        DataTable memoria = new DataTable();

                        switch (comboBuscarClientes.SelectedIndex)
                        {

                            case 0:
                                break;
                            case 1:
                                //---------------------------------------------------------------------------------------------     
                                try
                                {
                                    string buscado = txtBuscaCliente.Text;
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Cliente where nombrec='" + buscado + "'", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscaCliente.DataSource = memoria.DefaultView;
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
                                    string buscado = txtBuscaCliente.Text;
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Cliente where rfccliente='" + buscado + "'", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscaCliente.DataSource = memoria.DefaultView;
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
                                    string buscado = txtBuscaCliente.Text;
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Cliente where estado='" + buscado + "'", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscaCliente.DataSource = memoria.DefaultView;
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

        private void btnRegresar_Click(object sender, EventArgs e)
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
