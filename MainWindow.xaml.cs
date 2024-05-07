using System;
using System.Collections.Generic;
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

namespace Football_Data_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Team> allTeams = new List<Team>();


        public MainWindow()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //populate combobox
            string[] genres = { "All", "Premier League", "LaLiga", "LOI" };
            cbxleague.ItemsSource = genres;

            //Create Teams
            Prem b1 = new Prem() { Name = "Manchester United", YearFormed = 1878, Manager = "Eric Ten Hag", Stadium = "Old Trafford" , ImagePath= "C:\\Users\\oranc\\OneDrive - Atlantic TU\\Football Data Project\\Image\\ManUnited.png" };

            Prem b2 = new Prem() { Name = "Liverpool", YearFormed = 1892, Manager = "Jurgen Klopp", Stadium = "Anfield", ImagePath = "C:\\Users\\oranc\\OneDrive - Atlantic TU\\Football Data Project\\Image\\Lpool.png" };

            LaLiga b3 = new LaLiga() { Name = "Real Madrid ", YearFormed = 1902, Manager = "Carlo Ancelotti", Stadium = "Santiago Bernabeu", ImagePath = "C:\\Users\\oranc\\OneDrive - Atlantic TU\\Football Data Project\\Image\\RealMadrid.png" };

            LaLiga b4 = new LaLiga() { Name = "Barcelona", YearFormed = 1899, Manager = "Xavi", Stadium = "Camp Nou", ImagePath = "C:\\Users\\oranc\\OneDrive - Atlantic TU\\Football Data Project\\Image\\Barca.jpg" };

            LOI b5 = new LOI() { Name = "Sligo Rovers", YearFormed = 1928, Manager = "John Russell", Stadium = "The Showgrounds", ImagePath = "C:\\Users\\oranc\\OneDrive - Atlantic TU\\Football Data Project\\Image\\Sligo Rovers.png" };

            LOI b6 = new LOI() { Name = "Derry City", YearFormed = 1928, Manager = "Ruaidhrí Higgins", Stadium = "The Brandywell", ImagePath = "C:\\Users\\oranc\\OneDrive - Atlantic TU\\Football Data Project\\Image\\DerryCity.png" };

            //Create Players
            Player a1 = new Player() { Name = "Kobbie Mainoo", Age = 18, KitNumber = 38, Position = "Center Midfield" };

            Player a2 = new Player() { Name = "Amad Diallo", Age = 21, KitNumber = 16, Position = "Right Winger" };

            Player a3 = new Player() { Name = "Mohammed Salah", Age = 33, KitNumber = 11, Position = "Right Winger" };

            Player a4 = new Player() { Name = "Conor Bradley", Age = 20, KitNumber = 84, Position = "Right Back" };

            Player a5 = new Player() { Name = "Luka Modric", Age = 38, KitNumber = 10, Position = "Center Midfield" };

            Player a6 = new Player() { Name = "Vinicius Junior", Age = 23, KitNumber = 7, Position = "Right Winger" };

            Player a7 = new Player() { Name = "Robert Lewandowski", Age = 35, KitNumber = 9, Position = "Striker" };

            Player a8 = new Player() { Name = "Pedri", Age = 21, KitNumber = 8, Position = "Center Midfield" };

            Player a9 = new Player() { Name = "Fabrice Hartmann", Age = 23, KitNumber = 11, Position = "Right Winger" };

            Player a10 = new Player() { Name = "Simon Power", Age = 25, KitNumber = 25, Position = "Left Winger" };

            Player a11 = new Player() { Name = "Brian Maher", Age = 23, KitNumber = 1, Position = "Goalkeeper" };

            Player a12 = new Player() { Name = "Patrick Hoban", Age = 32, KitNumber = 9, Position = "Striker" };

            //Add Players to Teams
            b1.PlayerList.Add(a1);
            b1.PlayerList.Add(a2);
            b2.PlayerList.Add(a3);
            b2.PlayerList.Add(a4);
            b3.PlayerList.Add(a5);
            b3.PlayerList.Add(a6);
            b4.PlayerList.Add(a7);
            b4.PlayerList.Add(a8);
            b5.PlayerList.Add(a9);
            b5.PlayerList.Add(a10);
            b6.PlayerList.Add(a11);
            b6.PlayerList.Add(a12);



            allTeams.Add(b1);
            allTeams.Add(b2);
            allTeams.Add(b3);
            allTeams.Add(b4);
            allTeams.Add(b5);
            allTeams.Add(b6);

            allTeams.Sort();

            lbxteams.ItemsSource = allTeams;
        }

        private void lbxteams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team selectedleague = lbxteams.SelectedItem as Team;

            if (selectedleague != null)
            {
                lbxplayers.ItemsSource = selectedleague.PlayerList;

                tblkTeamInfo.Text = string.Format($" Formed in {selectedleague.YearFormed}" + $"\nManager: {selectedleague.Manager}" + $"\nStadium: {selectedleague.Stadium}");
            }
        }

        private void cbxleague_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedLeague = cbxleague.SelectedItem as string;

            List<Team> filteredList = new List<Team>();

            switch (selectedLeague)
            {
                case "All":
                    lbxteams.ItemsSource = allTeams;
                    break;

                case "Premier League":
                    foreach (Team team in allTeams)
                    {
                        if (team is Prem)

                            filteredList.Add(team);

                    }
                    lbxteams.ItemsSource = filteredList;
                    break;

                case "LaLiga":
                    foreach (Team team in allTeams)
                    {
                        if (team is LaLiga)

                            filteredList.Add(team);

                    }
                    lbxteams.ItemsSource = filteredList;
                    break;

                case "LOI":
                    foreach (Team team in allTeams)
                    {
                        if (team is LOI)

                            filteredList.Add(team);

                    }
                    lbxteams.ItemsSource = filteredList;
                    break;

            }
        }

       
    }
}