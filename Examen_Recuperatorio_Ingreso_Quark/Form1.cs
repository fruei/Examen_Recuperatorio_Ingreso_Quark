using Examen_Recuperatorio_Ingreso_Quark.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Recuperatorio_Ingreso_Quark
{
    public partial class Form1 : Form
    {
        GeneradorDatos generadorDeDatos = new GeneradorDatos();
        List<Socio> socios = new List<Socio>();
        List<Libro> libros = new List<Libro>();
        List<Prestamo> prestamos = new List<Prestamo>();

        string prestamoSeleccionado = "";
        string libroSeleccionado = "";
        bool socioSeleccionadoCheck = false;

        Socio socioSeleccionado = new Socio();
        Ejemplar ejemplarPrestadoSeleccionado = new Ejemplar();

        public Form1()
        {
            InitializeComponent();

            //Inicializacion de libros y sus ejemplares
            libros = generadorDeDatos.GenerarLibros();   
            
            ActualizarVistaListaLibros();

            // Inicializacion de los socios
            socios = generadorDeDatos.GenerarSocios();

            socios.ForEach(s =>
            {
                lstSocios.Items.Add($"{s.Id}, NombreCompleto: {s.Apellido} {s.Nombre}");
            });
        }

        private void SocioSelectedValueChange(object sender, EventArgs e)
        {
            prestamoSeleccionado = "";
            string _socio = lstSocios.SelectedItem.ToString();

            string[] socioData = _socio.Split(',');
            if (socioData.Length != 2)
                return;

            int id = 0;

            try
            {
                id = int.Parse(socioData[0]);
            }
            catch
            {
                MessageBox.Show("Algo salio mal al seleccionar el socio, por favor contactese con un administrador");
                return;
            }

            Socio socio = socios.Find(
                s => s.Id == id
            );
            
            // Se selecciona el socio en la vista
            socioSeleccionado = socio;
            socioSeleccionadoCheck = true;

            lstPrestamos.Items.Clear();

            // Actualizar la vista de los prestamos
            ActualizarVistaPrestamos(socio);            

            // El socio ya no puede pedir prestamos
            if(socio.Ejemplares_retirados.Count >= socio.Cantidad_max_ejemplares)
                btnPrestamo.Visible = false;
            // El socio puede pedir prestamos
            else btnPrestamo.Visible = true;
        }
        
        void ActualizarVistaListaLibros()
        {
            lstLibros.Items.Clear();
            libros.ForEach(l =>
            {
                if (l.DisponibleEjemplar())
                    lstLibros.Items.Add($"{l.Codigo_ISBN}, Nombre: {l.Nombre} Autor: {l.Autor}");
            });
        }

        void ActualizarVistaPrestamos(Socio socio)
        {
            lstPrestamos.Items.Clear();
            socio.Ejemplares_retirados.ForEach(ej =>
            {
                lstPrestamos.Items.Add(
                    $"{ej.Libro.Codigo_ISBN}, Nombre: {ej.Libro.Nombre} Autor: {ej.Libro.Autor}");
            });
            btnPrestamo.Visible = socio.TieneCupoEjemplares();
            btnCancelarPrestamo.Visible = socio.Ejemplares_retirados.Count > 0 ? true : false;

            // El socio no tienen ningun prestamo
            if (socio.Ejemplares_retirados.Count <= 0)
                lstPrestamos.Items.Add("Este socio no tiene ningun prestamo");
        }

        private void btnCancelarPrestamo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prestamoSeleccionado))
            {
                MessageBox.Show("Primero seleccione un libro prestado para poder cancelar");
                return;
            }

            #region Obtencion del ejemplar prestado
            string _libro = prestamoSeleccionado;         

            string[] libroData = _libro.Split(',');
            if (libroData.Length != 2)
                return;

            int codigo = 0;

            try
            {
                codigo = int.Parse(libroData[0]);
            }
            catch
            {
                MessageBox.Show("Algo salio mal al seleccionar el libro prestado, por favor contactese con un administrador");
                return;
            }

            Socio socio = socioSeleccionado;
            Ejemplar ejemplarPrestado = new Ejemplar();

            socio.Ejemplares_retirados.ForEach(
                ej =>
                {
                    if(ej.Libro.Codigo_ISBN == codigo)
                    {
                        ejemplarPrestado = ej;
                        return;
                    }
                });

            #endregion

            // Se realiza la cancelacion del prestamo
            socio.DevolverEjemplar(ejemplarPrestado);
            ejemplarPrestado.Libro.RegistrarReingresoEjemplar(ejemplarPrestado);

            MessageBox.Show("Libro prestado devuelto");
            ActualizarVistaPrestamos(socio);
            ActualizarVistaListaLibros();
            prestamoSeleccionado = "";
        }

        private void PrestamosSelectedValueChange(object sender, EventArgs e)
        {
            prestamoSeleccionado = lstPrestamos.SelectedItem.ToString();
        }

        private void LibroDisponibleSelectedValueChange(object sender, EventArgs e)
        {
            libroSeleccionado = lstLibros.SelectedItem.ToString();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(libroSeleccionado))
            {
                MessageBox.Show("Primero seleccione el libro a prestar");
                return;
            }

            if (!socioSeleccionadoCheck)
            {
                MessageBox.Show("Primero seleccione un socio al cual hacerle el prestamo");
                return;
            }

            #region Obtencion del objeto libro seleccionado
            string _libro = libroSeleccionado;

            string[] libroData = _libro.Split(',');
            if (libroData.Length != 2)
                return;

            int codigo = 0;

            try
            {
                codigo = int.Parse(libroData[0]);
            }
            catch
            {
                MessageBox.Show("Algo salio mal al seleccionar el libro, por favor contactese con un administrador");
                return;
            }

            Libro libro = libros.Find(
               l => l.Codigo_ISBN == codigo
            );

            #endregion

            // Hacer el prestamo
            #region Validaciones del prestamo
            if (!libro.DisponibleEjemplar())
            {
                // Ya no quedan ejemplares de este libro
                MessageBox.Show("Ya no quedan ejemplares de este libro para prestar");
                return;
            }

            Socio socio = socioSeleccionado;

            if (!socio.TieneCupoEjemplares())
            {
                // El socio ya no puede pedir prestamos
                MessageBox.Show("Este socio ya no puede pedir prestamos");
                return;
            }
            #endregion

            Ejemplar ejemplar = libro.PrestarEjemplar();

            socio.PedirPrestadoEjemplar(ejemplar);

            Prestamo prestamo = new Prestamo(socio,ejemplar);

            prestamos.Add(prestamo);

            MessageBox.Show("El prestamo se realizo correctamente para el socio seleccionado");

            ActualizarVistaListaLibros();
            ActualizarVistaPrestamos(socio);
            libroSeleccionado = "";
        }
    }
}
