namespace ListaExercicio.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A forma para calcular o volume de uma esfera é V = (4/3).π.r³");

            Console.Write("Sabendo disso, insira o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14;
            double raioCubo = raio * raio * raio;

            double calcVolume = pi * raioCubo;

            double volume = calcVolume * 4/3;

            Console.WriteLine("O volume da sua esfera é: " + Math.Round(volume, 4));

            Console.WriteLine("Pressione qualquer tecla para sair:");
            Console.ReadLine();
        }
    }
}