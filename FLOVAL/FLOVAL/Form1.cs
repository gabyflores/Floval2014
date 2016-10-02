using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Process Servidor = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1RegistrarCliente_Click(object sender, EventArgs e)
        {
            RegistroCliente n = new RegistroCliente();
            n.Show();
        }

        private void toolStripMenuItem1RegistrarProveedor_Click(object sender, EventArgs e)
        {
            RegistrarProveedor m = new RegistrarProveedor();
            m.Show();
        }

        private void toolStripMenuItem1MostrarCliente_Click(object sender, EventArgs e)
        {
            MostrarCliente j = new MostrarCliente();
            j.Show();
        }

        private void toolStripMenuItem1MostrarProveedor_Click(object sender, EventArgs e)
        {
            MostrarProveedor l = new MostrarProveedor();
            l.Show();
        }

        private void toolStripMenuItem1RegistrarProducto_Click(object sender, EventArgs e)
        {
            RegistrarProducto h = new RegistrarProducto();
            h.Show();
        }

        private void toolStripMenuItem1MostrarProducto_Click(object sender, EventArgs e)
        {
            MostrarProducto k = new MostrarProducto();
            k.Show();
        }

        private void toolStripMenuItem1BuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente b = new BuscarCliente();
            b.Show();
        }

        private void toolStripMenuItem1BuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto a = new BuscarProducto();
            a.Show();
        }

        private void toolStripMenuItem1BuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedor c = new BuscarProveedor();
            c.Show();
        }

        private void toolStripMenuItem1Modificar_Click(object sender, EventArgs e)
        {
            ModificarProveedor y = new ModificarProveedor();
            y.Show();
        }

        private void toolStripMenuItem1BuscarVarios_Click(object sender, EventArgs e)
        {
            BuscarVarios d = new BuscarVarios();
            d.Show();
        }

        private void toolStripMenuItem1ModificaCliente_Click(object sender, EventArgs e)
        {
            ModificarCliente w = new ModificarCliente();
            w.Show();
        }

        private void toolStripMenuItem1ModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto s = new ModificarProducto();
            s.Show();
        }

        private void toolStripMenuItem1RegistrarCompra_Click(object sender, EventArgs e)
        {
            RegistrarCompra z = new RegistrarCompra();
            z.Show();
        }

        private void toolStripMenuItem1RegistrarVenta_Click(object sender, EventArgs e)
        {
            RegistrarVenta bi = new RegistrarVenta();
            bi.Show();
        }

        private void toolStripMenuItem1RegistrarCambio_Click(object sender, EventArgs e)
        {
            RegistrarCambio ba = new RegistrarCambio();
            ba.Show();
        }

        private void toolStripMenuItem1MostrarCompra_Click(object sender, EventArgs e)
        {
            MostrarCompra ms = new MostrarCompra();
            ms.Show();
        }

        private void toolStripMenuItem1MostrarVenta_Click(object sender, EventArgs e)
        {
            MostrarVenta mis = new MostrarVenta();
            mis.Show();
        }

        private void toolStripMenuItem1MostrarCambio_Click(object sender, EventArgs e)
        {
            MostrarCambio kl = new MostrarCambio();
            kl.Show();
        }

        private void toolStripMenuItem1BuscarVenta_Click(object sender, EventArgs e)
        {
            BuscarVenta ls = new BuscarVenta();
            ls.Show();
        }

        private void toolStripMenuItem1BuscarCambio_Click(object sender, EventArgs e)
        {
            BuscarCambio nj = new BuscarCambio();
            nj.Show();
        }

        private void toolStripMenuItem1BuscarCompra_Click(object sender, EventArgs e)
        {
            BuscarCompra fg = new BuscarCompra();
            fg.Show();
        }

        private void toolStripMenuItem1AgregarPedido_Click(object sender, EventArgs e)
        {
            AgregarPedido agp = new AgregarPedido();
            agp.Show();
        }

        private void toolStripMenuItem1BuscarPedido_Click(object sender, EventArgs e)
        {
            BuscarPedido bp = new BuscarPedido();
            bp.Show();
        }

        private void toolStripMenuItem1MostrarPedido_Click(object sender, EventArgs e)
        {
            MostrarPedido mp = new MostrarPedido();
            mp.Show();
        }

        private void btnSalirAplicacion_Click(object sender, EventArgs e)
        {
            Servidor.StartInfo.FileName = "kill.bat";
            Servidor.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            Servidor.Start();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Servidor.StartInfo.FileName = "arranque.bat";
            Servidor.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            Servidor.Start();
        }
    }
}
