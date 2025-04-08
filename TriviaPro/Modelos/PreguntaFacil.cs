using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Modelos
{
    public class PreguntaFacil : Pregunta
    {
        public PreguntaFacil(string texto, List<string> opciones, string respuestaCorrecta, string categoria)
        : base(texto, opciones, respuestaCorrecta, categoria, "Fácil") { }

        public override int ObtenerPuntaje()
        {
            return 5;
        }

        public override int ObtenerTiempo()
        {
            return 20;
        }
    }

}

