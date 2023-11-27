namespace Interview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Job Interview Console Application");


            try
            {
                // Get candidate information
                Candidate candidate = CandidateInformationService.GetCandidateInformation();

                // Run the interview process
                InterviewProcess.RunInterview(candidate);
            }
            catch (Exception ex)
            {
                // Handle unexpected exceptions
                ApplicationExceptionHandler.HandleException(ex);
                throw;
            }
        }
    }
}