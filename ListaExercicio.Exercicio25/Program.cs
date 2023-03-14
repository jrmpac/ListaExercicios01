namespace ListaExercicio.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calcular tabuada de N -----");
            Console.WriteLine();

            Console.Write("Insira o número que deseja ver a tabuada: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int tabuada = 0;

            if (n >= 1 || n <= 10 )
            {
                for (int i = 0; i < 11; i++)
                {
                    tabuada = n * i;
                    Console.WriteLine(+ n + i + "=" + tabuada);
                }
                
            }

        }
    }
}