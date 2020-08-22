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
                Arreglos.ColasCirculares colasCirculares = new Arreglos.ColasCirculares(5);

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

        static void Colas()
        {
            try
            {
                Arreglos.Colas colas = new Arreglos.Colas(5);

                Console.WriteLine(colas.Imprimir());

                colas.Agregar("cero");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Agregar("uno");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Agregar("dos");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Agregar("tres");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Agregar("cuatro");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("-----------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ColasDobles()
        {
            try
            {
                Arreglos.ColasDobles colasDobles = new Arreglos.ColasDobles(5);

                Console.WriteLine(colasDobles.Imprimir());

                colasDobles.PFront("cero");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("-----------");
                colasDobles.PFront("uno");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("-----------");
                colasDobles.PFront("dos");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("-----------");
                colasDobles.PBack("tres");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("-----------");
                colasDobles.PBack("cuatro");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("-----------");
                colasDobles.DFront();
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("-----------");
                colasDobles.DBack();
                Console.WriteLine(colasDobles.Imprimir());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
