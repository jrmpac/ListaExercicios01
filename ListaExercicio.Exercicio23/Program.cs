namespace ListaExercicio.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Gerador de números impares entre 100 e 200 -----");
            Console.WriteLine();

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}