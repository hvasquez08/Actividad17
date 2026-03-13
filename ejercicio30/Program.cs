Console.WriteLine("Ingrese el nombre del estudiante:");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese el curso:");
string curso = Console.ReadLine();

MostrarReporte(nombre, curso);

void MostrarReporte(string estudiante, string curso)
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

    Console.WriteLine("\n--- REPORTE DEL ESTUDIANTE ---");
    Console.WriteLine($"Nombre: {estudiante}");
    Console.WriteLine($"Curso: {curso}");
    Console.WriteLine($"Promedio: {promedio}");
}
