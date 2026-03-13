Console.WriteLine("Ingrese la cantidad de productos:");
int cantidad = int.Parse(Console.ReadLine());

Console.WriteLine($"El total de la factura es: {TotalFactura(cantidad)}");

double TotalFactura(int cantidad)
{
    double total = 0;
    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine($"Ingrese el precio del producto {i}:");
        double precio = double.Parse(Console.ReadLine());
        total += precio;
    }
    return total;
}
