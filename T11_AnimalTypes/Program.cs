namespace T11_AnimalsType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "tortoise":
                case "crocodile":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }           
        }
    }
}
