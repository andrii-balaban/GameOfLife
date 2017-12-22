using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using GameOfLife.Core.DomainObjects;
using GameOfLife.ViewModels;

namespace GameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IWorldView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetupWorld(World world)
        {
            DataContext = new WorldViewModel(world, this);
        }

        public void Run()
        {
            Show();
        }

        public void Draw(World world)
        {
            var filed = world.GetFiled();

            for (int xIndex = 0; xIndex < world.GetWidth(); xIndex++)
            {
                for (int yIndex = 0; yIndex < world.GetHeight(); yIndex++)
                {
                    DrawCell(filed[xIndex, yIndex]);
                }
            }
        }

        private void DrawCell(Cell cell)
        {
            Rectangle rectangle = GetCellRectangle(cell);
            WorldCanvas.Children.Add(rectangle);
        }

        private static Rectangle GetCellRectangle(Cell cell)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = 3,
                Height = 3,
                Fill = new SolidColorBrush(GetCellColor(cell))
            };

            Canvas.SetLeft(rectangle, cell.X * 3);
            Canvas.SetTop(rectangle, cell.Y * 3);
            return rectangle;
        }

        private static Color GetCellColor(Cell cell)
        {
            return cell.IsAlive() ? Color.FromRgb(255, 0, 0) : Color.FromRgb(255, 255, 255);
        }
    }
}
