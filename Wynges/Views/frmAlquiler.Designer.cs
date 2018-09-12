namespace Wynges.Views
{
    partial class frmAlquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlquiler));
            this.lblCerrar = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCerrarDetalle = new System.Windows.Forms.Label();
            this.dgvAlquilerDetalle = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.ClienteID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imlUno = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tbcUno = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEstadoPelicula = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPeliculaId = new System.Windows.Forms.TextBox();
            this.dgvPelicula = new System.Windows.Forms.DataGridView();
            this.pbBuscarPelicula = new System.Windows.Forms.PictureBox();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.dpFechaAlquiler = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.txtIdAlquiler = new System.Windows.Forms.TextBox();
            this.dpFechaOperacion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquilerDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbcUno.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarPelicula)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Red;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(816, 3);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(15, 13);
            this.lblCerrar.TabIndex = 15;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCerrarDetalle);
            this.tabPage1.Controls.Add(this.dgvAlquilerDetalle);
            this.tabPage1.Controls.Add(this.dgvMaster);
            this.tabPage1.Controls.Add(this.cmdImprimir);
            this.tabPage1.Controls.Add(this.cmdBuscar);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCerrarDetalle
            // 
            this.lblCerrarDetalle.AllowDrop = true;
            this.lblCerrarDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCerrarDetalle.AutoSize = true;
            this.lblCerrarDetalle.BackColor = System.Drawing.Color.Red;
            this.lblCerrarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarDetalle.Location = new System.Drawing.Point(708, 204);
            this.lblCerrarDetalle.Name = "lblCerrarDetalle";
            this.lblCerrarDetalle.Size = new System.Drawing.Size(15, 13);
            this.lblCerrarDetalle.TabIndex = 17;
            this.lblCerrarDetalle.Text = "X";
            this.lblCerrarDetalle.Visible = false;
            this.lblCerrarDetalle.Click += new System.EventHandler(this.lblCerrarDetalle_Click);
            // 
            // dgvAlquilerDetalle
            // 
            this.dgvAlquilerDetalle.AllowUserToAddRows = false;
            this.dgvAlquilerDetalle.AllowUserToDeleteRows = false;
            this.dgvAlquilerDetalle.AllowUserToOrderColumns = true;
            this.dgvAlquilerDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquilerDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvAlquilerDetalle.Location = new System.Drawing.Point(47, 204);
            this.dgvAlquilerDetalle.Name = "dgvAlquilerDetalle";
            this.dgvAlquilerDetalle.ReadOnly = true;
            this.dgvAlquilerDetalle.Size = new System.Drawing.Size(655, 97);
            this.dgvAlquilerDetalle.TabIndex = 9;
            this.dgvAlquilerDetalle.Visible = false;
            this.dgvAlquilerDetalle.Leave += new System.EventHandler(this.dgvAlquilerDetalle_Leave);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FechaDevolucion";
            this.dataGridViewTextBoxColumn1.HeaderText = "F. Devolución";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 370;
            // 
            // dgvMaster
            // 
            this.dgvMaster.AllowUserToAddRows = false;
            this.dgvMaster.AllowUserToDeleteRows = false;
            this.dgvMaster.AllowUserToOrderColumns = true;
            this.dgvMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.Fecha,
            this.Nombre,
            this.Descuento,
            this.SubTotal,
            this.Impuesto,
            this.Total,
            this.Estado});
            this.dgvMaster.Location = new System.Drawing.Point(6, 61);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.ReadOnly = true;
            this.dgvMaster.Size = new System.Drawing.Size(791, 367);
            this.dgvMaster.TabIndex = 4;
            this.dgvMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaster_CellContentClick);
            // 
            // ClienteID
            // 
            this.ClienteID.DataPropertyName = "AlquilerId";
            this.ClienteID.HeaderText = "Código";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            this.ClienteID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "F. Alquiler";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Cliente";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubTotal.HeaderText = "Sub-Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Impuesto
            // 
            this.Impuesto.DataPropertyName = "Impuesto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Impuesto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cmdImprimir.FlatAppearance.BorderSize = 0;
            this.cmdImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImprimir.ForeColor = System.Drawing.Color.White;
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImprimir.Location = new System.Drawing.Point(709, 8);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(91, 23);
            this.cmdImprimir.TabIndex = 3;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = false;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cmdBuscar.FlatAppearance.BorderSize = 0;
            this.cmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.ForeColor = System.Drawing.Color.White;
            this.cmdBuscar.Image = ((System.Drawing.Image)(resources.GetObject("cmdBuscar.Image")));
            this.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscar.Location = new System.Drawing.Point(612, 8);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(91, 23);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(509, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "label6";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(97, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(209, 21);
            this.txtBuscar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // imlUno
            // 
            this.imlUno.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlUno.ImageStream")));
            this.imlUno.TransparentColor = System.Drawing.Color.Transparent;
            this.imlUno.Images.SetKeyName(0, "editar2.png");
            this.imlUno.Images.SetKeyName(1, "documento.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "ALQUILER";
            // 
            // tbcUno
            // 
            this.tbcUno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcUno.Controls.Add(this.tabPage1);
            this.tbcUno.Controls.Add(this.tabPage2);
            this.tbcUno.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcUno.Location = new System.Drawing.Point(12, 32);
            this.tbcUno.Name = "tbcUno";
            this.tbcUno.SelectedIndex = 0;
            this.tbcUno.Size = new System.Drawing.Size(811, 463);
            this.tbcUno.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcUno.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDescuento);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblTotalPagado);
            this.groupBox1.Controls.Add(this.lblImpuesto);
            this.groupBox1.Controls.Add(this.lblSubTotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 422);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alquiler de Películas.";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescuento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.Black;
            this.lblDescuento.Location = new System.Drawing.Point(681, 323);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescuento.Size = new System.Drawing.Size(98, 17);
            this.lblDescuento.TabIndex = 37;
            this.lblDescuento.Text = "0,00";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(580, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Descuento:";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPagado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagado.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagado.Location = new System.Drawing.Point(681, 373);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPagado.Size = new System.Drawing.Size(98, 17);
            this.lblTotalPagado.TabIndex = 35;
            this.lblTotalPagado.Text = "0,00";
            this.lblTotalPagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImpuesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.ForeColor = System.Drawing.Color.Black;
            this.lblImpuesto.Location = new System.Drawing.Point(681, 356);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImpuesto.Size = new System.Drawing.Size(98, 17);
            this.lblImpuesto.TabIndex = 34;
            this.lblImpuesto.Text = "0,00";
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.Location = new System.Drawing.Point(681, 339);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubTotal.Size = new System.Drawing.Size(98, 17);
            this.lblSubTotal.TabIndex = 33;
            this.lblSubTotal.Text = "0,00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(616, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(590, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Impuesto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(591, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Sub Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEstadoPelicula);
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.txtPeliculaId);
            this.groupBox3.Controls.Add(this.dgvPelicula);
            this.groupBox3.Controls.Add(this.pbBuscarPelicula);
            this.groupBox3.Controls.Add(this.txtPelicula);
            this.groupBox3.Controls.Add(this.dpFechaAlquiler);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(6, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 241);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de Peliculas";
            // 
            // txtEstadoPelicula
            // 
            this.txtEstadoPelicula.Location = new System.Drawing.Point(295, 10);
            this.txtEstadoPelicula.MaxLength = 50;
            this.txtEstadoPelicula.Name = "txtEstadoPelicula";
            this.txtEstadoPelicula.Size = new System.Drawing.Size(48, 22);
            this.txtEstadoPelicula.TabIndex = 38;
            this.txtEstadoPelicula.Visible = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.errorIcono.SetIconPadding(this.btnQuitar, 1);
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(675, 37);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(98, 23);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.errorIcono.SetIconPadding(this.btnAgregar, 1);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(571, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPeliculaId
            // 
            this.txtPeliculaId.Location = new System.Drawing.Point(98, 13);
            this.txtPeliculaId.MaxLength = 50;
            this.txtPeliculaId.Name = "txtPeliculaId";
            this.txtPeliculaId.Size = new System.Drawing.Size(48, 22);
            this.txtPeliculaId.TabIndex = 35;
            this.txtPeliculaId.Visible = false;
            // 
            // dgvPelicula
            // 
            this.dgvPelicula.AllowUserToAddRows = false;
            this.dgvPelicula.AllowUserToDeleteRows = false;
            this.dgvPelicula.AllowUserToOrderColumns = true;
            this.dgvPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelicula.Location = new System.Drawing.Point(6, 66);
            this.dgvPelicula.Name = "dgvPelicula";
            this.dgvPelicula.ReadOnly = true;
            this.dgvPelicula.Size = new System.Drawing.Size(767, 169);
            this.dgvPelicula.TabIndex = 34;
            // 
            // pbBuscarPelicula
            // 
            this.pbBuscarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscarPelicula.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarPelicula.Image")));
            this.pbBuscarPelicula.Location = new System.Drawing.Point(67, 14);
            this.pbBuscarPelicula.Name = "pbBuscarPelicula";
            this.pbBuscarPelicula.Size = new System.Drawing.Size(22, 22);
            this.pbBuscarPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscarPelicula.TabIndex = 33;
            this.pbBuscarPelicula.TabStop = false;
            this.pbBuscarPelicula.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(9, 38);
            this.txtPelicula.MaxLength = 50;
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(334, 22);
            this.txtPelicula.TabIndex = 3;
            // 
            // dpFechaAlquiler
            // 
            this.dpFechaAlquiler.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaAlquiler.Location = new System.Drawing.Point(453, 38);
            this.dpFechaAlquiler.Margin = new System.Windows.Forms.Padding(2);
            this.dpFechaAlquiler.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dpFechaAlquiler.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dpFechaAlquiler.Name = "dpFechaAlquiler";
            this.dpFechaAlquiler.Size = new System.Drawing.Size(112, 22);
            this.dpFechaAlquiler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(450, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha Devolución";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Película";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(346, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Monto Alquiler";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(349, 38);
            this.txtPrecio.MaxLength = 50;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(99, 22);
            this.txtPrecio.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Controls.Add(this.pbBuscar);
            this.groupBox2.Controls.Add(this.txtIdAlquiler);
            this.groupBox2.Controls.Add(this.dpFechaOperacion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 52);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Alquiler y Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(229, 0);
            this.txtIdCliente.MaxLength = 50;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(33, 22);
            this.txtIdCliente.TabIndex = 28;
            this.txtIdCliente.Visible = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(474, 21);
            this.txtCategoria.MaxLength = 50;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(131, 22);
            this.txtCategoria.TabIndex = 1;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(201, 21);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(22, 22);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 26;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // txtIdAlquiler
            // 
            this.txtIdAlquiler.Location = new System.Drawing.Point(67, 21);
            this.txtIdAlquiler.MaxLength = 50;
            this.txtIdAlquiler.Name = "txtIdAlquiler";
            this.txtIdAlquiler.Size = new System.Drawing.Size(71, 22);
            this.txtIdAlquiler.TabIndex = 25;
            // 
            // dpFechaOperacion
            // 
            this.dpFechaOperacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaOperacion.Location = new System.Drawing.Point(662, 19);
            this.dpFechaOperacion.Margin = new System.Windows.Forms.Padding(2);
            this.dpFechaOperacion.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dpFechaOperacion.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dpFechaOperacion.Name = "dpFechaOperacion";
            this.dpFechaOperacion.Size = new System.Drawing.Size(112, 22);
            this.dpFechaOperacion.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(610, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(144, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(229, 21);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(681, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(577, 393);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.errorIcono.SetIconPadding(this.btnNuevo, 1);
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(473, 393);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(835, 507);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbcUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlquiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlquiler_FormClosing);
            this.Load += new System.EventHandler(this.frmAlquiler_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquilerDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbcUno.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarPelicula)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imlUno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tbcUno;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPelicula;
        private System.Windows.Forms.PictureBox pbBuscarPelicula;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.DateTimePicker dpFechaAlquiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TextBox txtIdAlquiler;
        private System.Windows.Forms.DateTimePicker dpFechaOperacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtPeliculaId;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEstadoPelicula;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.DataGridViewLinkColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridView dgvAlquilerDetalle;
        private System.Windows.Forms.Label lblCerrarDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}