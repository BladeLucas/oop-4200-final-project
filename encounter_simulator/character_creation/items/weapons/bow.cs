namespace DefaultNamespace;

public class bow
{
    //Variable declarations
    public int weapon_id;
    public string weapon_name;
    public string attack_1;
    public string range;

    //Constructs the proper Bow item based on the parameters passed to the constructor
    public Bow(int weapon_id, string weapon_name, string player_class, string attack_1, int range) {
        if(player_class != "ranger") {
            Console.WriteLine("Only a Ranger can use a bow.");
        } else {
            //Temp variable until weapon selection drop down is complete
            string weapon_selection = "Short Sword";

            //Based off weapon selection on the character creation page, create the appropriate Bow
            switch(weapon_selection) {
                case 1:
                    weapon_id = 9;
                    weapon_name = "Short Bow";
                    attack_1 = "Shoot";
                    range = 2;
                    break;
                case 2:
                    weapon_id = 10;
                    weapon_name = "Long Bow";
                    attack_1 = "Shoot";
                    range = 4;
                    break;
            }
        }
    }

    //Write the logic for the Bow when the grid is complete, that way we can figure out how to do ranged attacks
}