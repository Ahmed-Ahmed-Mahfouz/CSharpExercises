namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TODOs = new List<string>();
            TODOs.Add("Order a cake for the birthday party.");
            TODOs.Add("Buy train tickets for the weekend.");
            TODOs.Add("Take Lucky to the vet.");

            var endApp = false;

            Console.WriteLine("Hello!");

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODO");
                Console.WriteLine("[R]emove a TODO");
                Console.WriteLine("[E]xit");

                string choice = getUserChoice();

                switch (choice)
                {
                    case "S":
                        seeAllTODOs(TODOs);
                        break;
                    case "A":
                        addTODO(TODOs);
                        break;
                    case "R":
                        removeTODO(TODOs);
                        break;
                    case "E":
                        endApp = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            } while (!endApp);

        }

        static string getUserChoice()
        {
            return Console.ReadLine().ToUpper();
        }

        static void seeAllTODOs(List<string> TODOs)
        {
            Console.WriteLine("Here are your TODOs:");
            if (TODOs.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                return;
            }
            for (int i = 0; i < TODOs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {TODOs[i]}");
            }
        }

        static void addTODO(List<string> TODOs)
        {
            var validTODO = false;
            do
            {
                Console.WriteLine("Enter the TODO description:");
                string newTODO = Console.ReadLine();
                if (string.IsNullOrEmpty(newTODO))
                {
                    Console.WriteLine("The description cannot be empty.");
                }
                else if (TODOs.Contains(newTODO))
                {
                    Console.WriteLine("The description must be unique.");
                }
                else
                {
                    TODOs.Add(newTODO);
                    Console.WriteLine("TODO successfully added");
                    seeAllTODOs(TODOs);
                    validTODO = true;
                }
            } while (!validTODO);
        }

        static void removeTODO(List<string> TODOs)
        {
            var validIndex = false;
            do
            {
                Console.WriteLine("Enter the number of the TODO you want to remove:");
                string index = Console.ReadLine();
                if (index == null)
                {
                    Console.WriteLine("Selected index cannot be empty.");
                }
                else if (!int.TryParse(index, out int i))
                {
                    Console.WriteLine("The given index is not valid.");
                }
                else if (TODOs.Count == 0)
                {
                    Console.WriteLine("No TODOs have been added yet.");
                    break;
                }
                else if (i < 1 || i > TODOs.Count)
                {
                    Console.WriteLine("The given index is not valid.");
                }
                else
                {
                    TODOs.RemoveAt(i - 1);
                    Console.WriteLine("TODO successfully removed");
                    seeAllTODOs(TODOs);
                    validIndex = true;
                }
            } while (!validIndex);
        }

    }

}

