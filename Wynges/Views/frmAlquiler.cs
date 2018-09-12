using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Wynges.Models;
using System.Globalization;

namespace Wynges.Views
{
    public partial class frmAlquiler : Form
    {
        private bool IsNuevo = false;
        private DataTable dtDetalle;
        private decimal DescuentoPagado = 0;
        private decimal TotalPagado = 0;
        private decimal ImpuestoPagado = 0;
        private decimal SubTotalPagado = 0;

        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void crearTabla()
        {
            this.dtDetalle = new DataTable("AlquilerDetalle");
            DataColumn dc = new DataColumn("Titulo", Type.GetType("System.String"));
            this.dtDetalle.Columns.Add(dc);
            DataColumn dc2 = new DataColumn("Monto", Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add(dc2);
            DataColumn dc3 = new DataColumn("FechaDevolucion", Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add(dc3);
            DataColumn dc4 = new DataColumn("PeliculaPeliculaId", Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add(dc4);
            this.dgvPelicula.DataSource = this.dtDetalle;
            dgvPelicula.Columns[0].Width = 350;
            dgvPelicula.Columns[0].HeaderText="Título";
            dgvPelicula.Columns[1].Width = 180;
            dgvPelicula.Columns[1].HeaderText = "Monto Alquiler";
            dgvPelicula.Columns[2].Width = 180;
            dgvPelicula.Columns[2].HeaderText = "F. Dev. Estimada";
            dgvPelicula.Columns[3].Visible = false;
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

        private static frmAlquiler _instancia;
        public static frmAlquiler GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmAlquiler();
            }
            return _instancia;
        }

        public void setCliente(string idcliente, string nombre, string categoria)
        {
            this.txtIdCliente.Text = idcliente;
            this.txtNombre.Text = nombre;
            this.txtCategoria.Text = categoria;
            dpFechaAlquiler.Focus();
        }

        public void setPelicula(string idpelicula, string pelicula, string estado)
        {
            this.txtPeliculaId.Text = idpelicula;
            this.txtPelicula.Text = pelicula;
            this.txtEstadoPelicula.Text = estado;
            txtPrecio.Focus();
        }
        
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método Mostrar
        private void Mostrar()
        {
            WyngesModelContainer cnn = new WyngesModelContainer();

            var listaAlquiler = from a in cnn.AlquilerSet
                                from c in cnn.ClienteSet
                                where a.ClienteClienteId == c.ClienteId
                                select new { a.AlquilerId, a.Fecha, c.Nombre, a.Descuento, a.SubTotal, a.Impuesto, a.Total, a.Estado };
            this.dgvMaster.DataSource = listaAlquiler.ToList();
            lblTotal.Text = "Cantidad de Registros: " + Convert.ToString(dgvMaster.RowCount);
        }

        private void MostrarDetalle(int alquilercodigo)
        {
            WyngesModelContainer cnn = new WyngesModelContainer();

            var listaDetalle = from a in cnn.AlquilerSet
                               from d in cnn.AlquilerDetalleSet
                               from p in cnn.PeliculaSet
                                where a.AlquilerId == d.AlquilerAlquilerId && 
                                      d.PeliculaPeliculaId == p.PeliculaId && 
                                      a.AlquilerId == alquilercodigo
                                select new { d.Precio, d.FechaDevolucion, p.Nombre };
            this.dgvAlquilerDetalle.DataSource = listaDetalle.ToList();            
        }
        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtIdAlquiler.Text = string.Empty;
            this.txtIdCliente.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.lblDescuento.Text = "0.00";
            this.lblSubTotal.Text = "0.00";
            this.lblImpuesto.Text = "0.00";
            this.lblTotal.Text = "0.00";            
            DescuentoPagado = 0;
            TotalPagado = 0;
            ImpuestoPagado = 0;
            SubTotalPagado = 0;
            this.crearTabla();
        }

        private void limpiarDetalle()
        {
            this.txtPeliculaId.Text = string.Empty;
            this.txtPelicula.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtIdAlquiler.ReadOnly = !valor;
            this.txtPelicula.ReadOnly = !valor;
            this.dpFechaOperacion.Enabled = valor;
            this.txtPelicula.ReadOnly = !valor;
            this.txtPrecio.Enabled = valor;
            this.dpFechaAlquiler.Enabled = valor;

            this.pbBuscar.Enabled = valor;
            this.pbBuscarPelicula.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.btnQuitar.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }

        }

        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            dgvMaster.AutoGenerateColumns = false;            
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.crearTabla();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            CatalogoCliente vista = new  CatalogoCliente();
            vista.ShowDialog();
        }

        private void frmAlquiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CatalogoPelicula vista = new CatalogoPelicula();
            vista.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            try
            {
                if (this.txtPelicula.Text == string.Empty || this.txtPrecio.Text == string.Empty || this.dpFechaAlquiler.Value < DateTime.Now)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    if (this.txtPelicula.Text == string.Empty)
                    {
                        errorIcono.SetError(txtPelicula, "Ingrese una película");
                    }
                    if (this.txtPrecio.Text == string.Empty)
                    {
                        errorIcono.SetError(txtPrecio, "Ingrese un monto de alquiler");
                    }
                    if (this.dpFechaAlquiler.Value < DateTime.Now)
                    {
                        errorIcono.SetError(dpFechaAlquiler, "la fecha de devolución debe ser mayor a la fecha actual");
                    }
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["PeliculaPeliculaId"]) == Convert.ToInt32(this.txtPeliculaId.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra el artículo en el detalle");
                        }
                    }
                    if (registrar && (Convert.ToInt32(txtPrecio.Text) > 0))
                    {

                        SubTotalPagado = SubTotalPagado + Convert.ToDecimal(this.txtPrecio.Text);
                        if (txtCategoria.Text == "Preferencial")
                        {
                            DescuentoPagado = SubTotalPagado * 20 / 100;
                        }
                        else
                        {
                            DescuentoPagado = 0;
                        }
                        ImpuestoPagado = SubTotalPagado * 16 / 100;
                        TotalPagado = SubTotalPagado + ImpuestoPagado - DescuentoPagado;
                        this.lblSubTotal.Text = SubTotalPagado.ToString("N2");
                        this.lblDescuento.Text = DescuentoPagado.ToString("#0.00#");
                        this.lblImpuesto.Text = ImpuestoPagado.ToString("#0.00#");
                        this.lblTotalPagado.Text = TotalPagado.ToString("#0.00#");
                        //Agregar ese detalle al datalistadoDetalle
                        DataRow row = this.dtDetalle.NewRow();
                        row["Titulo"] = this.txtPelicula.Text;
                        row["Monto"] = Convert.ToDecimal(this.txtPrecio.Text);
                        row["FechaDevolucion"] = Convert.ToDateTime(this.dpFechaAlquiler.Value);
                        row["PeliculaPeliculaId"] = Convert.ToInt32(this.txtPeliculaId.Text);
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();

                    }
                    else
                    {
                        MensajeError("No hay precio válido");
                    }
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
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text == string.Empty || this.dpFechaOperacion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(dpFechaOperacion, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        WyngesModelContainer cnn = new WyngesModelContainer();

                        Alquiler alquiler = new Alquiler
                        {
                            Fecha = Convert.ToDateTime(dpFechaOperacion.Value),
                            ClienteClienteId = Convert.ToInt32(txtIdCliente.Text),
                            Descuento = Convert.ToDecimal(lblDescuento.Text),
                            SubTotal = Convert.ToDecimal(lblSubTotal.Text),
                            Impuesto = Convert.ToDecimal(lblImpuesto.Text),
                            Total = Convert.ToDecimal(lblTotalPagado.Text),
                            Estado = "Pendiente"
                        };
                        cnn.AlquilerSet.Add(alquiler);
                        foreach (DataRow row in dtDetalle.Rows)
                        {
                            AlquilerDetalle detalle = new AlquilerDetalle
                            {
                                Precio = Convert.ToDecimal(row["Monto"].ToString()),
                                FechaDevolucion = row["FechaDevolucion"].ToString(),
                                PeliculaPeliculaId = Convert.ToInt32(row["PeliculaPeliculaId"].ToString()),
                                AlquilerAlquilerId = Convert.ToInt32(alquiler.AlquilerId)
                            };
                            cnn.AlquilerDetalleSet.Add(detalle);
                        }                        
                        cnn.SaveChanges();
                        this.MensajeOk("Se insertó de forma correcta el registro");
                    }
                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarDetalle(Convert.ToInt32(this.dgvMaster.CurrentRow.Cells[0].Value));
            dgvAlquilerDetalle.Visible = true;
            this.lblCerrarDetalle.Visible = true;
            //dgvAlquilerDetalle.Top = dgvMaster.CurrentRow.DataGridView.Top;            
        }

        private void dgvAlquilerDetalle_Leave(object sender, EventArgs e)
        {
            dgvAlquilerDetalle.Visible = false;
        }

        private void lblCerrarDetalle_Click(object sender, EventArgs e)
        {
            dgvAlquilerDetalle.Visible = false;
            this.lblCerrarDetalle.Visible = false;
        }
    }
}
 