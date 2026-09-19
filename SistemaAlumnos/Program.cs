

Alumno alumno1 = new Alumno
{
    Nombre = "Bautista",
    Legajo = 1234,
    Nota1 = 8.5,
    Nota2 = 7.5
};

Alumno alumno2 = new Alumno
{
    Nombre = "Juan",
    Legajo = 5678,
    Nota1 = 4,
    Nota2 = 5
};

Console.WriteLine($"Primer alumno: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
Console.WriteLine($"Segundo alumno: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

alumno1.Nombre = "Pedro";

Console.WriteLine();
Console.WriteLine("Después de cambiar el nombre del primero:");
Console.WriteLine($"Primer alumno: {alumno1.Nombre}");
Console.WriteLine($"Segundo alumno: {alumno2.Nombre}");