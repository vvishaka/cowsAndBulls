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