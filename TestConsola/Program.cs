using System;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            EmulateLogin();
        }
        private static void DeclaracionOfVariable()
        {
            bool esValido = false;
            int edad = 0;
            Console.WriteLine("HOLAAAA ESTOY HACIENDO UN REPASO");
            while (!esValido)
            {

                try
                {
                    Console.Write("Ingrese su edad> "); edad = Convert.ToInt32(Console.ReadLine());
                    esValido = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("La edad ingresada es incorrecta");
                }

            }
            Console.WriteLine($"Tienes {edad} años");
            Console.WriteLine("Hasta pronto");
            char firstName = Console.ReadKey().KeyChar;
            Console.WriteLine(firstName);
        }
        private static void EmulateLogin()
        {
            string password = "user01";
            string attemp = String.Empty;
            ConsoleKeyInfo cki;
            Console.Write("PASSWORD>");
            cki = Console.ReadKey(true);
            while (cki.Key != ConsoleKey.Enter)
            {
                if (cki.Key != ConsoleKey.Backspace)
                {
                    attemp += cki.KeyChar.ToString();
                    Console.Write("*");
                }
                else if (!attemp.Equals(String.Empty))
                {
                    Console.Write("\b");
                }
                cki = Console.ReadKey(true);
            }
            Console.WriteLine();
            if (attemp.Equals(password))
            {
                Console.WriteLine("Ingreso al sistema de forma exitosa!");
            }
            else
            {
                Console.WriteLine("Acceso denegado, contraseña incorrecta");
            }
        }
    }
}
