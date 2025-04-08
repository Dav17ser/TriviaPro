using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaPro.Modelos;

namespace TriviaPro.Lógica
{
    public static class PreguntaFactory
    {
        private static List<Pregunta> bancoPreguntas = new List<Pregunta>();
        private static List<Pregunta> preguntasUsadas = new List<Pregunta>();

        static PreguntaFactory()
        {
            // CIENCIA
            bancoPreguntas.Add(new PreguntaFacil("¿Cuál es el planeta más cercano al Sol?", new List<string> { "Venus", "Mercurio", "Marte" }, "Mercurio", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué órgano del cuerpo bombea sangre?", new List<string> { "Corazón", "Pulmón", "Hígado" }, "Corazón", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué gas respiramos para vivir?", new List<string> { "Oxígeno", "Dióxido de carbono", "Nitrógeno" }, "Oxígeno", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué forma tiene la Tierra?", new List<string> { "Esfera", "Cubo", "Pirámide" }, "Esfera", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuántos sentidos tiene el ser humano?", new List<string> { "Cinco", "Cuatro", "Seis" }, "Cinco", "Ciencia"));

            bancoPreguntas.Add(new PreguntaMedia("¿Quién propuso la teoría de la relatividad?", new List<string> { "Newton", "Einstein", "Galileo" }, "Einstein", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál es el símbolo químico del agua?", new List<string> { "H2O", "O2", "NaCl" }, "H2O", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué tipo de energía produce el Sol?", new List<string> { "Nuclear", "Solar", "Cinética" }, "Solar", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál es el hueso más largo del cuerpo humano?", new List<string> { "Fémur", "Radio", "Tibia" }, "Fémur", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué unidad mide la intensidad eléctrica?", new List<string> { "Amperio", "Voltio", "Ohmio" }, "Amperio", "Ciencia"));

            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es la fórmula química del ozono?", new List<string> { "O2", "O3", "CO2" }, "O3", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué científico desarrolló la teoría cuántica?", new List<string> { "Planck", "Bohr", "Feynman" }, "Planck", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es el nombre del acelerador de partículas más grande del mundo?", new List<string> { "LHC", "CERN", "Fermilab" }, "LHC", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es el número atómico del oxígeno?", new List<string> { "8", "16", "12" }, "8", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué científico propuso la ley de la gravitación universal?", new List<string> { "Newton", "Einstein", "Kepler" }, "Newton", "Ciencia"));

            // HISTORIA
            bancoPreguntas.Add(new PreguntaFacil("¿En qué año llegó Cristóbal Colón a América?", new List<string> { "1492", "1500", "1485" }, "1492", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién fue el primer presidente de EE.UU.?", new List<string> { "George Washington", "Lincoln", "Jefferson" }, "George Washington", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué país se construyó la Gran Muralla?", new List<string> { "China", "India", "Japón" }, "China", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué imperio construyó el Coliseo?", new List<string> { "Romano", "Griego", "Egipcio" }, "Romano", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién descubrió América?", new List<string> { "Colón", "Magallanes", "Marco Polo" }, "Colón", "Historia"));

            bancoPreguntas.Add(new PreguntaMedia("¿Qué evento inició la Segunda Guerra Mundial?", new List<string> { "Invasión de Polonia", "Ataque a Pearl Harbor", "Batalla de Stalingrado" }, "Invasión de Polonia", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién escribió la Declaración de Independencia de EE.UU.?", new List<string> { "Jefferson", "Washington", "Franklin" }, "Jefferson", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuántos años duró la Guerra de los Cien Años?", new List<string> { "116", "100", "90" }, "116", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué civilización inventó la escritura cuneiforme?", new List<string> { "Sumerios", "Egipcios", "Griegos" }, "Sumerios", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Dónde se firmó el tratado de Versalles?", new List<string> { "Francia", "Alemania", "Inglaterra" }, "Francia", "Historia"));

            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el último zar de Rusia?", new List<string> { "Nicolás II", "Pedro I", "Iván IV" }, "Nicolás II", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué rey inglés tuvo seis esposas?", new List<string> { "Enrique VIII", "Ricardo III", "Carlos II" }, "Enrique VIII", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál fue la civilización que construyó Machu Picchu?", new List<string> { "Inca", "Maya", "Azteca" }, "Inca", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué año cayó el Imperio Romano de Occidente?", new List<string> { "476", "1492", "1453" }, "476", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué país lideró la colonización de África?", new List<string> { "Reino Unido", "España", "Francia" }, "Reino Unido", "Historia"));

            // DEPORTES
            bancoPreguntas.Add(new PreguntaFacil("¿Cuántos jugadores hay en un equipo de fútbol?", new List<string> { "11", "10", "12" }, "11", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué deporte se usa una raqueta?", new List<string> { "Tenis", "Fútbol", "Boxeo" }, "Tenis", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué país se originó el judo?", new List<string> { "Japón", "China", "Corea" }, "Japón", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué deporte juega Lionel Messi?", new List<string> { "Fútbol", "Béisbol", "Baloncesto" }, "Fútbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuántos puntos vale un gol en fútbol?", new List<string> { "1", "2", "3" }, "1", "Deportes"));

            bancoPreguntas.Add(new PreguntaMedia("¿Quién tiene más títulos de Grand Slam en tenis?", new List<string> { "Federer", "Nadal", "Djokovic" }, "Djokovic", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Dónde se celebraron los Juegos Olímpicos 2020?", new List<string> { "Tokio", "Río", "Londres" }, "Tokio", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué país ha ganado más Copas del Mundo de fútbol?", new List<string> { "Brasil", "Alemania", "Italia" }, "Brasil", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué deporte se utiliza el término 'strike'?", new List<string> { "Béisbol", "Fútbol", "Golf" }, "Béisbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál es la duración de un partido de baloncesto profesional?", new List<string> { "48 minutos", "90 minutos", "60 minutos" }, "48 minutos", "Deportes"));

            bancoPreguntas.Add(new PreguntaDificil("¿Quién ganó el Tour de Francia 2021?", new List<string> { "Tadej Pogačar", "Chris Froome", "Egan Bernal" }, "Tadej Pogačar", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es el récord mundial de los 100 metros planos?", new List<string> { "9.58s", "9.63s", "9.69s" }, "9.58s", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué país nació el rugby?", new List<string> { "Inglaterra", "Australia", "Sudáfrica" }, "Inglaterra", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál fue el primer país en organizar un Mundial de fútbol?", new List<string> { "Uruguay", "Italia", "Francia" }, "Uruguay", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién es conocido como el 'hombre más rápido del mundo'?", new List<string> { "Usain Bolt", "Tyson Gay", "Yohan Blake" }, "Usain Bolt", "Deportes"));
        }

        public static Pregunta GenerarPregunta(string categoria, string nivel)
        {
            var preguntasDisponibles = bancoPreguntas
                .Where(p => p.Categoria == categoria && p.Nivel == nivel && !preguntasUsadas.Contains(p))
                .ToList();

            if (preguntasDisponibles.Count == 0)
            {
                return null;
            }

            var random = new Random();
            var preguntaSeleccionada = preguntasDisponibles[random.Next(preguntasDisponibles.Count)];

            preguntasUsadas.Add(preguntaSeleccionada);
            return preguntaSeleccionada;
        }

        public static void ReiniciarSesion()
        {
            preguntasUsadas.Clear();
        }
    }
}

