namespace ListaExercicio.Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Fizz Buzz -----");
            Console.WriteLine();

            int num = 1;
            string fizz = "Fizz";
            string buzz = "Buzz";
            string fizzBuzz = "FizzBuzz";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(fizzBuzz);

                }

                else if (i % 3 ==0)
                {
                    Console.WriteLine(fizz);
                }              

                else if (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}