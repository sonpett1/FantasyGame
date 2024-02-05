namespace FantasyGame.Character;

public class Wizard : Character
{
    public Wizard(string name) : base(name)
    {
        Description = "The pumper mage";
    }
    
    public override void Attack()
    {
            Console.WriteLine($"{Description} casts at the target with {Currentwep.Description}! {Currentwep.AttackMessage}");
    }
}