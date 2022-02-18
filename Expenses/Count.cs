
public abstract class Count
{
    protected string name;
    protected int cash;
    protected string path;
    //protected int i = 0 ;
    protected int earnings = 0;
    protected int expenses = 0;
    protected int savings = 0;





    public virtual void WriteText()
    {
        Console.WriteLine("Enter the name of the product / service.");
        name = Console.ReadLine();
        Console.WriteLine("Enter the cost of the product / service.");
        cash = Int32.Parse(Console.ReadLine());
        StreamWriter sw;

        if (!File.Exists(path))
        {
            sw = File.CreateText(path);
            sw.WriteLine(path);
        }
        else
        {
            sw = new StreamWriter(path, true);
        }
       
        sw.WriteLine(name +" "+ cash);
        sw.Close();

        
    }
    public virtual void ReadText()
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("File does not exist");
        }
        else
        {
            StreamReader sr = File.OpenText(path);
            string s = " ";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);

            }
            sr.Close();
        }
    }

    
}
public class Life : Count
{

    public Life(string name = "Empty", int cash = 0, string path="life.txt")
    {
        this.cash = cash;
        this.name = name;
        this.path = path;


    }


}
public class Large : Count
{
    public Large(string name = "Empty", int cash = 0, string path = "large.txt")
    {
        this.cash = cash;
        this.name = name;
        this.path = path;


    }
}
public class Pleasures : Count
{
    public Pleasures(string name = "Empty", int cash = 0, string path = "pleasures.txt")
    {
        this.cash = cash;
        this.name = name;
        this.path = path;


    }
}
public class Education : Count
{
    public Education(string name = "Empty", int cash = 0, string path = "education.txt")
    {
        this.cash = cash;
        this.name = name;
        this.path = path;


    }
}
public class Freedom : Count
{
    public Freedom(string name = "Empty", int cash = 0, string path = "freedom.txt")
    {
        this.cash = cash;
        this.name = name;
        this.path = path;


    }
}
public class Charity : Count
{
    public Charity(string name = "Empty", int cash = 0, string path = "charity.txt")
    {
        this.cash = cash;
        this.name = name;
        this.path = path;


    }
}
public class Earnings : Count
{
    public void Show()
    {
        Console.WriteLine("Your Ernings: " + earnings);
    }
}
public class Expenses : Count
{
    public void Show()
    {
        Console.WriteLine("Your Expenses: " + expenses);
    }
}
public class Savings : Count
{
    public void Show()
    {
        Console.WriteLine("Your Saving: " + savings);
    }
}


