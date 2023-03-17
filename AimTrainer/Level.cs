using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Reflection.Emit;

namespace AimTrainer
{
    internal class Level
    {
        Aim aim = new Aim();
        public TextBlock timeGame = new TextBlock()
        {
            Text = "",
            FontSize = 30,
            FontFamily = new FontFamily("Kozuka Gothic Pro H")
        };
        public TextBlock timeStart = new TextBlock()
        {
            Text = "",
            FontSize = 150,
            FontFamily = new FontFamily("Kozuka Gothic Pro H")
        };
        public TextBlock timeEnd = new TextBlock()
        {
            Text = "",
            Margin = new Thickness(0),
            FontSize = 35,
            FontFamily = new FontFamily("Kozuka Gothic Pro H")
        };

        public int sec;
        public int count;
        public int secStart;
        public static int time = 10;
        public static string inf { get { return "∞"; } }

        public static int numberGoals = 1;

        async private void GameProcess(Canvas MyCanvas)
        {
            while (sec != time)
            {
                sec++;
                timeGame.Text = sec.ToString();
                await Task.Delay(1000);
            }
            aim.DeleteGoals(MyCanvas);
            timeGame.Text = "";
            timeEnd.Text = "End\n" + "Your count: " + count.ToString();

            count = 0;
            sec = 0;
        }

        async public void Start(Canvas MyCanvas)
        {
            secStart = 3;
            while (secStart != 0)
            {
                timeStart.Text = secStart.ToString();
                secStart--;
                await Task.Delay(1000);
            }
            timeStart.Text = "";
            aim.DrawGoals(MyCanvas);

            GameProcess(MyCanvas); 
        }
        public void Hit(Point p, Canvas MyCanvas)
        {
            for (int i = 0; i < numberGoals; i++)
            {
                if (p.X > aim.pointsList[i].X && p.X < aim.pointsList[i].X + aim.sizes[i] 
                    && p.Y > aim.pointsList[i].Y && p.Y < aim.pointsList[i].Y + aim.sizes[i])
                {
                    aim.DeleteGoal(MyCanvas, i);
                    aim.DrawGoal(MyCanvas, i);
                    count++;
                }
            }
            

        }
    }
}
