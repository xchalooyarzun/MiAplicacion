using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBibliogonza
{
    //Siempre dejar la clase como publica para poder instanciar desde otro proyecto en caso de necesitarla 
    public class Persona
    {
        //Generar constructor para persona para poder inicializar propiedades de un objeto 
        public Persona() {
            Nombre = null;
            Edad = 0;
            Asignatura = null;
        }
        // Metodos get y set 
        // Atajo prop -> TAB dos veces 
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Asignatura { get; set; }
    }
}
