using System.Transactions;

namespace Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnnualFee = int.Parse(Console.ReadLine());

            double SneakersPrice = AnnualFee * 0.60;
            double TeamPrice = SneakersPrice * 0.80;
            double BallPrice = TeamPrice * 0.25;
            double AccessoriesPrice = BallPrice * 0.20;
            double TotalPrise = AnnualFee + SneakersPrice+ TeamPrice + BallPrice + AccessoriesPrice;

            Console.WriteLine(TotalPrise);
        }
    }
}