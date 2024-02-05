namespace FantasyGame.Npc;

public class DarkMage : Npc
{
    public DarkMage()
    {
        Health = 150;
        Weakness = "Physical";
    }
    
    public override string ToString()
    {
        return "darkmage";
    }
}