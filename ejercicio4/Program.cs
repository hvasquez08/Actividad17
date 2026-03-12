//Crear una función que reciba el radio de un círculo y devuelva el área del círculo.
//la funcion es pi x radio al cuadrado oks
Console.WriteLine("Ingrese el radio");
double radio = double.Parse(Console.ReadLine());
Console.WriteLine($"el radio es{area(radio)}");
double area (double a)
{
    return (a * a)*(3.14);
}