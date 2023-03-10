namespace ListaExercicio.Exercio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calcular dias de vida -----");
            Console.WriteLine();

            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Escreva sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int diasVida = idade * 365;

            Console.WriteLine(nome+ ", você já viveu " + diasVida + " dias");
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}