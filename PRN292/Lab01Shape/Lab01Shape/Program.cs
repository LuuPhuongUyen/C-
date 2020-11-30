using System;

namespace Lab01Shape
{
    class Program
    {
        public abstract class Shapes
        {
            public Shapes(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int x { get; set; }
            public int y { get; set; }
            public void Move(int newX, int newY)
            {
                x = (newX);
                y = (newY);
            }
            public void RectangleMove(int deltaX, int deltaY)
            {
                Move(deltaX + x, deltaY + x);
            }
            public abstract void Show();
        }
        public class Rectangle : Shapes
        {
            public int width { get; set; }
            public int height { get; set; }
            public Rectangle(int x, int y, int newWidth, int newHeight) : base(x, y)
            {
                width = (newWidth);
                height = (newHeight);
            }
            public override void Show()
            {
                Console.WriteLine($"Drawing a Rectangle at ({x},{y}), Width = {width}, Height = {height}");
            }
        }
        public class Circle : Shapes
        {
            public int radius { get; set; }
            public Circle(int x, int y, int newRadius) : base(x, y)
            {
                radius = (newRadius);
            }

            public override void Show()
            {
                Console.WriteLine($"Drawing a Circle at ({x},{y}), Radius = {radius}");
            }
        }
        public class Line : Shapes
        {
            public int p1 { get; set; }
            public int p2 { get; set; }
            public Line(int x, int y, int p1, int p2) : base(x, y)
            {
                this.p1 = p1;
                this.p2 = p2;
            }

            public override void Show()
            {
                Console.WriteLine($"Drawing a Line at ({x},{y}), Point 1 = {p1}, Point 2 = {p2}");
            }
        }
        static void Main(string[] args)
        {
            Shapes[] s = new Shapes[3];
            s[0] = new Rectangle(8, 8, 4, 5);
            s[1] = new Circle(8, 8, 5);
            s[2] = new Line(8, 8, 2, 3);
            for (int i = 0; i < s.Length; i++)
            {
                s[i].Show();
                s[i].RectangleMove(10, 10);
                s[i].Show();
            }
            Rectangle rect = new Rectangle(0, 0, 15, 15);
            rect.width = 30;
            rect.Show();
        }
    }
}
