//Crear una función que reciba un número en grados Celsius y devuelva el valor convertido a Fahrenheit.
//formula es: f=(c*9/5)+32
Console.WriteLine("Ingrese los grados ");
double grados = double.Parse(Console.ReadLine());
Console.WriteLine($"Los grados fahrenheit son:{convertir(grados)}");
double convertir (double a)
{
    return (a * 9 / 5)+32;
}