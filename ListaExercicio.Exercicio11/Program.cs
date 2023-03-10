namespace ListaExercicio.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Verificar se o número é primo -----");

            Console.WriteLine("Digite o número que você deseja saber se é primo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool ehPrimo = true;

            if (num <= 1)
            {
                ehPrimo = false;
            }

            else
            {

            }

        }
    }
}