//Crear una función que reciba un número y devuelva su cuadrado.
Console.WriteLine("Ingrese un numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine($"el cuadrado es:{cuadrado(numero1)}");
double cuadrado(double a)
{
    return a * a;
}