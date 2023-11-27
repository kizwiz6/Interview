using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal class CandidateInformationService
    {
        // Responsible for gathering candidate information from user input
        public static Candidate GetCandidateInformation()
        {
            Console.Write("Enter the candidate's name: ");
            string name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter the candidate's age: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out age) && age >= 0)
                {
                    break; // Exit the loop if the input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input for age. Please enter a valid non-negative integer.");
                }
            }

            Console.Write("Enter the candidate's location: ");
            string location = Console.ReadLine();

            return new Candidate(name, age, 0, location); // YearsOfExperience is set to 0 initially
        }
    }
}
