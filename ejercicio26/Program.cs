Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

MostrarAnioNacimiento(edad);

void MostrarAnioNacimiento(int edad)
{
    int anioActual = DateTime.Now.Year;
    int anioNacimiento = anioActual - edad;
    Console.WriteLine($"Su año aproximado de nacimiento es: {anioNacimiento}");
}
