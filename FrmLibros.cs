using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmLibros : Form
    {

        private bool modoEdicion = false;
        private object txtAño;

        public FrmLibros()
        {
            InitializeComponent();
            CargarLibros();
            CargarAutores();
            CargarEditoriales();
        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvLibros.DataSource = tabla;
                                            }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        tabla.Columns.Add("NombreCompleto", typeof(string));
                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                        }
                        cmbAutor.DataSource = tabla;
                        cmbAutor.DisplayMember = "NombreCompleto";
                        cmbAutor.ValueMember = "IdAutor";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdEditorial, Nombre FROM Editoriales ORDER BY Nombre";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        cmbEditorial.DataSource = tabla;
                        cmbEditorial.DisplayMember = "Nombre";
                        cmbEditorial.ValueMember = "IdEditorial";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    MessageBox.Show(
                        "Por favor, ingrese un ISBN para buscar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";
                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", txtBuscar.Text.Trim());
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtISBN.Text = lector["ISBN"].ToString();
                                txtTitulo.Text = lector["Titulo"].ToString();
                                cmbAutor.SelectedValue = Convert.ToInt32(lector["IdAutor"]);
                                cmbEditorial.SelectedValue = Convert.ToInt32(lector["IdEditorial"]);
                                txtCategoria.Text = lector["Categoria"].ToString();
                                // txtAño.Text = lector["Año"].ToString();

                                MessageBox.Show(
                                      "Libro encontrado y cargado en los campos.",
                                      "Biblioteca",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró ningún libro con el ISBN proporcionado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }
    }
}


            



    










