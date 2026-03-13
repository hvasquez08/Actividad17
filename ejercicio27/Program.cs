Console.WriteLine("Ingrese el precio del producto:");
double precio = double.Parse(Console.ReadLine());

MostrarPrecioConDescuento(precio);

void MostrarPrecioConDescuento(double precio)
{
    double descuento = precio * 0.10;
    double precioFinal = precio - descuento;
    Console.WriteLine($"El precio con un 10% de descuento es: {precioFinal}");
}
