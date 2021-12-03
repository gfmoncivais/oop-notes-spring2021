using System;


namespace lecturemarch29
{
    public class PlayerUtilities
    {
        Player[] myPlayers;

        public PlayerUtilities()
        {

        }

        public PlayerUtilities(Player[] myPlayers)
        {
            this.myPlayers = myPlayers;
        }

        public void SortByTeam()
        {
            for(int i =0; i<Player.GetCount()-1; i++)
            {
                int minIndex = i;
                for(int j=i+1; j<Player.GetCount(); j++)
                {
                    if(myPlayers[j].GetTeam().CompareTo(myPlayers[minIndex].GetTeam() )< 0)
                    {
                        minIndex = j;
                    }
                }

                if(minIndex!= i )
                {
                    Swap(myPlayers, minIndex, i)l
                }
            }
                    }

                    public void Swap(Player[] myPlayers, int x, int y)
                    {
                        Player temp = myPlayers[x];
                        myPlayers[x] = myPlayers[y];
                        myPlayers[y] = temp;
                    }
    }
}
