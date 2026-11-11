namespace AcaBiblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            // txtAño = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAño = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTituloL = new Label();
            lblISBN = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(128, 128, 255);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(513, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(730, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(437, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(247, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(378, 18);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(36, 16);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            // pnlDatos.Controls.Add(txtAño);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloL);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 265);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(513, 117);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(247, 23);
            cmbEditorial.TabIndex = 17;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(513, 86);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(247, 23);
            cmbAutor.TabIndex = 16;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(0, 0);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(100, 23);
            txtExistencias.TabIndex = 18;
            // 
            // txtAño
            // 
            //txtAño.Location = new Point(513, 183);
            //txtAño.Name = "txtAño";
            //txtAño.Size = new Size(247, 23);
            //txtAño.TabIndex = 14;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(513, 149);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(247, 23);
            txtCategoria.TabIndex = 13;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(513, 54);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(247, 23);
            txtTitulo.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(513, 20);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(247, 23);
            txtISBN.TabIndex = 3;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(433, 230);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(74, 16);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(466, 190);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(37, 16);
            lblAño.TabIndex = 8;
            lblAño.Text = "Año:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(437, 156);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(66, 16);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoría:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(437, 124);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(62, 16);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(452, 93);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(47, 16);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblTituloL
            // 
            lblTituloL.AutoSize = true;
            lblTituloL.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloL.Location = new Point(452, 61);
            lblTituloL.Name = "lblTituloL";
            lblTituloL.Size = new Size(47, 16);
            lblTituloL.TabIndex = 4;
            lblTituloL.Text = "Titulo:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(459, 27);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(40, 16);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(257, 403);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(794, 60);
            pnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(636, 9);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.Location = new Point(481, 9);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.Location = new Point(326, 9);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Tape;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(171, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.ArrowRightToFile;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.Location = new Point(16, 9);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(149, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(0, 469);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1350, 260);
            dgvLibros.TabIndex = 4;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Label lblBuscar;
        private FileSystemWatcher fileSystemWatcher1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Panel pnlDatos;
        private Label lblTituloL;
        private Label lblISBN;
        private Label lblEditorial;
        private Label lblAutor;
        private Label lblCategoria;
        private Label lblAño;
        private Label lblExistencias;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private TextBox txtExistencias;
        // private TextBox txtAño;
        private TextBox txtCategoria;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private DataGridView dgvLibros;
    }
}