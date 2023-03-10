namespace ListaExercicio.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Efetuar soma números ímpare múltiplos de três entre 1 até 500 -----");
            Console.WriteLine();

            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;

                    Console.WriteLine("A soma dos números impares de três é: " + soma);
                }
            }
        }
    }
}