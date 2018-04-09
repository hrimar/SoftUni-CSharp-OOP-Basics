using System;
using System.Collections.Generic;
using System.Linq;

public class Potato
{
    static void Main() // 100/100 но трябва още да го оправя
    {
        long bagCapacity = long.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var bag = new Dictionary<string, Dictionary<string, long>>();
        long gold = 0;
        long gem = 0;
        long cash = 0;

        for (int i = 0; i < input.Length; i += 2)
        {
            string name = input[i];
            long count = long.Parse(input[i + 1]);

            string current = string.Empty;

            if (name.Length == 3)
            {
                current = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                current = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                current = "Gold";
            }

            if (current == "")
            {
                continue;
            }
            else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
            {
                continue;
            }

            switch (current)
            {
                case "Gem":
                    if (!bag.ContainsKey(current))
                    {
                        if (bag.ContainsKey("Gold"))
                        {
                            if (count > bag["Gold"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[current].Values.Sum() + count > bag["Gold"].Values.Sum())
                    {
                        continue;
                    }
                    break;
                case "Cash":
                    if (!bag.ContainsKey(current))
                    {
                        if (bag.ContainsKey("Gem"))
                        {
                            if (count > bag["Gem"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[current].Values.Sum() + count > bag["Gem"].Values.Sum())
                    {
                        continue;
                    }
                    break;
            }

            if (!bag.ContainsKey(current))
            {
                bag[current] = new Dictionary<string, long>();
            }

            if (!bag[current].ContainsKey(name))
            {
                bag[current][name] = 0;
            }

            bag[current][name] += count;
            if (current == "Gold")
            {
                gold += count;
            }
            else if (current == "Gem")
            {
                gem += count;
            }
            else if (current == "Cash")
            {
                cash += count;
            }
        }

        PrintResult(bag);
    }

    private static void PrintResult(Dictionary<string, Dictionary<string, long>> bag)
    {
        foreach (var x in bag)
        {
            Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
            foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
            {
                Console.WriteLine($"##{item2.Key} - {item2.Value}");
            }
        }
    }
}
