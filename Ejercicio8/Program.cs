//Crear una función que reciba tres números y devuelva el promedio de los tres.
//le meti un for xq me aburro 
double suma = 0;
for (int i = 1; i<=3; i++)
{
    Console.WriteLine("Ingrese un numero");
    double numero = double.Parse(Console.ReadLine());
    suma += numero;

}
Console.WriteLine($"el promedio es{promedio(suma)}");
double promedio(double a)
{
    return a / 3;
}