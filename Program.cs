namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversion";

            Console.WriteLine("Please Enter A Number: ");
            double num = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Now Enter Another Number: ");
            double sum =
                num + Convert.ToDouble(Console.ReadLine() );

            Console.WriteLine("Total = " + sum );
            Console.ReadKey();
        }
    }
}
