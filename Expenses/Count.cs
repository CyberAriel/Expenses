public abstract class Count
{
    protected string name;
    protected int cash;
    protected string path;
    protected int variable;
   
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

    public virtual void ReadText(ref int variable)
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
                Console.WriteLine(s);
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
    protected int earnings;

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
        ReadText(ref earnings);
        Console.WriteLine("You earn in last month: " + earnings);
    }
   
    public void Show()
    {
        if (!File.Exists(path))
        {
            earnings = 0;
        }
        else
        {
            StreamReader sr = File.OpenText(path);
            string s = " ";
            while ((s = sr.ReadLine()) != null)
            {
                //Console.WriteLine(s);
                string[] subs = s.Split(' ', '.');
                int j = subs.Length;
                earnings = earnings + Int32.Parse(subs[j - 1]);

            }
            Console.WriteLine("Your Ernings: " + earnings);
            sr.Close();
        }
    
    }
}
public class Expenses : Count
{
    protected int expenses;

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
        ReadText(ref expenses);
        
        Console.WriteLine("You spent in total: " + expenses);
    }

    public void Show()
    {
        Console.WriteLine("Your Expenses: " + expenses);
    }
}

public class Savings : Count
{
    protected int savings = 0;

    public void Show()
    {
        Console.WriteLine("Your Saving: " + savings);
    }
}


