namespace ListaExercicio.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calcular media ponderada -----");
            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da primeira nota: ");
            int peso1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da segunda nota: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da segunda nota:");

            double media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine("A média ponderada das notas é: " + media);

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();



        }
    }
}