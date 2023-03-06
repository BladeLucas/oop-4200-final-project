namespace DefaultNamespace;

public class light_armor
{
    //Variable Declarations
    public int armor_id;
    public string armor_name;
    public int armor_class;

    private const string ARMOR_TYPE = "light";
    
    //Constructs the proper light armor for the class dependant on the parameters passed to the constructor
    public Light_Armor(int armor_id, string armor_name, string armor_type, int armor_class) {
        //Temp variable until Dexterity Stat is implemented
        int dex = 11;
        int dex_modifier = 0;

        //Won't let fighters use light armor
        if(player_class = "fighter") {
            Console.WriteLine("Fighters cannot wear Light Armor");
        } else {
            armor_id = 1;
            armor_type = ARMOR_TYPE;
            //Assigns the proper stats to the light armor depending on the class
            switch(player_class){
                case "cleric":
                    armor_name = "Robes";
                    armor_class = 11 + dex_modifier;
                    break;
                case "wizard":
                    armor_name = "Robes";
                    armor_class = 11 + dex_modifier;
                    break;
                case "ranger":
                    armor_name = "Studded Leather Armor";
                    armor_class = 12 + dex_modifier
                    break
                case "monk":
                    armor_name = "Leather Armor";
                    armor_class = 11 + dex_modifier
                    break;
            }
        }
    }
}