using System;

namespace Pensonato
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] q = new Quartos[9];
            Console.Write("Quantos quartos vão ser separados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("\nRent #"+(i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                q[room] = new Quartos(nome, email);
            }

            Console.WriteLine("\nBusy Rooms: ");
            foreach (Quartos obj in q)
            {
                if (q != null)
                {
                    Console.WriteLine(": "+q);
                }
            }




        }
    }
}
