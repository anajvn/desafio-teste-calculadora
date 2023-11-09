namespace desafioTesteCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine(calc.Somar(1, 2));
            Console.WriteLine(calc.Subtrair(1, 2));
            Console.WriteLine(calc.Multiplicar(1,2));
            Console.WriteLine(calc.Dividir(1, 2));
            calc.Historico().ForEach(s => Console.WriteLine(s));
        }
    }
}