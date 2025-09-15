namespace CowsAndBulls;

public class CowsAndBullsGame
{
    private readonly Random _random;

    public CowsAndBullsGame()
    {
        _random = new Random();
    }

    public int GenerateNumber()
    {
        return _random.Next(1234, 9877);
    }

    public bool Check(int toCheck)
    {
        bool check = true;


        return check;
    }

}