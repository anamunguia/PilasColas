using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    public class Colas
    {
        private string[] array;
        private int max;
        private int principio;
        private int final;
        public Colas(int tamanio){
            this.array = new string[tamanio];
            this.max = tamanio;
            this.principio = 0;
            this.final = 0;
        }
        private bool ValidaVacio(){
            return (principio == final);
        }
        private bool ValidaLleno(){
            return (final == max);
        }
        public void Agregar(string dato){
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }

            array[(principio + final) % max] = dato;
            final++;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            array[principio] = null;

            principio = (principio + 1) % max;
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            if (ValidaVacio())
            {
                return ("Arreglo Vacío");
            }

            for (int i = principio; i < max; i++)
            {
                if (i > principio)
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {array[i]}";
            }

            return datos;
        }

    }
}