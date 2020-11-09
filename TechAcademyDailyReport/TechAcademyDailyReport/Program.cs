using System;


namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("The Tech Academy" + Environment.NewLine + "Student Daily Report.");
            Console.ReadLine();

            Console.WriteLine("\n" + "What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("\n" + "What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("\n" + "What page number?");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("\n" + "Do you need help with anything? Please answer “true” or “false”.");
            string studyHelp = Console.ReadLine();

            Console.WriteLine("\n" + "Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("\n" + "Is there any other feedback you’d like to provide? Please be specific.");
            string courseFeedback = Console.ReadLine();

            Console.WriteLine("\n" + "How many hours did you study today?");
            string studyHours = Console.ReadLine();

            Console.WriteLine("\n" + "Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}