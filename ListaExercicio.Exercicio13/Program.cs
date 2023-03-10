namespace ListaExercicio.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calculo padaria -----");

            Console.WriteLine();
            Console.Write("Digite quantos pães foram vendidos: ");
            int qntPaes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de broas que foram vendidas: ");
            int qntBroas = Convert.ToInt32(Console.ReadLine());

            double precoPao = 0.12;
            double precoBroa = 1.50;
            double arrecadacaoPao = qntPaes * precoPao;
            double arrecadacaoBroa = qntBroas * precoBroa;

            double totalVendido = arrecadacaoBroa + arrecadacaoPao;
            double poupanca = totalVendido * 0.10;

            Console.WriteLine("Você vai poupar " + Math.Round(poupanca, 2));

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();

        }
    }
}