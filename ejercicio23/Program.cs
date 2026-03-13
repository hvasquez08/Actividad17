Console.WriteLine("Ingrese el primer número:");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
double numero2 = double.Parse(Console.ReadLine());

MostrarSuma(numero1, numero2);

void MostrarSuma(double a, double b)
{
    Console.WriteLine($"La suma de {a} + {b} es: {a + b}");
}
