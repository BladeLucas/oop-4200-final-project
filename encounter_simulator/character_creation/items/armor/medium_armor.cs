namespace DefaultNamespace;

public class medium_armor
{
    //Variable Declarations
    public int armor_id;
    public string armor_name;
    public int armor_class;

    private const string ARMOR_TYPE = "medium";

    //Creates a Medium Armor Item dependant on the parameters passed to the constructor
    public Medium_Armor(int armor_id, string armor_name, string armor_type, int armor_class) {
        if(player_class != fighter) {
            Console.WriteLine("Only Fighters can use Medium armor.");
        } else {
            //Temp variables until Dexterity stat is implemented
            int dex = 11;
            dex_modifier = 0; 

            armor_id = 2;
            armor_type = ARMOR_TYPE;
            armor_name = "Chain Mail";
            armor_class = 13 + dex_modifier;
        }
    }
}