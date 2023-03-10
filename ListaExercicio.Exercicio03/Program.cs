namespace ListaExercicio.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para calcular o volume de um Cilindro precisamos de 2 medidas: Altura e Raio.");

            
            Console.Write("Digite o valor da altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());


            double volume = Math.PI * altura * (raio * raio;

            Console.WriteLine("O volume do seu cilindro é: " + Math.Round(volume, 2));

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}