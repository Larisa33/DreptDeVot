using static System.Net.Mime.MediaTypeNames;

namespace DreptDeVot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            int age = validAge("Please enter your age: ");


            if (age >= 18 )
            {
                Console.WriteLine("Congrats! You are eligible for voting.");
            } else
            {
                Console.WriteLine("Sorry, but you are not old enough to be eligible for voting!");
            }

            static int validAge(string eticheta)
            {
                bool validAge = false;

                while (!validAge)
                {
                    Console.Write(eticheta);
                    string text = Console.ReadLine();

                    validAge = int.TryParse(text, out int result);


                    if (validAge)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, the text does not represent a valid age. Please try again!");
                    }

                }

                return 0;

            }

        }

    }
}