using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal class InterviewProcess
    {
        // Simulates the interview process and provides feedback based on candidate information
        public static void RunInterview(Candidate candidate)
        {
            Console.WriteLine($"Welcome, {candidate.Name}, to the interview process!");

            // Simulate the interview process
            Console.WriteLine("\nInterview Questions:");

            // ... (rest of the interview process)

            // Provide feedback based on candidate information
            Console.WriteLine("\nInterview Feedback:");

            switch (candidate.Name)
            {
                case "Kieran":
                    Console.WriteLine($"Hi {candidate.Name} !");
                    break;
                default:
                    Console.WriteLine($"{candidate.Name}? Erm, I think we have the wrong person. Sorry.");
                    break;
            }
        }
    }
}
