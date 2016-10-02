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
    public partial class MostrarVenta : Form
    {
        public MostrarVenta()
        {
            InitializeComponent();
        }

        private void MostrarVenta_Load(object sender, EventArgs e)
        {

            DataTable memoria = new DataTable();
            try
            {

                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Venta", conexion);
                datosConsulta.Fill(memoria);
                dgvMuestraVenta.DataSource = memoria.DefaultView;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }


        }

        private void dgvMuestraVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int busca = Convert.ToInt32(dgvMuestraVenta.CurrentCell.Value.ToString());
                DataTable memoria2 = new DataTable();
                NpgsqlConnection conecta = new NpgsqlConnection("Server=localhost;" + "Database=Bolsa;" + "User ID=gabrielaflores;" + "Port=5344");

                conecta.Open();
                NpgsqlDataAdapter consulta = new NpgsqlDataAdapter("select idproductod,cantidadv,preciov from DetalleVenta where folioventad=" + busca + "", conecta);

                consulta.Fill(memoria2);
                dgvMuestraDetalle.DataSource = memoria2.DefaultView;
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());

            }

        }

        private void btnRegresaMV_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvMuestraDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                int bandera = 0;
                int ID = Convert.ToInt32(dgvMuestraDetalle.CurrentCell.Value.ToString());
                IDbConnection dbcon = new NpgsqlConnection("Server=localhost;"
                    + "Database=Bolsa;" +
                "User ID=gabrielaflores;" + "Port=5344");
                dbcon.Open();
                IDbCommand dbcmd = dbcon.CreateCommand();
                dbcmd.CommandText = "select rutaimagen from Producto where idproducto=" + ID + "";
                IDataReader reader = dbcmd.ExecuteReader();
                if (reader.Read())
                {
                    string nombreimagen = reader.GetString(reader.GetOrdinal("rutaimagen"));
                    pboxMostrarVenta.Image = new Bitmap(nombreimagen);
                    bandera = 1;

                }
                if (bandera == 0)
                {
                    MessageBox.Show("No tiene imagen");
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }
    }
}

