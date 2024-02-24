using System;

namespace ClassesAndObjects
{
    internal class Angle
    {
        int degree;
        int minute;
        int second;


        public int Degree
        {
            get { return degree; }
            set { degree = value % 360; }
        }

        public int Minute
        {
            get { return minute; }
            set { minute = value % 60; }
        }

        public int Second
        {
            get { return second; }
            set { second = value % 60; }
        }

        public Angle(int degrees, int minutes, int seconds)
        {
            Degree = degrees;
            Minute = minutes;
            Second = seconds;
        }

        public double ToRadians()
        {
            double decimalDegrees = degree + (minute + second / 60) / 60;
            return decimalDegrees * Math.PI / 180;
        }

    }
}
