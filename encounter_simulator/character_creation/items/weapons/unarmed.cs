namespace DefaultNamespace;
using static DefaultNamespace.AllMethods;

public class unarmed
{
    //Variable declarations
    public int weapon_id;
    public string weapon_name;
    public string attack_1;
    public string attack_2;

    //Constructor for an unarmed attack, using the properties passed in the parameters
    public Unarmed(int weapon_id, string weapon_name, string player_class, string attack_1, string attack_2) {
        if(player_class != "monk") {
            Console.WriteLine("Only a monk can use Unarmed strikes. All others must have a weapon.");
        } else {
            weapon_id = 7;
            weapon_name = "Unarmed";
            attack_1 = "Punch";
            attack_2 = "Flurry";
        }
    }

    //Method for the Punch attack, to be used by another class
    public static void Punch(string enemy_name) {
        int ac, damage;
        int roll = d20();

        if(roll < ac) {
            Console.WriteLine(enemy_name + " blocked your Punch!");
        } else {
            damage = d6();
            Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " with Punch!");
        }
    }

    //Method for the Flurry attack, to be used by another class
    public static void Flurry(string enemy_name) {
        int ac, damage;
        int roll = d20();

        if(roll < ac) {
            Console.WriteLine(enemy_name + " blocked your Flurry");
        } else {
            //Deals 3d4 damage
            damage = d4() + d4() + d4();
            Console.WriteLine("You dealt " + damage + " damage to " + enemy_name + " with your Flurry!");
        }
    }
}