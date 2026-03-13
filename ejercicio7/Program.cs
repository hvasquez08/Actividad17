//Crear una función que reciba el precio de un producto y el porcentaje de descuento y devuelva el precio final.
Console.WriteLine("Ingrese el precio del producto");
double precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el descuento");
double descuento = double.Parse(Console.ReadLine());
Console.WriteLine($"el precio final es:{PrecioFinal(precio,descuento)}");
double PrecioFinal(double a, double b)
{
    return (a)-((a) * (b / 100));
}