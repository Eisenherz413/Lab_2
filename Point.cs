using System;
using System.Collections.Generic;
using System.Text;

namespace If_Switch
{
    class Point
    {
        double X { get; set; }
        double Y { get; set; }
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void MoveX(double xValue) //переміщення по осі X
        {
            X += xValue;
        }
        public void MoveY(double yValue) //переміщення по осі Y
        {
            Y += yValue;
        }
        public void ToTheBeginning() //визначення відстані до початку координат
        {
            double xDistance = this.X;
            double YDistance = this.Y;
        }
        public double Difference(Point B) //відстань між двома точками
        {
            double distance;
            return distance = Math.Sqrt(Math.Pow(B.X-this.X, 2) + Math.Pow(B.Y-this.Y, 2));
        }
        public void Convertation() //перетворення в полярні координати
        {
            double r = Math.Sqrt(Math.Pow(Y, 2) + Math.Pow(X, 2));
            double sinFi = Y / r;
            double cosFi = X / r;
        }

    }
}
