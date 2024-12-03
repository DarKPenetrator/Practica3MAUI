using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3Jorge
{
    public class Noticia
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Imagen { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }

        public Noticia(string titulo, string contenido, string imagen, string fecha, string descripcion)
        {
            Titulo = titulo;
            Contenido = contenido;
            Imagen = imagen;
            Fecha = fecha;
            Descripcion = descripcion;
        }

        public Noticia() { }
    }
}
