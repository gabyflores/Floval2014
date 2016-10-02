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
    public partial class BuscarVarios : Form
    {
        public BuscarVarios()
        {
            InitializeComponent();
        }

        private void txtBuscaVarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                    if (txtBuscaVarios.Text == "")
                    {
                        MessageBox.Show("DEBES INTRODUCIR UN DATO A BUSCAR....");
                        txtBuscaVarios.Focus();
                    }
                    else
                    {

                        DataTable memoria = new DataTable();

                        switch (comboBuscaVariosP.SelectedIndex)
                        {

                            case 0:
                                break;
                            case 1:
                                //---------------------------------------------------------------------------------------------     
                                try
                                {
                                    int buscado = Convert.ToInt32(txtBuscaVarios.Text);
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Producto where cantidadp=" + buscado + "", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscaVarios.DataSource = memoria.DefaultView;
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
                                    double buscado = Convert.ToDouble(txtBuscaVarios.Text);
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Producto where precio=" + buscado + "", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscaVarios.DataSource = memoria.DefaultView;
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
                                    double buscado = Convert.ToDouble(txtBuscaVarios.Text);
                                    NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                                          + "Database=Bolsa;" +
                                      "User ID=gabrielaflores;" + "Port=5344");
                                    NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Producto where costo=" + buscado + "", conexion);
                                    datosConsulta.Fill(memoria);
                                    dgvBuscaVarios.DataSource = memoria.DefaultView;
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

        private void btnRegresaBuscaVarios_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
        }

        private void dgvBuscaVarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int busca = Convert.ToInt32(dgvBuscaVarios.CurrentCell.Value.ToString());

                IDbConnection dbcon = new NpgsqlConnection("Server=localhost;" +
                       "Database=Bolsa;" +
                       "User ID=gabrielaflores;" + "Port=5344");
                dbcon.Open();

                IDbCommand dbcmd = dbcon.CreateCommand();

                dbcmd.CommandText = "select rutaimagen from Producto where idproducto=" + busca + "";
                IDataReader reader = dbcmd.ExecuteReader();

                if (reader.Read())
                {

                    string nombreimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                    pboxBuscaVariosProductos.Image = new Bitmap(nombreimagen);

                }
                else
                {
                    MessageBox.Show("NO TIENE IMAGEN");
                }
            }
            catch (Exception msg) {
                MessageBox.Show(msg.ToString());
            }
    }
}
    }