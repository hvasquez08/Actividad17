//Crear una función que reciba dos números y devuelva la suma de ambos.
Console.WriteLine("Ingrese un numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine($"La suma es:{suma(numero1,numero2)}");
double suma(double a, double b)
{
    return a + b;
}