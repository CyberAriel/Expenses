using System.IO;




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

int action;
string s;
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
                    Life life = new Life();
                    do
                    {
                        life.WriteText();
                        Console.WriteLine("Do you want to add another expense (y/n)");
                        s = Console.ReadLine();
                    } while (s.Equals("y"));
                    Console.WriteLine("Do you want to see your expenses (y/n)");
                    s = Console.ReadLine();
                    if (s.Equals("y"))
                    {
                        life.ReadText();
                        Console.WriteLine("Press the key to return to the menu");
                        Console.ReadKey();
                    }


                    break;

                case 2:
                    Large large = new Large();
                    do
                    {
                        large.WriteText();
                        Console.WriteLine("Do you want to add another expense (y/n)");
                        s = Console.ReadLine();
                    } while (s.Equals("y"));
                    Console.WriteLine("Do you want to see your expenses (y/n)");
                    s = Console.ReadLine();
                    if (s.Equals("y"))
                    {
                        large.ReadText();
                        Console.WriteLine("Press the key to return to the menu");
                        Console.ReadKey();
                    }

                    break;

                case 3:
                    Pleasures pleasures = new Pleasures();
                    do
                    {
                        pleasures.WriteText();
                        Console.WriteLine("Do you want to add another expense (y/n)");
                        s = Console.ReadLine();
                    } while (s.Equals("y"));
                    Console.WriteLine("Do you want to see your expenses (y/n)");
                    s = Console.ReadLine();
                    if (s.Equals("y"))
                    {
                        pleasures.ReadText();
                        Console.WriteLine("Press the key to return to the menu");
                        Console.ReadKey();
                    }

                    break;
                case 4:
                    Education education = new Education();
                    do
                    {
                        education.WriteText();
                        Console.WriteLine("Do you want to add another expense (y/n)");
                        s = Console.ReadLine();
                    } while (s.Equals("y"));
                    Console.WriteLine("Do you want to see your expenses (y/n)");
                    s = Console.ReadLine();
                    if (s.Equals("y"))
                    {
                        education.ReadText();
                        Console.WriteLine("Press the key to return to the menu");
                        Console.ReadKey();
                    }

                    break;
                case 5:
                    Freedom freedom = new Freedom();
                    do
                    {
                        freedom.WriteText();
                        Console.WriteLine("Do you want to add another expense (y/n)");
                        s = Console.ReadLine();
                    } while (s.Equals("y"));
                    Console.WriteLine("Do you want to see your expenses (y/n)");
                    s = Console.ReadLine();
                    if (s.Equals("y"))
                    {
                        freedom.ReadText();
                        Console.WriteLine("Press the key to return to the menu");
                        Console.ReadKey();
                    }

                    break;
                case 6:
                    Charity charity = new Charity();
                    do
                    {
                        charity.WriteText();
                        Console.WriteLine("Do you want to add another expense (y/n)");
                        s = Console.ReadLine();
                    } while (s.Equals("y"));
                    Console.WriteLine("Do you want to see your expenses (y/n)");
                    s = Console.ReadLine();
                    if (s.Equals("y"))
                    {
                        charity.ReadText();
                        Console.WriteLine("Press the key to return to the menu");
                        Console.ReadKey();
                    }

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
                    Life life = new Life();
                  
                        life.ReadText();
                        Console.WriteLine("Press the key to return to the menu");
                    Console.ReadKey();
                    break;

                case 2:
                    Large large = new Large();
                   
                    large.ReadText();
                    Console.WriteLine("Press the key to return to the menu");
                    Console.ReadKey();
                    break;

                case 3:
                    Pleasures pleasures = new Pleasures();

                    pleasures.ReadText();
                    Console.WriteLine("Press the key to return to the menu");
                    Console.ReadKey();
                    break;
                case 4:
                    Education education = new Education();

                    education.ReadText();
                    Console.WriteLine("Press the key to return to the menu");
                    Console.ReadKey();
                    break;
                case 5:
                    Freedom freedom = new Freedom();

                    freedom.ReadText();
                    Console.WriteLine("Press the key to return to the menu");
                    Console.ReadKey();
                    break;
                case 6:
                    Charity charity = new Charity();

                    charity.ReadText();
                    Console.WriteLine("Press the key to return to the menu");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Wrong section");
                    break;
            }
            break;

        case 3:
           
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
} while (action != 0);







//life.WriteText();
//life.ReadText();




GC.Collect();


