namespace DefaultNamespace;
using static DefaultNamespace.AllMethods;

public class dagger
{
    //Variable declarations
    public int weapon_id;
    public string weapon_name;
    public string attack_1;

    //Constructs a Dagger item with the parameters passed to the constructor
    public Dagger(int weapon_id, string weapon_name, string player_class, string attack_1) {
        if(player_class != "ranger") {
            Console.WriteLine("Only a ranger can use daggers");
        } else {
            weapon_id = 8;
            weapon_name = "Dagger";
            attack_1 = "Stab";
        }
    }

    //Method for the Stab attack, to be used by another class
    public static void Stab(string enemy_name) {
        int ac, damage;
        int roll = d20();

        if(roll < ac) {
            Console.WriteLine(enemy_name + " blocked your Stab!");
        } else {
            damage = d4();
            Console.WriteLine("You dealt " + damage + " to the " + enemy_name + " with Stab!")
        }
    }

}