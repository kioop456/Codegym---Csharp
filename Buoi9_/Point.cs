namespace Buoi9_
{
    internal partial class Program
    {
        public class Point
        {
            public Point()
            {
            }

            public Point(int row, int column)
            {
                this.Row = row;
                this.Column = column;
            }

            public int Row { get; set; }

            public int Column { get; set; }
        }
    }

}
