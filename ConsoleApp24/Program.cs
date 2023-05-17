namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystals;
            int crystalPrice = 10;

            Console.WriteLine("Эй, путник! У меня есть кристаллы для тебя. Один кристал всего по " + crystalPrice + " монет.");
            Console.Write("Сколько у вас золота: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько вам нужно кристаллов: ");
            crystals = Convert.ToInt32(Console.ReadLine());

            money -= crystals * crystalPrice;

            Console.WriteLine("У вас в сумке - " + crystals + " кристаллов и " + money + " монет.");
        }
    }
}