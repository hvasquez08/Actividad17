Console.WriteLine("Ingrese la base del rectángulo:");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo:");
double alturaRectangulo = double.Parse(Console.ReadLine());

MostrarAreaRectangulo(baseRectangulo, alturaRectangulo);

void MostrarAreaRectangulo(double b, double h)
{
    double area = b * h;
    Console.WriteLine($"El área del rectángulo con base {b} y altura {h} es: {area}");
}
