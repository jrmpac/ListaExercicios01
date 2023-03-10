namespace ListaExercicio.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Calcular volume lata de óleo ------");

            Console.WriteLine();

            Console.Write("Digite o raio da lata de óleo em centimetros: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura da lata de óleo em centímetros: ");
            double altura = double.Parse(Console.ReadLine());

            double pi = 3.1415;

            double volume = pi * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume da lata de óleo é de " + Math.Round(volume, 2));

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}