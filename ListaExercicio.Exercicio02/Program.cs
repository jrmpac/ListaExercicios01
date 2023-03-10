namespace ListaExercicio.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double fahrenheit = 0;
            double celsius = 0;

            Console.Write("Digite a temperatura em Fahrenheit que deseja converter para Celsius: ");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = -32;

            double temperaturaTemporaria = fahrenheit - celsius;

            double temperaturaFinal = temperaturaTemporaria / 1.8;

            Console.WriteLine("A temperatura em graus celsius é: " + Math.Round(temperaturaFinal, 2));

            Console.ReadLine();
        }
    }
}