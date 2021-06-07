using System;

namespace projeeto_EM_DUPLAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deseja fazer login? responda com s(sim) ou n(não)");
            string login = Console.ReadLine();

            if (login == "s")
            {
                Console.WriteLine("digite seu usuario");
                string username = Console.ReadLine();
                Console.WriteLine("digite sua senha");
                string senha = Console.ReadLine();

            }else
            {
                Console.WriteLine("deseja fazer o cadastro?");
                string novoCadastro = Console.ReadLine();
            }

            

        }
    }
}
