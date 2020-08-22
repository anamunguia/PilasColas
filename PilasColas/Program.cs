using Arreglos;
using Listas;
using System;

namespace PilasColas
{
    class Program
    {
        static void Main(string[] args)
        {
            ColasCirculares();

        }

        static void Pilas()
        {
            try
            {

                Arreglos.Pilas Arraypila = new Arreglos.Pilas(5);


                /*  pila.Agregar("cero");
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Agregar("uno");
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Agregar("dos");
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Agregar("tres");
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Agregar("cuatro");
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Agregar("cinco");
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Eliminar();
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Eliminar();
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Eliminar();
                  Console.WriteLine(pila.Imprimir());

                  Console.WriteLine("-----------");
                  pila.Eliminar();
                  Console.WriteLine(pila.Imprimir());  */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ColasCirculares()
        {
            try
            {
                ColasCirculares colasCirculares = new ColasCirculares(5);

                Console.WriteLine(colasCirculares.Imprimir());

                colasCirculares.Agregar("cero");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Agregar("uno");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Agregar("dos");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Agregar("tres");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Agregar("cuatro");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("-----------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
