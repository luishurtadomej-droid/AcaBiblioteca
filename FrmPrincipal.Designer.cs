namespace AcaBiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnSalida = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Gray;
            pnlMenu.Controls.Add(btnSalida);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 661);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalida
            // 
            btnSalida.AutoSize = true;
            btnSalida.BackColor = Color.White;
            btnSalida.Cursor = Cursors.Hand;
            btnSalida.Dock = DockStyle.Top;
            btnSalida.FlatAppearance.BorderSize = 0;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalida.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalida.IconColor = Color.Black;
            btnSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalida.IconSize = 30;
            btnSalida.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalida.Location = new Point(0, 395);
            btnSalida.Margin = new Padding(0, 10, 0, 10);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(220, 45);
            btnSalida.TabIndex = 7;
            btnSalida.Text = "Salida";
            btnSalida.TextAlign = ContentAlignment.MiddleRight;
            btnSalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = true;
            btnReportes.BackColor = Color.White;
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 30;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 350);
            btnReportes.Margin = new Padding(0, 10, 0, 10);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(220, 45);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.AutoSize = true;
            btnPrestamos.BackColor = Color.White;
            btnPrestamos.Cursor = Cursors.Hand;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.ArrowRightArrowLeft;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 30;
            btnPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.Location = new Point(0, 305);
            btnPrestamos.Margin = new Padding(0, 10, 0, 10);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(220, 45);
            btnPrestamos.TabIndex = 5;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleRight;
            btnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.AutoSize = true;
            btnEditoriales.BackColor = Color.White;
            btnEditoriales.Cursor = Cursors.Hand;
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.FlatAppearance.BorderSize = 0;
            btnEditoriales.FlatStyle = FlatStyle.Flat;
            btnEditoriales.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 30;
            btnEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditoriales.Location = new Point(0, 260);
            btnEditoriales.Margin = new Padding(0, 10, 0, 10);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(220, 45);
            btnEditoriales.TabIndex = 4;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextAlign = ContentAlignment.MiddleRight;
            btnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.AutoSize = true;
            btnAutores.BackColor = Color.White;
            btnAutores.Cursor = Cursors.Hand;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.FlatAppearance.BorderSize = 0;
            btnAutores.FlatStyle = FlatStyle.Flat;
            btnAutores.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.Feather;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 30;
            btnAutores.ImageAlign = ContentAlignment.MiddleLeft;
            btnAutores.Location = new Point(0, 215);
            btnAutores.Margin = new Padding(0, 10, 0, 10);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(220, 45);
            btnAutores.TabIndex = 3;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleRight;
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.BackColor = Color.White;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 170);
            btnUsuarios.Margin = new Padding(0, 10, 0, 10);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(220, 45);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.AutoSize = true;
            btnLibros.BackColor = Color.White;
            btnLibros.Cursor = Cursors.Hand;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 30;
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(0, 125);
            btnLibros.Margin = new Padding(0, 10, 0, 10);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(220, 45);
            btnLibros.TabIndex = 1;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleRight;
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = true;
            btnInicio.BackColor = Color.White;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 80);
            btnInicio.Margin = new Padding(0, 10, 0, 10);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(220, 45);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleRight;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.DimGray;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 80);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Image = Properties.Resources._18312668;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(94, 77);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Tempus Sans ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(91, 37);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(129, 17);
            lblSubtitulo.TabIndex = 0;
            lblSubtitulo.Text = "Sistema De Gestión";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(87, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(192, 192, 255);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(220, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1144, 80);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = SystemColors.ControlDark;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(220, 631);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(1144, 30);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(220, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1144, 551);
            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 661);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestión Biblioteca";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnSalida;
        private FontAwesome.Sharp.IconButton btnReportes;
    }
}
