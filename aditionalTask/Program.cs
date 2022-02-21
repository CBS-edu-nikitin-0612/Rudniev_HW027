using System;

namespace aditionalTask
{
    struct Point
    {
        private int x, y, z;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public Point(int x) : this(x, 1, 1) { }
        public Point(int x, int y) : this(x, y, 1) { }
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point A, Point B)
            => new Point(A.X + B.X, A.Y + B.Y, A.Z + B.Z);

        public override string ToString()
            => $"{nameof(Point)}: x = {this.x}, y = {this.y}, z = {this.z}.";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point C = new Point(2, 2, 2) + new Point(3, 3, 3);
            Console.WriteLine(C);
        }
    }
}
