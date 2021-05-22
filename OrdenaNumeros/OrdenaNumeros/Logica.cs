using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace OrdenaNumeros
{
    class Logica
    {//Atributos propios del juego
        private int[,] matrizValores;
        private int posicionFila, posicionColumna;


        public int PosicionFila
        {
            get
            {
                return posicionFila;
            }
            set
            {
                if (value >= 0 && value <= 17)
                {
                    posicionFila = value;
                }
            }
        }

        public int PosicionColumna
        {
            get
            {
                return posicionColumna;
            }
            set
            {
                if (value >= 0 && value <= 17)
                {
                    posicionColumna = value;
                }
            }
        }
    }
}
