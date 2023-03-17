using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace AimTrainer
{
    public class Aim
    {
        public int amountGoals = Level.numberGoals;
        public int size { get; private set; }

        Random random = new Random();
        private Ellipse goal;
        private List<Ellipse> goalsList = new List<Ellipse>();
        public List<Point> pointsList = new List<Point>();
        public List<int> sizes = new List<int>();

        public int x { get; private set; }
        public int y { get; private set; }

        public void DeleteGoals(Canvas MyCanvas)
        {
            for (int i = 0; i < amountGoals; i++)
            {
                MyCanvas.Children.Remove(goalsList[i]);
                pointsList[i] = new Point(-100, -100); ;
            }
        }

        public void DeleteGoal(Canvas MyCanvas, int index)
        {
            MyCanvas.Children.Remove(goalsList[index]);
            x = -100;
            y = -100;
        }

        public void DrawGoals(Canvas MyCanvas)
        {
            for (int i = 0; i < amountGoals; i++)
            {

                size = random.Next(40, 70);
                sizes.Add(size);

                goalsList.Add(new Ellipse
                {
                    Height = size,
                    Width = size,
                    StrokeThickness = 3,
                    StrokeDashArray = { 2, 2 },
                    Stroke = Brushes.Black,
                    StrokeDashCap = PenLineCap.Round,
                    Fill = Brushes.PaleVioletRed,
                });

                x = random.Next(50, 660);
                y = random.Next(50, 440);

                pointsList.Add(new Point(x, y));

                DoubleAnimation anim = new DoubleAnimation
                {
                    From = 0,
                    To = size,
                    Duration = TimeSpan.FromSeconds(0.2)
                };
                goalsList[i].BeginAnimation(Ellipse.HeightProperty, anim);
                MyCanvas.Children.Add(goalsList[i]);

                Canvas.SetLeft(goalsList[i], x - 50);
                Canvas.SetTop(goalsList[i], y - 50);
            }

        }

        public void DrawGoal(Canvas MyCanvas, int index)
        {
            size = random.Next(40, 80);
            sizes[index] = size;

            goal = new Ellipse
            {
                Height = size,
                Width = size,
                StrokeThickness = 3,
                StrokeDashArray = { 2, 2 },
                Stroke = Brushes.Black,
                StrokeDashCap = PenLineCap.Round,
                Fill = Brushes.PaleVioletRed,
            };

            goalsList[index] = goal;

            x = random.Next(50, 660);
            y = random.Next(50, 440);

            pointsList[index] = new Point(x, y);

            DoubleAnimation anim = new DoubleAnimation
            {
                From = 0,
                To = size,
                Duration = TimeSpan.FromSeconds(0.2)
            };
            goalsList[index].BeginAnimation(Ellipse.HeightProperty, anim);
            MyCanvas.Children.Add(goalsList[index]);

            Canvas.SetLeft(goalsList[index], x - 50);
            Canvas.SetTop(goalsList[index], y - 50);

        }
    }
}
