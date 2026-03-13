Console.WriteLine("Ingrese la cantidad de minutos:");
int minutos = int.Parse(Console.ReadLine());

Console.WriteLine($"Equivalente en horas: {ConvertirMinutosAHoras(minutos)}");

double ConvertirMinutosAHoras(int minutos)
{
    return minutos / 60.0;
}
