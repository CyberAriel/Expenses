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

static void Read(Count c)
{
    c.ReadText();
    Console.WriteLine("Press the key to return to the menu");
    Console.ReadKey();
}
static void Write(Count c)
{
    string s;
    do
    {
        c.WriteText();
        Console.WriteLine("Do you want to add another expense (y/n)");
        s = Console.ReadLine();
    } while (s.Equals("y"));
    Console.WriteLine("Do you want to see your expenses (y/n)");
    s = Console.ReadLine();
    if (s.Equals("y"))
    {
        c.ReadText();
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
                    Life life = new Life();
                    count = life;
                    Write(count);

                 

                    break;

                case 2:
                    Large large = new Large();
                    count = large;
                    Write(count);

                    break;

                case 3:
                    Pleasures pleasures = new Pleasures();
                    count = pleasures;
                    Write(count);

                    break;
                case 4:
                    Education education = new Education();
                    count = education;
                    Write(count);

                    break;
                case 5:
                    Freedom freedom = new Freedom();
                    count = freedom;
                    Write(count);

                    break;
                case 6:
                    Charity charity = new Charity();
                    count = charity;
                    Write(count);

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
                    count = life;
                    Read(count);

                  
                    break;

                case 2:
                    Large large = new Large();
                    count = large;
                    Read(count);
                 
                    break;

                case 3:
                    Pleasures pleasures = new Pleasures();
                    count = pleasures;
                    Read(count);
                  
                    break;
                case 4:
                    Education education = new Education();
                    count = education;
                    Read(count);
                  
                    break;
                case 5:
                    Freedom freedom = new Freedom();
                    count = freedom;
                    Read(count);
                 
                    break;
                case 6:
                    Charity charity = new Charity();
                    count = charity;
                    Read(count);
                 
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
    GC.Collect();
} while (action != 0);














