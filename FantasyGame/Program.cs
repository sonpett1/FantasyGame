using FantasyGame.Character;
using FantasyGame.Npc;
using FantasyGame.Weapon;

class Program
{
    static void Main(string[] args)
    {
        // Making a fighter with sword
        Character sondre = new Fighter("Sondre");
        Weapon sword1 = new Sword();
        sondre.Currentwep = sword1;
        
        sondre.Attack();
        Console.WriteLine(" ");
        
        // Using attack() on random character
        Console.WriteLine("Attacks with random classes and weapons:\n");
        CreateCharacter("Heine")[0].Attack();
        
        // Saving a random char
        List<Character> rndChar = CreateCharacter("Loffen");
        Console.WriteLine(rndChar[0].Name);
        rndChar[0].Attack();

        // Spawning some NPCs
        Npc goblin1 = new Goblin();
        Npc darkMage1 = new DarkMage();
        
        // Performing attack() on NPC
        sondre.Attack(darkMage1);
        Console.WriteLine($"{darkMage1} has {darkMage1.Health} health remaining");
    }
    
    // Method that returns a list with a random character wielding a random weapon
    private static List<Character> CreateCharacter(string name)
    {
        Random rnd = new Random();
        
        // Creating random character
        List<Character> charList = new List<Character>();
        string[] characterArr = {"wizard", "rogue", "fighter"};
        int character = rnd.Next(0, characterArr.Length);
        
        switch (character)
        {
            case 0:
            {
                charList.Add(new Wizard(name));
            }
                break;
            case 1:
            {
                charList.Add(new Rogue(name));
            }
                break;
            case 2:
            {
                charList.Add(new Fighter(name));
            }
                break;
        }
        
        // Creating random weapon
        List<Weapon> weaponList = new List<Weapon>();
        string[] weaponArr = { "bow", "dagger", "staff", "sword", "wand" };
        int weapon = rnd.Next(0, weaponArr.Length);

        switch (weapon)
        {
            case 0:
            {
                weaponList.Add(new Bow());
            }
                break;
            
            case 1:
            {
                weaponList.Add(new Dagger());
            }
                break;
            
            case 2:
            {
                weaponList.Add(new Staff());
            }
                break;
            
            case 3:
            {
                weaponList.Add(new Sword());
            }
                break;
            
            case 4:
            {
                weaponList.Add(new Wand());
            }
                break;
        }

        charList[0].Currentwep = weaponList[0];
        return charList;
    }
}

