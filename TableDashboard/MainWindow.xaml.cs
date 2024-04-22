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
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaxximed = false;   

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2) 
            {
                if( IsMaxximed )
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720; 

                    this.IsMaxximed = false;

                }
                else
                {
                    this.WindowState= WindowState.Maximized;

                    IsMaxximed= true;
                }
            }

        }
    }
}