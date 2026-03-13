Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine(MostrarEdad(edad));

string MostrarEdad(int edad)
{
    return $"La edad ingresada es: {edad}";
}
