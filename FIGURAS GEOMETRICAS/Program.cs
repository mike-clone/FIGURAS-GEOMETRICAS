using System;

namespace FIGURAS_GEOMETRICAS
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, lado;
            Figura figura;//crear objeto
            figura = new Figura();//instanciamiento
            Figura ac2 = new Figura();
            area = figura.areaCuadrado(5);
            Console.WriteLine(area);

            Console.WriteLine("Ingrese Lado");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ac2.areaCuadrado(lado));

            //ac1.area(3);
            Console.WriteLine("Area del Circulo" + figura.areaCi(4));
            Console.Read();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Area del Circulo" + figura.areaCi(4));
            Console.Read();
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.Green;
        }
    }

    class Figura
    {
        double areaCirculo;
        double PI = 3.1415;
        public double areaCuadrado(double lado)
        {
            double ac;
            ac = lado * lado;
            return ac;
        }
        public double areaCi(int radio)
        {
            areaCirculo = PI * radio * radio;
            return areaCirculo;
        }

    }
}
