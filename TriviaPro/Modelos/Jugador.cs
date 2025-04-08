using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaPro.Lógica;

namespace TriviaPro.Modelos
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public Puntaje Puntaje { get; private set; }
        public int PreguntasRespondidas { get; private set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Puntaje = new Puntaje();
            PreguntasRespondidas = 0;
        }

        public void ResponderCorrectamente(string nivel)
        {
            Puntaje.Sumar(nivel);
            PreguntasRespondidas++;
        }

        public void ResponderIncorrectamente()
        {
            Puntaje.Restar();
            PreguntasRespondidas++;
        }

        public void Reiniciar()
        {
            Puntaje.Reiniciar();
            PreguntasRespondidas = 0;
        }
    }

}

