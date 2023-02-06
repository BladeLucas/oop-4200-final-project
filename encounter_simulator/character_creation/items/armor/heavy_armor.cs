namespace DefaultNamespace;

public class heavy_armor
{
    //Variable Declarations
    public int armor_id;
    public string armor_name;
    public int armor_class;

    private const string ARMOR_TYPE = "heavy";

    //Creates a Heavy Armor item using the parameters passed to the constructor
    public Heavy_Armor(int armor_id, string armor_name, string armor_type, int armor_class) {
        if(player_class != "fighter") {
            Console.WriteLine("Only a Fighter can use Heavy armor");
        } else {
            //Temp Variable until Strength stat is implemented
            int str = 15;
            //Game Mechanic: Player needs to have a strength of 15 or higher to use Heavy Armor
            if(str < 15) {
                Console.WriteLine("You must have a Strength stat of at least 15 to use Heavy Armor");
            } else {
                //Temp variables until Dexterity Stat is implemented
                int dex = 11;
                dex_modifier = 0;

                armor_id = 3;
                armor_type = ARMOR_TYPE;
                armor_name = "Plate Armor";
                armor_class = 18
            }
        }
    }
}