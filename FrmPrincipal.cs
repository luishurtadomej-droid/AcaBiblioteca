using AcaBiblioteca.Datos;
namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //Conexion conexion = new Conexion();
            //try
            //{
            //using (var conn = Conexion.ObtenerConexion())
            //{
            //conn.Open();
            // La conexión se ha establecido correctamente
            //MessageBox.Show("Conexión a la base de datos establecida correctamente.",
            // "AcaBiblioteca",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information);
            //}
            //}
            //catch (Exception ex)
            //{
            //MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
            // "AcaBiblioteca",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Error);
            //}
            abrirFormulario(new FrmInicio());
        }

        private void abrirFormulario(Form formulario)
        {
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();



        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInicio());
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmLibros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmUsuarios());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmAutores());
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEditoriales());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmPrestamos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmReportes());
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
