using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()  // 100/100 -  Виж я пак!
    {
        var solders = new List<ISoldier>(); // !! за кол-я да използваме най-абстр-я възможен тип!

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            // “Private <id> <firstName> <lastName> <salary>”
            string[] tokens = input.Split();
            string soldierType = tokens[0];
            int id = int.Parse(tokens[1]);
            string firstName = tokens[2];
            string lastName = tokens[3];
            decimal salary = decimal.Parse(tokens[4]);

            ISoldier soldier = null;    // !!!!

            try
            {
                switch (soldierType)
                {
                    case "Private":
                        soldier = new Private(id, firstName, lastName, salary);
                        break;
                    case "LeutenantGeneral":
                        var leutenant = new LeutenantGeneral(id, firstName, lastName, salary);

                        for (int i = 5; i < tokens.Length; i++)
                        {
                            int privateId = int.Parse(tokens[i]);
                            ISoldier @private = solders.First(p => p.Id == privateId);
                            leutenant.AddPrivate(@private);
                        }

                        soldier = leutenant; // !!!
                        break;
                    case "Engineer":
                        string engineerCorps = tokens[5];
                        var engineer = new Engineer(id, firstName, lastName, salary, engineerCorps);

                        for (int i = 6; i < tokens.Length; i++)
                        {
                            string partName = tokens[i];
                            int hoursWorked = int.Parse(tokens[++i]);   // !!!
                            try
                            {
                                IRepair repair = new Repair(partName, hoursWorked);
                                engineer.AddRepair(repair);
                            }
                            catch { }

                        }
                        soldier = engineer;
                        break;
                    case "Commando":
                        string commandoCorps = tokens[5];
                        var commando = new Commando(id, firstName, lastName, salary, commandoCorps);

                        for (int i = 6; i < tokens.Length; i++)
                        {
                            string codeName = tokens[i];
                            string missionState = tokens[++i];   // !!
                            try
                            {
                                IMission mission = new Mission(codeName, missionState);
                                commando.AddMission(mission);
                            }
                            catch { }

                        }
                        soldier = commando;
                        break;
                    case "Spy":
                        int codeNumber = (int)salary;
                        soldier = new Spy(id, firstName, lastName, codeNumber);
                        break;
                    default:
                        throw new ArgumentException("Ïnvalid soldier type!");
                }

                solders.Add(soldier);
            }
            catch (Exception )
            {
               // Console.WriteLine(e.Message);
            }
           
        }

        foreach (var s in solders)
        {
            //// var 2:
            //var soldierType = s.GetType();
            //var actualSoldier = Convert.ChangeType(s, soldierType); // от какъв тип - в какъв тип да се превърне!
            //Console.WriteLine(actualSoldier);

            // var 1:
            Console.WriteLine(s);
        }
    }
}

