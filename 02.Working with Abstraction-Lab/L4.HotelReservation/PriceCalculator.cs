using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

public class PriceCalculator
{

    private decimal pricePerNight;
    private int nights;
    private SeasonsMultiplier seasonMultiplier ;
    private Discounts discount;

    public PriceCalculator(string command)
    {
        var splitCommand = command.Split();
        pricePerNight = decimal.Parse(splitCommand[0]);
        nights = int.Parse(splitCommand[1]);

        // Парсване на Enum:
        seasonMultiplier = Enum.Parse<SeasonsMultiplier>(splitCommand[2]);

        discount = Discounts.None;
        if (splitCommand.Length > 3)
        {
            discount = Enum.Parse<Discounts>(splitCommand[3]);
        }
    }

    public string CalculatePrice()
    {
        //GetColor(Seasons.Autumn);
        var tempTotal = pricePerNight * nights * (int)seasonMultiplier;
        var discountPercentage = ((decimal)100 - (int) discount)/ 100;
        var totalPrice = tempTotal * discountPercentage;

        return totalPrice.ToString("F2");
    }

    public ConsoleColor GetColor(SeasonsMultiplier seasonsParameter)
    {
        switch (seasonsParameter)
        {
            case SeasonsMultiplier.Autumn:
                return ConsoleColor.Yellow;
            case SeasonsMultiplier.Spring:
                return ConsoleColor.Green;
            case SeasonsMultiplier.Winter:
                return ConsoleColor.White;
            case SeasonsMultiplier.Summer:
                return ConsoleColor.Blue;
            default:
                throw new InvalidEnumArgumentException();
        }
    }
}

