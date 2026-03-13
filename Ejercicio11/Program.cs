//Crear una función que reciba el peso en kilogramos y devuelva el peso en libras.
Console.WriteLine("Ingrese el peso en kilogramos");
double pesoKg = double.Parse(Console.ReadLine());

Console.WriteLine($"El peso en libras es: {ConvertirKgALibras(pesoKg)}");
double ConvertirKgALibras(double kilogramos)
{
    return kilogramos * 2.25;
}
