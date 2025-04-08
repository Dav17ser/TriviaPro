using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Modelos
{
    public abstract class Pregunta
    {
        public string Texto { get; protected set; }
        public List<string> Opciones { get; protected set; }
        public string RespuestaCorrecta { get; protected set; }
        public string Categoria { get; protected set; }
        public string Nivel { get; protected set; }
        public int TiempoLimite { get; protected set; }

        public Pregunta(string texto, List<string> opciones, string respuestaCorrecta, string categoria, string nivel)
        {
            Texto = texto;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
            Categoria = categoria;
            Nivel = nivel;
        }

        public abstract int ObtenerPuntaje();
        public abstract int ObtenerTiempo(); // en segundos

        public virtual bool EvaluarRespuesta(string respuestaUsuario)
        {
            return respuestaUsuario == RespuestaCorrecta;
        }
    }
}

