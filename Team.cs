using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Data_Project
{
    public abstract class Team : IComparable
    {
        //Properties
        public string Name { get; set; }
        public int YearFormed { get; set; }

        public string Manager { get; set; }

        public string Stadium { get; set; }

        public string ImagePath { get; set; }

        public List<Player> PlayerList { get; set; }



        //Constructors
        public Team(string name, int yearFormed, string manager, string stadium, string imagepath)
        {
            Name = name;
            YearFormed = yearFormed;
            Manager = manager;
            Stadium = stadium;
            ImagePath = imagepath;

            PlayerList = new List<Player>();
        }

        public Team() : this("Unknown", 0, "Unknown", "Unknown","Unknown")
        {
            PlayerList = new List<Player>();
        }

        //Methods
        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            Team otherteam = obj as Team;
            return this.Name.CompareTo(otherteam.Name);
        }
    }
    public class Prem : Team
    {
        public override string ToString()

        {
            return base.ToString() + "- Premier League";
        }
    }

    public class LaLiga : Team
    {
        public override string ToString()

        {
            return base.ToString() + "- LaLiga";
        }
    }

    public class LOI : Team
    {
        public override string ToString()

        {
            return base.ToString() + "- LOI";
        }
    }
}
