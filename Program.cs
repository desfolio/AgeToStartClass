using System;

namespace AgeToStartClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            var isValidAge = int.TryParse(Console.ReadLine(), out int age);

            const int legalAge = 21;

            if (isValidAge)
            {
                if ((firstName.ToLower() == "tim" || firstName.ToLower() == "sue")
                        && age >= legalAge)
                {
                    Console.WriteLine($"Hello Professor {firstName}. Welcome to the class.");
                }
                else if ((firstName.ToLower() == "tim" || firstName.ToLower() == "sue")
                        && age < legalAge)
                {
                    Console.WriteLine($"Hello Professor {firstName}. We recommend you wait " +
                        $"{legalAge - age} years to start this class.");
                }
                else if (age < legalAge)
                {
                    Console.WriteLine($"Hello {firstName}. We recommend you wait " +
                        $"{legalAge - age} years to start this class.");
                }
                else
                {
                    Console.WriteLine($"Hello {firstName}. Welcome to the class.");
                }
            }
            else
            {
                Console.WriteLine("Did not enter a valid age!");
            }
        }
    }
}
