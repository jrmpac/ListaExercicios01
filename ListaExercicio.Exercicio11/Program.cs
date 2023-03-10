namespace ListaExercicio.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Verificar se o número é primo -----");

            Console.Write("Digite um número inteiro positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool ehPrimo = true;

            if (num % 1 == 0 && num % num == 0 )
            {
                ehPrimo = true;
                Console.WriteLine("é um número primo.");
            }
            
            else if (num % 1 != 0 || num % num != 0)
            {
                ehPrimo = false;
                Console.WriteLine("Nao eh primo");
            }

            else
            {
                Console.WriteLine("AAAA NAO É um número primo.");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}