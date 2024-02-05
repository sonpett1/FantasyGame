namespace FantasyGame.Weapon;

public class Weapon
{
    // FIELDS
    public string Description { get; set; } = "fists";
    public string AttackMessage { get; set; } = "punch";
    public string DamageType { get; set; } = "Physical";
    
    
    // METHODS
    public override string ToString()
    {
        return "weapon";
    }
}