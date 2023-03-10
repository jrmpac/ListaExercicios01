namespace ListaExercicio.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Comparador de valores -----");
            Console.WriteLine();

            Console.Write("Insira o primeiro valor: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a == b)
            {
                double c = a + b;
                Console.Write("O resultado da soma dos dois valores é: " + c);
            }
            else
            {
                double c = a * b;
                Console.Write("O resultado da multiplicação dos dois valores é: " + c);
            }

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}