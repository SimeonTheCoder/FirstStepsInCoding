using System;

namespace HelloSoftUni
{
    class Program
    {
        static int hoursPerProject = 3;

        static void Main(string[] args) {
            string name = Console.ReadLine();

            int projects = int.Parse(Console.ReadLine());

            int time = projects * hoursPerProject;

            Console.WriteLine(String.Format("The architect {0} will need {1} hours to complete {2} project/s.", name, time, projects));
        }
    }
}