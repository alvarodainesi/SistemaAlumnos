Alumno alumno1 = new Alumno("Bautista", 1234);
Alumno alumno2 = new Alumno("Juan", 5678);

bool notasAlumno1 = alumno1.CargarNotas(8.5, 7.5);
bool notasAlumno2 = alumno2.CargarNotas(4, 5);

if (!notasAlumno1)
{
    Console.WriteLine("Las notas del primer alumno no son válidas.");
}

if (!notasAlumno2)
{
    Console.WriteLine("Las notas del segundo alumno no son válidas.");
}

Console.WriteLine($"Primer alumno: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
Console.WriteLine($"Segundo alumno: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

alumno1.Nombre = "Pedro";

Console.WriteLine();
Console.WriteLine("Después de cambiar el nombre del primero:");
Console.WriteLine($"Primer alumno: {alumno1.Nombre}");
Console.WriteLine($"Segundo alumno: {alumno2.Nombre}");

// Alumno alumno3 = new Alumno();
// Da error porque el constructor necesita nombre y legajo.

// alumno1.Nota1 = 47;
// Da error porque Nota1 solamente se puede modificar desde la clase.

Console.WriteLine();
Console.WriteLine($"Promedio de {alumno1.Nombre}: {alumno1.Promedio()}");
Console.WriteLine($"Está aprobado: {alumno1.EstaAprobado()}");

Console.WriteLine();
Console.WriteLine($"Promedio de {alumno2.Nombre}: {alumno2.Promedio()}");
Console.WriteLine($"Está aprobado: {alumno2.EstaAprobado()}");

alumno2.SubirNota();

Console.WriteLine();
Console.WriteLine($"Notas de {alumno2.Nombre} después de subirlas: {alumno2.Nota1} y {alumno2.Nota2}");

Console.WriteLine();
Console.WriteLine(alumno1);
Console.WriteLine(alumno2);

bool cargaInvalida = alumno1.CargarNotas(47, 8);

if (!cargaInvalida)
{
    Console.WriteLine("Las notas ingresadas no son válidas.");
}