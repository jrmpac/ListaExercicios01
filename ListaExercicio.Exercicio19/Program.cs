namespace ListaExercicio.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calculadora IMC -----");

            Console.WriteLine();
            Console.Write("Insira seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }

            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            }

            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }

            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obesidade Grau I");
            }

            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Obesidade Grau II");
            }

            else
            {
                Console.WriteLine("Obesidade Grau III ou Mórbida");
            }
        }
    }
}