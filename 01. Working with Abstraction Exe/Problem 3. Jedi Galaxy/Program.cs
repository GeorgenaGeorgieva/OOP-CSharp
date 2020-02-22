namespace JediGalaxy
{
    using System;
    using System.Linq;
     
    public class Program
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Galaxy galaxy = new Galaxy();
            Evil evil = new Evil();
            Player player = new Player();

            galaxy.CreateMatrix(dimensions);

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                ProcessingCoordinates(evil, player, command);
                galaxy.MoveEvilToTopLeftCorner(evil);
                galaxy.MovePlayerToTopRightCorner(player);

                command = Console.ReadLine();
            }

            Console.WriteLine(player.Score);
        }

        private static void ProcessingCoordinates(Evil evil, Player player, string command)
        {
            int[] playerStartCoordinates = command
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] evilStartCoordinates = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            evil.UpdateCoodrinates(evilStartCoordinates[0], evilStartCoordinates[1]);
            player.UpdateCoordinates(playerStartCoordinates[0], playerStartCoordinates[1]);
        }
    }
}
