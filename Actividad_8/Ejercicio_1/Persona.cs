using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    [Serializable]
    internal class Persona : IComparable<Persona>
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public int CompareTo(Persona p)
        {
            return p == null ? -1 : DNI.CompareTo(p.DNI);
        }
        public override string ToString()
        {
            return $"{DNI};{Nombre}";
        }
    }
}
