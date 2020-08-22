using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    public class ColasDobles
    {   //principio y final para almacenar
        private string[] array;
        private int max;
        private int principio;
        private int final;
        private int key;

        public ColasDobles(int tamanio)
        {
            this.array = new string[tamanio];
            this.max = tamanio;
            this.principio = 0;            
            this.final = 0;
            this.key = 0;

        }
        private bool ValidaVacio()
        {
            return (principio == -1);
        }
        private bool ValidaLleno()
        {
            return (key == max);
        }

        public void PFront(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }
            array[principio] = dato;
            principio++;
            key++;
            if ((final == 0) || (principio==final+1))
            {
                final = max;
            }
        }
        public void PBack(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }
            if (final == 0)
            {
                final = max;
            }
            else
            {
                final--;
            }
            array[final] = dato;
            key++;
        }
        public void DBack()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            array[final] = null;
            if (final == max - 1)
            {
                final = 0;
            }
            else if (principio == final)
            {
                principio = final = 0;
            }
            final++;
        }
        public void DFront()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            array[principio - 1] = null;
            principio--;
            if (principio == final)
            {
                principio = final = 0;
            }
            else if (final == max - 1)
            {
                final = 0;
            }

        }
        public string Imprimir()
        {
            string datos = string.Empty;
            if (ValidaVacio())
            {
                return ("Arreglo Vacío");
            }

            for (int i = 0; i < max; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {array[i]}";
            }

            return datos;
        }

    }
}
