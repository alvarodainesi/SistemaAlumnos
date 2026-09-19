Alumno alumnoEjemplo = new Alumno("Ana Pérez", 40111222, 1234);
Profesor profesor = new Profesor("Marta Díaz", 30111222, "Programación");
Preceptor preceptor = new Preceptor("Juan López", 35123456, "Primero A");

List<Persona> personas = new List<Persona>();

personas.Add(alumnoEjemplo);
personas.Add(profesor);
personas.Add(preceptor);

foreach (Persona persona in personas)
{
    Console.WriteLine(persona.Presentarse());
}

Console.WriteLine();
List<Alumno> alumnos = new List<Alumno>();

int opcion = 0;

while (opcion != 6)
{
    Console.WriteLine();
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno por legajo");
    Console.WriteLine("4. Mostrar promedio general");
    Console.WriteLine("5. Mostrar cantidad de aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elegí una opción: ");

    bool opcionValida = int.TryParse(Console.ReadLine(), out opcion);

    if (!opcionValida)
    {
        Console.WriteLine("La opción ingresada no es válida.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";
            Console.Write("Documento: ");
            bool documentoValido = int.TryParse(Console.ReadLine(), out int documento);

            Console.Write("Legajo: ");
            bool legajoValido = int.TryParse(Console.ReadLine(), out int legajo);

            Console.Write("Primera nota: ");
            bool nota1Valida = double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("Segunda nota: ");
            bool nota2Valida = double.TryParse(Console.ReadLine(), out double nota2);

            if (!documentoValido || !legajoValido || !nota1Valida || !nota2Valida)
            {
                Console.WriteLine("Alguno de los datos ingresados no es válido.");
                break;
            }

            Alumno nuevoAlumno = new Alumno(nombre, documento, legajo);

            if (nuevoAlumno.CargarNotas(nota1, nota2))
            {
                alumnos.Add(nuevoAlumno);
                Console.WriteLine("Alumno agregado.");
            }
            else
            {
                Console.WriteLine("Las notas deben estar entre 0 y 10.");
            }

            break;

        case 2:
            if (alumnos.Count == 0)
            {
                Console.WriteLine("Todavía no hay alumnos.");
            }
            else
            {
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                }
            }

            break;

        case 3:
            Console.Write("Ingresá el legajo: ");
            bool busquedaValida = int.TryParse(Console.ReadLine(), out int legajoBuscado);

            if (!busquedaValida)
            {
                Console.WriteLine("El legajo ingresado no es válido.");
                break;
            }

            Alumno? alumnoEncontrado = null;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Legajo == legajoBuscado)
                {
                    alumnoEncontrado = alumno;
                }
            }

            if (alumnoEncontrado == null)
            {
                Console.WriteLine("No existe un alumno con ese legajo.");
            }
            else
            {
                Console.WriteLine(alumnoEncontrado);
            }

            break;

        case 4:
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No se puede calcular el promedio porque no hay alumnos.");
            }
            else
            {
                double sumaPromedios = 0;

                foreach (Alumno alumno in alumnos)
                {
                    sumaPromedios = sumaPromedios + alumno.Promedio();
                }

                double promedioGeneral = sumaPromedios / alumnos.Count;
                Console.WriteLine($"Promedio general: {promedioGeneral}");
            }

            break;

        case 5:
            int cantidadAprobados = 0;

            foreach (Alumno alumno in alumnos)
            {
                if (alumno.EstaAprobado())
                {
                    cantidadAprobados++;
                }
            }

            Console.WriteLine($"Cantidad de aprobados: {cantidadAprobados}");
            break;

        case 6:
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("La opción ingresada no existe.");
            break;
    }
}