using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Operators
    {
        public void Start()
        {
            Point firstPoint = new Point(2, 2);
            Point secondPoint = ++firstPoint;

            Console.WriteLine(secondPoint);
            Console.WriteLine(firstPoint == secondPoint);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"X: {X}, Y: {Y}";
        public override bool Equals(object obj) => this.ToString() == obj.ToString();

        public override int GetHashCode() => this.ToString().GetHashCode();

        public static Point operator ++(Point p1) => new Point(p1.X + 1, p1.Y + 1);
        public static Point operator --(Point p1) => new Point(p1.X - 1, p1.Y - 1);
        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);
    }
}
