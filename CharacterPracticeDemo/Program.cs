namespace CharacterPracticeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character("Christoffer", 100, 20, 5);
            Monster dragon = new Monster("Dragon", 100, 20, 5);

            bool won = hero.Fight(dragon);
            if (won)
            {
                Console.WriteLine("Victory!");
            } else
            {
                Console.WriteLine("You died :(");
            }
        }
    }
}