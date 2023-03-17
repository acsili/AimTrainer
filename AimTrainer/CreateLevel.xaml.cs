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
{    public partial class CreateLevel : Page
    {
        public CreateLevel()
        {
            InitializeComponent();
            if (Level.time > 130)
                textBlockGameTime.Text = "Time(sec):" + Level.inf;
            else
                textBlockGameTime.Text = $"Time(sec):{Level.time}";
            textBlockNumberGoals.Text = $"Goals:{Level.numberGoals}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
        private void Button30Sec_Click(object sender, RoutedEventArgs e)
        {
            Level.time = 30;
            textBlockGameTime.Text = $"Time(sec):{Level.time}";
        }
        private void Button120Sec_Click(object sender, RoutedEventArgs e)
        {
            Level.time = 120;
            textBlockGameTime.Text = $"Time(sec):{Level.time}";
        }

        private void Button60Sec_Click(object sender, RoutedEventArgs e)
        {
            Level.time = 60;
            textBlockGameTime.Text = $"Time(sec):{Level.time}";
        }

        private void Button10Sec_Click(object sender, RoutedEventArgs e)
        {
            Level.time = 10;
            textBlockGameTime.Text = $"Time(sec):{Level.time}";
        }

        private void ButtonInfSec_Click(object sender, RoutedEventArgs e)
        {
            textBlockGameTime.Text = "Time(sec):" + Level.inf;
            Level.time = int.MaxValue;
        }

        private void Button1Goal_Click(object sender, RoutedEventArgs e)
        {
            Level.numberGoals = 1;
            textBlockNumberGoals.Text = $"Goals:{Level.numberGoals}";
        }

        private void Button2Goal_Click(object sender, RoutedEventArgs e)
        {
            Level.numberGoals = 2;
            textBlockNumberGoals.Text = $"Goals:{Level.numberGoals}";
        }

        private void Button3Goal_Click(object sender, RoutedEventArgs e)
        {
            Level.numberGoals = 3;
            textBlockNumberGoals.Text = $"Goals:{Level.numberGoals}";
        }

        private void Button4Goal_Click(object sender, RoutedEventArgs e)
        {
            Level.numberGoals = 4;
            textBlockNumberGoals.Text = $"Goals:{Level.numberGoals}";
        }

        private void Button5Goal_Click(object sender, RoutedEventArgs e)
        {
            Level.numberGoals = 5;
            textBlockNumberGoals.Text = $"Goals:{Level.numberGoals}";
        }
    }
}
