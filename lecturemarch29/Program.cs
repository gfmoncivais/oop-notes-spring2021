using System;

namespace lecturemarch29 //called Baseball Players 
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.txt";
            PlayerFile playerFile = new PlayerFile(fileName);

            Player[] myPlayers = playerFile.ReadPlayer();

            PlayerReport playerReport = new PlayerReport(myPlayers);
            //playerReport.PrintAllPlayers();

            Console.WriteLine("\n");
            playerReport.Stats();

            playerReport.CombinationReport();

            Console.WriteLine(0);
            Player
        }
    }
}
