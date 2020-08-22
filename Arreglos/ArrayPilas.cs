using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    public class ArrayPilas
    {
        private string[] array;
        private int max;
        private int tope;

        public ArrayPilas(int tamanio)
        {
            this.array = new string[tamanio];
            this.tope = 0;
            this.max = array.Length - 1;
        }
        private bool validaVacio()
        {
            return (tope < 1);
        }
        private bool validaLleno()
        {
            return (tope > max);
        }
        public void Agregar(string dato)
        {
            if (validaLleno())
            {
                throw new Exception("arreglo lleno");
            }
            array[tope] = dato;
            tope++;
        }
        public void Eliminar()
        {
            if (validaVacio())
            {
                throw new Exception("arreglo vacío");
            }
            tope--;
            array[tope] = null;

            string.IsNullOrEmpty("");
        }
        public string Imprimir()
        {
            string dato = string.Empty;
            if (validaVacio())
            {
                return "arreglo vacio";
            }
            for (int i = 0; i < tope; i++)
            {
                if (i > 0)
                {
                    dato += "\n";
                }
                dato += $"[{i}]-{array[i]}";
            }

            return dato;
        }
    }
}
