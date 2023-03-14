namespace ListaExercicio.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Tabuada -----");
            Console.WriteLine();

            for (int num = 0; num <= 10; num++)
            {
                Console.WriteLine("Tabuada do " + num + ":");

                for (int i = 0; i <= 10; i++)
                {
                    int resultado = num * i;
                    Console.WriteLine(num + "x" + i + "= " + resultado);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();
        }
    }
}