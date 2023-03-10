namespace ListaExercicio.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a temperatura em Celsius: ");

            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahnrenheit = celsius * 1.8 + 32;

            Console.WriteLine();
            Console.WriteLine("A temperatura em Fahnrenheit é: " + Math.Round(fahnrenheit, 1));

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();

        }
    }
}