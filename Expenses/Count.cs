public abstract class Count
{
    protected string name;
    protected int cash;
    protected string path;
    protected int variable;
    protected int display=0;
    protected int earnings;
    protected int expenses;
    protected int expensestotal = 0;

    public virtual void WriteText()
    {

        StreamWriter sw;

        if (!File.Exists(path))
        {
            sw = File.CreateText(path);
        }
        else
        {
            sw = new StreamWriter(path, true);
        }
        sw.WriteLine(name +" "+ cash);
        sw.Close();

        
    }

    public virtual void ReadText(ref int variable, int display)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Data cannot be read or data does not exist");
        }
        else
        {
            StreamReader sr = File.OpenText(path);
            string s = " ";
            while ((s = sr.ReadLine()) != null)
            {
                if (display!=0)
                {
                    Console.WriteLine(s);
                }
                
                string[] subs = s.Split(' ', '.');
                int j = subs.Length;
                variable = variable + Int32.Parse(subs[j - 1]);

            }
            sr.Close();
        }
    }
}

public class Earnings : Count
{
    
   
    public Earnings(string name = "Empty", int cash = 0, string path="earnings.txt", int earnings=0)
    {
        this.cash = cash;
        this.name = name;
        this.path = path;
        this.earnings = earnings;


    }

    public void AddEarnigns()
    {
        Console.WriteLine("Enter your monthly earnings");
        cash = Int32.Parse(Console.ReadLine());
        WriteText();
    }

    public void ShowEarnings()
    {
        earnings = 0;
        display = 1;
        ReadText(ref earnings, display);
        Console.WriteLine("You earn in last month: " + earnings);
    }
   
    public void Show()
    {
        earnings = 0;
        ReadText(ref earnings, display);
        Console.WriteLine("You earn total: " + earnings);
    }
}
public class Expenses : Count
{
    

    public Expenses(string path = "expenses.txt", string name = "Empty", int cash = 0, int expenses=0)
    {
        this.cash = cash;
        this.name = name;
        this.path = path;
        this.expenses = expenses;
    }

    public void AddExpenses()
    {
    Console.WriteLine("Enter the name of the product / service.");
        name = Console.ReadLine();
        Console.WriteLine("Enter the cost of the product / service.");
        cash = Int32.Parse(Console.ReadLine());
        WriteText();
    }

    public void ShowExpenses()
    {
        display = 1;
        ReadText(ref expenses, display);
        Console.WriteLine("You spent in total: " + expenses);
    }
    void Expensestotal(string path)
    {
        expenses = 0;
        this.path = path;
        ReadText(ref expenses, display);
        expensestotal = expensestotal + expenses;

       // Console.WriteLine("You expenses "+path+": " + expenses);
        
    }

    public void Show()
    {

        Expensestotal("life.txt");
        Expensestotal("large.txt");
        Expensestotal("pleasures.txt");
        Expensestotal("education.txt");
        Expensestotal("freedom.txt");
        Expensestotal("charity.txt");

        
        Console.WriteLine("You expenses total: " + expensestotal);
    }

}

public class Savings : Count
{
    protected int savings = 0;

    public void Show()
    {


        savings = earnings - expensestotal;
        Console.WriteLine("Your Saving: " + savings);
    }
}


