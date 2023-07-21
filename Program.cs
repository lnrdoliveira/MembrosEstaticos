using System;
using System.Globalization;
using file02;
namespace Course{
    class Program{

        static void Main(String[] args){
            Calculadora calc = new Calculadora();

            System.Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);
            System.Console.WriteLine("Circunferência: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: "+ volume.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Valor de PI: "+calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}