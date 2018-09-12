using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Wynges.Views
{
    public partial class Principal : Form
    {
        public int intalquiler=0;
        public Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void AbrirFormInPanel(object formHijo)
        {
            Form fh = formHijo as Form;

            if (intalquiler==1)
            {
                fh = frmAlquiler.GetInstancia();                
            }
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh; intalquiler = 0;
            fh.Show();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width==250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Cliente());
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmPelicula());
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            intalquiler = 1;
            AbrirFormInPanel(new frmAlquiler());
        }
    }
}
