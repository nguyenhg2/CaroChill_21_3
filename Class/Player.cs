using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroChill_13_03.Class
{
    public class Player
    {
        public string Name { get; set; }
        public Image Mark { get; set; }

        public Player(string name, Image mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
