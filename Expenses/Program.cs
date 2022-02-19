using System.IO;
using System;
using System.Collections;

static void Menu()
{
    Console.WriteLine("Select section");
    Console.WriteLine("1: Life");
    Console.WriteLine("2: Large expenses");
    Console.WriteLine("3: Pleasures");
    Console.WriteLine("4: Education");
    Console.WriteLine("5: Freedoom");
    Console.WriteLine("6: Charity");
}

static void WriteExpenses(Expenses ex)
{
   
    string s;
    do
    {
        ex.AddExpenses();
        Console.WriteLine("Do you want to add another expense (y/n)");
        s = Console.ReadLine();
    } while (s.Equals("y"));
    Console.WriteLine("Do you want to see your expenses (y/n)");
    s = Console.ReadLine();
    if (s.Equals("y"))
    {
        ex.ShowExpenses();
        Console.WriteLine("Press the key to return to the menu");
        Console.ReadKey();
    }

}

static void ReadExpesnes(Expenses ex)
{
    ex.ShowExpenses();
    Console.WriteLine("Press the key to return to the menu");
    Console.ReadKey();
}

static void Earn (Earnings ea)
{
    string s;
    Console.WriteLine("Do you want to add your earnings (y/n)");
    s = Console.ReadLine();
    if (s.Equals("y"))
    {
        do
        {
            ea.AddEarnigns();
            Console.WriteLine("Do you want to add another earnings (y/n)");
            s = Console.ReadLine();
        } while (s.Equals("y"));
    }
    
    Console.WriteLine("Do you want to see your earnings (y/n)");
    s = Console.ReadLine();
    if (s.Equals("y"))
    {
        ea.ShowEarnings();
        Console.WriteLine("Press the key to return to the menu");
        Console.ReadKey();
    }
    

}
Count count;
int action;

Console.WriteLine("Welcome in Expenses");
Console.WriteLine("Create by Patryk Pieczka");
Earnings earnings = new Earnings();
earnings.Show();
Expenses expenses = new Expenses();
expenses.Show();
Savings savings = new Savings();
savings.Show();


do
{
    Console.WriteLine("Select action");
    Console.WriteLine("1: Add a purchase");
    Console.WriteLine("2: Show a Purchase");
    Console.WriteLine("3: Determine your earnings");
    Console.WriteLine("4: Determine your expenses");
    Console.WriteLine("5: Determine your savings");
    Console.WriteLine("0: Exit");

    action = Int16.Parse(Console.ReadLine());
    
    switch (action)
    {
        case 1:
            Menu();
           
            action = Int16.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Expenses life = new Expenses("life.txt");
                    
                    WriteExpenses(life);

                    break;
                case 2:
                    Expenses large = new Expenses("large.txt");

                    WriteExpenses(large);

                    break;
                case 3:
                    Expenses pleasures = new Expenses("pleasures.txt");

                    WriteExpenses(pleasures);

                    break;
                case 4:
                    Expenses education = new Expenses("education.txt");

                    WriteExpenses(education);

                    break;
                case 5:
                    Expenses freedom = new Expenses("freedom.txt");

                    WriteExpenses(freedom);

                    break;
                case 6:
                    Expenses charity = new Expenses("charity.txt");

                    WriteExpenses(charity);

                    break;
                default:
                    Console.WriteLine("Wrong section");

                    break;
            }
            break;

        case 2:
            Menu();
            action = Int16.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Expenses life = new Expenses("life.txt");

                    ReadExpesnes(life);

                    break;
                case 2:
                    Expenses large = new Expenses("large.txt");

                    ReadExpesnes(large);
                 
                    break;
                case 3:
                    Expenses pleasures = new Expenses("pleasures.txt");

                    ReadExpesnes(pleasures);
                  
                    break;
                case 4:
                    Expenses education = new Expenses("education.txt");

                    ReadExpesnes(education);
                  
                    break;
                case 5:
                    Expenses freedom = new Expenses("freedom.txt");

                    ReadExpesnes(freedom);
                 
                    break;
                case 6:
                    Expenses charity = new Expenses("charity.txt");

                    ReadExpesnes(charity);
                 
                    break;
                default:
                    Console.WriteLine("Wrong section");

                    break;
            }
            break;

        case 3:
            Earn(earnings);
            break;
        case 4:

            break;
        case 5:

            break;
        case 0:

            break;

        default:
            Console.WriteLine("Wrong action");
            break;
    }
    GC.Collect();
} while (action != 0);














