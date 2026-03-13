Console.WriteLine("Ingrese su nombre:");
string nombre = Console.ReadLine();

Bienvenida(nombre);

void Bienvenida(string usuario)
{
    Console.WriteLine($"Bienvenido, {usuario}");
}
