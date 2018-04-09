using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program    // 100/100
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();
            
            string command = Console.ReadLine();
            while (command != "Output")
            {
                InputData(doctors, departments, command);

                command = Console.ReadLine();
            }

            string surchedResult;
            while ((surchedResult = Console.ReadLine()) != "End")
            {
                OutputData(doctors, departments, surchedResult);

            }
        }

        private static void OutputData(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string surchedResult)
        {
            string[] args = surchedResult.Split();

            if (args.Length == 1)
            {
                Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int staq))
            {
                Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
            }
        }

        private static void InputData(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string command)
        {
            string[] tokens = command.Split();
            var departament = tokens[0];
            var firstName = tokens[1];
            var LastName = tokens[2];
            var pacient = tokens[3];
            var fullName = firstName + LastName;

            if (!doctors.ContainsKey(firstName + LastName))
            {
                doctors[fullName] = new List<string>();
            }
            if (!departments.ContainsKey(departament))
            {
                departments[departament] = new List<List<string>>();
                for (int rooms = 0; rooms < 20; rooms++)
                {
                    departments[departament].Add(new List<string>());
                }
            }

            bool hasPlace = departments[departament].SelectMany(x => x).Count() < 60;
            if (hasPlace)
            {
                int room = 0;
                doctors[fullName].Add(pacient);
                for (int st = 0; st < departments[departament].Count; st++)
                {
                    if (departments[departament][st].Count < 3)
                    {
                        room = st;
                        break;
                    }
                }
                departments[departament][room].Add(pacient);
            }
        }
    }
}
