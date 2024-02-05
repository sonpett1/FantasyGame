namespace FantasyGame.Npc;
// Class for Character() to do some attacks on (will not attack back)
// Maybe try some magic resist / armor calculations
// Try to add resistance to types of weapons aswell
public class Npc
{
    // FIELDS
    public int Health { get; set; } = 100;
    public int Armor { get; set; } = 0;
    public int MagicResist { get; set; } = 0;
    public string Weakness { get; set; }
    
    // METHODS
    public override string ToString()
    {
        return "npc";
    }
}