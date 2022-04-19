using System;

namespace InnerFactory
{
    public class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{nameof(this.x)} is {this.x} and {nameof(y)} is {this.y}";
        }
        public static class Factory // Inner class
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
}

