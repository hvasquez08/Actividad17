Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();

Console.WriteLine($"El promedio final de {nombre} es: {PromedioFinal(nombre)}");

double PromedioFinal(string nombre)
{
    double suma = 0;
    int cantidad = 3; // tres calificaciones

    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine($"Ingrese la calificación {i}:");
        double nota = double.Parse(Console.ReadLine());
        suma += nota;
    }

    return suma / cantidad;
}
