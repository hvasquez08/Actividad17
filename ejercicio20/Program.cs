Console.WriteLine("Ingrese la cantidad de días trabajados:");
int dias = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el pago diario:");
double pagoDiario = double.Parse(Console.ReadLine());

Console.WriteLine($"El salario total es: {SalarioTotal(dias, pagoDiario)}");

double SalarioTotal(int dias, double pagoDiario)
{
    return dias * pagoDiario;
}
