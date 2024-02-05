namespace FantasyGame.Npc;

public class Goblin : Npc
{
    public Goblin()
    {
        Health = 200;
        Weakness = "Magic";
    }
    
    public override string ToString()
    {
        return "globin";
    }
}