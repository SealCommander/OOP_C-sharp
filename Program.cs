using System;

namespace TriangleApp
{
    internal class Triangle
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = c;
            this.c = c;
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public string GetTypeOfTriangle()
        {
            if (a == b && b == c)
                return "Равносторонний треугольник";
            else if (a == b || b == c || a == c)
                return "Равнобедренный треугольник";
            else if (IsRightTriangle())
                return "Прямоугольный треугольник";
            else
                return "Разносторонний треугольник";
        }

        private bool IsRightTriangle()
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-6;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Сторона a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Сторона b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Сторона c: ");
                double c = double.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(a, b, c);

                Console.WriteLine($"Периметр: {triangle.GetPerimeter():F2}");
                Console.WriteLine($"Площадь: {triangle.GetArea():F2}");
                Console.WriteLine($"Тип треугольника: {triangle.GetTypeOfTriangle()}");
           
        }
    }
}