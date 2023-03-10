namespace ListaExercicio.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Salario do funcionário e aumento -----");

            Console.WriteLine();
            Console.WriteLine("Insira o salário inicial do funcionário");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            double aumentoPorcentagem = salarioBase * 0.15;
            double salarioAumentado = aumentoPorcentagem + salarioBase;

            double descontoSalario = salarioAumentado * 0.08;
            double salarioDescontado = salarioAumentado - descontoSalario;

            Console.WriteLine("O salário inicial é: " + salarioBase);
            Console.WriteLine("O salário com aumento é: " + salarioAumentado);
            Console.WriteLine("O salário final é: " + salarioDescontado);
            
        }
    }
}