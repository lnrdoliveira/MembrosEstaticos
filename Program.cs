using System;
using System.Globalization;
namespace Course{
    class Program{

        static double Pi = 3.14;
        static void Main(String[] args){
            System.Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            System.Console.WriteLine("Circunferência: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: "+ volume.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Valor de PI: "+Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
        static double Circunferencia(double r){
            return 2.0*Pi*r;
        }
        static double Volume(double r){
            return 4.0/3.0*Pi*Math.Pow(r, 3.0);
        }
    }
}