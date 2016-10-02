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
    public partial class MostrarCambio : Form
    {
        public MostrarCambio()
        {
            InitializeComponent();
        }

        private void MostrarCambio_Load(object sender, EventArgs e)
        {
            
            try
            {
                DataTable memoria = new DataTable();
                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Cambio", conexion);
                datosConsulta.Fill(memoria);
                dgvMuestraCambio.DataSource = memoria.DefaultView;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void dgvMuestraCambio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int busca = Convert.ToInt32(dgvMuestraCambio.CurrentCell.Value.ToString());
                DataTable memoria2 = new DataTable();
                NpgsqlConnection conecta = new NpgsqlConnection("Server=localhost;" + "Database=Bolsa;" + "User ID=gabrielaflores;" + "Port=5344");

                conecta.Open();
                NpgsqlDataAdapter consulta = new NpgsqlDataAdapter("select idproductoreg,cantidadreg,precioreg,idproductolleva,cantidadlleva,preciolleva  from DetalleCambio where foliocambiod=" + busca + "", conecta);

                consulta.Fill(memoria2);
                dgvMuestraDetalleCambio.DataSource = memoria2.DefaultView;
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.ToString());

            }
        }

        private void btnRegresaMC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
