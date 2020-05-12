using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
            // hello
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
        public virtual List<Player> Players{ get; set; }
    }

    public class TeamData : DbContext
    {
        public TeamData() : base("MyTeamData3") { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
