using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaPro.Lógica;
using TriviaPro.Modelos;

namespace TriviaPro.Formularios
{
    public partial class FormJuego : Form
    {
        private string categoriaSeleccionada;
        private string nivelSeleccionado;
        private Partida partida;
        private TemporizadorTrivia temporizador;
        private Pregunta preguntaActual;
        private int tiempoRestante;

        public FormJuego(string categoria, string nivel)
        {
            InitializeComponent();
            this.categoriaSeleccionada = categoria;
            this.nivelSeleccionado = nivel;

            // Reiniciar preguntas usadas en cada sesión nueva
            PreguntaFactory.ReiniciarSesion();

            partida = new Partida(categoria, nivel);
            temporizador = new TemporizadorTrivia();

            IniciarJuego();
        }

        private void IniciarJuego()
        {
            CargarSiguientePregunta();
        }

        private void CargarSiguientePregunta()
        {
            if (partida.PreguntasRespondidas >= 15)
            {
                FinalizarJuego();
                return;
            }

            preguntaActual = PreguntaFactory.GenerarPregunta(categoriaSeleccionada, nivelSeleccionado);

            if (preguntaActual == null)
            {
                MessageBox.Show("No hay más preguntas disponibles para esta categoría y nivel.", "Fin del Juego");
                FinalizarJuego();
                return;
            }

            lblPregunta.Text = preguntaActual.Texto;

            var opciones = preguntaActual.Opciones;
            rdb1.Text = opciones[0];
            rdb2.Text = opciones[1];
            rdb3.Text = opciones[2];
            rdb1.Checked = rdb2.Checked = rdb3.Checked = false;

            if (opciones.Count == 4)
            {
                rdb4.Text = opciones[3];
                rdb4.Visible = true;
                rdb4.Checked = false;
            }
            else
            {
                rdb4.Visible = false;
            }

            lblPreguntaN.Text = $"Pregunta {partida.PreguntasRespondidas + 1} de 15";

            IniciarTemporizador();
        }

        private void IniciarTemporizador()
        {
            tiempoRestante = preguntaActual.ObtenerTiempo();
            pbTiempo.Maximum = tiempoRestante;
            pbTiempo.Value = tiempoRestante;
            lblTiempo.Text = $"Tiempo restante: {tiempoRestante}s";

            timerPregunta.Start();
        }

        private void timerPregunta_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            pbTiempo.Value = Math.Max(0, tiempoRestante);
            lblTiempo.Text = $"Tiempo restante: {tiempoRestante}s";

            if (tiempoRestante <= 0)
            {
                timerPregunta.Stop();
                EvaluarRespuesta(null);
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string respuestaSeleccionada = null;

            if (rdb1.Checked) respuestaSeleccionada = rdb1.Text;
            else if (rdb2.Checked) respuestaSeleccionada = rdb2.Text;
            else if (rdb3.Checked) respuestaSeleccionada = rdb3.Text;
            else if (rdb4.Visible && rdb4.Checked) respuestaSeleccionada = rdb4.Text;

            if (respuestaSeleccionada == null)
            {
                MessageBox.Show("Debes seleccionar una opción antes de responder.", "Advertencia");
                return;
            }

            timerPregunta.Stop();
            EvaluarRespuesta(respuestaSeleccionada);
        }

        private void EvaluarRespuesta(string respuesta)
        {
            bool correcta = preguntaActual.EvaluarRespuesta(respuesta);
            partida.RegistrarRespuesta(preguntaActual, correcta);

            lblPuntaje.Text = $"Puntaje: {partida.Puntaje}";

            string mensaje = correcta ?
                "¡Correcto! 😄" :
                $"Incorrecto. ❌\nLa respuesta era: {preguntaActual.RespuestaCorrecta}";

            MessageBox.Show(mensaje, "Resultado");

            CargarSiguientePregunta();
        }

        private void FinalizarJuego()
        {
            timerPregunta.Stop();

            string resumen = $"¡Juego finalizado!\n\nPuntaje total: {partida.Puntaje} puntos\n" +
                             $"Preguntas respondidas: {partida.PreguntasRespondidas}\n\n¡Gracias por jugar!";

            MessageBox.Show(resumen, "Resumen Final");
            this.Close();
        }

    }
}