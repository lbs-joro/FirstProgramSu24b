namespace FirstProgramSu24b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int diceNumber = rand.Next(1, 7);

            Console.WriteLine(diceNumber);



        }
    }
}