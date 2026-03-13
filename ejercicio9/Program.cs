//Crear una función que reciba el salario por hora y las horas trabajadas y devuelva el salario total.
Console.WriteLine("Ingrese las horas trabajadas");
double horas = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio por hora");
double precio = double.Parse(Console.ReadLine());
Console.WriteLine($" el precio por hora es{Salario(horas,precio)}");
double Salario(double a,double b)
{
    return a * b;
}