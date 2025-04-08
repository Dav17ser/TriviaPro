using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Modelos
{
    public class PreguntaMedia : Pregunta
    {
        public PreguntaMedia(string texto, List<string> opciones, string respuestaCorrecta, string categoria)
        : base(texto, opciones, respuestaCorrecta, categoria, "Media") { }

        public override int ObtenerPuntaje()
        {
            return 10;
        }

        public override int ObtenerTiempo()
        {
            return 15;
        }
    }
}

