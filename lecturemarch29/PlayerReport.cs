using System;
using System.IO;

namespace lecturemarch29
{
    public class PlayerReport
    {
        Player[] myPlayers;

        public PlayerReport()
        {

        }


        public PlayerReport(Player[] myPlayers)
        {
            this.myPlayers = myPlayers; 
        }

        public void PrintAllPlayers()
        {
            for(int i = 0; i < Player.GetCount(); i++)
            {
                Console.WriteLine(myPlayers[i].ToString());
            }
        }
        public void Stats()
        {
            //calculate the average
            //find min and max and then calculate the range
            double total = 0;
            double min = myPlayers[0].GetBattingAvg();
            double max = myPlayers[0].GetBattingAvg();

            for(int i = 0; i < Player.GetCount(); i++)
            {
                total += myPlayers[i].GetBattingAvg();

                if(myPlayers[i].GetBattingAvg() < min)
                {
                    min = myPlayers[i].GetBattingAvg();
                }
                if(myPlayers[i].GetBattingAvg() > max)
                {
                    max = myPlayers[i].GetBattingAvg();
                }
            }
            double average = total/Player.GetCount();
            double range = max - min; 

            Console.WriteLine($"The avg is {Math.Round(average, 3)} and the range is {Math.Round(range, 3)}");
        }

        public void CombinationReport()
        {
            //Comnination of two players with a mean batting avg of more than 0.35
            for( int i = 0; i < Player.GetCount()-1; i ++)
            {
                for(int j = i+1; j<Player.GetCount(); j++)
                {
                    if(myPlayers[i].GetBattingAvg() + myPlayers[j].GetBattingAvg() / 2 > 0.35); 
                    {
                        Console.WriteLine(myPlayers[i] + "\t\t" + myPlayers[j]); //with the .ToString or without, it'll run the same 
                    }
                }
            }
        }

        public void TeamAvg()
        {
            for (int i =1)
        }
    }
}
