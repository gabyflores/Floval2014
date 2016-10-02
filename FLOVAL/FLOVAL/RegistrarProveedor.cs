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
    public partial class RegistrarProveedor : Form
    {
        public RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreProveedor.Text == "" || txtPtsProveedor.Text == "" || txtMarca.Text == "" || txtCiudadProveedor.Text == "" || txtEstadoProveedor.Text == "" || txtDireccionProveedor.Text == "" || txtTelefonoProveedor.Text == "" || txtCelularProveedor.Text == "" || txtCorreoProveedor.Text == "")
                {
                    MessageBox.Show("Favor de Introducir los Datos");
                }
                else
                {
                    try
                    {
                        //-----------------------------------------------Pide Datos--------------------------------------------------
                        int Id = Convert.ToInt32(txtIdProveedor.Text);
                        string NombreProveedor = txtNombreProveedor.Text;
                        int Ptos = Convert.ToInt32(txtPtsProveedor.Text);
                        string Marca = txtMarca.Text;
                        string CiudadProveedor = txtCiudadProveedor.Text;
                        string EstadoProveedor = txtEstadoProveedor.Text;
                        string DireccionProveedor = txtDireccionProveedor.Text;
                        string TelefonoProveedor = txtTelefonoProveedor.Text;
                        string CelularProveedor = txtCelularProveedor.Text;
                        string CorreoProveedor = txtCorreoProveedor.Text;


                        //-----------------------------------------------------------Conexion-----------------------------------------

                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "insert into Proveedor values(" + Id + ",'" + NombreProveedor + "'," + Ptos + ",'" + Marca + "','" + CiudadProveedor + "','" + EstadoProveedor + "','" + DireccionProveedor + "', '" + TelefonoProveedor + "','" + CelularProveedor + "','" + CorreoProveedor + "')";
                        IDataReader reader = dbcmd.ExecuteReader();
                        dbcon.Close();

                        //---------------------------------------------------Limpiar------------------------------------------------------
                        txtIdProveedor.Text = "";
                        txtNombreProveedor.Text = "";
                        txtPtsProveedor.Text = "";
                        txtMarca.Text = "";
                        txtCiudadProveedor.Text = "";
                        txtEstadoProveedor.Text = "";
                        txtDireccionProveedor.Text = "";
                        txtTelefonoProveedor.Text = "";
                        txtCelularProveedor.Text = "";
                        txtCorreoProveedor.Text = "";


                        IDbConnection dbcon1 = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon1.Open();
                        IDbCommand dbcmd1 = dbcon1.CreateCommand();
                        dbcmd1.CommandText = "select * from Proveedor order by idproveedor desc limit 1";
                        IDataReader reader1 = dbcmd1.ExecuteReader();
                        reader1.Read();
                        dbcon1.Close();

                        int x;
                        x = reader1.GetInt32(reader1.GetOrdinal("idproveedor"));
                        x = x + 1; ;

                        txtIdProveedor.Text = Convert.ToString(x);







                        MessageBox.Show("Proveedor Registrado correctamente");
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

        private void RegistrarProveedor_Load(object sender, EventArgs e)
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
                dbcmd2.CommandText = "select * from Proveedor order by idproveedor desc limit 1";
                IDataReader reader2 = dbcmd2.ExecuteReader();
                conexion.Close();

                if (reader2.Read())
                {
                    idcliente = reader2.GetInt32(reader2.GetOrdinal("idproveedor"));
                    //EtiquetaId.Text = Convert.ToString(idproducto);
                    x = idcliente;
                    x += 1;
                    txtIdProveedor.Text = Convert.ToString(x);


                }
                else
                {

                    x = 1;
                    txtIdProveedor.Text = Convert.ToString(x);

                }



            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresarAP_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
