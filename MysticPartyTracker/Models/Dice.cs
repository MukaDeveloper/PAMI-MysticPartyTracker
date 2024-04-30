namespace MysticPartyTracker.Models
{
    public class Dice
    {
        public int Side { get; set; }

        public Dice(int side)
        {
            Side = side;
        }

        public int Roll()
        {
            return new Random().Next(Side) + 1;
        }
    }
}
