using System;
using System.Collections.Generic;

namespace EstructurasDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //crearemos un pequeño menu para gestiionar la insercion de nombres
            List<string> names = new List<string>();
            int option = 0;
            
            do
            {
                option = menu();
                switch (option)
                {
                    case 1:
                        string name = String.Empty;
                        do
                        {
                            Console.Write("Ingrese el nombre >"); name = Console.ReadLine().Trim();
                        } while (names.Contains(name));
                        names.Add(name);
                        Console.WriteLine("El nombre se agrego correctamente");
                        break;
                    case 2:
                        string name01 = String.Empty;
                        Console.WriteLine("Ingrese el nombre>"); name01 = Console.ReadLine().Trim();
                        if (names.Remove(name01))
                        {
                            Console.WriteLine("El elemento se elimino correctamente");
                        }
                        else
                        {
                            Console.WriteLine("El elemento no se encuentra disponible");
                        }
                        break;
                    case 3:
                        String name02 = String.Empty;
                        Console.WriteLine("Ingrese un indice entre {0} y {1}>", 0, names.Count - 1);
                        int index = 0;
                        bool result = int.TryParse(Console.ReadLine().Trim(), out index);
                        Console.WriteLine("Index {0}, Ingrese un nombre >", index); name02 = Console.ReadLine().Trim();
                        try
                        {
                            names.Insert(index, name02);
                            Console.WriteLine("El nombre se inserto correctamente");
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Indice fuera de rango,no se inserto en nombre");
                        }     

                        break;
                    case 4:
                        Console.WriteLine(string.Join("\n", names));
                        break;
                    default:
                        break;
                }
            } while (option!=5);
            Console.WriteLine("Gracias por probar el programa");
        }
        private static int menu()
        {
            Console.WriteLine("MENU\n" +
                "(1) Agregar nombre\n" +
                "(2) Eliminar nombre\n" +
                "(3) Insertar nombre\n" +
                "(4) Listar\n" +
                "(5) salir\n");
            int index = 0;
            bool valido = false;
            do
            {
                Console.Write("OP>");
                valido = Int32.TryParse(Console.ReadLine().Trim(), out index);
                if (!valido)
                {
                    continue;
                }
            } while ( index>5 || index<1);
            return index;
        }
    }
}
