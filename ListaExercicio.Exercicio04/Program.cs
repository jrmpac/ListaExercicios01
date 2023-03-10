namespace ListaExercicio.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de combustível");

            Console.Write("Digite a quilometragem inicial do veículo: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final do veículo: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite quanto de combustível foi gasto no trajeto: ");
            double combustivel = Convert.ToDouble(Console.ReadLine());

            double consumo = (kmFinal - kmInicial) / combustivel;

            Console.WriteLine("O consumo de combustível por km foi: " + consumo + " L");

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();
        }
    }
}