using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaPro.Lógica
{
    class TemporizadorTrivia
    {
        private Timer timer;
        public int TiempoRestante { get; private set; }
        public event Action TiempoTerminado;
        public event Action<int> TiempoActualizado;

        public TemporizadorTrivia()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        public void Iniciar(int segundos)
        {
            TiempoRestante = segundos;
            timer.Start();
        }

        public void Detener()
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TiempoRestante--;
            TiempoActualizado?.Invoke(TiempoRestante);

            if (TiempoRestante <= 0)
            {
                timer.Stop();
                TiempoTerminado?.Invoke();
            }
        }
    }
}

