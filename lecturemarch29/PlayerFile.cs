
using System;
using System.IO; 

namespace lecturemarch29 
{
    public class PlayerFile
    {
        private Player[] myPlayers = new Player[20];

        string fileName;

        public PlayerFile()
        {

        }
        public PlayerFile(string fileName)
        {
            this.fileName = fileName; 
        }

        public Player[] ReadPlayer()
        {
            //complete this method **ReadPlayer()**
            StreamReader inFile = new StreamReader(fileName);
            Player.SetCount(0);

            while(line!= null)
            {
                string[] tempArray = Player.Split('#');
                
                myPlayers[Player.GetCount()] = new Player(int.Parse(tempArray[0], tempArray[1], 
                tempArray[2], double.Parse(tempArray[3])));

                Player.SetCount(Player.GetCount()+1); 
            }
            inFile.Close(); 

            return myPlayers;
        }

    }
}
