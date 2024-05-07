namespace MysticPartyTracker.Models
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Race { get; set; } = string.Empty;
        public int Level { get; set; }

        public Character(string name, string charClass, string race, int level)
        {
            Name = name;
            Class = charClass;
            Race = race;
            Level = level;
        }

        public void newCharacter()
        {
            return;
        }
    }
}
