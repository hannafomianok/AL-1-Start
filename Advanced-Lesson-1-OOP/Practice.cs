using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {

            double[,] arr = new double[10, 2];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int s = 1;
                    Circle circle = new Circle(i);
                    var sCircle = circle.CalcArea();
                    Square square = new Square(i);
                    var sSquare = square.CalcArea();
                    s++;
                    arr[i, 0] = sCircle;
                    arr[i, 1] = sSquare;
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

        }




        public class Circle : Figure
        {
            private int rad;
            public Circle(int rad)
            {
                this.rad = rad;
            }
            public override double CalcArea()
            {
                return Math.PI * rad * rad;
            }
        }

        public class Square : Figure
        {
            private int a;
            public Square(int a)
            {
                this.a = a;
            }
            public override double CalcArea()
            {
                return a * a;
            }
        }

        public class Figure
        {
            public virtual double CalcArea()
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
            FuelCar car1 = new FuelCar();
            car1.Engine = 120;
            FuelCar car2 = new FuelCar();
            car2.Engine = 163;

            if (car1 > car2)
            {
                Console.WriteLine("car1 больше  car2");
            }

            if (car1 < car2)
            {
                Console.WriteLine("car1 меньше car2");
            }

            if (car1 == car2)
            {
                Console.WriteLine("car1 равна car2");
            }

            if (car1 != car2)
            {
                Console.WriteLine("car1 не равна car2");
            }
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {
        }
    }
}
