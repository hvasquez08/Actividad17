//Crear una función que reciba un número y devuelva su doble.
Console.WriteLine("Ingrese un numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine($"el doble es:{cuadrado(numero1)}");
double cuadrado(double a)
{
    return a * 2;
}