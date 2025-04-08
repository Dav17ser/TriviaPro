using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Lógica
{
    public class Puntaje
    {
        public int Total { get; private set; }

        public Puntaje()
        {
            Total = 0;
        }

        public void Sumar(string nivel)
        {
            switch (nivel)
            {
                case "Fácil":
                    Total += 5;
                    break;
                case "Medio":
                    Total += 10;
                    break;
                case "Difícil":
                    Total += 15;
                    break;
            }
        }

        public void Restar()
        {
            Total -= 2;
            if (Total < 0)
                Total = 0;
        }

        public void Reiniciar()
        {
            Total = 0;
        }
    }
}

