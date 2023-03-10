namespace ListaExercicio.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Mostrar números em ordem descrescente -----");

            Console.WriteLine();
            Console.Write("Escreva o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o segundo número: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escreva o terceiro número:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b || a == c || b == c)
            {
                Console.WriteLine("Digite números diferentes.");

            }

            else if (a > b && b > c)
            {
                Console.WriteLine("O maior número é: " + a);
                Console.WriteLine("O segundo número é: " + b);
                Console.WriteLine("O menor número é: " + c);
            }

            else if (a > c && c > b)
            {
                Console.WriteLine("O maior número é: " + a);
                Console.WriteLine("O segundo número é: " + c);
                Console.WriteLine("O menor número é: " + b);
            }

            else if (b > a && a > c)
            {
                Console.WriteLine("O maior número é: " + b);
                Console.WriteLine("O segundo número é: " + a);
                Console.WriteLine("O menor número é: " + c);
            }

            else if (c > a && a > b)
            {
                Console.WriteLine("O maior número é: " + c);
                Console.WriteLine("O segundo número é: " + a);
                Console.WriteLine("O menor número é: " + b);
            }

            else
            {
                Console.WriteLine("O maior número é: " + c);
                Console.WriteLine("O segundo número é: " + b);
                Console.WriteLine("O menor número é: " + a);
            }
        }

    }
}
