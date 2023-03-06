namespace DefaultNamespace;
using static DefaultNamespace.AllMethods;

public class mace
{
    //Variable declarations
    public int weapon_id;
    public string weapon_name;
    public string attack_1;
    public string attack_2;

    //Creates a Mace item using the parameters passed to the constructor
    public Mace(int weapon_id, string weapon_name, string player_class, string attack_1, string attack_2){

        if(player_class != "fighter") {
            Console.WriteLine("Only a fighter can select a mace");
        } else {
            weapon_id = 3;
            weapon_name = "Mace";
            attack_1 = "Swing";
            attack_2 = "Strong Swing";
        }
    }

    //Method for the Swing attack, to be used by another class
    public static void Swing(string enemy_name, int weapon_id) {
        int ac, damage;
        int roll = d20();

        if(roll < ac) {
            Console.WriteLine(enemy_name + " blocked your Swing!");
        } else {
            damage = d6();
            Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " with your Swing!");
        }
    }

    //Method for the Strong Attack, to be used by another class
    public static void Strong_Attack() {
        int ac, damage;
        int roll = d20();

        if(roll < ac){
            Console.WriteLine(enemy_name + " blocked your attack!")
        } else {
            damage = d8();
            Console.WriteLine("You dealt " + damage + " damage to the " + enemy_name + " with your Strong Attack!");
        }
    }
}