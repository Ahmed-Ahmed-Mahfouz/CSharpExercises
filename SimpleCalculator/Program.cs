namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Input the first number: ");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");

            var operation = Console.ReadLine();

            if (EqualsCaseInsensitive(operation, "A"))
            {
                Add(firstNumber, secondNumber);
            }
            else if (EqualsCaseInsensitive(operation, "S"))
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (EqualsCaseInsensitive(operation, "M"))
            {
                Multiply(firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();

            void Add(int a, int b)
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }

            void Subtract(int a, int b)
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }

            void Multiply(int a, int b)
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }

            bool EqualsCaseInsensitive(string a, string b)
            {
                return a.ToUpper() == b.ToUpper();
            }
        }
    }
}
