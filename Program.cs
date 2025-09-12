// See https://aka.ms/new-console-template for more information



public class CowsAndBulls
{
    public static void Main()
    {
        
    }

    public int GenerateNumber()
    {
        Random random = new Random();
        int number = random.Next(1234, 9877);
        return number;
    }

    public bool Check(int toCheck)
    {
        bool check = true;
        string numberString = toCheck.ToString();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                
            }
        }
        return check;
    }
    
}