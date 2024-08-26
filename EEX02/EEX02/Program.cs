using System.Globalization;

double Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double Area = Base * Altura;
double perimetro = (2 * Base) + (2 * Altura);
double diagonal = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
Console.WriteLine("AREA = " + Area.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));