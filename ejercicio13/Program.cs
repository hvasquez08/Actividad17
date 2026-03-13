Console.WriteLine("Ingrese el precio del primer producto");
double precio1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el precio del segundo producto");
double precio2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el precio del tercer producto");
double precio3 = double.Parse(Console.ReadLine());

Console.WriteLine($"El total de la compra es: {TotalCompra(precio1, precio2, precio3)}");

double TotalCompra(double a, double b, double c)
{
    return a + b + c;
}
