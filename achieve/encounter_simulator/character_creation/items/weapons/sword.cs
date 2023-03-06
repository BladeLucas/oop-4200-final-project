namespace DefaultNamespace;
using static DefaultNamespace.AllMethods;
public class sword
{
    //Variable declarations
    public int weapon_id;
    public string weapon_name;
    public string attack_1;
    public string attack_2;

    //Create the sword corresponding to the variables the constructor is passed
    public Sword(int weapon_id, string weapon_name, string player_class, string attack_1, string attack_2)
    {
        //Checks the players class to make sure they can weild a sword
        if (player_class = fighter || player_class = cleric)
        {
            if (player_class = "fighter")
            {
                //Temp variable until weapon selection drop down is complete
                string weapon_selection = "Short Sword";

                //Assigns the proper variables for the players selection
                switch (weapon_selection)
                {
                    case one_handed_sword:
                        weapon_id = 1;
                        weapon_name = "Short Sword";
                        attack_1 = "Slash";
                        attack_2 = "Stab";
                        break;
                        
                    case two_handed_sword:
                        weapon_id = 2;
                        weapon_name = "Great Sword";
                        attack_1 = "Slash";
                        attack_2 = "Strong Attack";
                        break;
                }
            }

            //Assigns the proper variables for the players selection
            if (player_class = "cleric")
            {
                weapon_id = 1;
                weapon_name = "Short Sword";
            }
        }
        //Throws an error in the console if the player somehow chooses a sword for a class that cannot use it
        else
        {
            Console.WriteLine("Error, only a Fighter or Cleric can use a sword")
        }
    }

    //Method for the Slash attack, to be called by another class
    static void Slash(string enemy_name, int weapon_id)
    {
        //temp variables until armor class is implemented
        int ac;
        //Roll a d20 to determine if you hit or not
        int roll = d20();
        int damage;

        if (roll < ac)
        {
            Console.WriteLine(enemy_name + " blocked your slash!");
        }
        else
        {
            switch (weapon_id)
            {
                case 1:
                    damage = d8();
                    Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " with your Slash!")
                    break;
                case 2:
                    damage = d10();
                    Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " with your Slash!")
                    break;
            }
        }
    }

    //Method for the Stab attack, to be called by another class
    static void Stab(string enemy_name)
    {
        {
            //temp variables until armor class is implemented
            int ac;
            //Roll a d20 to determine if you hit or not
            int roll = d20();
            int damage;
            
            if (roll < ac)
            {
                Console.WriteLine(enemy_name + " blocked your Stab!");
            }
            else
            {
                damage = d8();
                Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " with your Stab!")
            }
        }
    }
    
    //Method for the Strong Attack, to be called by another class
    static void Strong_Attack(string enemy_name)
    {
        {
            //temp variables until armor class is implemented
            int ac;
            //Roll a d20 to determine if you hit or not
            int roll = d20();
            int damage;

            if (roll < ac)
            {
                Console.WriteLine(enemy_name + " blocked your Strong Attack!");
            }
            else
            {
                damage = d10();
                Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " with your Strong Attack!")
            }
        }
    }
}