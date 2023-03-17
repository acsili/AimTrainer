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

namespace AimTrainer
{
    public partial class PlayPage : Page
    {
        Level level = new Level();
        


        public PlayPage()
        {
            InitializeComponent();
            MyCanvas.Children.Add(level.timeGame);
            MyCanvas.Children.Add(level.timeStart);
            MyCanvas.Children.Add(level.timeEnd);
            level.Start(MyCanvas);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            level.Hit(p, MyCanvas);
        }

        private void ButtonPlayBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void ButtonRestart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlayPage());
        }
    }
}
