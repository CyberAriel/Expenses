public abstract class Count
{
    protected string name;
    protected int cash;
    protected string path = @"count.txt";
    protected int i = 0 ;
    protected int earnings = 0;
    protected int expenses = 0;
    protected int savings = 0;





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
    public virtual void ReadText()
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
public class Life : Count
{

    public Life(string name = "Empty", int cash = 0, string path="life.txt")
    {
        this.cash = cash;
        this.name = name;
        this.path = path;


    }

    public void Text()

    {
        WriteText();
        ReadText();
    }


}
public class Large : Count
{
 
}
public class Pleasures : Count
{
    
}
public class Education : Count
{

}
public class Freedom : Count
{

}
public class Charity : Count
{
   
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


