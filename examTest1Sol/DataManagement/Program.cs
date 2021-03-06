﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examTest1Sol;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            TeamData db = new TeamData();

            using (db)
            {
                Team t1 = new Team() { TeamID = 1, TeamName = "Sligo Rovers", Grounds = "ShowGrounds" };

                Player p1 = new Player() { PlayerID = 1, Name = "Tom", Position = "forward", TeamID = 1, Team = t1 };
                Player p2 = new Player() { PlayerID = 2, Name = "Mick", Position = "defender", TeamID = 1, Team = t1 };

                Team t2 = new Team() { TeamID = 2, TeamName = "Finn Harps", Grounds = "Donegal" };

                Player p3 = new Player() { PlayerID = 1, Name = "Sam", Position = "midfield", TeamID = 2, Team = t2 };
                Player p4 = new Player() { PlayerID = 2, Name = "Jim", Position = "goalkeeper", TeamID = 2, Team = t2 };

                db.Teams.Add(t1);
                db.Teams.Add(t2);

                Console.WriteLine("Added teams to db");

                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);

                Console.WriteLine("Added players to db");

                db.SaveChanges();

                Console.WriteLine("Saved to database");
            }
        }
    }
}
