using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the restocking tool.");

        int sodaStock = 100;
        int sodasSold;

        Console.Write("How many Sodas have been sold today? 100 are in stock ");
        sodasSold = Convert.ToInt32(Console.ReadLine());

        sodaStock -= sodasSold;

        if (sodaStock < 40)
        {
            Console.WriteLine("Will need a restock. Only " + sodaStock + " units remaining.");
        }
        else
        {
            Console.WriteLine("There are " + sodaStock + " units of soda remaining.");
        }

        int chipStock = 40;
        int chipsSold;

        Console.Write("How many Chips have been sold today? 40 are in stock.");
        chipsSold = Convert.ToInt32(Console.ReadLine());

        chipStock -= chipsSold;

        if (chipStock < 20)
        {
            Console.WriteLine("Will need a restock. Only " + chipStock + " units remaining.");
        }
        else
        {
            Console.WriteLine("There are " + chipStock + " units remaining.");
        }


        int candyStock = 60;
        int candiesSold;

        Console.Write("How many Candies have been sold today? 60 are in stock.");
        candiesSold = Convert.ToInt32(Console.ReadLine());

        candyStock -= candiesSold;

        if (candyStock < 40)
        {
            Console.WriteLine("Will need a restock. Only " + candyStock + " units remaining.");
        }
        else
        {
            Console.WriteLine("There are " + candyStock + " units of candy remaining");
        }

        Console.WriteLine("Thank you for filling out the values. Please restock the following items:");

        if (sodaStock < 40)
        {
            Console.WriteLine("Soda: " + (40 - sodaStock) + " units.");
        }

        if (chipStock < 20)
        {
            Console.WriteLine("Chips: " + (20 - chipStock) + " units.");
        }

        if (candyStock < 40)
        {
            Console.WriteLine("Candy: " + (40 - candyStock) + " units.");
        }
    }
}