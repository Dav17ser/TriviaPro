using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaPro.Formularios;
using TriviaPro.Lógica;

namespace TriviaPro
{
    public partial class FormInicio: Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(new string[] { "Ciencia", "Historia", "Deportes" });
            cmbNivel.Items.AddRange(new string[] { "Fácil", "Media", "Difícil" });

            cmbCategoria.SelectedIndex(0, "");
            cmbNivel.SelectedIndex(0, "");
            
            cmbCategoria.SelectedIndex = 0;
            cmbNivel.SelectedIndex = 0;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string categoria = cmbCategoria.SelectedItem?.ToString();
            string nivel = cmbNivel.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(categoria) || string.IsNullOrWhiteSpace(nivel))
            {
                MessageBox.Show("Por favor completa todos los campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Reiniciar preguntas usadas
            PreguntaFactory.ReiniciarSesion();

            // Abrir el juego
            FormJuego juego = new FormJuego(categoria, nivel);
            this.Hide();
            juego.ShowDialog();
            this.Show();
        }
    }
}
