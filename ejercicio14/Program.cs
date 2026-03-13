Console.WriteLine("Ingrese la distancia recorrida (en km):");
double distancia = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo empleado (en horas):");
double tiempo = double.Parse(Console.ReadLine());

Console.WriteLine($"La velocidad promedio es: {VelocidadPromedio(distancia, tiempo)} km/h");

double VelocidadPromedio(double distancia, double tiempo)
{
    return distancia / tiempo;
}
