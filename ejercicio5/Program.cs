//Crear una función que reciba la base y la altura de un rectángulo y devuelva su área.
//el area de un rectangulo es base x altura
Console.WriteLine("Ingrese la base");
double Base = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura");
double Altura = double.Parse(Console.ReadLine());
Console.WriteLine($"el area es:{Area(Altura,Base)}");
double Area(double a, double b)
{
    return a * b;
}