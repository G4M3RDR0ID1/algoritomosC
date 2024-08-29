using Retangulo_CLasse;

Console.WriteLine("Entre a largura e altura do retangulo: ");

Retangulo d = new Retangulo();



d.Largura = double.Parse(Console.ReadLine());
d.Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Area = " + d.Area().ToString("f2"));
Console.WriteLine("Perimetro = " + d.Perimetro().ToString("f2"));
Console.WriteLine("Diagonal = " + d.Diagonal().ToString("f2"));