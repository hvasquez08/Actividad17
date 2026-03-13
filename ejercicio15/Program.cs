Console.WriteLine("Ingrese la base del triángulo:");
double baseTriangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del triángulo:");
double alturaTriangulo = double.Parse(Console.ReadLine());

Console.WriteLine($"El área del triángulo es: {AreaTriangulo(baseTriangulo, alturaTriangulo)}");

double AreaTriangulo(double b, double h)
{
    return (b * h) / 2;
}
