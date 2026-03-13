Console.WriteLine("Ingrese su nombre:");
string nombre = Console.ReadLine();

SaludoPersonalizado(nombre);

void SaludoPersonalizado(string persona)
{
    Console.WriteLine($"hola, {persona} Espero que te la pases bien hoy xd.");
}
