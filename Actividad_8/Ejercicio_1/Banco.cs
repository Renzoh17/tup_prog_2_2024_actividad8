using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    [Serializable]
    internal class Banco
    {
        List<Persona> clientes = new List<Persona>();
        List<Cuenta> cuentas = new List<Cuenta>();
        Cuenta c;
        Persona p;
        public int CantidadClientes
        {
            get
            {
                return clientes.Count;
            }
        }
        public int CantidadCuentas
        {
            get
            {
                return cuentas.Count;
            }
        }
        public Cuenta this[int idx]
        {
            get
            {
                return idx >= 0 && idx < cuentas.Count ? cuentas[idx] : null;
            }
        }
        
        public Cuenta AgregarCuenta(int numeroCuenta, int dni, string nombre)
        {
            p = VerClientePorDNI(dni);

            if (p == null)
            {
                p = new Persona(dni, nombre);
                clientes.Add(p);
            }

            c = VerCuentaPorNumero(numeroCuenta);

            if (c == null)
            {
                c = new Cuenta(numeroCuenta, p);
                cuentas.Add(c);
            }
                       
            return c;
        }
        public Cuenta VerCuentaPorNumero(int numeroCuenta)
        {
            return this[numeroCuenta];
        }
        public Persona VerClientePorDNI(int dni)
        {
            p = new Persona(dni, "");
            clientes.Sort();
            int idx = clientes.BinarySearch(p);
            return idx >= 0 ? clientes[idx] : null;
        }
        public bool RestaurarCuenta(int numero, double saldo, DateTime fecha, Persona persona)
        {

            return false;
        }
    }
}
