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
            // CIENCIA - Fácil
            bancoPreguntas.Add(new PreguntaFacil("¿Cuál es el planeta más cercano al Sol?", new List<string> { "Venus", "Mercurio", "Marte" }, "Mercurio", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué órgano del cuerpo bombea sangre?", new List<string> { "Corazón", "Pulmón", "Hígado" }, "Corazón", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué gas respiramos para vivir?", new List<string> { "Oxígeno", "Dióxido de carbono", "Nitrógeno" }, "Oxígeno", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué forma tiene la Tierra?", new List<string> { "Esfera", "Cubo", "Pirámide" }, "Esfera", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuántos sentidos tiene el ser humano?", new List<string> { "Cinco", "Cuatro", "Seis" }, "Cinco", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué animal es conocido como el rey de la selva?", new List<string> { "Elefante", "León", "Tigre" }, "León", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuántos planetas hay en el sistema solar?", new List<string> { "8", "9", "7" }, "8", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuál es el órgano que permite el sentido de la vista?", new List<string> { "Ojo", "Nariz", "Oído" }, "Ojo", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué instrumento se usa para medir la temperatura?", new List<string> { "Termómetro", "Barómetro", "Higrómetro" }, "Termómetro", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué gas componen mayoritariamente los pulmones humanos?", new List<string> { "Oxígeno", "Nitrógeno", "Dióxido de Carbono" }, "Nitrógeno", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cómo se llama el proceso por el cual las plantas producen su propio alimento?", new List<string> { "Fotosíntesis", "Respiración", "Fermentación" }, "Fotosíntesis", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuáles son los tres estados de la materia?", new List<string> { "Líquido, sólido, gas", "Líquido, plasma, gas", "Sólido, líquido, plasma" }, "Líquido, sólido, gas", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuál es la sustancia más dura que se encuentra en la naturaleza?", new List<string> { "Diamante", "Oro", "Hierro" }, "Diamante", "Ciencia"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué parte del cuerpo humano se encuentran las cuerdas vocales?", new List<string> { "Garganta", "Boca", "Nariz" }, "Garganta", "Ciencia"));

            // CIENCIA - Medio
            bancoPreguntas.Add(new PreguntaMedia("¿Quién propuso la teoría de la relatividad?", new List<string> { "Newton", "Einstein", "Galileo" }, "Einstein", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál es el símbolo químico del agua?", new List<string> { "H2O", "O2", "NaCl" }, "H2O", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué tipo de energía produce el Sol?", new List<string> { "Nuclear", "Solar", "Cinética" }, "Solar", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál es el hueso más largo del cuerpo humano?", new List<string> { "Fémur", "Radio", "Tibia" }, "Fémur", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué unidad mide la intensidad eléctrica?", new List<string> { "Amperio", "Voltio", "Ohmio" }, "Amperio", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué capa de la Tierra se encuentra debajo de la corteza terrestre?", new List<string> { "Manto", "Núcleo", "Litosfera" }, "Manto", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién descubrió la penicilina?", new List<string> { "Louis Pasteur", "Alexander Fleming", "Edward Jenner" }, "Alexander Fleming", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué año se lanzó el primer satélite artificial, Sputnik 1?", new List<string> { "1957", "1961", "1955" }, "1957", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué científico propuso la teoría de la evolución de las especies?", new List<string> { "Darwin", "Galileo", "Newton" }, "Darwin", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué tipo de roca es la más común en la corteza terrestre?", new List<string> { "Sedimentaria", "Ígnea", "Metamórfica" }, "Ígnea", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál es la principal fuente de energía para la fotosíntesis?", new List<string> { "Luz solar", "Luz lunar", "Luz artificial" }, "Luz solar", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué partícula subatómica tiene carga positiva?", new List<string> { "Protón", "Neutrón", "Electrón" }, "Protón", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué planeta es conocido como el 'planeta rojo'?", new List<string> { "Marte", "Venus", "Júpiter" }, "Marte", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué país se encuentra el mayor telescopio del mundo?", new List<string> { "Chile", "Estados Unidos", "China" }, "Chile", "Ciencia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué gas es el responsable de la lluvia ácida?", new List<string> { "Dióxido de azufre", "Dióxido de carbono", "Óxidos de nitrógeno" }, "Dióxido de azufre", "Ciencia"));

            // CIENCIA - Difícil
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es la fórmula química del ozono?", new List<string> { "O2", "O3", "CO2" }, "O3", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué científico desarrolló la teoría cuántica?", new List<string> { "Planck", "Bohr", "Feynman" }, "Planck", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es el nombre del acelerador de partículas más grande del mundo?", new List<string> { "LHC", "CERN", "Fermilab" }, "LHC", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es el número atómico del oxígeno?", new List<string> { "8", "16", "12" }, "8", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué científico propuso la ley de la gravitación universal?", new List<string> { "Newton", "Einstein", "Kepler" }, "Newton", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué científico desarrolló la teoría del Big Bang?", new List<string> { "Hubble", "Lemaître", "Einstein" }, "Lemaître", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es el principal gas de efecto invernadero en la atmósfera?", new List<string> { "Dióxido de carbono", "Metano", "Oxígeno" }, "Dióxido de carbono", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué es el bosón de Higgs?", new List<string> { "Partícula subatómica", "Acelerador de partículas", "Átomo" }, "Partícula subatómica", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué planta se utiliza para la producción de oxígeno?", new List<string> { "Cactus", "Alga", "Pino" }, "Alga", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué gas se produce cuando se quema el carbón?", new List<string> { "Monóxido de carbono", "Dióxido de carbono", "Óxidos de nitrógeno" }, "Monóxido de carbono", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién desarrolló la teoría del electromagnetismo?", new List<string> { "Faraday", "Maxwell", "Tesla" }, "Maxwell", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Cuál es el nombre de la partícula responsable de la carga negativa en el átomo?", new List<string> { "Electrón", "Neutrón", "Protón" }, "Electrón", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué elemento químico es utilizado en la fabricación de pilas recargables?", new List<string> { "Litio", "Plomo", "Níquel" }, "Litio", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué científica ganó dos premios Nobel en diferentes campos?", new List<string> { "Marie Curie", "Rosalind Franklin", "Ada Lovelace" }, "Marie Curie", "Ciencia"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué año se descubrió el electrón?", new List<string> { "1897", "1900", "1865" }, "1897", "Ciencia"));

            // HISTORIA - Fácil
            bancoPreguntas.Add(new PreguntaFacil("¿En qué año llegó Cristóbal Colón a América?", new List<string> { "1492", "1500", "1485" }, "1492", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién fue el primer presidente de EE.UU.?", new List<string> { "George Washington", "Lincoln", "Jefferson" }, "George Washington", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué país se construyó la Gran Muralla?", new List<string> { "China", "India", "Japón" }, "China", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué imperio construyó el Coliseo?", new List<string> { "Romano", "Griego", "Egipcio" }, "Romano", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién descubrió América?", new List<string> { "Colón", "Magallanes", "Marco Polo" }, "Colón", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué guerra tuvo lugar entre 1914 y 1918?", new List<string> { "Primera Guerra Mundial", "Segunda Guerra Mundial", "Guerra de Vietnam" }, "Primera Guerra Mundial", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué presidente estadounidense emitió la Proclamación de Emancipación?", new List<string> { "Abraham Lincoln", "George Washington", "Thomas Jefferson" }, "Abraham Lincoln", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién fue el líder nazi de Alemania durante la Segunda Guerra Mundial?", new List<string> { "Adolf Hitler", "Joseph Stalin", "Benito Mussolini" }, "Adolf Hitler", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué civilización construyó las pirámides de Egipto?", new List<string> { "Egipcios", "Mayas", "Aztecas" }, "Egipcios", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué año se firmó la Declaración de Independencia de EE.UU.?", new List<string> { "1776", "1787", "1791" }, "1776", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué país construyó la pirámide de Giza?", new List<string> { "Egipto", "México", "Italia" }, "Egipto", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién fue el primer emperador de Roma?", new List<string> { "Octavio", "Nerón", "César" }, "Octavio", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué civilización construyó las líneas de Nazca?", new List<string> { "Maya", "Inca", "Nazca" }, "Nazca", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué siglo comenzó la Revolución Francesa?", new List<string> { "Siglo XVIII", "Siglo XIX", "Siglo XVII" }, "Siglo XVIII", "Historia"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién fue el líder de la Revolución Mexicana?", new List<string> { "Pancho Villa", "Emiliano Zapata", "Hernán Cortés" }, "Pancho Villa", "Historia"));
            
            // HISTORIA - Medio
            bancoPreguntas.Add(new PreguntaMedia("¿Qué evento histórico ocurrió en 1789?", new List<string> { "Revolución Francesa", "Independencia de EE.UU.", "Ascenso de Napoleón" }, "Revolución Francesa", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién fue el líder del Imperio Romano durante su mayor expansión?", new List<string> { "César", "Constantino", "Augusto" }, "Augusto", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué guerra fue utilizado el avión por primera vez?", new List<string> { "Primera Guerra Mundial", "Segunda Guerra Mundial", "Guerra de Corea" }, "Primera Guerra Mundial", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué civilización construyó la ciudad de Machu Picchu?", new List<string> { "Aztecas", "Mayas", "Incas" }, "Incas", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién fue el líder de la Revolución Cubana?", new List<string> { "Che Guevara", "Fidel Castro", "Juan Perón" }, "Fidel Castro", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién fue el último emperador romano?", new List<string> { "Rómulo Augústulo", "Julio César", "Augusto" }, "Rómulo Augústulo", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué país fue el primero en lanzar un satélite al espacio?", new List<string> { "EE.UU.", "URSS", "China" }, "URSS", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué presidente fue asesinado en 1963 en Dallas, EE.UU.?", new List<string> { "John F. Kennedy", "Abraham Lincoln", "Richard Nixon" }, "John F. Kennedy", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué año se firmó la Paz de Westfalia?", new List<string> { "1648", "1600", "1500" }, "1648", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál fue la causa principal de la caída del Imperio Romano?", new List<string> { "Invasiones bárbaras", "Revueltas internas", "Falta de recursos" }, "Invasiones bárbaras", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál fue la primera ciudad en tener un sistema de alcantarillado?", new List<string> { "Roma", "Mesopotamia", "Alejandría" }, "Roma", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué batalla fue derrotado Napoleón Bonaparte?", new List<string> { "Waterloo", "Leipzig", "Austerlitz" }, "Waterloo", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién fue el primer presidente de la República Mexicana?", new List<string> { "Benito Juárez", "Miguel de la Madrid", "Guadalupe Victoria" }, "Guadalupe Victoria", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué fecha comenzó la Primera Guerra Mundial?", new List<string> { "28 de junio de 1914", "1 de septiembre de 1914", "4 de julio de 1914" }, "28 de junio de 1914", "Historia"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué año cayó el muro de Berlín?", new List<string> { "1989", "1991", "1979" }, "1989", "Historia"));

            // HISTORIA - Difícil
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el último zar de Rusia?", new List<string> { "Nicolás II", "Alejandro III", "Pedro el Grande" }, "Nicolás II", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué año terminó la Guerra de Vietnam?", new List<string> { "1975", "1973", "1980" }, "1975", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué tratado puso fin a la Primera Guerra Mundial?", new List<string> { "Tratado de Versalles", "Tratado de París", "Tratado de Utrecht" }, "Tratado de Versalles", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué imperio conquistó Constantinopla en 1453?", new List<string> { "Imperio Otomano", "Imperio Romano", "Imperio Bizantino" }, "Imperio Otomano", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el emperador chino durante la dinastía Ming?", new List<string> { "Yongle", "Kangxi", "Shunzhi" }, "Yongle", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué año marcó el inicio de la Edad Media?", new List<string> { "476", "500", "600" }, "476", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué evento dio inicio a la Segunda Guerra Mundial?", new List<string> { "Invasión de Polonia", "Firma del Tratado de Versalles", "Batalla de Stalingrado" }, "Invasión de Polonia", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el líder del Imperio Mongol?", new List<string> { "Genghis Khan", "Kublai Khan", "Tamerlán" }, "Genghis Khan", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fundó el Imperio Francés en el siglo XIX?", new List<string> { "Napoleón Bonaparte", "Carlos Magno", "Luis XIV" }, "Napoleón Bonaparte", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué fecha se produjo el atentado del 11 de septiembre de 2001?", new List<string> { "11 de septiembre", "1 de enero", "4 de julio" }, "11 de septiembre", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el primer califa omeya?", new List<string> { "Muawiya I", "Abu Bakr", "Ali ibn Abi Talib" }, "Muawiya I", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué país formó parte de la antigua Yugoslavia?", new List<string> { "Rumanía", "Croacia", "Hungría" }, "Croacia", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el primer ministro del Reino Unido durante la Primera Guerra Mundial?", new List<string> { "David Lloyd George", "Winston Churchill", "Herbert Asquith" }, "Herbert Asquith", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué batalla se firmó la rendición de Japón en la Segunda Guerra Mundial?", new List<string> { "Batalla de Midway", "Batalla de Okinawa", "Rendición de Japón en la bahía de Tokio" }, "Rendición de Japón en la bahía de Tokio", "Historia"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el último emperador del Imperio Bizantino?", new List<string> { "Constantino XI Paleólogo", "Teodosio I", "Justinian I" }, "Constantino XI Paleólogo", "Historia"));
            
            // DEPORTES - Fácil
            bancoPreguntas.Add(new PreguntaFacil("¿En qué deporte se utiliza una pelota y una raqueta?", new List<string> { "Tenis", "Fútbol", "Básquetbol" }, "Tenis", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué deporte se juega con un balón redondo?", new List<string> { "Fútbol", "Tenis", "Béisbol" }, "Fútbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Quién es conocido como 'La Pulga' en el fútbol?", new List<string> { "Cristiano Ronaldo", "Lionel Messi", "Neymar" }, "Lionel Messi", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué deporte se juega con un aro y una pelota?", new List<string> { "Básquetbol", "Fútbol", "Voleibol" }, "Básquetbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué país ganó la Copa del Mundo de Fútbol en 2018?", new List<string> { "Francia", "Brasil", "Alemania" }, "Francia", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué deporte se practica un 'slam dunk'?", new List<string> { "Básquetbol", "Fútbol", "Hockey" }, "Básquetbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué equipo de fútbol tiene como apodo 'Los Red Devils'?", new List<string> { "Manchester United", "Liverpool", "Chelsea" }, "Manchester United", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué deporte se practica un 'gol de campo'?", new List<string> { "Fútbol", "Rugby", "Béisbol" }, "Fútbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué deporte se utiliza un puck?", new List<string> { "Hockey sobre hielo", "Béisbol", "Fútbol" }, "Hockey sobre hielo", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué deporte se juega con una raqueta y una pelota amarilla?", new List<string> { "Tenis", "Golf", "Cricket" }, "Tenis", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué deporte tiene una competición llamada 'Super Bowl'?", new List<string> { "Fútbol Americano", "Fútbol", "Béisbol" }, "Fútbol Americano", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuántos minutos dura un partido de fútbol?", new List<string> { "90 minutos", "60 minutos", "120 minutos" }, "90 minutos", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Cuál es el equipo de fútbol más famoso de Argentina?", new List<string> { "Boca Juniors", "River Plate", "Independiente" }, "Boca Juniors", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿Qué deporte se juega en Wimbledon?", new List<string> { "Tenis", "Cricket", "Golf" }, "Tenis", "Deportes"));
            bancoPreguntas.Add(new PreguntaFacil("¿En qué país se originó el deporte del béisbol?", new List<string> { "Estados Unidos", "Japón", "Cuba" }, "Estados Unidos", "Deportes"));

            // DEPORTES - Medio
            bancoPreguntas.Add(new PreguntaMedia("¿Quién tiene más títulos de Grand Slam en tenis?", new List<string> { "Federer", "Nadal", "Djokovic" }, "Djokovic", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Dónde se celebraron los Juegos Olímpicos 2020?", new List<string> { "Tokio", "Río", "Londres" }, "Tokio", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué país ha ganado más Copas del Mundo de fútbol?", new List<string> { "Brasil", "Alemania", "Italia" }, "Brasil", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué deporte se utiliza el término 'strike'?", new List<string> { "Béisbol", "Fútbol", "Golf" }, "Béisbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Cuál es la duración de un partido de baloncesto profesional?", new List<string> { "48 minutos", "90 minutos", "60 minutos" }, "48 minutos", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién tiene el récord de más goles en la historia de la Copa del Mundo?", new List<string> { "Marta", "Ronaldo Nazário", "Miroslav Klose" }, "Miroslav Klose", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué año se celebraron los primeros Juegos Olímpicos modernos?", new List<string> { "1896", "1900", "1924" }, "1896", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué país ganó la primera Copa Mundial de Fútbol?", new List<string> { "Brasil", "Uruguay", "Argentina" }, "Uruguay", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué deporte olímpico tiene una modalidad llamada 'pista y campo'?", new List<string> { "Atletismo", "Natación", "Voleibol" }, "Atletismo", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué país se originó el fútbol?", new List<string> { "Inglaterra", "Brasil", "Escocia" }, "Inglaterra", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué tenista tiene más títulos de Grand Slam?", new List<string> { "Roger Federer", "Rafael Nadal", "Novak Djokovic" }, "Novak Djokovic", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién fue el primer boxeador en ganar tres campeonatos mundiales de diferentes categorías?", new List<string> { "Muhammad Ali", "Sugar Ray Leonard", "Floyd Mayweather" }, "Sugar Ray Leonard", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Qué equipo de fútbol tiene más títulos de la UEFA Champions League?", new List<string> { "Real Madrid", "Barcelona", "AC Milan" }, "Real Madrid", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿En qué deporte se practica el famoso movimiento conocido como 'backflip'?", new List<string> { "Gimnasia", "Fútbol", "Basketbol" }, "Gimnasia", "Deportes"));
            bancoPreguntas.Add(new PreguntaMedia("¿Quién fue el primer jugador en ganar cinco Balones de Oro?", new List<string> { "Cristiano Ronaldo", "Lionel Messi", "Michel Platini" }, "Lionel Messi", "Deportes"));

            // DEPORTES - Difícil
            bancoPreguntas.Add(new PreguntaDificil("¿En qué deporte se utiliza un 'tachón'?", new List<string> { "Fútbol", "Béisbol", "Fútbol Americano" }, "Fútbol", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué nadador es conocido por ser el más condecorado en la historia de los Juegos Olímpicos?", new List<string> { "Michael Phelps", "Ian Thorpe", "Caeleb Dressel" }, "Michael Phelps", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué equipo de la NBA jugó Michael Jordan en la mayor parte de su carrera?", new List<string> { "Los Angeles Lakers", "Chicago Bulls", "Miami Heat" }, "Chicago Bulls", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién tiene el récord de más goles en la historia de la Premier League?", new List<string> { "Wayne Rooney", "Sergio Agüero", "Alan Shearer" }, "Alan Shearer", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿En qué año se celebró el primer Mundial de Rugby?", new List<string> { "1987", "1991", "1974" }, "1987", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el primer ciclista en ganar el Tour de Francia cinco veces?", new List<string> { "Jacques Anquetil", "Eddy Merckx", "Bernard Hinault" }, "Jacques Anquetil", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué boxeador fue conocido como 'El Hombre más temido del Mundo'?", new List<string> { "Mike Tyson", "Muhammad Ali", "Joe Frazier" }, "Mike Tyson", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Qué equipo de fútbol tiene más títulos de la Copa América?", new List<string> { "Argentina", "Brasil", "Uruguay" }, "Uruguay", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién es el único deportista en ganar medallas olímpicas en dos deportes diferentes?", new List<string> { "Carl Lewis", "Michael Phelps", "Clara Hughes" }, "Clara Hughes", "Deportes"));
            bancoPreguntas.Add(new PreguntaDificil("¿Quién fue el primer atleta en correr los 100 metros en menos de 10 segundos?", new List<string> { "Bob Hayes", "Carl Lewis", "Usain Bolt" }, "Bob Hayes", "Deportes"));
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

