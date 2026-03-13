Console.WriteLine("Ingrese la cantidad de estudiantes:");
int cantidad = int.Parse(Console.ReadLine());

Console.WriteLine($"El promedio del grupo es: {PromedioGrupo(cantidad)}");

double PromedioGrupo(int cantidad)
{
    double suma = 0;
    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i}:");
        double nota = double.Parse(Console.ReadLine());
        suma += nota;
    }
    return suma / cantidad;
}
