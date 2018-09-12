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
using Wynges.Views;

namespace Wynges
{
    public partial class CatalogoCliente : Form
    {        
        public CatalogoCliente()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            WyngesModelContainer cnn = new WyngesModelContainer();
            this.dgvCliente.DataSource = cnn.ClienteSet.ToList();            
            lblTotal.Text = "Cantidad de Registros: " + Convert.ToString(dgvCliente.RowCount);
        }

        //Método buscarnombre
        private void BuscarNombre()
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    WyngesModelContainer cnn = new WyngesModelContainer();

                    var query = from p in cnn.ClienteSet
                                where p.Nombre.Contains(txtBuscar.Text)
                                select p;

                    dgvCliente.DataSource = query.ToList();
                }
            }
            else
            {
                Mostrar();
            }
        }

        private void CatalogoCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.AutoGenerateColumns = false;
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

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            frmAlquiler form = frmAlquiler.GetInstancia();
            string par1, par2, par3;

            par1= Convert.ToString(this.dgvCliente.CurrentRow.Cells[0].Value); //dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value.ToString();
            par2 = Convert.ToString(this.dgvCliente.CurrentRow.Cells[1].Value);
            par3= Convert.ToString(this.dgvCliente.CurrentRow.Cells[5].Value);
            form.setCliente(par1, par2,par3);
            this.Hide();
        }
    }
}