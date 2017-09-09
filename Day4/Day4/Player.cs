using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day4
{
    class Player
    {
        public string id;
        public string name;
        public int hp;
        public int attack;
        public int moveSpeed;

        public void Move()
        {
            Console.WriteLine(name + " 움직임.");
        }
    }
}
