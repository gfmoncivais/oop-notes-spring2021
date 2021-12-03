using System;

namespace lecturemarch29
{
    public class Player
    {
        private int id;
        private string name;
        private string team;
        private double battingAvg; 
        private static int count; 
        //we copied the input.txt file Jeff has on Teams 
        private Player[] myPlayers = new Player[20]; // new array for the players 

        public Player() //Default Constructor
        {

        }
        public Player(int id,string name, string team, double battingAvg)
        {
        this.id = id;
        this.name = name;
        this.team = team; 
        this.battingAvg = battingAvg;
        }

    public void SetId(int id)
    {
        this.id = id;
    }
    public int GetID()
    {
        return id; 
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name; 
    }
    public void SetTeam(string team)
    {
        this.team = team;
    }
    public string GetTeam()
    {
        return team;
    }
        public double SetBattingAvg(double battingAvg) => this.battingAvg = battingAvg;
        public double GetBattingAvg()
    {
        return battingAvg;
    }
    public static void SetCount(int count)
    {
        Player.count = count;
    }
    public int GetCount()
    {
        return Player.count;
    }
        public override string ToString()
        {
            return id + "\t" + name + "\t" + team + "\t" + battingAvg;
        }

    }


}
