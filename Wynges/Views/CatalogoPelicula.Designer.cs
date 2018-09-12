namespace Wynges.Views
{
    partial class CatalogoPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoPelicula));
            this.dgvPelicula = new System.Windows.Forms.DataGridView();
            this.PeliculaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imlUno = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcUno = new System.Windows.Forms.TabControl();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbcUno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPelicula
            // 
            this.dgvPelicula.AllowUserToAddRows = false;
            this.dgvPelicula.AllowUserToDeleteRows = false;
            this.dgvPelicula.AllowUserToOrderColumns = true;
            this.dgvPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeliculaId,
            this.Nombre,
            this.Genero,
            this.Estado});
            this.dgvPelicula.Location = new System.Drawing.Point(6, 41);
            this.dgvPelicula.Name = "dgvPelicula";
            this.dgvPelicula.ReadOnly = true;
            this.dgvPelicula.Size = new System.Drawing.Size(655, 325);
            this.dgvPelicula.TabIndex = 4;
            this.dgvPelicula.DoubleClick += new System.EventHandler(this.dgvPelicula_DoubleClick);
            // 
            // PeliculaId
            // 
            this.PeliculaId.DataPropertyName = "PeliculaId";
            this.PeliculaId.HeaderText = "Código";
            this.PeliculaId.Name = "PeliculaId";
            this.PeliculaId.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Título";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // imlUno
            // 
            this.imlUno.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlUno.ImageStream")));
            this.imlUno.TransparentColor = System.Drawing.Color.Transparent;
            this.imlUno.Images.SetKeyName(0, "editar2.png");
            this.imlUno.Images.SetKeyName(1, "documento.png");
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPelicula);
            this.tabPage1.Controls.Add(this.cmdBuscar);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.cmdBuscar.Location = new System.Drawing.Point(379, 12);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(92, 21);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
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
            this.txtBuscar.Size = new System.Drawing.Size(276, 21);
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
            // tbcUno
            // 
            this.tbcUno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcUno.Controls.Add(this.tabPage1);
            this.tbcUno.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcUno.Location = new System.Drawing.Point(12, 22);
            this.tbcUno.Name = "tbcUno";
            this.tbcUno.SelectedIndex = 0;
            this.tbcUno.Size = new System.Drawing.Size(675, 408);
            this.tbcUno.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcUno.TabIndex = 15;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "CATALOGO DE PELICULAS";
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Red;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(672, 6);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(15, 13);
            this.lblCerrar.TabIndex = 16;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // CatalogoPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.tbcUno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatalogoPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogoPelicula";
            this.Load += new System.EventHandler(this.CatalogoPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelicula)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbcUno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPelicula;
        private System.Windows.Forms.ImageList imlUno;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tbcUno;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeliculaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}