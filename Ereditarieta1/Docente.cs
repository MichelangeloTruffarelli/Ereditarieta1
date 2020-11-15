using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta1
{
    internal class Docente : Lavoratore
    {
        private string Materia { get; set; }
        public List<Studente> Studenti { get; private set; } = new List<Studente>();

        public Docente(string m)
        {
            Nome = base.Nome;
            Cognome = base.Cognome;
            Materia = m;
            Altezza = base.Altezza;
            Stipendio = base.Stipendio;
            DataNascita = base.DataNascita;
        }

        public void AddStudente(Studente st)
        {
            Studenti.Add(st);
        }
    }
}
