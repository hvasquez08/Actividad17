Console.WriteLine("Ingrese el número de estudiantes en el curso:");
int cantidad = int.Parse(Console.ReadLine());

MostrarCantidadEstudiantes(cantidad);

void MostrarCantidadEstudiantes(int numero)
{
    Console.WriteLine($"En la clase hay {numero} estudiantes.");
}
