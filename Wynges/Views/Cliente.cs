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

namespace Wynges
{
    public partial class Cliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public ListViewItem.ListViewSubItemCollection SubItems;

        public Cliente()
        {
            InitializeComponent();
            ttMensaje.SetToolTip(txtCodigo, "Ingrese un número que identifique el cliente");
            ttMensaje.SetToolTip(txtNombre, "Ingrese el nombre o la razón social del cliente");
            ttMensaje.SetToolTip(txtTelefono, "Ingrese el numero de teléfono del cliente");
            ttMensaje.SetToolTip(txtDireccion, "Ingrese la dirección del cliente");
            ttMensaje.SetToolTip(txtCorreo, "Ingrese el correo del cliente");
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrat mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Limpiar formulario
        private void LimpiarFrm()
        {
            txtBuscar.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            chkActivo.Checked = false;
        }
        //Habilitar las cajas de textos
        private void Habilitar(bool Valor)
        {
            txtCodigo.ReadOnly = !Valor;
            txtNombre.ReadOnly = !Valor;
            txtTelefono.ReadOnly = !Valor;
            txtDireccion.ReadOnly = !Valor;
            txtCorreo.ReadOnly = !Valor;
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
            this.dgvCliente.DataSource = cnn.ClienteSet.ToList();
            OcultarColumnas();
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
        //Ocultar el chekbox del dataGridView
        private void OcultarColumnas()
        {
            this.dgvCliente.Columns[0].Visible = false;
            this.dgvCliente.Columns[1].Visible = false;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            dgvCliente.AutoGenerateColumns = false;
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
            txtCodigo.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["ClienteId"].Value); //dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Nombre"].Value);
            txtTelefono.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Telefono"].Value);
            txtDireccion.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Direccion"].Value);
            txtCorreo.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Correo"].Value);
            cbClasificacion.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Clasificacion"].Value);
            if (Convert.ToString(this.dgvCliente.CurrentRow.Cells["Estado"].Value) == "A")
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
                this.dgvCliente.Columns[0].Visible = true;
            }
            else
            {
                this.dgvCliente.Columns[0].Visible = false;
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCliente.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dgvCliente.Rows[e.RowIndex].Cells["Eliminar"];
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

                    foreach (DataGridViewRow row in dgvCliente.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            WyngesModelContainer cnn = new WyngesModelContainer();

                            var query = (from p in cnn.ClienteSet
                                        where p.ClienteId.Equals(Codigo)
                                        select p).FirstOrDefault();

                            cnn.ClienteSet.Remove(query);
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
                if (this.txtNombre.Text == string.Empty || this.txtTelefono.Text == string.Empty || txtDireccion.Text == string.Empty || txtCorreo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    if (this.txtNombre.Text == string.Empty) errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    if (this.txtTelefono.Text == string.Empty) errorIcono.SetError(txtTelefono, "Ingrese un Valor");
                    if (this.txtDireccion.Text == string.Empty) errorIcono.SetError(txtDireccion, "Ingrese un Valor");
                    if (this.txtCorreo.Text == string.Empty) errorIcono.SetError(txtCorreo, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        WyngesModelContainer cnn = new WyngesModelContainer();

                        Models.Cliente cliente = new Models.Cliente();
                        cliente.Nombre = txtNombre.Text;
                        cliente.Telefono = txtTelefono.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Correo = txtCorreo.Text;
                        if (chkActivo.Checked == true)
                        {
                            cliente.Estado = "A";
                        }
                        else
                        {
                            cliente.Estado = "I";
                        }
                        cliente.Clasificacion = cbClasificacion.Text;

                        cnn.ClienteSet.Add(cliente);
                        cnn.SaveChanges();
                        this.MensajeOk("Se insertó de forma correcta el registro");
                    }
                    else
                    {
                        WyngesModelContainer cnn = new WyngesModelContainer();
                        int id = Convert.ToInt32(txtCodigo.Text);
                        var query = cnn.ClienteSet.Where(p => p.ClienteId == id).FirstOrDefault();

                        query.Nombre = txtNombre.Text;
                        query.Telefono = txtTelefono.Text;
                        query.Direccion = txtDireccion.Text;
                        query.Correo = txtCorreo.Text;
                        query.Clasificacion= cbClasificacion.Text;
                        if (chkActivo.Checked==true)
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
