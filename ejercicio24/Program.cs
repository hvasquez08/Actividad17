Console.WriteLine("Ingrese el radio del círculo:");
double radio = double.Parse(Console.ReadLine());

MostrarAreaCirculo(radio);

void MostrarAreaCirculo(double r)
{
    double area = 3.14 * r * r;
    Console.WriteLine($"El área del círculo con radio {r} es: {area}");
}
