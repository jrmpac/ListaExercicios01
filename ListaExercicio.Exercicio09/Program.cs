namespace ListaExercicio.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calcular média de nota -----");
            Console.WriteLine();


            Console.Write("Digite a primeira nota do aluno: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota do aluno: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = 4 / (1 / nota1 + 1 / nota2 + 1 / nota3 + 1 / nota4);

            Console.Write("A média harmônica das notas do aluno é de " +  Math.Round(media, 2));

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para sair.");
            Console.ReadLine();

        }
    }
}