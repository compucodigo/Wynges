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
    public partial class frmPelicula : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public ListViewItem.ListViewSubItemCollection SubItems;

        public frmPelicula()
        {
            InitializeComponent();
            ttMensaje.SetToolTip(txtNombre, "Ingrese el nombre o título de la película");
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Wynges", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrat mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Wynges", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Limpiar formulario
        private void LimpiarFrm()
        {
            txtBuscar.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkActivo.Checked = false;
        }
        //Habilitar las cajas de textos
        private void Habilitar(bool Valor)
        {
            txtCodigo.ReadOnly = !Valor;
            txtNombre.ReadOnly = !Valor;
            cbClasificacion.Enabled = Valor;
            chkActivo.Enabled = Valor;
        }
        private void Botones()
        {
            if (IsNuevo || IsEditar)
            {
                Habilitar(true);
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
        // Metodo ocultar columnas
        private void Mostrar()
        {
            WyngesModelContainer cnn = new WyngesModelContainer();
            this.dgvPelicula.DataSource = cnn.PeliculaSet.ToList();
            OcultarColumnas();
            lblTotal.Text = "Cantidad de Registros: " + Convert.ToString(dgvPelicula.RowCount);
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
        //Ocultar el chekbox del dataGridView
        private void OcultarColumnas()
        {
            this.dgvPelicula.Columns[0].Visible = false;
            this.dgvPelicula.Columns[1].Visible = false;
        }

        private void frmPelicula_Load(object sender, EventArgs e)
        {
            dgvPelicula.AutoGenerateColumns = false;
            Mostrar();
            Habilitar(false);
            Botones();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(this.dgvPelicula.CurrentRow.Cells["PeliculaId"].Value); //dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = Convert.ToString(this.dgvPelicula.CurrentRow.Cells["Nombre"].Value);
            cbClasificacion.Text = Convert.ToString(this.dgvPelicula.CurrentRow.Cells["Genero"].Value);
            if (Convert.ToString(this.dgvPelicula.CurrentRow.Cells["Estado"].Value) == "A")
            {
                chkActivo.Checked = true;
            }
            else
            {
                chkActivo.Checked = false;
            }
            tbcUno.SelectedIndex = 1;
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dgvPelicula.Columns[0].Visible = true;
            }
            else
            {
                this.dgvPelicula.Columns[0].Visible = false;
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPelicula.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dgvPelicula.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Wynges", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;

                    foreach (DataGridViewRow row in dgvPelicula.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            WyngesModelContainer cnn = new WyngesModelContainer();

                            var query = (from p in cnn.PeliculaSet
                                         where p.PeliculaId.Equals(Codigo)
                                         select p).FirstOrDefault();

                            cnn.PeliculaSet.Remove(query);
                            cnn.SaveChanges();
                            this.MensajeOk("Se Eliminó Correctamente el registro");
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.LimpiarFrm();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.LimpiarFrm();
            this.txtCodigo.Text = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    if (this.txtNombre.Text == string.Empty) errorIcono.SetError(txtNombre, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        WyngesModelContainer cnn = new WyngesModelContainer();

                        Models.Pelicula pelicula = new Models.Pelicula();
                        pelicula.Nombre = txtNombre.Text;
                        if (chkActivo.Checked == true)
                        {
                            pelicula.Estado = "A";
                        }
                        else
                        {
                            pelicula.Estado = "I";
                        }
                        pelicula.Genero = cbClasificacion.Text;

                        cnn.PeliculaSet.Add(pelicula);
                        cnn.SaveChanges();
                        this.MensajeOk("Se insertó de forma correcta el registro");
                    }
                    else
                    {
                        WyngesModelContainer cnn = new WyngesModelContainer();
                        int id = Convert.ToInt32(txtCodigo.Text);
                        var query = cnn.PeliculaSet.Where(p => p.PeliculaId == id).FirstOrDefault();

                        query.Nombre = txtNombre.Text;                        
                        query.Genero = cbClasificacion.Text;
                        if (chkActivo.Checked == true)
                        {
                            query.Estado = "A";
                        }
                        else
                        {
                            query.Estado = "I";
                        }

                        cnn.SaveChanges();
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.LimpiarFrm();
                    this.Mostrar();
                    this.txtCodigo.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
