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
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscaMCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdClienteBM.Text == "")
                {
                    MessageBox.Show("Favor de Introducir el ID a buscar......");
                }
                else
                {
                    try
                    {
                        int bandera = 0;
                        int ID = Convert.ToInt32(txtIdClienteBM.Text);
                        IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                            + "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();
                        IDbCommand dbcmd = dbcon.CreateCommand();
                        dbcmd.CommandText = "select * from Cliente where idcliente=" + ID + "";
                        IDataReader reader = dbcmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtClienteBuscadoM.Text = Convert.ToString(reader.GetInt32(reader.GetOrdinal("idcliente")));//PONER ESTE PARA QUE NO SE PUEDA MODIFICAR
                            txtNombreClienteM.Text = reader.GetString(reader.GetOrdinal("nombrec"));
                            txtRfcClienteBM.Text = reader.GetString(reader.GetOrdinal("rfccliente"));
                            txtTelefonoClienteBM.Text = reader.GetString(reader.GetOrdinal("telefono"));
                            txtCelularClienteBM.Text = reader.GetString(reader.GetOrdinal("celular"));
                            txtCorreoClienteBM.Text = reader.GetString(reader.GetOrdinal("correo"));
                            txtCiudadClienteBM.Text = reader.GetString(reader.GetOrdinal("ciudad"));
                            txtEstadoClienteBM.Text = reader.GetString(reader.GetOrdinal("estado"));
                            txtMedioClienteBM.Text = reader.GetString(reader.GetOrdinal("mediodecontacto"));


                            bandera = 1;

                            //txtClienteBuscadoM.ReadOnly = false;
                            txtNombreClienteM.ReadOnly = false;
                            txtRfcClienteBM.ReadOnly = false;
                            txtTelefonoClienteBM.ReadOnly = false;
                            txtCelularClienteBM.ReadOnly = false;
                            txtCorreoClienteBM.ReadOnly = false;
                            txtCiudadClienteBM.ReadOnly = false;
                            txtEstadoClienteBM.ReadOnly = false;
                            txtMedioClienteBM.ReadOnly = false;





                            // txtBuscado.Clear();
                        }
                        dbcon.Close();
                        if (bandera == 0)
                        {
                            MessageBox.Show("REGISTRO NO ENCONTRADO......");
                            txtClienteBuscadoM.Text = "";
                            txtNombreClienteM.Text = "";
                            txtRfcClienteBM.Text = "";
                            txtTelefonoClienteBM.Text = "";
                            txtCelularClienteBM.Text = "";
                            txtCorreoClienteBM.Text = "";
                            txtCiudadClienteBM.Text = "";
                            txtEstadoClienteBM.Text = "";
                            txtMedioClienteBM.Text = "";

                            //  txtID.Text = "";
                            txtIdClienteBM.Clear();
                        }

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show("error.....\n\n" + msg.ToString());
                    }
                }
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdClienteBM.Text == "" || txtClienteBuscadoM.Text == "" || txtNombreClienteM.Text == "" || txtRfcClienteBM.Text == "" || txtTelefonoClienteBM.Text == "" || txtCelularClienteBM.Text == "" || txtCorreoClienteBM.Text == "" || txtCiudadClienteBM.Text == "" || txtEstadoClienteBM.Text == "" || txtMedioClienteBM.Text == "")
                {// || txtRfcClienteBM.Text=="" || txtTelefonoClienteBM.Text=="" || txtCelularClienteBM.Text=="" || txtCorreoClienteBM.Text=="" || txtCiudadClienteBM.Text=="")
                    MessageBox.Show("DEBES INTRODUCIR El ID A ACTUALIZAR Y LA INFORMACION QUE QUIERAS CAMBIAR....");
                    txtIdClienteBM.Focus();
                    //AQUI HAY QUE VERIFICAR QUE SE PUEDAN INTRODUCIR VALORES NULOS 
                }
                else
                {

                    //DataTable memoria = new DataTable();
                    try
                    {
                        int n = Convert.ToInt32(txtIdClienteBM.Text);
                        NpgsqlConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                        "Database=Bolsa;" +
                        "User ID=gabrielaflores;" + "Port=5344");
                        dbcon.Open();

                        string nombrenew = txtNombreClienteM.Text;//NO MODIFICA ID
                        string rfcnew = txtRfcClienteBM.Text;
                        string telefononew = txtTelefonoClienteBM.Text;
                        string celularnew = txtCelularClienteBM.Text;
                        string correonew = txtCorreoClienteBM.Text;
                        string ciudadnew = txtCiudadClienteBM.Text;
                        string estadonew = txtEstadoClienteBM.Text;
                        string medionew = txtMedioClienteBM.Text;

                        string queryUp = "update Cliente set nombrec='" + nombrenew + "',rfccliente='" + rfcnew + "',telefono='" + telefononew + "',celular='" + celularnew + "',correo='" + correonew + "', ciudad='" + ciudadnew + "',estado='" + estadonew + "',mediodecontacto='" + medionew + "' where idcliente=" + n + "";
                        NpgsqlCommand cmdUp = new NpgsqlCommand(queryUp, dbcon);
                        cmdUp.ExecuteNonQuery();
                        MessageBox.Show("REGISTRO MODIFICADO.....");
                        txtIdClienteBM.Text = "";
                        txtClienteBuscadoM.Text = "";
                        txtNombreClienteM.Text = "";
                        txtRfcClienteBM.Text = "";
                        txtTelefonoClienteBM.Text = "";
                        txtCelularClienteBM.Text = "";
                        txtCorreoClienteBM.Text = "";
                        txtCiudadClienteBM.Text = "";
                        txtEstadoClienteBM.Text = "";
                        txtMedioClienteBM.Text = "";

                        dbcon.Close();

                    }
                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.ToString());
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());

            }
        }
        

        private void btnRegresaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }catch(Exception msg){
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
