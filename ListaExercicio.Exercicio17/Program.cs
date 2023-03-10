namespace ListaExercicio.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Imprimir valores A B C -----");
            Console.WriteLine();
            Console.Write("Insira o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o terceiro valor: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma dos dois primeiros números é menor que o terceiro número");
            }

            else
            {
                Console.WriteLine("A soma dos dois primeiros é maior que o terceiro número");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();
        }
    }
}