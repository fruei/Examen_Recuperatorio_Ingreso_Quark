using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Recuperatorio_Ingreso_Quark.Modelos
{
    class GeneradorDatos
    {
        public void GenerarEjemplares(Libro libro)
        {
            for (int j = 0; j < 3; j++)
            {
                Ejemplar ejemplar = new Ejemplar
                {
                    Libro = libro,
                    Edicion_numero = j,
                    Ubicacion = RandomString()
                };

                libro.AgregarNuevoEjemplar(ejemplar);
            }
        }

        public List<Libro> GenerarLibros()
        {
            List<Libro> libros = new List<Libro>();

            Libro libro = new Libro
            {
                Nombre = "Warcross",
                Codigo_ISBN = 1234867,
                Autor = $"Marie Lu"
            };

            GenerarEjemplares(libro);   
            

            libros.Add(libro);

            Libro libro1 = new Libro
            {
                Nombre = "Wilcard",
                Codigo_ISBN = 23123124,
                Autor = $"Marie Lu"
            };

            GenerarEjemplares(libro1);
            libros.Add(libro1);

            Libro libro2 = new Libro
            {
                Nombre = "Game Feel",
                Codigo_ISBN = 523187498,
                Autor = $"Steve Swink"
            };

            GenerarEjemplares(libro2);
            libros.Add(libro2);

            return libros;
        }

        public List<Socio> GenerarSocios()
        {
            List<Socio> socios = new List<Socio>();
            Socio socio1 = new Socio
            {
                Nombre = "Sofia",
                Apellido = "Jara",
                Id = 44447,
            };

            socios.Add(socio1);


            Socio socio2 = new Socio
            {
                Nombre = "Manuel",
                Apellido = "Celi",
                Id = 123123333,
            };

            socios.Add(socio2);

            Socio socio3 = new Socio
            {
                Nombre = "Mauricio",
                Apellido = "Vilte",
                Id = 55231,
            };

            socios.Add(socio3);

            SocioVIP sociovip = new SocioVIP();
            sociovip.Nombre = "Emanuel";
            sociovip.Apellido = "Jara";
            sociovip.Id = 4444;
            sociovip.Cuota_mensual = 800;

            socios.Add(sociovip);

            return socios;
           
        }

        string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }
    }
}
