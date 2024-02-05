namespace FantasyGame.Character;

public class Rogue : Character
{
    
    public Rogue(string name) : base(name)
    {
        Description = "A sneaky assassin";
    }
    
    public override void Attack()
    {
        Console.WriteLine($"{Description} stabs at target with {Currentwep.Description}! {Currentwep.AttackMessage}");
    }
}