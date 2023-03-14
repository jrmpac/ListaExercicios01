namespace ListaExercicios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora de volume retangular:");

            Console.Write("Digite a largura da sua caixa: ");

            double largura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o comprimento da sua caixa: ");

            double comprimento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura da sua caixa: ");
            
            double altura = Convert.ToInt32(Console.ReadLine());

            double volume = largura * comprimento * altura;

            Console.Write("O volume da sua caixa é: " + volume);

            Console.ReadLine();

        }
    }
}