namespace ListaExercicio.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Verificador de par ou impar -----");
            Console.WriteLine();
            
            Console.Write("Digite o número que deseja verificar:");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.Write("É par.");;
            }
            else
            {
                Console.Write("É impar.");
            }

            Console.WriteLine("Digite qualquer tecla para sair.");
            Console.ReadLine();
        }
    }
}