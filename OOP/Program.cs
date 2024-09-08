using System.Text.RegularExpressions;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDateTime = new DateTime(2024, 8, 24);
            Console.WriteLine($"the year date = {myDateTime.Year}");
            Console.WriteLine($"the month date = {myDateTime.Month}");
            Console.WriteLine($"the day date = {myDateTime.Day}");

            var firstRect = new Rectangle(20, 10);
            Console.WriteLine(firstRect.Width);
            Console.WriteLine(firstRect.Height);

            var prices = new int[] { 7, 6, 4, 3, 1 };
            var maxProfit = MaxProfit(prices);
            Console.WriteLine(maxProfit);

            Console.ReadKey();
        }

        class Rectangle
        {
            public int Width;
            public int Height;

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }

        public static int MaxProfit(int[] prices)
        {
            var lowestDayToBuy = prices[0];
            var dayIndex = 0;

            for (var i = 1; i < prices.Length; i++)
                if (prices[i] <= lowestDayToBuy)
                {
                    lowestDayToBuy = prices[i];
                    dayIndex = i;
                }

            var hightestDayToSell = prices[dayIndex];

            for(var i = dayIndex; i < prices.Length; i++)
                if (prices[i] >= hightestDayToSell) hightestDayToSell = prices[i];

            return hightestDayToSell - lowestDayToBuy;
        }
    }
}
