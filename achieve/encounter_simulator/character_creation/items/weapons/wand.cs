namespace DefaultNamespace;
using static DefaultNamespace.AllMethods;

public class wand
{
    //Variable declarations
    public int weapon_id;
    public string weapon_name;
    public string attack_1;

    //Creates a Wand with the parameters passed to the constructor
    public Wand(int weapon_id, string weapon_name, string player_class, string attack_1) {
        if(player_class != "wizard") {
            Console.WriteLine("Only a wizard can use a wand");
        } else {
            weapon_id = 6;
            weapon_name = "Wand"
            //Setting attack to null as a wizard will use spells for attacks rather than a weapon
            attack_1 = null;
        }
    }
}