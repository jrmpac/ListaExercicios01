namespace ListaExercicio.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calculadora fatorial -----");
            Console.WriteLine();

            Console.WriteLine("Insira o número que deseja fazer o calculo fatorial");
            int a = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;

            for (int i = a; i > 0; i--)
            {
                fatorial *= i;                             
                
            }
            Console.WriteLine("Resultado: " + fatorial);
        }
    }
}