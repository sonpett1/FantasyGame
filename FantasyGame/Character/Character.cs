namespace FantasyGame.Character;
using Npc;
using Weapon;

public class Character
{
    // FIELDS
    public Weapon Currentwep { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = "Civilian";

    // CONSTRUCTOR
    public Character(string name)
    {
        this.Name = name;
        Currentwep = new Weapon();
    }
    
    // METHODS
    public virtual void Attack()
    {
        Console.WriteLine($"{Currentwep.AttackMessage}");
    }
    
    // Doing 20 damage if enemy NPC is weak to equipped weapon, 10 damage if not. 
    public void Attack(Npc npc)
    {
        int damageResult = (Currentwep.DamageType == npc.Weakness) ? npc.Health -= 20 : npc.Health -= 10;
        
    }

    public override string ToString()
    {
        return "character";
    }
}