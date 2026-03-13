Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();

MostrarPromedio(nombre);

void MostrarPromedio(string estudiante)
{
    double suma = 0;
    int cantidad = 3;

    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine($"Ingrese la calificación {i}:");
        double nota = double.Parse(Console.ReadLine());
        suma += nota;
    }

    double promedio = suma / cantidad;
    Console.WriteLine($"{estudiante}, su promedio es: {promedio}");
}
