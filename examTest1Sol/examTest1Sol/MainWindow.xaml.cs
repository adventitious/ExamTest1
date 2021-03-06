﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examTest1Sol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TeamData db = new TeamData();
        public MainWindow()
        {
            InitializeComponent();
            // hello
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from t in db.Teams
                        select t.TeamName;

            var teams = query.ToList();

            Lsb_data.ItemsSource = teams;
            Lsb_data.SelectedItem = 0;

            string teamName = teams.ElementAt(0);
            
            var players = from p in db.Players
                          where p.Team.TeamName == teamName
                          select p.Name;

            Lsb_data_2.ItemsSource = players.ToList();
         
            Student s1 = new Student() { StudentName = "qwe", StudentNumber = "zzz", GPA = 55.5, StudentImage = "images/sonic.jpg" };
            Student s2 = new Student() { StudentName = "zxc", StudentNumber = "vvv", GPA = 2.6, StudentImage = "/images/tails.png" };

            List<Student> students = new List<Student>();

            students.Add(s1);
            students.Add(s2);

            Lsb_Students.ItemsSource = students;
        }
    }

    public  class UtileFuncs
    {
        public int AddTwoNumbers( int a, int b)
        {
            return a + b;
        }
    }

    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public int TeamID { get; set; }
        public virtual Team Team { get; set; }
    }

    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Grounds { get; set; }
        public string ShirtSize { get; set; }
        public virtual List<Player> Players{ get; set; }
    }

    public class TeamData : DbContext
    {
        public TeamData() : base("MyTeamData3") { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

    public class Student
    {
        public String StudentName{ get; set; }
        public String StudentNumber{ get; set; }
        public String StudentImage{ get; set; }
        public double GPA{ get; set; }
        public String GPA_Colour 
        {
            get
            {
                if( GPA >= 40 )
                {
                    return "green";

                }   
                return "red";
            }
        }


    }
}
