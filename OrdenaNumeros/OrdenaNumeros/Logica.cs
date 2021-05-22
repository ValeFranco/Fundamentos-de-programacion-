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

        public int[,] Matrizvalores
        {
            get
            {
                return matrizValores;
            }
        }
        public Logica()
        {
            posicionFila = 0;
            posicionColumna = 0;
            matrizValores = new int[4, 4];

            //Aqui se invocan los metodos que inicializan las matrices
            InicializaMatrizValores();
        }


        /// <summary>
        /// Inicializa la matriz de valores, asignando los numeros a organizar
        /// </summary>

        public void InicializaMatrizValores()
        {
            int valor = 0;

            //Inicialmente se asignan los números del 0 al 15 en toda la matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizValores[i, j] = valor;
                    valor++;
                }
            }

            //Luego, procedemos a cambiar los valores de posición de manera aleatoria

            Random aleatorio = new Random();
            int posicionHorizontal, posicionVertical, valorTemporal;

            //Aqui desordenamos la matriz, calculando posiciones horizontales y
            //verticales dentro de la matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    valorTemporal = matrizValores[i, j];
                    posicionHorizontal = aleatorio.Next(4);
                    posicionVertical = aleatorio.Next(4);

                    matrizValores[i, j] = matrizValores[posicionHorizontal, posicionVertical];
                    matrizValores[posicionHorizontal, posicionVertical] = valorTemporal;
                }
            }
        }
        

    }
}

