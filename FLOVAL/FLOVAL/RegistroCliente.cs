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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCliente.Text == "" || txtRfcCliente.Text == "" || txtTelefonoCliente.Text == "" || txtCelularCliente.Text == "" || txtCorreoCliente.Text == "" || txtCiudadCliente.Text == "" || txtEstadoCliente.Text == "" || txtMedioCliente.Text == "")
                {
                    MessageBox.Show("Favor de Introducir los Datos");
                }
                else
                {
                    try
                    {
                        //-----------------------------------------------Pide Datos--------------------------------------------------
                        int Id = Convert.ToInt32(txtIdCliente.Text);
                        string NombreCliente = txtNombreCliente.Text;
                        string RfcCliente = txtRfcCliente.Text;
                        string TelefonoCliente = txtTelefonoCliente.Text;
                        string CelularCliente = txtCelularCliente.Text;
                        string CorreoCliente = txtCorreoCliente.Text;
                        string CiudadCliente = txtCiudadCliente.Text;
                        string EstadoCliente = txtEstadoCliente.Text;
                        string MedioContacto = txtMedioCliente.Text;

                        //-----------------------------------------------------------Conexion-----------------------------------------

                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "insert into Cliente values(" + Id + ",'" + NombreCliente + "','" + RfcCliente + "','" + TelefonoCliente + "','" + CelularCliente + "','" + CorreoCliente + "','" + CiudadCliente + "', '" + EstadoCliente + "','" + MedioContacto + "')";
                        IDataReader reader = dbcmd.ExecuteReader();
                        dbcon.Close();

                        //---------------------------------------------------Limpiar------------------------------------------------------
                        //txtIdCliente.Text = "";
                        txtNombreCliente.Text = "";
                        txtRfcCliente.Text = "";
                        txtTelefonoCliente.Text = "";
                        txtCelularCliente.Text = "";
                        txtCorreoCliente.Text = "";
                        txtCiudadCliente.Text = "";
                        txtEstadoCliente.Text = "";
                        txtMedioCliente.Text = "";

                        IDbConnection dbcon1 = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon1.Open();
                        IDbCommand dbcmd1 = dbcon1.CreateCommand();
                        dbcmd1.CommandText = "select * from Cliente order by idcliente desc limit 1";
                        IDataReader reader1 = dbcmd1.ExecuteReader();
                        reader1.Read();
                        dbcon1.Close();

                        int x;
                        x = reader1.GetInt32(reader1.GetOrdinal("idcliente"));
                        x = x + 1; ;

                        txtIdCliente.Text = Convert.ToString(x);




                        MessageBox.Show("Cliente Registrado correctamente");
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

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                int idcliente;

                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                conexion.Open();

                IDbCommand dbcmd2 = conexion.CreateCommand();
                dbcmd2.CommandText = "select * from Cliente order by idcliente desc limit 1";
                IDataReader reader2 = dbcmd2.ExecuteReader();
                conexion.Close();

                if (reader2.Read())
                {
                    idcliente = reader2.GetInt32(reader2.GetOrdinal("idcliente"));
                    //EtiquetaId.Text = Convert.ToString(idproducto);
                    x = idcliente;
                    x += 1;
                    txtIdCliente.Text = Convert.ToString(x);


                }
                else
                {

                    x = 1;
                    txtIdCliente.Text = Convert.ToString(x);

                }



            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
