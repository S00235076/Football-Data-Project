using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Data_Project
{
    public class Player
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int KitNumber { get; set; }
        public string Position { get; internal set; }


        //Constructors
        public Player (string name, int age, int kitnumber, string position)
        {
            Name = name;
            Age = age;
            KitNumber = kitnumber;
            Position = position;

        }

        public Player()
        {

        }

        //Methods
        public override string ToString()
        {
            return string.Format($"{Name} - Age {Age} - Kit Number {KitNumber} - Position - {Position} ");
        }
    }
}
