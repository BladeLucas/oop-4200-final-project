namespace DefaultNamespace;
using static DefaultNamespace.AllMethods;

public class staff
{
    //Variable declaration
    public int weapon_id;
    public string weapon_name;
    public string attack_1;
    public string attack_2;

    //Constructs a staff appropriate to the parameters passed to the constructor. Player class dependant
    public Staff(int weapon_id, string weapon_name, string player_class, string attack_1) {
        if(player_class = "wizard" || player_class = "monk") {
            switch (player_class) {
                case "wizard":
                    weapon_id = 4;
                    weapon_name = "Staff";
                    attack_1 = "Smack";
                    break;
                case "monk":
                    weapon_id = 5;
                    weapon_name = "Quarter Staff";
                    attack_1 = "Smack";
            }
        } else {
            Console.WriteLine("Only a Wizard or Monk can use a Staff.");
        }
    }

    //Method for the smack attack, to be used by another class
    public static void Smack(string enemy_name, int weapon_id, string weapon_name) {
        int ac, damage;
        int roll = d20();

        if(roll < 20) {
            Console.WriteLine(enemy_name + " blocked your Smack!");
        } else {
            //Deals different damage depending if its a Staff or Quarter Staff
            switch (weapon_id) {
                case 4:
                    damage = d4();
                    break;
                case 5:
                    damage = d6();
                    break;
            }
            Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " by Smacking him with your " + weapon_name);
        }
    }
}