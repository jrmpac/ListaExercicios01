namespace ListaExercicio.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Conversor Celsius para Fahrenheit -----");

            Console.WriteLine();
            Console.Write("Digite a temperatura em graus Celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: " + Math.Round(fahrenheit, 2));
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair");

            Console.ReadLine();
        }
    }
}