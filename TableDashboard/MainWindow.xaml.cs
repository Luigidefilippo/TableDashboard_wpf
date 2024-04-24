using System.Text;
using System.Collections.ObjectModel; 
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TableDashboard
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            //Create Datagrid items info 

            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Lucas", Position = "Coach", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Ermione", Position = "Manager", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Chris", Position = "Stage", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "4", Character = "B", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ludovica", Position = "Stage", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "5", Character = "N", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Paolo", Position = "Stage", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "6", Character = "S", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Lucas", Position = "Coach", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "7", Character = "L", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Gigi", Position = "Coach", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "8", Character = "T", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Mirko", Position = "Leader", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "9", Character = "E", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "John ", Position = "CEO", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });
            members.Add(new Member { Number = "10", Character = "Y", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Vittoria", Position = "Coach", Email = "L.del@3emGroup.it", Phone = "415-954-1475" });

            membersDataGrid.ItemsSource = members;
        }

        //private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.ChangedButton == MouseButton.Left)
        //    {
        //        this.DragMove();
        //    }
        //}

        //private bool IsMaxximed = false;   

        //private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    if(e.ClickCount == 2) 
        //    {
        //        if( IsMaxximed )
        //        {
        //            this.WindowState = WindowState.Normal;
        //            this.Width = 1080;
        //            this.Height = 720; 

        //            this.IsMaxximed = false;

        //        }
        //        else
        //        {
        //            this.WindowState= WindowState.Maximized;

        //            IsMaxximed= true;

        //        }
        //    }

        //}


        public void Border_MoudeDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();

        }


        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }


}

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor  { get; set; }



    }
}