namespace FantasyGame.Character;

public class Fighter : Character
{
    
    public Fighter(string name) : base(name)
    {
        Description = "A fierce Fighter";
    }
    public override void Attack()
    {
        Console.WriteLine($"{Description} swings at the target with {Currentwep.Description}! {Currentwep.AttackMessage}");
    }
}