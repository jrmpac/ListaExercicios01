namespace ListaExercicio.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Calculadora de salário ---------- ");
            Console.WriteLine();

            Console.Write("Informe o salário base do vendedor: ");            
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o total de vendas desse vendedor: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a % da comissão sobre o total de vendas: ");
            double porcentagemComissao = Convert.ToDouble(Console.ReadLine());

            porcentagemComissao /= 100;

            double comissao = porcentagemComissao * totalVendas;

            double salarioFinal = comissao + salarioBase;

            Console.WriteLine("O salário total do vendedor é: R$ " + Math.Round(salarioFinal, 2));

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadLine();

        }
    }
}