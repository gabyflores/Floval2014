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
    public partial class MostrarCliente : Form
    {
        public MostrarCliente()
        {
            InitializeComponent();
        }

        private void MostrarCliente_Load(object sender, EventArgs e)
        {
            DataTable memoria = new DataTable();
            try
            {

                NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;"
                        + "Database=Bolsa;" +
                    "User ID=gabrielaflores;" + "Port=5344");
                NpgsqlDataAdapter datosConsulta = new NpgsqlDataAdapter("select * from Cliente", conexion);
                datosConsulta.Fill(memoria);
                dgvClienteMuestra.DataSource = memoria.DefaultView;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnRegresarCR_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
