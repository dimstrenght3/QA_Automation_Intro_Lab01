namespace T04_CentConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double centimeters = length * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
