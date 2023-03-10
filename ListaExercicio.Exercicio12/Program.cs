namespace ListaExercicio.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Medir dimensão do terreno -----");

            Console.Write("Digite a Largura do terreno em metros: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno em metros: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine("A área do terreno é de " + area + " metros quadrados.");

        }
    }
}