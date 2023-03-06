namespace DefaultNamespace;

public class diceRolls
{
    private Random roll = new Random();
    public static int d4()
    {
        int diceRoll = roll.Next(1, 4);
        return diceRoll;
    }
    
    public static int d6()
    {
        int diceRoll = roll.Next(1, 6);
        return diceRoll;
    }
    
    public static int d8()
    {
        int diceRoll = roll.Next(1, 8);
        return diceRoll;
    }
    
    public static int d10()
    {
        int diceRoll = roll.Next(1, 10);
        return diceRoll;
    }
    
    public static int d12()
    {
        int diceRoll = roll.Next(1, 12);
        return diceRoll;
    }
    
    public static int d20()
    {
        int diceRoll = roll.Next(1, 20);
        return diceRoll;
    }
    
    public static int d100()
    {
        int diceRoll = roll.Next(1, 100);
        return diceRoll;
    }
}