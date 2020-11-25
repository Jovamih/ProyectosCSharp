using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsola
{
    class Persona
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public Persona(String nombre,string dni)
        {
            this.Nombre = nombre;
            this.DNI = dni;
        }
        public virtual void Trabajar()
        {
            Console.WriteLine("{0} esta trabajando", Nombre);
        }
        public virtual void Comer()
        {
            Console.WriteLine("{0} esta comiendo", Nombre);
        }
    }
}
