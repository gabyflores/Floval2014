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
    public partial class MostrarProducto : Form
    {
        public MostrarProducto()
        {
            InitializeComponent();
        }

        private void MostrarProducto_Load(object sender, EventArgs e)
        {
            DataTable memoria = new DataTable();
            try
            {

                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Producto", conexion);
                datosConsulta.Fill(memoria);
                dgvMostrarProductos.DataSource = memoria.DefaultView;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }

        }

        private void btnRegresaRP_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception msg) { MessageBox.Show(msg.ToString()); 
            
            }
        }

        private void dgvMostrarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int busca = Convert.ToInt32(dgvMostrarProductos.CurrentCell.Value.ToString());

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
                            pboxProductoMuestra.Image = new Bitmap(nombreimagen);

                        }
                        else {
                            MessageBox.Show("NO TIENE IMAGEN");
                        }


               /* DataTable memoria2 = new DataTable();
                NpgsqlConnection conecta = new NpgsqlConnection("Server=localhost;" + "Database=Bolsa;" + "User ID=gabrielaflores;" + "Port=5344");

                conecta.Open();
                NpgsqlDataAdapter consulta = new NpgsqlDataAdapter("select idproductod,cantidadv,preciov from DetalleVenta where folioventad=" + busca + "", conecta);

                consulta.Fill(memoria2);
                 dgvMostrarProductos.DataSource = memoria2.DefaultView;*/
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());

            }
        }
    }
}
