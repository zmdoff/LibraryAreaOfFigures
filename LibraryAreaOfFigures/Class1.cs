using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAreaOfFiguresProj
{
    public static class LibraryAreaOfFigures
    {
        public static double AreaOfCircle(double R)
        {
            //площадь круга = п * R^2
            return Math.PI * Math.Pow(R, 2);
        }

        public static double AreaOfTriangleOn3sides(double A, double B, double C)
        {
            //площадь треугольника по трем сторонам вычисляем по формуле Герона
            double p;
            //полупериметр
            p = (A + B + C) / 2;
            //формула Герона
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }


    }
}
