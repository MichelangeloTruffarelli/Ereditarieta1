using System;

namespace Ereditarieta1
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double Altezza { get; set; }
        public DateTime DataNascita { get; set; }

        public Persona(string n, string c, double a, DateTime d)
        {
            Nome = n;
            Cognome = c;
            Altezza = a;
            DataNascita = d;
        }
    }
}
