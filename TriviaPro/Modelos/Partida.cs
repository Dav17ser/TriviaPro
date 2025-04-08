using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Modelos
{
    public class Partida
    {
        public string Categoria { get; private set; }
        public string Nivel { get; private set; }
        public int Puntaje { get; private set; }
        public int PreguntasRespondidas => HistorialPreguntas.Count;
        public List<Pregunta> HistorialPreguntas { get; private set; }

        public Partida(string categoria, string nivel)
        {
            Categoria = categoria;
            Nivel = nivel;
            Puntaje = 0;
            HistorialPreguntas = new List<Pregunta>();
        }

        public void RegistrarRespuesta(Pregunta pregunta, bool esCorrecta)
        {
            HistorialPreguntas.Add(pregunta);

            if (esCorrecta)
            {
                // Puntaje por nivel correcto
                Puntaje += pregunta.ObtenerPuntaje();
            }
            else
            {
                // Restar 2 puntos por error, mínimo 0
                Puntaje -= 2;
                if (Puntaje < 0)
                {
                    Puntaje = 0;
                }
            }
        }
    }
}
    

