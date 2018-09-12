using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wynges.Models;

namespace Wynges.Views
{
    public partial class CatalogoPelicula : Form
    {
        public CatalogoPelicula()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            WyngesModelContainer cnn = new WyngesModelContainer();
            this.dgvPelicula.DataSource = cnn.PeliculaSet.ToList();
        }

        //Método buscarnombre
        private void BuscarNombre()
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    WyngesModelContainer cnn = new WyngesModelContainer();

                    var query = from p in cnn.PeliculaSet
                                where p.Nombre.Contains(txtBuscar.Text)
                                select p;

                    dgvPelicula.DataSource = query.ToList();
                }
            }
            else
            {
                Mostrar();
            }
        }

        private void CatalogoPelicula_Load(object sender, EventArgs e)
        {
            dgvPelicula.AutoGenerateColumns = false;
            Mostrar();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPelicula_DoubleClick(object sender, EventArgs e)
        {
            frmAlquiler form = frmAlquiler.GetInstancia();
            string par1, par2, par3;

            par1 = Convert.ToString(this.dgvPelicula.CurrentRow.Cells[0].Value);
            par2 = Convert.ToString(this.dgvPelicula.CurrentRow.Cells[1].Value);
            par3 = Convert.ToString(this.dgvPelicula.CurrentRow.Cells[3].Value);
            form.setPelicula(par1, par2, par3);
            this.Hide();
        }
    }
}
