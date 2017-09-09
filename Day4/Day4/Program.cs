using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[2];

            players[0] = new Player();
            players[0].id = "blue";
            players[0].name = "블루";
            players[0].hp = 100;
            players[0].attack = 100;
            players[0].moveSpeed = 1;

            players[1] = new Player();
            players[1].id = "lycan";
            players[1].name = "라이칸";
            players[1].hp = 50;
            players[1].attack = 10;
            players[1].moveSpeed = 5;

            players[0].Move();
            players[1].Move();


            Monster[] mosters = new Monster[4];
            mosters[0] = new Monster();
            mosters[0].name = "";
            mosters[0].hp = 0;
            mosters[0].attack = 0;
            mosters[0].moveSpeed = 3;


        }

        static int PlusTwoNum(int a, int b)
        {
            return a + b;
        }


        static float PlusTwoNum(float a, float b)
        {
            return a + b;
        }
    }
}
