using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal class ApplicationExceptionHandler
    {
        // Handles unexpected exceptions by displaying a message and logging details
        public static void HandleException(Exception ex)
        {
            Console.WriteLine("An unexpected error occurred. Please contact support.");
            // Log the exception details for further investigation
        }
    }
}
