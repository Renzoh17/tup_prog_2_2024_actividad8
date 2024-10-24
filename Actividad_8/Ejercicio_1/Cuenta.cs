using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    [Serializable]
    internal class Cuenta : IComparable<Cuenta>
    {
        public int Numero {  get; set; }
        public double Saldo {  get; set; }
        public DateTime Fecha { get; set; }
        public Persona Titular { get; set; }    

        public Cuenta(int numero, Persona titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Cuenta(int numero, Persona titular, DateTime fecha, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Fecha = fecha;
            Saldo = saldo;
        }

        public int CompareTo(Cuenta c)
        {
            return c == null ? -1 : Numero.CompareTo(c.Numero);
        }
        public override string ToString()
        {
            return $"{Titular.DNI};{Titular.Nombre};{Numero};{Saldo:f2}";
        }
    }
}
